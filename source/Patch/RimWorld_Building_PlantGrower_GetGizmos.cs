using System.Collections.Generic;
using HarmonyLib;
using RimWorld;
using ToggleHarvest.Helpers;
using Verse;

namespace ToggleHarvest.Patch
{
  [HarmonyPatch(typeof(Building_PlantGrower), nameof(Building_PlantGrower.GetGizmos))]
  internal static class RimWorld_Building_PlantGrower_GetGizmos
  {
    private static void Postfix(Building_PlantGrower __instance, ref IEnumerable<Gizmo> __result)
    {
      var allowHarvestCommand = new Command_Toggle
      {
        defaultLabel = "ToggleHarvest.CommandAllowHarvest".Translate(),
        defaultDesc = "ToggleHarvest.CommandAllowHarvestDesc".Translate(),
        icon = TexCommand.ForbidOff,
        isActive = () => Building_PlantGrower_Helper.IsAllowed(__instance),
        toggleAction = () => Building_PlantGrower_Helper.SetAllowed(__instance, !Building_PlantGrower_Helper.IsAllowed(__instance))
      };

      __result = new List<Gizmo>(__result) { allowHarvestCommand };
    }
  }
}
