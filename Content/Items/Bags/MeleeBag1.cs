using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class MeleeBag1 : Bag
{
    public override int Rarity => ItemRarityID.Blue;
    public override List<int> Items => new()
    {
        PlatinumHelmet,
        PlatinumChainmail,
        PlatinumGreaves,

        FeralClaws,
        
        BladeofGrass,
        Starfury,
    };
}
