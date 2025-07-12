using HarmonyLib;
using RimWorld;
using Verse;
using Verse.AI.Group;

namespace BoomMod.Patch;

[HarmonyPatch(typeof(DeathActionWorker_BigExplosion), nameof(DeathActionWorker_BigExplosion.PawnDied), typeof(Corpse), typeof(Lord))]
internal static class RimWorld_DeathActionWorker_BigExplosion_PawnDied
{
  private static bool Prefix(Corpse corpse, Lord prevLord) => corpse.InnerPawn is null || !Evaluator.IsExplosive(corpse.InnerPawn) || Evaluator.IsExplosionImmiment();
}
