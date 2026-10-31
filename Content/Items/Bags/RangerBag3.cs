using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class RangerBag3 : Bag
{
    public override int Rarity => ItemRarityID.LightRed;
    public override List<int> Items => new()
    {
        TitaniumHelmet,
        TitaniumBreastplate,
        TitaniumLeggings,

        RangerEmblem,
        StalkersQuiver,
        
        OnyxBlaster,
        DaedalusStormbow,
    };
}
