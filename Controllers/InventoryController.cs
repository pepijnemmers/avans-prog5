using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjaApp.Models;

namespace NinjaApp.Controllers;

public class InventoryController : MainController
{
    /// <summary>
    ///     Shows the inventory of a ninja.
    /// </summary>
    /// <param name="ninjaId"> The id of the ninja. </param>
    /// <returns> The view with the inventory of the ninja. </returns>
    [HttpGet][Route("Inventory/{ninjaId}")][Route("Inventory/Index/{ninjaId}")]
    public IActionResult Index(Guid ninjaId)
    {
        var ninja = GetNinjaFromId(ninjaId);
        if (ninja == null)
        {
            TempData["ErrorMessage"] = "De ninja kon niet gevonden worden.";
            return RedirectToAction("Index", "Home");
        }
        
        return View(ninja);
    }
    
    /// <summary>
    ///     Edit the name and gold of a ninja.
    /// </summary>
    /// <param name="id"> The id of the ninja. </param>
    /// <returns> The view with the form to edit the ninja. </returns>
    [HttpGet]
    public IActionResult Edit(Guid id)
    {
        var ninja = GetNinjaFromId(id);
        if (ninja == null)
        {
            TempData["ErrorMessage"] = "De ninja kon niet gevonden worden.";
            return RedirectToAction("Index", "Home");
        }
        
        return View(ninja);
    }
    
    /// <summary>
    ///     Clear the inventory of a ninja.
    /// </summary>
    /// <param name="id"> The id of the ninja. </param>
    /// <returns> The view with the inventory of the ninja. </returns>
    [HttpGet][Route("/Inventory/ClearAll/{id:guid}")]
    public IActionResult ClearAll(Guid id)
    {
        var ninja = GetNinjaFromId(id);
        if (ninja == null)
        {
            TempData["ErrorMessage"] = "De ninja kon niet gevonden worden.";
            return RedirectToAction("Index", "Home");
        }
        
        if (ninja.Inventory.Count == 0)
        {
            TempData["ErrorMessage"] = "De inventory van deze ninja is al leeg.";
            return RedirectToAction("Index", new { ninjaId = id });
        }

        try
        {
            bool refundFinished = true;
            foreach (var inventoryItem in ninja.Inventory)
            {
                bool refunded = RefundGoldFromOrder(ninja.Id, inventoryItem.Equipment.Id);
                if (!refunded)
                {
                    refundFinished = false;
                    break;
                }
            }
            
            if (!refundFinished)
            {
                TempData["ErrorMessage"] = "Er is iets misgegaan bij het terugbetalen van de items.";
                return RedirectToAction("Index", new { ninjaId = id });
            }
            
            ninja.Inventory.Clear();
            Context.SaveChanges();
            TempData["SuccessMessage"] = $"De inventory van {ninja.Name} is leeggemaakt.";
        }
        catch
        {
            TempData["ErrorMessage"] = "Er is iets misgegaan bij het leegmaken van de inventory.";
        }
        return RedirectToAction("Index", new { ninjaId = id });
    }
}