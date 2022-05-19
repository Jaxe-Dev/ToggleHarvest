using System.Collections.Generic;
using RimWorld;

namespace ToggleHarvest.Helpers
{
  public static class Building_PlantGrower_Helper
  {
    private static readonly HashSet<Building_PlantGrower> Disallowed = new HashSet<Building_PlantGrower>();

    public static void Reset() => Disallowed.Clear();

    public static bool IsAllowed(Building_PlantGrower building) => !Disallowed.Contains(building);

    public static void SetAllowed(Building_PlantGrower building, bool allowed)
    {
      var isDisallowed = Disallowed.Contains(building);
      if (allowed && isDisallowed) { Disallowed.Remove(building); }
      else if (!allowed && !isDisallowed) { Disallowed.Add(building); }
    }
  }
}
