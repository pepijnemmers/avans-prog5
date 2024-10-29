using System.ComponentModel.DataAnnotations;

namespace NinjaApp.Models;

public class Ninja
{
    public Ninja() { } // Required for EF Core
    
    public Ninja(Guid id, string name, int gold, List<InventoryItem> inventory)
    {
        Id = id;
        Name = name;
        Gold = gold;
        Inventory = inventory;
    }
    
    [Key] public Guid Id { get; set; }
    [Required][StringLength(255)] public string Name { get; set; } = null!;
    [Required] public int Gold { get; set; }
    [Required] public List<InventoryItem> Inventory { get; set; } = null!;

    public Dictionary<SlotCategory, Equipment> GetInventory()
    {
        return Inventory.ToDictionary(item => item.SlotCategory, item => item.Equipment);
    }
    
    public int GetTotalGearValue()
    {
        return GetTotalGearAgility() + GetTotalGearStrength() + GetTotalGearIntelligence();
    }
    
    public int GetTotalGearAgility()
    {
        // TODO! in the inventory, the equipment is null
        return Inventory?.Sum(item => item.Equipment.Agility) ?? 0;
    }
    
    public int GetTotalGearStrength()
    {
        return Inventory?.Sum(item => item.Equipment.Strength) ?? 0;
    }
    
    public int GetTotalGearIntelligence()
    {
        return Inventory?.Sum(item => item.Equipment.Intelligence) ?? 0;
    }
}