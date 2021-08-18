using System;
using Dalamud.Plugin;
using Dalamud.Game.ClientState.Actors.Types;
using Dalamud.Game.ClientState.Actors.Types.NonPlayer;

namespace BlueMageHelper
{
    public class TargetData
    {
        public static string Name { get; set; }
        public static int NameID { get; set; }

        public bool IsBattleNpc(Actor target)
        {
            if (target is BattleNpc bnpc)
            {
                Name = bnpc.Name;
                NameID = bnpc.NameId;
                return true;
            }
            return false;
        }
    }
}