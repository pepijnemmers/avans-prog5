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
    
    [Key] public Guid Id { get; private set; }
    [Required] public SlotCategory SlotCategory { get; private set; }
    [Required] public Equipment Equipment { get; private set; } = null!;
    [Required] public Ninja Ninja { get; private set; } = null!;
}