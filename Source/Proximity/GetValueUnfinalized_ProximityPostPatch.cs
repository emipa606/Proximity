using System;
using HarmonyLib;
using RimWorld;
using Verse;

namespace Proximity
{
	// Token: 0x02000002 RID: 2
	[HarmonyPatch(typeof(StatWorker), "GetValueUnfinalized")]
	public class GetValueUnfinalized_ProximityPostPatch
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[HarmonyPostfix]
        [Obsolete]
        public static void PostFix(ref float __result, StatWorker __instance, StatDef ___stat, StatRequest req)
		{
			if (!req.HasThing)
			{
				return;
			}
			Thing thing = req.Thing;
			if (!(thing is Pawn))
			{
				return;
			}
			if (___stat == StatDefOf.MoveSpeed)
			{
				__result += ProximityData.GetProxData(thing, 1);
			}
			if (___stat == StatDefOf.GlobalLearningFactor)
			{
				__result += ProximityData.GetProxData(thing, 2);
			}
			if (___stat == StatDefOf.NegotiationAbility)
			{
				__result += ProximityData.GetProxData(thing, 24);
			}
			if (___stat == StatDefOf.PsychicSensitivity)
			{
				__result += ProximityData.GetProxData(thing, 3);
			}
			if (___stat == StatDefOf.SocialImpact)
			{
				__result += ProximityData.GetProxData(thing, 25);
			}
			if (___stat == StatDefOf.ToxicSensitivity)
			{
				__result += ProximityData.GetProxData(thing, 4);
			}
			if (___stat == StatDefOf.ComfyTemperatureMin)
			{
				__result += ProximityData.GetProxData(thing, 47);
			}
			if (___stat == StatDefOf.ComfyTemperatureMax)
			{
				__result += ProximityData.GetProxData(thing, 48);
			}
			if (___stat == StatDefOf.ShootingAccuracyPawn)
			{
				__result += ProximityData.GetProxData(thing, 29);
			}
			if (___stat == StatDefOf.AimingDelayFactor)
			{
				__result += ProximityData.GetProxData(thing, 22);
			}
			if (___stat == StatDefOf.MeleeDodgeChance)
			{
				__result += ProximityData.GetProxData(thing, 9);
			}
			if (___stat == StatDefOf.MeleeHitChance)
			{
				__result += ProximityData.GetProxData(thing, 10);
			}
			if (___stat == StatDefOf.ImmunityGainSpeed)
			{
				__result += ProximityData.GetProxData(thing, 23);
			}
			if (___stat == StatDefOf.MedicalTendSpeed)
			{
				__result += ProximityData.GetProxData(thing, 32);
			}
			if (___stat == StatDefOf.MedicalTendQuality)
			{
				__result += ProximityData.GetProxData(thing, 33);
			}
			if (___stat == ProxGlobals.StatDefOf.MedicalOperationSpeed)
			{
				__result += ProximityData.GetProxData(thing, 34);
			}
			if (___stat == StatDefOf.MedicalSurgerySuccessChance)
			{
				__result += ProximityData.GetProxData(thing, 35);
			}
			if (___stat == StatDefOf.AnimalGatherSpeed)
			{
				__result += ProximityData.GetProxData(thing, 11);
			}
			if (___stat == StatDefOf.AnimalGatherYield)
			{
				__result += ProximityData.GetProxData(thing, 27);
			}
			if (___stat == StatDefOf.ConstructionSpeed)
			{
				__result += ProximityData.GetProxData(thing, 12);
			}
			if (___stat == StatDefOf.ConstructSuccessChance)
			{
				__result += ProximityData.GetProxData(thing, 19);
			}
			if (___stat == StatDefOf.EatingSpeed)
			{
				__result += ProximityData.GetProxData(thing, 13);
			}
			if (___stat == StatDefOf.HuntingStealth)
			{
				__result += ProximityData.GetProxData(thing, 30);
			}
			if (___stat == StatDefOf.MiningSpeed)
			{
				__result += ProximityData.GetProxData(thing, 14);
			}
			if (___stat == StatDefOf.PlantHarvestYield)
			{
				__result += ProximityData.GetProxData(thing, 20);
			}
			if (___stat == StatDefOf.PlantWorkSpeed)
			{
				__result += ProximityData.GetProxData(thing, 15);
			}
			if (___stat == StatDefOf.ResearchSpeed)
			{
				__result += ProximityData.GetProxData(thing, 28);
			}
			if (___stat == StatDefOf.SmoothingSpeed)
			{
				__result += ProximityData.GetProxData(thing, 16);
			}
			if (___stat == StatDefOf.TameAnimalChance)
			{
				__result += ProximityData.GetProxData(thing, 21);
			}
			if (___stat == StatDefOf.TrainAnimalChance)
			{
				__result += ProximityData.GetProxData(thing, 26);
			}
            if (___stat == StatDefOf.WorkSpeedGlobal)
			{
				__result += ProximityData.GetProxData(thing, 18);
			}
			if (___stat == ProxGlobals.StatDefOf.ButcheryFleshSpeed)
			{
				__result += ProximityData.GetProxData(thing, 36);
			}
			if (___stat == ProxGlobals.StatDefOf.ButcheryMechanoidSpeed)
			{
				__result += ProximityData.GetProxData(thing, 37);
			}
			if (___stat == ProxGlobals.StatDefOf.ButcheryFleshEfficiency)
			{
				__result += ProximityData.GetProxData(thing, 38);
			}
			if (___stat == ProxGlobals.StatDefOf.ButcheryMechanoidEfficiency)
			{
				__result += ProximityData.GetProxData(thing, 39);
			}
			if (___stat == ProxGlobals.StatDefOf.CookSpeed)
			{
				__result += ProximityData.GetProxData(thing, 40);
			}
			if (___stat == ProxGlobals.StatDefOf.DrugCookingSpeed)
			{
				__result += ProximityData.GetProxData(thing, 41);
			}
			if (___stat == ProxGlobals.StatDefOf.DrugSynthesisSpeed)
			{
				__result += ProximityData.GetProxData(thing, 42);
			}
			if (___stat == StatDefOf.FixBrokenDownBuildingSuccessChance)
			{
				__result += ProximityData.GetProxData(thing, 31);
			}
			if (___stat == ProxGlobals.StatDefOf.SmeltingSpeed)
			{
				__result += ProximityData.GetProxData(thing, 44);
			}
			if (___stat == ProxGlobals.StatDefOf.GeneralLaborSpeed)
			{
				__result += ProximityData.GetProxData(thing, 49);
			}
		}
	}
}
