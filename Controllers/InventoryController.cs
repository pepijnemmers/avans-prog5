using Microsoft.AspNetCore.Mvc;
using NinjaApp.Models;

namespace NinjaApp.Controllers;

public class InventoryController : MainController
{
    [Route("Inventory/{ninjaId}")][Route("Inventory/Index/{ninjaId}")]
    public IActionResult Index(Guid ninjaId)
    {
        Ninja? ninja = Context.Ninjas.Find(ninjaId);
        
        if (ninja == null)
        {
            TempData["ErrorMessage"] = "De ninja kon niet gevonden worden.";
            return RedirectToAction("Index", "Home");
        }
        
        // TODO - check of juiste stats worden getoond
        return View(ninja);
    }
    
    [HttpGet][Route("Inventory/Edit/{ninjaId}")]
    public IActionResult Edit(Guid ninjaId)
    {
        Ninja? ninja = Context.Ninjas.Find(ninjaId);
        
        if (ninja == null)
        {
            TempData["ErrorMessage"] = "De ninja kon niet gevonden worden.";
            return RedirectToAction("Index", "Home");
        }
        
        return View(ninja);
    }
    
    [HttpPost]
    public IActionResult Update(Guid id, string name)
    {
        // TODO - check of de ninja wordt geupdate
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het updaten van de ninja.";
            return RedirectToAction("Index");
        }
        
        var existingNinja = Context.Ninjas.Find(id);
        if (existingNinja == null)
        {
            TempData["ErrorMessage"] = "De ninja kon niet gevonden worden.";
            return RedirectToAction("Index");
        }
        
        try
        {
            existingNinja.Name = name;
            Context.SaveChanges();
            TempData["SuccessMessage"] = $"De ninja {name} is succesvol bewerkt.";
        }
        catch
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het updaten van de ninja.";
        }
        return RedirectToAction("Index");
    }
}