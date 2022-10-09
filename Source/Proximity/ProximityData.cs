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

    private Pawn Pawn => (Pawn)parent;

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

        ProximityStatReset(Pawn);
        if (Pawn.Map != null)
        {
            var list = GenRadial
                .RadialDistinctThingsAround(Pawn.Position, Pawn.Map, ProxGlobals.closeRange, true).ToList();
            if (list.Count > 0)
            {
                foreach (var thing in list)
                {
                    if (!ProxGlobals.IsNearThingValid(thing, Pawn) || !ProxGlobals.NearThingEffects(thing, Pawn))
                    {
                        continue;
                    }

                    var proxRange = ProximityGet.GetProxRange(thing.def);
                    if (!ProxGlobals.NearThingInRange(thing, Pawn, proxRange))
                    {
                        continue;
                    }

                    ProxGlobals.ProximityHediffEffect(thing, Pawn);
                    ProximityStatSet(thing, Pawn);
                }
            }

            if (ProxGlobals.UseTerrain)
            {
                var list2 = GenRadial.RadialCellsAround(Pawn.Position, ProxGlobals.closeRange, true).ToList();
                if (list2.Count > 0)
                {
                    for (var j = 0; j < list2.Count; j++)
                    {
                        var terrainDef = list2[j].InBounds(Pawn.Map) ? list2[j].GetTerrain(Pawn.Map) : null;
                        if (terrainDef == null || !list2[j].InBounds(Pawn.Map) ||
                            !ProxGlobals.IsTerrainValid(terrainDef, Pawn) ||
                            !ProxGlobals.TerrainEffects(terrainDef, list2[j], Pawn))
                        {
                            continue;
                        }

                        var tproxRange = ProximityGet.GetTProxRange(terrainDef);
                        if (!ProxGlobals.TerrainInRange(terrainDef, list2[j], Pawn, tproxRange))
                        {
                            continue;
                        }

                        ProxGlobals.ProximityTerrainHediffEffect(terrainDef, list2[j], Pawn);
                        ProximityTStatSet(terrainDef, list2[j], Pawn);
                    }
                }
            }
        }

        ProxTick = Find.TickManager.TicksGame + ProxGlobals.ExtendTicks();
    }

    internal static void ProximityStatReset(Pawn pawn)
    {
        ThingComp thingComp = pawn?.TryGetComp<ProximityData>();
        if (thingComp == null)
        {
            return;
        }

        var proximityData = (ProximityData)thingComp;

        proximityData.MoveSpeedOffSet = 0f;
        proximityData.GlobalLearningFactorOffSet = 0f;
        proximityData.NegotiationAbilityOffSet = 0f;
        proximityData.PsychicSensitivityOffSet = 0f;
        proximityData.SocialImpactOffSet = 0f;
        proximityData.ToxicResistanceOffSet = 0f;
        proximityData.ComfyTemperatureMinOffSet = 0f;
        proximityData.ComfyTemperatureMaxOffSet = 0f;
        proximityData.AimingDelayFactorOffSet = 0f;
        proximityData.ShootingAccuracyPawnOffSet = 0f;
        proximityData.MeleeDodgeChanceOffSet = 0f;
        proximityData.MeleeHitChanceOffSet = 0f;
        proximityData.ImmunityGainSpeedOffSet = 0f;
        proximityData.MedicalTendSpeedOffSet = 0f;
        proximityData.MedicalTendQualityOffSet = 0f;
        proximityData.MedicalOperationSpeedOffSet = 0f;
        proximityData.MedicalSurgerySuccessChanceOffSet = 0f;
        proximityData.AnimalGatherSpeedOffSet = 0f;
        proximityData.AnimalGatherYieldOffSet = 0f;
        proximityData.ConstructionSpeedOffSet = 0f;
        proximityData.ConstructSuccessChanceOffSet = 0f;
        proximityData.EatingSpeedOffSet = 0f;
        proximityData.HuntingStealthOffSet = 0f;
        proximityData.MiningSpeedOffSet = 0f;
        proximityData.PlantHarvestYieldOffSet = 0f;
        proximityData.PlantWorkSpeedOffSet = 0f;
        proximityData.ResearchSpeedOffSet = 0f;
        proximityData.SmoothingSpeedOffSet = 0f;
        proximityData.TameAnimalChanceOffSet = 0f;
        proximityData.TrainAnimalChanceOffSet = 0f;
        proximityData.WorkSpeedGlobalOffSet = 0f;
        proximityData.ButcheryFleshSpeedOffSet = 0f;
        proximityData.ButcheryMechanoidSpeedOffSet = 0f;
        proximityData.ButcheryFleshEfficiencyOffSet = 0f;
        proximityData.ButcheryMechanoidEfficiencyOffSet = 0f;
        proximityData.CookSpeedOffSet = 0f;
        proximityData.DrugCookingSpeedOffSet = 0f;
        proximityData.DrugSynthesisSpeedOffSet = 0f;
        proximityData.FixBrokenDownBuildingSuccessChanceOffSet = 0f;
        proximityData.SmeltingSpeedOffSet = 0f;
        proximityData.GeneralLaborSpeedOffSet = 0f;
    }

    internal static void ProximityStatSet(Thing thing, Pawn pawn)
    {
        ThingComp thingComp = pawn?.TryGetComp<ProximityData>();
        if (thingComp == null)
        {
            return;
        }

        var proximityData = (ProximityData)thingComp;

        var proxQualFactor = ProxGlobals.GetProxQualFactor(thing);
        if (ProximityGet.GetProxMoveSpeedOffSet(thing.def) != 0f)
        {
            proximityData.MoveSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxMoveSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxGlobalLearningFactorOffSet(thing.def) != 0f)
        {
            proximityData.GlobalLearningFactorOffSet +=
                proxQualFactor * ProximityGet.GetProxGlobalLearningFactorOffSet(thing.def);
        }

        if (ProximityGet.GetProxNegotiationAbilityOffSet(thing.def) != 0f)
        {
            proximityData.NegotiationAbilityOffSet +=
                proxQualFactor * ProximityGet.GetProxNegotiationAbilityOffSet(thing.def);
        }

        if (ProximityGet.GetProxPsychicSensitivityOffSet(thing.def) != 0f)
        {
            proximityData.PsychicSensitivityOffSet +=
                proxQualFactor * ProximityGet.GetProxPsychicSensitivityOffSet(thing.def);
        }

        if (ProximityGet.GetProxSocialImpactOffSet(thing.def) != 0f)
        {
            proximityData.SocialImpactOffSet +=
                proxQualFactor * ProximityGet.GetProxSocialImpactOffSet(thing.def);
        }

        if (ProximityGet.GetProxToxicResistanceOffSet(thing.def) != 0f)
        {
            proximityData.ToxicResistanceOffSet +=
                proxQualFactor * ProximityGet.GetProxToxicResistanceOffSet(thing.def);
        }

        if (ProximityGet.GetProxComfyTemperatureMinOffSet(thing.def) != 0f)
        {
            proximityData.ComfyTemperatureMinOffSet +=
                proxQualFactor * ProximityGet.GetProxComfyTemperatureMinOffSet(thing.def);
        }

        if (ProximityGet.GetProxComfyTemperatureMaxOffSet(thing.def) != 0f)
        {
            proximityData.ComfyTemperatureMaxOffSet +=
                proxQualFactor * ProximityGet.GetProxComfyTemperatureMaxOffSet(thing.def);
        }

        if (ProximityGet.GetProxAimingDelayFactorOffSet(thing.def) != 0f)
        {
            proximityData.AimingDelayFactorOffSet +=
                proxQualFactor * ProximityGet.GetProxAimingDelayFactorOffSet(thing.def);
        }

        if (ProximityGet.GetProxShootingAccuracyPawnOffSet(thing.def) != 0f)
        {
            proximityData.ShootingAccuracyPawnOffSet +=
                proxQualFactor * ProximityGet.GetProxShootingAccuracyPawnOffSet(thing.def);
        }

        if (ProximityGet.GetProxMeleeDodgeChanceOffSet(thing.def) != 0f)
        {
            proximityData.MeleeDodgeChanceOffSet +=
                proxQualFactor * ProximityGet.GetProxMeleeDodgeChanceOffSet(thing.def);
        }

        if (ProximityGet.GetProxMeleeHitChanceOffSet(thing.def) != 0f)
        {
            proximityData.MeleeHitChanceOffSet +=
                proxQualFactor * ProximityGet.GetProxMeleeHitChanceOffSet(thing.def);
        }

        if (ProximityGet.GetProxImmunityGainSpeedOffSet(thing.def) != 0f)
        {
            proximityData.ImmunityGainSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxImmunityGainSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxMedicalTendSpeedOffSet(thing.def) != 0f)
        {
            proximityData.MedicalTendSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxMedicalTendSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxMedicalTendQualityOffSet(thing.def) != 0f)
        {
            proximityData.MedicalTendQualityOffSet +=
                proxQualFactor * ProximityGet.GetProxMedicalTendQualityOffSet(thing.def);
        }

        if (ProximityGet.GetProxMedicalOperationSpeedOffSet(thing.def) != 0f)
        {
            proximityData.MedicalOperationSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxMedicalOperationSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxMedicalSurgerySuccessChanceOffSet(thing.def) != 0f)
        {
            proximityData.MedicalSurgerySuccessChanceOffSet += proxQualFactor *
                                                               ProximityGet
                                                                   .GetProxMedicalSurgerySuccessChanceOffSet(
                                                                       thing.def);
        }

        if (ProximityGet.GetProxAnimalGatherSpeedOffSet(thing.def) != 0f)
        {
            proximityData.AnimalGatherSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxAnimalGatherSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxAnimalGatherYieldOffSet(thing.def) != 0f)
        {
            proximityData.AnimalGatherYieldOffSet +=
                proxQualFactor * ProximityGet.GetProxAnimalGatherYieldOffSet(thing.def);
        }

        if (ProximityGet.GetProxConstructionSpeedOffSet(thing.def) != 0f)
        {
            proximityData.ConstructionSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxConstructionSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxConstructSuccessChanceOffSet(thing.def) != 0f)
        {
            proximityData.ConstructSuccessChanceOffSet += proxQualFactor *
                                                          ProximityGet.GetProxConstructSuccessChanceOffSet(
                                                              thing.def);
        }

        if (ProximityGet.GetProxEatingSpeedOffSet(thing.def) != 0f)
        {
            proximityData.EatingSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxEatingSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxHuntingStealthOffSet(thing.def) != 0f)
        {
            proximityData.HuntingStealthOffSet +=
                proxQualFactor * ProximityGet.GetProxHuntingStealthOffSet(thing.def);
        }

        if (ProximityGet.GetProxMiningSpeedOffSet(thing.def) != 0f)
        {
            proximityData.MiningSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxMiningSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxPlantHarvestYieldOffSet(thing.def) != 0f)
        {
            proximityData.PlantHarvestYieldOffSet +=
                proxQualFactor * ProximityGet.GetProxPlantHarvestYieldOffSet(thing.def);
        }

        if (ProximityGet.GetProxPlantWorkSpeedOffSet(thing.def) != 0f)
        {
            proximityData.PlantWorkSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxPlantWorkSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxResearchSpeedOffSet(thing.def) != 0f)
        {
            proximityData.ResearchSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxResearchSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxSmoothingSpeedOffSet(thing.def) != 0f)
        {
            proximityData.SmoothingSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxSmoothingSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxTameAnimalChanceOffSet(thing.def) != 0f)
        {
            proximityData.TameAnimalChanceOffSet +=
                proxQualFactor * ProximityGet.GetProxTameAnimalChanceOffSet(thing.def);
        }

        if (ProximityGet.GetProxTrainAnimalChanceOffSet(thing.def) != 0f)
        {
            proximityData.TrainAnimalChanceOffSet +=
                proxQualFactor * ProximityGet.GetProxTrainAnimalChanceOffSet(thing.def);
        }

        if (ProximityGet.GetProxWorkSpeedGlobalOffSet(thing.def) != 0f)
        {
            proximityData.WorkSpeedGlobalOffSet +=
                proxQualFactor * ProximityGet.GetProxWorkSpeedGlobalOffSet(thing.def);
        }

        if (ProximityGet.GetProxButcheryFleshSpeedOffSet(thing.def) != 0f)
        {
            proximityData.ButcheryFleshSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxButcheryFleshSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxButcheryMechanoidSpeedOffSet(thing.def) != 0f)
        {
            proximityData.ButcheryMechanoidSpeedOffSet += proxQualFactor *
                                                          ProximityGet.GetProxButcheryMechanoidSpeedOffSet(
                                                              thing.def);
        }

        if (ProximityGet.GetProxButcheryFleshEfficiencyOffSet(thing.def) != 0f)
        {
            proximityData.ButcheryFleshEfficiencyOffSet += proxQualFactor *
                                                           ProximityGet
                                                               .GetProxButcheryFleshEfficiencyOffSet(
                                                                   thing.def);
        }

        if (ProximityGet.GetProxButcheryMechanoidEfficiencyOffSet(thing.def) != 0f)
        {
            proximityData.ButcheryMechanoidEfficiencyOffSet += proxQualFactor *
                                                               ProximityGet
                                                                   .GetProxButcheryMechanoidEfficiencyOffSet(
                                                                       thing.def);
        }

        if (ProximityGet.GetProxCookSpeedOffSet(thing.def) != 0f)
        {
            proximityData.CookSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxCookSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxDrugCookingSpeedOffSet(thing.def) != 0f)
        {
            proximityData.DrugCookingSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxDrugCookingSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxDrugSynthesisSpeedOffSet(thing.def) != 0f)
        {
            proximityData.DrugSynthesisSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxDrugSynthesisSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxFixBrokenDownBuildingSuccessChanceOffSet(thing.def) != 0f)
        {
            proximityData.FixBrokenDownBuildingSuccessChanceOffSet += proxQualFactor *
                                                                      ProximityGet
                                                                          .GetProxFixBrokenDownBuildingSuccessChanceOffSet(
                                                                              thing.def);
        }

        if (ProximityGet.GetProxSmeltingSpeedOffSet(thing.def) != 0f)
        {
            proximityData.SmeltingSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxSmeltingSpeedOffSet(thing.def);
        }

        if (ProximityGet.GetProxGeneralLaborSpeedOffSet(thing.def) != 0f)
        {
            proximityData.GeneralLaborSpeedOffSet +=
                proxQualFactor * ProximityGet.GetProxGeneralLaborSpeedOffSet(thing.def);
        }
    }

    internal static void ProximityTStatSet(TerrainDef terrain, IntVec3 terrainPosition, Pawn pawn)
    {
        ThingComp thingComp = pawn?.TryGetComp<ProximityData>();
        if (thingComp == null)
        {
            return;
        }

        var proximityData = (ProximityData)thingComp;

        var num = 1f;
        if (ProximityGet.GetTProxMoveSpeedOffSet(terrain) != 0f)
        {
            proximityData.MoveSpeedOffSet += num * ProximityGet.GetTProxMoveSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxGlobalLearningFactorOffSet(terrain) != 0f)
        {
            proximityData.GlobalLearningFactorOffSet +=
                num * ProximityGet.GetTProxGlobalLearningFactorOffSet(terrain);
        }

        if (ProximityGet.GetTProxNegotiationAbilityOffSet(terrain) != 0f)
        {
            proximityData.NegotiationAbilityOffSet +=
                num * ProximityGet.GetTProxNegotiationAbilityOffSet(terrain);
        }

        if (ProximityGet.GetTProxPsychicSensitivityOffSet(terrain) != 0f)
        {
            proximityData.PsychicSensitivityOffSet +=
                num * ProximityGet.GetTProxPsychicSensitivityOffSet(terrain);
        }

        if (ProximityGet.GetTProxSocialImpactOffSet(terrain) != 0f)
        {
            proximityData.SocialImpactOffSet += num * ProximityGet.GetTProxSocialImpactOffSet(terrain);
        }

        if (ProximityGet.GetTProxToxicSensitivityOffSet(terrain) != 0f)
        {
            proximityData.ToxicResistanceOffSet +=
                num * ProximityGet.GetTProxToxicSensitivityOffSet(terrain);
        }

        if (ProximityGet.GetTProxComfyTemperatureMinOffSet(terrain) != 0f)
        {
            proximityData.ComfyTemperatureMinOffSet +=
                num * ProximityGet.GetTProxComfyTemperatureMinOffSet(terrain);
        }

        if (ProximityGet.GetTProxComfyTemperatureMaxOffSet(terrain) != 0f)
        {
            proximityData.ComfyTemperatureMaxOffSet +=
                num * ProximityGet.GetTProxComfyTemperatureMaxOffSet(terrain);
        }

        if (ProximityGet.GetTProxAimingDelayFactorOffSet(terrain) != 0f)
        {
            proximityData.AimingDelayFactorOffSet +=
                num * ProximityGet.GetTProxAimingDelayFactorOffSet(terrain);
        }

        if (ProximityGet.GetTProxShootingAccuracyPawnOffSet(terrain) != 0f)
        {
            proximityData.ShootingAccuracyPawnOffSet +=
                num * ProximityGet.GetTProxShootingAccuracyPawnOffSet(terrain);
        }

        if (ProximityGet.GetTProxMeleeDodgeChanceOffSet(terrain) != 0f)
        {
            proximityData.MeleeDodgeChanceOffSet +=
                num * ProximityGet.GetTProxMeleeDodgeChanceOffSet(terrain);
        }

        if (ProximityGet.GetTProxMeleeHitChanceOffSet(terrain) != 0f)
        {
            proximityData.MeleeHitChanceOffSet += num * ProximityGet.GetTProxMeleeHitChanceOffSet(terrain);
        }

        if (ProximityGet.GetTProxImmunityGainSpeedOffSet(terrain) != 0f)
        {
            proximityData.ImmunityGainSpeedOffSet +=
                num * ProximityGet.GetTProxImmunityGainSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxMedicalTendSpeedOffSet(terrain) != 0f)
        {
            proximityData.MedicalTendSpeedOffSet +=
                num * ProximityGet.GetTProxMedicalTendSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxMedicalTendQualityOffSet(terrain) != 0f)
        {
            proximityData.MedicalTendQualityOffSet +=
                num * ProximityGet.GetTProxMedicalTendQualityOffSet(terrain);
        }

        if (ProximityGet.GetTProxMedicalOperationSpeedOffSet(terrain) != 0f)
        {
            proximityData.MedicalOperationSpeedOffSet +=
                num * ProximityGet.GetTProxMedicalOperationSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxMedicalSurgerySuccessChanceOffSet(terrain) != 0f)
        {
            proximityData.MedicalSurgerySuccessChanceOffSet +=
                num * ProximityGet.GetTProxMedicalSurgerySuccessChanceOffSet(terrain);
        }

        if (ProximityGet.GetTProxAnimalGatherSpeedOffSet(terrain) != 0f)
        {
            proximityData.AnimalGatherSpeedOffSet +=
                num * ProximityGet.GetTProxAnimalGatherSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxAnimalGatherYieldOffSet(terrain) != 0f)
        {
            proximityData.AnimalGatherYieldOffSet +=
                num * ProximityGet.GetTProxAnimalGatherYieldOffSet(terrain);
        }

        if (ProximityGet.GetTProxConstructionSpeedOffSet(terrain) != 0f)
        {
            proximityData.ConstructionSpeedOffSet +=
                num * ProximityGet.GetTProxConstructionSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxConstructSuccessChanceOffSet(terrain) != 0f)
        {
            proximityData.ConstructSuccessChanceOffSet +=
                num * ProximityGet.GetTProxConstructSuccessChanceOffSet(terrain);
        }

        if (ProximityGet.GetTProxEatingSpeedOffSet(terrain) != 0f)
        {
            proximityData.EatingSpeedOffSet += num * ProximityGet.GetTProxEatingSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxHuntingStealthOffSet(terrain) != 0f)
        {
            proximityData.HuntingStealthOffSet += num * ProximityGet.GetTProxHuntingStealthOffSet(terrain);
        }

        if (ProximityGet.GetTProxMiningSpeedOffSet(terrain) != 0f)
        {
            proximityData.MiningSpeedOffSet += num * ProximityGet.GetTProxMiningSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxPlantHarvestYieldOffSet(terrain) != 0f)
        {
            proximityData.PlantHarvestYieldOffSet +=
                num * ProximityGet.GetTProxPlantHarvestYieldOffSet(terrain);
        }

        if (ProximityGet.GetTProxPlantWorkSpeedOffSet(terrain) != 0f)
        {
            proximityData.PlantWorkSpeedOffSet += num * ProximityGet.GetTProxPlantWorkSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxResearchSpeedOffSet(terrain) != 0f)
        {
            proximityData.ResearchSpeedOffSet += num * ProximityGet.GetTProxResearchSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxSmoothingSpeedOffSet(terrain) != 0f)
        {
            proximityData.SmoothingSpeedOffSet += num * ProximityGet.GetTProxSmoothingSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxTameAnimalChanceOffSet(terrain) != 0f)
        {
            proximityData.TameAnimalChanceOffSet +=
                num * ProximityGet.GetTProxTameAnimalChanceOffSet(terrain);
        }

        if (ProximityGet.GetTProxTrainAnimalChanceOffSet(terrain) != 0f)
        {
            proximityData.TrainAnimalChanceOffSet +=
                num * ProximityGet.GetTProxTrainAnimalChanceOffSet(terrain);
        }

        if (ProximityGet.GetTProxWorkSpeedGlobalOffSet(terrain) != 0f)
        {
            proximityData.WorkSpeedGlobalOffSet +=
                num * ProximityGet.GetTProxWorkSpeedGlobalOffSet(terrain);
        }

        if (ProximityGet.GetTProxButcheryFleshSpeedOffSet(terrain) != 0f)
        {
            proximityData.ButcheryFleshSpeedOffSet +=
                num * ProximityGet.GetTProxButcheryFleshSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxButcheryMechanoidSpeedOffSet(terrain) != 0f)
        {
            proximityData.ButcheryMechanoidSpeedOffSet +=
                num * ProximityGet.GetTProxButcheryMechanoidSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxButcheryFleshEfficiencyOffSet(terrain) != 0f)
        {
            proximityData.ButcheryFleshEfficiencyOffSet +=
                num * ProximityGet.GetTProxButcheryFleshEfficiencyOffSet(terrain);
        }

        if (ProximityGet.GetTProxButcheryMechanoidEfficiencyOffSet(terrain) != 0f)
        {
            proximityData.ButcheryMechanoidEfficiencyOffSet +=
                num * ProximityGet.GetTProxButcheryMechanoidEfficiencyOffSet(terrain);
        }

        if (ProximityGet.GetTProxCookSpeedOffSet(terrain) != 0f)
        {
            proximityData.CookSpeedOffSet += num * ProximityGet.GetTProxCookSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxDrugCookingSpeedOffSet(terrain) != 0f)
        {
            proximityData.DrugCookingSpeedOffSet +=
                num * ProximityGet.GetTProxDrugCookingSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxDrugSynthesisSpeedOffSet(terrain) != 0f)
        {
            proximityData.DrugSynthesisSpeedOffSet +=
                num * ProximityGet.GetTProxDrugSynthesisSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxFixBrokenDownBuildingSuccessChanceOffSet(terrain) != 0f)
        {
            proximityData.FixBrokenDownBuildingSuccessChanceOffSet +=
                num * ProximityGet.GetTProxFixBrokenDownBuildingSuccessChanceOffSet(terrain);
        }

        if (ProximityGet.GetTProxSmeltingSpeedOffSet(terrain) != 0f)
        {
            proximityData.SmeltingSpeedOffSet += num * ProximityGet.GetTProxSmeltingSpeedOffSet(terrain);
        }

        if (ProximityGet.GetTProxGeneralLaborSpeedOffSet(terrain) != 0f)
        {
            proximityData.GeneralLaborSpeedOffSet +=
                num * ProximityGet.GetTProxGeneralLaborSpeedOffSet(terrain);
        }
    }

    internal static float GetProxData(Thing thing, int num)
    {
        var result = 0f;
        if (thing is not Verse.Pawn)
        {
            return result;
        }

        ThingComp thingComp = thing.TryGetComp<ProximityData>();
        if (thingComp == null)
        {
            return result;
        }

        var proximityData = (ProximityData)thingComp;

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