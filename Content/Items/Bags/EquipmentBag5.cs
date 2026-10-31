using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class EquipmentBag5 : Bag
{
    public override int Rarity => ItemRarityID.Red;
    public override List<int> Items => new()
    {
        AmphibianBoots,
        MasterNinjaGear,
        LongRainbowTrailWings,
        AnkhShield,
        EmpressFlightBooster,
        QueenSlimeHook,
        QueenSlimeMountSaddle,
        SolarFlarePickaxe,
        LunarHamaxeSolar,
    };
}
