using Microsoft.AspNetCore.Mvc;
using NinjaApp.Models;

namespace NinjaApp.Controllers;

public class InventoryController : MainController
{
    [HttpGet][Route("Inventory/{ninjaId}")][Route("Inventory/Index/{ninjaId}")]
    public IActionResult Index(Guid ninjaId)
    {
        Ninja? ninja = Context.Ninjas.Find(ninjaId);
        
        if (ninja == null)
        {
            TempData["ErrorMessage"] = "De ninja kon niet gevonden worden.";
            return RedirectToAction("Index", "Home");
        }
        
        return View(ninja);
    }
    
    [HttpGet]
    public IActionResult Edit(Guid id)
    {
        var ninja = Context.Ninjas.Find(id);
        if (ninja == null)
        {
            TempData["ErrorMessage"] = "De ninja kon niet gevonden worden.";
            return RedirectToAction("Index", "Home");
        }
        
        return View(ninja);
    }

    [HttpPost][ValidateAntiForgeryToken]
    public IActionResult Update(Ninja ninja, Guid id)
    {
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het updaten van de ninja.";
            return RedirectToAction("Index", "Home");
        }
        
        var existingNinja = Context.Ninjas.Find(id);
        if (existingNinja == null)
        {
            TempData["ErrorMessage"] = "De ninja kon niet gevonden worden.";
            return RedirectToAction("Index", "Home");
        }

        existingNinja.Name = ninja.Name;
        
        try
        {
            Context.Ninjas.Update(existingNinja);
            Context.SaveChanges();
            TempData["SuccessMessage"] = $"Ninja {existingNinja.Name} is succesvol geüpdatet.";
        }
        catch
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het updaten van de ninja.";
        }
        
        return RedirectToAction("Index", "Inventory", new { ninjaId = existingNinja.Id });
    }
}