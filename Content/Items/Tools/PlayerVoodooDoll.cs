using Microsoft.Xna.Framework;

namespace QuickLoadoutBags.Content.Items.Tools;

public class PlayerVoodooDoll : ModItem
{
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 3;
    }

    public override void SetDefaults()
    {
        Item.width = 26;
        Item.height = 32;
        Item.maxStack = 1;
        Item.rare = ItemRarityID.Red;
        Item.useAnimation = 10;
        Item.useTime = 10;
        Item.useStyle = ItemUseStyleID.HoldUp;
        Item.consumable = false;
    }

    public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
    {
        itemGroup = ContentSamples.CreativeHelper.ItemGroup.BossSpawners;
    }

    public override bool? UseItem(Player player)
    {
        if (player.whoAmI == Main.myPlayer)
        {
            if (player.statLife > 20)
            {
                player.statLife -= 20;
                CombatText.NewText(player.getRect(), Color.Red, 20);
            }
        }
        return true;
    }
}
