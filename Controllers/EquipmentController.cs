using Microsoft.AspNetCore.Mvc;
using NinjaApp.Models;
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
    public IActionResult Create()
    {
        ViewBag.SlotCategories = Enum.GetValues<SlotCategory>().ToList();
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

        Context.Equipments.Add(equipment);
        Context.SaveChanges();
        
        TempData["SuccessMessage"] = $"Equipment {equipment.Name} is succesvol aangemaakt.";
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Edit(Guid id)
    {
        ViewBag.SlotCategories = Enum.GetValues<SlotCategory>().ToList();
        var equipment = Context.Equipments.Find(id);
        return View(equipment);
    }

    [HttpPost]
    public IActionResult Update(Equipment equipment)
    {
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het updaten van het equipment.";
            ViewBag.SlotCategories = Enum.GetValues<SlotCategory>().ToList();
            return RedirectToAction("Index");
        }

        Context.Equipments.Update(equipment);
        Context.SaveChanges();
        
        TempData["SuccessMessage"] = $"Equipment {equipment.Name} is succesvol bewerkt.";
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
        
        Context.Equipments.Remove(equipment);
        Context.SaveChanges();
        
        TempData["SuccessMessage"] = $"Equipment {equipment.Name} is succesvol verwijderd.";
        return RedirectToAction("Index");
    }
}