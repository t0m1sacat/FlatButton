using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libFlatButtonUniversal.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, Frameworks = "UIKit Foundation CoreGraphics", ForceLoad = true)]
