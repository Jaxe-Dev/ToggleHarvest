using Harmony;
using Verse;

namespace ToggleHarvest.Patch
{
    [HarmonyPatch(typeof(Game), nameof(Game.InitNewGame))]
    internal static class Verse_Game_InitNewGame
    {
        private static void Prefix() => Mod.Reset();
    }
}
