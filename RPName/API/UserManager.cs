using Newtonsoft.Json;
using PluginAPI.Core;
using System.IO;

namespace RPName.API
{
    public class UserManager
    {
        public static string GetPlayerRPName(Player player)
        {
            if (player == null) 
                return RPName.Config.HumanName.RandomItem();
            return GetRPUserData(player).RPName;
        }

        public static string GetPlayerRPName(string userId) => GetRPUserData(userId).RPName;

        public static RPUserData GetRPUserData(Player player)
        {
            if (!File.Exists(Path.Combine(RPName.UserDataFolder, player.UserId + ".json")))
                return GenerateNewUserData(player.UserId);
            RPUserData userData = JsonConvert.DeserializeObject<RPUserData>(File.ReadAllText(Path.Combine(RPName.UserDataFolder, player.UserId + ".json")));
            return userData;
        }

        public static RPUserData GetRPUserData(string userId)
        {
            if (!File.Exists(Path.Combine(RPName.UserDataFolder, userId + ".json")))
                return GenerateNewUserData(userId);
            RPUserData userData = JsonConvert.DeserializeObject<RPUserData>(File.ReadAllText(Path.Combine(RPName.UserDataFolder, userId + ".json")));
            return userData;
        }

        public static void SetRPName(Player player, string rpName)
        {
            RPUserData userData = GetRPUserData(player);
            userData.RPName = rpName;
            string jsonUserData = JsonConvert.SerializeObject(userData, Formatting.Indented);
            File.WriteAllText(Path.Combine(RPName.UserDataFolder, player.UserId + ".json"), jsonUserData);
        }

        public static void SetRPName(string userId, string rpName)
        {
            RPUserData userData = GetRPUserData(userId);
            userData.RPName = rpName;
            string jsonUserData = JsonConvert.SerializeObject(userData, Formatting.Indented);
            File.WriteAllText(Path.Combine(RPName.UserDataFolder, userId + ".json"), jsonUserData);
        }

        public static RPUserData GenerateNewUserData(string userId)
        {
            RPUserData userData = new RPUserData(userId, RPName.Config.HumanName.RandomItem());
            string jsonUserData = JsonConvert.SerializeObject(userData, Formatting.Indented);
            File.WriteAllText(Path.Combine(RPName.UserDataFolder, userId + ".json"), jsonUserData);
            return userData;
        }
    }
}
