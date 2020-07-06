using System;
using System.Collections.Generic;
using System.Linq;
using Verse;

namespace Proximity
{
	// Token: 0x02000007 RID: 7
	[StaticConstructorOnStartup]
	internal static class Proximity_Setup
	{
		// Token: 0x0600001E RID: 30 RVA: 0x0000460C File Offset: 0x0000280C
		static Proximity_Setup()
		{
			Proximity_Setup.Proximity_Setup_Pawns();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004614 File Offset: 0x00002814
		private static void Proximity_Setup_Pawns()
		{
			Proximity_Setup.ProxSetup_Comp(typeof(CompProperties_ProxData), delegate(ThingDef def)
			{
				RaceProperties race = def.race;
				return race != null && race.IsFlesh;
			});
			Proximity_Setup.ProxSetup_Comp(typeof(CompProperties_ProxData), delegate(ThingDef def)
			{
				RaceProperties race = def.race;
				return race != null && race.Humanlike;
			});
			Proximity_Setup.ProxSetup_Comp(typeof(CompProperties_ProxData), delegate(ThingDef def)
			{
				RaceProperties race = def.race;
				return race != null && race.Animal;
			});
			Proximity_Setup.ProxSetup_Comp(typeof(CompProperties_ProxData), delegate(ThingDef def)
			{
				RaceProperties race = def.race;
				return ((race != null) ? race.FleshType.defName : null) == "Insectoid";
			});
			Proximity_Setup.ProxSetup_Comp(typeof(CompProperties_ProxData), delegate(ThingDef def)
			{
				RaceProperties race = def.race;
				return race != null && race.IsMechanoid;
			});
			Proximity_Setup.ProxSetup_Comp(typeof(CompProperties_ProxData), delegate(ThingDef def)
			{
				RaceProperties race = def.race;
				return ((race != null) ? race.FleshType.defName : null) == "Mechanoid";
			});
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004738 File Offset: 0x00002938
		private static void ProxSetup_Comp(Type compType, Func<ThingDef, bool> qualifier)
		{
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			List<ThingDef> list = DefDatabase<ThingDef>.AllDefsListForReading.Where(qualifier).ToList();
			GenList.RemoveDuplicates<ThingDef>(list);
			foreach (ThingDef item in list)
			{
				if (item.comps != null && !GenCollection.Any<CompProperties>(item.comps, (Predicate<CompProperties>)((CompProperties c) => (object)((object)c).GetType() == compType)))
				{
					item.comps.Add((CompProperties)(object)(CompProperties)Activator.CreateInstance(compType));
				}
			}
		}
	}
}
