using System.ComponentModel.DataAnnotations;
using NinjaApp.Models.Enums;

namespace NinjaApp.Models;

public class Ninja
{
    [Key] public Guid Id { get; set; }
    [Required][StringLength(255)] public string Name { get; set; } = null!;
    [Required] public int Gold { get; set; }
    [Required] public List<InventoryItem> Inventory { get; set; } = null!;

    /// <summary>
    ///     Get the inventory item for a specific slot
    /// </summary>
    /// <param name="slot">The category to get the inventory item for</param>
    /// <returns>InventoryItem or null</returns>
    public InventoryItem? GetInventoryItem(SlotCategory slot)
    {
        return Inventory?.FirstOrDefault(item => item.Equipment.Category == slot);
    }
    
    /// <summary>
    ///     Get the total gear value of the ninja
    /// </summary>
    /// <returns>int</returns>
    public int GetTotalGearValue()
    {
        return GetTotalGearAgility() + GetTotalGearStrength() + GetTotalGearIntelligence();
    }
    
    /// <summary>
    ///     Get the total gear agility of the ninja
    /// </summary>
    /// <returns>int</returns>
    public int GetTotalGearAgility()
    {
        return Inventory?.Sum(item => item.Equipment.Agility) ?? 0;
    }
    
    /// <summary>
    ///     Get the total gear strength of the ninja
    /// </summary>
    /// <returns>int</returns>
    public int GetTotalGearStrength()
    {
        return Inventory?.Sum(item => item.Equipment.Strength) ?? 0;
    }
    
    /// <summary>
    ///     Get the total gear intelligence of the ninja
    /// </summary>
    /// <returns>int</returns>
    public int GetTotalGearIntelligence()
    {
        return Inventory?.Sum(item => item.Equipment.Intelligence) ?? 0;
    }
    
    /// <summary>
    ///     Get the total gear price of the ninja
    /// </summary>
    /// <returns>int</returns>
    public int GetTotalGearPrice()
    {
        return Inventory?.Sum(item => item.Equipment.Price) ?? 0;
    }
}