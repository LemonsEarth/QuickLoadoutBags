using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class RangerBag5 : Bag
{
    public override int Rarity => ItemRarityID.Red;
    public override List<int> Items => new()
    {
        VortexHelmet,
        VortexBreastplate,
        VortexLeggings,

        RangerEmblem,
        SniperScope,
        
        SDMG,
        Celeb2,
    };
}
