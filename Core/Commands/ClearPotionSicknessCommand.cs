using System.Collections.Generic;
using System.Linq;

namespace QuickLoadoutBags.Core.Commands;

public class ClearPotionSicknessCommand : ModCommand
{
    public override string Command => "clearpotion";
    public override bool IsCaseSensitive => false;
    public override CommandType Type => CommandType.Chat;

    public override void Action(CommandCaller caller, string input, string[] args)
    {
        Main.LocalPlayer.potionDelay = 0;
        Main.LocalPlayer.ClearBuff(BuffID.PotionSickness);
        Main.NewText("Cleared potion sickness.");
    }
}
