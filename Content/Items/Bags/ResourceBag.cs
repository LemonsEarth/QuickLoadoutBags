namespace QuickLoadoutBags.Content.Items.Bags;

public class ResourceBag : ModItem
{
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 999;
    }

    public override void SetDefaults()
    {
        Item.width = 32;
        Item.height = 32;
        Item.rare = ItemRarityID.Expert;
    }

    public override bool CanUseItem(Player player)
    {
        return false;
    }

    public override bool CanRightClick()
    {
        return true;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.Register();
    }

    public override void ModifyItemLoot(ItemLoot itemLoot)
    {
         itemLoot.Add(ItemDropRule.Common(WoodenArrow, 1, 4000, 4000));
         itemLoot.Add(ItemDropRule.Common(FrostburnArrow, 1, 4000, 4000));
         itemLoot.Add(ItemDropRule.Common(HolyArrow, 1, 4000, 4000));
         itemLoot.Add(ItemDropRule.Common(IchorArrow, 1, 4000, 4000));

        itemLoot.Add(ItemDropRule.Common(MusketBall, 1, 4000, 4000));
        itemLoot.Add(ItemDropRule.Common(CrystalBullet, 1, 4000, 4000));
        itemLoot.Add(ItemDropRule.Common(IchorBullet, 1, 4000, 4000));
        itemLoot.Add(ItemDropRule.Common(ChlorophyteBullet, 1, 4000, 4000));

        itemLoot.Add(ItemDropRule.Common(RocketIII, 1, 4000, 4000));

        itemLoot.Add(ItemDropRule.Common(HealingPotion, 1, 999, 999));
        itemLoot.Add(ItemDropRule.Common(GreaterHealingPotion, 1, 999, 999));

        itemLoot.Add(ItemDropRule.Common(ManaPotion, 1, 999, 999));
        itemLoot.Add(ItemDropRule.Common(SuperManaPotion, 1, 999, 999));

        itemLoot.Add(ItemDropRule.Common(FlaskofIchor, 1, 999, 999));
    }
}
