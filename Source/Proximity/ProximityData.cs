using System.Collections.Generic;
using System.Linq;
using Verse;

namespace Proximity;

public class ProximityData : ThingComp
{
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

    private Pawn pawn;
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

    private static Dictionary<IntVec3, List<IntVec3>> cachedRadialCellsAround = new Dictionary<IntVec3, List<IntVec3>>();
    
    private static List<Thing> thingsAround = new List<Thing>();

    public override void CompTick()
    {
        if (Find.TickManager.TicksGame <= ProxTick)
        {
            return;
        }
        var pawn = Pawn;
        var pawnMap = pawn.Map;
        var pawnPos = pawn.Position;
        ProximityStatReset();
        if (pawnMap != null)
        {
            thingsAround.Clear();
            foreach (var def in ProxGlobals.ProximityThings)
            {
                thingsAround.AddRange(pawnMap.listerThings.ThingsOfDef(def).Where(x => x.Position.DistanceTo(pawnPos) <= ProxGlobals.closeRange).ToList());
            }
            foreach (var thing in thingsAround)
            {
                if (!ProxGlobals.IsNearThingValid(thing, pawn) || !ProxGlobals.NearThingEffects(thing, pawn))
                {
                    continue;
                }

                var proxRange = ProximityGet.GetProxRange(thing.def);
                if (!ProxGlobals.NearThingInRange(thing, pawn, proxRange))
                {
                    continue;
                }

                ProxGlobals.ProximityHediffEffect(thing, pawn);
                ProximityStatSet(thing);
            }
            if (!cachedRadialCellsAround.TryGetValue(pawnPos, out var cells))
            {
                cachedRadialCellsAround[pawnPos] = cells = GenRadial.RadialCellsAround(pawnPos, ProxGlobals.closeRange, true)
                    .ToList();
            }

            foreach (var cell in cells)
            {
                bool inBounds = cell.InBounds(pawnMap);
                var terrainDef = inBounds ? cell.GetTerrain(pawnMap) : null;
                if (terrainDef == null || !ProxGlobals.ProximityTerrains.Contains(terrainDef) ||
                    !ProxGlobals.TerrainEffects(terrainDef, cell, pawn))
                {
                    continue;
                }

                var tproxRange = ProximityGet.GetTProxRange(terrainDef);
                if (!ProxGlobals.TerrainInRange(terrainDef, cell, pawn, tproxRange))
                {
                    continue;
                }

                ProxGlobals.ProximityTerrainHediffEffect(terrainDef, cell, pawn);
                ProximityTStatSet(terrainDef);
            }
        }

        ProxTick = Find.TickManager.TicksGame + ProxGlobals.ExtendTicks();
    }

    internal void ProximityStatReset()
    {
        this.MoveSpeedOffSet = 0f;
        this.GlobalLearningFactorOffSet = 0f;
        this.NegotiationAbilityOffSet = 0f;
        this.PsychicSensitivityOffSet = 0f;
        this.SocialImpactOffSet = 0f;
        this.ToxicResistanceOffSet = 0f;
        this.ComfyTemperatureMinOffSet = 0f;
        this.ComfyTemperatureMaxOffSet = 0f;
        this.AimingDelayFactorOffSet = 0f;
        this.ShootingAccuracyPawnOffSet = 0f;
        this.MeleeDodgeChanceOffSet = 0f;
        this.MeleeHitChanceOffSet = 0f;
        this.ImmunityGainSpeedOffSet = 0f;
        this.MedicalTendSpeedOffSet = 0f;
        this.MedicalTendQualityOffSet = 0f;
        this.MedicalOperationSpeedOffSet = 0f;
        this.MedicalSurgerySuccessChanceOffSet = 0f;
        this.AnimalGatherSpeedOffSet = 0f;
        this.AnimalGatherYieldOffSet = 0f;
        this.ConstructionSpeedOffSet = 0f;
        this.ConstructSuccessChanceOffSet = 0f;
        this.EatingSpeedOffSet = 0f;
        this.HuntingStealthOffSet = 0f;
        this.MiningSpeedOffSet = 0f;
        this.PlantHarvestYieldOffSet = 0f;
        this.PlantWorkSpeedOffSet = 0f;
        this.ResearchSpeedOffSet = 0f;
        this.SmoothingSpeedOffSet = 0f;
        this.TameAnimalChanceOffSet = 0f;
        this.TrainAnimalChanceOffSet = 0f;
        this.WorkSpeedGlobalOffSet = 0f;
        this.ButcheryFleshSpeedOffSet = 0f;
        this.ButcheryMechanoidSpeedOffSet = 0f;
        this.ButcheryFleshEfficiencyOffSet = 0f;
        this.ButcheryMechanoidEfficiencyOffSet = 0f;
        this.CookSpeedOffSet = 0f;
        this.DrugCookingSpeedOffSet = 0f;
        this.DrugSynthesisSpeedOffSet = 0f;
        this.FixBrokenDownBuildingSuccessChanceOffSet = 0f;
        this.SmeltingSpeedOffSet = 0f;
        this.GeneralLaborSpeedOffSet = 0f;
    }

    internal void ProximityStatSet(Thing thing)
    {
        var proxQualFactor = ProxGlobals.GetProxQualFactor(thing);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMoveSpeedOffSet(thing.def), ref this.MoveSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxGlobalLearningFactorOffSet(thing.def), ref this.GlobalLearningFactorOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxNegotiationAbilityOffSet(thing.def), ref this.NegotiationAbilityOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxPsychicSensitivityOffSet(thing.def), ref this.PsychicSensitivityOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxSocialImpactOffSet(thing.def), ref this.SocialImpactOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxToxicResistanceOffSet(thing.def), ref this.ToxicResistanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxComfyTemperatureMinOffSet(thing.def), ref this.ComfyTemperatureMinOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxComfyTemperatureMaxOffSet(thing.def), ref this.ComfyTemperatureMaxOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxAimingDelayFactorOffSet(thing.def), ref this.AimingDelayFactorOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxShootingAccuracyPawnOffSet(thing.def), ref this.ShootingAccuracyPawnOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMeleeDodgeChanceOffSet(thing.def), ref this.MeleeDodgeChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMeleeHitChanceOffSet(thing.def), ref this.MeleeHitChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxImmunityGainSpeedOffSet(thing.def), ref this.ImmunityGainSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMedicalTendSpeedOffSet(thing.def), ref this.MedicalTendSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMedicalTendQualityOffSet(thing.def), ref this.MedicalTendQualityOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMedicalOperationSpeedOffSet(thing.def), ref this.MedicalOperationSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMedicalSurgerySuccessChanceOffSet(thing.def), ref this.MedicalSurgerySuccessChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxAnimalGatherSpeedOffSet(thing.def), ref this.AnimalGatherSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxAnimalGatherYieldOffSet(thing.def), ref this.AnimalGatherYieldOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxConstructionSpeedOffSet(thing.def), ref this.ConstructionSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxConstructSuccessChanceOffSet(thing.def), ref this.ConstructSuccessChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxEatingSpeedOffSet(thing.def), ref this.EatingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxHuntingStealthOffSet(thing.def), ref this.HuntingStealthOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxMiningSpeedOffSet(thing.def), ref this.MiningSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxPlantHarvestYieldOffSet(thing.def), ref this.PlantHarvestYieldOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxPlantWorkSpeedOffSet(thing.def), ref this.PlantWorkSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxResearchSpeedOffSet(thing.def), ref this.ResearchSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxSmoothingSpeedOffSet(thing.def), ref this.SmoothingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxTameAnimalChanceOffSet(thing.def), ref this.TameAnimalChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxTrainAnimalChanceOffSet(thing.def), ref this.TrainAnimalChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxWorkSpeedGlobalOffSet(thing.def), ref this.WorkSpeedGlobalOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxButcheryFleshSpeedOffSet(thing.def), ref this.ButcheryFleshSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxButcheryMechanoidSpeedOffSet(thing.def), ref this.ButcheryMechanoidSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxButcheryFleshEfficiencyOffSet(thing.def), ref this.ButcheryFleshEfficiencyOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxButcheryMechanoidEfficiencyOffSet(thing.def), ref this.ButcheryMechanoidEfficiencyOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxCookSpeedOffSet(thing.def), ref this.CookSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxDrugCookingSpeedOffSet(thing.def), ref this.DrugCookingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxDrugSynthesisSpeedOffSet(thing.def), ref this.DrugSynthesisSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxFixBrokenDownBuildingSuccessChanceOffSet(thing.def), ref this.FixBrokenDownBuildingSuccessChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxSmeltingSpeedOffSet(thing.def), ref this.SmeltingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetProxGeneralLaborSpeedOffSet(thing.def), ref this.GeneralLaborSpeedOffSet);
    }
    internal void ProximityTStatSet(TerrainDef terrain)
    {
        var proxQualFactor = 1f;
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMoveSpeedOffSet(terrain), ref this.MoveSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxGlobalLearningFactorOffSet(terrain), ref this.GlobalLearningFactorOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxNegotiationAbilityOffSet(terrain), ref this.NegotiationAbilityOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxPsychicSensitivityOffSet(terrain), ref this.PsychicSensitivityOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxSocialImpactOffSet(terrain), ref this.SocialImpactOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxToxicResistanceOffSet(terrain), ref this.ToxicResistanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxComfyTemperatureMinOffSet(terrain), ref this.ComfyTemperatureMinOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxComfyTemperatureMaxOffSet(terrain), ref this.ComfyTemperatureMaxOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxAimingDelayFactorOffSet(terrain), ref this.AimingDelayFactorOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxShootingAccuracyPawnOffSet(terrain), ref this.ShootingAccuracyPawnOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMeleeDodgeChanceOffSet(terrain), ref this.MeleeDodgeChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMeleeHitChanceOffSet(terrain), ref this.MeleeHitChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxImmunityGainSpeedOffSet(terrain), ref this.ImmunityGainSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMedicalTendSpeedOffSet(terrain), ref this.MedicalTendSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMedicalTendQualityOffSet(terrain), ref this.MedicalTendQualityOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMedicalOperationSpeedOffSet(terrain), ref this.MedicalOperationSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMedicalSurgerySuccessChanceOffSet(terrain), ref this.MedicalSurgerySuccessChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxAnimalGatherSpeedOffSet(terrain), ref this.AnimalGatherSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxAnimalGatherYieldOffSet(terrain), ref this.AnimalGatherYieldOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxConstructionSpeedOffSet(terrain), ref this.ConstructionSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxConstructSuccessChanceOffSet(terrain), ref this.ConstructSuccessChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxEatingSpeedOffSet(terrain), ref this.EatingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxHuntingStealthOffSet(terrain), ref this.HuntingStealthOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxMiningSpeedOffSet(terrain), ref this.MiningSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxPlantHarvestYieldOffSet(terrain), ref this.PlantHarvestYieldOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxPlantWorkSpeedOffSet(terrain), ref this.PlantWorkSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxResearchSpeedOffSet(terrain), ref this.ResearchSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxSmoothingSpeedOffSet(terrain), ref this.SmoothingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxTameAnimalChanceOffSet(terrain), ref this.TameAnimalChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxTrainAnimalChanceOffSet(terrain), ref this.TrainAnimalChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxWorkSpeedGlobalOffSet(terrain), ref this.WorkSpeedGlobalOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxButcheryFleshSpeedOffSet(terrain), ref this.ButcheryFleshSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxButcheryMechanoidSpeedOffSet(terrain), ref this.ButcheryMechanoidSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxButcheryFleshEfficiencyOffSet(terrain), ref this.ButcheryFleshEfficiencyOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxButcheryMechanoidEfficiencyOffSet(terrain), ref this.ButcheryMechanoidEfficiencyOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxCookSpeedOffSet(terrain), ref this.CookSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxDrugCookingSpeedOffSet(terrain), ref this.DrugCookingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxDrugSynthesisSpeedOffSet(terrain), ref this.DrugSynthesisSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxFixBrokenDownBuildingSuccessChanceOffSet(terrain), ref this.FixBrokenDownBuildingSuccessChanceOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxSmeltingSpeedOffSet(terrain), ref this.SmeltingSpeedOffSet);
        TryAddValue(proxQualFactor, ProximityGet.GetTProxGeneralLaborSpeedOffSet(terrain), ref this.GeneralLaborSpeedOffSet);
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