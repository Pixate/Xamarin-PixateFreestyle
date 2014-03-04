using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloWorld
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			// This is not strictly required right now, but a good practice to add for future feature support
			PixateFreestyleLib.PixateFreestyle.InitializePixateFreestyle ();

			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
