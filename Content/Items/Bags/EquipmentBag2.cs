using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class EquipmentBag2 : Bag
{
    public override int Rarity => ItemRarityID.Orange;
    public override List<int> Items => new()
    {
        AmphibianBoots,
        EoCShield,
        BundleofBalloons,
        WormScarf,
        StingerNecklace,
        DiamondHook,
        MagicLantern,
        MoltenPickaxe,
        MoltenHamaxe,
    };
}
