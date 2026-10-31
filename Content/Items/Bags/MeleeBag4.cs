using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class MeleeBag4 : Bag
{
    public override int Rarity => ItemRarityID.Lime;
    public override List<int> Items => new()
    {
        BeetleHelmet,
        BeetleScaleMail,
        BeetleLeggings,

        FireGauntlet,
        WarriorEmblem,
        
        TerraBlade,
        TheHorsemansBlade,
    };
}
