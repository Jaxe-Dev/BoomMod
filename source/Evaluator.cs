using System.Collections.Generic;
using RimWorld;
using Verse;

namespace BoomMod;

internal static class Evaluator
{
  private static readonly Dictionary<HediffDef, float> ExplosionChance = new()
  {
    { DefDatabase<HediffDef>.GetNamed("Burn"), 1f },
    { DefDatabase<HediffDef>.GetNamed("Gunshot"), 1f },
    { DefDatabase<HediffDef>.GetNamed("Shredded"), 1f }
  };

  private static bool _explosionImminent;

  public static bool IsExplosive(Pawn pawn) => pawn.RaceProps is not null && (pawn.RaceProps.deathAction?.workerClass == typeof(DeathActionWorker_BigExplosion) || pawn.RaceProps.deathAction?.workerClass == typeof(DeathActionWorker_SmallExplosion));

  public static bool IsExploding(Pawn pawn, Hediff? cause)
  {
    if (cause is null) { return false; }

    var def = (cause as Hediff_MissingPart)?.lastInjury ?? cause.def;

    if (!pawn.HasAttachment(ThingDefOf.Fire) && !IsExplosive(def)) { return false; }

    _explosionImminent = true;
    return true;
  }

  private static bool IsExplosive(HediffDef def) => ExplosionChance.ContainsKey(def) && Rand.Chance(ExplosionChance[def]);

  public static bool IsExplosionImmiment()
  {
    var explode = _explosionImminent;
    if (explode) { _explosionImminent = false; }

    return explode;
  }
}
