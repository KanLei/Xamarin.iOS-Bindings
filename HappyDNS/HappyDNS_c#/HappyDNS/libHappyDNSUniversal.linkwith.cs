using ObjCRuntime;

[assembly: LinkWith ("libHappyDNSUniversal.a", LinkTarget.ArmV7|LinkTarget.ArmV7s|LinkTarget.Arm64|LinkTarget.Simulator|LinkTarget.Simulator64 , Frameworks = "Foundation", LinkerFlags = "-lresolv", SmartLink = true, ForceLoad = true)]
