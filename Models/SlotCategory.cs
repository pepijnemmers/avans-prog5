namespace NinjaApp.Models;

public enum SlotCategory
{
    Head,
    Chest,
    Hand,
    Feet,
    Ring,
    Necklace
}

public static class SlotCategoryExtensions
{
    public static string ToFriendlyString(this SlotCategory slotCategory)
    {
        return slotCategory switch
        {
            SlotCategory.Head => "Head",
            SlotCategory.Chest => "Chest",
            SlotCategory.Hand => "Hand",
            SlotCategory.Feet => "Feet",
            SlotCategory.Ring => "Ring",
            SlotCategory.Necklace => "Necklace",
            _ => "Onbekend"
        };
    }
}
