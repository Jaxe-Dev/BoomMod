﻿using System.Collections.Generic;
using System.Linq;
using RimWorld;
using Verse;

namespace BoomMod
{
    internal static class Evaluator
    {
        private static readonly Dictionary<HediffDef, float> ExplosionChance = new Dictionary<HediffDef, float>
        {
                    { HediffDefOf.Burn, 1f },
                    { HediffDefOf.Gunshot, 1f },
                    { HediffDefOf.Shredded, 1f }
        };

        private static bool _explosionImminent;

        public static bool IsBoomPawnKind(Pawn pawn) => pawn.kindDef.defName.ToLower().StartsWith("boom");

        public static bool IsExploding(Pawn pawn, Hediff cause)
        {
            if (cause == null) { return false; }

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
}
