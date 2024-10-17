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
        // TODO : create werkt niet
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het aanmaken van het equipment.";
            ViewBag.SlotCategories = Enum.GetValues<SlotCategory>().ToList();
            return RedirectToAction("Index");
        }

        Context.Equipments.Add(equipment);
        Context.SaveChanges();
        
        return RedirectToAction("Index");
    }
    
    public IActionResult Edit(Guid id)
    {
        return View();
    }
}