using MEC;
using PlayerRoles;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using RPName.API;
using System;
using System.IO;
using System.Linq;
using Random = UnityEngine.Random;

namespace RPName
{
    public class EventHandlers
    {
        [PluginEvent(ServerEventType.WaitingForPlayers)]
        public void OnWaitingForPlayers()
        {
            if (!Directory.Exists(RPName.UserDataFolder))
                Directory.CreateDirectory(RPName.UserDataFolder);
        }

        [PluginEvent(ServerEventType.PlayerChangeRole)]
        public void OnChangingRole(Player player, PlayerRoleBase oldRole, RoleTypeId newRole, RoleChangeReason reason)
        {
            try
            {
                Timing.CallDelayed(0.1f, () =>
                {
                    if (player == null) return;
                    if (newRole == RoleTypeId.Spectator && !RPName.Config.ReturnNameAfterDeath && !RPName.Config.ClassName.ContainsKey(newRole)) return;
                    player.DisplayNickname = GetPlayerRPName(player, newRole);
                });
            }
            catch (Exception e)
            {
                Log.Error("[RPName] [Event: OnChangingRole] " + e.ToString());
            }
        }

        public static string GetPlayerRPName(Player player, RoleTypeId newRole)
        {
            if (newRole == RoleTypeId.Spectator && RPName.Config.ReturnNameAfterDeath && !RPName.Config.ClassName.ContainsKey(newRole)) return string.Empty;
            if (!RPName.Config.ClassName.ContainsKey(newRole)) return string.Empty;
            return RPName.Config.ClassName.Where(x => x.Key == newRole).First().Value.Replace("%RandNum%", Random.Range(0, RPName.Config.MaxNumber).ToString()).Replace("%HumanName%", UserManager.GetPlayerRPName(player)).Replace("%NickName%", player.Nickname.ToString());
        }
    }
}
