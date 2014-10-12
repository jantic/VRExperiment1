

using UnrealBuildTool;
using System.Collections.Generic;

public class VRExperiment1EditorTarget : TargetRules
{
	public VRExperiment1EditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "VRExperiment1" } );
	}
}
