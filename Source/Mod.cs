using Harmony;
using Verse;

namespace BoomMod
{
    [StaticConstructorOnStartup]
    internal static class Mod
    {
        static Mod() => HarmonyInstance.Create("BoomMod").PatchAll();
    }
}
