using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class RangerBag2 : Bag
{
    public override int Rarity => ItemRarityID.Orange;
    public override List<int> Items => new()
    {
        NecroHelmet,
        NecroBreastplate,
        NecroGreaves,

        SharkToothNecklace,
        
        PhoenixBlaster,
        HellwingBow,
    };
}
