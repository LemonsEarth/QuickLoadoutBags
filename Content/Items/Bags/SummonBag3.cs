using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class SummonBag3 : Bag
{
    public override int Rarity => ItemRarityID.LightRed;
    public override List<int> Items => new()
    {
        SpiderMask,
        SpiderBreastplate,
        SpiderGreaves,

        SummonerEmblem,
        PygmyNecklace,

        CoolWhip,
        SanguineStaff,
    };
}
