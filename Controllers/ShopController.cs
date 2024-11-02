using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjaApp.Models;
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
        
        // TODO
        
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
            bool refundFinished = RefundGoldFromOrder(ninja, equipment);
            if (!refundFinished || inventoryItem == null)
            {
                throw new();
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