using Microsoft.AspNetCore.Mvc;
using NinjaApp.Models;

namespace NinjaApp.Controllers;

public class HomeController : MainController
{
    [Route("")][Route("home")][Route("home/index")][Route("ninjas")]
    public IActionResult Index(string? search)
    {
        var ninjas = GetNinjas(search);
        if (search != null) ViewBag.Search = search;
        return View(ninjas);
    }
    
    private List<Ninja> GetNinjas(string? search = null)
    {
        if (search != null)
        {
            return Context.Ninjas.ToList().Where(ninja => ninja.Name.ToLower().Contains(search.ToLower())).ToList();
        } 
        return Context.Ninjas.ToList();
    }

    [HttpGet][Route("ninjas/new")]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost][Route("ninjas/new")]
    public IActionResult Create(string Name, int Gold)
    {
        Ninja ninja = new(Guid.NewGuid(), Name, Gold, new List<InventoryItem>());
        
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