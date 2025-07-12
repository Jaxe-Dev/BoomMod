# BoomMod
![Mod Version](https://img.shields.io/badge/Mod_Version-1.9-blue.svg)
![RimWorld Version](https://img.shields.io/badge/Built_for_RimWorld-1.6-blue.svg)
![Harmony Version](https://img.shields.io/badge/Powered_by_Harmony-2.3.6-blue.svg)
![Steam Downloads](https://img.shields.io/steam/downloads/1504182014?colorB=blue&label=Steam+Downloads)


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
