using System.Collections.Generic;
using RimWorld;
using Verse;

namespace Proximity;

internal class ProxGlobals
{
    internal static readonly int closeRange = 10;

    internal static readonly int ProxSecondTick = 2;

    private static List<ThingDef> _proximityThings;


    private static HashSet<TerrainDef> _proximityTerrains;

    public static List<ThingDef> ProximityThings
    {
        get
        {
            if (_proximityThings != null)
            {
                return _proximityThings;
            }

            _proximityThings = new List<ThingDef>();
            foreach (var def in DefDatabase<ThingDef>.AllDefs)
            {
                if (def.thingClass == null || !typeof(Building).IsAssignableFrom(def.thingClass))
                {
                    continue;
                }

                if (def.HasModExtension<ProximityDefs>())
                {
                    _proximityThings.Add(def);
                }
            }

            return _proximityThings;
        }
    }

    public static HashSet<TerrainDef> ProximityTerrains
    {
        get
        {
            if (_proximityTerrains is not null)
            {
                return _proximityTerrains;
            }

            _proximityTerrains = new HashSet<TerrainDef>();
            foreach (var terrain in DefDatabase<TerrainDef>.AllDefs)
            {
                if (terrain.HasModExtension<ProximityDefs>())
                {
                    _proximityTerrains.Add(terrain);
                }
            }

            return _proximityTerrains;
        }
    }

    internal static int ExtendTicks()
    {
        var num = ProxSecondTick;
        num = num < 2 ? 2 : num;
        var num2 = num * 15;
        num2 = num2 > 120 ? 120 : num2;
        return Rand.Range((num * 60) - num2, (num * 60) + num2);
    }

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

    internal static bool IsNearThingValid(Thing NearThing, Pawn pawn)
    {
        if (!ProximityGet.GetProxDisabled(NearThing.def))
        {
            return true;
        }

        if (NearThing.IsBrokenDown() || NearThing.IsForbidden(pawn))
        {
            return false;
        }

        var compFlickable = NearThing.TryGetComp<CompFlickable>();
        if (compFlickable is { SwitchIsOn: false })
        {
            return false;
        }

        var compRefuelable = NearThing.TryGetComp<CompRefuelable>();
        if (compRefuelable is { HasFuel: false })
        {
            return false;
        }

        var compPowerTrader = NearThing.TryGetComp<CompPowerTrader>();
        return compPowerTrader is not { PowerOn: false };
    }

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

        if (pawn is { IsColonist: true } && !ProximityGet.GetProxColonist(def))
        {
            return false;
        }

        if (pawn is { Drafted: true } && !ProximityGet.GetProxDrafted(def))
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

    [DefOf]
    public static class StatDefOf
    {
        public static StatDef MedicalTendSpeed;

        public static StatDef MedicalTendQuality;

        public static StatDef MedicalOperationSpeed;

        public static StatDef MedicalSurgerySuccessChance;

        public static StatDef ButcheryFleshSpeed;

        public static StatDef ButcheryMechanoidSpeed;

        public static StatDef ButcheryFleshEfficiency;

        public static StatDef ButcheryMechanoidEfficiency;

        public static StatDef CookSpeed;

        public static StatDef DrugCookingSpeed;

        public static StatDef DrugSynthesisSpeed;

        public static StatDef SmeltingSpeed;

        public static StatDef GeneralLaborSpeed;
    }
}