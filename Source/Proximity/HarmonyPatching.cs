using System.Reflection;
using HarmonyLib;
using Verse;

namespace Proximity;

[StaticConstructorOnStartup]
internal static class HarmonyPatching
{
    static HarmonyPatching()
    {
        new Harmony("com.Pelador.Rimworld.Proximity").PatchAll(Assembly.GetExecutingAssembly());
    }
}