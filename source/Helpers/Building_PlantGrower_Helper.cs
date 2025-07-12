using System.Collections.Generic;
using RimWorld;

namespace ToggleHarvest.Helpers;

public static class Building_PlantGrower_Helper
{
  private static readonly HashSet<Building_PlantGrower> Disallowed = new();

  public static void Reset() => Disallowed.Clear();

  public static bool IsAllowed(Building_PlantGrower building) => !Disallowed.Contains(building);

  public static void SetAllowed(Building_PlantGrower building, bool allowed)
  {
    var isDisallowed = Disallowed.Contains(building);
    switch (allowed)
    {
      case true when isDisallowed:
        Disallowed.Remove(building);
        break;
      case false when !isDisallowed:
        Disallowed.Add(building);
        break;
    }
  }
}
