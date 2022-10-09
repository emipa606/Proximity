using System.Collections.Generic;
using Verse;

namespace Proximity;

public class ProximityGet
{
    public static float GetProxMoveSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMoveSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxGlobalLearningFactorOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxGlobalLearningFactorOffSet).Value
            : 0f;
    }

    public static float GetProxImmunityGainSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxImmunityGainSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxNegotiationAbilityOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxNegotiationAbilityOffSet).Value
            : 0f;
    }

    public static float GetProxPsychicSensitivityOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxPsychicSensitivityOffSet).Value
            : 0f;
    }

    public static float GetProxSocialImpactOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxSocialImpactOffSet).Value
            : 0f;
    }

    public static float GetProxToxicResistanceOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxToxicResistanceOffSet).Value
            : 0f;
    }

    public static float GetProxComfyTemperatureMinOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxComfyTemperatureMinOffSet).Value
            : 0f;
    }

    public static float GetProxComfyTemperatureMaxOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxComfyTemperatureMaxOffSet).Value
            : 0f;
    }

    public static float GetProxShootingAccuracyPawnOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxShootingAccuracyPawnOffSet).Value
            : 0f;
    }

    public static float GetProxAimingDelayFactorOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxAimingDelayFactorOffSet).Value
            : 0f;
    }

    public static float GetProxMeleeDodgeChanceOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMeleeDodgeChanceOffSet).Value
            : 0f;
    }

    public static float GetProxMeleeHitChanceOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMeleeHitChanceOffSet).Value
            : 0f;
    }

    public static float GetProxMedicalTendSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMedicalTendSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxMedicalTendQualityOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMedicalTendQualityOffSet).Value
            : 0f;
    }

    public static float GetProxMedicalOperationSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMedicalOperationSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxMedicalSurgerySuccessChanceOffSet(ThingDef thingdef)
    {
        if (thingdef.HasModExtension<ProximityDefs>())
        {
            return new float?(thingdef.GetModExtension<ProximityDefs>().ProxMedicalSurgerySuccessChanceOffSet)
                .Value;
        }

        return 0f;
    }

    public static float GetProxAnimalGatherSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxAnimalGatherSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxAnimalGatherYieldOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxAnimalGatherYieldOffSet).Value
            : 0f;
    }

    public static float GetProxConstructionSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxConstructionSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxConstructSuccessChanceOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxConstructSuccessChanceOffSet).Value
            : 0f;
    }

    public static float GetProxEatingSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxEatingSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxHuntingStealthOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxHuntingStealthOffSet).Value
            : 0f;
    }

    public static float GetProxMiningSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMiningSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxPlantHarvestYieldOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxPlantHarvestYieldOffSet).Value
            : 0f;
    }

    public static float GetProxPlantWorkSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxPlantWorkSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxSmoothingSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxSmoothingSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxResearchSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxResearchSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxTameAnimalChanceOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxTameAnimalChanceOffSet).Value
            : 0f;
    }

    public static float GetProxTrainAnimalChanceOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxTrainAnimalChanceOffSet).Value
            : 0f;
    }

    public static float GetProxWorkSpeedGlobalOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxWorkSpeedGlobalOffSet).Value
            : 0f;
    }

    public static float GetProxButcheryFleshSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxButcheryFleshSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxButcheryMechanoidSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxButcheryMechanoidSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxButcheryFleshEfficiencyOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxButcheryFleshEfficiencyOffSet).Value
            : 0f;
    }

    public static float GetProxButcheryMechanoidEfficiencyOffSet(ThingDef thingdef)
    {
        if (thingdef.HasModExtension<ProximityDefs>())
        {
            return new float?(thingdef.GetModExtension<ProximityDefs>().ProxButcheryMechanoidEfficiencyOffSet)
                .Value;
        }

        return 0f;
    }

    public static float GetProxCookSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxCookSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxDrugCookingSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxDrugCookingSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxDrugSynthesisSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxDrugSynthesisSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxFixBrokenDownBuildingSuccessChanceOffSet(ThingDef thingdef)
    {
        if (thingdef.HasModExtension<ProximityDefs>())
        {
            return new float?(
                thingdef.GetModExtension<ProximityDefs>().ProxFixBrokenDownBuildingSuccessChanceOffSet).Value;
        }

        return 0f;
    }

    public static float GetProxSmeltingSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxSmeltingSpeedOffSet).Value
            : 0f;
    }

    public static float GetProxGeneralLaborSpeedOffSet(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxGeneralLaborSpeedOffSet).Value
            : 0f;
    }

    public static string GetProxHediff(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>() ||
            thingdef.GetModExtension<ProximityDefs>().ProxHediff == null)
        {
            return "";
        }

        return thingdef.GetModExtension<ProximityDefs>().ProxHediff;
    }

    public static float GetProxHediffSev(ThingDef thingdef)
    {
        if (thingdef.HasModExtension<ProximityDefs>())
        {
            return new float?(thingdef.GetModExtension<ProximityDefs>().ProxHediffSev)
                .Value;
        }

        return 0f;
    }

    public static bool GetProxRoomOnly(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxRoomOnly;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxRoomOnly)
            .Value;
    }

    public static int GetProxRange(ThingDef thingdef)
    {
        return thingdef.HasModExtension<ProximityDefs>()
            ? new int?(thingdef.GetModExtension<ProximityDefs>().ProxRange).Value
            : 0;
    }

    public static bool GetProxQuality(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxQuality;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxQuality)
            .Value;
    }

    public static bool GetProxDisabled(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxDisabled;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxDisabled)
            .Value;
    }

    public static bool GetProxDrafted(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxDrafted;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxDrafted)
            .Value;
    }

    public static bool GetProxComposMentis(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxComposMentis;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxComposMentis)
            .Value;
    }

    public static bool GetProxColonist(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxColonist;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxColonist)
            .Value;
    }

    public static bool GetProxOutsider(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxOutsider;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxOutsider)
            .Value;
    }

    public static bool GetProxAlly(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxAlly;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxAlly).Value;
    }

    public static bool GetProxNeutral(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxNeutral;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxNeutral)
            .Value;
    }

    public static bool GetProxHostile(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxHostile;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxHostile)
            .Value;
    }

    public static bool GetProxPrisoner(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxPrisoner;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxPrisoner)
            .Value;
    }

    public static bool GetProxAnimal(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxAnimal;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxAnimal)
            .Value;
    }

    public static bool GetProxInsectoid(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxInsectoid;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxInsectoid)
            .Value;
    }

    public static bool GetProxMechanoid(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = thingdef.GetModExtension<ProximityDefs>().ProxMechanoid;
        return new bool?(thingdef.GetModExtension<ProximityDefs>().ProxMechanoid)
            .Value;
    }

    public static List<string> GetProxEquipped(ThingDef thingdef)
    {
        if (!thingdef.HasModExtension<ProximityDefs>() ||
            thingdef.GetModExtension<ProximityDefs>().ProxEquipped == null)
        {
            return null;
        }

        return thingdef.GetModExtension<ProximityDefs>().ProxEquipped;
    }

    public static float GetTProxMoveSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMoveSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxGlobalLearningFactorOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxGlobalLearningFactorOffSet).Value
            : 0f;
    }

    public static float GetTProxImmunityGainSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxImmunityGainSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxNegotiationAbilityOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxNegotiationAbilityOffSet).Value
            : 0f;
    }

    public static float GetTProxPsychicSensitivityOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxPsychicSensitivityOffSet).Value
            : 0f;
    }

    public static float GetTProxSocialImpactOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxSocialImpactOffSet).Value
            : 0f;
    }

    public static float GetTProxToxicSensitivityOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxToxicResistanceOffSet).Value
            : 0f;
    }

    public static float GetTProxComfyTemperatureMinOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxComfyTemperatureMinOffSet).Value
            : 0f;
    }

    public static float GetTProxComfyTemperatureMaxOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxComfyTemperatureMaxOffSet).Value
            : 0f;
    }

    public static float GetTProxShootingAccuracyPawnOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxShootingAccuracyPawnOffSet).Value
            : 0f;
    }

    public static float GetTProxAimingDelayFactorOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxAimingDelayFactorOffSet).Value
            : 0f;
    }

    public static float GetTProxMeleeDodgeChanceOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMeleeDodgeChanceOffSet).Value
            : 0f;
    }

    public static float GetTProxMeleeHitChanceOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMeleeHitChanceOffSet).Value
            : 0f;
    }

    public static float GetTProxMedicalTendSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMedicalTendSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxMedicalTendQualityOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMedicalTendQualityOffSet).Value
            : 0f;
    }

    public static float GetTProxMedicalOperationSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMedicalOperationSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxMedicalSurgerySuccessChanceOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMedicalSurgerySuccessChanceOffSet).Value
            : 0f;
    }

    public static float GetTProxAnimalGatherSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxAnimalGatherSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxAnimalGatherYieldOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxAnimalGatherYieldOffSet).Value
            : 0f;
    }

    public static float GetTProxConstructionSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxConstructionSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxConstructSuccessChanceOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxConstructSuccessChanceOffSet).Value
            : 0f;
    }

    public static float GetTProxEatingSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxEatingSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxHuntingStealthOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxHuntingStealthOffSet).Value
            : 0f;
    }

    public static float GetTProxMiningSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMiningSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxPlantHarvestYieldOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxPlantHarvestYieldOffSet).Value
            : 0f;
    }

    public static float GetTProxPlantWorkSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxPlantWorkSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxSmoothingSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxSmoothingSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxResearchSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxResearchSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxTameAnimalChanceOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxTameAnimalChanceOffSet).Value
            : 0f;
    }

    public static float GetTProxTrainAnimalChanceOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxTrainAnimalChanceOffSet).Value
            : 0f;
    }

    public static float GetTProxWorkSpeedGlobalOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxWorkSpeedGlobalOffSet).Value
            : 0f;
    }

    public static float GetTProxButcheryFleshSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxButcheryFleshSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxButcheryMechanoidSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxButcheryMechanoidSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxButcheryFleshEfficiencyOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxButcheryFleshEfficiencyOffSet).Value
            : 0f;
    }

    public static float GetTProxButcheryMechanoidEfficiencyOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxButcheryMechanoidEfficiencyOffSet).Value
            : 0f;
    }

    public static float GetTProxCookSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxCookSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxDrugCookingSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxDrugCookingSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxDrugSynthesisSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxDrugSynthesisSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxFixBrokenDownBuildingSuccessChanceOffSet(TerrainDef terrain)
    {
        if (terrain.HasModExtension<ProximityDefs>())
        {
            return new float?(terrain.GetModExtension<ProximityDefs>().ProxFixBrokenDownBuildingSuccessChanceOffSet)
                .Value;
        }

        return 0f;
    }

    public static float GetTProxSmeltingSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxSmeltingSpeedOffSet).Value
            : 0f;
    }

    public static float GetTProxGeneralLaborSpeedOffSet(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new float?(terrain.GetModExtension<ProximityDefs>().ProxGeneralLaborSpeedOffSet).Value
            : 0f;
    }

    public static string GetTProxHediff(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>() ||
            terrain.GetModExtension<ProximityDefs>().ProxHediff == null)
        {
            return "";
        }

        return terrain.GetModExtension<ProximityDefs>().ProxHediff;
    }

    public static float GetTProxHediffSev(TerrainDef terrain)
    {
        if (terrain.HasModExtension<ProximityDefs>())
        {
            return new float?(terrain.GetModExtension<ProximityDefs>().ProxHediffSev)
                .Value;
        }

        return 0f;
    }

    public static bool GetTProxRoomOnly(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxRoomOnly;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxRoomOnly)
            .Value;
    }

    public static int GetTProxRange(TerrainDef terrain)
    {
        return terrain.HasModExtension<ProximityDefs>()
            ? new int?(terrain.GetModExtension<ProximityDefs>().ProxRange).Value
            : 0;
    }

    public static bool GetTProxQuality(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxQuality;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxQuality).Value;
    }

    public static bool GetTProxDisabled(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxDisabled;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxDisabled)
            .Value;
    }

    public static bool GetTProxDrafted(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxDrafted;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxDrafted).Value;
    }

    public static bool GetTProxComposMentis(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxComposMentis;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxComposMentis)
            .Value;
    }

    public static bool GetTProxColonist(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxColonist;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxColonist)
            .Value;
    }

    public static bool GetTProxOutsider(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxOutsider;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxOutsider)
            .Value;
    }

    public static bool GetTProxAlly(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxAlly;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxAlly).Value;
    }

    public static bool GetTProxNeutral(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxNeutral;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxNeutral).Value;
    }

    public static bool GetTProxHostile(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxHostile;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxHostile).Value;
    }

    public static bool GetTProxPrisoner(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxPrisoner;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxPrisoner)
            .Value;
    }

    public static bool GetTProxAnimal(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxAnimal;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxAnimal).Value;
    }

    public static bool GetTProxInsectoid(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxInsectoid;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxInsectoid)
            .Value;
    }

    public static bool GetTProxMechanoid(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>())
        {
            return false;
        }

        _ = terrain.GetModExtension<ProximityDefs>().ProxMechanoid;
        return new bool?(terrain.GetModExtension<ProximityDefs>().ProxMechanoid)
            .Value;
    }

    public static List<string> GetTProxEquipped(TerrainDef terrain)
    {
        if (!terrain.HasModExtension<ProximityDefs>() ||
            terrain.GetModExtension<ProximityDefs>().ProxEquipped == null)
        {
            return null;
        }

        return terrain.GetModExtension<ProximityDefs>().ProxEquipped;
    }
}