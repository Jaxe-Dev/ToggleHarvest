using HarmonyLib;
using RimWorld;
using ToggleHarvest.Helpers;
using Verse;

namespace ToggleHarvest.Patch
{
  [HarmonyPatch(typeof(Building_PlantGrower), nameof(Building_PlantGrower.ExposeData))]
  internal static class RimWorld_Building_PlantGrower_ExposeData
  {
    private static void Postfix(ref Building_PlantGrower __instance)
    {
      var allowHarvest = Building_PlantGrower_Helper.IsAllowed(__instance);
      Scribe_Values.Look(ref allowHarvest, "allowHarvest", true);
      Building_PlantGrower_Helper.SetAllowed(__instance, allowHarvest);
    }
  }
}
