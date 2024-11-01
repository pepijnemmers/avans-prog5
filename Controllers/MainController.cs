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

    protected bool RefundGoldFromOrder(Ninja ninja, Equipment equipment)
    {
        var order = Context.Orders.FirstOrDefault(o => o.NinjaId == ninja.Id && o.EquipmentId == equipment.Id);
        if (order == null) return false;
        
        var ninjaFromDb = Context.Ninjas.FirstOrDefault(n => n.Id == ninja.Id);
        if (ninjaFromDb == null) return false;
        
        try
        {
            ninjaFromDb.Gold += order.Price;
            Context.Orders.Remove(order);
            Context.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}