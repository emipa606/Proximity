using RimWorld;
using Verse;

namespace Proximity
{
    // Token: 0x02000003 RID: 3
    internal class ProxGlobals
    {
        // Token: 0x04000001 RID: 1
        internal static int closeRange = 10;

        // Token: 0x04000002 RID: 2
        internal static int ProxSecondTick = 2;

        // Token: 0x04000003 RID: 3
        internal static bool UseTerrain = true;

        // Token: 0x06000003 RID: 3 RVA: 0x00002418 File Offset: 0x00000618
        internal static int ExtendTicks()
        {
            var num = ProxSecondTick;
            num = num < 2 ? 2 : num;
            var num2 = num * 15;
            num2 = num2 > 120 ? 120 : num2;
            return Rand.Range((num * 60) - num2, (num * 60) + num2);
        }

        // Token: 0x06000004 RID: 4 RVA: 0x00002458 File Offset: 0x00000658
        internal static void ProximityHediffEffect(Thing thing, Pawn pawn)
        {
            if (pawn.RaceProps.IsMechanoid)
            {
                return;
            }

            var text = ProximityGet.GetProxHediff(thing.def) ?? "";
            var proxHediffSev = ProximityGet.GetProxHediffSev(thing.def);
            var proxRange = ProximityGet.GetProxRange(thing.def);
            if (proxHediffSev == 0f || text == "" || !NearThingInRange(thing, pawn, proxRange))
            {
                return;
            }

            var named = DefDatabase<HediffDef>.GetNamed(text, false);
            if (named == null || ProxImmuneTo(pawn, named))
            {
                return;
            }

            var health = pawn.health;
            Hediff hediff;
            if (health == null)
            {
                hediff = null;
            }
            else
            {
                var hediffSet = health.hediffSet;
                hediff = hediffSet?.GetFirstHediffOfDef(named);
            }

            var hediff2 = hediff;
            if (hediff2 != null)
            {
                hediff2.Severity += proxHediffSev;
                return;
            }

            var hediff3 = HediffMaker.MakeHediff(named, pawn);
            hediff3.Severity = proxHediffSev;
            pawn.health.AddHediff(hediff3);
        }

        // Token: 0x06000005 RID: 5 RVA: 0x00002544 File Offset: 0x00000744
        internal static void ProximityTerrainHediffEffect(TerrainDef terrain, IntVec3 terrainPosition, Pawn pawn)
        {
            if (pawn.RaceProps.IsMechanoid)
            {
                return;
            }

            var text = ProximityGet.GetTProxHediff(terrain) ?? "";
            var tproxHediffSev = ProximityGet.GetTProxHediffSev(terrain);
            var tproxRange = ProximityGet.GetTProxRange(terrain);
            if (tproxHediffSev == 0f || text == "" || !TerrainInRange(terrain, terrainPosition, pawn, tproxRange))
            {
                return;
            }

            var named = DefDatabase<HediffDef>.GetNamed(text, false);
            if (named == null || ProxImmuneTo(pawn, named))
            {
                return;
            }

            var health = pawn.health;
            Hediff hediff;
            if (health == null)
            {
                hediff = null;
            }
            else
            {
                var hediffSet = health.hediffSet;
                hediff = hediffSet?.GetFirstHediffOfDef(named);
            }

            var hediff2 = hediff;
            if (hediff2 != null)
            {
                hediff2.Severity += tproxHediffSev;
                return;
            }

            var hediff3 = HediffMaker.MakeHediff(named, pawn);
            hediff3.Severity = tproxHediffSev;
            pawn.health.AddHediff(hediff3);
        }

        // Token: 0x06000006 RID: 6 RVA: 0x00002620 File Offset: 0x00000820
        internal static bool ProxImmuneTo(Pawn pawn, HediffDef def)
        {
            var hediffs = pawn.health.hediffSet.hediffs;
            foreach (var hediff in hediffs)
            {
                var curStage = hediff.CurStage;
                if (curStage?.makeImmuneTo == null)
                {
                    continue;
                }

                foreach (var hediffDef in curStage.makeImmuneTo)
                {
                    if (hediffDef == def)
                    {
                        return true;
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

            if (EffRange > closeRange)
            {
                EffRange = closeRange;
            }

            return thing.Position.InHorDistOf(pawn.Position, EffRange);
        }

        // Token: 0x06000008 RID: 8 RVA: 0x000026CE File Offset: 0x000008CE
        internal static bool TerrainInRange(TerrainDef terrain, IntVec3 terrainPosition, Pawn pawn, int EffRange)
        {
            if (EffRange < 0)
            {
                EffRange = 0;
            }

            if (EffRange > closeRange)
            {
                EffRange = closeRange;
            }

            return terrainPosition.InHorDistOf(pawn.Position, EffRange);
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

            if (!ProximityGet.GetProxDisabled(NearThing.def))
            {
                return true;
            }

            if (NearThing.IsBrokenDown() || NearThing.IsForbidden(pawn))
            {
                return false;
            }

            var compFlickable = NearThing.TryGetComp<CompFlickable>();
            if (compFlickable != null && !compFlickable.SwitchIsOn)
            {
                return false;
            }

            var compRefuelable = NearThing.TryGetComp<CompRefuelable>();
            if (compRefuelable != null && !compRefuelable.HasFuel)
            {
                return false;
            }

            var compPowerTrader = NearThing.TryGetComp<CompPowerTrader>();
            if (compPowerTrader != null && !compPowerTrader.PowerOn)
            {
                return false;
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
            var def = thing.def;
            if (ProximityGet.GetProxRoomOnly(def))
            {
                // Func def changed, this used to be GetRoom
                var room = thing.Position.GetRoomOrAdjacent(thing.Map);
                var room2 = pawn?.Position.GetRoomOrAdjacent(thing.Map);
                if (room != null && room2 != null && room != room2)
                {
                    return false;
                }
            }

            if (pawn != null && pawn.IsColonist && !ProximityGet.GetProxColonist(def))
            {
                return false;
            }

            if (pawn != null && pawn.Drafted && !ProximityGet.GetProxDrafted(def))
            {
                return false;
            }

            if (!ProximityGet.GetProxComposMentis(def))
            {
                return pawn != null && (!pawn.RaceProps.IsMechanoid || ProximityGet.GetProxMechanoid(def)) &&
                       (pawn.RaceProps.FleshType.defName != "Insectoid" || ProximityGet.GetProxInsectoid(def)) &&
                       (!pawn.AnimalOrWildMan() || ProximityGet.GetProxAnimal(def)) &&
                       (!pawn.IsPrisoner || ProximityGet.GetProxPrisoner(def)) &&
                       (pawn.Faction == thing.Faction || GetEffectsOutsider(thing, pawn)) &&
                       (ProximityGet.GetProxEquipped(def) == null || GetPawnHasEquipment(thing, pawn));
            }

            if (pawn != null && (pawn.Downed || pawn.InMentalState || pawn.IsBurning() ||
                                 HealthAIUtility.ShouldSeekMedicalRest(pawn)))
            {
                return false;
            }

            if (!pawn.Awake())
            {
                return false;
            }

            return pawn != null && (!pawn.RaceProps.IsMechanoid || ProximityGet.GetProxMechanoid(def)) &&
                   (pawn.RaceProps.FleshType.defName != "Insectoid" || ProximityGet.GetProxInsectoid(def)) &&
                   (!pawn.AnimalOrWildMan() || ProximityGet.GetProxAnimal(def)) &&
                   (!pawn.IsPrisoner || ProximityGet.GetProxPrisoner(def)) &&
                   (pawn.Faction == thing.Faction || GetEffectsOutsider(thing, pawn)) &&
                   (ProximityGet.GetProxEquipped(def) == null || GetPawnHasEquipment(thing, pawn));
        }

        // Token: 0x0600000C RID: 12 RVA: 0x000028CC File Offset: 0x00000ACC
        internal static bool TerrainEffects(TerrainDef terrain, IntVec3 terrainPosition, Pawn pawn)
        {
            if (ProximityGet.GetTProxRoomOnly(terrain))
            {
                var room = terrainPosition.GetRoomOrAdjacent(pawn.Map);
                var room2 = pawn.Position.GetRoomOrAdjacent(pawn.Map);
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
                if (pawn.Downed || pawn.InMentalState || pawn.IsBurning() ||
                    HealthAIUtility.ShouldSeekMedicalRest(pawn))
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

            var faction = pawn.Faction;
            var map = pawn.Map;
            return (faction == map?.ParentFaction || GetTerrainEffectsOutsider(terrain, pawn)) &&
                   (ProximityGet.GetTProxEquipped(terrain) == null || GetTerrainPawnHasEquipment(terrain, pawn));
        }

        // Token: 0x0600000D RID: 13 RVA: 0x00002A08 File Offset: 0x00000C08
        internal static bool GetPawnHasEquipment(Thing thing, Pawn pawn)
        {
            var proxEquipped = ProximityGet.GetProxEquipped(thing.def);
            if (proxEquipped.Count <= 0)
            {
                return false;
            }

            foreach (var defName in proxEquipped)
            {
                var named = DefDatabase<ThingDef>.GetNamed(defName, false);
                if (named == null || !pawn.equipment.HasAnything())
                {
                    continue;
                }

                var allEquipmentListForReading = pawn.equipment.AllEquipmentListForReading;
                if (allEquipmentListForReading.Count <= 0)
                {
                    continue;
                }

                foreach (var thingWithComps in allEquipmentListForReading)
                {
                    if (thingWithComps.def.defName == named.defName)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Token: 0x0600000E RID: 14 RVA: 0x00002AA8 File Offset: 0x00000CA8
        internal static bool GetTerrainPawnHasEquipment(TerrainDef terrain, Pawn pawn)
        {
            var tproxEquipped = ProximityGet.GetTProxEquipped(terrain);
            if (tproxEquipped.Count <= 0)
            {
                return false;
            }

            foreach (var defName in tproxEquipped)
            {
                var named = DefDatabase<ThingDef>.GetNamed(defName, false);
                if (named == null || !pawn.equipment.HasAnything())
                {
                    continue;
                }

                var allEquipmentListForReading = pawn.equipment.AllEquipmentListForReading;
                if (allEquipmentListForReading.Count <= 0)
                {
                    continue;
                }

                foreach (var thingWithComps in allEquipmentListForReading)
                {
                    if (thingWithComps.def.defName == named.defName)
                    {
                        return true;
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

            if (thing.Faction == null || pawn.Faction == null)
            {
                return false;
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
            else if (pawn.Faction.RelationKindWith(thing.Faction) == FactionRelationKind.Hostile &&
                     ProximityGet.GetProxHostile(thing.def))
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

            var map = pawn.Map;
            var faction = map?.ParentFaction;
            if (faction == null || pawn.Faction == null)
            {
                return false;
            }

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
            else if (pawn.Faction.RelationKindWith(faction) == FactionRelationKind.Hostile &&
                     ProximityGet.GetTProxHostile(terrain))
            {
                return true;
            }

            return false;
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002C40 File Offset: 0x00000E40
        internal static float GetProxQualFactor(Thing thing)
        {
            var result = 1f;
            if (!ProximityGet.GetProxQuality(thing.def) || !thing.TryGetQuality(out var qualityCategory))
            {
                return result;
            }

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

            return result;
        }

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

            // Token: 0x0400007B RID: 123
            public static StatDef SmeltingSpeed;

            // Token: 0x0400007B RID: 126
            public static StatDef GeneralLaborSpeed;
        }
    }
}