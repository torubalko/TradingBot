using System;
using System.Windows.Media;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

internal class GrayscaleColorRamp : ColorRampBase
{
	private int p7v;

	private double u7X;

	private bool q7T;

	private int E7B;

	private double H7p;

	private double I7b;

	private double W7y;

	internal static GrayscaleColorRamp xtI;

	public GrayscaleColorRamp(ColorFamilyName familyName, bool isDarkTheme, int grayMin, int silverMax, double graySilverRatio, double tintHue, double saturation)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(familyName, isDarkTheme);
		if (grayMin > silverMax)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102100));
		}
		q7T = familyName == ColorFamilyName.Silver;
		p7v = grayMin;
		E7B = silverMax;
		u7X = Math.Max(0.25, Math.Min(0.75, graySilverRatio));
		UIColor uIColor = UIColor.FromHsb(tintHue, 1.0, 1.0);
		W7y = (double)(int)uIColor.R / 255.0 * saturation;
		I7b = (double)(int)uIColor.G / 255.0 * saturation;
		H7p = (double)(int)uIColor.B / 255.0 * saturation;
		AddDefaultShades();
	}

	private IColorRampShade k7j(int P_0)
	{
		int num = E7B - p7v + 1;
		int num2 = num / 19;
		double num3 = (double)num * (1.0 - u7X);
		double num4 = (q7T ? ((double)p7v + num3 + (double)(num2 / 2)) : ((double)p7v));
		double num5 = (q7T ? ((double)E7B) : ((double)p7v + num3 - (double)(num2 / 2)));
		double num6 = 1.0 - (double)(P_0 - 100) / 800.0;
		double num7 = num6;
		if (q7T)
		{
			double num8 = Easings.SineOut(num6);
			num7 = num6 + (num8 - num6) * 0.75;
		}
		double num9 = (num5 - num4) * num7;
		double num10 = (q7T ? Math.Max(0.0, num4 + num9) : Math.Min(255.0, num4 + num9));
		double num11 = 255.0 - num10;
		double num12 = (q7T ? (1.0 + num6) : Easings.SineOut(0.1 + 0.9 * num6));
		UIColor color = UIColor.FromRgb((byte)(num10 + num11 * W7y * num12), (byte)(num10 + num11 * I7b * num12), (byte)(num10 + num11 * H7p * num12));
		if (P_0 % 100 == 0)
		{
			return new ColorRampShade(this, color, (ShadeName)P_0, base.IsDarkTheme);
		}
		return new ColorRampShade(this, color, P_0);
	}

	protected override IColorRampShade GetShadeCore(int shadeNumber)
	{
		shadeNumber = ColorRampShade.CoerceShadeNumber(shadeNumber);
		if (q7T)
		{
			if (shadeNumber < 100)
			{
				if (shadeNumber == 0)
				{
					return new ColorRampShade(this, UIColor.FromColor(Colors.White), ShadeName.White, base.IsDarkTheme);
				}
				UIColor color = UIColor.FromMix(Colors.White, GetShade(100).Color, (double)shadeNumber / 100.0);
				return new ColorRampShade(this, color, shadeNumber);
			}
		}
		else if (shadeNumber > 900)
		{
			if (shadeNumber == 1000)
			{
				return new ColorRampShade(this, UIColor.FromColor(Colors.Black), ShadeName.Black, base.IsDarkTheme);
			}
			UIColor color2 = UIColor.FromMix(Colors.Black, GetShade(900).Color, (double)(1000 - shadeNumber) / 100.0);
			return new ColorRampShade(this, color2, shadeNumber);
		}
		return k7j(shadeNumber);
	}

	internal static bool atD()
	{
		return xtI == null;
	}

	internal static GrayscaleColorRamp Et2()
	{
		return xtI;
	}
}
