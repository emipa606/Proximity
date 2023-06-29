using System.Collections.Generic;
using System.Linq;
using Verse;

namespace Proximity;

public class ProximityData : ThingComp
{
    private static readonly Dictionary<IntVec3, List<IntVec3>> cachedRadialCellsAround =
        new Dictionary<IntVec3, List<IntVec3>>();

    private static readonly List<Thing> thingsAround = new List<Thing>();
    public float AimingDelayFactorOffSet;

    public float AnimalGatherSpeedOffSet;

    public float AnimalGatherYieldOffSet;

    public float ButcheryFleshEfficiencyOffSet;

    public float ButcheryFleshSpeedOffSet;

    public float ButcheryMechanoidEfficiencyOffSet;

    public float ButcheryMechanoidSpeedOffSet;

    public float ComfyTemperatureMaxOffSet;

    public float ComfyTemperatureMinOffSet;

    public float ConstructionSpeedOffSet;

    public float ConstructSuccessChanceOffSet;

    public float CookSpeedOffSet;

    public float DrugCookingSpeedOffSet;

    public float DrugSynthesisSpeedOffSet;

    public float EatingSpeedOffSet;

    public float FixBrokenDownBuildingSuccessChanceOffSet;

    public float GeneralLaborSpeedOffSet;

    public float GlobalLearningFactorOffSet;

    public float HuntingStealthOffSet;

    public float ImmunityGainSpeedOffSet;

    public float MedicalOperationSpeedOffSet;

    public float MedicalSurgerySuccessChanceOffSet;

    public float MedicalTendQualityOffSet;

    public float MedicalTendSpeedOffSet;

    public float MeleeDodgeChanceOffSet;

    public float MeleeHitChanceOffSet;

    public float MiningSpeedOffSet;

    public float MoveSpeedOffSet;

    public float NegotiationAbilityOffSet;

    private Pawn pawn;

    public float PlantHarvestYieldOffSet;

    public float PlantWorkSpeedOffSet;

    public int ProxTick;

    public float PsychicSensitivityOffSet;

    public float ResearchSpeedOffSet;

    public float ShootingAccuracyPawnOffSet;

    //public float SculptingSpeedOffSet;

    public float SmeltingSpeedOffSet;

    public float SmoothingSpeedOffSet;

    public float SocialImpactOffSet;

    public float TameAnimalChanceOffSet;

    public float ToxicResistanceOffSet;

    public float TrainAnimalChanceOffSet;

    public float WorkSpeedGlobalOffSet;

    private Pawn Pawn
    {
        get
        {
            if (pawn == null)
            {
                pawn = (Pawn)parent;
            }

            return pawn;
        }
    }

    public override void PostExposeData()
    {
        base.PostExposeData();
        Scribe_Values.Look(ref MoveSpeedOffSet, "Prox_MoveSpeedOffSet");
        Scribe_Values.Look(ref GlobalLearningFactorOffSet, "Prox_GlobalLearningFactorOffSet");
        Scribe_Values.Look(ref NegotiationAbilityOffSet, "Prox_NegotiationAbilityOffSet");
        Scribe_Values.Look(ref PsychicSensitivityOffSet, "Prox_PsychicSensitivityOffSet");
        Scribe_Values.Look(ref SocialImpactOffSet, "Prox_SocialImpactOffSet");
        Scribe_Values.Look(ref ToxicResistanceOffSet, "Prox_ToxicSensitivityOffSet");
        Scribe_Values.Look(ref ComfyTemperatureMinOffSet, "Prox_ComfyTemperatureMinOffSet");
        Scribe_Values.Look(ref ComfyTemperatureMaxOffSet, "Prox_ComfyTemperatureMaxOffSet");
        Scribe_Values.Look(ref AimingDelayFactorOffSet, "Prox_AimingDelayFactorOffSet");
        Scribe_Values.Look(ref ShootingAccuracyPawnOffSet, "Prox_ShootingAccuracyPawnOffSet");
        Scribe_Values.Look(ref MeleeDodgeChanceOffSet, "Prox_MeleeDodgeChanceOffSet");
        Scribe_Values.Look(ref MeleeHitChanceOffSet, "Prox_MeleeHitChanceOffSet");
        Scribe_Values.Look(ref ImmunityGainSpeedOffSet, "Prox_ImmunityGainSpeedOffSet");
        Scribe_Values.Look(ref MedicalTendSpeedOffSet, "Prox_MedicalTendSpeedOffSet");
        Scribe_Values.Look(ref MedicalTendQualityOffSet, "Prox_MedicalTendQualityOffSet");
        Scribe_Values.Look(ref MedicalOperationSpeedOffSet, "Prox_MedicalOperationSpeedOffSet");
        Scribe_Values.Look(ref MedicalSurgerySuccessChanceOffSet, "Prox_MedicalSurgerySuccessChanceOffSet");
        Scribe_Values.Look(ref AnimalGatherSpeedOffSet, "Prox_AnimalGatherSpeedOffSet");
        Scribe_Values.Look(ref AnimalGatherYieldOffSet, "Prox_AnimalGatherYieldOffSet");
        Scribe_Values.Look(ref ConstructionSpeedOffSet, "Prox_ConstructionSpeedOffSet");
        Scribe_Values.Look(ref ConstructSuccessChanceOffSet, "Prox_ConstructSuccessChanceOffSet");
        Scribe_Values.Look(ref EatingSpeedOffSet, "Prox_EatingSpeedOffSet");
        Scribe_Values.Look(ref HuntingStealthOffSet, "Prox_HuntingStealthOffSet");
        Scribe_Values.Look(ref MiningSpeedOffSet, "Prox_MiningSpeedOffSet");
        Scribe_Values.Look(ref PlantHarvestYieldOffSet, "Prox_PlantHarvestYieldOffSet");
        Scribe_Values.Look(ref PlantWorkSpeedOffSet, "Prox_PlantWorkSpeedOffSet");
        Scribe_Values.Look(ref ResearchSpeedOffSet, "Prox_ResearchSpeedOffSet");
        Scribe_Values.Look(ref SmoothingSpeedOffSet, "Prox_SmoothingSpeedOffSet");
        Scribe_Values.Look(ref TameAnimalChanceOffSet, "Prox_TameAnimalChanceOffSet");
        Scribe_Values.Look(ref TrainAnimalChanceOffSet, "Prox_TrainAnimalChanceOffSet");
        Scribe_Values.Look(ref WorkSpeedGlobalOffSet, "Prox_WorkSpeedGlobalOffSet");
        Scribe_Values.Look(ref ButcheryFleshEfficiencyOffSet, "Prox_ButcheryFleshEfficiencyOffSet");
        Scribe_Values.Look(ref ButcheryFleshSpeedOffSet, "Prox_ButcheryFleshSpeedOffSet");
        Scribe_Values.Look(ref ButcheryMechanoidEfficiencyOffSet, "Prox_ButcheryMechanoidEfficiencyOffSet");
        Scribe_Values.Look(ref ButcheryMechanoidSpeedOffSet, "Prox_ButcheryMechanoidSpeedOffSet");
        Scribe_Values.Look(ref CookSpeedOffSet, "Prox_CookSpeedOffSet");
        Scribe_Values.Look(ref DrugCookingSpeedOffSet, "Prox_DrugCookingSpeedOffSet");
        Scribe_Values.Look(ref DrugSynthesisSpeedOffSet, "Prox_DrugSynthesisSpeedOffSet");
        Scribe_Values.Look(ref FixBrokenDownBuildingSuccessChanceOffSet,
            "Prox_FixBrokenDownBuildingSuccessChanceOffSet");
        Scribe_Values.Look(ref SmeltingSpeedOffSet, "Prox_SmeltingSpeedOffSet");
        Scribe_Values.Look(ref GeneralLaborSpeedOffSet, "Prox_GeneralLaborSpeedOffSet");
        Scribe_Values.Look(ref ProxTick, "ProxTick");
    }

    public override void CompTick()
    {
        if (Find.TickManager.TicksGame <= ProxTick)
        {
            return;
        }

        var localPawn = Pawn;
        var pawnMap = localPawn.Map;
        var pawnPos = localPawn.Position;
        ProximityStatReset();
        if (pawnMap != null)
        {
            thingsAround.Clear();
            foreach (var def in ProxGlobals.ProximityThings)
            {
                thingsAround.AddRange(pawnMap.listerThings.ThingsOfDef(def)
                    .Where(x => x.Position.DistanceTo(pawnPos) <= ProxGlobals.closeRange).ToList());
            }

            foreach (var thing in thingsAround)
            {
                if (!ProxGlobals.IsNearThingValid(thing, localPawn) || !ProxGlobals.NearThingEffects(thing, localPawn))
                {
                    continue;
                }

                var proxRange = ProximityGet.GetProxRange(thing.def);
                if (!ProxGlobals.NearThingInRange(thing, localPawn, proxRange))
                {
                    continue;
                }

                ProxGlobals.ProximityHediffEffect(thing, localPawn);
                ProximityStatSet(thing);
            }

            if (!cachedRadialCellsAround.TryGetValue(pawnPos, out var cells))
            {
                cachedRadialCellsAround[pawnPos] = cells = GenRadial
                    .RadialCellsAround(pawnPos, ProxGlobals.closeRange, true)
                    .ToList();
            }

            foreach (var cell in cells)
            {
                var inBounds = cell.InBounds(pawnMap);
                var terrainDef = inBounds ? cell.GetTerrain(pawnMap) : null;
                if (terrainDef == null || !ProxGlobals.ProximityTerrains.Contains(terrainDef) ||
                    !ProxGlobals.TerrainEffects(terrainDef, cell, localPawn))
                {
                    continue;
                }

                var tproxRange = ProximityGet.GetTProxRange(terrainDef);
                if (!ProxGlobals.TerrainInRange(terrainDef, cell, localPawn, tproxRange))
                {
                    continue;
                }

                ProxGlobals.ProximityTerrainHediffEffect(terrainDef, cell, localPawn);
                ProximityTStatSet(terrainDef);
            }
        }

        ProxTick = Find.TickManager.TicksGame + ProxGlobals.ExtendTicks();
    }

    internal void ProximityStatReset()
    {
        MoveSpeedOffSet = 0f;
        GlobalLearningFactorOffSet = 0f;
        NegotiationAbilityOffSet = 0f;
        PsychicSensitivityOffSet = 0f;
        SocialImpactOffSet = 0f;
        ToxicResistanceOffSet = 0f;
        ComfyTemperatureMinOffSet = 0f;
        ComfyTemperatureMaxOffSet = 0f;
        AimingDelayFactorOffSet = 0f;
        ShootingAccuracyPawnOffSet = 0f;
        MeleeDodgeChanceOffSet = 0f;
        MeleeHitChanceOffSet = 0f;
        ImmunityGainSpeedOffSet = 0f;
        MedicalTendSpeedOffSet = 0f;
        MedicalTendQualityOffSet = 0f;
        MedicalOperationSpeedOffSet = 0f;
        MedicalSurgerySuccessChanceOffSet = 0f;
        AnimalGatherSpeedOffSet = 0f;
        AnimalGatherYieldOffSet = 0f;
        ConstructionSpeedOffSet = 0f;
        ConstructSuccessChanceOffSet = 0f;
        EatingSpeedOffSet = 0f;
        HuntingStealthOffSet = 0f;
        MiningSpeedOffSet = 0f;
        PlantHarvestYieldOffSet = 0f;
        PlantWorkSpeedOffSet = 0f;
        ResearchSpeedOffSet = 0f;
        SmoothingSpeedOffSet = 0f;
        TameAnimalChanceOffSet = 0f;
        TrainAnimalChanceOffSet = 0f;
        WorkSpeedGlobalOffSet = 0f;
        ButcheryFleshSpeedOffSet = 0f;
        ButcheryMechanoidSpeedOffSet = 0f;
        ButcheryFleshEfficiencyOffSet = 0f;
        ButcheryMechanoidEfficiencyOffSet = 0f;
        CookSpeedOffSet = 0f;
        DrugCookingSpeedOffSet = 0f;
        DrugSynthesisSpeedOffSet = 0f;
        FixBrokenDownBuildingSuccessChanceOffSet = 0f;
        SmeltingSpeedOffSet = 0f;
        GeneralLaborSpeedOffSet = 0f;
    }

    internal void ProximityStatSet(Thing thing)
    {
        var proxQualFactor = ProxGlobals.GetProxQualFactor(thing);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMoveSpeedOffSet(thing.def), ref MoveSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxGlobalLearningFactorOffSet(thing.def),
            ref GlobalLearningFactorOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxNegotiationAbilityOffSet(thing.def),
            ref NegotiationAbilityOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxPsychicSensitivityOffSet(thing.def),
            ref PsychicSensitivityOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxSocialImpactOffSet(thing.def), ref SocialImpactOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxToxicResistanceOffSet(thing.def), ref ToxicResistanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxComfyTemperatureMinOffSet(thing.def),
            ref ComfyTemperatureMinOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxComfyTemperatureMaxOffSet(thing.def),
            ref ComfyTemperatureMaxOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxAimingDelayFactorOffSet(thing.def),
            ref AimingDelayFactorOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxShootingAccuracyPawnOffSet(thing.def),
            ref ShootingAccuracyPawnOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMeleeDodgeChanceOffSet(thing.def), ref MeleeDodgeChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMeleeHitChanceOffSet(thing.def), ref MeleeHitChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxImmunityGainSpeedOffSet(thing.def),
            ref ImmunityGainSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMedicalTendSpeedOffSet(thing.def), ref MedicalTendSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMedicalTendQualityOffSet(thing.def),
            ref MedicalTendQualityOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMedicalOperationSpeedOffSet(thing.def),
            ref MedicalOperationSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMedicalSurgerySuccessChanceOffSet(thing.def),
            ref MedicalSurgerySuccessChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxAnimalGatherSpeedOffSet(thing.def),
            ref AnimalGatherSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxAnimalGatherYieldOffSet(thing.def),
            ref AnimalGatherYieldOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxConstructionSpeedOffSet(thing.def),
            ref ConstructionSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxConstructSuccessChanceOffSet(thing.def),
            ref ConstructSuccessChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxEatingSpeedOffSet(thing.def), ref EatingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxHuntingStealthOffSet(thing.def), ref HuntingStealthOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMiningSpeedOffSet(thing.def), ref MiningSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxPlantHarvestYieldOffSet(thing.def),
            ref PlantHarvestYieldOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxPlantWorkSpeedOffSet(thing.def), ref PlantWorkSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxResearchSpeedOffSet(thing.def), ref ResearchSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxSmoothingSpeedOffSet(thing.def), ref SmoothingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxTameAnimalChanceOffSet(thing.def), ref TameAnimalChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxTrainAnimalChanceOffSet(thing.def),
            ref TrainAnimalChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxWorkSpeedGlobalOffSet(thing.def), ref WorkSpeedGlobalOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxButcheryFleshSpeedOffSet(thing.def),
            ref ButcheryFleshSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxButcheryMechanoidSpeedOffSet(thing.def),
            ref ButcheryMechanoidSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxButcheryFleshEfficiencyOffSet(thing.def),
            ref ButcheryFleshEfficiencyOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxButcheryMechanoidEfficiencyOffSet(thing.def),
            ref ButcheryMechanoidEfficiencyOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxCookSpeedOffSet(thing.def), ref CookSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxDrugCookingSpeedOffSet(thing.def), ref DrugCookingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxDrugSynthesisSpeedOffSet(thing.def),
            ref DrugSynthesisSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxFixBrokenDownBuildingSuccessChanceOffSet(thing.def),
            ref FixBrokenDownBuildingSuccessChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxSmeltingSpeedOffSet(thing.def), ref SmeltingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxGeneralLaborSpeedOffSet(thing.def),
            ref GeneralLaborSpeedOffSet);
    }

    internal void ProximityTStatSet(TerrainDef terrain)
    {
        var proxQualFactor = 1f;
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMoveSpeedOffSet(terrain), ref MoveSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxGlobalLearningFactorOffSet(terrain),
            ref GlobalLearningFactorOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxNegotiationAbilityOffSet(terrain),
            ref NegotiationAbilityOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxPsychicSensitivityOffSet(terrain),
            ref PsychicSensitivityOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxSocialImpactOffSet(terrain), ref SocialImpactOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxToxicResistanceOffSet(terrain), ref ToxicResistanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxComfyTemperatureMinOffSet(terrain),
            ref ComfyTemperatureMinOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxComfyTemperatureMaxOffSet(terrain),
            ref ComfyTemperatureMaxOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxAimingDelayFactorOffSet(terrain), ref AimingDelayFactorOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxShootingAccuracyPawnOffSet(terrain),
            ref ShootingAccuracyPawnOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMeleeDodgeChanceOffSet(terrain), ref MeleeDodgeChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMeleeHitChanceOffSet(terrain), ref MeleeHitChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxImmunityGainSpeedOffSet(terrain), ref ImmunityGainSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMedicalTendSpeedOffSet(terrain), ref MedicalTendSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMedicalTendQualityOffSet(terrain),
            ref MedicalTendQualityOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMedicalOperationSpeedOffSet(terrain),
            ref MedicalOperationSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMedicalSurgerySuccessChanceOffSet(terrain),
            ref MedicalSurgerySuccessChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxAnimalGatherSpeedOffSet(terrain), ref AnimalGatherSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxAnimalGatherYieldOffSet(terrain), ref AnimalGatherYieldOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxConstructionSpeedOffSet(terrain), ref ConstructionSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxConstructSuccessChanceOffSet(terrain),
            ref ConstructSuccessChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxEatingSpeedOffSet(terrain), ref EatingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxHuntingStealthOffSet(terrain), ref HuntingStealthOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMiningSpeedOffSet(terrain), ref MiningSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxPlantHarvestYieldOffSet(terrain), ref PlantHarvestYieldOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxPlantWorkSpeedOffSet(terrain), ref PlantWorkSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxResearchSpeedOffSet(terrain), ref ResearchSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxSmoothingSpeedOffSet(terrain), ref SmoothingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxTameAnimalChanceOffSet(terrain), ref TameAnimalChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxTrainAnimalChanceOffSet(terrain), ref TrainAnimalChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxWorkSpeedGlobalOffSet(terrain), ref WorkSpeedGlobalOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxButcheryFleshSpeedOffSet(terrain),
            ref ButcheryFleshSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxButcheryMechanoidSpeedOffSet(terrain),
            ref ButcheryMechanoidSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxButcheryFleshEfficiencyOffSet(terrain),
            ref ButcheryFleshEfficiencyOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxButcheryMechanoidEfficiencyOffSet(terrain),
            ref ButcheryMechanoidEfficiencyOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxCookSpeedOffSet(terrain), ref CookSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxDrugCookingSpeedOffSet(terrain), ref DrugCookingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxDrugSynthesisSpeedOffSet(terrain),
            ref DrugSynthesisSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxFixBrokenDownBuildingSuccessChanceOffSet(terrain),
            ref FixBrokenDownBuildingSuccessChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxSmeltingSpeedOffSet(terrain), ref SmeltingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxGeneralLaborSpeedOffSet(terrain), ref GeneralLaborSpeedOffSet);
    }

    private void TryAddValue(float proxQualFactor, float value, ref float field)
    {
        if (value != 0f)
        {
            field += proxQualFactor * value;
        }
    }

    internal static float GetProxData(Thing thing, int num)
    {
        var result = 0f;
        var proximityData = thing?.TryGetComp<ProximityData>();
        if (proximityData == null)
        {
            return result;
        }

        switch (num)
        {
            case 1:
                return proximityData.MoveSpeedOffSet;
            case 2:
                return proximityData.GlobalLearningFactorOffSet;
            case 3:
                return proximityData.PsychicSensitivityOffSet;
            case 4:
                return proximityData.ToxicResistanceOffSet;
            case 9:
                return proximityData.MeleeDodgeChanceOffSet;
            case 10:
                return proximityData.MeleeHitChanceOffSet;
            case 11:
                return proximityData.AnimalGatherSpeedOffSet;
            case 12:
                return proximityData.ConstructionSpeedOffSet;
            case 13:
                return proximityData.EatingSpeedOffSet;
            case 14:
                return proximityData.MiningSpeedOffSet;
            case 15:
                return proximityData.PlantWorkSpeedOffSet;
            case 16:
                return proximityData.SmoothingSpeedOffSet;
            case 18:
                return proximityData.WorkSpeedGlobalOffSet;
            case 19:
                return proximityData.ConstructSuccessChanceOffSet;
            case 20:
                return proximityData.PlantHarvestYieldOffSet;
            case 21:
                return proximityData.TameAnimalChanceOffSet;
            case 22:
                return proximityData.AimingDelayFactorOffSet;
            case 23:
                return proximityData.ImmunityGainSpeedOffSet;
            case 24:
                return proximityData.NegotiationAbilityOffSet;
            case 25:
                return proximityData.SocialImpactOffSet;
            case 26:
                return proximityData.TrainAnimalChanceOffSet;
            case 27:
                return proximityData.AnimalGatherYieldOffSet;
            case 28:
                return proximityData.ResearchSpeedOffSet;
            case 29:
                return proximityData.ShootingAccuracyPawnOffSet;
            case 30:
                return proximityData.HuntingStealthOffSet;
            case 31:
                return proximityData.FixBrokenDownBuildingSuccessChanceOffSet;
            case 32:
                return proximityData.MedicalTendSpeedOffSet;
            case 33:
                return proximityData.MedicalTendQualityOffSet;
            case 34:
                return proximityData.MedicalOperationSpeedOffSet;
            case 35:
                return proximityData.MedicalSurgerySuccessChanceOffSet;
            case 36:
                return proximityData.ButcheryFleshSpeedOffSet;
            case 37:
                return proximityData.ButcheryMechanoidSpeedOffSet;
            case 38:
                return proximityData.ButcheryFleshEfficiencyOffSet;
            case 39:
                return proximityData.ButcheryMechanoidEfficiencyOffSet;
            case 40:
                return proximityData.CookSpeedOffSet;
            case 41:
                return proximityData.DrugCookingSpeedOffSet;
            case 42:
                return proximityData.DrugSynthesisSpeedOffSet;
            case 44:
                return proximityData.SmeltingSpeedOffSet;
            case 47:
                return proximityData.ComfyTemperatureMinOffSet;
            case 48:
                return proximityData.ComfyTemperatureMaxOffSet;
            case 49:
                return proximityData.GeneralLaborSpeedOffSet;
        }

        result = 0f;

        return result;
    }
}