using Microsoft.AspNetCore.Mvc;
using NinjaApp.Models;

namespace NinjaApp.Controllers;

public class InventoryController : MainController
{
    [Route("Inventory/{ninjaId}")][Route("Inventory/Index/{ninjaId}")]
    public IActionResult Index(Guid ninjaId)
    {
        Ninja? ninja = Context.Ninjas.Find(ninjaId);
        return View(ninja);
    }
    
    public IActionResult Edit(Guid ninjaId)
    {
        return View();
    }
}