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
    public const string Version = "1.6";

    static Mod() => new Harmony(Id).PatchAll();
  }
}
