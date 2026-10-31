using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class MagicBag1 : Bag
{
    public override int Rarity => ItemRarityID.Blue;
    public override List<int> Items => new()
    {
        JungleHat,
        JungleShirt,
        JunglePants,

        CelestialCuffs,
        ManaFlower,

        DiamondStaff,
        Vilethorn,
    };
}
