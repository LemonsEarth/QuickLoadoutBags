namespace QuickLoadoutBags.Content.Items.Bags;

public class PotionBag : ModItem
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
         itemLoot.Add(ItemDropRule.Common(RegenerationPotion, 1, 30, 30));
         itemLoot.Add(ItemDropRule.Common(IronskinPotion, 1, 30, 30));
         itemLoot.Add(ItemDropRule.Common(SwiftnessPotion, 1, 30, 30));
         itemLoot.Add(ItemDropRule.Common(EndurancePotion, 1, 30, 30));
         itemLoot.Add(ItemDropRule.Common(LifeforcePotion, 1, 30, 30));
         itemLoot.Add(ItemDropRule.Common(ShinePotion, 1, 30, 30));
         itemLoot.Add(ItemDropRule.Common(MagicPowerPotion, 1, 30, 30));
         itemLoot.Add(ItemDropRule.Common(ManaRegenerationPotion, 1, 30, 30));
         itemLoot.Add(ItemDropRule.Common(SummoningPotion, 1, 30, 30));
    }
}
