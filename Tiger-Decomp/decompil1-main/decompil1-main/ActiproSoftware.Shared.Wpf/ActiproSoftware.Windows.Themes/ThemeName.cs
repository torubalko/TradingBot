using System;
using System.ComponentModel;

namespace ActiproSoftware.Windows.Themes;

[Obsolete("The 'ThemeName' enumeration will be removed in a future build.  Use the new static 'ThemeNames' class instead.  Several old theme names in 'ThemeName' have been mapped to new names in 'ThemeNames'.  Please read the Themes conversion documentation for details.")]
[Browsable(false)]
[EditorBrowsable(EditorBrowsableState.Never)]
public enum ThemeName
{
	Generic,
	Classic,
	HighContrast,
	AeroNormalColor,
	MetroDark,
	MetroLight,
	MetroLightBlue,
	MetroLightCyan,
	MetroLightGreen,
	MetroLightOrange,
	MetroLightPurple,
	MetroLightRed,
	MetroLightRoyal,
	MetroWhite,
	MetroWhiteBlue,
	MetroWhiteCyan,
	MetroWhiteGreen,
	MetroWhiteOrange,
	MetroWhitePurple,
	MetroWhiteRed,
	MetroWhiteRoyal,
	OfficeBlue,
	OfficeBlack,
	OfficeSilver,
	Custom
}
