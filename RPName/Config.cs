namespace RPName
{
    using PlayerRoles;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Config
    {
        [Description("Max random number.")]
        public int MaxNumber { get; set; } = 9999;

        [Description("List of roles and their display names. (%HumanName% - Rp-name of the player, %NickName% - Nickname of the player, %RandNum% - Generated random number)")]
        public Dictionary<RoleTypeId, string> ClassName { get; set; } = new Dictionary<RoleTypeId, string>()
        {
            { RoleTypeId.Scp049, "SCP-049" },
            { RoleTypeId.Scp0492, "SCP-049-2" },
            { RoleTypeId.Scp079, "SCP-079" },
            { RoleTypeId.Scp096, "SCP-096" },
            { RoleTypeId.Scp106, "SCP-106" },
            { RoleTypeId.Scp173, "SCP-173" },
            { RoleTypeId.Scp939, "SCP-939" },
            { RoleTypeId.ClassD, "D-%RandNum%" },
            { RoleTypeId.Scientist, "Dr. %HumanName%" },
            { RoleTypeId.FacilityGuard, "Guard %HumanName%" },
            { RoleTypeId.NtfCaptain, "Capitan %HumanName%" },
            { RoleTypeId.NtfSergeant, "Sergeant %HumanName%" },
            { RoleTypeId.NtfPrivate, "Private %HumanName%" },
            { RoleTypeId.NtfSpecialist, "Specialist %HumanName%" },
            { RoleTypeId.ChaosConscript, "Chaos Agent %HumanName%" },
            { RoleTypeId.ChaosMarauder, "Chaos Agent %HumanName%" },
            { RoleTypeId.ChaosRepressor, "Chaos Agent %HumanName%" },
            { RoleTypeId.ChaosRifleman, "Chaos Agent %HumanName%" }
        };

        [Description("Human names.")]
        public List<string> HumanName { get; set; } = new List<string>()
        {
            "James",
            "Robert",
            "John",
            "Michael",
            "David",
            "William",
            "Richard",
            "Joseph",
            "Thomas",
            "Charles",
            "Christopher",
            "Daniel",
            "Matthew",
            "Anthony",
            "Mark",
            "Donald",
            "Steven",
            "Paul",
            "Andrew",
            "Joshua",
            "Kenneth",
            "Kevin",
            "Brian",
            "George",
            "Timothy",
            "Timothy",
            "Edward",
            "Jason",
            "Jeffrey",
            "Ryan",
            "Jacob",
            "Gary",
            "Nicholas",
            "Eric",
            "Jonathan",
            "Stephen",
            "Justin",
            "Scott",
            "Brandon",
            "Benjamin",
            "Samuel",
            "Gregory",
            "Alexander",
            "Frank",
            "Patrick",
            "Raymond",
            "Jack",
            "Dennis",
            "Jerry",
            "Tyler",
            "Aaron",
            "Jose",
            "Adam",
            "Nathan",
            "Henry",
            "Douglas",
            "Zachary",
            "Peter",
            "Kyle",
            "Ethan",
            "Walter"
        };

        [Description("Return name after death?")]
        public bool ReturnNameAfterDeath { get; set; } = true;
    }
}
