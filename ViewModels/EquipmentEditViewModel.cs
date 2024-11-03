using NinjaApp.Models;

namespace NinjaApp.ViewModels;

public class EquipmentEditViewModel
{
    public required Equipment Equipment { get; set; }
    public List<InventoryItem>? UsedBy { get; set; }
}