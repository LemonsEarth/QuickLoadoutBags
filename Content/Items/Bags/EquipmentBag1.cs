using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class EquipmentBag1 : Bag
{
    public override int Rarity => ItemRarityID.Blue;
    public override List<int> Items => new()
    {
        HermesBoots,
        BlizzardinaBottle,
        SandstorminaBottle,
        FrogLeg,
        DiamondHook,
        ShadowOrb,
        SilverPickaxe,
        SilverAxe
    };
}
