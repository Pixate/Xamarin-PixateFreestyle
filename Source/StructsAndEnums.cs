using System;

namespace PixateLib
{
	public enum PXStylesheetOrigin
	{
		PXStylesheetOriginApplication,
	    PXStylesheetOriginUser,
	    PXStylesheetOriginView
	}

	public enum PXParseErrorDestination
	{
		PXParseErrorDestinationNone,
		PXParseErrorDestinationConsole,
	}

	public enum PXUpdateStylesType
	{
		PXUpdateStylesTypeAuto,
		PXUpdateStylesTypeManual,
	}

	public enum PXCacheStylesType
	{
		PXCacheStylesTypeAuto,
		PXCacheStylesTypeNone,
	}
}
