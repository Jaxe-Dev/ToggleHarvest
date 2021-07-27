using System.Collections.Generic;
using HarmonyLib;
using RimWorld;
using Verse;

namespace ToggleHarvest
{
    [StaticConstructorOnStartup]
    internal static class Mod
    {
        public const string Id = "ToggleHarvest";
        public const string Name = "Toggle Harvest";
        public const string Version = "1.5";

        private static readonly HashSet<Zone_Growing> DisallowedZones = new HashSet<Zone_Growing>();

        static Mod() => new Harmony(Id).PatchAll();

        public static void Reset() => DisallowedZones.Clear();
        public static bool IsAllowed(Zone_Growing zone) => !DisallowedZones.Contains(zone);

        public static void SetAllowed(Zone_Growing zone, bool allowed)
        {
            var isDisallowed = DisallowedZones.Contains(zone);
            if (allowed && isDisallowed) { DisallowedZones.Remove(zone); }
            else if (!allowed && !isDisallowed) { DisallowedZones.Add(zone); }
        }
    }
}
