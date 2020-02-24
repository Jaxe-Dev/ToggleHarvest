using HarmonyLib;
using RimWorld;
using Verse;

namespace ToggleHarvest.Patch
{
    [HarmonyPatch(typeof(WorkGiver_GrowerHarvest), nameof(WorkGiver_GrowerHarvest.HasJobOnCell))]
    internal static class RimWorld_WorkGiver_GrowerHarvest_HasJobOnCell
    {
        private static void Postfix(ref bool __result, Pawn pawn, IntVec3 c)
        {
            if (!__result) { return; }

            if (!(c.GetZone(pawn.Map) is Zone_Growing zone) || Mod.IsAllowed(zone)) { return; }
            __result = false;
        }
    }
}
