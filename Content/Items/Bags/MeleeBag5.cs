using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class MeleeBag5 : Bag
{
    public override int Rarity => ItemRarityID.Red;
    public override List<int> Items => new()
    {
        SolarFlareHelmet,
        SolarFlareBreastplate,
        SolarFlareLeggings,

        FireGauntlet,
        WarriorEmblem,
        
        Meowmere,
        StarWrath,
    };
}
