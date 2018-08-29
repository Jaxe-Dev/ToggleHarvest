using Harmony;
using Verse;

namespace ToggleHarvest.Patch
{
    [HarmonyPatch(typeof(Game), nameof(Game.LoadGame))]
    internal static class Verse_Game_LoadGame
    {
        private static void Prefix() => Mod.Reset();
    }
}