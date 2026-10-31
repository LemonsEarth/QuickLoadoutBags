using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class MagicBag3 : Bag
{
    public override int Rarity => ItemRarityID.LightRed;
    public override List<int> Items => new()
    {
        TitaniumHeadgear,
        TitaniumBreastplate,
        TitaniumLeggings,

        SorcererEmblem,
        ManaCloak,

        SkyFracture,
        MeteorStaff,
    };
}
