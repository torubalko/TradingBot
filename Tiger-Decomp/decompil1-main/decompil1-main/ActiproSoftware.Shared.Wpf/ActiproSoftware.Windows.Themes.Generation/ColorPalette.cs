using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

public class ColorPalette
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public ColorFamilyName HWA;

		private static _003C_003Ec__DisplayClass18_0 J8l;

		public _003C_003Ec__DisplayClass18_0()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal bool UWl(IColorRamp r)
		{
			return r.FamilyName == HWA;
		}

		internal static bool o8E()
		{
			return J8l == null;
		}

		internal static _003C_003Ec__DisplayClass18_0 n8x()
		{
			return J8l;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IColorRamp feY;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IColorRamp qeI;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IColorRamp Jex;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IColorRamp Ber;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IColorRamp beZ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IColorRamp Ven;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IColorRamp Mea;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IColorRamp Deq;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IColorRamp meW;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IColorRamp zeU;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IColorRamp ueH;

	private static ColorPalette At1;

	public IEnumerable<IColorRamp> All
	{
		get
		{
			yield return Gray;
			yield return Silver;
			yield return Red;
			yield return Orange;
			yield return Yellow;
			yield return Green;
			yield return Teal;
			yield return Blue;
			yield return Indigo;
			yield return Purple;
			yield return Pink;
		}
	}

	public IColorRamp Blue
	{
		[CompilerGenerated]
		get
		{
			return feY;
		}
		[CompilerGenerated]
		private set
		{
			feY = value;
		}
	}

	public IColorRamp Gray
	{
		[CompilerGenerated]
		get
		{
			return qeI;
		}
		[CompilerGenerated]
		private set
		{
			qeI = value;
		}
	}

	public IColorRamp Green
	{
		[CompilerGenerated]
		get
		{
			return Jex;
		}
		[CompilerGenerated]
		private set
		{
			Jex = value;
		}
	}

	public IColorRamp Indigo
	{
		[CompilerGenerated]
		get
		{
			return Ber;
		}
		[CompilerGenerated]
		private set
		{
			Ber = value;
		}
	}

	public IColorRamp Orange
	{
		[CompilerGenerated]
		get
		{
			return beZ;
		}
		[CompilerGenerated]
		private set
		{
			beZ = value;
		}
	}

	public IColorRamp Pink
	{
		[CompilerGenerated]
		get
		{
			return Ven;
		}
		[CompilerGenerated]
		private set
		{
			Ven = value;
		}
	}

	public IColorRamp Purple
	{
		[CompilerGenerated]
		get
		{
			return Mea;
		}
		[CompilerGenerated]
		private set
		{
			Mea = value;
		}
	}

	public IColorRamp Red
	{
		[CompilerGenerated]
		get
		{
			return Deq;
		}
		[CompilerGenerated]
		private set
		{
			Deq = value;
		}
	}

	public IColorRamp Silver
	{
		[CompilerGenerated]
		get
		{
			return meW;
		}
		[CompilerGenerated]
		private set
		{
			meW = value;
		}
	}

	public IColorRamp Teal
	{
		[CompilerGenerated]
		get
		{
			return zeU;
		}
		[CompilerGenerated]
		private set
		{
			zeU = value;
		}
	}

	public IColorRamp Yellow
	{
		[CompilerGenerated]
		get
		{
			return ueH;
		}
		[CompilerGenerated]
		private set
		{
			ueH = value;
		}
	}

	public ColorPalette(ThemeDefinition definition)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (definition != null)
		{
			bool isDarkTheme = definition.IsDarkTheme;
			Gray = new GrayscaleColorRamp(ColorFamilyName.Gray, isDarkTheme, definition.GrayMin, definition.SilverMax, definition.GraySilverRatio, definition.BaseGrayscaleHue, (double)definition.BaseGrayscaleSaturation / 100.0);
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			}
			Silver = new GrayscaleColorRamp(ColorFamilyName.Silver, isDarkTheme, definition.GrayMin, definition.SilverMax, definition.GraySilverRatio, definition.BaseGrayscaleHue, (double)definition.BaseGrayscaleSaturation / 100.0);
			Red = new ColorFamilyColorRamp(ColorFamilyName.Red, isDarkTheme, definition.BaseColorRed);
			Orange = new ColorFamilyColorRamp(ColorFamilyName.Orange, isDarkTheme, definition.BaseColorOrange);
			Yellow = new ColorFamilyColorRamp(ColorFamilyName.Yellow, isDarkTheme, definition.BaseColorYellow);
			Green = new ColorFamilyColorRamp(ColorFamilyName.Green, isDarkTheme, definition.BaseColorGreen);
			Teal = new ColorFamilyColorRamp(ColorFamilyName.Teal, isDarkTheme, definition.BaseColorTeal);
			Blue = new ColorFamilyColorRamp(ColorFamilyName.Blue, isDarkTheme, definition.BaseColorBlue);
			Indigo = new ColorFamilyColorRamp(ColorFamilyName.Indigo, isDarkTheme, definition.BaseColorIndigo);
			Purple = new ColorFamilyColorRamp(ColorFamilyName.Purple, isDarkTheme, definition.BaseColorPurple);
			Pink = new ColorFamilyColorRamp(ColorFamilyName.Pink, isDarkTheme, definition.BaseColorPink);
			return;
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96496));
	}

	private static Color teu(Color P_0, double P_1)
	{
		P_1 = Math.Max(0.0, Math.Min(1.0, P_1));
		byte r = (byte)Math.Round((double)(int)P_0.R * (1.0 - P_1), MidpointRounding.AwayFromZero);
		byte g = (byte)Math.Round((double)(int)P_0.G * (1.0 - P_1), MidpointRounding.AwayFromZero);
		byte b = (byte)Math.Round((double)(int)P_0.B * (1.0 - P_1), MidpointRounding.AwayFromZero);
		return Color.FromArgb(P_0.A, r, g, b);
	}

	internal static UIColor Shade(UIColor color, double percentage, double otherAdjustPercentage)
	{
		double num = color.HsbHue;
		double num2 = Math.Min(Math.Abs(num - 0.0), Math.Abs(num - 360.0));
		double num3 = Math.Abs(num - 120.0);
		double num4 = Math.Abs(num - 240.0);
		int num5;
		if (!(num4 <= Math.Min(num2, num3)))
		{
			if (!(num2 <= num3))
			{
				num3 = num - 120.0;
				color.HsbHue = num - otherAdjustPercentage * num3;
				goto IL_0284;
			}
			num5 = 2;
		}
		else
		{
			num5 = 1;
			if (ot8() != null)
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_01a3:
		num2 = ((num > 180.0) ? (num - 360.0) : (num - 0.0));
		color.HsbHue = num - otherAdjustPercentage * num2;
		goto IL_0284;
		IL_0284:
		color.HsbSaturation *= 1.0 + otherAdjustPercentage;
		color = UIColor.FromColor(teu(color.ToColor(), percentage));
		num = color.HsbHue;
		double num6 = Math.Abs(num - 60.0);
		double num7 = default(double);
		if (num6 < 40.0)
		{
			num7 = (40.0 - num6) / 40.0;
			num5 = 0;
			if (ot8() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_021a;
		IL_021a:
		return color;
		IL_00cd:
		num4 = num - 240.0;
		color.HsbHue = num - otherAdjustPercentage * num4;
		goto IL_0284;
		IL_0005:
		int num8 = default(int);
		num5 = num8;
		goto IL_0009;
		IL_0009:
		switch (num5)
		{
		case 1:
			goto IL_00cd;
		case 2:
			goto IL_01a3;
		}
		double num9 = 1.0 + 0.08 * num7 * (1.0 - percentage);
		if (percentage > 0.2)
		{
			num -= num7 * 15.0;
		}
		color = UIColor.FromHsb(num, color.HsbSaturation * num9, color.HsbBrightness * num9);
		goto IL_021a;
	}

	private static Color Ge2(Color P_0, double P_1)
	{
		P_1 = Math.Max(0.0, Math.Min(1.0, P_1));
		byte r = (byte)Math.Round((double)(int)P_0.R + (double)(255 - P_0.R) * P_1, MidpointRounding.AwayFromZero);
		byte g = (byte)Math.Round((double)(int)P_0.G + (double)(255 - P_0.G) * P_1, MidpointRounding.AwayFromZero);
		byte b = (byte)Math.Round((double)(int)P_0.B + (double)(255 - P_0.B) * P_1, MidpointRounding.AwayFromZero);
		return Color.FromArgb(P_0.A, r, g, b);
	}

	internal static UIColor Tint(UIColor color, double percentage)
	{
		double hsbHue = color.HsbHue;
		color = UIColor.FromColor(Ge2(color.ToColor(), percentage));
		hsbHue = color.HsbHue;
		double num = Math.Abs(hsbHue - 60.0);
		if (num < 20.0)
		{
			double num2 = (20.0 - num) / 20.0;
			double num3 = 1.0 - 0.23 * num2;
			color = UIColor.FromHsb(hsbHue, color.HsbSaturation * num3, color.HsbBrightness);
		}
		if (percentage > 0.5 && percentage < 0.7)
		{
			double num4 = Math.Abs(hsbHue - 240.0);
			if (num4 < 70.0)
			{
				double num5 = (70.0 - num4) / 70.0;
				double num6 = 1.0 + 0.15 * num5;
				double num7 = 1.0 + 0.05 * num5;
				color = UIColor.FromHsb(hsbHue, color.HsbSaturation * num6, color.HsbBrightness * num7);
			}
		}
		return color;
	}

	public static Color GetBaseColorForBrandColor(Color brandColor)
	{
		UIColor uIColor = UIColor.FromColor(brandColor);
		double hsbHue = uIColor.HsbHue;
		double num = hsbHue - 4.0;
		double num2 = hsbHue + 4.0;
		Color result = Colors.Transparent;
		double num3 = double.MaxValue;
		byte b = (byte)Math.Min(255.0, (double)(int)uIColor.R + 8.0);
		byte b2 = (byte)Math.Min(255.0, (double)(int)uIColor.R + 64.0);
		byte b3 = (byte)Math.Min(255.0, (double)(int)uIColor.G + 8.0);
		byte b4 = (byte)Math.Min(255.0, (double)(int)uIColor.G + 64.0);
		byte b5 = (byte)Math.Min(255.0, (double)(int)uIColor.B + 8.0);
		byte b6 = (byte)Math.Min(255.0, (double)(int)uIColor.B + 64.0);
		double hsbHue2 = default(double);
		int num6 = default(int);
		for (byte b7 = b; b7 <= b2; b7++)
		{
			while (true)
			{
				IL_0254:
				for (byte b8 = b3; b8 <= b4; b8++)
				{
					for (byte b9 = b5; b9 <= b6; b9++)
					{
						UIColor color = UIColor.FromRgb(b7, b8, b9);
						int num4 = 1;
						if (ot8() != null)
						{
							goto IL_0005;
						}
						goto IL_0009;
						IL_0009:
						while (true)
						{
							switch (num4)
							{
							case 4:
								break;
							default:
								goto IL_01be;
							case 2:
								goto end_IL_0009;
							case 1:
								goto IL_02dd;
							case 3:
								goto end_IL_027f;
							}
							UIColor uIColor2 = Shade(color, 0.13, 0.1);
							double num5 = Math.Sqrt(Math.Pow(uIColor2.R - uIColor.R, 2.0) + Math.Pow(uIColor2.G - uIColor.G, 2.0) + Math.Pow(uIColor2.B - uIColor.B, 2.0));
							if (num5 < num3)
							{
								result = color.ToColor();
								num3 = num5;
							}
							goto IL_0260;
							IL_02dd:
							hsbHue2 = color.HsbHue;
							num4 = 0;
							if (rtg())
							{
								continue;
							}
							goto IL_0005;
							IL_01be:
							if (hsbHue2 >= num && hsbHue2 <= num2)
							{
								num4 = 4;
								if (rtg())
								{
									continue;
								}
								goto IL_0005;
							}
							goto IL_0260;
							IL_0260:
							if (b9 == byte.MaxValue)
							{
								num4 = 3;
								continue;
							}
							goto IL_008e;
							continue;
							end_IL_0009:
							break;
						}
						goto IL_0254;
						IL_0005:
						num4 = num6;
						goto IL_0009;
						continue;
						end_IL_027f:
						break;
						IL_008e:;
					}
					if (b8 == byte.MaxValue)
					{
						break;
					}
				}
				break;
			}
			if (b7 == byte.MaxValue)
			{
				break;
			}
		}
		return result;
	}

	public IColorRamp GetColorRamp(ColorFamilyName familyName)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals2.HWA = familyName;
		return All.FirstOrDefault((IColorRamp r) => r.FamilyName == CS_0024_003C_003E8__locals2.HWA);
	}

	internal static bool rtg()
	{
		return At1 == null;
	}

	internal static ColorPalette ot8()
	{
		return At1;
	}
}
