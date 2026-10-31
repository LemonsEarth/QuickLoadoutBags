using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class MagicBag4 : Bag
{
    public override int Rarity => ItemRarityID.Lime;
    public override List<int> Items => new()
    {
        SpectreMask,
        SpectreRobe,
        SpectrePants,

        CelestialEmblem,
        ManaCloak,

        Razorpine,
        SpectreStaff,
    };
}
