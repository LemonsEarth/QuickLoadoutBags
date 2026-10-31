using QuickLoadoutBags.Core.Globals.GlobalNPCs;
using Terraria.DataStructures;

namespace QuickLoadoutBags.Core.ModPlayers;

public class RespawnTimePlayer : ModPlayer
{
    public int respawnTime = 180;

    public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
    {
        Player.respawnTimer = respawnTime;
    }
}

public class RespawnTimeCommand : ModCommand
{
    public override string Command => "setRespawnTime";
    public override bool IsCaseSensitive => false;
    public override CommandType Type => CommandType.Chat;

    public override void Action(CommandCaller caller, string input, string[] args)
    {
        if (args.Length >= 1 && int.TryParse(args[0], out int newRespawnTime))
        {
            Main.LocalPlayer.GetModPlayer<RespawnTimePlayer>().respawnTime = newRespawnTime;
            Main.NewText($"Respawn time set to {newRespawnTime} ticks ({newRespawnTime / 60:F2} seconds).");
        }
    }
}
