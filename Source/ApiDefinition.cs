using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PixateLib {

	[BaseType (typeof (NSObject))]
	interface PXEngine {
		
		[Static, Export ("version")]
		string Version { get; }

		[Static, Export ("buildDate")]
		NSDate BuildDate { get; }

		[Static, Export ("licenseEmail")]
		string LicenseEmail { get; }

		[Static, Export ("licenseKey")]
		string LicenseKey { get; }

		[Static, Export ("refreshStylesWithOrientationChange")]
		bool RefreshStylesWithOrientationChange { get; set; }

		[Static, Export ("configuration")]
		PXEngineConfiguration Configuration { get; }

		[Static, Export ("licenseKey:forUser:")]
		void LicenseKeyForUser(string key, string user);

		[Static, Export ("selectFromStyleable:usingSelector:")]
		NSObject[] SelectFromStyleableUsingSelector(NSObject styleable, string Selector);

		[Static, Export ("matchingRuleSetsForStyleable:")]
		string MatchingRuleSetsForStyleable(NSObject styleable);

		[Static, Export ("matchingDeclarationsForStyleable:")]
		string MatchingDeclarationsForStyleable(NSObject styleable);

		[Static, Export ("styleSheetFromFilePath:withOrigin:")]
		PXStylesheet StyleSheetFromFilePathWithOrigin(string path, PXStylesheetOrigin origin);
		
		[Static, Export ("styleSheetFromSource:withOrigin:")]
		PXStylesheet StyleSheetFromSourceWithOrigin(string source, PXStylesheetOrigin origin);
		
		[Static, Export ("currentApplicationStylesheet")]
		PXStylesheet CurrentApplicationStylesheet();
		
		[Static, Export ("currentUserStylesheet")]
		PXStylesheet CurrentUserStylesheet();
		
		[Static, Export ("currentViewStylesheet")]
		PXStylesheet CurrentViewStylesheet();
		
		[Static, Export ("applyStylesheets")]
		void ApplyStylesheets();

		[Static, Export ("updateStyles:")]
		void UpdateStyles(NSObject styleable);

		[Static, Export ("updateStylesnonRecursively:")]
		void UpdateStylesNonRecursively(NSObject styleable);
	}

	[BaseType (typeof (NSObject))]
	interface PXStylesheet {

		[Export ("errors")]
		string[] Errors { get; }

		[Export ("filePath")]
		string FilePath { get; set; }

		[Export ("monitorChanges")]
		bool MonitorChanges { get; set; }
	}

	[BaseType (typeof (NSObject))]
	interface PXEngineConfiguration {
		[Export ("parseErrorDestination")]
		PXParseErrorDestination ParseErrorDestination { get; set; }

		[Export ("updateStylesType")]
		PXUpdateStylesType UpdateStylesType { get; set; }

		[Export ("cacheStylesType")]
		PXCacheStylesType CacheStylesType { get; set; }
	}
}
