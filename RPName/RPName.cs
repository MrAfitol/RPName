using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;
using PluginAPI.Helpers;
using System.IO;

namespace RPName
{
    public class RPName
    {
        public static RPName Instance { get; private set; }

        [PluginConfig("configs/rp-name.yml")]
        public static Config Config;

        public static string UserDataFolder { get; private set; }

        [PluginEntryPoint("RPName", "1.0.9", "A plugin that changes the names of players on RP names.", "MrAfitol")]
        void LoadPlugin()
        {
            Instance = this;
            EventManager.RegisterEvents<EventHandlers>(this);

            var handler = PluginHandler.Get(this);
            UserDataFolder = Path.Combine(Paths.PluginAPI, "RPNameData", Server.Port.ToString(), "UsersData");
        }
    }
}
