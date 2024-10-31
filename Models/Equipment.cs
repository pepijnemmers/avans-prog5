using System.ComponentModel.DataAnnotations;

namespace NinjaApp.Models;

public class Equipment
{
    [Key] public Guid Id { get; set; }
    [Required][StringLength(255)] public string Name { get; set; } = null!;
    [Required] public SlotCategory Category { get; set; }
    [Required] public int Price { get; set; }
    [Required] public int Strength { get; set; }
    [Required] public int Intelligence { get; set; }
    [Required] public int Agility { get; set; }
}