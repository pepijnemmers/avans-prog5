using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjaApp.Models;
using NinjaApp.Models.Enums;
using NinjaApp.ViewModels;

namespace NinjaApp.Controllers;

public class ShopController : MainController
{
    public IActionResult Index(Guid ninjaId, SlotCategory? category = null)
    {
        var ninja = GetNinjaFromId(ninjaId);
        var allNinjas = Context.Ninjas
            .OrderBy(nj => nj.Name)
            .Include(nj => nj.Inventory)
            .ThenInclude(item => item.Equipment)
            .ToList();
        var allEquipment = Context.Equipments
            .OrderBy(eq => eq.Name)
            .ToList();
        var slotCategories = Enum.GetValues<SlotCategory>().ToList();
        var selectedSlot = category;
        var orders = Context.Orders
            .Where(o => o.NinjaId == ninjaId)
            .ToList();

        var viewModel = new ShopViewModel()
        {
            Ninja = ninja,
            AllNinjas = allNinjas,
            AllEquipment = allEquipment,
            SlotCategories = slotCategories,
            SelectedSlotCategory = selectedSlot,
            Orders = orders
        };
        
        return View(viewModel);
    }

    public IActionResult Buy(Guid ninjaId, Guid equipmentId)
    {
        var ninja = GetNinjaFromId(ninjaId);
        var equipment = Context.Equipments.Find(equipmentId);
        
        if (ninja == null || equipment == null)
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het verkopen van het item.";
            return RedirectToAction("Index", new { ninjaId, equipment?.Category });
        }
        
        // check if the ninja already has equipment of the same category
        var currentInventoryItem = ninja.Inventory.FirstOrDefault(item => item.Equipment.Category == equipment.Category);
        if (currentInventoryItem != null)
        {
            TempData["ErrorMessage"] = $"De ninja heeft al een item van de categorie {equipment.Category}. Verkoop eerst het huidige item voordat je een nieuwe koopt.";
            return RedirectToAction("Index", new { ninjaId, equipment?.Category });
        }
        
        // Check if the ninja has enough gold
        if (ninja.Gold < equipment.Price)
        {
            TempData["ErrorMessage"] = $"De ninja heeft niet genoeg goud om {equipment.Name} te kopen.";
            return RedirectToAction("Index", new { ninjaId, equipment?.Category });
        }
        
        try
        {
            // create order
            var order = new Order()
            {
                NinjaId = ninjaId,
                EquipmentId = equipmentId,
                Price = equipment.Price
            };
            Context.Orders.Add(order);
            
            // add equipment to inventory
            var inventoryItem = new InventoryItem()
            {
                NinjaId = ninjaId,
                EquipmentId = equipmentId
            };
            ninja.Inventory.Add(inventoryItem);
            
            // remove gold from ninja
            ninja.Gold -= equipment.Price;
            
            Context.SaveChanges();
            TempData["SuccessMessage"] = $"Het item {equipment.Name} is gekocht en toegevoegd aan de inventory.";
        }
        catch
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het kopen van het item.";
        }
        
        return RedirectToAction("Index", new { ninjaId, equipment?.Category });
    }
    
    public IActionResult Sell(Guid ninjaId, Guid equipmentId)
    {
        var ninja = GetNinjaFromId(ninjaId);
        var equipment = Context.Equipments.Find(equipmentId);
        
        if (ninja == null || equipment == null)
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het verkopen van het item.";
            return RedirectToAction("Index", new { ninjaId, equipment?.Category });
        }

        try
        {
            var inventoryItem = ninja.Inventory.FirstOrDefault(item => item.EquipmentId == equipmentId);
            bool refundFinished = RefundGoldFromOrder(ninja.Id, equipment.Id);
            if (!refundFinished || inventoryItem == null)
            {
                throw new Exception();
            }
            
            ninja.Inventory.Remove(inventoryItem);
            Context.SaveChanges();
            TempData["SuccessMessage"] = $"Het item {equipment.Name} is verkocht.";
        }
        catch
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het verkopen van het item.";
        }
        
        return RedirectToAction("Index", new { ninjaId, equipment?.Category });
    }
}