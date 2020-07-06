using System;
using System.Collections.Generic;
using RimWorld;
using Verse;

namespace Proximity
{
	// Token: 0x02000003 RID: 3
	internal class ProxGlobals
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002418 File Offset: 0x00000618
		internal static int extendTicks()
		{
			int num = ProxGlobals.ProxSecondTick;
			num = ((num < 2) ? 2 : num);
			int num2 = num * 15;
			num2 = ((num2 > 120) ? 120 : num2);
			return Rand.Range(num * 60 - num2, num * 60 + num2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002458 File Offset: 0x00000658
		internal static void ProximityHediffEffect(Thing thing, Pawn pawn)
		{
			if (!pawn.RaceProps.IsMechanoid)
			{
				string text = (ProximityGet.GetProxHediff(thing.def) != null) ? ProximityGet.GetProxHediff(thing.def) : "";
				float proxHediffSev = ProximityGet.GetProxHediffSev(thing.def);
				int proxRange = ProximityGet.GetProxRange(thing.def);
				if (proxHediffSev != 0f && text != "" && ProxGlobals.NearThingInRange(thing, pawn, proxRange))
				{
					HediffDef named = DefDatabase<HediffDef>.GetNamed(text, false);
					if (named != null && !ProxGlobals.ProxImmuneTo(pawn, named))
					{
						Pawn_HealthTracker health = pawn.health;
						Hediff hediff;
						if (health == null)
						{
							hediff = null;
						}
						else
						{
							HediffSet hediffSet = health.hediffSet;
							hediff = ((hediffSet != null) ? hediffSet.GetFirstHediffOfDef(named, false) : null);
						}
						Hediff hediff2 = hediff;
						if (hediff2 != null)
						{
							hediff2.Severity += proxHediffSev;
							return;
						}
						Hediff hediff3 = HediffMaker.MakeHediff(named, pawn, null);
						hediff3.Severity = proxHediffSev;
						pawn.health.AddHediff(hediff3, null, null, null);
					}
				}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002544 File Offset: 0x00000744
		internal static void ProximityTerrainHediffEffect(TerrainDef terrain, IntVec3 terrainPosition, Pawn pawn)
		{
			if (!pawn.RaceProps.IsMechanoid)
			{
				string text = (ProximityGet.GetTProxHediff(terrain) != null) ? ProximityGet.GetTProxHediff(terrain) : "";
				float tproxHediffSev = ProximityGet.GetTProxHediffSev(terrain);
				int tproxRange = ProximityGet.GetTProxRange(terrain);
				if (tproxHediffSev != 0f && text != "" && ProxGlobals.TerrainInRange(terrain, terrainPosition, pawn, tproxRange))
				{
					HediffDef named = DefDatabase<HediffDef>.GetNamed(text, false);
					if (named != null && !ProxGlobals.ProxImmuneTo(pawn, named))
					{
						Pawn_HealthTracker health = pawn.health;
						Hediff hediff;
						if (health == null)
						{
							hediff = null;
						}
						else
						{
							HediffSet hediffSet = health.hediffSet;
							hediff = ((hediffSet != null) ? hediffSet.GetFirstHediffOfDef(named, false) : null);
						}
						Hediff hediff2 = hediff;
						if (hediff2 != null)
						{
							hediff2.Severity += tproxHediffSev;
							return;
						}
						Hediff hediff3 = HediffMaker.MakeHediff(named, pawn, null);
						hediff3.Severity = tproxHediffSev;
						pawn.health.AddHediff(hediff3, null, null, null);
					}
				}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002620 File Offset: 0x00000820
		internal static bool ProxImmuneTo(Pawn pawn, HediffDef def)
		{
			List<Hediff> hediffs = pawn.health.hediffSet.hediffs;
			for (int i = 0; i < hediffs.Count; i++)
			{
				HediffStage curStage = hediffs[i].CurStage;
				if (curStage != null && curStage.makeImmuneTo != null)
				{
					for (int j = 0; j < curStage.makeImmuneTo.Count; j++)
					{
						if (curStage.makeImmuneTo[j] == def)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002690 File Offset: 0x00000890
		internal static bool NearThingInRange(Thing thing, Pawn pawn, int EffRange)
		{
			if (EffRange < 0)
			{
				EffRange = 0;
			}
			if (EffRange > ProxGlobals.closeRange)
			{
				EffRange = ProxGlobals.closeRange;
			}
			return thing.Position.InHorDistOf(pawn.Position, (float)EffRange);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000026CE File Offset: 0x000008CE
		internal static bool TerrainInRange(TerrainDef terrain, IntVec3 terrainPosition, Pawn pawn, int EffRange)
		{
			if (EffRange < 0)
			{
				EffRange = 0;
			}
			if (EffRange > ProxGlobals.closeRange)
			{
				EffRange = ProxGlobals.closeRange;
			}
			return terrainPosition.InHorDistOf(pawn.Position, (float)EffRange);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000026FC File Offset: 0x000008FC
		internal static bool IsNearThingValid(Thing NearThing, Pawn pawn)
		{
			if (!(NearThing is Building))
			{
				return false;
			}
			if (!NearThing.def.HasModExtension<ProximityDefs>())
			{
				return false;
			}
			if (ProximityGet.GetProxDisabled(NearThing.def))
			{
				if (NearThing.IsBrokenDown() || NearThing.IsForbidden(pawn))
				{
					return false;
				}
				CompFlickable compFlickable = NearThing.TryGetComp<CompFlickable>();
				if (compFlickable != null && !compFlickable.SwitchIsOn)
				{
					return false;
				}
				CompRefuelable compRefuelable = NearThing.TryGetComp<CompRefuelable>();
				if (compRefuelable != null && !compRefuelable.HasFuel)
				{
					return false;
				}
				CompPowerTrader compPowerTrader = NearThing.TryGetComp<CompPowerTrader>();
				if (compPowerTrader != null && !compPowerTrader.PowerOn)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000277F File Offset: 0x0000097F
		internal static bool IsTerrainValid(TerrainDef terrain, Pawn pawn)
		{
			return terrain.HasModExtension<ProximityDefs>();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000278C File Offset: 0x0000098C
		internal static bool NearThingEffects(Thing thing, Pawn pawn)
		{
			ThingDef def = thing.def;
			if (ProximityGet.GetProxRoomOnly(def))
			{
				Room room = (thing != null) ? thing.Position.GetRoom(thing.Map, RegionType.Set_Passable) : null;
				Room room2 = (pawn != null) ? pawn.Position.GetRoom(thing.Map, RegionType.Set_Passable) : null;
				if (room != null && room2 != null && room != room2)
				{
					return false;
				}
			}
			if (pawn.IsColonist && !ProximityGet.GetProxColonist(def))
			{
				return false;
			}
			if (pawn.Drafted && !ProximityGet.GetProxDrafted(def))
			{
				return false;
			}
			if (ProximityGet.GetProxComposMentis(def))
			{
				if (pawn.Downed || pawn.InMentalState || pawn.IsBurning() || HealthAIUtility.ShouldSeekMedicalRest(pawn))
				{
					return false;
				}
				if (!pawn.Awake())
				{
					return false;
				}
			}
			return (!pawn.RaceProps.IsMechanoid || ProximityGet.GetProxMechanoid(def)) && (!(pawn.RaceProps.FleshType.defName == "Insectoid") || ProximityGet.GetProxInsectoid(def)) && (!pawn.AnimalOrWildMan() || ProximityGet.GetProxAnimal(def)) && (!pawn.IsPrisoner || ProximityGet.GetProxPrisoner(def)) && (pawn.Faction == thing.Faction || ProxGlobals.GetEffectsOutsider(thing, pawn)) && (ProximityGet.GetProxEquipped(def) == null || ProxGlobals.GetPawnHasEquipment(thing, pawn));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000028CC File Offset: 0x00000ACC
		internal static bool TerrainEffects(TerrainDef terrain, IntVec3 terrainPosition, Pawn pawn)
		{
			if (ProximityGet.GetTProxRoomOnly(terrain))
			{
				Room room = terrainPosition.GetRoom(pawn.Map, RegionType.Set_Passable);
				Room room2 = (pawn != null) ? pawn.Position.GetRoom(pawn.Map, RegionType.Set_Passable) : null;
				if (room != null && room2 != null && room != room2)
				{
					return false;
				}
			}
			if (pawn.IsColonist && !ProximityGet.GetTProxColonist(terrain))
			{
				return false;
			}
			if (pawn.Drafted && !ProximityGet.GetTProxDrafted(terrain))
			{
				return false;
			}
			if (ProximityGet.GetTProxComposMentis(terrain))
			{
				if (pawn.Downed || pawn.InMentalState || pawn.IsBurning() || HealthAIUtility.ShouldSeekMedicalRest(pawn))
				{
					return false;
				}
				if (!pawn.Awake())
				{
					return false;
				}
			}
			if (pawn.RaceProps.IsMechanoid && !ProximityGet.GetTProxMechanoid(terrain))
			{
				return false;
			}
			if (pawn.RaceProps.FleshType.defName == "Insectoid" && !ProximityGet.GetTProxInsectoid(terrain))
			{
				return false;
			}
			if (pawn.AnimalOrWildMan() && !ProximityGet.GetTProxAnimal(terrain))
			{
				return false;
			}
			if (pawn.IsPrisoner && !ProximityGet.GetTProxPrisoner(terrain))
			{
				return false;
			}
			Faction faction = pawn.Faction;
			Map map = pawn.Map;
			return (faction == ((map != null) ? map.ParentFaction : null) || ProxGlobals.GetTerrainEffectsOutsider(terrain, pawn)) && (ProximityGet.GetTProxEquipped(terrain) == null || ProxGlobals.GetTerrainPawnHasEquipment(terrain, pawn));
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002A08 File Offset: 0x00000C08
		internal static bool GetPawnHasEquipment(Thing thing, Pawn pawn)
		{
			List<string> proxEquipped = ProximityGet.GetProxEquipped(thing.def);
			if (proxEquipped.Count > 0)
			{
				for (int i = 0; i < proxEquipped.Count; i++)
				{
					ThingDef named = DefDatabase<ThingDef>.GetNamed(proxEquipped[i], false);
					if (named != null && pawn.equipment.HasAnything())
					{
						List<ThingWithComps> allEquipmentListForReading = pawn.equipment.AllEquipmentListForReading;
						if (allEquipmentListForReading.Count > 0)
						{
							for (int j = 0; j < allEquipmentListForReading.Count; j++)
							{
								if (allEquipmentListForReading[j].def.defName == named.defName)
								{
									return true;
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002AA8 File Offset: 0x00000CA8
		internal static bool GetTerrainPawnHasEquipment(TerrainDef terrain, Pawn pawn)
		{
			List<string> tproxEquipped = ProximityGet.GetTProxEquipped(terrain);
			if (tproxEquipped.Count > 0)
			{
				for (int i = 0; i < tproxEquipped.Count; i++)
				{
					ThingDef named = DefDatabase<ThingDef>.GetNamed(tproxEquipped[i], false);
					if (named != null && pawn.equipment.HasAnything())
					{
						List<ThingWithComps> allEquipmentListForReading = pawn.equipment.AllEquipmentListForReading;
						if (allEquipmentListForReading.Count > 0)
						{
							for (int j = 0; j < allEquipmentListForReading.Count; j++)
							{
								if (allEquipmentListForReading[j].def.defName == named.defName)
								{
									return true;
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002B40 File Offset: 0x00000D40
		internal static bool GetEffectsOutsider(Thing thing, Pawn pawn)
		{
			if (ProximityGet.GetProxOutsider(thing.def))
			{
				return true;
			}
			if (pawn.Faction.RelationKindWith(thing.Faction) == FactionRelationKind.Ally)
			{
				if (ProximityGet.GetProxAlly(thing.def))
				{
					return true;
				}
			}
			else if (pawn.Faction.RelationKindWith(thing.Faction) == FactionRelationKind.Neutral)
			{
				if (ProximityGet.GetProxNeutral(thing.def))
				{
					return true;
				}
			}
			else if (pawn.Faction.RelationKindWith(thing.Faction) == FactionRelationKind.Hostile && ProximityGet.GetProxHostile(thing.def))
			{
				return true;
			}
			return false;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002BC8 File Offset: 0x00000DC8
		internal static bool GetTerrainEffectsOutsider(TerrainDef terrain, Pawn pawn)
		{
			if (ProximityGet.GetTProxOutsider(terrain))
			{
				return true;
			}
			Map map = pawn.Map;
			Faction faction = (map != null) ? map.ParentFaction : null;
			if (faction != null)
			{
				if (pawn.Faction.RelationKindWith(faction) == FactionRelationKind.Ally)
				{
					if (ProximityGet.GetTProxAlly(terrain))
					{
						return true;
					}
				}
				else if (pawn.Faction.RelationKindWith(faction) == FactionRelationKind.Neutral)
				{
					if (ProximityGet.GetTProxNeutral(terrain))
					{
						return true;
					}
				}
				else if (pawn.Faction.RelationKindWith(faction) == FactionRelationKind.Hostile && ProximityGet.GetTProxHostile(terrain))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002C40 File Offset: 0x00000E40
		internal static float GetProxQualFactor(Thing thing)
		{
			float result = 1f;
			QualityCategory qualityCategory;
			if (ProximityGet.GetProxQuality(thing.def) && thing.TryGetQuality(out qualityCategory))
			{
				switch (qualityCategory)
				{
				case QualityCategory.Awful:
					result = 0.8f;
					break;
				case QualityCategory.Poor:
					result = 0.9f;
					break;
				case QualityCategory.Normal:
					result = 1f;
					break;
				case QualityCategory.Good:
					result = 1.1f;
					break;
				case QualityCategory.Excellent:
					result = 1.2f;
					break;
				case QualityCategory.Masterwork:
					result = 1.4f;
					break;
				case QualityCategory.Legendary:
					result = 1.65f;
					break;
				default:
					result = 1f;
					break;
				}
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		internal static int closeRange = 10;

		// Token: 0x04000002 RID: 2
		internal static int ProxSecondTick = 2;

		// Token: 0x04000003 RID: 3
		internal static bool UseTerrain = true;

		// Token: 0x0200000A RID: 10
		[DefOf]
		public static class StatDefOf
		{
			// Token: 0x0400006F RID: 111
			public static StatDef MedicalTendSpeed;

			// Token: 0x04000070 RID: 112
			public static StatDef MedicalTendQuality;

			// Token: 0x04000071 RID: 113
			public static StatDef MedicalOperationSpeed;

			// Token: 0x04000072 RID: 114
			public static StatDef MedicalSurgerySuccessChance;

			// Token: 0x04000073 RID: 115
			public static StatDef ButcheryFleshSpeed;

			// Token: 0x04000074 RID: 116
			public static StatDef ButcheryMechanoidSpeed;

			// Token: 0x04000075 RID: 117
			public static StatDef ButcheryFleshEfficiency;

			// Token: 0x04000076 RID: 118
			public static StatDef ButcheryMechanoidEfficiency;

			// Token: 0x04000077 RID: 119
			public static StatDef CookSpeed;

			// Token: 0x04000078 RID: 120
			public static StatDef DrugCookingSpeed;

			// Token: 0x04000079 RID: 121
			public static StatDef DrugSynthesisSpeed;

			//// Token: 0x0400007A RID: 122
			//public static StatDef SculptingSpeed;

			// Token: 0x0400007B RID: 123
			public static StatDef SmeltingSpeed;


			//// Token: 0x0400007C RID: 124
			//public static StatDef SmithingSpeed;

			//// Token: 0x0400007D RID: 125
			//public static StatDef TailoringSpeed;

			// Token: 0x0400007B RID: 126
			public static StatDef GeneralLaborSpeed;
		}
	}
}
