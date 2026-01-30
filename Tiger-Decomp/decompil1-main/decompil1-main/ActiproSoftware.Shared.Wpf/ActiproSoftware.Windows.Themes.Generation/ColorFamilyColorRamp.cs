using System;
using System.Windows.Media;
using ActiproSoftware.Windows.Media;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

internal class ColorFamilyColorRamp : ColorRampBase
{
	private UIColor pe4;

	internal const double LightestTintPercentage = 0.87;

	internal const double DarkThemeLighterTintPercentage = 0.64;

	internal const double DarkThemeLightTintPercentage = 0.32;

	internal const double LightThemeLighterTintPercentage = 0.75;

	internal const double LightThemeLightTintPercentage = 0.61;

	internal const double LightThemeLitTintPercentage = 0.4;

	internal const double LightThemeBaseTintPercentage = 0.2;

	internal const double DarkThemeBaseShadePercentage = 0.11;

	internal const double DarkThemeDimShadePercentage = 0.22;

	internal const double DarkThemeDarkShadePercentage = 0.32;

	internal const double DarkThemeDarkerShadePercentage = 0.45;

	internal const double LightThemeDarkShadePercentage = 0.13;

	internal const double LightThemeDarkerShadePercentage = 0.32;

	internal const double DarkestShadePercentage = 0.6;

	internal const double DarkThemeBaseShadeOtherAdjustPercentage = 0.08;

	internal const double DarkThemeDimShadeOtherAdjustPercentage = 0.11;

	internal const double DarkThemeDarkShadeOtherAdjustPercentage = 0.15;

	internal const double DarkThemeDarkerShadeOtherAdjustPercentage = 0.17;

	internal const double LightThemeDarkShadeOtherAdjustPercentage = 0.1;

	internal const double LightThemeDarkerShadeOtherAdjustPercentage = 0.15;

	internal const double DarkestShadeOtherAdjustPercentage = 0.2;

	internal static ColorFamilyColorRamp GtO;

	public ColorFamilyColorRamp(ColorFamilyName familyName, bool isDarkTheme, Color baseColor)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(familyName, isDarkTheme);
		pe4 = UIColor.FromColor(baseColor);
		AddDefaultShades();
	}

	private IColorRampShade Uew(int P_0)
	{
		if (base.IsDarkTheme)
		{
			return P_0 switch
			{
				0 => new ColorRampShade(this, UIColor.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), ShadeName.White, base.IsDarkTheme), 
				100 => new ColorRampShade(this, ColorPalette.Tint(pe4, 0.87), ShadeName.Lightest, base.IsDarkTheme), 
				200 => new ColorRampShade(this, ColorPalette.Tint(pe4, 0.64), ShadeName.Lighter, base.IsDarkTheme), 
				300 => new ColorRampShade(this, ColorPalette.Tint(pe4, 0.32), ShadeName.Light, base.IsDarkTheme), 
				400 => new ColorRampShade(this, pe4, ShadeName.Lit, base.IsDarkTheme), 
				500 => new ColorRampShade(this, ColorPalette.Shade(pe4, 0.11, 0.08), ShadeName.Base, base.IsDarkTheme), 
				600 => new ColorRampShade(this, ColorPalette.Shade(pe4, 0.22, 0.11), ShadeName.Dim, base.IsDarkTheme), 
				700 => new ColorRampShade(this, ColorPalette.Shade(pe4, 0.32, 0.15), ShadeName.Dark, base.IsDarkTheme), 
				800 => new ColorRampShade(this, ColorPalette.Shade(pe4, 0.45, 0.17), ShadeName.Darker, base.IsDarkTheme), 
				900 => new ColorRampShade(this, ColorPalette.Shade(pe4, 0.6, 0.2), ShadeName.Darkest, base.IsDarkTheme), 
				1000 => new ColorRampShade(this, UIColor.FromArgb(byte.MaxValue, 0, 0, 0), ShadeName.Black, base.IsDarkTheme), 
				_ => null, 
			};
		}
		return P_0 switch
		{
			0 => new ColorRampShade(this, UIColor.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), ShadeName.White, base.IsDarkTheme), 
			100 => new ColorRampShade(this, ColorPalette.Tint(pe4, 0.87), ShadeName.Lightest, base.IsDarkTheme), 
			200 => new ColorRampShade(this, ColorPalette.Tint(pe4, 0.75), ShadeName.Lighter, base.IsDarkTheme), 
			300 => new ColorRampShade(this, ColorPalette.Tint(pe4, 0.61), ShadeName.Light, base.IsDarkTheme), 
			400 => new ColorRampShade(this, ColorPalette.Tint(pe4, 0.4), ShadeName.Lit, base.IsDarkTheme), 
			500 => new ColorRampShade(this, ColorPalette.Tint(pe4, 0.2), ShadeName.Base, base.IsDarkTheme), 
			600 => new ColorRampShade(this, pe4, ShadeName.Dim, base.IsDarkTheme), 
			700 => new ColorRampShade(this, ColorPalette.Shade(pe4, 0.13, 0.1), ShadeName.Dark, base.IsDarkTheme), 
			800 => new ColorRampShade(this, ColorPalette.Shade(pe4, 0.32, 0.15), ShadeName.Darker, base.IsDarkTheme), 
			900 => new ColorRampShade(this, ColorPalette.Shade(pe4, 0.6, 0.2), ShadeName.Darkest, base.IsDarkTheme), 
			1000 => new ColorRampShade(this, UIColor.FromArgb(byte.MaxValue, 0, 0, 0), ShadeName.Black, base.IsDarkTheme), 
			_ => null, 
		};
	}

	protected override IColorRampShade GetShadeCore(int shadeNumber)
	{
		shadeNumber = ColorRampShade.CoerceShadeNumber(shadeNumber);
		IColorRampShade colorRampShade = Uew(shadeNumber);
		if (colorRampShade == null)
		{
			int num = (int)Math.Floor((double)shadeNumber / 100.0) * 100;
			int num2 = (int)Math.Ceiling((double)shadeNumber / 100.0) * 100;
			Color color = Uew(num).Color;
			Color color2 = Uew(num2).Color;
			int num3 = 0;
			if (etG() != null)
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			}
			double percentage = (double)(shadeNumber - num) / 100.0;
			colorRampShade = new ColorRampShade(this, UIColor.FromMix(color, color2, percentage), shadeNumber);
		}
		return colorRampShade;
	}

	internal static bool Xtq()
	{
		return GtO == null;
	}

	internal static ColorFamilyColorRamp etG()
	{
		return GtO;
	}
}
