# GitHub Copilot Instructions for Proximity (Continued) Mod

## Overview

Proximity (Continued) is a RimWorld mod that allows modders to manipulate stats and add hediff effects to pawns when they are in proximity to buildings or terrain. This mod does not add new content to the game itself but provides valuable functionality for other modders to use.

## Key Features and Systems

### Proximity System
- **Stat Manipulation**: Modifies pawn stats based on proximity to buildings or terrain.
- **Hediff Effects**: Applies hediff effects to pawns when they are near specified buildings or terrain.

### Setup
- **Building/Terrain Definitions**: Modders need to define which buildings or terrain should trigger proximity effects.
- **Effect Configuration**: Configures the effects, such as stat changes and hediffs, that occur when pawns are in proximity.

### Performance Optimizations
- **Efficient Proximity Checks**: Optimizes the checks for pawns being near buildings or terrain to improve performance.

## Coding Patterns and Conventions

### C# Coding Conventions
- **Modular Design**: The code is organized into separate classes and files, such as `Proximity_Setup.cs`, `ProxGlobals.cs`, etc., to maintain a clean and modular design.
- **Type and Member Naming**: Types and members are named descriptively to reflect their functionality, e.g., `Proximity_Setup`, `Proximity_Setup_Pawns`, `ProxSetup_Comp`.

### XML Integration
- **XML Configuration**: While this mod does not use XML definitions itself, it is designed to work with XML configurations provided by other mods. Ensure that XML files are properly structured and referenced.

### Harmony Patching
- **Harmony Integration**: The mod uses the Harmony library to patch RimWorld's existing code. Ensure that Harmony patches are correctly applied and do not conflict with other mods.

## Suggestions for Copilot

### XML Integration
- When working with XML configurations, ensure that the XML files are properly formatted and that the mod references the correct XML files.
- Use XML comments to describe the purpose of each XML element and attribute.

### Harmony Patching
- When creating Harmony patches, ensure that the patches are correctly targeted and do not cause conflicts with other mods.
- Test the patches thoroughly in a controlled environment before deploying them.

### General Tips
- Always test the mod in a clean RimWorld installation to ensure compatibility.
- Use RimSort to sort your mods for better performance and compatibility.
- For best support, use the Discord-channel for error-reporting. Do not report errors by making discussion threads; instead, post your log using the Log Uploader.

## Example Usage

### Example of Adding a Proximity Effect
xml
<!-- Example XML configuration for a custom building -->
<ThingDef ParentName="Building">
    <defName>CustomBuilding</defName>
    <label>Custom Building</label>
    <description>This is a custom building with proximity effects.</description>
    <thingCategories>
        <li>Buildings</li>
    </thingCategories>
    <comps>
        <li>
            <compClass>ProximityDefs</compClass>
            <proximityEffects>
                <li>
                    <stat>StatDefOf.Stamina</stat>
                    <value>0.1</value>
                </li>
                <li>
                    <hediff>HediffDefOf.Bleeding</hediff>
                    <severity>0.05</severity>
                </li>
            </proximityEffects>
        </li>
    </comps>
</ThingDef>


### Example of Harmony Patch
csharp
// Example Harmony patch to modify a RimWorld method
using HarmonyLib;
using RimWorld;
using Verse;

[HarmonyPatch(typeof(Pawn), "Tick")]
public static class HarmonyPatch_Pawn_Tick
{
    [HarmonyPostfix]
    public static void Postfix(Pawn __instance)
    {
        // Custom logic for proximity effects
        if (ProximityData.TryGetProxData(__instance, out var data))
        {
            // Apply proximity effects
        }
    }
}


By following these guidelines, you can effectively use GitHub Copilot to enhance your modding experience with Proximity (Continued).

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

