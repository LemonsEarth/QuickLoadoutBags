using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class MagicBag2 : Bag
{
    public override int Rarity => ItemRarityID.Orange;
    public override List<int> Items => new()
    {
        WizardHat,
        DiamondRobe,
        MeteorLeggings,

        CelestialCuffs,
        MagnetFlower,

        Flamelash,
        ZapinatorGray,
    };
}
