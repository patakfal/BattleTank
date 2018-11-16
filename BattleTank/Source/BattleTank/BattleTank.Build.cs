// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class BattleTank : ModuleRules
{
	public BattleTank(ReadOnlyTargetRules Target) : base (Target)
	{
 
		// Make sure UBT reminds us of how to keep the project IWYU compliant
        bEnforceIWYU = true;

        //Enable IWYU but keep our PrivatePCH in use
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        //Our PrivatePCH that we want to globally #include
        PrivatePCHHeaderFile = "BattleTank.h";


 		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");
		// if ((Target.Platform == UnrealTargetPlatform.Win32) || (Target.Platform == UnrealTargetPlatform.Win64))
		// {
		//		if (UEBuildConfiguration.bCompileSteamOSS == true)
		//		{
		//			DynamicallyLoadedModuleNames.Add("OnlineSubsystemSteam");
		//		}
		// }
	}
}
