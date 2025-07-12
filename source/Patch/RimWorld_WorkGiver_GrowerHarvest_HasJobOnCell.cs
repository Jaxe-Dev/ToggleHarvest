using HarmonyLib;
using RimWorld;
using ToggleHarvest.Helpers;
using Verse;

namespace ToggleHarvest.Patch;

[HarmonyPatch(typeof(WorkGiver_GrowerHarvest), nameof(WorkGiver_GrowerHarvest.HasJobOnCell))]
internal static class RimWorld_WorkGiver_GrowerHarvest_HasJobOnCell
{
  private static void Postfix(ref bool __result, Pawn pawn, IntVec3 c)
  {
    if (!__result) { return; }

    if (c.GetZone(pawn.Map) is Zone_Growing zone && !Zone_Growing_Helper.IsAllowed(zone)) { __result = false; }
    else if (c.GetFirstBuilding(pawn.Map) is Building_PlantGrower building && !Building_PlantGrower_Helper.IsAllowed(building)) { __result = false; }
  }
}
