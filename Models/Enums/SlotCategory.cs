namespace NinjaApp.Models.Enums;

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
    /// <summary>
    ///     Converts the SlotCategory enum to a friendly string.
    /// </summary>
    /// <param name="slotCategory"> The SlotCategory enum. </param>
    /// <returns> A friendly string representation of the SlotCategory enum. </returns>
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
