using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjaApp.Models;

namespace NinjaApp.Controllers;

public class HomeController : MainController
{
    [Route("")][Route("home")][Route("home/index")][Route("ninjas")]
    public IActionResult Index(string? search = null)
    {
        var ninjas = GetNinjas(search);
        if (search != null) ViewBag.Search = search;
        return View(ninjas);
    }
    
    private List<Ninja> GetNinjas(string? search = null)
    {
        if (search != null)
        {
            return Context.Ninjas
                .OrderBy(ninja => ninja.Name)
                .Include(ninja => ninja.Inventory)
                .ThenInclude(item => item.Equipment)
                .Where(ninja => ninja.Name.Contains(search))
                .ToList();
        }
        
        return Context.Ninjas
            .OrderBy(ninja => ninja.Name)
            .Include(ninja => ninja.Inventory)
            .ThenInclude(item => item.Equipment)
            .ToList();
    }

    [HttpGet][Route("ninjas/new")]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost][Route("ninjas/new")]
    public IActionResult Create(string name, int gold)
    {
        // validate
        if (string.IsNullOrWhiteSpace(name) || gold < 0 || gold > 999999)
        {
            TempData["ErrorMessage"] = "De naam mag niet leeg zijn en de goudwaarde moet groter zijn dan 0 en kleiner dan 999999.";
            return Create();
        }
        
        Ninja ninja = new()
        {
            Id = Guid.NewGuid(),
            Name = name,
            Gold = gold,
            Inventory = new List<InventoryItem>()
        };
        
        // add to database
        try
        {
            Context.Ninjas.Add(ninja);
            Context.SaveChanges();
        }
        catch
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het aanmaken van de ninja.";
        }
        
        return RedirectToAction("Index");
    }
    
    [HttpPost][ValidateAntiForgeryToken]
    public IActionResult Update(Ninja ninja, Guid id)
    {
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

        existingNinja.Name = ninja.Name;
        existingNinja.Gold = ninja.Gold;
        
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
    
    [HttpGet][Route("/Home/Delete/{id:guid}")]
    public IActionResult Delete(Guid id)
    {
        var ninja = Context.Ninjas.Find(id);
        if (ninja == null)
        {
            TempData["ErrorMessage"] = "De ninja kon niet worden gevonden.";
            return RedirectToAction("Index");
        }
        
        try
        {
            Context.Ninjas.Remove(ninja);
            Context.SaveChanges();
            TempData["SuccessMessage"] = $"Ninja {ninja.Name} is succesvol verwijderd.";
        }
        catch
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het verwijderen van de ninja.";
        }
        
        return RedirectToAction("Index");
    }
}