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
    public static string ToString(this SlotCategory slotCategory)
    {
        return slotCategory switch
        {
            SlotCategory.Head => "Hoofd",
            SlotCategory.Chest => "Borst",
            SlotCategory.Hand => "Hand",
            SlotCategory.Feet => "Voeten",
            SlotCategory.Ring => "Ring",
            SlotCategory.Necklace => "Ketting",
            _ => "Onbekend"
        };
    }
}
