using Microsoft.AspNetCore.Mvc;
using NinjaApp.Models;

namespace NinjaApp.Controllers;

public class HomeController : MainController
{
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

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
}