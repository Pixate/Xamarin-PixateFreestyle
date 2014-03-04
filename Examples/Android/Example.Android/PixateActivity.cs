using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Example
{
	[Activity (Label = "Pixate Example", MainLauncher = true)]
	public class PixateActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Com.Pixate.Freestyle.PixateFreestyle.Init (this);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var button = FindViewById<Button> (Resource.Id.myButton);

			Com.Pixate.Freestyle.PixateFreestyle.SetStyleId (button, "myButton");
		}
	}
}


