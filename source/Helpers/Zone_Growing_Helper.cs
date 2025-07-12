using System.Collections.Generic;
using RimWorld;

namespace ToggleHarvest.Helpers;

public static class Zone_Growing_Helper
{
  private static readonly HashSet<Zone_Growing> Disallowed = new();

  public static void Reset() => Disallowed.Clear();

  public static bool IsAllowed(Zone_Growing zone) => !Disallowed.Contains(zone);

  public static void SetAllowed(Zone_Growing zone, bool allowed)
  {
    var isDisallowed = Disallowed.Contains(zone);
    switch (allowed)
    {
      case true when isDisallowed:
        Disallowed.Remove(zone);
        break;
      case false when !isDisallowed:
        Disallowed.Add(zone);
        break;
    }
  }
}
