using System.Reflection;
using System.Runtime.CompilerServices;
using MonoTouch.ObjCRuntime;

// Information about this assembly is defined by the following attributes.
// Change them to the values specific to your project.
[assembly: AssemblyTitle ("PixateFreestyle")]
[assembly: AssemblyDescription ("")]
[assembly: AssemblyConfiguration ("")]
[assembly: AssemblyCompany ("Pixate, Inc.")]
[assembly: AssemblyProduct ("Pixate, Inc.")]
[assembly: AssemblyCopyright ("Pixate, Inc.")]
[assembly: AssemblyTrademark ("")]
[assembly: AssemblyCulture ("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.
[assembly: AssemblyVersion ("2.1.*")]

// The following attributes are used to specify the signing key for the assembly,
// if desired. See the Mono documentation for more information about signing.
//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

// Link the native Pixate Freestyle library
[assembly: LinkWith ("PixateFreestyle", LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s, LinkerFlags= "-ObjC", Frameworks= "CoreGraphics CoreText QuartzCore")]
