# RPName
[![Version](https://img.shields.io/github/v/release/MrAfitol/RPName?sort=semver&style=flat-square&color=blue&label=Version)](https://github.com/MrAfitol/RPName/releases)
[![Downloads](https://img.shields.io/github/downloads/MrAfitol/RPName/total?style=flat-square&color=yellow&label=Downloads)](https://github.com/MrAfitol/RPName/releases)

A plugin that changes the names of players on RP names.
## How download ?
   - *1. Find the SCP SL server config folder*
   
   *("C:\Users\(user name)\AppData\Roaming\SCP Secret Laboratory\" for windows, "/home/(user name)/.config/SCP Secret Laboratory/" for linux)*
  
   - *2. Find the "PluginAPI" folder there, it contains the "plugins" folder.*
  
   - *3. Select either the port of your server to install the same on that server or the "global" folder to install the plugin for all servers*
  
  ***Or***
  
   - *Run the command in console `p install MrAfitol/RPName`*
  
 ## Config
```yml
# Max random number.
max_number: 9999
# List of roles and their display names. (%HumanName% - Rp-name of the player, %NickName% - Nickname of the player, %RandNum% - Generated random number)
class_name:
  Scp049: SCP-049
  Scp0492: SCP-049-2
  Scp079: SCP-079
  Scp096: SCP-096
  Scp106: SCP-106
  Scp173: SCP-173
  Scp939: SCP-939
  ClassD: D-%RandNum%
  Scientist: Dr. %HumanName%
  FacilityGuard: Guard %HumanName%
  NtfCaptain: Capitan %HumanName%
  NtfSergeant: Sergeant %HumanName%
  NtfPrivate: Private %HumanName%
  NtfSpecialist: Specialist %HumanName%
  ChaosConscript: Chaos Agent %HumanName%
  ChaosMarauder: Chaos Agent %HumanName%
  ChaosRepressor: Chaos Agent %HumanName%
  ChaosRifleman: Chaos Agent %HumanName%
# Human names.
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
## Wiki
**Be sure to check out the [Wiki](https://github.com/MrAfitol/RPName/wiki)**
