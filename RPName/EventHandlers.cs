namespace RPName
{
    using MEC;
    using PlayerRoles;
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using System;
    using System.Linq;
    using Random = UnityEngine.Random;

    public class EventHandlers
    {
        [PluginEvent(ServerEventType.PlayerChangeRole)]
        public void OnChangingRole(Player player, PlayerRoleBase oldRole, RoleTypeId newRole, RoleChangeReason reason)
        {
            try
            {
                Timing.CallDelayed(0.1f, () => {
                    if (player == null) return;
                    if (newRole == RoleTypeId.Spectator && !RPName.Instance.Config.ReturnNameAfterDeath && !RPName.Instance.Config.ClassName.ContainsKey(newRole)) return;
                    player.DisplayNickname = GetPlayerRPName(player, newRole);
                });
            }
            catch (Exception e)
            {
                Log.Error("[RPName] [Event: OnChangingRole] " + e.ToString());
            }
        }

        public string GetPlayerRPName(Player player, RoleTypeId newRole)
        {
            if (newRole == RoleTypeId.Spectator && RPName.Instance.Config.ReturnNameAfterDeath && !RPName.Instance.Config.ClassName.ContainsKey(newRole)) return string.Empty;
            if (!RPName.Instance.Config.ClassName.ContainsKey(newRole)) return string.Empty;
            return RPName.Instance.Config.ClassName.Where(x => x.Key == newRole).First().Value.Replace("%RandNum%", Random.Range(0, RPName.Instance.Config.MaxNumber).ToString()).Replace("%HumanName%", RPName.Instance.Config.HumanName.RandomItem()).Replace("%NickName%", player.Nickname.ToString());
        }
    }
}
