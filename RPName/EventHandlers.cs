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

                    if (newRole == RoleTypeId.Spectator && RPName.Instance.Config.ReturnNameAfterDeath)
                    {
                        player.DisplayNickname = "";
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
                        player.DisplayNickname = RPName.Instance.Config.ClassName.Where(x => x.Key.GetTeam() == Team.ChaosInsurgency).First().Value + (RPName.Instance.Config.UseHumanName ? (RPName.Instance.Config.NickLastName ? RPName.Instance.Config.HumanName.RandomItem() + " " + player.Nickname : RPName.Instance.Config.HumanName.RandomItem()) : player.Nickname);
                        return;
                    }

                    if (RPName.Instance.Config.ClassName.ContainsKey(newRole))
                    {
                        player.DisplayNickname = RPName.Instance.Config.ClassName[newRole] + (RPName.Instance.Config.UseHumanName ? (RPName.Instance.Config.NickLastName ? RPName.Instance.Config.HumanName.RandomItem() + " " + player.Nickname : RPName.Instance.Config.HumanName.RandomItem()) : player.Nickname);
                    }
                });
            }
            catch (Exception e)
            {
                Log.Error("[RPName] [Event: OnChangingRole] " + e.ToString());
            }
        }
    }
}
