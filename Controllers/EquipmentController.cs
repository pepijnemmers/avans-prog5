using Microsoft.AspNetCore.Mvc;
using NinjaApp.Models;
using NinjaApp.ViewModels;

namespace NinjaApp.Controllers;

public class EquipmentController : MainController
{
    public IActionResult Index()
    {
        var viewModel = new EquipmentViewModel()
        {
            Equipments = GetEquipments(),
            SlotCategories = Enum.GetValues<SlotCategory>().ToList()
        };
        
        return View(viewModel);
    }

    private List<Equipment> GetEquipments()
    {
        return Context.Equipments.ToList();
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