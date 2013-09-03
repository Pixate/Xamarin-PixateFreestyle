using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using PixateLib;

namespace SimpleDemo1
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			// 
			// ENTER YOUR LICENSE INFO HERE
			//
			PXEngine.LicenseKeyForUser("SERIAL NUMBER", "USER NAME");
			
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
