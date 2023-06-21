using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using RimWorld;
using Verse;

namespace Proximity;

[HarmonyPatch(typeof(StatWorker), "GetValueUnfinalized")]
public static class StatWorker_GetValueUnfinalized_Patch
{
    public static Dictionary<StatDef, int> proximityStats = new Dictionary<StatDef, int>
    {
        {StatDefOf.MoveSpeed, 1},
        {StatDefOf.GlobalLearningFactor, 2},
        {StatDefOf.PsychicSensitivity, 3},
        {StatDefOf.ToxicResistance, 4},
        {StatDefOf.NegotiationAbility, 24},
        {StatDefOf.SocialImpact, 25},
        {StatDefOf.ComfyTemperatureMin, 47},
        {StatDefOf.ComfyTemperatureMax, 48},
        {StatDefOf.ShootingAccuracyPawn, 29},
        {StatDefOf.AimingDelayFactor, 22},
        {StatDefOf.MeleeDodgeChance, 9},
        {StatDefOf.MeleeHitChance, 10},
        {StatDefOf.ImmunityGainSpeed, 23},
        {StatDefOf.MedicalTendSpeed, 32},
        {StatDefOf.MedicalTendQuality, 33},
        {ProxGlobals.StatDefOf.MedicalOperationSpeed, 34},
        {StatDefOf.MedicalSurgerySuccessChance, 35},
        {StatDefOf.AnimalGatherSpeed, 11},
        {StatDefOf.AnimalGatherYield, 27},
        {StatDefOf.ConstructionSpeed, 12},
        {StatDefOf.ConstructSuccessChance, 19},
        {StatDefOf.EatingSpeed, 13},
        {StatDefOf.HuntingStealth, 30},
        {StatDefOf.MiningSpeed, 14},
        {StatDefOf.PlantHarvestYield, 20},
        {StatDefOf.PlantWorkSpeed, 15},
        {StatDefOf.ResearchSpeed, 28},
        {StatDefOf.SmoothingSpeed, 16},
        {StatDefOf.TameAnimalChance, 21},
        {StatDefOf.TrainAnimalChance, 26},
        {StatDefOf.WorkSpeedGlobal, 18},
        {ProxGlobals.StatDefOf.ButcheryFleshSpeed, 36},
        {ProxGlobals.StatDefOf.ButcheryMechanoidSpeed, 37},
        {ProxGlobals.StatDefOf.ButcheryFleshEfficiency, 38},
        {ProxGlobals.StatDefOf.ButcheryMechanoidEfficiency, 39},
        {ProxGlobals.StatDefOf.CookSpeed, 40},
        {ProxGlobals.StatDefOf.DrugCookingSpeed, 41},
        {ProxGlobals.StatDefOf.DrugSynthesisSpeed, 42},
        {StatDefOf.FixBrokenDownBuildingSuccessChance, 31},
        {ProxGlobals.StatDefOf.SmeltingSpeed, 44},
        {ProxGlobals.StatDefOf.GeneralLaborSpeed, 49},
    };


    public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> codeInstructions)
    {
        var codes = codeInstructions.ToList();
        var statField = AccessTools.Field(typeof(StatWorker), "stat");
        var setOffsets = AccessTools.Method(typeof(StatWorker_GetValueUnfinalized_Patch), "SetOffsets");
        var patched = false;
        for (var i = 0; i < codes.Count; i++)
        {
            var code = codes[i];
            yield return code;
            if (!patched && i > 1 && codes[i].opcode == OpCodes.Brfalse && codes[i - 1].opcode == OpCodes.Ldloc_1)
            {
                yield return new CodeInstruction(OpCodes.Ldloca_S, 0);
                yield return new CodeInstruction(OpCodes.Ldarg_0);
                yield return new CodeInstruction(OpCodes.Ldfld, statField);
                yield return new CodeInstruction(OpCodes.Ldarg_S, 1);
                yield return new CodeInstruction(OpCodes.Call, setOffsets);
                patched = true;
            }
        }
    }

    public static void SetOffsets(ref float __result, StatDef stat, StatRequest req)
    {
        if (proximityStats.TryGetValue(stat, out var num))
        {
            __result += ProximityData.GetProxData(req.Thing, num);
        }
    }
}