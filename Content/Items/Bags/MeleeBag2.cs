using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class MeleeBag2 : Bag
{
    public override int Rarity => ItemRarityID.Orange;
    public override List<int> Items => new()
    {
        MoltenHelmet,
        MoltenBreastplate,
        MoltenGreaves,

        FeralClaws,
        
        NightsEdge,
        DarkLance,
    };
}
