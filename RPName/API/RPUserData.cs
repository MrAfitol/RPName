namespace RPName.API
{
    [System.Serializable]
    public class RPUserData
    {
        public string UserId;

        public string RPName;

        public RPUserData(string userId, string rpName)
        {
            UserId = userId;
            RPName = rpName;
        }
    }
}
