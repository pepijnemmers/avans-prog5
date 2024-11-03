using Microsoft.AspNetCore.Mvc;
using NinjaApp.Models;
using NinjaApp.Models.Enums;
using NinjaApp.ViewModels;

namespace NinjaApp.Controllers;

public class EquipmentController : MainController
{
    public IActionResult Index()
    {
        var viewModel = new EquipmentViewModel()
        {
            Equipments = GetEquipments(),
            SlotCategories = Enum.GetValues<SlotCategory>().ToList()
        };
        
        return View(viewModel);
    }

    private List<Equipment> GetEquipments()
    {
        return Context.Equipments.ToList();
    }

    [HttpGet][Route("/equipment/new")]
    public IActionResult Create(string? category = null)
    {
        ViewBag.SlotCategories = Enum.GetValues<SlotCategory>().ToList();
        if (category != null)
        {
            ViewBag.SelectedCategory = Enum.Parse<SlotCategory>(category);
        }
        return View();
    }
    
    [HttpPost][Route("/equipment/new")]
    public IActionResult Create(Equipment equipment)
    {
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het aanmaken van het equipment.";
            ViewBag.SlotCategories = Enum.GetValues<SlotCategory>().ToList();
            return RedirectToAction("Index");
        }
        
        if (equipment.Price <= 0)
        {
            TempData["ErrorMessage"] = "De prijs van het equipment kan niet negatief of 0 zijn.";
            return RedirectToAction("Index");
        }

        try
        {
            Context.Equipments.Add(equipment);
            Context.SaveChanges();
            TempData["SuccessMessage"] = $"Equipment {equipment.Name} is succesvol aangemaakt.";
        }
        catch
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het aanmaken van het equipment.";
        }
        
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Edit(Guid id)
    {
        ViewBag.SlotCategories = Enum.GetValues<SlotCategory>().ToList();
        var equipment = Context.Equipments.Find(id);
        if (equipment == null)
        {
            TempData["ErrorMessage"] = "Het equipment kon niet worden gevonden.";
            return RedirectToAction("Index");
        }
        
        var usedBy = Context.InventoryItems.Where(i => i.EquipmentId == id).ToList();
        var viewModel = new EquipmentEditViewModel()
        {
            Equipment = equipment,
            UsedBy = usedBy
        };
        
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult Update(Equipment equipment, Guid id)
    {
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het updaten van het equipment.";
            ViewBag.SlotCategories = Enum.GetValues<SlotCategory>().ToList();
            return RedirectToAction("Index");
        }
        
        var existingEquipment = Context.Equipments.Find(id);
        if (existingEquipment == null)
        {
            TempData["ErrorMessage"] = "Het equipment kon niet worden gevonden.";
            return RedirectToAction("Index");
        }
        
        if (equipment.Price <= 0)
        {
            TempData["ErrorMessage"] = "De prijs van het equipment kan niet negatief of 0 zijn.";
            return RedirectToAction("Edit", new { id });
        }

        existingEquipment.Name = equipment.Name;
        existingEquipment.Category = equipment.Category;
        existingEquipment.Strength = equipment.Strength;
        existingEquipment.Intelligence = equipment.Intelligence;
        existingEquipment.Agility = equipment.Agility;
        existingEquipment.Price = equipment.Price;
        
        try
        {
            Context.SaveChanges();
            TempData["SuccessMessage"] = $"Equipment {equipment.Name} is succesvol bewerkt.";
        }
        catch
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het updaten van het equipment.";
        }
        
        return RedirectToAction("Index");
    }
    
    [HttpGet][Route("/Equipment/Delete/{id:guid}")]
    public IActionResult Delete(Guid id)
    {
        var equipment = Context.Equipments.Find(id);
        if (equipment == null)
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het verwijderen van het equipment.";
            return RedirectToAction("Index");
        }

        try
        {
            var orders = Context.Orders.Where(o => o.EquipmentId == id).ToList();
            foreach (var order in orders)
            {
                bool refundFinished = RefundGoldFromOrder(order.NinjaId, id);
                if (!refundFinished)
                {
                    throw new Exception();
                }
            }
            
            Context.Equipments.Remove(equipment);
            Context.SaveChanges();
            TempData["SuccessMessage"] = $"Equipment {equipment.Name} is succesvol verwijderd.";
        }
        catch
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het verwijderen van het equipment.";
        }
        
        return RedirectToAction("Index");
    }
}