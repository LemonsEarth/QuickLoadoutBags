using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class MagicBag5 : Bag
{
    public override int Rarity => ItemRarityID.Red;
    public override List<int> Items => new()
    {
        NebulaHelmet,
        NebulaBreastplate,
        NebulaLeggings,

        CelestialEmblem,
        ManaCloak,

        NebulaBlaze,
        NebulaArcanum,
    };
}
