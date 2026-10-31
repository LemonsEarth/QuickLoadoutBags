using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class RangerBag4 : Bag
{
    public override int Rarity => ItemRarityID.Lime;
    public override List<int> Items => new()
    {
        ChlorophyteHelmet,
        ChlorophytePlateMail,
        ChlorophyteGreaves,

        RangerEmblem,
        SniperScope,
        
        SnowmanCannon,
        ChainGun,
    };
}
