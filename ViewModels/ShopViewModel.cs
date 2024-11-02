using NinjaApp.Models;

namespace NinjaApp.ViewModels;

public class ShopViewModel
{
    public Ninja? Ninja { get; set; }
    public List<Ninja>? AllNinjas { get; set; }
    public List<Equipment>? AllEquipment { get; set; }
    public List<SlotCategory> SlotCategories { get; set; } = null!;
    public SlotCategory? SelectedSlotCategory { get; set; }
    public List<Order>? Orders { get; set; }
}