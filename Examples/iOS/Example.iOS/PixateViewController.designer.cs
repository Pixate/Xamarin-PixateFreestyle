// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Example
{
	[Register ("PixateViewController")]
	partial class PixateViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonSearch { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelError { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField textPostalCode { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonSearch != null) {
				buttonSearch.Dispose ();
				buttonSearch = null;
			}

			if (textPostalCode != null) {
				textPostalCode.Dispose ();
				textPostalCode = null;
			}

			if (labelError != null) {
				labelError.Dispose ();
				labelError = null;
			}
		}
	}
}
