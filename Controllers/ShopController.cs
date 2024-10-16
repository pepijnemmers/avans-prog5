using Microsoft.AspNetCore.Mvc;

namespace NinjaApp.Controllers;

public class ShopController : MainController
{
    public IActionResult Index(Guid ninjaId)
    {
        return View();
    }
}