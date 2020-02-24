using HarmonyLib;
using Verse.Profile;

namespace ToggleHarvest.Patch
{
    [HarmonyPatch(typeof(MemoryUtility), "ClearAllMapsAndWorld")]
    internal static class Verse_Profile_MemoryUtility_ClearAllMapsAndWorld
    {
        private static void Prefix() => Mod.Reset();
    }
}
