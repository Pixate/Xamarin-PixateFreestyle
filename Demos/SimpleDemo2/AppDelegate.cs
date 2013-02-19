using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;
using PixateLib;

namespace SimpleDemo2
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			window.RootViewController = new MyViewController();

			// make the window visible
			window.MakeKeyAndVisible ();

			// Print the version an build date
			Console.WriteLine("Pixate Engine v{0} {1}", PXEngine.Version, PXEngine.BuildDate);

			// Print the location of the current application-level stylesheet
			Console.WriteLine("CSS File location: {0}", PXEngine.CurrentApplicationStylesheet().FilePath);

			// Monitor for changes in the stylesheet and update styles live
			PXEngine.CurrentApplicationStylesheet().MonitorChanges = true;

			return true;
		}
	}

	public class MyViewController : UIViewController
	{
		UIButton button1;
		UIButton button2;
		UIButton button3;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			button1 = UIButton.FromType(UIButtonType.RoundedRect);
			button1.Frame = new RectangleF(50, 20, 200, 40);
			button1.SetTitle("#myButton1 .allButtons", UIControlState.Normal);
			PXEngine.SetStyleId(button1, "myButton1");
			PXEngine.SetStyleClass(button1, "allButtons");

			button2 = UIButton.FromType(UIButtonType.RoundedRect);
			button2.Frame = new RectangleF(50, 70, 200, 40);
			button2.SetTitle("#myButton2 .allButtons", UIControlState.Normal);
			PXEngine.SetStyleId(button2, "myButton2");
			PXEngine.SetStyleClass(button2, "allButtons");

			button3 = UIButton.FromType(UIButtonType.RoundedRect);
			button3.Frame = new RectangleF(50, 120, 200, 40);
			button3.SetTitle("#myButton3 .allButtons", UIControlState.Normal);
			PXEngine.SetStyleId(button3, "myButton3");
			PXEngine.SetStyleClass(button1, "allButtons");

			PXEngine.SetStyleCSS(button3, "background-color: green; border-radius: 5;");

			this.View.AddSubview(button1);
			this.View.AddSubview(button2);
			this.View.AddSubview(button3);
		}
	}

}

