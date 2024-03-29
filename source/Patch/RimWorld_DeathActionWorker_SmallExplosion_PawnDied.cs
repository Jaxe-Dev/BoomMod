﻿using HarmonyLib;
using RimWorld;
using Verse;

namespace BoomMod.Patch
{
  [HarmonyPatch(typeof(DeathActionWorker_SmallExplosion), nameof(DeathActionWorker_SmallExplosion.PawnDied), typeof(Corpse))]
  internal static class RimWorld_DeathActionWorker_SmallExplosion_PawnDied
  {
    private static bool Prefix(Corpse corpse) => corpse.InnerPawn == null || !Evaluator.IsExplosive(corpse.InnerPawn) || Evaluator.IsExplosionImmiment();
  }
}
