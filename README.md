# Toggle Harvest
![Mod Version](https://img.shields.io/badge/Mod_Version-1.10-blue.svg)
![RimWorld Version](https://img.shields.io/badge/Built_for_RimWorld-1.6-blue.svg)
![Harmony Version](https://img.shields.io/badge/Powered_by_Harmony-2.3.6-blue.svg)\
![Steam Downloads](https://img.shields.io/steam/downloads/1499848654?colorB=blue&label=Steam+Downloads)
![GitHub Downloads](https://img.shields.io/github/downloads/Jaxe-Dev/ToggleHarvest/total.svg?colorB=blue&label=GitHub+Downloads)

[Link to Steam Workshop page](https://steamcommunity.com/sharedfiles/filedetails/?id=1499848654)\
[Link to Ludeon Forum Post](https://ludeon.com/forums/index.php?topic=43552.0)

---

Adds an *Allow Harvest* button to Growing Zones alongside the already existing *Allow Sowing* button.

---

##### STEAM INSTALLATION
- **[Go to the Steam Workshop page](https://steamcommunity.com/sharedfiles/filedetails/?id=1499848654) and subscribe to the mod.**

---

##### NON-STEAM INSTALLATION
- **[Download the latest release](https://github.com/Jaxe-Dev/ToggleHarvest/releases/latest) and unzip it into your *RimWorld/Mods* folder.**

---

The following base methods are patched with Harmony:
```
Postfix : RimWorld.Building_PlantGrower.ExposeData
Postfix : RimWorld.Building_PlantGrower.GetGizmos
Postfix : RimWorld.WorkGiver_GrowerHarvest.HasJobOnCell
Postfix : RimWorld.Zone_Growing.ExposeData
Postfix : RimWorld.Zone_Growing.GetGizmos
Prefix  : Verse.Profile.MemoryUtility.ClearAllMapsAndWorld
```
