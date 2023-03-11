namespace RPName
{
    using PlayerRoles;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Config
    {
        [Description("Max number in ClassD name")]
        public int MaxNumber { get; set; } = 9999;

        [Description("Show SCP number? (If false, name will be SCP-###)")]
        public bool ShowNumberSCP { get; set; } = true;

        [Description("A list of roles and their names or designations")]
        public Dictionary<RoleTypeId, string> ClassName { get; set; } = new Dictionary<RoleTypeId, string>() 
        {
            { RoleTypeId.Scp049, "SCP-049" },
            { RoleTypeId.Scp0492, "SCP-049-2" },
            { RoleTypeId.Scp079, "SCP-079" },
            { RoleTypeId.Scp096, "SCP-096" },
            { RoleTypeId.Scp106, "SCP-106" },
            { RoleTypeId.Scp173, "SCP-173" },
            { RoleTypeId.Scp939, "SCP-939" },
            { RoleTypeId.ClassD, "D-" },
            { RoleTypeId.Scientist, "Dr. " },
            { RoleTypeId.FacilityGuard, "Guard " },
            { RoleTypeId.NtfCaptain, "Capitan " },
            { RoleTypeId.NtfSergeant, "Sergeant " },
            { RoleTypeId.NtfPrivate, "Private " },
            { RoleTypeId.NtfSpecialist, "Specialist " },
            { RoleTypeId.ChaosConscript, "Chaos Agent " }
        };

        [Description("Use human names? (If false, name will be player's nickname)")]
        public bool UseHumanName { get; set; } = true;

        [Description("If the parameter is enabled, the player's nickname will be displayed as a last name, but the UseHumanName parameter must be enabled")]
        public bool NickLastName { get; set; } = false;

        [Description("Human names")]
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
