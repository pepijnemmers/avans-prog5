using System.ComponentModel.DataAnnotations;

namespace NinjaApp.Models;

public class InventoryItem
{
    public InventoryItem() { } // Required for EF Core
    
    public InventoryItem(Guid id, SlotCategory slotCategory, Equipment equipment, Ninja ninja)
    {
        Id = id;
        SlotCategory = slotCategory;
        Equipment = equipment;
        Ninja = ninja;
    }
    
    [Key] public Guid Id { get; set; }
    [Required] public SlotCategory SlotCategory { get; set; }
    [Required] public Equipment Equipment { get; set; } = null!;
    [Required] public Ninja Ninja { get; set; } = null!;
}