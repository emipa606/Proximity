using System;
using System.Collections.Generic;
using Verse;

namespace Proximity
{
	// Token: 0x02000009 RID: 9
	public class ProximityGet
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00004804 File Offset: 0x00002A04
		public static float GetProxMoveSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMoveSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004848 File Offset: 0x00002A48
		public static float GetProxGlobalLearningFactorOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxGlobalLearningFactorOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000488C File Offset: 0x00002A8C
		public static float GetProxImmunityGainSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxImmunityGainSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000048D0 File Offset: 0x00002AD0
		public static float GetProxNegotiationAbilityOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxNegotiationAbilityOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004914 File Offset: 0x00002B14
		public static float GetProxPsychicSensitivityOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxPsychicSensitivityOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004958 File Offset: 0x00002B58
		public static float GetProxSocialImpactOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxSocialImpactOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000499C File Offset: 0x00002B9C
		public static float GetProxToxicSensitivityOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxToxicSensitivityOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000049E0 File Offset: 0x00002BE0
		public static float GetProxComfyTemperatureMinOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxComfyTemperatureMinOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004A24 File Offset: 0x00002C24
		public static float GetProxComfyTemperatureMaxOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxComfyTemperatureMaxOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004A68 File Offset: 0x00002C68
		public static float GetProxShootingAccuracyPawnOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxShootingAccuracyPawnOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004AAC File Offset: 0x00002CAC
		public static float GetProxAimingDelayFactorOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxAimingDelayFactorOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004AF0 File Offset: 0x00002CF0
		public static float GetProxMeleeDodgeChanceOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMeleeDodgeChanceOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004B34 File Offset: 0x00002D34
		public static float GetProxMeleeHitChanceOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMeleeHitChanceOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004B78 File Offset: 0x00002D78
		public static float GetProxMedicalTendSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMedicalTendSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004BBC File Offset: 0x00002DBC
		public static float GetProxMedicalTendQualityOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMedicalTendQualityOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004C00 File Offset: 0x00002E00
		public static float GetProxMedicalOperationSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMedicalOperationSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004C44 File Offset: 0x00002E44
		public static float GetProxMedicalSurgerySuccessChanceOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMedicalSurgerySuccessChanceOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004C88 File Offset: 0x00002E88
		public static float GetProxAnimalGatherSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxAnimalGatherSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004CCC File Offset: 0x00002ECC
		public static float GetProxAnimalGatherYieldOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxAnimalGatherYieldOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004D10 File Offset: 0x00002F10
		public static float GetProxConstructionSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxConstructionSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004D54 File Offset: 0x00002F54
		public static float GetProxConstructSuccessChanceOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxConstructSuccessChanceOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004D98 File Offset: 0x00002F98
		public static float GetProxEatingSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxEatingSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004DDC File Offset: 0x00002FDC
		public static float GetProxHuntingStealthOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxHuntingStealthOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004E20 File Offset: 0x00003020
		public static float GetProxMiningSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxMiningSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004E64 File Offset: 0x00003064
		public static float GetProxPlantHarvestYieldOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxPlantHarvestYieldOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004EA8 File Offset: 0x000030A8
		public static float GetProxPlantWorkSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxPlantWorkSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004EEC File Offset: 0x000030EC
		public static float GetProxSmoothingSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxSmoothingSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004F30 File Offset: 0x00003130
		public static float GetProxResearchSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxResearchSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004F74 File Offset: 0x00003174
		public static float GetProxTameAnimalChanceOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxTameAnimalChanceOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004FB8 File Offset: 0x000031B8
		public static float GetProxTrainAnimalChanceOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxTrainAnimalChanceOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004FFC File Offset: 0x000031FC
		public static float GetProxUnskilledLaborSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxUnskilledLaborSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005040 File Offset: 0x00003240
		public static float GetProxWorkSpeedGlobalOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxWorkSpeedGlobalOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005084 File Offset: 0x00003284
		public static float GetProxButcheryFleshSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxButcheryFleshSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000050C8 File Offset: 0x000032C8
		public static float GetProxButcheryMechanoidSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxButcheryMechanoidSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000510C File Offset: 0x0000330C
		public static float GetProxButcheryFleshEfficiencyOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxButcheryFleshEfficiencyOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005150 File Offset: 0x00003350
		public static float GetProxButcheryMechanoidEfficiencyOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxButcheryMechanoidEfficiencyOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005194 File Offset: 0x00003394
		public static float GetProxCookSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxCookSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000051D8 File Offset: 0x000033D8
		public static float GetProxDrugCookingSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxDrugCookingSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000521C File Offset: 0x0000341C
		public static float GetProxDrugSynthesisSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxDrugSynthesisSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005260 File Offset: 0x00003460
		public static float GetProxFixBrokenDownBuildingSuccessChanceOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxFixBrokenDownBuildingSuccessChanceOffSet) : null).Value;
			}
			return 0f;
		}

		//// Token: 0x0600004A RID: 74 RVA: 0x000052A4 File Offset: 0x000034A4
		//public static float GetProxSculptingSpeedOffSet(ThingDef thingdef)
		//{
		//	if (thingdef.HasModExtension<ProximityDefs>())
		//	{
		//		return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxSculptingSpeedOffSet) : null).Value;
		//	}
		//	return 0f;
		//}

		// Token: 0x0600004B RID: 75 RVA: 0x000052E8 File Offset: 0x000034E8
		public static float GetProxSmeltingSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxSmeltingSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		//// Token: 0x0600004C RID: 76 RVA: 0x0000532C File Offset: 0x0000352C
		//public static float GetProxSmithingSpeedOffSet(ThingDef thingdef)
		//{
		//	if (thingdef.HasModExtension<ProximityDefs>())
		//	{
		//		return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxSmithingSpeedOffSet) : null).Value;
		//	}
		//	return 0f;
		//}

		//// Token: 0x0600004D RID: 77 RVA: 0x00005370 File Offset: 0x00003570
		//public static float GetProxTailoringSpeedOffSet(ThingDef thingdef)
		//{
		//	if (thingdef.HasModExtension<ProximityDefs>())
		//	{
		//		return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxTailoringSpeedOffSet) : null).Value;
		//	}
		//	return 0f;
		//}		
		
		// Token: 0x0600004A RID: 74 RVA: 0x000052A4 File Offset: 0x000034A4
		public static float GetProxGeneralLaborSpeedOffSet(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxGeneralLaborSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000053B2 File Offset: 0x000035B2
		public static string GetProxHediff(ThingDef thingdef)
		{
			if (!thingdef.HasModExtension<ProximityDefs>() || thingdef == null || thingdef.GetModExtension<ProximityDefs>().ProxHediff == null)
			{
				return "";
			}
			if (thingdef == null)
			{
				return null;
			}
			return thingdef.GetModExtension<ProximityDefs>().ProxHediff;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000053E4 File Offset: 0x000035E4
		public static float GetProxHediffSev(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new float?(thingdef.GetModExtension<ProximityDefs>().ProxHediffSev) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005428 File Offset: 0x00003628
		public static bool GetProxRoomOnly(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxRoomOnly;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxRoomOnly) : null).Value;
			}
			return false;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005474 File Offset: 0x00003674
		public static int GetProxRange(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>())
			{
				return ((thingdef != null) ? new int?(thingdef.GetModExtension<ProximityDefs>().ProxRange) : null).Value;
			}
			return 0;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000054B4 File Offset: 0x000036B4
		public static bool GetProxQuality(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxQuality;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxQuality) : null).Value;
			}
			return false;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005500 File Offset: 0x00003700
		public static bool GetProxDisabled(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxDisabled;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxDisabled) : null).Value;
			}
			return false;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000554C File Offset: 0x0000374C
		public static bool GetProxDrafted(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxDrafted;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxDrafted) : null).Value;
			}
			return false;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005598 File Offset: 0x00003798
		public static bool GetProxComposMentis(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxComposMentis;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxComposMentis) : null).Value;
			}
			return false;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000055E4 File Offset: 0x000037E4
		public static bool GetProxColonist(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxColonist;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxColonist) : null).Value;
			}
			return false;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005630 File Offset: 0x00003830
		public static bool GetProxOutsider(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxOutsider;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxOutsider) : null).Value;
			}
			return false;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000567C File Offset: 0x0000387C
		public static bool GetProxAlly(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxAlly;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxAlly) : null).Value;
			}
			return false;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000056C8 File Offset: 0x000038C8
		public static bool GetProxNeutral(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxNeutral;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxNeutral) : null).Value;
			}
			return false;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005714 File Offset: 0x00003914
		public static bool GetProxHostile(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxHostile;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxHostile) : null).Value;
			}
			return false;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00005760 File Offset: 0x00003960
		public static bool GetProxPrisoner(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxPrisoner;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxPrisoner) : null).Value;
			}
			return false;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000057AC File Offset: 0x000039AC
		public static bool GetProxAnimal(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxAnimal;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxAnimal) : null).Value;
			}
			return false;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000057F8 File Offset: 0x000039F8
		public static bool GetProxInsectoid(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxInsectoid;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxInsectoid) : null).Value;
			}
			return false;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005844 File Offset: 0x00003A44
		public static bool GetProxMechanoid(ThingDef thingdef)
		{
			if (thingdef.HasModExtension<ProximityDefs>() && thingdef != null)
			{
                _ = thingdef.GetModExtension<ProximityDefs>().ProxMechanoid;
                return ((thingdef != null) ? new bool?(thingdef.GetModExtension<ProximityDefs>().ProxMechanoid) : null).Value;
			}
			return false;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005890 File Offset: 0x00003A90
		public static List<string> GetProxEquipped(ThingDef thingdef)
		{
			if (!thingdef.HasModExtension<ProximityDefs>() || (thingdef?.GetModExtension<ProximityDefs>().ProxEquipped) == null)
			{
				return null;
			}
			if (thingdef == null)
			{
				return null;
			}
			return thingdef.GetModExtension<ProximityDefs>().ProxEquipped;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000058C0 File Offset: 0x00003AC0
		public static float GetTProxMoveSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMoveSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005904 File Offset: 0x00003B04
		public static float GetTProxGlobalLearningFactorOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxGlobalLearningFactorOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00005948 File Offset: 0x00003B48
		public static float GetTProxImmunityGainSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxImmunityGainSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000598C File Offset: 0x00003B8C
		public static float GetTProxNegotiationAbilityOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxNegotiationAbilityOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000059D0 File Offset: 0x00003BD0
		public static float GetTProxPsychicSensitivityOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxPsychicSensitivityOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005A14 File Offset: 0x00003C14
		public static float GetTProxSocialImpactOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxSocialImpactOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00005A58 File Offset: 0x00003C58
		public static float GetTProxToxicSensitivityOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxToxicSensitivityOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005A9C File Offset: 0x00003C9C
		public static float GetTProxComfyTemperatureMinOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxComfyTemperatureMinOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00005AE0 File Offset: 0x00003CE0
		public static float GetTProxComfyTemperatureMaxOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxComfyTemperatureMaxOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005B24 File Offset: 0x00003D24
		public static float GetTProxShootingAccuracyPawnOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxShootingAccuracyPawnOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005B68 File Offset: 0x00003D68
		public static float GetTProxAimingDelayFactorOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxAimingDelayFactorOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005BAC File Offset: 0x00003DAC
		public static float GetTProxMeleeDodgeChanceOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMeleeDodgeChanceOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005BF0 File Offset: 0x00003DF0
		public static float GetTProxMeleeHitChanceOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMeleeHitChanceOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005C34 File Offset: 0x00003E34
		public static float GetTProxMedicalTendSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMedicalTendSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005C78 File Offset: 0x00003E78
		public static float GetTProxMedicalTendQualityOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMedicalTendQualityOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005CBC File Offset: 0x00003EBC
		public static float GetTProxMedicalOperationSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMedicalOperationSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005D00 File Offset: 0x00003F00
		public static float GetTProxMedicalSurgerySuccessChanceOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMedicalSurgerySuccessChanceOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005D44 File Offset: 0x00003F44
		public static float GetTProxAnimalGatherSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxAnimalGatherSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00005D88 File Offset: 0x00003F88
		public static float GetTProxAnimalGatherYieldOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxAnimalGatherYieldOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00005DCC File Offset: 0x00003FCC
		public static float GetTProxConstructionSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxConstructionSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00005E10 File Offset: 0x00004010
		public static float GetTProxConstructSuccessChanceOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxConstructSuccessChanceOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00005E54 File Offset: 0x00004054
		public static float GetTProxEatingSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxEatingSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00005E98 File Offset: 0x00004098
		public static float GetTProxHuntingStealthOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxHuntingStealthOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00005EDC File Offset: 0x000040DC
		public static float GetTProxMiningSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxMiningSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005F20 File Offset: 0x00004120
		public static float GetTProxPlantHarvestYieldOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxPlantHarvestYieldOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00005F64 File Offset: 0x00004164
		public static float GetTProxPlantWorkSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxPlantWorkSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005FA8 File Offset: 0x000041A8
		public static float GetTProxSmoothingSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxSmoothingSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00005FEC File Offset: 0x000041EC
		public static float GetTProxResearchSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxResearchSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00006030 File Offset: 0x00004230
		public static float GetTProxTameAnimalChanceOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxTameAnimalChanceOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00006074 File Offset: 0x00004274
		public static float GetTProxTrainAnimalChanceOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxTrainAnimalChanceOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000060B8 File Offset: 0x000042B8
		public static float GetTProxUnskilledLaborSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxUnskilledLaborSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000060FC File Offset: 0x000042FC
		public static float GetTProxWorkSpeedGlobalOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxWorkSpeedGlobalOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00006140 File Offset: 0x00004340
		public static float GetTProxButcheryFleshSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxButcheryFleshSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00006184 File Offset: 0x00004384
		public static float GetTProxButcheryMechanoidSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxButcheryMechanoidSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000061C8 File Offset: 0x000043C8
		public static float GetTProxButcheryFleshEfficiencyOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxButcheryFleshEfficiencyOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000620C File Offset: 0x0000440C
		public static float GetTProxButcheryMechanoidEfficiencyOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxButcheryMechanoidEfficiencyOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00006250 File Offset: 0x00004450
		public static float GetTProxCookSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxCookSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00006294 File Offset: 0x00004494
		public static float GetTProxDrugCookingSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxDrugCookingSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000062D8 File Offset: 0x000044D8
		public static float GetTProxDrugSynthesisSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxDrugSynthesisSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000631C File Offset: 0x0000451C
		public static float GetTProxFixBrokenDownBuildingSuccessChanceOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxFixBrokenDownBuildingSuccessChanceOffSet) : null).Value;
			}
			return 0f;
		}

		//// Token: 0x06000088 RID: 136 RVA: 0x00006360 File Offset: 0x00004560
		//public static float GetTProxSculptingSpeedOffSet(TerrainDef terrain)
		//{
		//	if (terrain.HasModExtension<ProximityDefs>())
		//	{
		//		return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxSculptingSpeedOffSet) : null).Value;
		//	}
		//	return 0f;
		//}

		// Token: 0x06000089 RID: 137 RVA: 0x000063A4 File Offset: 0x000045A4
		public static float GetTProxSmeltingSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxSmeltingSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		//// Token: 0x0600008A RID: 138 RVA: 0x000063E8 File Offset: 0x000045E8
		//public static float GetTProxSmithingSpeedOffSet(TerrainDef terrain)
		//{
		//	if (terrain.HasModExtension<ProximityDefs>())
		//	{
		//		return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxSmithingSpeedOffSet) : null).Value;
		//	}
		//	return 0f;
		//}

		//// Token: 0x0600008B RID: 139 RVA: 0x0000642C File Offset: 0x0000462C
		//public static float GetTProxTailoringSpeedOffSet(TerrainDef terrain)
		//{
		//	if (terrain.HasModExtension<ProximityDefs>())
		//	{
		//		return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxTailoringSpeedOffSet) : null).Value;
		//	}
		//	return 0f;
		//}		
		
		// Token: 0x06000088 RID: 136 RVA: 0x00006360 File Offset: 0x00004560
		public static float GetTProxGeneralLaborSpeedOffSet(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxGeneralLaborSpeedOffSet) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000646E File Offset: 0x0000466E
		public static string GetTProxHediff(TerrainDef terrain)
		{
			if (!terrain.HasModExtension<ProximityDefs>() || terrain == null || terrain.GetModExtension<ProximityDefs>().ProxHediff == null)
			{
				return "";
			}
			if (terrain == null)
			{
				return null;
			}
			return terrain.GetModExtension<ProximityDefs>().ProxHediff;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000064A0 File Offset: 0x000046A0
		public static float GetTProxHediffSev(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new float?(terrain.GetModExtension<ProximityDefs>().ProxHediffSev) : null).Value;
			}
			return 0f;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000064E4 File Offset: 0x000046E4
		public static bool GetTProxRoomOnly(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxRoomOnly;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxRoomOnly) : null).Value;
			}
			return false;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006530 File Offset: 0x00004730
		public static int GetTProxRange(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>())
			{
				return ((terrain != null) ? new int?(terrain.GetModExtension<ProximityDefs>().ProxRange) : null).Value;
			}
			return 0;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00006570 File Offset: 0x00004770
		public static bool GetTProxQuality(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxQuality;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxQuality) : null).Value;
			}
			return false;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000065BC File Offset: 0x000047BC
		public static bool GetTProxDisabled(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxDisabled;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxDisabled) : null).Value;
			}
			return false;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00006608 File Offset: 0x00004808
		public static bool GetTProxDrafted(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxDrafted;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxDrafted) : null).Value;
			}
			return false;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00006654 File Offset: 0x00004854
		public static bool GetTProxComposMentis(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxComposMentis;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxComposMentis) : null).Value;
			}
			return false;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000066A0 File Offset: 0x000048A0
		public static bool GetTProxColonist(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxColonist;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxColonist) : null).Value;
			}
			return false;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000066EC File Offset: 0x000048EC
		public static bool GetTProxOutsider(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxOutsider;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxOutsider) : null).Value;
			}
			return false;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00006738 File Offset: 0x00004938
		public static bool GetTProxAlly(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxAlly;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxAlly) : null).Value;
			}
			return false;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00006784 File Offset: 0x00004984
		public static bool GetTProxNeutral(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxNeutral;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxNeutral) : null).Value;
			}
			return false;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000067D0 File Offset: 0x000049D0
		public static bool GetTProxHostile(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxHostile;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxHostile) : null).Value;
			}
			return false;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000681C File Offset: 0x00004A1C
		public static bool GetTProxPrisoner(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxPrisoner;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxPrisoner) : null).Value;
			}
			return false;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00006868 File Offset: 0x00004A68
		public static bool GetTProxAnimal(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxAnimal;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxAnimal) : null).Value;
			}
			return false;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000068B4 File Offset: 0x00004AB4
		public static bool GetTProxInsectoid(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxInsectoid;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxInsectoid) : null).Value;
			}
			return false;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006900 File Offset: 0x00004B00
		public static bool GetTProxMechanoid(TerrainDef terrain)
		{
			if (terrain.HasModExtension<ProximityDefs>() && terrain != null)
			{
                _ = terrain.GetModExtension<ProximityDefs>().ProxMechanoid;
                return ((terrain != null) ? new bool?(terrain.GetModExtension<ProximityDefs>().ProxMechanoid) : null).Value;
			}
			return false;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000694C File Offset: 0x00004B4C
		public static List<string> GetTProxEquipped(TerrainDef terrain)
		{
			if (!terrain.HasModExtension<ProximityDefs>() || (terrain?.GetModExtension<ProximityDefs>().ProxEquipped) == null)
			{
				return null;
			}
			if (terrain == null)
			{
				return null;
			}
			return terrain.GetModExtension<ProximityDefs>().ProxEquipped;
		}
	}
}
