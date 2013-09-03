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

		[Static, Export ("updateStylesAsync:")]
		void UpdateStylesAsync(NSObject styleable);

		[Static, Export ("updateStylesNonRecursivelyAsync:")]
		void UpdateStylesNonRecursivelyAsync(NSObject styleable);
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
