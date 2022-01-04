﻿using System.Diagnostics.CodeAnalysis;
using HarmonyLib;
using SolastaCommunityExpansion.Models;
using static RulesetImplementationDefinitions;

namespace SolastaCommunityExpansion.Patches.Conjurations
{
    [HarmonyPatch(typeof(RulesetImplementationManagerLocation), "ApplySummonForm")]
    [SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "Patch")]
    internal static class RulesetImplementationManagerLocation_ApplySummonForm
    {
        internal static void Prefix(EffectForm effectForm, ApplyFormsParams formsParams)
        {
            UpcastSummonsContext.ApplyUpcastSummon(effectForm, formsParams.effectLevel);
        }

        internal static void Postfix(EffectForm effectForm)
        {
            UpcastSummonsContext.RestoreStandardSummon(effectForm);
        }
    }
}
