using Harmony;
using RimWorld;
using Verse;

namespace BoomMod.Patch
{
    [HarmonyPatch(typeof(DeathActionWorker_BigExplosion), nameof(DeathActionWorker_BigExplosion.PawnDied), typeof(Corpse))]
    internal static class RimWorld_DeathActionWorker_BigExplosion_PawnDied
    {
        private static bool Prefix(Corpse corpse) => (corpse.InnerPawn == null) || !Evaluator.IsListedPawnKind(corpse.InnerPawn) || Evaluator.IsExplosionImmiment();
    }
}
