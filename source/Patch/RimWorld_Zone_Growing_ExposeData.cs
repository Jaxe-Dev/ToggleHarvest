using HarmonyLib;
using RimWorld;
using ToggleHarvest.Helpers;
using Verse;

namespace ToggleHarvest.Patch
{
  [HarmonyPatch(typeof(Zone_Growing), nameof(Zone_Growing.ExposeData))]
  internal static class RimWorld_Zone_Growing_ExposeData
  {
    private static void Postfix(ref Zone_Growing __instance)
    {
      var allowHarvest = Zone_Growing_Helper.IsAllowed(__instance);
      Scribe_Values.Look(ref allowHarvest, "allowHarvest", true);
      Zone_Growing_Helper.SetAllowed(__instance, allowHarvest);
    }
  }
}
