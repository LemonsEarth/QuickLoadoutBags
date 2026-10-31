using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public class SummonBag1 : Bag
{
    public override int Rarity => ItemRarityID.Blue;
    public override List<int> Items => new()
    {
        JungleHat,
        FlinxFurCoat,
        JunglePants,

        FeralClaws,

        ThornWhip,
        FlinxStaff,
    };
}
