namespace QuickLoadoutBags.Core.Globals.GlobalNPCs;

public class DamageVariationNPC : GlobalNPC
{
    public static bool damageVariationDisabled = true;
    public override void ModifyIncomingHit(NPC npc, ref NPC.HitModifiers modifiers)
    {
        if (damageVariationDisabled)
        {
            modifiers.DamageVariationScale *= 0f;
        }
    }
}

public class DamageVariationCommand : ModCommand
{
    public override string Command => "toggleDamageVariation";
    public override bool IsCaseSensitive => false;
    public override CommandType Type => CommandType.World;

    public override void Action(CommandCaller caller, string input, string[] args)
    {
        DamageVariationNPC.damageVariationDisabled = !DamageVariationNPC.damageVariationDisabled;
        if (DamageVariationNPC.damageVariationDisabled)
        {
            Main.NewText("NPC damage variation has been disabled.");
        }
        else
        {
            Main.NewText("NPC damage variation has been enabled.");
        }
    }
}
