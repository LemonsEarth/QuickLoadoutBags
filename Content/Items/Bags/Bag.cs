global using static Terraria.ID.ItemID;
using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Bags;

public abstract class Bag : ModItem
{
    public abstract List<int> Items { get; }
    public abstract int Rarity { get; }

    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 999;
    }

    public override void SetDefaults()
    {
        Item.width = 32;
        Item.height = 32;
        Item.rare = Rarity;
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
        foreach (int item in Items)
        {
            itemLoot.Add(ItemDropRule.Common(item));
        }
    }
}
