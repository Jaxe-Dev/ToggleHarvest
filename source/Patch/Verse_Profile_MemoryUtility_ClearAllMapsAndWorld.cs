using HarmonyLib;
using ToggleHarvest.Helpers;
using Verse.Profile;

namespace ToggleHarvest.Patch
{
  [HarmonyPatch(typeof(MemoryUtility), "ClearAllMapsAndWorld")]
  internal static class Verse_Profile_MemoryUtility_ClearAllMapsAndWorld
  {
    private static void Prefix()
    {
      Zone_Growing_Helper.Reset();
      Building_PlantGrower_Helper.Reset();
    }
  }
}
