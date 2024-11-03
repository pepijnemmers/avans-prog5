using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjaApp.Database;
using NinjaApp.Models;

namespace NinjaApp.Controllers;

public class MainController : Controller
{
    protected readonly NinjaDbContext Context = new();

    /// <summary>
    ///     Refunds the gold from an order and removes the order from the database.
    /// </summary>
    /// <param name="ninjaId"> The id of the ninja. </param>
    /// <param name="equipmentId"> The id of the equipment. </param>
    /// <returns> True if the refund was successful, false if not. </returns>
    protected bool RefundGoldFromOrder(Guid ninjaId, Guid equipmentId)
    {
        var order = Context.Orders.FirstOrDefault(o => o.NinjaId == ninjaId && o.EquipmentId == equipmentId);
        if (order == null) return false;
        
        var ninjaFromDb = Context.Ninjas.FirstOrDefault(n => n.Id == ninjaId);
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
    
    /// <summary>
    ///     Gets a ninja from the database by id.
    /// </summary>
    /// <param name="id"> The id of the ninja. </param>
    /// <returns> The ninja if found, null if not. </returns>
    protected Ninja GetNinjaFromId(Guid id)
    {
        var ninjas = Context.Ninjas
            .OrderBy(ninja => ninja.Name)
            .Include(ninja => ninja.Inventory)
            .ThenInclude(item => item.Equipment)
            .ToList();
        return ninjas.FirstOrDefault(ninja => ninja.Id == id)!;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}