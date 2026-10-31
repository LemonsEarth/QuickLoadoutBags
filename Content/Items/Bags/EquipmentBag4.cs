using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class EquipmentBag4 : Bag
{
    public override int Rarity => ItemRarityID.Lime;
    public override List<int> Items => new()
    {
        AmphibianBoots,
        MasterNinjaGear,
        MothronWings,
        AnkhShield,
        AvengerEmblem,
        QueenSlimeHook,
        QueenSlimeMountSaddle,
        Picksaw,
        Hammush,
    };
}
