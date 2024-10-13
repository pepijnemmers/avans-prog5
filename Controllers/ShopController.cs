using Microsoft.AspNetCore.Mvc;

namespace NinjaApp.Controllers;

public class ShopController : Controller
{
    public IActionResult Index(Guid ninjaId)
    {
        return View();
    }
}