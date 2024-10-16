using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NinjaApp.Database;
using NinjaApp.Models;

namespace NinjaApp.Controllers;

public class MainController : Controller
{
    protected readonly NinjaDbContext Context;
    
    public MainController()
    {
        Context = new NinjaDbContext();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}