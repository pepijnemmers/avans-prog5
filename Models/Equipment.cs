using System.ComponentModel.DataAnnotations;

namespace NinjaApp.Models;

public class Equipment
{
    public Equipment() { } // Required for EF Core
    
    public Equipment(Guid id, string name, SlotCategory category, int price, int strength, int intelligence, int agility)
    {
        Id = id;
        Name = name;
        Category = category;
        Price = price;
        Strength = strength;
        Intelligence = intelligence;
        Agility = agility;
    }

    [Key] public Guid Id { get; private set; }
    [Required][StringLength(255)] public string Name { get; set; } = null!;
    [Required] public SlotCategory Category { get; set; }
    [Required] public int Price { get; set; }
    [Required] public int Strength { get; set; }
    [Required] public int Intelligence { get; set; }
    [Required] public int Agility { get; set; }
}