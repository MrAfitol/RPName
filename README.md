# RPName
[![GitHub release](https://flat.badgen.net/github/release/MrAfitol/RPName)](https://github.com/MrAfitol/RPName/releases/)
![GitHub downloads](https://flat.badgen.net/github/assets-dl/MrAfitol/RPName)

A plugin that changes the names of players on RP names.
## How download ?
  *1. Find the SCP SL server config folder*
  
  *("C:\Users\(user name)\AppData\Roaming\SCP Secret Laboratory\" for windows, "/home/(user name)/.config/SCP Secret Laboratory/" for linux)*
  
  *2. Find the "PluginAPI" folder there, it contains the "plugins" folder.*
  
  *3. Select either the port of your server to install the same on that server or the "global" folder to install the plugin for all servers*
  
 ## Config
```yml
# Max number in ClassD name
max_number: 9999
# Show SCP number? (If false, name will be SCP-###)
show_number_s_c_p: true
# A list of roles and their names or designations
class_name:
  Scp049: SCP-049
  Scp0492: SCP-049-2
  Scp079: SCP-079
  Scp096: SCP-096
  Scp106: SCP-106
  Scp173: SCP-173
  Scp939: SCP-939
  ClassD: D-
  Scientist: 'Dr. '
  FacilityGuard: 'Guard '
  NtfCaptain: 'Capitan '
  NtfSergeant: 'Sergeant '
  NtfPrivate: 'Private '
  NtfSpecialist: 'Specialist '
  ChaosConscript: 'Chaos Agent '
# Use human names? (If false, name will be player's nickname)
use_human_name: true
# Human names
human_name:
- James
- Robert
- John
- Michael
- David
- William
- Richard
- Joseph
- Thomas
- Charles
- Christopher
- Daniel
- Matthew
- Anthony
- Mark
- Donald
- Steven
- Paul
- Andrew
- Joshua
- Kenneth
- Kevin
- Brian
- George
- Timothy
- Timothy
- Edward
- Jason
- Jeffrey
- Ryan
- Jacob
- Gary
- Nicholas
- Eric
- Jonathan
- Stephen
- Justin
- Scott
- Brandon
- Benjamin
- Samuel
- Gregory
- Alexander
- Frank
- Patrick
- Raymond
- Jack
- Dennis
- Jerry
- Tyler
- Aaron
- Jose
- Adam
- Nathan
- Henry
- Douglas
- Zachary
- Peter
- Kyle
- Ethan
- Walter
# Return name after death?
return_name_after_death: true
```
