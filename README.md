# BoomMod
![Mod Version](https://img.shields.io/badge/Mod_Version-1.3-blue.svg)
![RimWorld Version](https://img.shields.io/badge/Built_for_RimWorld-1.2-blue.svg)
![Harmony Version](https://img.shields.io/badge/Powered_by_Harmony-2.x-blue.svg)\
![Steam Subscribers](https://img.shields.io/badge/dynamic/xml.svg?label=Steam+Subscribers&query=//table/tr[2]/td[1]&colorB=blue&url=https://steamcommunity.com/sharedfiles/filedetails/%3Fid=1504182014&suffix=+total)
![GitHub Downloads](https://img.shields.io/github/downloads/Jaxe-Dev/BoomMod/total.svg?colorB=blue&label=GitHub+Downloads)


[Link to Steam Workshop page](https://steamcommunity.com/sharedfiles/filedetails/?id=1504182014)\
[Link to Ludeon Forum thread](https://ludeon.com/forums/index.php?topic=45971.0)

---

With this mod Boomalopes and Boomrats will only explode on death when the killing blow is a gunshot, burn, another explosion or they are otherwise on fire at the time. Melee weapons, medieval ranged weapons and natural causes do not trigger an explosion.

---

##### STEAM INSTALLATION
- **[Go to the Steam Workshop page](https://steamcommunity.com/sharedfiles/filedetails/?id=1504182014) and subscribe to the mod.**

---

##### NON-STEAM INSTALLATION
- **[Download the latest release](https://github.com/Jaxe-Dev/BoomMod/releases/latest) and unzip it into your *RimWorld/Mods* folder.**

The following base methods are patched with Harmony:
```
Prefix* : RimWorld.DeathActionWorker_BigExplosion.PawnDied
Prefix* : RimWorld.DeathActionWorker_SmallExplosion.PawnDied
Prefix  : Verse.BattleLogEntry_StateTransition
```
*A prefix marked by a \* denotes that in some circumstances the original method will be bypassed*
