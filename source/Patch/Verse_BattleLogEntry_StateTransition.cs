using HarmonyLib;
using RimWorld;
using Verse;

namespace BoomMod.Patch;

[HarmonyPatch(typeof(BattleLogEntry_StateTransition), MethodType.Constructor, typeof(Thing), typeof(RulePackDef), typeof(Pawn), typeof(Hediff), typeof(BodyPartRecord))]
internal static class Verse_BattleLogEntry_StateTransition
{
  private static void Prefix(Thing subject, ref RulePackDef transitionDef, Hediff culpritHediff)
  {
    if (subject is not Pawn pawn || !Evaluator.IsExplosive(pawn) || Evaluator.IsExploding(pawn, culpritHediff)) { return; }
    transitionDef = RulePackDefOf.Transition_Died;
  }
}
