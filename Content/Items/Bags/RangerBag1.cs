using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class RangerBag1 : Bag
{
    public override int Rarity => ItemRarityID.Blue;
    public override List<int> Items => new()
    {
        FossilHelm,
        FossilShirt,
        FossilPants,

        SharkToothNecklace,
        
        Minishark,
        TendonBow,
    };
}
