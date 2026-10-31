using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class MeleeBag3 : Bag
{
    public override int Rarity => ItemRarityID.LightRed;
    public override List<int> Items => new()
    {
        TitaniumMask,
        TitaniumBreastplate,
        TitaniumLeggings,

        BerserkerGlove,
        WarriorEmblem,
        
        ShadowFlameKnife,
        DripplerFlail,
    };
}
