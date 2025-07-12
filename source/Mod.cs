using HarmonyLib;
using Verse;

namespace BoomMod;

[StaticConstructorOnStartup]
internal static class Mod
{
  public const string Id = "BoomMod";
  public const string Name = Id;
  public const string Version = "1.9";

  static Mod() => new Harmony(Id).PatchAll();
}
