using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NinjaApp.Models;

public class Order
{
    public Order() { } // Required for EF Core

    public Order(Guid id, Guid ninjaId, Guid equipmentId, int price)
    {
        Id = id;
        NinjaId = ninjaId;
        EquipmentId = equipmentId;
        Price = price;
    }

    [Key] public Guid Id { get; set; }
    [Required] public Guid NinjaId { get; set; }
    [ForeignKey(nameof(NinjaId))] public Ninja Ninja { get; set; } = null!;
    [Required] public Guid EquipmentId { get; set; }
    [ForeignKey(nameof(EquipmentId))] public Equipment Equipment { get; set; } = null!;
    [Required] public int Price { get; set; }
}