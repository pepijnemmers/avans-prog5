using Microsoft.AspNetCore.Mvc;
using NinjaApp.Models;
using NinjaApp.Models.Enums;
using NinjaApp.ViewModels;

namespace NinjaApp.Controllers;

public class EquipmentController : MainController
{
    /// <summary>
    ///     Returns the index view with a list of all equipment.
    /// </summary>
    /// <returns> The index view with a list of all equipment. </returns>
    public IActionResult Index()
    {
        var viewModel = new EquipmentViewModel()
        {
            Equipments = GetEquipments(),
            SlotCategories = Enum.GetValues<SlotCategory>().ToList()
        };
        
        return View(viewModel);
    }

    /// <summary>
    ///     Returns a list of all equipment.
    /// </summary>
    /// <returns> A list of all equipment. </returns>
    private List<Equipment> GetEquipments()
    {
        return Context.Equipments.ToList();
    }

    /// <summary>
    ///     Returns the create view with a list of all slot categories.
    /// </summary>
    /// <param name="category"> The selected slot category. </param>
    /// <returns> The create view with a list of all slot categories. </returns>
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
    
    /// <summary>
    ///     Creates a new equipment.
    /// </summary>
    /// <param name="equipment"> The equipment to create. </param>
    /// <returns> A redirect to the index view. </returns>
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
    
    /// <summary>
    ///     Returns the edit view with a list of all slot categories.
    /// </summary>
    /// <param name="id"> The id of the equipment to edit. </param>
    /// <returns> The edit view with a list of all slot categories. </returns>
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

    /// <summary>
    ///     Updates an existing equipment.
    /// </summary>
    /// <param name="equipment"> The updated equipment. </param>
    /// <param name="id"> The id of the equipment to update. </param>
    /// <returns> A redirect to the index view. </returns>
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
    
    /// <summary>
    ///     Deletes an existing equipment.
    /// </summary>
    /// <param name="id"> The id of the equipment to delete. </param>
    /// <returns> A redirect to the index view. </returns>
    /// <exception cref="Exception"> Thrown when the refund of gold from an order fails. </exception>
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