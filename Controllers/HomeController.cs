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
            .OrderBy(ninja => ninja.Name).ToList();
        
        // todo include inventory toevoegen 
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
            ViewBag.ErrorMessage = "De naam mag niet leeg zijn en de goudwaarde moet groter zijn dan 0 en kleiner dan 999999.";
            return Create();
        }
        
        Ninja ninja = new(Guid.NewGuid(), name, gold, new List<InventoryItem>());
        
        // add to database
        using var transaction = Context.Database.BeginTransaction();
        try
        {
            Context.Ninjas.Add(ninja);
            Context.SaveChanges();
            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();
        }
        
        return RedirectToAction("Index");
    }
    
}