using Microsoft.AspNetCore.Mvc;

namespace NinjaApp.Controllers;

public class EquipmentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult New()
    {
        return View();
    }
    
    public IActionResult Edit(Guid id)
    {
        return View();
    }
}