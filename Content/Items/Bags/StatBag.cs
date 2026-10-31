namespace QuickLoadoutBags.Content.Items.Bags;

public class StatBag : ModItem
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
         itemLoot.Add(ItemDropRule.Common(LifeCrystal, 1, 15, 15));
         itemLoot.Add(ItemDropRule.Common(ManaCrystal, 1, 9, 9));
         itemLoot.Add(ItemDropRule.Common(LifeFruit, 1, 20, 20));
    }
}
