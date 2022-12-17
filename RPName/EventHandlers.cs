namespace RPName
{
    using PlayerRoles;
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using System.Linq;
    using Random = UnityEngine.Random;

    public class EventHandlers
    {
        [PluginEvent(ServerEventType.PlayerChangeRole)]
        public void OnChangingRole(Player player, PlayerRoleBase oldRole, RoleTypeId newRole, RoleChangeReason reason)
        {
            if (newRole == RoleTypeId.Spectator && RPName.Instance.Config.ReturnNameAfterDeath)
            {
                player.DisplayNickname = player.Nickname;
                return;
            }

            if (newRole == RoleTypeId.ClassD && RPName.Instance.Config.ClassName.ContainsKey(newRole))
            {
                player.DisplayNickname = RPName.Instance.Config.ClassName[newRole] + Random.Range(0, RPName.Instance.Config.MaxNumber);
                return;
            }

            if (newRole.GetTeam() == Team.SCPs)
            {
                if (RPName.Instance.Config.ShowNumberSCP && RPName.Instance.Config.ClassName.ContainsKey(newRole))
                {
                    player.DisplayNickname = RPName.Instance.Config.ClassName[newRole];
                }
                else
                {
                    player.DisplayNickname = "SCP-###";
                }
                return;
            }

            if (newRole.GetTeam() == Team.ChaosInsurgency && RPName.Instance.Config.ClassName.Any(x => x.Key.GetTeam() == Team.ChaosInsurgency))
            {
                player.DisplayNickname = RPName.Instance.Config.ClassName.Where(x => x.Key.GetTeam() == Team.ChaosInsurgency).First().Value + RPName.Instance.Config.HumanName.RandomItem();
                return;
            }

            if (RPName.Instance.Config.ClassName.ContainsKey(newRole))
            {
                if (RPName.Instance.Config.UseHumanName) player.DisplayNickname = RPName.Instance.Config.ClassName[newRole] + RPName.Instance.Config.HumanName.RandomItem();
                else player.DisplayNickname = RPName.Instance.Config.ClassName[newRole] + player.Nickname;

                return;
            }
        }
    }
}
