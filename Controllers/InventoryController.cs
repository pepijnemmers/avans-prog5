using Microsoft.AspNetCore.Mvc;

namespace NinjaApp.Controllers;

public class InventoryController : MainController
{
    public IActionResult Index(Guid ninjaId)
    {
        return View();
    }
    
    public IActionResult Edit(Guid ninjaId)
    {
        return View();
    }
}