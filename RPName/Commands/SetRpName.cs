using CommandSystem;
using PlayerRoles;
using PluginAPI.Core;
using RPName.API;
using System;

namespace RPName.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class SetRpName : ICommand
    {
        public string Command => "setrpname";

        public string[] Aliases => new string[] { "setrpn", "srpn" };

        public string Description => "Set your rp name";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get(sender);

            if (player == null)
            {
                response = "An error occurred while using the command. Try again!";
                return false;
            }

            if (arguments.Count != 1)
            {
                response = "The command is incorrect, use:\n.setrpname (name)";
                return false;
            }

            if (!string.IsNullOrEmpty(arguments.At(0)))
            {
                if (!TryRPName(arguments.At(0)))
                {
                    response = "An invalid word was found in the name!";
                    return true;
                }

                UserManager.SetRPName(player, arguments.At(0));

                if (player.Role == RoleTypeId.Spectator && !RPName.Config.ReturnNameAfterDeath && !RPName.Config.ClassName.ContainsKey(player.Role))
                {
                    response = "Your rp name has been successfully set!";
                    return true;
                }

                player.DisplayNickname = EventHandlers.GetPlayerRPName(player, player.Role);

                response = "Your rp name has been successfully set!";
                return true;
            }
            else
            {
                response = "Rp name is null or empty";
                return false;
            }
        }

        public bool TryRPName(string name)
        {
            if (RPName.Config.BlockWordsInRPName == null)
                return true;
            if (RPName.Config.BlockWordsInRPName?.Count <= 0)
                return true;
            foreach (string word in RPName.Config.BlockWordsInRPName)
                if (name.Contains(word))
                    return false;
            return true;
        }
    }
}
