using System.ComponentModel.DataAnnotations;

namespace NinjaApp.Models;

public class Order
{
    public Order() { } // Required for EF Core
    
    public Order(Guid id, Ninja ninja, Equipment equipment, int price)
    {
        Id = id;
        Ninja = ninja;
        Equipment = equipment;
        Price = price;
    }
    
    [Key] public Guid Id { get; set; }
    [Required] public Ninja Ninja { get; set; } = null!;
    [Required] public Equipment Equipment { get; set; } = null!;
    [Required] public int Price { get; set; }
}