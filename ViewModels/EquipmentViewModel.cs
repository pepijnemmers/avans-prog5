using NinjaApp.Models;
using NinjaApp.Models.Enums;

namespace NinjaApp.ViewModels;

public class EquipmentViewModel
{
    public required List<Equipment>? Equipments { get; set; }
    public required List<SlotCategory> SlotCategories { get; set; }
}