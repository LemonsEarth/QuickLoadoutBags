using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class EquipmentBag3 : Bag
{
    public override int Rarity => ItemRarityID.LightRed;
    public override List<int> Items => new()
    {
        AmphibianBoots,
        EoCShield,
        FrozenWings,
        AnkhShield,
        CharmofMyths,
        DualHook,
        MagicLantern,
        AdamantitePickaxe,
        AdamantiteWaraxe,
    };
}
