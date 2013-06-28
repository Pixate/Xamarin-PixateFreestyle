using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("PXEngine", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, ForceLoad = true, LinkerFlags= "-ObjC", Frameworks= "CoreGraphics CoreText")]
