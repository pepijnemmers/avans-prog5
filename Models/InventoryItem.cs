using System.ComponentModel.DataAnnotations;

namespace NinjaApp.Models;

public class InventoryItem
{
    [Key] public Guid Id { get; set; }
    [Required] public Ninja Ninja { get; set; } = null!;
    [Required] public Equipment Equipment { get; set; } = null!;
}