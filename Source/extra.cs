/*
 *	Copyright (c) 2012-2013, Pixate, Inc
 *	All rights reserved.
 *
 *	This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

// August 28, 2013 - Paul Colton - Added support for Pixate 1.1 beta 4

using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using System;
using MonoTouch.UIKit;

using System.Linq;
using System.Collections.Generic;

namespace PixateLib
{
	public partial class PXEngine
	{
		//
		// styleId
		//
		public static string GetStyleId (NSObject obj)
		{
			return (NSString) obj.ValueForKey (new NSString ("styleId"));
		}
		public static void SetStyleId (NSObject obj, string id)
		{
			obj.SetValueForKeyPath (new NSString (id), new NSString ("styleId"));
		}

		//
		// styleClass
		//
		public static string GetStyleClass (NSObject obj)
		{
			return (NSString) obj.ValueForKey (new NSString ("styleClass"));
		}
		public static void SetStyleClass (NSObject obj, string id)
		{
			obj.SetValueForKeyPath (new NSString (id), new NSString ("styleClass"));
		}

		//
		// styleCSS
		//
		public static string GetStyleCSS (NSObject obj)
		{
			return (NSString) obj.ValueForKey (new NSString ("styleCSS"));
		}
		public static void SetStyleCSS (NSObject obj, string id)
		{
			obj.SetValueForKeyPath (new NSString (id), new NSString ("styleCSS"));
		}

		//
		// styleMode
		//
		public static PXStylingMode GetStyleMode (NSObject obj)
		{
			var mode = obj.ValueForKey (new NSString ("styleMode"));
			var modeString = mode.ToString ();
			return (PXStylingMode)Enum.Parse (typeof(PXStylingMode), modeString);
		}
		public static void SetStyleMode (NSObject obj, PXStylingMode mode)
		{
			var modeNum = new NSNumber ((int)mode);
			obj.SetValueForKeyPath (modeNum, new NSString ("styleMode"));
		}
	}

	public static class PXUIViewExtensions
	{
		//
		// StyleClass
		//
		public static string GetStyleClass (this UIView view)
		{
			return PixateLib.PXEngine.GetStyleClass (view);
		}
		public static void SetStyleClass (this UIView view, string styleClass)
		{
			PixateLib.PXEngine.SetStyleClass (view, styleClass);
		}

		//
		// StyleCSS
		//
		public static string GetStyleCSS (this UIView view)
		{
			return PixateLib.PXEngine.GetStyleCSS(view);
		}
		public static void SetStyleCSS (this UIView view, string styleCss)
		{
			PixateLib.PXEngine.SetStyleCSS (view, styleCss);
		}

		//
		// StyleId
		//
		public static string GetStyleId (this UIView view)
		{
			return PixateLib.PXEngine.GetStyleId (view);
		}
		public static void SetStyleId (this UIView view, string styleId)
		{
			PixateLib.PXEngine.SetStyleId (view, styleId);
		}

		//
		// StyleMode
		//
		public static PXStylingMode GetStyleMode (this UIView view)
		{
			return PixateLib.PXEngine.GetStyleMode (view);
		}
		public static void SetStyleMode (this UIView view, PXStylingMode mode)
		{
			PixateLib.PXEngine.SetStyleMode (view, mode);
		}

		//
		// Update Styles Methods
		//
		public static void UpdateStyles (this UIView view)
		{
			PixateLib.PXEngine.UpdateStyles (view);
		}

		public static void UpdateStylesNonRecursively (this UIView view)
		{
			PixateLib.PXEngine.UpdateStylesNonRecursively (view);
		}

		public static void UpdateStylesAsync (this UIView view)
		{
			PixateLib.PXEngine.UpdateStylesAsync (view);
		}

		public static void UpdateStylesNonRecursivelyAsync (this UIView view)
		{
			PixateLib.PXEngine.UpdateStylesNonRecursivelyAsync (view);
		}

		//
		// Add / Remove Classes to a UIView
		//
		public static void AddStyleClass(this UIView view, string styleClass)
		{
			// Store result of kvp to check if a value exists
			object classesObject = view.GetStyleClass ();

			// Get current classes from this view
			string classes = classesObject != null ? classesObject.ToString() : string.Empty;

			// Append our requested class/es
			List<String> splits = classes.Split ().ToList ();
			splits.Add(styleClass);

			// Remove duplicate classes and re-stringify
			classes = string.Join(" ", splits.Distinct().ToArray());

			// Refresh view
			view.SetStyleClass (classes);
			view.UpdateStyles();
		}

		public static void RemoveStyleClass(this UIView view, string styleClass)
		{
			// Store result of kvp to check if a value exists
			object classesObject = view.GetStyleClass ();

			// Get current classes from this view
			string classes = classesObject != null ? classesObject.ToString() : string.Empty;

			// Remove our requested class
			List<String> splits = classes.Split ().ToList ();
			splits.Remove(styleClass);

			// Re-stringify
			classes = string.Join(" ", splits.ToArray());

			// Refresh view
			view.SetStyleClass (classes);
			view.UpdateStyles();
		}
	}

	public static class PXUIBarButtonItemExtensions
	{
		//
		// StyleClass
		//
		public static string GetStyleClass (this UIBarButtonItem view)
		{
			return PixateLib.PXEngine.GetStyleClass (view);
		}
		public static void SetStyleClass (this UIBarButtonItem view, string styleClass)
		{
			PixateLib.PXEngine.SetStyleClass (view, styleClass);
		}

		//
		// StyleCSS
		//
		public static string GetStyleCSS (this UIBarButtonItem view)
		{
			return PixateLib.PXEngine.GetStyleCSS(view);
		}
		public static void SetStyleCSS (this UIBarButtonItem view, string styleCss)
		{
			PixateLib.PXEngine.SetStyleCSS (view, styleCss);
		}

		//
		// StyleId
		//
		public static string GetStyleId (this UIBarButtonItem view)
		{
			return PixateLib.PXEngine.GetStyleId (view);
		}
		public static void SetStyleId (this UIBarButtonItem view, string styleId)
		{
			PixateLib.PXEngine.SetStyleId (view, styleId);
		}

		//
		// StyleMode
		//
		public static PXStylingMode GetStyleMode (this UIBarButtonItem view)
		{
			return PixateLib.PXEngine.GetStyleMode (view);
		}
		public static void SetStyleMode (this UIBarButtonItem view, PXStylingMode mode)
		{
			PixateLib.PXEngine.SetStyleMode (view, mode);
		}

		//
		// Update Styles Methods
		//
		public static void UpdateStyles (this UIBarButtonItem view)
		{
			PixateLib.PXEngine.UpdateStyles (view);
		}

		public static void UpdateStylesNonRecursively (this UIBarButtonItem view)
		{
			PixateLib.PXEngine.UpdateStylesNonRecursively (view);
		}

		public static void UpdateStylesAsync (this UIBarButtonItem view)
		{
			PixateLib.PXEngine.UpdateStylesAsync (view);
		}

		public static void UpdateStylesNonRecursivelyAsync (this UIBarButtonItem view)
		{
			PixateLib.PXEngine.UpdateStylesNonRecursivelyAsync (view);
		}

	}

	public static class PXUITabBarItemExtensions
	{
		//
		// StyleClass
		//
		public static string GetStyleClass (this UITabBarItem view)
		{
			return PixateLib.PXEngine.GetStyleClass (view);
		}
		public static void SetStyleClass (this UITabBarItem view, string styleClass)
		{
			PixateLib.PXEngine.SetStyleClass (view, styleClass);
		}

		//
		// StyleCSS
		//
		public static string GetStyleCSS (this UITabBarItem view)
		{
			return PixateLib.PXEngine.GetStyleCSS(view);
		}
		public static void SetStyleCSS (this UITabBarItem view, string styleCss)
		{
			PixateLib.PXEngine.SetStyleCSS (view, styleCss);
		}

		//
		// StyleId
		//
		public static string GetStyleId (this UITabBarItem view)
		{
			return PixateLib.PXEngine.GetStyleId (view);
		}
		public static void SetStyleId (this UITabBarItem view, string styleId)
		{
			PixateLib.PXEngine.SetStyleId (view, styleId);
		}

		//
		// StyleMode
		//
		public static PXStylingMode GetStyleMode (this UITabBarItem view)
		{
			return PixateLib.PXEngine.GetStyleMode (view);
		}
		public static void SetStyleMode (this UITabBarItem view, PXStylingMode mode)
		{
			PixateLib.PXEngine.SetStyleMode (view, mode);
		}

		//
		// Update Styles Methods
		//

		public static void UpdateStyles (this UITabBarItem view)
		{
			PixateLib.PXEngine.UpdateStyles(view);
		}

		public static void UpdateStylesNonRecursively (this UITabBarItem view)
		{
			PixateLib.PXEngine.UpdateStylesNonRecursively(view);
		}

		public static void UpdateStylesAsync (this UITabBarItem view)
		{
			PixateLib.PXEngine.UpdateStylesAsync (view);
		}

		public static void UpdateStylesNonRecursivelyAsync (this UITabBarItem view)
		{
			PixateLib.PXEngine.UpdateStylesNonRecursivelyAsync (view);
		}


	}
}
