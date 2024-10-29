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
            return Context.Ninjas.ToList().Where(ninja => ninja.Name.ToLower().Contains(search.ToLower())).OrderBy(ninja => ninja.Name).ToList();
        } 
        
        return Context.Ninjas
            .Include(ninja => ninja.Inventory)
            .OrderBy(ninja => ninja.Name)
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
        
        Ninja ninja = new(Guid.NewGuid(), name, gold, new List<InventoryItem>());
        
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
    
}