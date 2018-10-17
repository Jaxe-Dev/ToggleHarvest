using System.Collections.Generic;
using Harmony;
using RimWorld;
using Verse;

namespace ToggleHarvest.Patch
{
    [HarmonyPatch(typeof(Zone_Growing), nameof(Zone_Growing.GetGizmos))]
    internal static class RimWorld_Zone_Growing_GetGizmos
    {
        private static void Postfix(Zone_Growing __instance, ref IEnumerable<Gizmo> __result)
        {
            var allowHarvestCommand = new Command_Toggle
            {
                        defaultLabel = "ToggleHarvest.CommandAllowHarvest".Translate(),
                        defaultDesc = "ToggleHarvest.CommandAllowHarvestDesc".Translate(),
                        icon = TexCommand.ForbidOff,
                        isActive = () => Mod.IsAllowed(__instance),
                        toggleAction = () => Mod.SetAllowed(__instance, !Mod.IsAllowed(__instance))
            };

            __result = new List<Gizmo>(__result) { allowHarvestCommand };
        }
    }
}
