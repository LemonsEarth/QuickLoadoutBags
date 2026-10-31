using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class SummonBag4 : Bag
{
    public override int Rarity => ItemRarityID.Lime;
    public override List<int> Items => new()
    {
        SpookyHelmet,
        SpookyBreastplate,
        SpookyLeggings,

        PapyrusScarab,
        PygmyNecklace,

        ScytheWhip,
        XenoStaff,
    };
}
