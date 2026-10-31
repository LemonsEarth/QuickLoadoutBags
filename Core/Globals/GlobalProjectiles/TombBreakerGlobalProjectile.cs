using QuickLoadoutBags.Core.Globals.GlobalNPCs;
using Terraria.DataStructures;

namespace QuickLoadoutBags.Core.Globals.GlobalProjectiles;

public class TombBreakerGlobalProjectile : GlobalProjectile
{
    public static bool tombBreakerEnabled = true;
    public override bool AppliesToEntity(Projectile entity, bool lateInstantiation)
    {
        return ProjectileID.Sets.IsAGravestone[entity.type];
    }

    public override void OnSpawn(Projectile projectile, IEntitySource source)
    {
        if (!tombBreakerEnabled) return;
        projectile.timeLeft = 0;
        projectile.Kill();
    }
}

public class TombBreakerCommand : ModCommand
{
    public override string Command => "toggleTombBreaker";
    public override bool IsCaseSensitive => false;
    public override CommandType Type => CommandType.World;

    public override void Action(CommandCaller caller, string input, string[] args)
    {
        TombBreakerGlobalProjectile.tombBreakerEnabled = !TombBreakerGlobalProjectile.tombBreakerEnabled;
        if (TombBreakerGlobalProjectile.tombBreakerEnabled)
        {
            Main.NewText("Gravestones are disabled.");
        }
        else
        {
            Main.NewText("Gravestones are enabled.");
        }
    }
}
