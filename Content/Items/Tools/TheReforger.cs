using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace QuickLoadoutBags.Content.Items.Tools;

public class TheReforger : ModItem
{
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 999;
    }

    public override void SetDefaults()
    {
        Item.width = 40;
        Item.height = 40;
        Item.rare = ItemRarityID.Expert;
        Item.consumable = false;
    }

    public override bool CanUseItem(Player player)
    {
        return false;
    }

    public override bool CanRightClick()
    {
        return true;
    }

    public override bool ConsumeItem(Player player)
    {
        return false;
    }

    public override void RightClick(Player player)
    {
        for (int i = 3; i <= 9; i++)
        {
            if (!player.armor[i].IsAir)
            {
                player.armor[i].Prefix(PrefixID.Menacing);
            }
        }

        foreach (var item in player.inventory)
        {
            if (item.IsAir) continue;
            if (item.CanHavePrefixes())
            {
                if (item.CanApplyPrefix(PrefixID.Legendary) && item.prefix != PrefixID.Legendary)
                {
                    item.Prefix(PrefixID.Legendary);
                    item.prefix = PrefixID.Legendary;
                }
                else if (item.CanApplyPrefix(PrefixID.Unreal) && item.prefix != PrefixID.Unreal)
                {
                    item.Prefix(PrefixID.Unreal);
                    item.prefix = PrefixID.Unreal;
                }
                else if (item.CanApplyPrefix(PrefixID.Mythical) && item.DamageType == DamageClass.Magic && item.prefix != PrefixID.Mythical)
                {
                    item.Prefix(PrefixID.Mythical);
                    item.prefix = PrefixID.Mythical;
                }
                else if (item.CanApplyPrefix(PrefixID.Godly) && item.prefix != PrefixID.Godly)
                {
                    item.Prefix(PrefixID.Godly);
                    item.prefix = PrefixID.Godly;
                }
            }
        }
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.Register();
    }
}
