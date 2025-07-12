using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using RimWorld;
using ToggleHarvest.Helpers;
using Verse;

namespace ToggleHarvest.Patch;

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
      isActive = () => Zone_Growing_Helper.IsAllowed(__instance),
      toggleAction = () => Zone_Growing_Helper.SetAllowed(__instance, !Zone_Growing_Helper.IsAllowed(__instance))
    };

    var list = __result.ToList();
    var index = list.FirstIndexOf(static gizmo => (gizmo as Command_Toggle)?.Label == "CommandAllowSow".Translate());

    if (index <= 0) { list.Add(allowHarvestCommand); }
    else { list.Insert(index + 1, allowHarvestCommand); }

    __result = list;
  }
}
