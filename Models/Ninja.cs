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
    
    [Key] public Guid Id { get; private set; }
    [Required][StringLength(255)] public string Name { get; private set; } = null!;
    [Required] public int Gold { get; private set; }
    [Required] public List<InventoryItem> Inventory { get; private set; } = null!;

    public Dictionary<SlotCategory, Equipment> GetInventory()
    {
        return Inventory.ToDictionary(item => item.SlotCategory, item => item.Equipment);
    }
    
    public int GetTotalGearValue()
    {
        return Inventory.Sum(item => item.Equipment.Agility + item.Equipment.Strength + item.Equipment.Intelligence);
    }
    
    public int GetTotalGearAgility()
    {
        return Inventory.Sum(item => item.Equipment.Agility);
    }
    
    public int GetTotalGearStrength()
    {
        return Inventory.Sum(item => item.Equipment.Strength);
    }
    
    public int GetTotalGearIntelligence()
    {
        return Inventory.Sum(item => item.Equipment.Intelligence);
    }
}