using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using System;
using MonoTouch.UIKit;

namespace PixateLib
{
	public partial class PXEngine
	{
		public static void SetStyleId (NSObject obj, string id)
		{
			obj.SetValueForKeyPath (new NSString (id), new NSString ("styleId"));
		}

		public static void SetStyleClass (NSObject obj, string id)
		{
			obj.SetValueForKeyPath (new NSString (id), new NSString ("styleClass"));
		}

		public static void SetStyleCSS (NSObject obj, string id)
		{
			obj.SetValueForKeyPath (new NSString (id), new NSString ("styleCSS"));
		}
	}

	public static class PXEngineExtensions
	{
		public static void SetStyleClass (this UIView view, string styleClass)
		{
			PixateLib.PXEngine.SetStyleClass (view, styleClass);
		}

		public static void SetStyleCSS (this UIView view, string styleCss)
		{
			PixateLib.PXEngine.SetStyleCSS (view, styleCss);
		}

		public static void SetStyleId (this UIView view, string styleId)
		{
			PixateLib.PXEngine.SetStyleId (view, styleId);
		}

		public static void UpdateStyles (this UIView view)
		{
			PixateLib.PXEngine.UpdateStyles (view);
		}

		public static void UpdateStylesNonRecursively (this UIView view)
		{
			PixateLib.PXEngine.UpdateStylesNonRecursively (view);
		}
	}

	public static class UIBarButtonItemExtensions
	{
		public static void SetStyleClass (this UIBarButtonItem view, string styleClass)
		{
			PixateLib.PXEngine.SetStyleClass (view, styleClass);
		}
		
		public static void SetStyleCSS (this UIBarButtonItem view, string styleCss)
		{
			PixateLib.PXEngine.SetStyleCSS (view, styleCss);
		}
		
		public static void SetStyleId (this UIBarButtonItem view, string styleId)
		{
			PixateLib.PXEngine.SetStyleId (view, styleId);
		}
		
		public static void UpdateStyles (this UIBarButtonItem view)
		{
			PixateLib.PXEngine.UpdateStyles (view);
		}
		
		public static void UpdateStylesNonRecursively (this UIBarButtonItem view)
		{
			PixateLib.PXEngine.UpdateStylesNonRecursively (view);
		}
	}

	public static class UITabBarItemExtensions
	{
		public static void SetStyleClass (this UITabBarItem view, string styleClass)
		{
			PixateLib.PXEngine.SetStyleClass (view, styleClass);
		}
		
		public static void SetStyleCSS (this UITabBarItem view, string styleCss)
		{
			PixateLib.PXEngine.SetStyleCSS (view, styleCss);
		}
		
		public static void SetStyleId (this UITabBarItem view, string styleId)
		{
			PixateLib.PXEngine.SetStyleId (view, styleId);
		}
		
		public static void UpdateStyles (this UITabBarItem view)
		{
			PixateLib.PXEngine.UpdateStyles(view);
		}
		
		public static void UpdateStylesNonRecursively (this UITabBarItem view)
		{
			PixateLib.PXEngine.UpdateStylesNonRecursively(view);
		}
	}
}
