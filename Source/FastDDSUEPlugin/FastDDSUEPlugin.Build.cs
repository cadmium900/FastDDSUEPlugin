// Copyright Epic Games, Inc. All Rights Reserved.

using System;
using System.IO;
using UnrealBuildTool;

public class FastDDSUEPlugin : ModuleRules
{
	public FastDDSUEPlugin(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		bUseRTTI = true;
		bEnableExceptions = true;
		PublicIncludePaths.AddRange(
			new string[] {
			}
			);
		PublicIncludePaths.Add( Path.Combine(ModuleDirectory, "include"));

        
		/*PublicDefinitions.Add("FASTRTPS_NO_LIB"); // static link
		PublicDefinitions.Add("FASTCDR_NO_LIB"); // static link
		PublicDefinitions.Add("FOONATHAN_MEMORY=1");
		PublicDefinitions.Add("FOONATHAN_MEMORY_VERSION_MAJOR=0");
		PublicDefinitions.Add("FOONATHAN_MEMORY_VERSION_MINOR=7");
		PublicDefinitions.Add("FOONATHAN_MEMORY_VERSION_PATCH=3");*/
		// PublicDefinitions.Add("FASTCDR_DYN_LINK");
		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
			PublicDefinitions.Add("WIN32");
			PublicDefinitions.Add("_WINDOWS");
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "libs", "win64", "libfastcdr-2.3.lib"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "libs", "win64", "libfastdds-3.3.lib"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "libs", "win64", "foonathan_memory-0.7.3.lib"));
            PublicSystemLibraries.Add("Shlwapi.lib");
        }

        PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
