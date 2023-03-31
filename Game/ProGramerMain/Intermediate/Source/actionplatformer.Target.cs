using UnrealBuildTool;

public class actionplatformerTarget : TargetRules
{
	public actionplatformerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("actionplatformer");
	}
}
