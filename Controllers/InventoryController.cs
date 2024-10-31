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
}