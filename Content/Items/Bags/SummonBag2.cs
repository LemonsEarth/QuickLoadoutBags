using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class SummonBag2 : Bag
{
    public override int Rarity => ItemRarityID.Orange;
    public override List<int> Items => new()
    {
        BeeHeadgear,
        BeeBreastplate,
        BeeGreaves,

        FeralClaws,
        PygmyNecklace,

        ThornWhip,
        ImpStaff,
    };
}
