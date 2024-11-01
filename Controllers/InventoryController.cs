using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjaApp.Models;

namespace NinjaApp.Controllers;

public class InventoryController : MainController
{
    private Ninja GetNinjaFromId(Guid id)
    {
        var ninjas = Context.Ninjas
            .OrderBy(ninja => ninja.Name)
            .Include(ninja => ninja.Inventory)
            .ThenInclude(item => item.Equipment)
            .ToList();
        return ninjas.FirstOrDefault(ninja => ninja.Id == id)!;
    }
    
    [HttpGet][Route("Inventory/{ninjaId}")][Route("Inventory/Index/{ninjaId}")]
    public IActionResult Index(Guid ninjaId)
    {
        var ninja = GetNinjaFromId(ninjaId);
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
        var ninja = GetNinjaFromId(id);
        if (ninja == null)
        {
            TempData["ErrorMessage"] = "De ninja kon niet gevonden worden.";
            return RedirectToAction("Index", "Home");
        }
        
        return View(ninja);
    }
    
    [HttpGet][Route("/Inventory/ClearAll/{id:guid}")]
    public IActionResult ClearAll(Guid id)
    {
        var ninja = GetNinjaFromId(id);
        if (ninja == null)
        {
            TempData["ErrorMessage"] = "De ninja kon niet gevonden worden.";
            return RedirectToAction("Index", "Home");
        }

        try
        {
            // TODO: refund gold from orders and then delete the orders (in transaction to prevent partial refund (using the saveChanges is a transaction))
            // RefundGoldFromOrder(ninja.Id, equipment.Id) in main controller
            ninja.Inventory.Clear();
            Context.SaveChanges();
            TempData["SuccessMessage"] = $"De inventory van {ninja.Name} is leeggemaakt.";
        }
        catch
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het leegmaken van de inventory.";
        }
        return RedirectToAction("Index", new { ninjaId = id });
    }
}