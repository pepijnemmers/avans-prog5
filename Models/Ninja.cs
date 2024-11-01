using System.ComponentModel.DataAnnotations;

namespace NinjaApp.Models;

public class Ninja
{
    [Key] public Guid Id { get; set; }
    [Required][StringLength(255)] public string Name { get; set; } = null!;
    [Required] public int Gold { get; set; }
    [Required] public List<InventoryItem> Inventory { get; set; } = null!;

    public InventoryItem? GetInventoryItem(SlotCategory slot)
    {
        return Inventory?.FirstOrDefault(item => item.Equipment.Category == slot);
    }
    
    public int GetTotalGearValue()
    {
        return GetTotalGearAgility() + GetTotalGearStrength() + GetTotalGearIntelligence();
    }
    
    public int GetTotalGearAgility()
    {
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