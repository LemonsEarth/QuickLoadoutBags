using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class SummonBag5 : Bag
{
    public override int Rarity => ItemRarityID.Red;
    public override List<int> Items => new()
    {
        StardustHelmet,
        StardustBreastplate,
        StardustLeggings,

        PapyrusScarab,
        PygmyNecklace,

        RainbowWhip,
        StardustDragonStaff,
    };
}
