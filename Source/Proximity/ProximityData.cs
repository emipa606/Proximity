using System.Collections.Generic;
using System.Linq;
using Verse;

namespace Proximity;

public class ProximityData : ThingComp
{
    private static readonly Dictionary<IntVec3, List<IntVec3>> cachedRadialCellsAround = new();

    private static readonly List<Thing> thingsAround = [];
    private float aimingDelayFactorOffSet;

    private float animalGatherSpeedOffSet;

    private float animalGatherYieldOffSet;

    private float butcheryFleshEfficiencyOffSet;

    private float butcheryFleshSpeedOffSet;

    private float butcheryMechanoidEfficiencyOffSet;

    private float butcheryMechanoidSpeedOffSet;

    private float comfyTemperatureMaxOffSet;

    private float comfyTemperatureMinOffSet;

    private float constructionSpeedOffSet;

    private float constructSuccessChanceOffSet;

    private float cookSpeedOffSet;

    private float drugCookingSpeedOffSet;

    private float drugSynthesisSpeedOffSet;

    private float eatingSpeedOffSet;

    private float fixBrokenDownBuildingSuccessChanceOffSet;

    private float generalLaborSpeedOffSet;

    private float globalLearningFactorOffSet;

    private float huntingStealthOffSet;

    private float immunityGainSpeedOffSet;

    private float medicalOperationSpeedOffSet;

    private float medicalSurgerySuccessChanceOffSet;

    private float medicalTendQualityOffSet;

    private float medicalTendSpeedOffSet;

    private float meleeDodgeChanceOffSet;

    private float meleeHitChanceOffSet;

    private float miningSpeedOffSet;

    private float moveSpeedOffSet;

    private float negotiationAbilityOffSet;

    private Pawn pawn;

    private float plantHarvestYieldOffSet;

    private float plantWorkSpeedOffSet;

    private int proxTick;

    private float psychicSensitivityOffSet;

    private float researchSpeedOffSet;

    private float shootingAccuracyPawnOffSet;

    //public float SculptingSpeedOffSet;

    private float smeltingSpeedOffSet;

    private float smoothingSpeedOffSet;

    private float socialImpactOffSet;

    private float tameAnimalChanceOffSet;

    private float toxicResistanceOffSet;

    private float trainAnimalChanceOffSet;

    private float workSpeedGlobalOffSet;

    private Pawn Pawn
    {
        get
        {
            pawn ??= (Pawn)parent;

            return pawn;
        }
    }

    public override void PostExposeData()
    {
        base.PostExposeData();
        Scribe_Values.Look(ref moveSpeedOffSet, "Prox_MoveSpeedOffSet");
        Scribe_Values.Look(ref globalLearningFactorOffSet, "Prox_GlobalLearningFactorOffSet");
        Scribe_Values.Look(ref negotiationAbilityOffSet, "Prox_NegotiationAbilityOffSet");
        Scribe_Values.Look(ref psychicSensitivityOffSet, "Prox_PsychicSensitivityOffSet");
        Scribe_Values.Look(ref socialImpactOffSet, "Prox_SocialImpactOffSet");
        Scribe_Values.Look(ref toxicResistanceOffSet, "Prox_ToxicSensitivityOffSet");
        Scribe_Values.Look(ref comfyTemperatureMinOffSet, "Prox_ComfyTemperatureMinOffSet");
        Scribe_Values.Look(ref comfyTemperatureMaxOffSet, "Prox_ComfyTemperatureMaxOffSet");
        Scribe_Values.Look(ref aimingDelayFactorOffSet, "Prox_AimingDelayFactorOffSet");
        Scribe_Values.Look(ref shootingAccuracyPawnOffSet, "Prox_ShootingAccuracyPawnOffSet");
        Scribe_Values.Look(ref meleeDodgeChanceOffSet, "Prox_MeleeDodgeChanceOffSet");
        Scribe_Values.Look(ref meleeHitChanceOffSet, "Prox_MeleeHitChanceOffSet");
        Scribe_Values.Look(ref immunityGainSpeedOffSet, "Prox_ImmunityGainSpeedOffSet");
        Scribe_Values.Look(ref medicalTendSpeedOffSet, "Prox_MedicalTendSpeedOffSet");
        Scribe_Values.Look(ref medicalTendQualityOffSet, "Prox_MedicalTendQualityOffSet");
        Scribe_Values.Look(ref medicalOperationSpeedOffSet, "Prox_MedicalOperationSpeedOffSet");
        Scribe_Values.Look(ref medicalSurgerySuccessChanceOffSet, "Prox_MedicalSurgerySuccessChanceOffSet");
        Scribe_Values.Look(ref animalGatherSpeedOffSet, "Prox_AnimalGatherSpeedOffSet");
        Scribe_Values.Look(ref animalGatherYieldOffSet, "Prox_AnimalGatherYieldOffSet");
        Scribe_Values.Look(ref constructionSpeedOffSet, "Prox_ConstructionSpeedOffSet");
        Scribe_Values.Look(ref constructSuccessChanceOffSet, "Prox_ConstructSuccessChanceOffSet");
        Scribe_Values.Look(ref eatingSpeedOffSet, "Prox_EatingSpeedOffSet");
        Scribe_Values.Look(ref huntingStealthOffSet, "Prox_HuntingStealthOffSet");
        Scribe_Values.Look(ref miningSpeedOffSet, "Prox_MiningSpeedOffSet");
        Scribe_Values.Look(ref plantHarvestYieldOffSet, "Prox_PlantHarvestYieldOffSet");
        Scribe_Values.Look(ref plantWorkSpeedOffSet, "Prox_PlantWorkSpeedOffSet");
        Scribe_Values.Look(ref researchSpeedOffSet, "Prox_ResearchSpeedOffSet");
        Scribe_Values.Look(ref smoothingSpeedOffSet, "Prox_SmoothingSpeedOffSet");
        Scribe_Values.Look(ref tameAnimalChanceOffSet, "Prox_TameAnimalChanceOffSet");
        Scribe_Values.Look(ref trainAnimalChanceOffSet, "Prox_TrainAnimalChanceOffSet");
        Scribe_Values.Look(ref workSpeedGlobalOffSet, "Prox_WorkSpeedGlobalOffSet");
        Scribe_Values.Look(ref butcheryFleshEfficiencyOffSet, "Prox_ButcheryFleshEfficiencyOffSet");
        Scribe_Values.Look(ref butcheryFleshSpeedOffSet, "Prox_ButcheryFleshSpeedOffSet");
        Scribe_Values.Look(ref butcheryMechanoidEfficiencyOffSet, "Prox_ButcheryMechanoidEfficiencyOffSet");
        Scribe_Values.Look(ref butcheryMechanoidSpeedOffSet, "Prox_ButcheryMechanoidSpeedOffSet");
        Scribe_Values.Look(ref cookSpeedOffSet, "Prox_CookSpeedOffSet");
        Scribe_Values.Look(ref drugCookingSpeedOffSet, "Prox_DrugCookingSpeedOffSet");
        Scribe_Values.Look(ref drugSynthesisSpeedOffSet, "Prox_DrugSynthesisSpeedOffSet");
        Scribe_Values.Look(ref fixBrokenDownBuildingSuccessChanceOffSet,
            "Prox_FixBrokenDownBuildingSuccessChanceOffSet");
        Scribe_Values.Look(ref smeltingSpeedOffSet, "Prox_SmeltingSpeedOffSet");
        Scribe_Values.Look(ref generalLaborSpeedOffSet, "Prox_GeneralLaborSpeedOffSet");
        Scribe_Values.Look(ref proxTick, "ProxTick");
    }

    public override void CompTick()
    {
        if (Find.TickManager.TicksGame <= proxTick)
        {
            return;
        }

        var localPawn = Pawn;
        var pawnMap = localPawn.Map;
        var pawnPos = localPawn.Position;
        proximityStatReset();
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
                proximityStatSet(thing);
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
                proximityTStatSet(terrainDef);
            }
        }

        proxTick = Find.TickManager.TicksGame + ProxGlobals.ExtendTicks();
    }

    private void proximityStatReset()
    {
        moveSpeedOffSet = 0f;
        globalLearningFactorOffSet = 0f;
        negotiationAbilityOffSet = 0f;
        psychicSensitivityOffSet = 0f;
        socialImpactOffSet = 0f;
        toxicResistanceOffSet = 0f;
        comfyTemperatureMinOffSet = 0f;
        comfyTemperatureMaxOffSet = 0f;
        aimingDelayFactorOffSet = 0f;
        shootingAccuracyPawnOffSet = 0f;
        meleeDodgeChanceOffSet = 0f;
        meleeHitChanceOffSet = 0f;
        immunityGainSpeedOffSet = 0f;
        medicalTendSpeedOffSet = 0f;
        medicalTendQualityOffSet = 0f;
        medicalOperationSpeedOffSet = 0f;
        medicalSurgerySuccessChanceOffSet = 0f;
        animalGatherSpeedOffSet = 0f;
        animalGatherYieldOffSet = 0f;
        constructionSpeedOffSet = 0f;
        constructSuccessChanceOffSet = 0f;
        eatingSpeedOffSet = 0f;
        huntingStealthOffSet = 0f;
        miningSpeedOffSet = 0f;
        plantHarvestYieldOffSet = 0f;
        plantWorkSpeedOffSet = 0f;
        researchSpeedOffSet = 0f;
        smoothingSpeedOffSet = 0f;
        tameAnimalChanceOffSet = 0f;
        trainAnimalChanceOffSet = 0f;
        workSpeedGlobalOffSet = 0f;
        butcheryFleshSpeedOffSet = 0f;
        butcheryMechanoidSpeedOffSet = 0f;
        butcheryFleshEfficiencyOffSet = 0f;
        butcheryMechanoidEfficiencyOffSet = 0f;
        cookSpeedOffSet = 0f;
        drugCookingSpeedOffSet = 0f;
        drugSynthesisSpeedOffSet = 0f;
        fixBrokenDownBuildingSuccessChanceOffSet = 0f;
        smeltingSpeedOffSet = 0f;
        generalLaborSpeedOffSet = 0f;
    }

    private void proximityStatSet(Thing thing)
    {
        var proxQualFactor = ProxGlobals.GetProxQualFactor(thing);
        tryAddValue(proxQualFactor, ProximityGet.GetProxMoveSpeedOffSet(thing.def), ref moveSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxGlobalLearningFactorOffSet(thing.def),
            ref globalLearningFactorOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxNegotiationAbilityOffSet(thing.def),
            ref negotiationAbilityOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxPsychicSensitivityOffSet(thing.def),
            ref psychicSensitivityOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxSocialImpactOffSet(thing.def), ref socialImpactOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxToxicResistanceOffSet(thing.def), ref toxicResistanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxComfyTemperatureMinOffSet(thing.def),
            ref comfyTemperatureMinOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxComfyTemperatureMaxOffSet(thing.def),
            ref comfyTemperatureMaxOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxAimingDelayFactorOffSet(thing.def),
            ref aimingDelayFactorOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxShootingAccuracyPawnOffSet(thing.def),
            ref shootingAccuracyPawnOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxMeleeDodgeChanceOffSet(thing.def), ref meleeDodgeChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxMeleeHitChanceOffSet(thing.def), ref meleeHitChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxImmunityGainSpeedOffSet(thing.def),
            ref immunityGainSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxMedicalTendSpeedOffSet(thing.def), ref medicalTendSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxMedicalTendQualityOffSet(thing.def),
            ref medicalTendQualityOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxMedicalOperationSpeedOffSet(thing.def),
            ref medicalOperationSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxMedicalSurgerySuccessChanceOffSet(thing.def),
            ref medicalSurgerySuccessChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxAnimalGatherSpeedOffSet(thing.def),
            ref animalGatherSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxAnimalGatherYieldOffSet(thing.def),
            ref animalGatherYieldOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxConstructionSpeedOffSet(thing.def),
            ref constructionSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxConstructSuccessChanceOffSet(thing.def),
            ref constructSuccessChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxEatingSpeedOffSet(thing.def), ref eatingSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxHuntingStealthOffSet(thing.def), ref huntingStealthOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxMiningSpeedOffSet(thing.def), ref miningSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxPlantHarvestYieldOffSet(thing.def),
            ref plantHarvestYieldOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxPlantWorkSpeedOffSet(thing.def), ref plantWorkSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxResearchSpeedOffSet(thing.def), ref researchSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxSmoothingSpeedOffSet(thing.def), ref smoothingSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxTameAnimalChanceOffSet(thing.def), ref tameAnimalChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxTrainAnimalChanceOffSet(thing.def),
            ref trainAnimalChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxWorkSpeedGlobalOffSet(thing.def), ref workSpeedGlobalOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxButcheryFleshSpeedOffSet(thing.def),
            ref butcheryFleshSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxButcheryMechanoidSpeedOffSet(thing.def),
            ref butcheryMechanoidSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxButcheryFleshEfficiencyOffSet(thing.def),
            ref butcheryFleshEfficiencyOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxButcheryMechanoidEfficiencyOffSet(thing.def),
            ref butcheryMechanoidEfficiencyOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxCookSpeedOffSet(thing.def), ref cookSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxDrugCookingSpeedOffSet(thing.def), ref drugCookingSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxDrugSynthesisSpeedOffSet(thing.def),
            ref drugSynthesisSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxFixBrokenDownBuildingSuccessChanceOffSet(thing.def),
            ref fixBrokenDownBuildingSuccessChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxSmeltingSpeedOffSet(thing.def), ref smeltingSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetProxGeneralLaborSpeedOffSet(thing.def),
            ref generalLaborSpeedOffSet);
    }

    private void proximityTStatSet(TerrainDef terrain)
    {
        var proxQualFactor = 1f;
        tryAddValue(proxQualFactor, ProximityGet.GetTProxMoveSpeedOffSet(terrain), ref moveSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxGlobalLearningFactorOffSet(terrain),
            ref globalLearningFactorOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxNegotiationAbilityOffSet(terrain),
            ref negotiationAbilityOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxPsychicSensitivityOffSet(terrain),
            ref psychicSensitivityOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxSocialImpactOffSet(terrain), ref socialImpactOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxToxicResistanceOffSet(terrain), ref toxicResistanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxComfyTemperatureMinOffSet(terrain),
            ref comfyTemperatureMinOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxComfyTemperatureMaxOffSet(terrain),
            ref comfyTemperatureMaxOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxAimingDelayFactorOffSet(terrain), ref aimingDelayFactorOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxShootingAccuracyPawnOffSet(terrain),
            ref shootingAccuracyPawnOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxMeleeDodgeChanceOffSet(terrain), ref meleeDodgeChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxMeleeHitChanceOffSet(terrain), ref meleeHitChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxImmunityGainSpeedOffSet(terrain), ref immunityGainSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxMedicalTendSpeedOffSet(terrain), ref medicalTendSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxMedicalTendQualityOffSet(terrain),
            ref medicalTendQualityOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxMedicalOperationSpeedOffSet(terrain),
            ref medicalOperationSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxMedicalSurgerySuccessChanceOffSet(terrain),
            ref medicalSurgerySuccessChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxAnimalGatherSpeedOffSet(terrain), ref animalGatherSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxAnimalGatherYieldOffSet(terrain), ref animalGatherYieldOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxConstructionSpeedOffSet(terrain), ref constructionSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxConstructSuccessChanceOffSet(terrain),
            ref constructSuccessChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxEatingSpeedOffSet(terrain), ref eatingSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxHuntingStealthOffSet(terrain), ref huntingStealthOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxMiningSpeedOffSet(terrain), ref miningSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxPlantHarvestYieldOffSet(terrain), ref plantHarvestYieldOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxPlantWorkSpeedOffSet(terrain), ref plantWorkSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxResearchSpeedOffSet(terrain), ref researchSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxSmoothingSpeedOffSet(terrain), ref smoothingSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxTameAnimalChanceOffSet(terrain), ref tameAnimalChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxTrainAnimalChanceOffSet(terrain), ref trainAnimalChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxWorkSpeedGlobalOffSet(terrain), ref workSpeedGlobalOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxButcheryFleshSpeedOffSet(terrain),
            ref butcheryFleshSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxButcheryMechanoidSpeedOffSet(terrain),
            ref butcheryMechanoidSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxButcheryFleshEfficiencyOffSet(terrain),
            ref butcheryFleshEfficiencyOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxButcheryMechanoidEfficiencyOffSet(terrain),
            ref butcheryMechanoidEfficiencyOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxCookSpeedOffSet(terrain), ref cookSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxDrugCookingSpeedOffSet(terrain), ref drugCookingSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxDrugSynthesisSpeedOffSet(terrain),
            ref drugSynthesisSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxFixBrokenDownBuildingSuccessChanceOffSet(terrain),
            ref fixBrokenDownBuildingSuccessChanceOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxSmeltingSpeedOffSet(terrain), ref smeltingSpeedOffSet);
        tryAddValue(proxQualFactor, ProximityGet.GetTProxGeneralLaborSpeedOffSet(terrain), ref generalLaborSpeedOffSet);
    }

    private static void tryAddValue(float proxQualFactor, float value, ref float field)
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
                return proximityData.moveSpeedOffSet;
            case 2:
                return proximityData.globalLearningFactorOffSet;
            case 3:
                return proximityData.psychicSensitivityOffSet;
            case 4:
                return proximityData.toxicResistanceOffSet;
            case 9:
                return proximityData.meleeDodgeChanceOffSet;
            case 10:
                return proximityData.meleeHitChanceOffSet;
            case 11:
                return proximityData.animalGatherSpeedOffSet;
            case 12:
                return proximityData.constructionSpeedOffSet;
            case 13:
                return proximityData.eatingSpeedOffSet;
            case 14:
                return proximityData.miningSpeedOffSet;
            case 15:
                return proximityData.plantWorkSpeedOffSet;
            case 16:
                return proximityData.smoothingSpeedOffSet;
            case 18:
                return proximityData.workSpeedGlobalOffSet;
            case 19:
                return proximityData.constructSuccessChanceOffSet;
            case 20:
                return proximityData.plantHarvestYieldOffSet;
            case 21:
                return proximityData.tameAnimalChanceOffSet;
            case 22:
                return proximityData.aimingDelayFactorOffSet;
            case 23:
                return proximityData.immunityGainSpeedOffSet;
            case 24:
                return proximityData.negotiationAbilityOffSet;
            case 25:
                return proximityData.socialImpactOffSet;
            case 26:
                return proximityData.trainAnimalChanceOffSet;
            case 27:
                return proximityData.animalGatherYieldOffSet;
            case 28:
                return proximityData.researchSpeedOffSet;
            case 29:
                return proximityData.shootingAccuracyPawnOffSet;
            case 30:
                return proximityData.huntingStealthOffSet;
            case 31:
                return proximityData.fixBrokenDownBuildingSuccessChanceOffSet;
            case 32:
                return proximityData.medicalTendSpeedOffSet;
            case 33:
                return proximityData.medicalTendQualityOffSet;
            case 34:
                return proximityData.medicalOperationSpeedOffSet;
            case 35:
                return proximityData.medicalSurgerySuccessChanceOffSet;
            case 36:
                return proximityData.butcheryFleshSpeedOffSet;
            case 37:
                return proximityData.butcheryMechanoidSpeedOffSet;
            case 38:
                return proximityData.butcheryFleshEfficiencyOffSet;
            case 39:
                return proximityData.butcheryMechanoidEfficiencyOffSet;
            case 40:
                return proximityData.cookSpeedOffSet;
            case 41:
                return proximityData.drugCookingSpeedOffSet;
            case 42:
                return proximityData.drugSynthesisSpeedOffSet;
            case 44:
                return proximityData.smeltingSpeedOffSet;
            case 47:
                return proximityData.comfyTemperatureMinOffSet;
            case 48:
                return proximityData.comfyTemperatureMaxOffSet;
            case 49:
                return proximityData.generalLaborSpeedOffSet;
        }

        result = 0f;

        return result;
    }
}