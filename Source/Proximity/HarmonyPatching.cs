using System;
using System.Reflection;
using HarmonyLib;
using Verse;

namespace Proximity
{
	// Token: 0x02000004 RID: 4
	[StaticConstructorOnStartup]
	internal static class HarmonyPatching
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002CEA File Offset: 0x00000EEA
		static HarmonyPatching()
		{
			new Harmony("com.Pelador.Rimworld.Proximity").PatchAll(Assembly.GetExecutingAssembly());
		}
	}
}
