using System;
using System.Linq;
using Verse;

namespace Proximity;

[StaticConstructorOnStartup]
internal static class Proximity_Setup
{
    static Proximity_Setup()
    {
        Proximity_Setup_Pawns();
    }

    private static void Proximity_Setup_Pawns()
    {
        ProxSetup_Comp(typeof(CompProperties_ProxData), delegate(ThingDef def)
        {
            var race = def.race;
            return race is { IsFlesh: true };
        });
        ProxSetup_Comp(typeof(CompProperties_ProxData), delegate(ThingDef def)
        {
            var race = def.race;
            return race is { Humanlike: true };
        });
        ProxSetup_Comp(typeof(CompProperties_ProxData), delegate(ThingDef def)
        {
            var race = def.race;
            return race is { Animal: true };
        });
        ProxSetup_Comp(typeof(CompProperties_ProxData), delegate(ThingDef def)
        {
            var race = def.race;
            return race?.FleshType.defName == "Insectoid";
        });
        ProxSetup_Comp(typeof(CompProperties_ProxData), delegate(ThingDef def)
        {
            var race = def.race;
            return race is { IsMechanoid: true };
        });
        ProxSetup_Comp(typeof(CompProperties_ProxData), delegate(ThingDef def)
        {
            var race = def.race;
            return race?.FleshType.defName == "Mechanoid";
        });
    }

    private static void ProxSetup_Comp(Type compType, Func<ThingDef, bool> qualifier)
    {
        //IL_0078: Unknown result type (might be due to invalid IL or missing references)
        //IL_0082: Expected O, but got Unknown
        var list = DefDatabase<ThingDef>.AllDefsListForReading.Where(qualifier).ToList();
        list.RemoveDuplicates();
        foreach (var item in list)
        {
            if (item.comps != null && !item.comps.Any(c => c.GetType() == compType))
            {
                item.comps.Add((CompProperties)Activator.CreateInstance(compType));
            }
        }
    }
}