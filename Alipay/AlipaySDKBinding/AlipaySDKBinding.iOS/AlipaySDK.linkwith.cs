using ObjCRuntime;

[assembly: LinkWith ("AlipaySDK.a", LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.Simulator | LinkTarget.Simulator64,
    Frameworks="Foundation UIKit CoreGraphics CoreMotion CFNetwork SystemConfiguration CoreTelephony QuartzCore CoreText Security",
    LinkerFlags="-lsqlite3.0 -lc++", SmartLink = true, ForceLoad = true)]
