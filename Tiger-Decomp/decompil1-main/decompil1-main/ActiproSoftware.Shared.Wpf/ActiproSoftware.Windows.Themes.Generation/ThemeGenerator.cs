#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

internal class ThemeGenerator
{
	private enum md
	{
		MenuItem = 28,
		StatusBar = 38,
		Thumb = 42,
		ToolBar = 43,
		ToolTip = 47
	}

	private enum YK
	{
		Background,
		Border
	}

	[Flags]
	private enum oS
	{
		None = 0
	}

	[Flags]
	private enum DL
	{
		Normal = 0,
		Checked = 2,
		Defaulted = 4,
		Disabled = 8,
		Hover = 0x10,
		Pressed = 0x80
	}

	private class AD
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly IDictionary<Color, Brush> VWR;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ThemeDefinition gWE;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ColorPalette vWs;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ResourceDictionary bWL;

		internal static AD e8h;

		[SpecialName]
		[CompilerGenerated]
		public IDictionary<Color, Brush> WWC()
		{
			return VWR;
		}

		[SpecialName]
		[CompilerGenerated]
		public ThemeDefinition nWI()
		{
			return gWE;
		}

		[SpecialName]
		[CompilerGenerated]
		public void yWx(ThemeDefinition P_0)
		{
			gWE = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public ColorPalette IWZ()
		{
			return vWs;
		}

		[SpecialName]
		[CompilerGenerated]
		public void iWn(ColorPalette P_0)
		{
			vWs = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public ResourceDictionary dWq()
		{
			return bWL;
		}

		[SpecialName]
		[CompilerGenerated]
		public void sWW(ResourceDictionary P_0)
		{
			bWL = P_0;
		}

		[SpecialName]
		public bool rWH()
		{
			if (!nWI().IsDarkTheme)
			{
				return false;
			}
			return nWI().RequireDarkerBorders;
		}

		[SpecialName]
		public bool PWV()
		{
			ThemeIntent intent = nWI().Intent;
			ThemeIntent themeIntent = intent;
			if (themeIntent != ThemeIntent.White && themeIntent != ThemeIntent.Black)
			{
				return false;
			}
			return true;
		}

		public AD()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			VWR = new Dictionary<Color, Brush>();
			base._002Ector();
		}

		internal static bool P8P()
		{
			return e8h == null;
		}

		internal static AD I8W()
		{
			return e8h;
		}
	}

	internal static ThemeGenerator ofk;

	private static Color XFw(AD P_0, IColorRamp P_1, md P_2, YK P_3, DL P_4 = DL.Normal, oS P_5 = oS.None)
	{
		oS oS = P_5 & (oS)(-16);
		int num = (int)(P_5 & (oS)15);
		bool flag = (P_5 & (oS)256) == (oS)256;
		bool flag2 = P_0.rWH() && !flag;
		num += RF7(P_0, P_2, _0020: false, P_3, P_4, flag2);
		if (num < 0)
		{
			num *= -1;
			oS ^= (oS)64;
		}
		if (num > 15)
		{
			throw new InvalidOperationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105806));
		}
		oS = (oS)((int)oS | num);
		IColorRampShade colorRampShade = KFu(P_0, P_1, P_2, P_3, oS);
		return lF2(colorRampShade, P_2, P_3);
	}

	private static Color mF4(AD P_0, IColorRamp P_1, md P_2, oS P_3 = oS.None)
	{
		return KFu(P_0, P_1, P_2, YK.Background, P_3).Color;
	}

	private static IColorRampShade KFu(AD P_0, IColorRamp P_1, md P_2, YK P_3, oS P_4 = oS.None)
	{
		ShadeName shadeName = EFe(P_0, P_2, YK.Background, _0020: false);
		int num = 0;
		if ((P_4 & (oS)16) == (oS)16)
		{
			shadeName = ShadeName.Darkest;
		}
		else if ((P_4 & (oS)15) != oS.None)
		{
			num += (int)(P_4 & (oS)15) * -100;
		}
		if ((P_4 & (oS)32) == (oS)32)
		{
			num -= 50;
		}
		if ((P_4 & (oS)64) == (oS)64)
		{
			num *= -1;
		}
		bool flag = (P_4 & (oS)256) == (oS)256 || !P_0.nWI().IsDarkTheme;
		if ((P_4 & (oS)128) == (oS)128)
		{
			flag = !flag;
		}
		int num2 = (int)(flag ? (shadeName - num) : (1000 - shadeName + num));
		if (num2 > 900 && P_0.rWH())
		{
			double brightness = P_1[ShadeName.Black].Brightness;
			double brightness2 = P_1[ShadeName.Darkest].Brightness;
			double num3 = brightness2 - brightness;
			if (num3 > 0.01)
			{
				double num4 = ((double)num2 - 900.0) / 100.0;
				double brightness3 = P_1[ShadeName.Darker].Brightness;
				double num5 = brightness3 - brightness2;
				int val = (int)(num5 * num4 / num3 * 100.0);
				num2 = 900 + Math.Max(0, Math.Min(100, val));
			}
		}
		num2 = ColorRampShade.CoerceShadeNumber(num2);
		return P_1.GetShade(num2);
	}

	private static Color lF2(IColorRampShade P_0, md P_1, YK P_2)
	{
		int num = 2;
		YK yK = default(YK);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					switch (yK)
					{
					case (YK)4:
					case (YK)9:
						return P_0.GetForegroundColor(0.7);
					case (YK)3:
					case (YK)8:
						return P_0.GetForegroundColor(0.89);
					case (YK)6:
					case (YK)11:
						break;
					case (YK)5:
					case (YK)10:
						return P_0.GetForegroundColor(0.53);
					default:
						return P_0.Color;
					case (YK)2:
					case (YK)7:
						return P_0.GetForegroundColor(1.0);
					}
					if (P_1 == md.MenuItem)
					{
						return P_0.GetForegroundColor(0.35);
					}
					goto default;
				default:
					return P_0.GetForegroundColor(0.45);
				case 2:
					break;
				}
				yK = P_2;
				num2 = 1;
			}
			while (mfF());
		}
	}

	private static ShadeName EFe(AD P_0, md P_1, YK P_2, bool P_3)
	{
		if (P_3)
		{
			switch (P_1)
			{
			case (md)0:
				return ShadeName.Lighter;
			case (md)1:
				return ShadeName.Lighter;
			case (md)3:
				return ShadeName.Lightest;
			case (md)5:
				return ShadeName.Base;
			case (md)6:
				return ShadeName.Lit;
			case (md)7:
				return ShadeName.Lightest;
			case (md)8:
				return ShadeName.Lightest;
			case (md)9:
				return ShadeName.Lighter;
			case (md)10:
				return ShadeName.Light;
			case (md)11:
				return ShadeName.Lit;
			case (md)12:
				return ShadeName.Base;
			case (md)13:
				return ShadeName.Dim;
			case (md)14:
				return ShadeName.Dark;
			case (md)15:
				return ShadeName.Darker;
			case (md)16:
				return ShadeName.Darkest;
			case (md)17:
				return ShadeName.Lighter;
			case (md)19:
				return ShadeName.Lightest;
			case (md)20:
				return ShadeName.Lighter;
			case (md)21:
				return ShadeName.Light;
			case (md)23:
				return ShadeName.Lightest;
			case (md)24:
				return ShadeName.Light;
			case (md)26:
				return ShadeName.Lightest;
			case (md)27:
				return ShadeName.Lightest;
			case md.MenuItem:
				return ShadeName.Lightest;
			case (md)30:
				return ShadeName.Lighter;
			case (md)32:
				return ShadeName.Lightest;
			case (md)33:
				return ShadeName.Lit;
			case (md)34:
				return ShadeName.Lightest;
			case (md)35:
				return P_0.PWV() ? ShadeName.Lightest : ShadeName.Light;
			case (md)36:
				return ShadeName.Lighter;
			case (md)37:
				return ShadeName.Lit;
			case (md)39:
				return ShadeName.Light;
			case (md)40:
				return ShadeName.Lighter;
			case (md)41:
				return ShadeName.Lightest;
			case md.Thumb:
				return ShadeName.Light;
			case md.ToolBar:
				return P_0.PWV() ? ShadeName.Lightest : ShadeName.Light;
			case (md)44:
				return P_0.PWV() ? ShadeName.Lightest : ShadeName.Light;
			case (md)46:
				return ShadeName.Lightest;
			case md.ToolTip:
				return ShadeName.Lighter;
			case (md)48:
				return ShadeName.Lighter;
			case (md)49:
				return P_0.PWV() ? ShadeName.Lightest : ShadeName.Light;
			case (md)51:
				return ShadeName.Light;
			case (md)52:
				return ShadeName.Base;
			case (md)53:
				return ShadeName.Lightest;
			case (md)25:
				return P_0.nWI().ListItemBackgroundStateKindResolved switch
				{
					BackgroundStateKind.LowContrast => ShadeName.Light, 
					BackgroundStateKind.MidContrast => ShadeName.Lit, 
					BackgroundStateKind.HighContrast => ShadeName.Base, 
					_ => ShadeName.Lightest, 
				};
			case (md)29:
			case (md)45:
				switch (P_0.nWI().BarItemBackgroundStateKindResolved)
				{
				case BackgroundStateKind.LowContrast:
					return ShadeName.Base;
				case BackgroundStateKind.MidContrast:
					return ShadeName.Dim;
				case BackgroundStateKind.HighContrast:
					return ShadeName.Dark;
				default:
					if (P_0.PWV() || P_1 == (md)29)
					{
						return ShadeName.Lightest;
					}
					return ShadeName.Light;
				}
			case md.StatusBar:
				if (P_0.nWI().StatusBarBackgroundKind == StatusBarBackgroundKind.Window)
				{
					return P_0.PWV() ? ShadeName.Lightest : ShadeName.Light;
				}
				return P_0.PWV() ? ShadeName.Lighter : ShadeName.Lit;
			default:
				throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105852));
			}
		}
		switch (P_1)
		{
		case (md)0:
			return ShadeName.Lightest;
		case (md)1:
			return P_0.nWI().IsDarkTheme ? ShadeName.Dim : ShadeName.Dark;
		case (md)2:
			return P_0.nWI().IsDarkTheme ? ShadeName.Base : ShadeName.Dark;
		case (md)3:
			return ShadeName.Lightest;
		case (md)4:
			return P_0.nWI().IsDarkTheme ? ShadeName.Base : ShadeName.Dark;
		case (md)6:
			return ShadeName.Lightest;
		case (md)19:
			return ShadeName.Lightest;
		case (md)21:
			return ShadeName.Lighter;
		case (md)18:
			return ShadeName.Light;
		case (md)22:
			return P_0.nWI().IsDarkTheme ? ShadeName.Dim : ShadeName.Dark;
		case (md)23:
			return ShadeName.Light;
		case (md)24:
			return ShadeName.Lightest;
		case (md)25:
			return P_0.nWI().IsDarkTheme ? ShadeName.Base : ShadeName.Lighter;
		case (md)26:
			return ShadeName.Lightest;
		case (md)27:
			return ShadeName.Lighter;
		case (md)29:
			return (P_0.nWI().BarItemBorderContrastKind == BorderContrastKind.Lowest) ? ShadeName.Light : ShadeName.Lighter;
		case (md)30:
			return ShadeName.Lighter;
		case (md)31:
			return ShadeName.Light;
		case (md)33:
			return P_0.nWI().IsDarkTheme ? ShadeName.Dim : ShadeName.Dark;
		case (md)34:
			return ShadeName.Base;
		case (md)35:
			return ShadeName.Light;
		case (md)36:
			return P_0.nWI().IsDarkTheme ? ShadeName.Dim : ShadeName.Dark;
		case (md)37:
			return ShadeName.Light;
		case md.StatusBar:
			return P_0.nWI().IsDarkTheme ? ShadeName.Dim : ShadeName.Dark;
		case (md)40:
			return P_0.nWI().IsDarkTheme ? ShadeName.Dim : ShadeName.Dark;
		case md.ToolTip:
			return ShadeName.Base;
		case (md)48:
			return P_0.nWI().IsDarkTheme ? ShadeName.Dim : ShadeName.Dark;
		case (md)49:
			return P_0.nWI().IsDarkTheme ? ShadeName.Dim : ShadeName.Dark;
		case (md)50:
			return ShadeName.Dim;
		case (md)51:
			return ShadeName.Lightest;
		case (md)52:
			return P_0.nWI().IsDarkTheme ? ShadeName.Lit : ShadeName.Base;
		case (md)45:
			if (P_0.nWI().IsDarkTheme)
			{
				return (P_0.nWI().BarItemBorderContrastKind == BorderContrastKind.Lowest) ? ShadeName.Lit : ShadeName.Light;
			}
			return (P_0.nWI().BarItemBorderContrastKind == BorderContrastKind.Lowest) ? ShadeName.Light : ShadeName.Lighter;
		default:
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105852));
		}
	}

	private static int RF7(AD P_0, md P_1, bool P_2, YK P_3, DL P_4, bool P_5)
	{
		int num = 0;
		if (P_3 == YK.Border)
		{
			if (P_2)
			{
				if (P_5)
				{
					switch (P_1)
					{
					case (md)3:
					case (md)6:
						num = -CFo(3, P_0.nWI().ButtonBorderContrastKind);
						break;
					case (md)8:
					case (md)9:
					case (md)10:
					case (md)11:
					case (md)12:
					case (md)13:
					case (md)14:
					case (md)15:
					case (md)16:
					case (md)20:
						num = -CFo(2, P_0.nWI().ContainerBorderContrastKind);
						break;
					case (md)25:
						num = -CFo(2, P_0.nWI().ListItemBorderContrastKind);
						break;
					case (md)29:
					case (md)45:
						num = -CFo(2, P_0.nWI().BarItemBorderContrastKind);
						break;
					case (md)32:
						num = -CFo(2, P_0.nWI().PopupBorderContrastKind);
						break;
					case md.StatusBar:
					case (md)40:
					case (md)48:
						num = -CFo(2, P_0.nWI().ContainerBorderContrastKind);
						break;
					case (md)49:
						num = -((P_0.nWI().WindowBorderKind == WindowBorderKind.LowContrast) ? 1 : 2);
						break;
					default:
						num = -2;
						break;
					}
				}
				else
				{
					switch (P_1)
					{
					case (md)3:
					case (md)6:
						num = CFo(jFF(P_0, P_1, P_2, ShadeName.Dark), P_0.nWI().ButtonBorderContrastKind);
						break;
					case (md)8:
					case (md)9:
					case (md)10:
					case (md)11:
					case (md)12:
					case (md)13:
					case (md)14:
					case (md)15:
					case (md)16:
					case (md)20:
						num = CFo(2, P_0.nWI().ContainerBorderContrastKind);
						break;
					case (md)25:
						num = CFo(2, P_0.nWI().ListItemBorderContrastKind);
						break;
					case (md)29:
					case (md)45:
						num = CFo(2, P_0.nWI().BarItemBorderContrastKind);
						break;
					case (md)32:
						num = CFo(jFF(P_0, P_1, P_2, ShadeName.Base), P_0.nWI().PopupBorderContrastKind);
						break;
					case md.StatusBar:
					case (md)40:
					case (md)48:
						num = CFo(jFF(P_0, P_1, P_2, ShadeName.Base), P_0.nWI().ContainerBorderContrastKind);
						break;
					case (md)49:
						num = jFF(P_0, P_1, P_2, (P_0.nWI().WindowBorderKind != WindowBorderKind.LowContrast) ? (P_0.PWV() ? ShadeName.Base : ShadeName.Dim) : (P_0.PWV() ? ShadeName.Lit : ShadeName.Base));
						break;
					default:
						num = jFF(P_0, P_1, P_2, ShadeName.Dim);
						break;
					}
				}
			}
			else
			{
				switch (P_1)
				{
				case (md)3:
				case (md)6:
				case (md)34:
					num = CFo(2, P_0.nWI().ButtonBorderContrastKind);
					break;
				case (md)21:
					num = CFo(2, P_0.nWI().ListItemBorderContrastKind);
					break;
				case (md)25:
					num = CFo(2, P_0.nWI().ListItemBorderContrastKind);
					break;
				case (md)29:
				case (md)45:
					num = CFo(2, P_0.nWI().BarItemBorderContrastKind);
					break;
				default:
					num = 2;
					break;
				}
				if (P_5)
				{
					num *= -1;
				}
			}
			if ((P_4 & DL.Disabled) == DL.Disabled)
			{
				num = Math.Max(num - 2, (int)Math.Round((double)num / 2.0, MidpointRounding.AwayFromZero));
			}
			if ((P_4 & (DL)1) == (DL)1)
			{
				num++;
			}
			if ((P_4 & (DL)32) == (DL)32)
			{
				num--;
			}
		}
		else if (P_4 == DL.Disabled)
		{
			num = ((P_1 != (md)6 && (uint)(P_1 - 44) > 1u) ? (num + 2) : (num - 1));
		}
		bool flag = (P_4 & DL.Checked) == DL.Checked;
		bool flag2 = (P_4 & DL.Defaulted) == DL.Defaulted;
		bool flag3 = (P_4 & DL.Hover) == DL.Hover;
		bool flag4 = (P_4 & (DL)64) == (DL)64;
		bool flag5 = (P_4 & DL.Pressed) == DL.Pressed;
		if (flag || flag2 || flag3 || flag4 || flag5)
		{
			switch (P_1)
			{
			case (md)2:
			case (md)3:
			case (md)6:
			case (md)19:
			case (md)24:
			case (md)36:
			case (md)51:
			case (md)52:
				num += ((flag3 || flag2) ? 1 : 2);
				break;
			default:
			{
				bool flag6 = !P_2 && P_0.nWI().IsDarkTheme;
				num += ((!flag5) ? ((!(flag || flag4)) ? (-1) : 0) : ((!flag6) ? 1 : 2));
				break;
			}
			}
		}
		return num;
	}

	private static int jFF(AD P_0, md P_1, bool P_2, ShadeName P_3)
	{
		ShadeName shadeName = EFe(P_0, P_1, YK.Background, P_2);
		return Math.Max(0, (P_3 - shadeName) / 100);
	}

	private static int CFo(int P_0, BorderContrastKind P_1)
	{
		switch (P_1)
		{
		case BorderContrastKind.Lowest:
			P_0 = 0;
			break;
		case BorderContrastKind.Low:
			if (P_0 >= 2)
			{
				P_0--;
			}
			break;
		case BorderContrastKind.High:
			P_0++;
			break;
		}
		return P_0;
	}

	private static void nFQ(AD P_0, Color P_1, int P_2, int P_3, out Color P_4, out Color P_5)
	{
		IColorRamp colorRamp = null;
		IColorRampShade colorRampShade = null;
		IEnumerator<IColorRamp> enumerator = P_0.IWZ().All.GetEnumerator();
		int num = 1;
		if (!mfF())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 1:
			try
			{
				while (enumerator.MoveNext())
				{
					IColorRamp current = enumerator.Current;
					foreach (IColorRampShade item in current)
					{
						if (item.Color == P_1)
						{
							colorRamp = current;
							colorRampShade = item;
							break;
						}
					}
				}
			}
			finally
			{
				enumerator?.Dispose();
			}
			break;
		}
		if (colorRampShade != null)
		{
			if (P_0.IWZ().Gray != colorRamp && P_0.IWZ().Silver != colorRamp)
			{
				P_2 = P_2 * 2 / 3;
				P_3 = P_3 * 2 / 3;
			}
			int shadeNumber = ColorRampShade.CoerceShadeNumber(colorRampShade.Number + P_2);
			int shadeNumber2 = ColorRampShade.CoerceShadeNumber(colorRampShade.Number + P_3);
			P_4 = colorRamp.GetShade(shadeNumber).Color;
			P_5 = colorRamp.GetShade(shadeNumber2).Color;
		}
		else
		{
			P_4 = P_1;
			P_5 = P_1;
		}
	}

	private static Color YFO(AD P_0, md P_1, YK P_2, DL P_3 = DL.Normal, oS P_4 = oS.None)
	{
		oS oS = P_4 & (oS)(-16);
		int num = (int)(P_4 & (oS)15);
		bool flag = (P_4 & (oS)256) == (oS)256;
		bool flag2 = P_0.rWH() && !flag;
		num += RF7(P_0, P_1, _0020: true, P_2, P_3, flag2);
		if (num < 0)
		{
			num *= -1;
			oS ^= (oS)64;
		}
		if (num > 15)
		{
			throw new InvalidOperationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105806));
		}
		oS = (oS)((int)oS | num);
		IColorRampShade colorRampShade = dFk(P_0, P_1, P_2, oS);
		return lF2(colorRampShade, P_1, P_2);
	}

	private static Color FF0(AD P_0, md P_1, oS P_2 = oS.None)
	{
		return dFk(P_0, P_1, YK.Background, P_2).Color;
	}

	private static IColorRampShade dFk(AD P_0, md P_1, YK P_2, oS P_3 = oS.None)
	{
		ShadeName shadeName = EFe(P_0, P_1, P_2, _0020: true);
		int num = 0;
		bool flag = false;
		if ((P_3 & (oS)16) == (oS)16)
		{
			flag = true;
			shadeName = ShadeName.Darkest;
		}
		else if ((P_3 & (oS)15) != oS.None)
		{
			num += (int)(P_3 & (oS)15) * -100;
		}
		if ((P_3 & (oS)32) == (oS)32)
		{
			num -= 50;
		}
		if ((P_3 & (oS)64) == (oS)64)
		{
			num *= -1;
		}
		bool flag2 = (P_3 & (oS)256) == (oS)256 || !P_0.nWI().IsDarkTheme;
		if ((P_3 & (oS)128) == (oS)128)
		{
			flag2 = !flag2;
		}
		IColorRamp colorRamp = ((!flag2) ? (flag ? P_0.IWZ().Silver : P_0.IWZ().Gray) : (flag ? P_0.IWZ().Gray : P_0.IWZ().Silver));
		int num2 = (int)(flag2 ? (shadeName - num) : (1000 - shadeName + num));
		if (flag2)
		{
			if (num2 > 900 && colorRamp == P_0.IWZ().Silver)
			{
				colorRamp = P_0.IWZ().Gray;
				num2 -= 900;
			}
		}
		else
		{
			if (num2 > 900 && colorRamp == P_0.IWZ().Gray && P_0.rWH())
			{
				double brightness = P_0.IWZ().Gray[ShadeName.Black].Brightness;
				double brightness2 = P_0.IWZ().Gray[ShadeName.Darkest].Brightness;
				double num3 = brightness2 - brightness;
				if (num3 > 0.01)
				{
					double num4 = ((double)num2 - 900.0) / 100.0;
					double brightness3 = P_0.IWZ().Gray[ShadeName.Darker].Brightness;
					double num5 = brightness3 - brightness2;
					int num6 = (int)(num5 * num4 / num3 * 100.0);
					num6 /= 2;
					num2 = 900 + Math.Max(0, Math.Min(100, num6));
				}
			}
			if (num2 < 100 && colorRamp == P_0.IWZ().Gray)
			{
				colorRamp = P_0.IWZ().Silver;
				num2 += 900;
			}
		}
		num2 = ColorRampShade.CoerceShadeNumber(num2);
		return colorRamp.GetShade(num2);
	}

	private static Color Opacity(Color color, byte a)
	{
		return Color.FromArgb(a, color.R, color.G, color.B);
	}

	private static void KFl(AD P_0, ResourceKey P_1, bool P_2)
	{
		LFq(P_0, P_1, P_2);
	}

	private static void GFA(AD P_0, ResourceKey P_1, Color P_2)
	{
		if (!P_0.WWC().TryGetValue(P_2, out var value))
		{
			value = new SolidColorBrush(P_2);
			P_0.WWC()[P_2] = value;
		}
		EFY(P_0, P_1, value);
	}

	private static void IFC(AD P_0, ResourceKey P_1, GradientKind P_2, GradientUsageKind P_3, Color P_4)
	{
		int num = 0;
		int num2 = 0;
		switch (P_2)
		{
		case GradientKind.Low:
			num -= 25;
			num2 += 25;
			break;
		case GradientKind.Mid:
			num -= 50;
			num2 += 50;
			break;
		case GradientKind.High:
			num -= 100;
			num2 += 100;
			break;
		}
		switch (P_3)
		{
		case GradientUsageKind.Checked:
		{
			int num3 = num;
			num = num2 / 2;
			num2 = num3 / 2;
			break;
		}
		case GradientUsageKind.Disabled:
			num /= 3;
			num2 /= 3;
			break;
		case GradientUsageKind.Pressed:
			num = num2;
			num2 = 0;
			break;
		}
		if (num != 0 || num2 != 0)
		{
			nFQ(P_0, P_4, num, num2, out var color, out var color2);
			if (color != color2)
			{
				LinearGradientBrush linearGradientBrush = new LinearGradientBrush
				{
					StartPoint = new Point(0.0, 0.0),
					EndPoint = new Point(0.0, 1.0),
					GradientStops = 
					{
						new GradientStop(color, 0.0),
						new GradientStop(color2, 1.0)
					}
				};
				EFY(P_0, P_1, linearGradientBrush);
				return;
			}
		}
		GFA(P_0, P_1, P_4);
	}

	private static void EFY(AD P_0, ResourceKey P_1, Brush P_2)
	{
		if (P_2.CanFreeze)
		{
			P_2.Freeze();
		}
		LFq(P_0, P_1, P_2);
	}

	private static void IFI(AD P_0, ResourceKey P_1, BulletChromeRelativeSize P_2)
	{
		LFq(P_0, P_1, P_2);
	}

	private static void UFx(AD P_0, ResourceKey P_1, CornerRadius P_2)
	{
		LFq(P_0, P_1, P_2);
	}

	private static void rFr(AD P_0, ResourceKey P_1, double P_2)
	{
		LFq(P_0, P_1, P_2);
	}

	private static void DFZ(AD P_0, ResourceKey P_1, FontFamily P_2)
	{
		LFq(P_0, P_1, P_2);
	}

	private static void GFn(AD P_0, ResourceKey P_1, FontWeight P_2)
	{
		LFq(P_0, P_1, P_2);
	}

	private static void DFa(AD P_0, ResourceKey P_1, int P_2)
	{
		LFq(P_0, P_1, P_2);
	}

	private static void LFq(AD P_0, ResourceKey P_1, object P_2)
	{
		P_0.dWq().Add(P_1, P_2);
	}

	private static void MFW(AD P_0, ResourceKey P_1, string P_2)
	{
		LFq(P_0, P_1, P_2);
	}

	private static void eFU(AD P_0, ResourceKey P_1, Thickness P_2)
	{
		LFq(P_0, P_1, P_2);
	}

	private static void xFH(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		eFU(P_0, AssetResourceKeys.BulletBorderNormalThicknessKey, new Thickness(P_0.nWI().BulletBorderWidth));
		IFI(P_0, AssetResourceKeys.BulletBulletChromeRelativeSizeKey, P_0.nWI().BulletRelativeSize);
		KFl(P_0, AssetResourceKeys.BulletGlyphUseAlternateGeometryBooleanKey, _0020: false);
		GFA(P_0, AssetResourceKeys.BulletInnerBackgroundDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletInnerBackgroundHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletInnerBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletInnerBackgroundPressedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletInnerBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletInnerBorderHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletInnerBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletInnerBorderPressedBrushKey, Colors.Transparent);
		KFl(P_0, AssetResourceKeys.BulletIsAnimationEnabledBooleanKey, _0020: false);
		GFA(P_0, AssetResourceKeys.BulletGlyphBorderIndeterminateDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletGlyphBorderIndeterminateHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletGlyphBorderIndeterminateNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletGlyphBorderIndeterminatePressedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletRoundGlyphBorderCheckedDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletRoundGlyphBorderCheckedNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletSquareGlyphBorderCheckedDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BulletSquareGlyphBorderCheckedNormalBrushKey, Colors.Transparent);
		UFx(P_0, AssetResourceKeys.ButtonBorderNormalCornerRadiusKey, new CornerRadius(P_0.nWI().ButtonCornerRadius));
		eFU(P_0, AssetResourceKeys.ButtonBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.ButtonInnerBorderNormalThicknessKey, new Thickness(0.0));
		KFl(P_0, AssetResourceKeys.ButtonIsAnimationEnabledBooleanKey, _0020: false);
		eFU(P_0, AssetResourceKeys.ButtonPaddingNormalThicknessKey, P_0.nWI().ButtonPadding);
		GFA(P_0, AssetResourceKeys.ButtonInnerBorderCheckedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ButtonInnerBorderDefaultedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ButtonInnerBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ButtonInnerBorderHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ButtonInnerBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ButtonInnerBorderPressedBrushKey, Colors.Transparent);
		UFx(P_0, AssetResourceKeys.CheckBoxBorderNormalCornerRadiusKey, new CornerRadius(P_0.nWI().CheckBoxCornerRadius));
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.BulletBackgroundDisabledBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.BulletBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.BulletBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.BulletBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.BulletBorderDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.BulletBorderHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.BulletBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.BulletBorderPressedBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.BulletGlyphBackgroundIndeterminateDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.BulletGlyphBackgroundIndeterminateHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.BulletGlyphBackgroundIndeterminateNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.BulletGlyphBackgroundIndeterminatePressedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.BulletRoundGlyphBackgroundCheckedDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.BulletRoundGlyphBackgroundCheckedHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.BulletRoundGlyphBackgroundCheckedNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.BulletRoundGlyphBackgroundCheckedPressedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.BulletSquareGlyphBackgroundCheckedDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.BulletSquareGlyphBackgroundCheckedHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.BulletSquareGlyphBackgroundCheckedNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.BulletSquareGlyphBackgroundCheckedPressedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ButtonBackgroundCheckedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ButtonBackgroundDisabledBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ButtonBackgroundDefaultedBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ButtonBackgroundHoverBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ButtonBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ButtonBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ButtonBorderCheckedBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ButtonBorderDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.ButtonBorderDefaultedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ButtonBorderHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ButtonBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ButtonBorderPressedBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ButtonDarkBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ButtonForegroundCheckedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ButtonForegroundDefaultedBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ButtonForegroundHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ButtonForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ButtonForegroundPressedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ButtonLightBackgroundNormalBrushKey, SystemColors.ControlColor);
			return;
		}
		GFA(P_0, AssetResourceKeys.BulletBackgroundDisabledBrushKey, YFO(P_0, (md)3, YK.Background, DL.Disabled));
		GFA(P_0, AssetResourceKeys.BulletBackgroundNormalBrushKey, FF0(P_0, (md)3));
		GFA(P_0, AssetResourceKeys.BulletBorderDisabledBrushKey, YFO(P_0, (md)3, YK.Border, DL.Disabled));
		GFA(P_0, AssetResourceKeys.BulletBorderNormalBrushKey, YFO(P_0, (md)3, YK.Border));
		Color color = YFO(P_0, (md)3, (YK)11);
		Color color2;
		Color color3;
		switch (P_0.nWI().BulletGlyphKind)
		{
		case BulletGlyphKind.Accent:
			GFA(P_0, AssetResourceKeys.BulletBackgroundCheckedHoverBrushKey, FF0(P_0, (md)3));
			GFA(P_0, AssetResourceKeys.BulletBackgroundCheckedNormalBrushKey, FF0(P_0, (md)3));
			GFA(P_0, AssetResourceKeys.BulletBackgroundCheckedPressedBrushKey, FF0(P_0, (md)3));
			GFA(P_0, AssetResourceKeys.BulletBackgroundHoverBrushKey, FF0(P_0, (md)3));
			GFA(P_0, AssetResourceKeys.BulletBackgroundPressedBrushKey, FF0(P_0, (md)3));
			GFA(P_0, AssetResourceKeys.BulletBorderCheckedHoverBrushKey, YFO(P_0, (md)3, YK.Border, DL.Normal, (oS)4));
			GFA(P_0, AssetResourceKeys.BulletBorderCheckedNormalBrushKey, YFO(P_0, (md)3, YK.Border));
			GFA(P_0, AssetResourceKeys.BulletBorderCheckedPressedBrushKey, YFO(P_0, (md)3, YK.Border, DL.Normal, (oS)4));
			GFA(P_0, AssetResourceKeys.BulletBorderHoverBrushKey, YFO(P_0, (md)3, YK.Border, DL.Normal, (oS)4));
			GFA(P_0, AssetResourceKeys.BulletBorderPressedBrushKey, YFO(P_0, (md)3, YK.Border, DL.Normal, (oS)4));
			color2 = mF4(P_0, colorRamp, (md)4);
			color3 = XFw(P_0, colorRamp, (md)4, YK.Background, DL.Pressed);
			break;
		case BulletGlyphKind.Inverted:
			GFA(P_0, AssetResourceKeys.BulletBackgroundCheckedHoverBrushKey, YFO(P_0, (md)3, (YK)11));
			GFA(P_0, AssetResourceKeys.BulletBackgroundCheckedNormalBrushKey, YFO(P_0, (md)3, (YK)10));
			GFA(P_0, AssetResourceKeys.BulletBackgroundCheckedPressedBrushKey, YFO(P_0, (md)3, (YK)9));
			GFA(P_0, AssetResourceKeys.BulletBackgroundHoverBrushKey, FF0(P_0, (md)3));
			GFA(P_0, AssetResourceKeys.BulletBackgroundPressedBrushKey, FF0(P_0, (md)3));
			GFA(P_0, AssetResourceKeys.BulletBorderCheckedHoverBrushKey, YFO(P_0, (md)3, (YK)11));
			GFA(P_0, AssetResourceKeys.BulletBorderCheckedNormalBrushKey, YFO(P_0, (md)3, (YK)10));
			GFA(P_0, AssetResourceKeys.BulletBorderCheckedPressedBrushKey, YFO(P_0, (md)3, (YK)9));
			GFA(P_0, AssetResourceKeys.BulletBorderHoverBrushKey, YFO(P_0, (md)3, YK.Border, DL.Hover));
			GFA(P_0, AssetResourceKeys.BulletBorderPressedBrushKey, YFO(P_0, (md)3, YK.Border, DL.Pressed));
			color2 = FF0(P_0, (md)3);
			color3 = FF0(P_0, (md)3);
			break;
		case BulletGlyphKind.InvertedAccent:
			GFA(P_0, AssetResourceKeys.BulletBackgroundCheckedHoverBrushKey, XFw(P_0, colorRamp, (md)4, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.BulletBackgroundCheckedNormalBrushKey, XFw(P_0, colorRamp, (md)4, YK.Background));
			GFA(P_0, AssetResourceKeys.BulletBackgroundCheckedPressedBrushKey, XFw(P_0, colorRamp, (md)4, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.BulletBackgroundHoverBrushKey, FF0(P_0, (md)3));
			GFA(P_0, AssetResourceKeys.BulletBackgroundPressedBrushKey, XFw(P_0, colorRamp, (md)4, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.BulletBorderCheckedHoverBrushKey, XFw(P_0, colorRamp, (md)4, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.BulletBorderCheckedNormalBrushKey, XFw(P_0, colorRamp, (md)4, YK.Background));
			GFA(P_0, AssetResourceKeys.BulletBorderCheckedPressedBrushKey, XFw(P_0, colorRamp, (md)4, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.BulletBorderHoverBrushKey, YFO(P_0, (md)3, YK.Border, DL.Normal, (oS)4));
			GFA(P_0, AssetResourceKeys.BulletBorderPressedBrushKey, XFw(P_0, colorRamp, (md)4, YK.Background, DL.Pressed));
			color2 = XFw(P_0, colorRamp, (md)4, (YK)7);
			color3 = XFw(P_0, colorRamp, (md)4, (YK)7);
			break;
		default:
			GFA(P_0, AssetResourceKeys.BulletBackgroundCheckedHoverBrushKey, XFw(P_0, colorRamp, (md)3, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.BulletBackgroundCheckedNormalBrushKey, FF0(P_0, (md)3));
			GFA(P_0, AssetResourceKeys.BulletBackgroundCheckedPressedBrushKey, XFw(P_0, colorRamp, (md)3, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.BulletBackgroundHoverBrushKey, XFw(P_0, colorRamp, (md)3, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.BulletBackgroundPressedBrushKey, XFw(P_0, colorRamp, (md)3, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.BulletBorderCheckedHoverBrushKey, XFw(P_0, colorRamp, (md)3, YK.Border, DL.Hover));
			GFA(P_0, AssetResourceKeys.BulletBorderCheckedNormalBrushKey, YFO(P_0, (md)3, YK.Border));
			GFA(P_0, AssetResourceKeys.BulletBorderCheckedPressedBrushKey, XFw(P_0, colorRamp, (md)3, YK.Border, DL.Pressed));
			GFA(P_0, AssetResourceKeys.BulletBorderHoverBrushKey, XFw(P_0, colorRamp, (md)3, YK.Border, DL.Hover));
			GFA(P_0, AssetResourceKeys.BulletBorderPressedBrushKey, XFw(P_0, colorRamp, (md)3, YK.Border, DL.Pressed));
			color2 = YFO(P_0, (md)3, (YK)9);
			color3 = YFO(P_0, (md)3, (YK)9);
			break;
		}
		GFA(P_0, AssetResourceKeys.BulletGlyphBackgroundIndeterminateDisabledBrushKey, color);
		GFA(P_0, AssetResourceKeys.BulletGlyphBackgroundIndeterminateHoverBrushKey, color2);
		GFA(P_0, AssetResourceKeys.BulletGlyphBackgroundIndeterminateNormalBrushKey, color2);
		GFA(P_0, AssetResourceKeys.BulletGlyphBackgroundIndeterminatePressedBrushKey, color3);
		GFA(P_0, AssetResourceKeys.BulletRoundGlyphBackgroundCheckedDisabledBrushKey, color);
		GFA(P_0, AssetResourceKeys.BulletRoundGlyphBackgroundCheckedHoverBrushKey, color2);
		GFA(P_0, AssetResourceKeys.BulletRoundGlyphBackgroundCheckedNormalBrushKey, color2);
		GFA(P_0, AssetResourceKeys.BulletRoundGlyphBackgroundCheckedPressedBrushKey, color3);
		GFA(P_0, AssetResourceKeys.BulletSquareGlyphBackgroundCheckedDisabledBrushKey, color);
		GFA(P_0, AssetResourceKeys.BulletSquareGlyphBackgroundCheckedHoverBrushKey, color2);
		GFA(P_0, AssetResourceKeys.BulletSquareGlyphBackgroundCheckedNormalBrushKey, color2);
		GFA(P_0, AssetResourceKeys.BulletSquareGlyphBackgroundCheckedPressedBrushKey, color3);
		IFC(P_0, AssetResourceKeys.ButtonBackgroundCheckedBrushKey, P_0.nWI().ButtonBackgroundGradientKind, GradientUsageKind.Checked, YFO(P_0, (md)6, YK.Background, DL.Checked));
		IFC(P_0, AssetResourceKeys.ButtonBackgroundDisabledBrushKey, P_0.nWI().ButtonBackgroundGradientKind, GradientUsageKind.Disabled, YFO(P_0, (md)6, YK.Background, DL.Disabled));
		IFC(P_0, AssetResourceKeys.ButtonBackgroundDefaultedBrushKey, P_0.nWI().ButtonBackgroundGradientKind, GradientUsageKind.Defaulted, FF0(P_0, (md)6));
		IFC(P_0, AssetResourceKeys.ButtonBackgroundHoverBrushKey, P_0.nWI().ButtonBackgroundGradientKind, GradientUsageKind.Hover, XFw(P_0, colorRamp, (md)6, YK.Background, DL.Hover));
		IFC(P_0, AssetResourceKeys.ButtonBackgroundNormalBrushKey, P_0.nWI().ButtonBackgroundGradientKind, GradientUsageKind.Normal, FF0(P_0, (md)6));
		IFC(P_0, AssetResourceKeys.ButtonBackgroundPressedBrushKey, P_0.nWI().ButtonBackgroundGradientKind, GradientUsageKind.Pressed, XFw(P_0, colorRamp, (md)6, YK.Background, DL.Pressed));
		GFA(P_0, AssetResourceKeys.ButtonBorderCheckedBrushKey, YFO(P_0, (md)6, YK.Border, DL.Checked));
		GFA(P_0, AssetResourceKeys.ButtonBorderDisabledBrushKey, YFO(P_0, (md)6, YK.Border, DL.Disabled));
		GFA(P_0, AssetResourceKeys.ButtonBorderDefaultedBrushKey, XFw(P_0, colorRamp, (md)6, YK.Border, DL.Defaulted));
		GFA(P_0, AssetResourceKeys.ButtonBorderHoverBrushKey, XFw(P_0, colorRamp, (md)6, YK.Border, DL.Hover));
		GFA(P_0, AssetResourceKeys.ButtonBorderNormalBrushKey, YFO(P_0, (md)6, YK.Border));
		GFA(P_0, AssetResourceKeys.ButtonBorderPressedBrushKey, XFw(P_0, colorRamp, (md)6, YK.Border, DL.Pressed));
		GFA(P_0, AssetResourceKeys.ButtonDarkBackgroundNormalBrushKey, FF0(P_0, (md)6, (oS)1));
		GFA(P_0, AssetResourceKeys.ButtonForegroundCheckedBrushKey, YFO(P_0, (md)6, (YK)8, DL.Checked));
		GFA(P_0, AssetResourceKeys.ButtonForegroundDefaultedBrushKey, YFO(P_0, (md)6, (YK)8));
		GFA(P_0, AssetResourceKeys.ButtonForegroundHoverBrushKey, XFw(P_0, colorRamp, (md)6, (YK)8, DL.Hover));
		GFA(P_0, AssetResourceKeys.ButtonForegroundNormalBrushKey, YFO(P_0, (md)6, (YK)8));
		GFA(P_0, AssetResourceKeys.ButtonForegroundPressedBrushKey, XFw(P_0, colorRamp, (md)6, (YK)8, DL.Pressed));
		GFA(P_0, AssetResourceKeys.ButtonLightBackgroundNormalBrushKey, FF0(P_0, (md)6, (oS)65));
	}

	private static void WF6(AD P_0)
	{
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.ChartAxisBaselineForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ChartAxisTickMajorForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ChartAxisTickMinorForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ChartBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ChartBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ChartBoxPlotBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ChartBoxPlotBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ChartDataPointLabelBorderNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ChartDataPointLabelForegroundNormalBrushKey, Colors.White);
			GFA(P_0, AssetResourceKeys.ChartGridLineMajorForegroundNormalBrushKey, Opacity(SystemColors.ControlTextColor, 32));
			GFA(P_0, AssetResourceKeys.ChartGridLineMinorForegroundNormalBrushKey, Opacity(SystemColors.ControlTextColor, 80));
			GFA(P_0, AssetResourceKeys.ChartGridStripeAlternateBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ChartGridStripeBackgroundNormalBrushKey, Opacity(SystemColors.ControlTextColor, 16));
			GFA(P_0, AssetResourceKeys.ChartLegendBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ChartLegendBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ChartMarkerBorderNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ChartPieBorderNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ChartRangeBackgroundNormalBrushKey, Opacity(SystemColors.ControlTextColor, 32));
		}
		else
		{
			GFA(P_0, AssetResourceKeys.ChartAxisBaselineForegroundNormalBrushKey, YFO(P_0, (md)7, (YK)6));
			GFA(P_0, AssetResourceKeys.ChartAxisTickMajorForegroundNormalBrushKey, YFO(P_0, (md)7, (YK)6, DL.Normal, (oS)2));
			GFA(P_0, AssetResourceKeys.ChartAxisTickMinorForegroundNormalBrushKey, YFO(P_0, (md)7, (YK)6, DL.Normal, (oS)1));
			GFA(P_0, AssetResourceKeys.ChartBackgroundNormalBrushKey, FF0(P_0, (md)7));
			GFA(P_0, AssetResourceKeys.ChartBorderNormalBrushKey, YFO(P_0, (md)7, YK.Border));
			GFA(P_0, AssetResourceKeys.ChartBoxPlotBackgroundNormalBrushKey, FF0(P_0, (md)5));
			GFA(P_0, AssetResourceKeys.ChartBoxPlotBorderNormalBrushKey, YFO(P_0, (md)5, (YK)8));
			GFA(P_0, AssetResourceKeys.ChartDataPointLabelBorderNormalBrushKey, FF0(P_0, (md)7));
			GFA(P_0, AssetResourceKeys.ChartDataPointLabelForegroundNormalBrushKey, Colors.White);
			GFA(P_0, AssetResourceKeys.ChartGridLineMajorForegroundNormalBrushKey, FF0(P_0, (md)7, (oS)3));
			GFA(P_0, AssetResourceKeys.ChartGridLineMinorForegroundNormalBrushKey, FF0(P_0, (md)7, (oS)2));
			GFA(P_0, AssetResourceKeys.ChartGridStripeAlternateBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ChartGridStripeBackgroundNormalBrushKey, FF0(P_0, (md)7, (oS)1));
			GFA(P_0, AssetResourceKeys.ChartLegendBackgroundNormalBrushKey, FF0(P_0, (md)7));
			GFA(P_0, AssetResourceKeys.ChartLegendBorderNormalBrushKey, YFO(P_0, (md)7, YK.Border, DL.Normal, (oS)2));
			GFA(P_0, AssetResourceKeys.ChartMarkerBorderNormalBrushKey, FF0(P_0, (md)7));
			GFA(P_0, AssetResourceKeys.ChartPieBorderNormalBrushKey, FF0(P_0, (md)7));
			GFA(P_0, AssetResourceKeys.ChartRangeBackgroundNormalBrushKey, Opacity(YFO(P_0, (md)7, YK.Border), 80));
		}
	}

	private static void rFV(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(ColorFamilyName.Silver);
		IColorRamp colorRamp2 = P_0.IWZ().GetColorRamp(ColorFamilyName.Gray);
		IColorRamp colorRamp3 = P_0.IWZ().GetColorRamp(ColorFamilyName.Red);
		IColorRamp colorRamp4 = P_0.IWZ().GetColorRamp(ColorFamilyName.Orange);
		IColorRamp colorRamp5 = P_0.IWZ().GetColorRamp(ColorFamilyName.Yellow);
		IColorRamp colorRamp6 = P_0.IWZ().GetColorRamp(ColorFamilyName.Green);
		IColorRamp colorRamp7 = P_0.IWZ().GetColorRamp(ColorFamilyName.Teal);
		IColorRamp colorRamp8 = P_0.IWZ().GetColorRamp(ColorFamilyName.Blue);
		IColorRamp colorRamp9 = P_0.IWZ().GetColorRamp(ColorFamilyName.Indigo);
		IColorRamp colorRamp10 = P_0.IWZ().GetColorRamp(ColorFamilyName.Purple);
		IColorRamp colorRamp11 = P_0.IWZ().GetColorRamp(ColorFamilyName.Pink);
		GFA(P_0, AssetResourceKeys.ColorPaletteSilverBackgroundLowestBrushKey, mF4(P_0, colorRamp, (md)26));
		GFA(P_0, AssetResourceKeys.ColorPaletteSilverBackgroundLowerBrushKey, mF4(P_0, colorRamp, (md)26, (oS)1));
		GFA(P_0, AssetResourceKeys.ColorPaletteSilverBackgroundLowBrushKey, mF4(P_0, colorRamp, (md)26, (oS)2));
		GFA(P_0, AssetResourceKeys.ColorPaletteSilverBackgroundMidLowBrushKey, mF4(P_0, colorRamp, (md)26, (oS)3));
		GFA(P_0, AssetResourceKeys.ColorPaletteSilverBackgroundMidBrushKey, mF4(P_0, colorRamp, (md)26, (oS)4));
		GFA(P_0, AssetResourceKeys.ColorPaletteSilverBackgroundMidHighBrushKey, mF4(P_0, colorRamp, (md)26, (oS)5));
		GFA(P_0, AssetResourceKeys.ColorPaletteSilverBackgroundHighBrushKey, mF4(P_0, colorRamp, (md)26, (oS)6));
		GFA(P_0, AssetResourceKeys.ColorPaletteSilverBackgroundHigherBrushKey, mF4(P_0, colorRamp, (md)26, (oS)7));
		GFA(P_0, AssetResourceKeys.ColorPaletteSilverBackgroundHighestBrushKey, mF4(P_0, colorRamp, (md)26, (oS)8));
		GFA(P_0, AssetResourceKeys.ColorPaletteGrayBackgroundLowestBrushKey, mF4(P_0, colorRamp2, (md)26));
		GFA(P_0, AssetResourceKeys.ColorPaletteGrayBackgroundLowerBrushKey, mF4(P_0, colorRamp2, (md)26, (oS)1));
		GFA(P_0, AssetResourceKeys.ColorPaletteGrayBackgroundLowBrushKey, mF4(P_0, colorRamp2, (md)26, (oS)2));
		GFA(P_0, AssetResourceKeys.ColorPaletteGrayBackgroundMidLowBrushKey, mF4(P_0, colorRamp2, (md)26, (oS)3));
		GFA(P_0, AssetResourceKeys.ColorPaletteGrayBackgroundMidBrushKey, mF4(P_0, colorRamp2, (md)26, (oS)4));
		GFA(P_0, AssetResourceKeys.ColorPaletteGrayBackgroundMidHighBrushKey, mF4(P_0, colorRamp2, (md)26, (oS)5));
		GFA(P_0, AssetResourceKeys.ColorPaletteGrayBackgroundHighBrushKey, mF4(P_0, colorRamp2, (md)26, (oS)6));
		GFA(P_0, AssetResourceKeys.ColorPaletteGrayBackgroundHigherBrushKey, mF4(P_0, colorRamp2, (md)26, (oS)7));
		GFA(P_0, AssetResourceKeys.ColorPaletteGrayBackgroundHighestBrushKey, mF4(P_0, colorRamp2, (md)26, (oS)8));
		GFA(P_0, AssetResourceKeys.ColorPaletteRedBackgroundLowestBrushKey, mF4(P_0, colorRamp3, (md)26));
		GFA(P_0, AssetResourceKeys.ColorPaletteRedBackgroundLowerBrushKey, mF4(P_0, colorRamp3, (md)26, (oS)1));
		GFA(P_0, AssetResourceKeys.ColorPaletteRedBackgroundLowBrushKey, mF4(P_0, colorRamp3, (md)26, (oS)2));
		GFA(P_0, AssetResourceKeys.ColorPaletteRedBackgroundMidLowBrushKey, mF4(P_0, colorRamp3, (md)26, (oS)3));
		GFA(P_0, AssetResourceKeys.ColorPaletteRedBackgroundMidBrushKey, mF4(P_0, colorRamp3, (md)26, (oS)4));
		GFA(P_0, AssetResourceKeys.ColorPaletteRedBackgroundMidHighBrushKey, mF4(P_0, colorRamp3, (md)26, (oS)5));
		GFA(P_0, AssetResourceKeys.ColorPaletteRedBackgroundHighBrushKey, mF4(P_0, colorRamp3, (md)26, (oS)6));
		GFA(P_0, AssetResourceKeys.ColorPaletteRedBackgroundHigherBrushKey, mF4(P_0, colorRamp3, (md)26, (oS)7));
		GFA(P_0, AssetResourceKeys.ColorPaletteRedBackgroundHighestBrushKey, mF4(P_0, colorRamp3, (md)26, (oS)8));
		GFA(P_0, AssetResourceKeys.ColorPaletteOrangeBackgroundLowestBrushKey, mF4(P_0, colorRamp4, (md)26));
		GFA(P_0, AssetResourceKeys.ColorPaletteOrangeBackgroundLowerBrushKey, mF4(P_0, colorRamp4, (md)26, (oS)1));
		GFA(P_0, AssetResourceKeys.ColorPaletteOrangeBackgroundLowBrushKey, mF4(P_0, colorRamp4, (md)26, (oS)2));
		GFA(P_0, AssetResourceKeys.ColorPaletteOrangeBackgroundMidLowBrushKey, mF4(P_0, colorRamp4, (md)26, (oS)3));
		GFA(P_0, AssetResourceKeys.ColorPaletteOrangeBackgroundMidBrushKey, mF4(P_0, colorRamp4, (md)26, (oS)4));
		GFA(P_0, AssetResourceKeys.ColorPaletteOrangeBackgroundMidHighBrushKey, mF4(P_0, colorRamp4, (md)26, (oS)5));
		GFA(P_0, AssetResourceKeys.ColorPaletteOrangeBackgroundHighBrushKey, mF4(P_0, colorRamp4, (md)26, (oS)6));
		GFA(P_0, AssetResourceKeys.ColorPaletteOrangeBackgroundHigherBrushKey, mF4(P_0, colorRamp4, (md)26, (oS)7));
		GFA(P_0, AssetResourceKeys.ColorPaletteOrangeBackgroundHighestBrushKey, mF4(P_0, colorRamp4, (md)26, (oS)8));
		GFA(P_0, AssetResourceKeys.ColorPaletteYellowBackgroundLowestBrushKey, mF4(P_0, colorRamp5, (md)26));
		GFA(P_0, AssetResourceKeys.ColorPaletteYellowBackgroundLowerBrushKey, mF4(P_0, colorRamp5, (md)26, (oS)1));
		GFA(P_0, AssetResourceKeys.ColorPaletteYellowBackgroundLowBrushKey, mF4(P_0, colorRamp5, (md)26, (oS)2));
		GFA(P_0, AssetResourceKeys.ColorPaletteYellowBackgroundMidLowBrushKey, mF4(P_0, colorRamp5, (md)26, (oS)3));
		GFA(P_0, AssetResourceKeys.ColorPaletteYellowBackgroundMidBrushKey, mF4(P_0, colorRamp5, (md)26, (oS)4));
		GFA(P_0, AssetResourceKeys.ColorPaletteYellowBackgroundMidHighBrushKey, mF4(P_0, colorRamp5, (md)26, (oS)5));
		GFA(P_0, AssetResourceKeys.ColorPaletteYellowBackgroundHighBrushKey, mF4(P_0, colorRamp5, (md)26, (oS)6));
		GFA(P_0, AssetResourceKeys.ColorPaletteYellowBackgroundHigherBrushKey, mF4(P_0, colorRamp5, (md)26, (oS)7));
		GFA(P_0, AssetResourceKeys.ColorPaletteYellowBackgroundHighestBrushKey, mF4(P_0, colorRamp5, (md)26, (oS)8));
		GFA(P_0, AssetResourceKeys.ColorPaletteGreenBackgroundLowestBrushKey, mF4(P_0, colorRamp6, (md)26));
		GFA(P_0, AssetResourceKeys.ColorPaletteGreenBackgroundLowerBrushKey, mF4(P_0, colorRamp6, (md)26, (oS)1));
		GFA(P_0, AssetResourceKeys.ColorPaletteGreenBackgroundLowBrushKey, mF4(P_0, colorRamp6, (md)26, (oS)2));
		GFA(P_0, AssetResourceKeys.ColorPaletteGreenBackgroundMidLowBrushKey, mF4(P_0, colorRamp6, (md)26, (oS)3));
		GFA(P_0, AssetResourceKeys.ColorPaletteGreenBackgroundMidBrushKey, mF4(P_0, colorRamp6, (md)26, (oS)4));
		GFA(P_0, AssetResourceKeys.ColorPaletteGreenBackgroundMidHighBrushKey, mF4(P_0, colorRamp6, (md)26, (oS)5));
		GFA(P_0, AssetResourceKeys.ColorPaletteGreenBackgroundHighBrushKey, mF4(P_0, colorRamp6, (md)26, (oS)6));
		GFA(P_0, AssetResourceKeys.ColorPaletteGreenBackgroundHigherBrushKey, mF4(P_0, colorRamp6, (md)26, (oS)7));
		GFA(P_0, AssetResourceKeys.ColorPaletteGreenBackgroundHighestBrushKey, mF4(P_0, colorRamp6, (md)26, (oS)8));
		GFA(P_0, AssetResourceKeys.ColorPaletteTealBackgroundLowestBrushKey, mF4(P_0, colorRamp7, (md)26));
		GFA(P_0, AssetResourceKeys.ColorPaletteTealBackgroundLowerBrushKey, mF4(P_0, colorRamp7, (md)26, (oS)1));
		GFA(P_0, AssetResourceKeys.ColorPaletteTealBackgroundLowBrushKey, mF4(P_0, colorRamp7, (md)26, (oS)2));
		GFA(P_0, AssetResourceKeys.ColorPaletteTealBackgroundMidLowBrushKey, mF4(P_0, colorRamp7, (md)26, (oS)3));
		GFA(P_0, AssetResourceKeys.ColorPaletteTealBackgroundMidBrushKey, mF4(P_0, colorRamp7, (md)26, (oS)4));
		GFA(P_0, AssetResourceKeys.ColorPaletteTealBackgroundMidHighBrushKey, mF4(P_0, colorRamp7, (md)26, (oS)5));
		GFA(P_0, AssetResourceKeys.ColorPaletteTealBackgroundHighBrushKey, mF4(P_0, colorRamp7, (md)26, (oS)6));
		GFA(P_0, AssetResourceKeys.ColorPaletteTealBackgroundHigherBrushKey, mF4(P_0, colorRamp7, (md)26, (oS)7));
		GFA(P_0, AssetResourceKeys.ColorPaletteTealBackgroundHighestBrushKey, mF4(P_0, colorRamp7, (md)26, (oS)8));
		GFA(P_0, AssetResourceKeys.ColorPaletteBlueBackgroundLowestBrushKey, mF4(P_0, colorRamp8, (md)26));
		GFA(P_0, AssetResourceKeys.ColorPaletteBlueBackgroundLowerBrushKey, mF4(P_0, colorRamp8, (md)26, (oS)1));
		GFA(P_0, AssetResourceKeys.ColorPaletteBlueBackgroundLowBrushKey, mF4(P_0, colorRamp8, (md)26, (oS)2));
		GFA(P_0, AssetResourceKeys.ColorPaletteBlueBackgroundMidLowBrushKey, mF4(P_0, colorRamp8, (md)26, (oS)3));
		GFA(P_0, AssetResourceKeys.ColorPaletteBlueBackgroundMidBrushKey, mF4(P_0, colorRamp8, (md)26, (oS)4));
		GFA(P_0, AssetResourceKeys.ColorPaletteBlueBackgroundMidHighBrushKey, mF4(P_0, colorRamp8, (md)26, (oS)5));
		GFA(P_0, AssetResourceKeys.ColorPaletteBlueBackgroundHighBrushKey, mF4(P_0, colorRamp8, (md)26, (oS)6));
		GFA(P_0, AssetResourceKeys.ColorPaletteBlueBackgroundHigherBrushKey, mF4(P_0, colorRamp8, (md)26, (oS)7));
		GFA(P_0, AssetResourceKeys.ColorPaletteBlueBackgroundHighestBrushKey, mF4(P_0, colorRamp8, (md)26, (oS)8));
		GFA(P_0, AssetResourceKeys.ColorPaletteIndigoBackgroundLowestBrushKey, mF4(P_0, colorRamp9, (md)26));
		GFA(P_0, AssetResourceKeys.ColorPaletteIndigoBackgroundLowerBrushKey, mF4(P_0, colorRamp9, (md)26, (oS)1));
		GFA(P_0, AssetResourceKeys.ColorPaletteIndigoBackgroundLowBrushKey, mF4(P_0, colorRamp9, (md)26, (oS)2));
		GFA(P_0, AssetResourceKeys.ColorPaletteIndigoBackgroundMidLowBrushKey, mF4(P_0, colorRamp9, (md)26, (oS)3));
		GFA(P_0, AssetResourceKeys.ColorPaletteIndigoBackgroundMidBrushKey, mF4(P_0, colorRamp9, (md)26, (oS)4));
		GFA(P_0, AssetResourceKeys.ColorPaletteIndigoBackgroundMidHighBrushKey, mF4(P_0, colorRamp9, (md)26, (oS)5));
		GFA(P_0, AssetResourceKeys.ColorPaletteIndigoBackgroundHighBrushKey, mF4(P_0, colorRamp9, (md)26, (oS)6));
		GFA(P_0, AssetResourceKeys.ColorPaletteIndigoBackgroundHigherBrushKey, mF4(P_0, colorRamp9, (md)26, (oS)7));
		GFA(P_0, AssetResourceKeys.ColorPaletteIndigoBackgroundHighestBrushKey, mF4(P_0, colorRamp9, (md)26, (oS)8));
		GFA(P_0, AssetResourceKeys.ColorPalettePurpleBackgroundLowestBrushKey, mF4(P_0, colorRamp10, (md)26));
		GFA(P_0, AssetResourceKeys.ColorPalettePurpleBackgroundLowerBrushKey, mF4(P_0, colorRamp10, (md)26, (oS)1));
		GFA(P_0, AssetResourceKeys.ColorPalettePurpleBackgroundLowBrushKey, mF4(P_0, colorRamp10, (md)26, (oS)2));
		GFA(P_0, AssetResourceKeys.ColorPalettePurpleBackgroundMidLowBrushKey, mF4(P_0, colorRamp10, (md)26, (oS)3));
		GFA(P_0, AssetResourceKeys.ColorPalettePurpleBackgroundMidBrushKey, mF4(P_0, colorRamp10, (md)26, (oS)4));
		GFA(P_0, AssetResourceKeys.ColorPalettePurpleBackgroundMidHighBrushKey, mF4(P_0, colorRamp10, (md)26, (oS)5));
		GFA(P_0, AssetResourceKeys.ColorPalettePurpleBackgroundHighBrushKey, mF4(P_0, colorRamp10, (md)26, (oS)6));
		GFA(P_0, AssetResourceKeys.ColorPalettePurpleBackgroundHigherBrushKey, mF4(P_0, colorRamp10, (md)26, (oS)7));
		GFA(P_0, AssetResourceKeys.ColorPalettePurpleBackgroundHighestBrushKey, mF4(P_0, colorRamp10, (md)26, (oS)8));
		GFA(P_0, AssetResourceKeys.ColorPalettePinkBackgroundLowestBrushKey, mF4(P_0, colorRamp11, (md)26));
		GFA(P_0, AssetResourceKeys.ColorPalettePinkBackgroundLowerBrushKey, mF4(P_0, colorRamp11, (md)26, (oS)1));
		GFA(P_0, AssetResourceKeys.ColorPalettePinkBackgroundLowBrushKey, mF4(P_0, colorRamp11, (md)26, (oS)2));
		GFA(P_0, AssetResourceKeys.ColorPalettePinkBackgroundMidLowBrushKey, mF4(P_0, colorRamp11, (md)26, (oS)3));
		GFA(P_0, AssetResourceKeys.ColorPalettePinkBackgroundMidBrushKey, mF4(P_0, colorRamp11, (md)26, (oS)4));
		GFA(P_0, AssetResourceKeys.ColorPalettePinkBackgroundMidHighBrushKey, mF4(P_0, colorRamp11, (md)26, (oS)5));
		GFA(P_0, AssetResourceKeys.ColorPalettePinkBackgroundHighBrushKey, mF4(P_0, colorRamp11, (md)26, (oS)6));
		GFA(P_0, AssetResourceKeys.ColorPalettePinkBackgroundHigherBrushKey, mF4(P_0, colorRamp11, (md)26, (oS)7));
		GFA(P_0, AssetResourceKeys.ColorPalettePinkBackgroundHighestBrushKey, mF4(P_0, colorRamp11, (md)26, (oS)8));
	}

	private static void kF5(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		eFU(P_0, AssetResourceKeys.ContainerBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.GroupBoxBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.StandardMdiBorderNormalThicknessKey, new Thickness(1.0));
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.AeroWizardPageTitleForegroundNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerBackgroundLowestBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ContainerBackgroundLowerBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ContainerBackgroundLowBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ContainerBackgroundMidLowBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ContainerBackgroundMidBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ContainerBackgroundMidHighBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ContainerBackgroundHighBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ContainerBackgroundHigherBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ContainerBackgroundHighestBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ContainerBorderLowestBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerBorderLowerBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerBorderLowBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerBorderMidLowBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerBorderMidBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerBorderMidHighBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerBorderHighBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerBorderHigherBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerBorderHighestBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowestNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowerNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidLowNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidHighNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundHigherNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighestNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowestMutedBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowerMutedBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowMutedBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidLowMutedBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidMutedBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidHighMutedBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighMutedBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundHigherMutedBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighestMutedBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowestSubtleBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowerSubtleBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowSubtleBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidLowSubtleBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidSubtleBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidHighSubtleBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighSubtleBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundHigherSubtleBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighestSubtleBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowestDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowerDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidLowDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidHighDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundHigherDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighestDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.GroupBoxBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.GroupBoxForegroundNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.GroupBoxHighlightNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.SeparatorBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.StandardMdiBackgroundNormalBrushKey, SystemColors.AppWorkspaceColor);
			GFA(P_0, AssetResourceKeys.StandardMdiBorderNormalBrushKey, SystemColors.AppWorkspaceColor);
			GFA(P_0, AssetResourceKeys.WorkspaceToolBarTrayHorizontalBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.WorkspaceToolBarTrayHorizontalBorderNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceToolBarTrayRoundBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.WorkspaceToolBarTrayRoundBorderNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceToolBarTrayVerticalBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.WorkspaceToolBarTrayVerticalBorderNormalBrushKey, SystemColors.WindowTextColor);
		}
		else
		{
			GFA(P_0, AssetResourceKeys.AeroWizardPageTitleForegroundNormalBrushKey, mF4(P_0, colorRamp, (md)49));
			GFA(P_0, AssetResourceKeys.ContainerBackgroundLowestBrushKey, FF0(P_0, (md)8));
			GFA(P_0, AssetResourceKeys.ContainerBackgroundLowerBrushKey, FF0(P_0, (md)9));
			GFA(P_0, AssetResourceKeys.ContainerBackgroundLowBrushKey, FF0(P_0, (md)10));
			GFA(P_0, AssetResourceKeys.ContainerBackgroundMidLowBrushKey, FF0(P_0, (md)11));
			GFA(P_0, AssetResourceKeys.ContainerBackgroundMidBrushKey, FF0(P_0, (md)12));
			GFA(P_0, AssetResourceKeys.ContainerBackgroundMidHighBrushKey, FF0(P_0, (md)13));
			GFA(P_0, AssetResourceKeys.ContainerBackgroundHighBrushKey, FF0(P_0, (md)14));
			GFA(P_0, AssetResourceKeys.ContainerBackgroundHigherBrushKey, FF0(P_0, (md)15));
			GFA(P_0, AssetResourceKeys.ContainerBackgroundHighestBrushKey, FF0(P_0, (md)16));
			GFA(P_0, AssetResourceKeys.ContainerBorderLowestBrushKey, YFO(P_0, (md)8, YK.Border));
			GFA(P_0, AssetResourceKeys.ContainerBorderLowerBrushKey, YFO(P_0, (md)9, YK.Border));
			GFA(P_0, AssetResourceKeys.ContainerBorderLowBrushKey, YFO(P_0, (md)10, YK.Border));
			GFA(P_0, AssetResourceKeys.ContainerBorderMidLowBrushKey, YFO(P_0, (md)11, YK.Border));
			GFA(P_0, AssetResourceKeys.ContainerBorderMidBrushKey, YFO(P_0, (md)12, YK.Border));
			GFA(P_0, AssetResourceKeys.ContainerBorderMidHighBrushKey, YFO(P_0, (md)13, YK.Border));
			GFA(P_0, AssetResourceKeys.ContainerBorderHighBrushKey, YFO(P_0, (md)14, YK.Border));
			GFA(P_0, AssetResourceKeys.ContainerBorderHigherBrushKey, YFO(P_0, (md)15, YK.Border));
			GFA(P_0, AssetResourceKeys.ContainerBorderHighestBrushKey, YFO(P_0, (md)16, YK.Border));
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowestNormalBrushKey, YFO(P_0, (md)8, (YK)8));
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowerNormalBrushKey, YFO(P_0, (md)9, (YK)8));
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowNormalBrushKey, YFO(P_0, (md)10, (YK)8));
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidLowNormalBrushKey, YFO(P_0, (md)11, (YK)8));
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidNormalBrushKey, YFO(P_0, (md)12, (YK)8));
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidHighNormalBrushKey, YFO(P_0, (md)13, (YK)8));
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighNormalBrushKey, YFO(P_0, (md)14, (YK)8));
			GFA(P_0, AssetResourceKeys.ContainerForegroundHigherNormalBrushKey, YFO(P_0, (md)15, (YK)8));
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighestNormalBrushKey, YFO(P_0, (md)16, (YK)8));
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowestMutedBrushKey, YFO(P_0, (md)8, (YK)9));
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowerMutedBrushKey, YFO(P_0, (md)9, (YK)9));
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowMutedBrushKey, YFO(P_0, (md)10, (YK)9));
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidLowMutedBrushKey, YFO(P_0, (md)11, (YK)9));
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidMutedBrushKey, YFO(P_0, (md)12, (YK)9));
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidHighMutedBrushKey, YFO(P_0, (md)13, (YK)9));
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighMutedBrushKey, YFO(P_0, (md)14, (YK)9));
			GFA(P_0, AssetResourceKeys.ContainerForegroundHigherMutedBrushKey, YFO(P_0, (md)15, (YK)9));
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighestMutedBrushKey, YFO(P_0, (md)16, (YK)9));
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowestSubtleBrushKey, YFO(P_0, (md)8, (YK)10));
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowerSubtleBrushKey, YFO(P_0, (md)9, (YK)10));
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowSubtleBrushKey, YFO(P_0, (md)10, (YK)10));
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidLowSubtleBrushKey, YFO(P_0, (md)11, (YK)10));
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidSubtleBrushKey, YFO(P_0, (md)12, (YK)10));
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidHighSubtleBrushKey, YFO(P_0, (md)13, (YK)10));
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighSubtleBrushKey, YFO(P_0, (md)14, (YK)10));
			GFA(P_0, AssetResourceKeys.ContainerForegroundHigherSubtleBrushKey, YFO(P_0, (md)15, (YK)10));
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighestSubtleBrushKey, YFO(P_0, (md)16, (YK)10));
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowestDisabledBrushKey, YFO(P_0, (md)8, (YK)11));
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowerDisabledBrushKey, YFO(P_0, (md)9, (YK)11, DL.Normal, (oS)1));
			GFA(P_0, AssetResourceKeys.ContainerForegroundLowDisabledBrushKey, YFO(P_0, (md)10, (YK)11, DL.Normal, (oS)2));
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidLowDisabledBrushKey, YFO(P_0, (md)11, (YK)11, DL.Normal, (oS)3));
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidDisabledBrushKey, YFO(P_0, (md)12, (YK)11, DL.Normal, (oS)4));
			GFA(P_0, AssetResourceKeys.ContainerForegroundMidHighDisabledBrushKey, YFO(P_0, (md)13, (YK)11, DL.Normal, (oS)5));
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighDisabledBrushKey, YFO(P_0, (md)14, (YK)11, DL.Normal, (oS)6));
			GFA(P_0, AssetResourceKeys.ContainerForegroundHigherDisabledBrushKey, YFO(P_0, (md)15, (YK)11, DL.Normal, (oS)7));
			GFA(P_0, AssetResourceKeys.ContainerForegroundHighestDisabledBrushKey, YFO(P_0, (md)16, (YK)11, DL.Normal, (oS)8));
			GFA(P_0, AssetResourceKeys.GroupBoxBorderNormalBrushKey, YFO(P_0, (md)10, YK.Border));
			GFA(P_0, AssetResourceKeys.GroupBoxForegroundNormalBrushKey, YFO(P_0, (md)10, (YK)8));
			GFA(P_0, AssetResourceKeys.GroupBoxHighlightNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.SeparatorBackgroundNormalBrushKey, YFO(P_0, (md)9, YK.Border));
			GFA(P_0, AssetResourceKeys.StandardMdiBackgroundNormalBrushKey, FF0(P_0, (md)12));
			GFA(P_0, AssetResourceKeys.StandardMdiBorderNormalBrushKey, FF0(P_0, (md)13));
			GFA(P_0, AssetResourceKeys.WorkspaceToolBarTrayHorizontalBackgroundNormalBrushKey, FF0(P_0, (md)53));
			GFA(P_0, AssetResourceKeys.WorkspaceToolBarTrayHorizontalBorderNormalBrushKey, YFO(P_0, (md)53, YK.Border));
			GFA(P_0, AssetResourceKeys.WorkspaceToolBarTrayRoundBackgroundNormalBrushKey, FF0(P_0, (md)53));
			GFA(P_0, AssetResourceKeys.WorkspaceToolBarTrayRoundBorderNormalBrushKey, YFO(P_0, (md)53, YK.Border));
			GFA(P_0, AssetResourceKeys.WorkspaceToolBarTrayVerticalBackgroundNormalBrushKey, FF0(P_0, (md)53));
			GFA(P_0, AssetResourceKeys.WorkspaceToolBarTrayVerticalBorderNormalBrushKey, YFO(P_0, (md)53, YK.Border));
		}
	}

	private static void dFR(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().DockGuideColorFamilyName);
		IColorRamp colorRamp2 = P_0.IWZ().GetColorRamp(P_0.nWI().PreviewTabColorFamilyName);
		IColorRamp colorRamp3 = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		IColorRamp colorRamp4 = P_0.IWZ().GetColorRamp(P_0.nWI().WindowColorFamilyName);
		bool flag = P_0.nWI().PrimaryAccentColorFamilyName == ColorFamilyName.Gray;
		GFA(P_0, AssetResourceKeys.AutoHideTabControlBackgroundNormalBrushKey, Colors.Transparent);
		UFx(P_0, AssetResourceKeys.AutoHideTabItemBorderNormalCornerRadiusKey, new CornerRadius(P_0.nWI().TabCornerRadius, P_0.nWI().TabCornerRadius, 0.0, 0.0));
		eFU(P_0, AssetResourceKeys.AutoHideTabItemBorderNormalThicknessKey, new Thickness(0.0, 0.0, 0.0, 6.0));
		eFU(P_0, AssetResourceKeys.AutoHideTabItemMarginNormalThicknessKey, new Thickness(0.0, 0.0, 12.0, 0.0));
		KFl(P_0, AssetResourceKeys.DockSiteAutoHidePopupOpensOnMouseHoverBooleanKey, _0020: false);
		eFU(P_0, AssetResourceKeys.DockSitePaddingThicknessKey, new Thickness(6.0));
		rFr(P_0, AssetResourceKeys.DockSiteSplitterSizeDoubleKey, 6.0);
		KFl(P_0, AssetResourceKeys.DockSiteToolWindowsHaveImagesOnTabsBooleanKey, _0020: false);
		UFx(P_0, AssetResourceKeys.TabbedMdiContainerTabControlBorderHighlightedCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.TabbedMdiContainerTabControlBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.TabbedMdiContainerTabControlHeaderBottomMarginNormalThicknessKey, new Thickness(0.0, -2.0, 0.0, 0.0));
		eFU(P_0, AssetResourceKeys.TabbedMdiContainerTabControlHeaderTopMarginNormalThicknessKey, new Thickness(0.0, 0.0, 0.0, -2.0));
		eFU(P_0, AssetResourceKeys.TabbedMdiContainerTabControlPaddingNormalThicknessKey, new Thickness(0.0, 2.0, 0.0, 0.0));
		UFx(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderNormalCornerRadiusKey, new CornerRadius(P_0.nWI().TabCornerRadius, P_0.nWI().TabCornerRadius, 0.0, 0.0));
		eFU(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBottomMarginNormalThicknessKey, new Thickness(0.0));
		rFr(P_0, AssetResourceKeys.TabbedMdiContainerTabItemSpacingNormalDoubleKey, 0.0);
		eFU(P_0, AssetResourceKeys.TabbedMdiContainerTabItemTopMarginNormalThicknessKey, new Thickness(0.0));
		eFU(P_0, AssetResourceKeys.ToolWindowContainerTabControlBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.ToolWindowContainerTabControlHeaderBottomMarginNormalThicknessKey, new Thickness(0.0, -1.0, 0.0, 0.0));
		eFU(P_0, AssetResourceKeys.ToolWindowContainerTabControlHeaderTopMarginNormalThicknessKey, new Thickness(0.0));
		UFx(P_0, AssetResourceKeys.ToolWindowContainerTabItemBorderNormalCornerRadiusKey, new CornerRadius(P_0.nWI().TabCornerRadius, P_0.nWI().TabCornerRadius, 0.0, 0.0));
		eFU(P_0, AssetResourceKeys.ToolWindowContainerTabItemBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.ToolWindowContainerTabItemBottomMarginNormalThicknessKey, new Thickness(0.0, 1.0, 0.0, 1.0));
		rFr(P_0, AssetResourceKeys.ToolWindowContainerTabItemSpacingNormalDoubleKey, 0.0);
		eFU(P_0, AssetResourceKeys.ToolWindowContainerTabItemTopMarginNormalThicknessKey, new Thickness(0.0));
		UFx(P_0, AssetResourceKeys.ToolWindowContainerTitleBarBorderNormalCornerRadiusKey, new CornerRadius(P_0.nWI().TitleBarCornerRadius, P_0.nWI().TitleBarCornerRadius, 0.0, 0.0));
		KFl(P_0, AssetResourceKeys.ToolWindowContainerTitleBarHasGripperBooleanKey, _0020: true);
		rFr(P_0, AssetResourceKeys.ToolWindowContainerTitleBarMinHeightNormalDoubleKey, 22.0);
		UFx(P_0, AssetResourceKeys.ToolWindowTitleBarButtonBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			eFU(P_0, AssetResourceKeys.AutoHideTabItemPaddingNormalThicknessKey, new Thickness(2.0));
			GFA(P_0, AssetResourceKeys.AutoHideTabItemBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.AutoHideTabItemBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.AutoHideTabItemBorderHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.AutoHideTabItemBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.AutoHideTabItemForegroundHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.AutoHideTabItemForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.DockGuideArrowBackgroundBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.DockGuideBackgroundBrushKey, Opacity(SystemColors.ControlLightLightColor, 160));
			GFA(P_0, AssetResourceKeys.DockGuideBorderBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.DockGuideGlyphBackgroundBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.DockGuideGlyphBorderBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.DockGuideGlyphForegroundBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.DockHostBackgroundNormalBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.DockingWindowPreviewBackgroundNormalBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.DockingWindowPreviewBorderNormalBrushKey, SystemColors.HotTrackColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabControlBackgroundActiveFocusedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabControlBackgroundInactiveNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabControlBorderNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabControlForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundActiveFocusedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundInactiveSelectedBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundPreviewActiveFocusedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundPreviewBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundPreviewHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderActiveFocusedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderInactiveSelectedBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderNormalBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderPreviewActiveFocusedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderPreviewBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderPreviewHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundActiveFocusedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundInactiveSelectedBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundPreviewActiveFocusedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundPreviewBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundPreviewHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemBackgroundSelectedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemBorderHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemBorderNormalBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemBorderSelectedBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemForegroundHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemForegroundNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemForegroundSelectedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTitleBarBackgroundActiveBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTitleBarBackgroundInactiveBrushKey, SystemColors.InactiveCaptionColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTitleBarForegroundActiveBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTitleBarForegroundInactiveBrushKey, SystemColors.InactiveCaptionTextColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTitleBarGlyphBackgroundActiveBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ToolWindowContainerTitleBarGlyphBackgroundInactiveBrushKey, SystemColors.InactiveCaptionTextColor);
			return;
		}
		eFU(P_0, AssetResourceKeys.AutoHideTabItemPaddingNormalThicknessKey, new Thickness(0.0, 2.0, 0.0, 2.0));
		GFA(P_0, AssetResourceKeys.AutoHideTabItemBackgroundHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.AutoHideTabItemBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.AutoHideTabItemBorderHoverBrushKey, flag ? YFO(P_0, (md)49, (YK)9) : XFw(P_0, colorRamp3, (md)49, YK.Background, DL.Hover));
		GFA(P_0, AssetResourceKeys.AutoHideTabItemBorderNormalBrushKey, FF0(P_0, (md)49, (oS)3));
		GFA(P_0, AssetResourceKeys.AutoHideTabItemForegroundHoverBrushKey, flag ? YFO(P_0, (md)49, (YK)9) : XFw(P_0, colorRamp3, (md)49, YK.Background, DL.Hover));
		GFA(P_0, AssetResourceKeys.AutoHideTabItemForegroundNormalBrushKey, YFO(P_0, (md)49, (YK)9));
		GFA(P_0, AssetResourceKeys.DockGuideArrowBackgroundBrushKey, YFO(P_0, (md)19, (YK)9));
		GFA(P_0, AssetResourceKeys.DockGuideBackgroundBrushKey, Opacity(FF0(P_0, (md)19), 160));
		GFA(P_0, AssetResourceKeys.DockGuideBorderBrushKey, YFO(P_0, (md)17, YK.Border, (DL)1));
		GFA(P_0, AssetResourceKeys.DockGuideGlyphBackgroundBrushKey, FF0(P_0, (md)19));
		GFA(P_0, AssetResourceKeys.DockGuideGlyphBorderBrushKey, YFO(P_0, (md)19, (YK)9));
		GFA(P_0, AssetResourceKeys.DockGuideGlyphForegroundBrushKey, mF4(P_0, colorRamp, (md)18));
		GFA(P_0, AssetResourceKeys.DockHostBackgroundNormalBrushKey, FF0(P_0, (md)49));
		GFA(P_0, AssetResourceKeys.DockingWindowPreviewBackgroundNormalBrushKey, mF4(P_0, colorRamp4, (md)49, (oS)256));
		GFA(P_0, AssetResourceKeys.DockingWindowPreviewBorderNormalBrushKey, FF0(P_0, (md)17, (oS)3));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerBackgroundNormalBrushKey, FF0(P_0, (md)40));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabControlBackgroundActiveFocusedBrushKey, mF4(P_0, colorRamp3, (md)40, (oS)256));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabControlBorderNormalBrushKey, YFO(P_0, (md)40, YK.Border));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabControlForegroundNormalBrushKey, YFO(P_0, (md)49, (YK)9));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundActiveFocusedBrushKey, mF4(P_0, colorRamp3, (md)40, (oS)256));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundHoverBrushKey, XFw(P_0, colorRamp3, (md)40, YK.Background, DL.Hover, (oS)256));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundPreviewActiveFocusedBrushKey, mF4(P_0, colorRamp2, (md)40, (oS)256));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundPreviewBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundPreviewHoverBrushKey, XFw(P_0, colorRamp2, (md)40, YK.Background, DL.Hover, (oS)256));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderActiveFocusedBrushKey, mF4(P_0, colorRamp3, (md)40, (oS)256));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderHoverBrushKey, XFw(P_0, colorRamp3, (md)40, YK.Background, DL.Hover, (oS)256));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderPreviewActiveFocusedBrushKey, mF4(P_0, colorRamp2, (md)40, (oS)256));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderPreviewBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderPreviewHoverBrushKey, XFw(P_0, colorRamp2, (md)40, YK.Background, DL.Hover, (oS)256));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundActiveFocusedBrushKey, XFw(P_0, colorRamp3, (md)40, (YK)7, DL.Normal, (oS)256));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundDisabledBrushKey, YFO(P_0, (md)49, (YK)11));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundHoverBrushKey, XFw(P_0, colorRamp3, (md)40, (YK)7, DL.Hover, (oS)256));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundNormalBrushKey, YFO(P_0, (md)49, (YK)8));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundPreviewActiveFocusedBrushKey, XFw(P_0, colorRamp2, (md)40, (YK)7, DL.Normal, (oS)256));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundPreviewBrushKey, YFO(P_0, (md)49, (YK)9));
		GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundPreviewHoverBrushKey, XFw(P_0, colorRamp2, (md)40, (YK)7, DL.Hover, (oS)256));
		if (P_0.nWI().IsDarkTheme && P_0.nWI().RequireDarkerBorders)
		{
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabControlBackgroundInactiveNormalBrushKey, YFO(P_0, (md)40, YK.Background, DL.Normal, (oS)4));
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundInactiveSelectedBrushKey, YFO(P_0, (md)40, YK.Background, DL.Normal, (oS)4));
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderInactiveSelectedBrushKey, YFO(P_0, (md)40, YK.Background, DL.Normal, (oS)4));
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundInactiveSelectedBrushKey, YFO(P_0, (md)40, (YK)8, DL.Normal, (oS)4));
		}
		else
		{
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabControlBackgroundInactiveNormalBrushKey, YFO(P_0, (md)40, YK.Border));
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBackgroundInactiveSelectedBrushKey, YFO(P_0, (md)40, YK.Border));
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemBorderInactiveSelectedBrushKey, YFO(P_0, (md)40, YK.Border));
			GFA(P_0, AssetResourceKeys.TabbedMdiContainerTabItemForegroundInactiveSelectedBrushKey, YFO(P_0, (md)40, P_0.nWI().IsDarkTheme ? ((YK)8) : ((YK)9)));
		}
		GFA(P_0, AssetResourceKeys.ToolWindowContainerBackgroundNormalBrushKey, FF0(P_0, (md)48));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemBackgroundHoverBrushKey, FF0(P_0, (md)48, (oS)3));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemBackgroundSelectedBrushKey, FF0(P_0, (md)48));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemBorderHoverBrushKey, FF0(P_0, (md)48, (oS)3));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemBorderSelectedBrushKey, YFO(P_0, (md)48, YK.Border));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemForegroundHoverBrushKey, YFO(P_0, (md)48, (YK)4, DL.Hover));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemForegroundNormalBrushKey, YFO(P_0, (md)48, (YK)9));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTabItemForegroundSelectedBrushKey, flag ? YFO(P_0, (md)48, (YK)8) : mF4(P_0, colorRamp3, (md)48));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTitleBarBackgroundActiveBrushKey, mF4(P_0, colorRamp4, (md)48, (oS)256));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTitleBarBackgroundInactiveBrushKey, FF0(P_0, (md)49));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTitleBarForegroundActiveBrushKey, XFw(P_0, colorRamp4, (md)48, (YK)7, DL.Normal, (oS)256));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTitleBarForegroundInactiveBrushKey, YFO(P_0, (md)49, (YK)8));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTitleBarGlyphBackgroundActiveBrushKey, XFw(P_0, colorRamp4, (md)48, (YK)8, DL.Normal, (oS)256));
		GFA(P_0, AssetResourceKeys.ToolWindowContainerTitleBarGlyphBackgroundInactiveBrushKey, YFO(P_0, (md)49, (YK)9));
	}

	private static void sFE(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		UFx(P_0, AssetResourceKeys.DropDownBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.DropDownBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.DropDownChromeMarginNormalThicknessKey, new Thickness(0.0));
		GFA(P_0, AssetResourceKeys.DropDownInnerBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.DropDownInnerBorderHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.DropDownInnerBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.DropDownInnerBorderPressedBrushKey, Colors.Transparent);
		eFU(P_0, AssetResourceKeys.DropDownMarginNormalThicknessKey, new Thickness(1.0, -1.0, -1.0, -1.0));
		int num = 7;
		int num2 = default(int);
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 7:
				UFx(P_0, AssetResourceKeys.EditBorderNormalCornerRadiusKey, new CornerRadius(0.0));
				eFU(P_0, AssetResourceKeys.EditBorderNormalThicknessKey, new Thickness(1.0));
				eFU(P_0, AssetResourceKeys.EditBoxEditPaddingNormalThicknessKey, new Thickness(1.0, 1.0, 0.0, 1.0));
				num2 = 5;
				goto IL_0005;
			default:
				GFA(P_0, AssetResourceKeys.EditWordWrapGlyphMarginForegroundNormalBrushKey, Color.FromArgb(byte.MaxValue, 43, 145, 175));
				return;
			case 5:
			{
				KFl(P_0, AssetResourceKeys.EditIsAnimationEnabledBooleanKey, _0020: false);
				eFU(P_0, AssetResourceKeys.EditPaddingNormalThicknessKey, new Thickness(2.0, 2.0, 0.0, 2.0));
				ThemeIntent intent = P_0.nWI().Intent;
				ThemeIntent themeIntent = intent;
				if (themeIntent != ThemeIntent.HighContrast)
				{
					flag = !P_0.nWI().IsDarkTheme;
					GFA(P_0, AssetResourceKeys.DropDownBackgroundDisabledBrushKey, Colors.Transparent);
					GFA(P_0, AssetResourceKeys.DropDownBackgroundHoverBrushKey, XFw(P_0, colorRamp, (md)19, YK.Background, DL.Hover));
					GFA(P_0, AssetResourceKeys.DropDownBackgroundNormalBrushKey, Colors.Transparent);
					GFA(P_0, AssetResourceKeys.DropDownBackgroundPressedBrushKey, XFw(P_0, colorRamp, (md)19, YK.Background, DL.Pressed));
					GFA(P_0, AssetResourceKeys.DropDownBorderDisabledBrushKey, Colors.Transparent);
					GFA(P_0, AssetResourceKeys.DropDownBorderHoverBrushKey, XFw(P_0, colorRamp, (md)19, YK.Border, DL.Hover));
					GFA(P_0, AssetResourceKeys.DropDownBorderNormalBrushKey, Colors.Transparent);
					GFA(P_0, AssetResourceKeys.DropDownBorderPressedBrushKey, XFw(P_0, colorRamp, (md)19, YK.Border, DL.Pressed));
					GFA(P_0, AssetResourceKeys.DropDownGlyphBackgroundDisabledBrushKey, YFO(P_0, (md)19, (YK)11));
					num = 6;
					break;
				}
				GFA(P_0, AssetResourceKeys.DropDownBackgroundDisabledBrushKey, Colors.Transparent);
				GFA(P_0, AssetResourceKeys.DropDownBackgroundHoverBrushKey, SystemColors.HighlightColor);
				GFA(P_0, AssetResourceKeys.DropDownBackgroundNormalBrushKey, Colors.Transparent);
				GFA(P_0, AssetResourceKeys.DropDownBackgroundPressedBrushKey, SystemColors.HighlightColor);
				GFA(P_0, AssetResourceKeys.DropDownBorderDisabledBrushKey, Colors.Transparent);
				GFA(P_0, AssetResourceKeys.DropDownBorderHoverBrushKey, SystemColors.HighlightTextColor);
				GFA(P_0, AssetResourceKeys.DropDownBorderNormalBrushKey, Colors.Transparent);
				GFA(P_0, AssetResourceKeys.DropDownBorderPressedBrushKey, SystemColors.HighlightColor);
				GFA(P_0, AssetResourceKeys.DropDownGlyphBackgroundDisabledBrushKey, SystemColors.ControlTextColor);
				GFA(P_0, AssetResourceKeys.DropDownGlyphBackgroundHoverBrushKey, SystemColors.HighlightTextColor);
				GFA(P_0, AssetResourceKeys.DropDownGlyphBackgroundNormalBrushKey, SystemColors.ControlTextColor);
				GFA(P_0, AssetResourceKeys.DropDownGlyphBackgroundPressedBrushKey, SystemColors.HighlightTextColor);
				GFA(P_0, AssetResourceKeys.EditBackgroundDisabledBrushKey, SystemColors.ControlColor);
				num = 2;
				if (Ffd() == null)
				{
					num = 3;
				}
				break;
			}
			case 4:
				GFA(P_0, AssetResourceKeys.EditRulerMarginBackgroundNormalBrushKey, FF0(P_0, (md)19, (oS)3));
				GFA(P_0, AssetResourceKeys.EditRulerMarginForegroundNormalBrushKey, YFO(P_0, (md)19, (YK)9));
				GFA(P_0, AssetResourceKeys.EditWhitespaceForegroundNormalBrushKey, flag ? Color.FromArgb(byte.MaxValue, 20, 72, 82) : Color.FromArgb(byte.MaxValue, 43, 145, 175));
				GFA(P_0, AssetResourceKeys.EditWordWrapGlyphMarginForegroundNormalBrushKey, flag ? Color.FromArgb(byte.MaxValue, 20, 72, 82) : Color.FromArgb(byte.MaxValue, 43, 145, 175));
				return;
			case 2:
				GFA(P_0, AssetResourceKeys.EditBackgroundHoverBrushKey, SystemColors.WindowColor);
				GFA(P_0, AssetResourceKeys.EditBackgroundNormalBrushKey, SystemColors.WindowColor);
				GFA(P_0, AssetResourceKeys.EditBorderDisabledBrushKey, SystemColors.ControlTextColor);
				num = 1;
				if (Ffd() == null)
				{
					break;
				}
				goto IL_0005;
			case 1:
				GFA(P_0, AssetResourceKeys.EditBorderFocusedBrushKey, SystemColors.ControlTextColor);
				GFA(P_0, AssetResourceKeys.EditBorderHoverBrushKey, SystemColors.ControlTextColor);
				GFA(P_0, AssetResourceKeys.EditBorderNormalBrushKey, SystemColors.ControlTextColor);
				GFA(P_0, AssetResourceKeys.EditCaretBackgroundNormalBrushKey, SystemColors.WindowTextColor);
				GFA(P_0, AssetResourceKeys.EditIndicatorMarginBackgroundNormalBrushKey, SystemColors.ControlDarkColor);
				GFA(P_0, AssetResourceKeys.EditLineNumberMarginForegroundNormalBrushKey, Color.FromArgb(byte.MaxValue, 43, 145, 175));
				GFA(P_0, AssetResourceKeys.EditRulerMarginBackgroundNormalBrushKey, SystemColors.ControlColor);
				GFA(P_0, AssetResourceKeys.EditRulerMarginForegroundNormalBrushKey, SystemColors.ControlTextColor);
				GFA(P_0, AssetResourceKeys.EditWhitespaceForegroundNormalBrushKey, Color.FromArgb(byte.MaxValue, 43, 145, 175));
				num = 0;
				if (Ffd() == null)
				{
					break;
				}
				goto IL_0005;
			case 6:
				GFA(P_0, AssetResourceKeys.DropDownGlyphBackgroundHoverBrushKey, XFw(P_0, colorRamp, (md)19, (YK)9, DL.Hover));
				GFA(P_0, AssetResourceKeys.DropDownGlyphBackgroundNormalBrushKey, YFO(P_0, (md)19, (YK)10));
				GFA(P_0, AssetResourceKeys.DropDownGlyphBackgroundPressedBrushKey, XFw(P_0, colorRamp, (md)19, (YK)9, DL.Pressed));
				GFA(P_0, AssetResourceKeys.EditBackgroundDisabledBrushKey, YFO(P_0, (md)19, YK.Background, DL.Disabled));
				GFA(P_0, AssetResourceKeys.EditBackgroundFocusedBrushKey, FF0(P_0, (md)19));
				GFA(P_0, AssetResourceKeys.EditBackgroundHoverBrushKey, FF0(P_0, (md)19));
				GFA(P_0, AssetResourceKeys.EditBackgroundNormalBrushKey, FF0(P_0, (md)19));
				GFA(P_0, AssetResourceKeys.EditBorderDisabledBrushKey, YFO(P_0, (md)19, YK.Border));
				GFA(P_0, AssetResourceKeys.EditBorderFocusedBrushKey, YFO(P_0, (md)19, YK.Border));
				GFA(P_0, AssetResourceKeys.EditBorderHoverBrushKey, YFO(P_0, (md)19, YK.Border));
				GFA(P_0, AssetResourceKeys.EditBorderNormalBrushKey, YFO(P_0, (md)19, YK.Border));
				GFA(P_0, AssetResourceKeys.EditCaretBackgroundNormalBrushKey, YFO(P_0, (md)19, (YK)7));
				GFA(P_0, AssetResourceKeys.EditIndicatorMarginBackgroundNormalBrushKey, FF0(P_0, (md)19, (oS)2));
				GFA(P_0, AssetResourceKeys.EditLineNumberMarginForegroundNormalBrushKey, Color.FromArgb(byte.MaxValue, 43, 145, 175));
				num = 4;
				if (Ffd() == null)
				{
					break;
				}
				goto IL_0005;
			case 3:
				{
					GFA(P_0, AssetResourceKeys.EditBackgroundFocusedBrushKey, SystemColors.WindowColor);
					num = 2;
					break;
				}
				IL_0005:
				num = num2;
				break;
			}
		}
	}

	private static void lFs(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		GFA(P_0, AssetResourceKeys.ExpanderBackgroundNormalBrushKey, Colors.Transparent);
		eFU(P_0, AssetResourceKeys.ExpanderBorderNormalThicknessKey, new Thickness(1.0));
		UFx(P_0, AssetResourceKeys.ExpanderHeaderBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.ExpanderHeaderBorderNormalThicknessKey, new Thickness(1.0));
		GFA(P_0, AssetResourceKeys.ExpanderHeaderInnerBorderHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ExpanderHeaderInnerBorderNormalBrushKey, Colors.Transparent);
		eFU(P_0, AssetResourceKeys.ExpanderHeaderPaddingNormalThicknessKey, new Thickness(5.0, 3.0, 5.0, 3.0));
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent != ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.ExpanderHeaderBackgroundHoverBrushKey, XFw(P_0, colorRamp, (md)21, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.ExpanderHeaderBackgroundNormalBrushKey, FF0(P_0, (md)21));
			GFA(P_0, AssetResourceKeys.ExpanderHeaderBorderHoverBrushKey, XFw(P_0, colorRamp, (md)21, YK.Border, DL.Hover));
			GFA(P_0, AssetResourceKeys.ExpanderHeaderBorderNormalBrushKey, FF0(P_0, (md)21));
			GFA(P_0, AssetResourceKeys.ExpanderHeaderForegroundNormalBrushKey, YFO(P_0, (md)21, (YK)8));
			int num = 1;
			if (Ffd() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				break;
			case 0:
				break;
			}
		}
		else
		{
			GFA(P_0, AssetResourceKeys.ExpanderHeaderBackgroundHoverBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ExpanderHeaderBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ExpanderHeaderBorderHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ExpanderHeaderBorderNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ExpanderHeaderForegroundNormalBrushKey, SystemColors.ControlTextColor);
		}
	}

	private static void gFL(AD P_0)
	{
		double num = P_0.nWI().BaseFontSize ?? SystemFonts.MessageFontSize;
		Func<double, double> func = (double fs) => Math.Round(fs * 2.0, MidpointRounding.AwayFromZero) / 2.0;
		Dictionary<FontSizeKind, double> dictionary = new Dictionary<FontSizeKind, double>();
		dictionary[FontSizeKind.ExtraSmall] = func(num * 0.75);
		dictionary[FontSizeKind.Small] = func(num * 0.875);
		dictionary[FontSizeKind.Medium] = num;
		dictionary[FontSizeKind.Large] = func(num * 1.166);
		dictionary[FontSizeKind.ExtraLarge] = func(num * 1.333);
		dictionary[FontSizeKind.ExtraLarge2] = func(num * 1.6);
		dictionary[FontSizeKind.ExtraLarge3] = Math.Round(num * 2.0, MidpointRounding.AwayFromZero);
		dictionary[FontSizeKind.ExtraLarge4] = Math.Round(num * 2.6, MidpointRounding.AwayFromZero);
		dictionary[FontSizeKind.ExtraLarge5] = Math.Round(num * 3.4, MidpointRounding.AwayFromZero);
		dictionary[FontSizeKind.ExtraLarge6] = Math.Round(num * 4.5, MidpointRounding.AwayFromZero);
		rFr(P_0, AssetResourceKeys.ExtraSmallFontSizeDoubleKey, dictionary[FontSizeKind.ExtraSmall]);
		rFr(P_0, AssetResourceKeys.SmallFontSizeDoubleKey, dictionary[FontSizeKind.Small]);
		rFr(P_0, AssetResourceKeys.MediumFontSizeDoubleKey, dictionary[FontSizeKind.Medium]);
		rFr(P_0, AssetResourceKeys.LargeFontSizeDoubleKey, dictionary[FontSizeKind.Large]);
		rFr(P_0, AssetResourceKeys.ExtraLargeFontSizeDoubleKey, dictionary[FontSizeKind.ExtraLarge]);
		rFr(P_0, AssetResourceKeys.ExtraLarge2FontSizeDoubleKey, dictionary[FontSizeKind.ExtraLarge2]);
		rFr(P_0, AssetResourceKeys.ExtraLarge3FontSizeDoubleKey, dictionary[FontSizeKind.ExtraLarge3]);
		rFr(P_0, AssetResourceKeys.ExtraLarge4FontSizeDoubleKey, dictionary[FontSizeKind.ExtraLarge4]);
		rFr(P_0, AssetResourceKeys.ExtraLarge5FontSizeDoubleKey, dictionary[FontSizeKind.ExtraLarge5]);
		rFr(P_0, AssetResourceKeys.ExtraLarge6FontSizeDoubleKey, dictionary[FontSizeKind.ExtraLarge6]);
		if (P_0.nWI().DefaultFontFamily != null)
		{
			DFZ(P_0, SystemFonts.MessageFontFamilyKey, P_0.nWI().DefaultFontFamily);
		}
		rFr(P_0, AssetResourceKeys.DefaultFontSizeDoubleKey, dictionary[FontSizeKind.Medium]);
		rFr(P_0, AssetResourceKeys.ToolWindowContainerTitleFontSizeDoubleKey, dictionary[P_0.nWI().ToolWindowContainerTitleFontSizeKind]);
		rFr(P_0, AssetResourceKeys.WindowTitleFontSizeDoubleKey, dictionary[P_0.nWI().WindowTitleFontSizeKind]);
	}

	private static void EFd(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		IColorRamp colorRamp2 = P_0.IWZ().GetColorRamp(P_0.nWI().ProgressColorFamilyName);
		GFA(P_0, AssetResourceKeys.GridSplitterBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.GripperBackgroundNormalBrushKey, Colors.Transparent);
		UFx(P_0, AssetResourceKeys.ProgressBarBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.ProgressBarBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.ProgressBarInnerBorderNormalThicknessKey, new Thickness(0.0));
		KFl(P_0, AssetResourceKeys.ProgressBarIsGlassEnabledBooleanKey, _0020: false);
		KFl(P_0, AssetResourceKeys.ProgressBarUseHighlightForIndeterminateIndicatorBooleanKey, _0020: false);
		rFr(P_0, AssetResourceKeys.ShadowOpacityNormalDoubleKey, P_0.nWI().IsDarkTheme ? 0.7 : 0.3);
		rFr(P_0, AssetResourceKeys.ShadowOpacitySoftDoubleKey, P_0.nWI().IsDarkTheme ? 0.3 : 0.1);
		eFU(P_0, AssetResourceKeys.TaskCardBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.TaskColumnBorderNormalThicknessKey, new Thickness(1.0));
		MFW(P_0, AssetResourceKeys.ThemeNameStringKey, P_0.nWI().Name);
		eFU(P_0, AssetResourceKeys.ThumbBorderNormalThicknessKey, new Thickness(1.0));
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.DocumentHeading1ForegroundNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.DocumentHeading2ForegroundNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.DocumentHeading3ForegroundNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.DocumentTextBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.DocumentTextForegroundNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.DocumentViewerBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.DocumentViewerForegroundNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.GripperForegroundNormalBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.GripperHighlightNormalBrushKey, SystemColors.ControlLightColor);
			GFA(P_0, AssetResourceKeys.HyperlinkForegroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.HyperlinkForegroundNormalBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundLowestBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundLowerBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundLowBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundMidLowBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundMidBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundMidHighBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundHighBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundHigherBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundHighestBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundLowestNormalBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundLowerNormalBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundLowNormalBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundMidLowNormalBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundMidNormalBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundMidHighNormalBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundHighNormalBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundHigherNormalBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundHighestNormalBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ProgressBarBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ProgressBarBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ProgressBarForegroundErrorBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ProgressBarForegroundNormalBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ProgressBarForegroundPausedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ProgressBarHighlightErrorBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ProgressBarHighlightNormalBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ProgressBarHighlightPausedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ProgressBarInnerBorderNormalBrushKey, SystemColors.ControlColor);
			KFl(P_0, AssetResourceKeys.ProgressBarIsContinuousBooleanKey, _0020: false);
			eFU(P_0, AssetResourceKeys.ProgressBarPaddingNormalThicknessKey, new Thickness(1.0));
			GFA(P_0, AssetResourceKeys.RatingItemBackgroundActiveBrushKey, SystemColors.HotTrackColor);
			GFA(P_0, AssetResourceKeys.RatingItemBackgroundAverageBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.RatingItemBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.RatingItemBackgroundSelectedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.RatingItemBorderActiveBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.RatingItemBorderAverageBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.RatingItemBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.RatingItemBorderSelectedBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.TaskCardBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.TaskCardBorderNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.TaskColumnBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TaskColumnBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ThumbBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ThumbBorderNormalBrushKey, SystemColors.ControlTextColor);
		}
		else
		{
			GFA(P_0, AssetResourceKeys.DocumentHeading1ForegroundNormalBrushKey, YFO(P_0, (md)19, (YK)8));
			GFA(P_0, AssetResourceKeys.DocumentHeading2ForegroundNormalBrushKey, YFO(P_0, (md)19, (YK)9));
			GFA(P_0, AssetResourceKeys.DocumentHeading3ForegroundNormalBrushKey, YFO(P_0, (md)19, (YK)10));
			GFA(P_0, AssetResourceKeys.DocumentTextBackgroundNormalBrushKey, FF0(P_0, (md)19));
			GFA(P_0, AssetResourceKeys.DocumentTextForegroundNormalBrushKey, YFO(P_0, (md)19, (YK)8));
			GFA(P_0, AssetResourceKeys.DocumentViewerBackgroundNormalBrushKey, FF0(P_0, (md)17));
			GFA(P_0, AssetResourceKeys.DocumentViewerForegroundNormalBrushKey, YFO(P_0, (md)17, (YK)8));
			GFA(P_0, AssetResourceKeys.GripperForegroundNormalBrushKey, FF0(P_0, (md)17, (oS)4));
			GFA(P_0, AssetResourceKeys.GripperHighlightNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.HyperlinkForegroundHoverBrushKey, XFw(P_0, colorRamp, (md)22, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.HyperlinkForegroundNormalBrushKey, mF4(P_0, colorRamp, (md)22));
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundLowestBrushKey, mF4(P_0, colorRamp, (md)26));
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundLowerBrushKey, mF4(P_0, colorRamp, (md)26, (oS)1));
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundLowBrushKey, mF4(P_0, colorRamp, (md)26, (oS)2));
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundMidLowBrushKey, mF4(P_0, colorRamp, (md)26, (oS)3));
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundMidBrushKey, mF4(P_0, colorRamp, (md)26, (oS)4));
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundMidHighBrushKey, mF4(P_0, colorRamp, (md)26, (oS)5));
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundHighBrushKey, mF4(P_0, colorRamp, (md)26, (oS)6));
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundHigherBrushKey, mF4(P_0, colorRamp, (md)26, (oS)7));
			GFA(P_0, AssetResourceKeys.PrimaryAccentBackgroundHighestBrushKey, mF4(P_0, colorRamp, (md)26, (oS)8));
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundLowestNormalBrushKey, XFw(P_0, colorRamp, (md)26, (YK)8));
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundLowerNormalBrushKey, XFw(P_0, colorRamp, (md)26, (YK)8, DL.Normal, (oS)1));
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundLowNormalBrushKey, XFw(P_0, colorRamp, (md)26, (YK)8, DL.Normal, (oS)2));
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundMidLowNormalBrushKey, XFw(P_0, colorRamp, (md)26, (YK)8, DL.Normal, (oS)3));
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundMidNormalBrushKey, XFw(P_0, colorRamp, (md)26, (YK)8, DL.Normal, (oS)4));
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundMidHighNormalBrushKey, XFw(P_0, colorRamp, (md)26, (YK)8, DL.Normal, (oS)5));
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundHighNormalBrushKey, XFw(P_0, colorRamp, (md)26, (YK)8, DL.Normal, (oS)6));
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundHigherNormalBrushKey, XFw(P_0, colorRamp, (md)26, (YK)8, DL.Normal, (oS)7));
			GFA(P_0, AssetResourceKeys.PrimaryAccentForegroundHighestNormalBrushKey, XFw(P_0, colorRamp, (md)26, (YK)8, DL.Normal, (oS)8));
			GFA(P_0, AssetResourceKeys.ProgressBarBackgroundNormalBrushKey, FF0(P_0, (md)33));
			GFA(P_0, AssetResourceKeys.ProgressBarBorderNormalBrushKey, YFO(P_0, (md)33, YK.Border));
			GFA(P_0, AssetResourceKeys.ProgressBarForegroundErrorBrushKey, mF4(P_0, P_0.IWZ().Red, (md)33));
			GFA(P_0, AssetResourceKeys.ProgressBarForegroundNormalBrushKey, mF4(P_0, colorRamp2, (md)33));
			GFA(P_0, AssetResourceKeys.ProgressBarForegroundPausedBrushKey, mF4(P_0, P_0.IWZ().Yellow, (md)33));
			GFA(P_0, AssetResourceKeys.ProgressBarHighlightErrorBrushKey, mF4(P_0, P_0.IWZ().Red, (md)33, (oS)65));
			GFA(P_0, AssetResourceKeys.ProgressBarHighlightNormalBrushKey, mF4(P_0, colorRamp2, (md)33, (oS)65));
			GFA(P_0, AssetResourceKeys.ProgressBarHighlightPausedBrushKey, mF4(P_0, P_0.IWZ().Yellow, (md)33, (oS)65));
			GFA(P_0, AssetResourceKeys.ProgressBarInnerBorderNormalBrushKey, FF0(P_0, (md)33));
			KFl(P_0, AssetResourceKeys.ProgressBarIsContinuousBooleanKey, _0020: true);
			eFU(P_0, AssetResourceKeys.ProgressBarPaddingNormalThicknessKey, new Thickness(0.0));
			GFA(P_0, AssetResourceKeys.RatingItemBackgroundActiveBrushKey, mF4(P_0, P_0.IWZ().Yellow, (md)34, (oS)1));
			GFA(P_0, AssetResourceKeys.RatingItemBackgroundAverageBrushKey, FF0(P_0, (md)34, (oS)2));
			GFA(P_0, AssetResourceKeys.RatingItemBackgroundNormalBrushKey, FF0(P_0, (md)34));
			GFA(P_0, AssetResourceKeys.RatingItemBackgroundSelectedBrushKey, mF4(P_0, P_0.IWZ().Yellow, (md)34));
			GFA(P_0, AssetResourceKeys.RatingItemBorderActiveBrushKey, XFw(P_0, P_0.IWZ().Yellow, (md)34, YK.Border, DL.Normal, (oS)1));
			GFA(P_0, AssetResourceKeys.RatingItemBorderAverageBrushKey, YFO(P_0, (md)34, YK.Border, DL.Normal, (oS)2));
			GFA(P_0, AssetResourceKeys.RatingItemBorderNormalBrushKey, YFO(P_0, (md)34, YK.Border));
			GFA(P_0, AssetResourceKeys.RatingItemBorderSelectedBrushKey, XFw(P_0, P_0.IWZ().Yellow, (md)34, YK.Border));
			GFA(P_0, AssetResourceKeys.TaskCardBackgroundNormalBrushKey, FF0(P_0, (md)41));
			GFA(P_0, AssetResourceKeys.TaskCardBorderNormalBrushKey, YFO(P_0, (md)41, YK.Border));
			GFA(P_0, AssetResourceKeys.TaskColumnBackgroundNormalBrushKey, FF0(P_0, (md)41, (oS)3));
			GFA(P_0, AssetResourceKeys.TaskColumnBorderNormalBrushKey, YFO(P_0, (md)41, YK.Border, DL.Normal, (oS)3));
			GFA(P_0, AssetResourceKeys.ThumbBackgroundNormalBrushKey, FF0(P_0, md.Thumb));
			GFA(P_0, AssetResourceKeys.ThumbBorderNormalBrushKey, YFO(P_0, md.Thumb, YK.Border));
		}
	}

	private static void PFN(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		eFU(P_0, AssetResourceKeys.ListBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.ListHeaderBorderNormalThicknessKey, new Thickness(0.0, 0.0, 1.0, 1.0));
		KFl(P_0, AssetResourceKeys.ListIsGlassEnabledBooleanKey, _0020: false);
		UFx(P_0, AssetResourceKeys.ListItemBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.ListItemBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.ListItemInnerBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.ListItemMarginNormalThicknessKey, new Thickness(0.0));
		eFU(P_0, AssetResourceKeys.ListPaddingNormalThicknessKey, new Thickness(0.0));
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.ListBackgroundDisabledBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ListBorderDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.ListBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ListGridLineBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListTreeLineBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListHeaderBackgroundDisabledBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListHeaderBackgroundHoverBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListHeaderBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListHeaderBackgroundPressedBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListHeaderBackgroundSelectedHoverBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListHeaderBackgroundSelectedNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListHeaderBorderDisabledBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ListHeaderBorderHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ListHeaderBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ListHeaderBorderPressedBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ListHeaderBorderSelectedHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ListHeaderBorderSelectedNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ListHeaderForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ListHeaderGlyphBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListHeaderGlyphBackgroundPressedBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListHeaderGlyphBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ListItemBackgroundDisabledBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListItemBackgroundHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ListItemBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ListItemBackgroundSelectedFocusedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ListItemBackgroundSelectedHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ListItemBackgroundSelectedNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListItemBorderDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ListItemBorderHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ListItemBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ListItemBorderSelectedFocusedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ListItemBorderSelectedHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ListItemBorderSelectedNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ListItemForegroundHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ListItemForegroundSelectedFocusedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ListItemForegroundSelectedHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ListItemForegroundSelectedNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ListRowAlternateBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ListRowBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ListToggleButtonExpanderGlyphBackgroundCheckedBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ListToggleButtonExpanderGlyphBackgroundHoverBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ListToggleButtonExpanderGlyphBackgroundNormalBrushKey, SystemColors.WindowTextColor);
		}
		else
		{
			GFA(P_0, AssetResourceKeys.ListBackgroundDisabledBrushKey, YFO(P_0, (md)23, YK.Background, DL.Disabled));
			GFA(P_0, AssetResourceKeys.ListBackgroundNormalBrushKey, FF0(P_0, (md)23));
			GFA(P_0, AssetResourceKeys.ListBorderDisabledBrushKey, YFO(P_0, (md)23, YK.Border, DL.Disabled));
			GFA(P_0, AssetResourceKeys.ListBorderNormalBrushKey, YFO(P_0, (md)23, YK.Border));
			GFA(P_0, AssetResourceKeys.ListGridLineBackgroundNormalBrushKey, FF0(P_0, (md)23, (oS)2));
			GFA(P_0, AssetResourceKeys.ListTreeLineBackgroundNormalBrushKey, FF0(P_0, (md)23, (oS)5));
			GFA(P_0, AssetResourceKeys.ListHeaderBackgroundDisabledBrushKey, FF0(P_0, (md)23));
			IFC(P_0, AssetResourceKeys.ListHeaderBackgroundHoverBrushKey, P_0.nWI().ListItemBackgroundGradientKind, GradientUsageKind.Hover, XFw(P_0, colorRamp, (md)24, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.ListHeaderBackgroundNormalBrushKey, FF0(P_0, (md)24));
			IFC(P_0, AssetResourceKeys.ListHeaderBackgroundPressedBrushKey, P_0.nWI().ListItemBackgroundGradientKind, GradientUsageKind.Pressed, XFw(P_0, colorRamp, (md)24, YK.Background, DL.Pressed));
			IFC(P_0, AssetResourceKeys.ListHeaderBackgroundSelectedHoverBrushKey, P_0.nWI().ListItemBackgroundGradientKind, GradientUsageKind.Hover, XFw(P_0, colorRamp, (md)24, YK.Background, DL.Hover, (oS)1));
			IFC(P_0, AssetResourceKeys.ListHeaderBackgroundSelectedNormalBrushKey, P_0.nWI().ListItemBackgroundGradientKind, GradientUsageKind.Pressed, FF0(P_0, (md)24, (oS)2));
			GFA(P_0, AssetResourceKeys.ListHeaderBorderDisabledBrushKey, YFO(P_0, (md)24, YK.Border));
			GFA(P_0, AssetResourceKeys.ListHeaderBorderHoverBrushKey, YFO(P_0, (md)24, YK.Border));
			GFA(P_0, AssetResourceKeys.ListHeaderBorderNormalBrushKey, YFO(P_0, (md)24, YK.Border));
			GFA(P_0, AssetResourceKeys.ListHeaderBorderPressedBrushKey, YFO(P_0, (md)24, YK.Border));
			GFA(P_0, AssetResourceKeys.ListHeaderBorderSelectedHoverBrushKey, YFO(P_0, (md)24, YK.Border));
			GFA(P_0, AssetResourceKeys.ListHeaderBorderSelectedNormalBrushKey, YFO(P_0, (md)24, YK.Border));
			GFA(P_0, AssetResourceKeys.ListHeaderForegroundNormalBrushKey, YFO(P_0, (md)23, (YK)9));
			GFA(P_0, AssetResourceKeys.ListHeaderGlyphBackgroundNormalBrushKey, FF0(P_0, (md)23, (oS)4));
			GFA(P_0, AssetResourceKeys.ListHeaderGlyphBackgroundPressedBrushKey, FF0(P_0, (md)23, (oS)6));
			GFA(P_0, AssetResourceKeys.ListHeaderGlyphBorderNormalBrushKey, FF0(P_0, (md)23, (oS)8));
			GFA(P_0, AssetResourceKeys.ListItemBackgroundDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ListItemBackgroundNormalBrushKey, Colors.Transparent);
			IFC(P_0, AssetResourceKeys.ListItemBackgroundSelectedFocusedBrushKey, P_0.nWI().ListItemBackgroundGradientKind, GradientUsageKind.Normal, XFw(P_0, colorRamp, (md)25, YK.Background));
			GFA(P_0, AssetResourceKeys.ListItemBorderDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ListItemBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ListItemBorderSelectedFocusedBrushKey, XFw(P_0, colorRamp, (md)25, YK.Border));
			GFA(P_0, AssetResourceKeys.ListItemForegroundHoverBrushKey, YFO(P_0, (md)25, (YK)8));
			GFA(P_0, AssetResourceKeys.ListItemForegroundSelectedFocusedBrushKey, YFO(P_0, (md)25, (YK)8));
			GFA(P_0, AssetResourceKeys.ListItemForegroundSelectedHoverBrushKey, YFO(P_0, (md)25, (YK)8));
			if (P_0.nWI().ListItemBackgroundStateKindResolved == BackgroundStateKind.Accent)
			{
				IFC(P_0, AssetResourceKeys.ListItemBackgroundHoverBrushKey, P_0.nWI().ListItemBackgroundGradientKind, GradientUsageKind.Hover, XFw(P_0, colorRamp, (md)25, YK.Background, DL.Hover));
				IFC(P_0, AssetResourceKeys.ListItemBackgroundSelectedHoverBrushKey, P_0.nWI().ListItemBackgroundGradientKind, GradientUsageKind.Hover, XFw(P_0, colorRamp, (md)25, YK.Background));
				IFC(P_0, AssetResourceKeys.ListItemBackgroundSelectedNormalBrushKey, P_0.nWI().ListItemBackgroundGradientKind, GradientUsageKind.Normal, FF0(P_0, (md)25, (oS)3));
				GFA(P_0, AssetResourceKeys.ListItemBorderHoverBrushKey, XFw(P_0, colorRamp, (md)25, YK.Border, DL.Hover));
				GFA(P_0, AssetResourceKeys.ListItemBorderSelectedHoverBrushKey, XFw(P_0, colorRamp, (md)25, YK.Border));
				GFA(P_0, AssetResourceKeys.ListItemBorderSelectedNormalBrushKey, FF0(P_0, (md)25, (oS)3));
				GFA(P_0, AssetResourceKeys.ListItemForegroundSelectedNormalBrushKey, YFO(P_0, (md)25, (YK)8, DL.Normal, (oS)3));
			}
			else
			{
				IFC(P_0, AssetResourceKeys.ListItemBackgroundHoverBrushKey, P_0.nWI().ListItemBackgroundGradientKind, GradientUsageKind.Hover, YFO(P_0, (md)25, YK.Background, DL.Hover));
				IFC(P_0, AssetResourceKeys.ListItemBackgroundSelectedHoverBrushKey, P_0.nWI().ListItemBackgroundGradientKind, GradientUsageKind.Hover, XFw(P_0, colorRamp, (md)25, YK.Background));
				IFC(P_0, AssetResourceKeys.ListItemBackgroundSelectedNormalBrushKey, P_0.nWI().ListItemBackgroundGradientKind, GradientUsageKind.Normal, FF0(P_0, (md)25));
				GFA(P_0, AssetResourceKeys.ListItemBorderHoverBrushKey, YFO(P_0, (md)25, YK.Border, DL.Hover));
				GFA(P_0, AssetResourceKeys.ListItemBorderSelectedHoverBrushKey, YFO(P_0, (md)25, YK.Border));
				GFA(P_0, AssetResourceKeys.ListItemBorderSelectedNormalBrushKey, YFO(P_0, (md)25, YK.Border));
				GFA(P_0, AssetResourceKeys.ListItemForegroundSelectedNormalBrushKey, YFO(P_0, (md)25, (YK)8));
			}
			GFA(P_0, AssetResourceKeys.ListRowAlternateBackgroundNormalBrushKey, FF0(P_0, (md)23, (oS)(((!P_0.nWI().IsDarkTheme) ? 1 : 0) | 0x20)));
			GFA(P_0, AssetResourceKeys.ListRowBackgroundNormalBrushKey, FF0(P_0, (md)23));
			if (P_0.nWI().ArrowKind == ArrowKind.Chevron)
			{
				GFA(P_0, AssetResourceKeys.ListToggleButtonExpanderGlyphBackgroundCheckedBrushKey, YFO(P_0, (md)21, (YK)8, DL.Hover));
				GFA(P_0, AssetResourceKeys.ListToggleButtonExpanderGlyphBackgroundHoverBrushKey, YFO(P_0, (md)21, (YK)9));
				GFA(P_0, AssetResourceKeys.ListToggleButtonExpanderGlyphBackgroundNormalBrushKey, YFO(P_0, (md)21, (YK)8, DL.Pressed));
			}
			else
			{
				GFA(P_0, AssetResourceKeys.ListToggleButtonExpanderGlyphBackgroundCheckedBrushKey, YFO(P_0, (md)23, (YK)9));
				GFA(P_0, AssetResourceKeys.ListToggleButtonExpanderGlyphBackgroundHoverBrushKey, mF4(P_0, colorRamp, (md)23, (oS)2));
				GFA(P_0, AssetResourceKeys.ListToggleButtonExpanderGlyphBackgroundNormalBrushKey, YFO(P_0, (md)23, (YK)10));
			}
		}
		GFA(P_0, AssetResourceKeys.ListItemInnerBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ListItemInnerBorderHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ListItemInnerBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ListItemInnerBorderSelectedFocusedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ListItemInnerBorderSelectedHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ListItemInnerBorderSelectedNormalBrushKey, Colors.Transparent);
	}

	private static void FFM(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		GFA(P_0, AssetResourceKeys.NavigationBarSplitterBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.NavigationPaneHeaderHighlightHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.NavigationPaneHeaderHighlightSelectedHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.NavigationPaneHeaderHighlightSelectedNormalBrushKey, Colors.Transparent);
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderAlternateBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderAlternateBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderHeaderAlternateBackgroundNormalBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderHeaderAlternateForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderHeaderBackgroundHoverBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderHeaderBackgroundNormalBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderHeaderForegroundHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderHeaderForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderBackgroundSelectedHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderBackgroundSelectedNormalBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderBorderHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderBorderSelectedHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderBorderSelectedNormalBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderForegroundHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderInnerBorderHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderInnerBorderSelectedHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderInnerBorderSelectedNormalBrushKey, SystemColors.HighlightColor);
		}
		else
		{
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderAlternateBackgroundNormalBrushKey, FF0(P_0, (md)20));
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderAlternateBorderNormalBrushKey, YFO(P_0, (md)20, YK.Border, DL.Normal, (oS)1));
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderBackgroundNormalBrushKey, FF0(P_0, (md)20));
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderBorderNormalBrushKey, YFO(P_0, (md)20, YK.Border));
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderHeaderAlternateBackgroundNormalBrushKey, YFO(P_0, (md)21, YK.Border, DL.Normal, (oS)1));
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderHeaderAlternateForegroundNormalBrushKey, YFO(P_0, (md)21, (YK)3, DL.Normal, (oS)1));
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderHeaderBackgroundHoverBrushKey, XFw(P_0, colorRamp, (md)21, YK.Border, DL.Hover, (oS)2));
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderHeaderBackgroundNormalBrushKey, YFO(P_0, (md)21, YK.Border));
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderHeaderForegroundHoverBrushKey, XFw(P_0, colorRamp, (md)21, (YK)3, DL.Hover, (oS)2));
			GFA(P_0, AssetResourceKeys.ExplorerBarExpanderHeaderForegroundNormalBrushKey, YFO(P_0, (md)21, (YK)3));
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderBackgroundHoverBrushKey, XFw(P_0, colorRamp, (md)31, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderBackgroundSelectedHoverBrushKey, XFw(P_0, colorRamp, (md)31, YK.Background));
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderBackgroundSelectedNormalBrushKey, XFw(P_0, colorRamp, (md)31, YK.Background));
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderBorderHoverBrushKey, XFw(P_0, colorRamp, (md)31, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderBorderSelectedHoverBrushKey, XFw(P_0, colorRamp, (md)31, YK.Background));
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderBorderSelectedNormalBrushKey, XFw(P_0, colorRamp, (md)31, YK.Background));
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderForegroundHoverBrushKey, XFw(P_0, colorRamp, (md)31, (YK)8, DL.Hover));
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderForegroundNormalBrushKey, XFw(P_0, colorRamp, (md)31, (YK)8));
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderInnerBorderHoverBrushKey, XFw(P_0, colorRamp, (md)31, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderInnerBorderSelectedHoverBrushKey, XFw(P_0, colorRamp, (md)31, YK.Background));
			GFA(P_0, AssetResourceKeys.NavigationPaneHeaderInnerBorderSelectedNormalBrushKey, XFw(P_0, colorRamp, (md)31, YK.Background));
		}
	}

	private static void YFK(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		int num = ((P_0.nWI().PopupBorderContrastKind != BorderContrastKind.Lowest) ? 1 : 0);
		double num2 = Math.Max(num, P_0.nWI().MenuPopupCornerRadius - 1.0);
		eFU(P_0, AssetResourceKeys.MenuHeadingPaddingNormalThicknessKey, new Thickness(Math.Round(P_0.nWI().MenuItemIconColumnWidth / 2.0, MidpointRounding.AwayFromZero), P_0.nWI().MenuItemPadding.Top, Math.Round(P_0.nWI().MenuItemPopupColumnWidth / 2.0, MidpointRounding.AwayFromZero), P_0.nWI().MenuItemPadding.Bottom));
		UFx(P_0, AssetResourceKeys.MenuItemBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.MenuItemBorderNormalThicknessKey, new Thickness(num));
		UFx(P_0, AssetResourceKeys.MenuItemGlyphBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.MenuItemGlyphBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.MenuItemIconColumnBorderNormalThicknessKey, new Thickness(0.0, 0.0, 1.0, 0.0));
		rFr(P_0, AssetResourceKeys.MenuItemIconColumnWidthDoubleKey, P_0.nWI().MenuItemIconColumnWidth);
		eFU(P_0, AssetResourceKeys.MenuItemInnerBorderNormalThicknessKey, new Thickness(1.0));
		rFr(P_0, AssetResourceKeys.MenuItemLargeIconColumnWidthDoubleKey, P_0.nWI().MenuItemLargeIconColumnWidth);
		eFU(P_0, AssetResourceKeys.MenuItemPaddingNormalThicknessKey, P_0.nWI().MenuItemPadding);
		rFr(P_0, AssetResourceKeys.MenuItemPopupColumnWidthDoubleKey, P_0.nWI().MenuItemPopupColumnWidth);
		eFU(P_0, AssetResourceKeys.MenuPaddingNormalThicknessKey, new Thickness(0.0, 1.0, 0.0, 1.0));
		UFx(P_0, AssetResourceKeys.MenuPopupBorderNormalCornerRadiusKey, new CornerRadius(P_0.nWI().MenuPopupCornerRadius));
		eFU(P_0, AssetResourceKeys.MenuPopupPaddingNormalThicknessKey, new Thickness(num, num2, num, num2));
		eFU(P_0, AssetResourceKeys.MenuSeparatorMarginNormalThicknessKey, new Thickness(0.0, num2, 0.0, num2));
		UFx(P_0, AssetResourceKeys.PopupBorderNormalCornerRadiusKey, new CornerRadius(P_0.nWI().PopupCornerRadius));
		eFU(P_0, AssetResourceKeys.PopupBorderNormalThicknessKey, new Thickness(num));
		GFA(P_0, AssetResourceKeys.PopupGalleryFilterBackgroundNormalBrushKey, Colors.Transparent);
		rFr(P_0, AssetResourceKeys.PopupShadowDirectionDoubleKey, P_0.nWI().PopupShadowDirection);
		DFa(P_0, AssetResourceKeys.PopupShadowElevationInt32Key, 8);
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.ActionPopupBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ActionPopupBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.MenuBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.MenuBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.MenuForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.MenuEditBackgroundHoverBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.MenuEditBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.MenuHeadingBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.MenuItemBackgroundDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.MenuItemBackgroundHighlightedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.MenuItemBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.MenuItemBorderDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.MenuItemBorderHighlightedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.MenuItemBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.MenuItemDescriptionForegroundHighlightedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.MenuItemDescriptionForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.MenuItemForegroundDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.MenuItemForegroundHighlightedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.MenuItemForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.MenuItemGlyphBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.MenuItemGlyphBorderNormalBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.MenuItemIconColumnBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.MenuItemIconColumnBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.MenuItemInnerBorderDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.MenuItemInnerBorderHighlightedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.MenuItemInnerBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.MenuItemPopupGlyphBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.MenuPopupAnchorBackgroundOpenedBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.MenuPopupBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.MenuPopupBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.MenuPopupInnerBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.MenuSeparatorBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.PopupBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.PopupBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.PopupGalleryFilterForegroundHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.PopupGalleryFilterForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.PopupGripperBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.PopupGripperBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.PopupGripperForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.PopupGripperHighlightNormalBrushKey, SystemColors.ControlColor);
			return;
		}
		GFA(P_0, AssetResourceKeys.ActionPopupBackgroundNormalBrushKey, mF4(P_0, colorRamp, (md)27));
		GFA(P_0, AssetResourceKeys.ActionPopupBorderNormalBrushKey, XFw(P_0, colorRamp, (md)27, YK.Border));
		GFA(P_0, AssetResourceKeys.MenuBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.MenuBorderNormalBrushKey, YFO(P_0, (md)27, YK.Border));
		GFA(P_0, AssetResourceKeys.MenuForegroundNormalBrushKey, YFO(P_0, (md)27, (YK)8));
		GFA(P_0, AssetResourceKeys.MenuEditBackgroundHoverBrushKey, FF0(P_0, (md)19));
		GFA(P_0, AssetResourceKeys.MenuEditBackgroundNormalBrushKey, FF0(P_0, (md)19));
		GFA(P_0, AssetResourceKeys.MenuHeadingBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.MenuItemBackgroundDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.MenuItemBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.MenuItemBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.MenuItemBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.MenuItemDescriptionForegroundNormalBrushKey, YFO(P_0, md.MenuItem, (YK)9));
		GFA(P_0, AssetResourceKeys.MenuItemForegroundDisabledBrushKey, YFO(P_0, md.MenuItem, (YK)11));
		GFA(P_0, AssetResourceKeys.MenuItemForegroundNormalBrushKey, YFO(P_0, md.MenuItem, (YK)8));
		GFA(P_0, AssetResourceKeys.MenuItemIconColumnBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.MenuItemIconColumnBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.MenuItemInnerBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.MenuItemInnerBorderHighlightedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.MenuItemInnerBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.MenuItemPopupGlyphBackgroundNormalBrushKey, YFO(P_0, md.MenuItem, (YK)10));
		GFA(P_0, AssetResourceKeys.MenuPopupAnchorBackgroundOpenedBrushKey, FF0(P_0, (md)32));
		GFA(P_0, AssetResourceKeys.MenuPopupBackgroundNormalBrushKey, FF0(P_0, (md)32));
		GFA(P_0, AssetResourceKeys.MenuPopupBorderNormalBrushKey, YFO(P_0, (md)32, YK.Border));
		GFA(P_0, AssetResourceKeys.MenuPopupInnerBorderNormalBrushKey, Colors.Transparent);
		if (P_0.rWH())
		{
			GFA(P_0, AssetResourceKeys.MenuSeparatorBackgroundNormalBrushKey, FF0(P_0, (md)27, (oS)2));
		}
		else
		{
			GFA(P_0, AssetResourceKeys.MenuSeparatorBackgroundNormalBrushKey, YFO(P_0, (md)27, YK.Border, (DL)32));
		}
		if (P_0.nWI().BarItemBackgroundStateKindResolved == BackgroundStateKind.Accent)
		{
			GFA(P_0, AssetResourceKeys.MenuItemBackgroundHighlightedBrushKey, XFw(P_0, colorRamp, (md)29, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.MenuItemBorderHighlightedBrushKey, XFw(P_0, colorRamp, (md)29, YK.Border, DL.Hover));
			GFA(P_0, AssetResourceKeys.MenuItemDescriptionForegroundHighlightedBrushKey, XFw(P_0, colorRamp, (md)29, (YK)9, DL.Hover));
			GFA(P_0, AssetResourceKeys.MenuItemForegroundHighlightedBrushKey, XFw(P_0, colorRamp, (md)29, (YK)8, DL.Hover));
			GFA(P_0, AssetResourceKeys.MenuItemGlyphBackgroundNormalBrushKey, mF4(P_0, colorRamp, (md)30));
			GFA(P_0, AssetResourceKeys.MenuItemGlyphBorderNormalBrushKey, XFw(P_0, colorRamp, (md)30, YK.Border));
		}
		else
		{
			GFA(P_0, AssetResourceKeys.MenuItemBackgroundHighlightedBrushKey, YFO(P_0, (md)29, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.MenuItemBorderHighlightedBrushKey, YFO(P_0, (md)29, YK.Border, DL.Hover));
			GFA(P_0, AssetResourceKeys.MenuItemDescriptionForegroundHighlightedBrushKey, YFO(P_0, (md)29, (YK)9, DL.Hover));
			GFA(P_0, AssetResourceKeys.MenuItemForegroundHighlightedBrushKey, YFO(P_0, (md)29, (YK)8, DL.Hover));
			GFA(P_0, AssetResourceKeys.MenuItemGlyphBackgroundNormalBrushKey, FF0(P_0, (md)30));
			GFA(P_0, AssetResourceKeys.MenuItemGlyphBorderNormalBrushKey, YFO(P_0, (md)30, YK.Border));
		}
		GFA(P_0, AssetResourceKeys.PopupBackgroundNormalBrushKey, FF0(P_0, (md)32));
		GFA(P_0, AssetResourceKeys.PopupBorderNormalBrushKey, YFO(P_0, (md)32, YK.Border));
		GFA(P_0, AssetResourceKeys.PopupGalleryFilterForegroundHoverBrushKey, YFO(P_0, (md)27, (YK)7));
		GFA(P_0, AssetResourceKeys.PopupGalleryFilterForegroundNormalBrushKey, YFO(P_0, (md)27, (YK)9));
		GFA(P_0, AssetResourceKeys.PopupGripperBackgroundNormalBrushKey, FF0(P_0, (md)27));
		GFA(P_0, AssetResourceKeys.PopupGripperBorderNormalBrushKey, YFO(P_0, (md)27, YK.Border));
		GFA(P_0, AssetResourceKeys.PopupGripperForegroundNormalBrushKey, YFO(P_0, (md)27, YK.Border));
		GFA(P_0, AssetResourceKeys.PopupGripperHighlightNormalBrushKey, FF0(P_0, (md)27));
	}

	private static void zFg(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		IColorRamp colorRamp2 = P_0.IWZ().GetColorRamp(P_0.nWI().WindowColorFamilyName);
		bool flag = P_0.nWI().WindowTitleBarBackgroundKind == WindowTitleBarBackgroundKind.Accent || P_0.nWI().WindowTitleBarBackgroundKind == WindowTitleBarBackgroundKind.AccentWithDimming;
		eFU(P_0, AssetResourceKeys.BackstageTabControlBorderNormalThicknessKey, new Thickness(0.0));
		eFU(P_0, AssetResourceKeys.BackstageTaskTabItemMarginThicknessKey, new Thickness(0.0, 1.0, 1.0, 1.0));
		KFl(P_0, AssetResourceKeys.BackstageWindowIsRibbonVisibleBooleanKey, _0020: false);
		KFl(P_0, AssetResourceKeys.BackstageWindowTitleBarUseAlternateStyleBooleanKey, flag);
		rFr(P_0, AssetResourceKeys.QuickAccessToolBarButtonMinHeightNormalDoubleKey, 28.0);
		rFr(P_0, AssetResourceKeys.QuickAccessToolBarButtonMinWidthNormalDoubleKey, 28.0);
		eFU(P_0, AssetResourceKeys.RibbonGroupSeparatorMarginNormalThicknessKey, new Thickness(0.0, 4.0, 0.0, 4.0));
		eFU(P_0, AssetResourceKeys.RibbonTabControlBorderNormalThicknessKey, new Thickness(0.0, 0.0, 0.0, 1.0));
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.ApplicationMenuBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ApplicationMenuBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ApplicationMenuFooterBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ApplicationMenuHeaderBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.BackstageButtonBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.BackstageButtonBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.BackstageHeaderSeparatorBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.BackstageTabControlBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.BackstageTabControlBorderNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.BackstageTabControlForegroundNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.BackstageTabControlHeaderBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.BackstageTabControlHeaderBorderNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.BackstageTabControlHeaderHighlightNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.BackstageTabItemBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.BackstageTabItemBackgroundSelectedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.BackstageTabItemBorderHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.BackstageTabItemBorderSelectedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.BackstageTabItemDecorationSelectedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.BackstageTabItemForegroundHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.BackstageTabItemForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.BackstageTabItemForegroundSelectedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.BackstageTabItemHighlightSelectedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.BackstageTabItemInnerBorderHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.BackstageTabItemInnerBorderSelectedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.RibbonBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.RibbonContextualTabItemForegroundHoverBrushKey, SystemColors.HotTrackColor);
			GFA(P_0, AssetResourceKeys.RibbonContextualTabItemForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.RibbonGroupBackgroundHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.RibbonGroupForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.RibbonGroupPopupGlyphBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.RibbonGroupSeparatorBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.RibbonSeparatorBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.RibbonTabControlBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.RibbonTabControlBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.RibbonTabItemBackgroundHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.RibbonTabItemBorderSelectedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.RibbonTabItemForegroundHoverBrushKey, SystemColors.HotTrackColor);
			GFA(P_0, AssetResourceKeys.RibbonTabItemForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.RibbonTabSeparatorBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.RibbonToolBarTrayBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.RibbonToolBarTrayBorderNormalBrushKey, SystemColors.ControlTextColor);
			return;
		}
		GFA(P_0, AssetResourceKeys.ApplicationMenuBackgroundNormalBrushKey, FF0(P_0, (md)27, (oS)1));
		GFA(P_0, AssetResourceKeys.ApplicationMenuBorderNormalBrushKey, YFO(P_0, (md)27, YK.Border, DL.Normal, (oS)1));
		GFA(P_0, AssetResourceKeys.ApplicationMenuFooterBackgroundNormalBrushKey, FF0(P_0, (md)27, (oS)2));
		GFA(P_0, AssetResourceKeys.ApplicationMenuHeaderBackgroundNormalBrushKey, FF0(P_0, (md)27, (oS)2));
		if (P_0.nWI().IsDarkTheme)
		{
			GFA(P_0, AssetResourceKeys.BackstageButtonBackgroundNormalBrushKey, FF0(P_0, (md)0));
			GFA(P_0, AssetResourceKeys.BackstageButtonBorderNormalBrushKey, YFO(P_0, (md)0, YK.Border));
			GFA(P_0, AssetResourceKeys.BackstageHeaderSeparatorBorderNormalBrushKey, YFO(P_0, (md)1, YK.Border));
			GFA(P_0, AssetResourceKeys.BackstageTabControlBorderNormalBrushKey, FF0(P_0, (md)1));
			GFA(P_0, AssetResourceKeys.BackstageTabControlHeaderBackgroundNormalBrushKey, FF0(P_0, (md)1));
			GFA(P_0, AssetResourceKeys.BackstageTabControlHeaderBorderNormalBrushKey, FF0(P_0, (md)1));
			GFA(P_0, AssetResourceKeys.BackstageTabItemForegroundNormalBrushKey, YFO(P_0, (md)1, (YK)7));
		}
		else
		{
			GFA(P_0, AssetResourceKeys.BackstageButtonBackgroundNormalBrushKey, FF0(P_0, (md)19));
			GFA(P_0, AssetResourceKeys.BackstageButtonBorderNormalBrushKey, YFO(P_0, (md)19, YK.Border));
			GFA(P_0, AssetResourceKeys.BackstageHeaderSeparatorBorderNormalBrushKey, XFw(P_0, colorRamp2, (md)1, YK.Border, DL.Normal, (oS)320));
			GFA(P_0, AssetResourceKeys.BackstageTabControlBorderNormalBrushKey, mF4(P_0, colorRamp2, (md)1, (oS)256));
			GFA(P_0, AssetResourceKeys.BackstageTabControlHeaderBackgroundNormalBrushKey, mF4(P_0, colorRamp2, (md)1, (oS)256));
			GFA(P_0, AssetResourceKeys.BackstageTabControlHeaderBorderNormalBrushKey, mF4(P_0, colorRamp2, (md)1, (oS)256));
			GFA(P_0, AssetResourceKeys.BackstageTabItemForegroundNormalBrushKey, XFw(P_0, colorRamp2, (md)2, (YK)7, DL.Normal, (oS)256));
		}
		GFA(P_0, AssetResourceKeys.BackstageTabControlBackgroundNormalBrushKey, FF0(P_0, (md)49));
		GFA(P_0, AssetResourceKeys.BackstageTabControlForegroundNormalBrushKey, YFO(P_0, (md)49, (YK)8));
		GFA(P_0, AssetResourceKeys.BackstageTabControlHeaderHighlightNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BackstageTabItemDecorationSelectedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BackstageTabItemBackgroundHoverBrushKey, XFw(P_0, colorRamp2, (md)2, YK.Background, DL.Hover, (oS)256));
		GFA(P_0, AssetResourceKeys.BackstageTabItemBackgroundSelectedBrushKey, XFw(P_0, colorRamp2, (md)2, YK.Background, DL.Pressed, (oS)256));
		GFA(P_0, AssetResourceKeys.BackstageTabItemBorderHoverBrushKey, XFw(P_0, colorRamp2, (md)2, YK.Background, DL.Hover, (oS)256));
		GFA(P_0, AssetResourceKeys.BackstageTabItemBorderSelectedBrushKey, XFw(P_0, colorRamp2, (md)2, YK.Background, DL.Pressed, (oS)256));
		GFA(P_0, AssetResourceKeys.BackstageTabItemForegroundHoverBrushKey, XFw(P_0, colorRamp2, (md)2, (YK)7, DL.Hover, (oS)256));
		GFA(P_0, AssetResourceKeys.BackstageTabItemForegroundSelectedBrushKey, XFw(P_0, colorRamp2, (md)2, (YK)7, DL.Pressed, (oS)256));
		GFA(P_0, AssetResourceKeys.BackstageTabItemHighlightSelectedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BackstageTabItemInnerBorderHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.BackstageTabItemInnerBorderSelectedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.RibbonBackgroundNormalBrushKey, FF0(P_0, (md)35));
		GFA(P_0, AssetResourceKeys.RibbonContextualTabItemForegroundHoverBrushKey, mF4(P_0, colorRamp2, (md)49, (oS)1));
		GFA(P_0, AssetResourceKeys.RibbonContextualTabItemForegroundNormalBrushKey, mF4(P_0, colorRamp2, (md)49));
		GFA(P_0, AssetResourceKeys.RibbonGroupBackgroundHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.RibbonGroupForegroundNormalBrushKey, YFO(P_0, (md)35, (YK)9));
		GFA(P_0, AssetResourceKeys.RibbonGroupPopupGlyphBackgroundNormalBrushKey, YFO(P_0, (md)35, (YK)9));
		GFA(P_0, AssetResourceKeys.RibbonGroupSeparatorBackgroundNormalBrushKey, YFO(P_0, (md)35, YK.Border));
		GFA(P_0, AssetResourceKeys.RibbonSeparatorBackgroundNormalBrushKey, YFO(P_0, (md)35, YK.Border));
		GFA(P_0, AssetResourceKeys.RibbonTabControlBackgroundNormalBrushKey, FF0(P_0, (md)35));
		GFA(P_0, AssetResourceKeys.RibbonTabControlBorderNormalBrushKey, YFO(P_0, (md)35, YK.Border));
		GFA(P_0, AssetResourceKeys.RibbonTabItemBackgroundHoverBrushKey, FF0(P_0, (md)35, (oS)65));
		GFA(P_0, AssetResourceKeys.RibbonTabItemBorderSelectedBrushKey, mF4(P_0, colorRamp2, (md)49));
		GFA(P_0, AssetResourceKeys.RibbonTabItemForegroundHoverBrushKey, YFO(P_0, (md)35, (YK)7));
		GFA(P_0, AssetResourceKeys.RibbonTabItemForegroundNormalBrushKey, YFO(P_0, (md)35, (YK)8));
		GFA(P_0, AssetResourceKeys.RibbonTabSeparatorBackgroundNormalBrushKey, YFO(P_0, (md)35, YK.Border));
		GFA(P_0, AssetResourceKeys.RibbonToolBarTrayBackgroundNormalBrushKey, FF0(P_0, (md)35));
		GFA(P_0, AssetResourceKeys.RibbonToolBarTrayBorderNormalBrushKey, YFO(P_0, (md)35, YK.Border));
	}

	private static void XF8(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		int num = 4;
		UFx(P_0, AssetResourceKeys.ScrollBarButtonBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.ScrollBarButtonBorderNormalThicknessKey, new Thickness(1.0));
		GFA(P_0, AssetResourceKeys.ScrollBarButtonInnerBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ScrollBarButtonInnerBorderHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ScrollBarButtonInnerBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ScrollBarButtonInnerBorderPressedBrushKey, Colors.Transparent);
		KFl(P_0, AssetResourceKeys.ScrollBarIsTransparencyModeEnabledBooleanKey, _0020: false);
		KFl(P_0, AssetResourceKeys.ScrollBarThumbGlyphUseAlternateGeometryBooleanKey, _0020: true);
		GFA(P_0, AssetResourceKeys.ScrollBarThumbGlyphHighlightNormalBrushKey, Colors.Transparent);
		KFl(P_0, AssetResourceKeys.ScrollBarHasButtonsBooleanKey, P_0.nWI().ScrollBarHasButtons);
		eFU(P_0, AssetResourceKeys.ScrollViewerMarginNormalThicknessKey, new Thickness(0.0));
		GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonInnerBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonInnerBorderHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonInnerBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonInnerBorderPressedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbGlyphHighlightNormalBrushKey, Colors.Transparent);
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			eFU(P_0, AssetResourceKeys.ScrollBarHorizontalPaddingNormalThicknessKey, new Thickness(0.0));
			UFx(P_0, AssetResourceKeys.ScrollBarThumbBorderNormalCornerRadiusKey, new CornerRadius(0.0));
			eFU(P_0, AssetResourceKeys.ScrollBarThumbBorderNormalThicknessKey, new Thickness(1.0));
			eFU(P_0, AssetResourceKeys.ScrollBarThumbMarginNormalThicknessKey, new Thickness(0.0));
			eFU(P_0, AssetResourceKeys.ScrollBarVerticalPaddingNormalThicknessKey, new Thickness(0.0));
			GFA(P_0, AssetResourceKeys.ScrollBarHorizontalBackgroundDisabledBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarHorizontalBackgroundNormalBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarHorizontalBackgroundPressedBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarVerticalBackgroundDisabledBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarVerticalBackgroundNormalBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarVerticalBackgroundPressedBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonBorderDisabledBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonBorderHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonBorderPressedBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonGlyphBackgroundDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonGlyphBackgroundHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonGlyphBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonGlyphBackgroundPressedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonHorizontalBackgroundDisabledBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonHorizontalBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonHorizontalBackgroundNormalBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonHorizontalBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonVerticalBackgroundDisabledBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonVerticalBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonVerticalBackgroundNormalBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonVerticalBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbBorderHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbBorderPressedBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbGlyphBackgroundHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbGlyphBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbGlyphBackgroundPressedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbHorizontalBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbHorizontalBackgroundNormalBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbHorizontalBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbVerticalBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbVerticalBackgroundNormalBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbVerticalBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ScrollViewerSpacerBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarHorizontalBackgroundDisabledBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarHorizontalBackgroundNormalBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarHorizontalBackgroundPressedBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarVerticalBackgroundDisabledBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarVerticalBackgroundNormalBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarVerticalBackgroundPressedBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonBorderDisabledBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonBorderHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonBorderPressedBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonGlyphBackgroundDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonGlyphBackgroundHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonGlyphBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonGlyphBackgroundPressedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonHorizontalBackgroundDisabledBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonHorizontalBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonHorizontalBackgroundNormalBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonHorizontalBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonVerticalBackgroundDisabledBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonVerticalBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonVerticalBackgroundNormalBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonVerticalBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbBorderHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbBorderPressedBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbGlyphBackgroundHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbGlyphBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbGlyphBackgroundPressedBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbHorizontalBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbHorizontalBackgroundNormalBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbHorizontalBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbVerticalBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbVerticalBackgroundNormalBrushKey, SystemColors.ScrollBarColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbVerticalBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollViewerSpacerBackgroundNormalBrushKey, SystemColors.ControlColor);
		}
		else
		{
			oS oS = ((P_0.nWI().ScrollBarThumbMargin <= 1.0) ? ((oS)2) : ((oS)3));
			oS oS2 = ((P_0.nWI().ScrollBarThumbMargin <= 1.0) ? ((oS)1) : ((oS)2));
			eFU(P_0, AssetResourceKeys.ScrollBarHorizontalPaddingNormalThicknessKey, P_0.nWI().ScrollBarHasButtons ? new Thickness(0.0) : new Thickness(num, 0.0, num, 0.0));
			UFx(P_0, AssetResourceKeys.ScrollBarThumbBorderNormalCornerRadiusKey, new CornerRadius(P_0.nWI().ScrollBarThumbCornerRadius));
			eFU(P_0, AssetResourceKeys.ScrollBarThumbBorderNormalThicknessKey, new Thickness(0.0));
			eFU(P_0, AssetResourceKeys.ScrollBarThumbMarginNormalThicknessKey, new Thickness(P_0.nWI().ScrollBarThumbMargin));
			eFU(P_0, AssetResourceKeys.ScrollBarVerticalPaddingNormalThicknessKey, P_0.nWI().ScrollBarHasButtons ? new Thickness(0.0) : new Thickness(0.0, num, 0.0, num));
			GFA(P_0, AssetResourceKeys.ScrollBarHorizontalBackgroundDisabledBrushKey, FF0(P_0, (md)36));
			GFA(P_0, AssetResourceKeys.ScrollBarHorizontalBackgroundNormalBrushKey, FF0(P_0, (md)36));
			GFA(P_0, AssetResourceKeys.ScrollBarHorizontalBackgroundPressedBrushKey, FF0(P_0, (md)36));
			GFA(P_0, AssetResourceKeys.ScrollBarVerticalBackgroundDisabledBrushKey, FF0(P_0, (md)36));
			GFA(P_0, AssetResourceKeys.ScrollBarVerticalBackgroundNormalBrushKey, FF0(P_0, (md)36));
			GFA(P_0, AssetResourceKeys.ScrollBarVerticalBackgroundPressedBrushKey, FF0(P_0, (md)36));
			GFA(P_0, AssetResourceKeys.ScrollBarButtonBorderDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonBorderHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonBorderPressedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonGlyphBackgroundDisabledBrushKey, YFO(P_0, (md)36, (YK)11));
			GFA(P_0, AssetResourceKeys.ScrollBarButtonGlyphBackgroundHoverBrushKey, XFw(P_0, colorRamp, (md)36, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.ScrollBarButtonGlyphBackgroundNormalBrushKey, YFO(P_0, (md)36, (YK)10));
			GFA(P_0, AssetResourceKeys.ScrollBarButtonGlyphBackgroundPressedBrushKey, XFw(P_0, colorRamp, (md)36, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.ScrollBarButtonHorizontalBackgroundDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonHorizontalBackgroundHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonHorizontalBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonHorizontalBackgroundPressedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonVerticalBackgroundDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonVerticalBackgroundHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonVerticalBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarButtonVerticalBackgroundPressedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbBorderHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbBorderPressedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbGlyphBackgroundHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbGlyphBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbGlyphBackgroundPressedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ScrollBarThumbHorizontalBackgroundHoverBrushKey, YFO(P_0, (md)36, YK.Background, DL.Hover, oS));
			GFA(P_0, AssetResourceKeys.ScrollBarThumbHorizontalBackgroundNormalBrushKey, FF0(P_0, (md)36, oS));
			GFA(P_0, AssetResourceKeys.ScrollBarThumbHorizontalBackgroundPressedBrushKey, YFO(P_0, (md)36, YK.Background, DL.Pressed, oS));
			GFA(P_0, AssetResourceKeys.ScrollBarThumbVerticalBackgroundHoverBrushKey, YFO(P_0, (md)36, YK.Background, DL.Hover, oS));
			GFA(P_0, AssetResourceKeys.ScrollBarThumbVerticalBackgroundNormalBrushKey, FF0(P_0, (md)36, oS));
			GFA(P_0, AssetResourceKeys.ScrollBarThumbVerticalBackgroundPressedBrushKey, YFO(P_0, (md)36, YK.Background, DL.Pressed, oS));
			GFA(P_0, AssetResourceKeys.ScrollViewerSpacerBackgroundNormalBrushKey, FF0(P_0, (md)36));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarHorizontalBackgroundDisabledBrushKey, FF0(P_0, (md)52));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarHorizontalBackgroundNormalBrushKey, FF0(P_0, (md)52));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarHorizontalBackgroundPressedBrushKey, FF0(P_0, (md)52));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarVerticalBackgroundDisabledBrushKey, FF0(P_0, (md)52));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarVerticalBackgroundNormalBrushKey, FF0(P_0, (md)52));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarVerticalBackgroundPressedBrushKey, FF0(P_0, (md)52));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonBorderDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonBorderHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonBorderPressedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonGlyphBackgroundDisabledBrushKey, YFO(P_0, (md)36, (YK)11));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonGlyphBackgroundHoverBrushKey, XFw(P_0, colorRamp, (md)36, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonGlyphBackgroundNormalBrushKey, YFO(P_0, (md)36, (YK)10));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonGlyphBackgroundPressedBrushKey, XFw(P_0, colorRamp, (md)36, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonHorizontalBackgroundDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonHorizontalBackgroundHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonHorizontalBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonHorizontalBackgroundPressedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonVerticalBackgroundDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonVerticalBackgroundHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonVerticalBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarButtonVerticalBackgroundPressedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbBorderHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbBorderPressedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbGlyphBackgroundHoverBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbGlyphBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbGlyphBackgroundPressedBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbHorizontalBackgroundHoverBrushKey, YFO(P_0, (md)52, YK.Background, DL.Hover, oS2));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbHorizontalBackgroundNormalBrushKey, FF0(P_0, (md)52, oS2));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbHorizontalBackgroundPressedBrushKey, YFO(P_0, (md)52, YK.Background, DL.Pressed, oS2));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbVerticalBackgroundHoverBrushKey, YFO(P_0, (md)52, YK.Background, DL.Hover, oS2));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbVerticalBackgroundNormalBrushKey, FF0(P_0, (md)52, oS2));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollBarThumbVerticalBackgroundPressedBrushKey, YFO(P_0, (md)52, YK.Background, DL.Pressed, oS2));
			GFA(P_0, AssetResourceKeys.WorkspaceScrollViewerSpacerBackgroundNormalBrushKey, FF0(P_0, (md)52));
		}
	}

	private static void oFD(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		eFU(P_0, AssetResourceKeys.SliderBorderNormalThicknessKey, new Thickness(1.0));
		GFA(P_0, AssetResourceKeys.SliderThumbHorizontalInnerBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.SliderThumbHorizontalInnerBorderFocusedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.SliderThumbHorizontalInnerBorderHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.SliderThumbHorizontalInnerBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.SliderThumbHorizontalInnerBorderPressedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.SliderThumbVerticalInnerBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.SliderThumbVerticalInnerBorderFocusedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.SliderThumbVerticalInnerBorderHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.SliderThumbVerticalInnerBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.SliderThumbVerticalInnerBorderPressedBrushKey, Colors.Transparent);
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.SliderForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.SliderSelectionBackgroundNormalBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.SliderSelectionBorderNormalBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBackgroundDisabledBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBackgroundFocusedBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBorderDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBorderFocusedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBorderHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBorderPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBackgroundDisabledBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBackgroundFocusedBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBorderDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBorderFocusedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBorderHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBorderPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.SliderTrackHorizontalBackgroundNormalBrushKey, SystemColors.ControlLightColor);
			GFA(P_0, AssetResourceKeys.SliderTrackHorizontalBorderNormalBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.SliderTrackVerticalBackgroundNormalBrushKey, SystemColors.ControlLightColor);
			GFA(P_0, AssetResourceKeys.SliderTrackVerticalBorderNormalBrushKey, SystemColors.ControlDarkColor);
		}
		else
		{
			GFA(P_0, AssetResourceKeys.SliderForegroundNormalBrushKey, YFO(P_0, (md)37, (YK)11));
			GFA(P_0, AssetResourceKeys.SliderSelectionBackgroundNormalBrushKey, mF4(P_0, colorRamp, (md)37));
			GFA(P_0, AssetResourceKeys.SliderSelectionBorderNormalBrushKey, XFw(P_0, colorRamp, (md)37, YK.Border));
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBackgroundDisabledBrushKey, YFO(P_0, (md)6, YK.Background, DL.Disabled));
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBackgroundFocusedBrushKey, XFw(P_0, colorRamp, (md)6, YK.Background, (DL)1));
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBackgroundHoverBrushKey, XFw(P_0, colorRamp, (md)6, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBackgroundNormalBrushKey, YFO(P_0, (md)6, YK.Background));
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBackgroundPressedBrushKey, XFw(P_0, colorRamp, (md)6, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBorderDisabledBrushKey, YFO(P_0, (md)6, YK.Border, DL.Disabled));
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBorderFocusedBrushKey, XFw(P_0, colorRamp, (md)6, YK.Border, (DL)1));
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBorderHoverBrushKey, XFw(P_0, colorRamp, (md)6, YK.Border, DL.Hover));
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBorderNormalBrushKey, YFO(P_0, (md)6, YK.Border));
			GFA(P_0, AssetResourceKeys.SliderThumbHorizontalBorderPressedBrushKey, XFw(P_0, colorRamp, (md)6, YK.Border, DL.Pressed));
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBackgroundDisabledBrushKey, YFO(P_0, (md)6, YK.Background, DL.Disabled));
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBackgroundFocusedBrushKey, XFw(P_0, colorRamp, (md)6, YK.Background, (DL)1));
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBackgroundHoverBrushKey, XFw(P_0, colorRamp, (md)6, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBackgroundNormalBrushKey, YFO(P_0, (md)6, YK.Background));
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBackgroundPressedBrushKey, XFw(P_0, colorRamp, (md)6, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBorderDisabledBrushKey, YFO(P_0, (md)6, YK.Border, DL.Disabled));
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBorderFocusedBrushKey, XFw(P_0, colorRamp, (md)6, YK.Border, (DL)1));
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBorderHoverBrushKey, XFw(P_0, colorRamp, (md)6, YK.Border, DL.Hover));
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBorderNormalBrushKey, YFO(P_0, (md)6, YK.Border));
			GFA(P_0, AssetResourceKeys.SliderThumbVerticalBorderPressedBrushKey, XFw(P_0, colorRamp, (md)6, YK.Border, DL.Pressed));
			GFA(P_0, AssetResourceKeys.SliderTrackHorizontalBackgroundNormalBrushKey, FF0(P_0, (md)37));
			GFA(P_0, AssetResourceKeys.SliderTrackHorizontalBorderNormalBrushKey, YFO(P_0, (md)37, YK.Border));
			GFA(P_0, AssetResourceKeys.SliderTrackVerticalBackgroundNormalBrushKey, FF0(P_0, (md)37));
			GFA(P_0, AssetResourceKeys.SliderTrackVerticalBorderNormalBrushKey, YFO(P_0, (md)37, YK.Border));
		}
	}

	private static void AFP(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		eFU(P_0, AssetResourceKeys.StatusBarItemPaddingNormalThicknessKey, new Thickness(10.0, 3.0, 10.0, 3.0));
		eFU(P_0, AssetResourceKeys.StatusBarSeparatorBorderNormalThicknessKey, new Thickness(1.0, 0.0, 1.0, 0.0));
		GFA(P_0, AssetResourceKeys.StatusBarInnerBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.StatusBarItemBackgroundNormalBrushKey, Colors.Transparent);
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.StatusBarBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.StatusBarBorderNormalBrushKey, SystemColors.ControlDarkColor);
			eFU(P_0, AssetResourceKeys.StatusBarBorderNormalThicknessKey, new Thickness(0.0, 1.0, 0.0, 0.0));
			GFA(P_0, AssetResourceKeys.StatusBarButtonGroupBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.StatusBarButtonGroupBorderNormalBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.StatusBarForegroundDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.StatusBarForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.StatusBarGripperForegroundNormalBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.StatusBarGripperHighlightNormalBrushKey, SystemColors.ControlLightColor);
			GFA(P_0, AssetResourceKeys.StatusBarHyperlinkForegroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.StatusBarHyperlinkForegroundNormalBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.StatusBarSeparatorBackgroundNormalBrushKey, SystemColors.ControlDarkColor);
			GFA(P_0, AssetResourceKeys.StatusBarSeparatorBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.StatusBarSliderThumbForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.StatusBarSliderThumbHorizontalBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.StatusBarSliderThumbHorizontalBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.StatusBarSliderThumbHorizontalHighlightNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.StatusBarSliderTrackHorizontalBackgroundNormalBrushKey, SystemColors.ControlDarkColor);
			KFl(P_0, AssetResourceKeys.StatusBarUseMonochromeImagesBooleanKey, _0020: false);
			return;
		}
		StatusBarBackgroundKind statusBarBackgroundKind = P_0.nWI().StatusBarBackgroundKind;
		StatusBarBackgroundKind statusBarBackgroundKind2 = statusBarBackgroundKind;
		if (statusBarBackgroundKind2 == StatusBarBackgroundKind.Accent)
		{
			GFA(P_0, AssetResourceKeys.StatusBarBackgroundNormalBrushKey, mF4(P_0, colorRamp, md.StatusBar, (oS)256));
			GFA(P_0, AssetResourceKeys.StatusBarBorderNormalBrushKey, mF4(P_0, colorRamp, md.StatusBar, (oS)256));
			eFU(P_0, AssetResourceKeys.StatusBarBorderNormalThicknessKey, new Thickness(0.0));
			GFA(P_0, AssetResourceKeys.StatusBarButtonGroupBackgroundNormalBrushKey, mF4(P_0, colorRamp, md.StatusBar, (oS)321));
			GFA(P_0, AssetResourceKeys.StatusBarButtonGroupBorderNormalBrushKey, mF4(P_0, colorRamp, md.StatusBar, (oS)321));
			GFA(P_0, AssetResourceKeys.StatusBarForegroundDisabledBrushKey, XFw(P_0, colorRamp, md.StatusBar, (YK)11, DL.Normal, (oS)256));
			GFA(P_0, AssetResourceKeys.StatusBarForegroundNormalBrushKey, XFw(P_0, colorRamp, md.StatusBar, (YK)7, DL.Normal, (oS)256));
			GFA(P_0, AssetResourceKeys.StatusBarGripperForegroundNormalBrushKey, Color.FromArgb(128, byte.MaxValue, byte.MaxValue, byte.MaxValue));
			GFA(P_0, AssetResourceKeys.StatusBarGripperHighlightNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.StatusBarHyperlinkForegroundHoverBrushKey, XFw(P_0, colorRamp, md.StatusBar, (YK)8, DL.Normal, (oS)256));
			GFA(P_0, AssetResourceKeys.StatusBarHyperlinkForegroundNormalBrushKey, XFw(P_0, colorRamp, md.StatusBar, (YK)7, DL.Normal, (oS)256));
			GFA(P_0, AssetResourceKeys.StatusBarSeparatorBackgroundNormalBrushKey, mF4(P_0, colorRamp, md.StatusBar, (oS)321));
			GFA(P_0, AssetResourceKeys.StatusBarSeparatorBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.StatusBarSliderThumbForegroundNormalBrushKey, XFw(P_0, colorRamp, md.StatusBar, (YK)8, DL.Normal, (oS)256));
			GFA(P_0, AssetResourceKeys.StatusBarSliderThumbHorizontalBackgroundNormalBrushKey, XFw(P_0, colorRamp, md.StatusBar, (YK)8, DL.Normal, (oS)256));
			GFA(P_0, AssetResourceKeys.StatusBarSliderThumbHorizontalBorderNormalBrushKey, XFw(P_0, colorRamp, md.StatusBar, (YK)8, DL.Normal, (oS)256));
			GFA(P_0, AssetResourceKeys.StatusBarSliderThumbHorizontalHighlightNormalBrushKey, XFw(P_0, colorRamp, md.StatusBar, (YK)7, DL.Normal, (oS)256));
			GFA(P_0, AssetResourceKeys.StatusBarSliderTrackHorizontalBackgroundNormalBrushKey, XFw(P_0, colorRamp, md.StatusBar, (YK)9, DL.Normal, (oS)256));
			KFl(P_0, AssetResourceKeys.StatusBarUseMonochromeImagesBooleanKey, _0020: true);
		}
		else
		{
			GFA(P_0, AssetResourceKeys.StatusBarBackgroundNormalBrushKey, FF0(P_0, md.StatusBar));
			GFA(P_0, AssetResourceKeys.StatusBarBorderNormalBrushKey, YFO(P_0, md.StatusBar, YK.Border));
			eFU(P_0, AssetResourceKeys.StatusBarBorderNormalThicknessKey, new Thickness(0.0, 1.0, 0.0, 0.0));
			GFA(P_0, AssetResourceKeys.StatusBarButtonGroupBackgroundNormalBrushKey, FF0(P_0, md.StatusBar, (oS)1));
			GFA(P_0, AssetResourceKeys.StatusBarButtonGroupBorderNormalBrushKey, FF0(P_0, md.StatusBar, (oS)1));
			GFA(P_0, AssetResourceKeys.StatusBarForegroundDisabledBrushKey, YFO(P_0, md.StatusBar, (YK)11));
			GFA(P_0, AssetResourceKeys.StatusBarForegroundNormalBrushKey, YFO(P_0, md.StatusBar, (YK)9));
			GFA(P_0, AssetResourceKeys.StatusBarGripperForegroundNormalBrushKey, FF0(P_0, md.StatusBar, (oS)4));
			GFA(P_0, AssetResourceKeys.StatusBarGripperHighlightNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.StatusBarHyperlinkForegroundHoverBrushKey, XFw(P_0, colorRamp, (md)22, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.StatusBarHyperlinkForegroundNormalBrushKey, mF4(P_0, colorRamp, (md)22));
			GFA(P_0, AssetResourceKeys.StatusBarSeparatorBackgroundNormalBrushKey, YFO(P_0, md.StatusBar, YK.Border));
			GFA(P_0, AssetResourceKeys.StatusBarSeparatorBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.StatusBarSliderThumbForegroundNormalBrushKey, YFO(P_0, md.StatusBar, (YK)10));
			GFA(P_0, AssetResourceKeys.StatusBarSliderThumbHorizontalBackgroundNormalBrushKey, YFO(P_0, md.StatusBar, (YK)10));
			GFA(P_0, AssetResourceKeys.StatusBarSliderThumbHorizontalBorderNormalBrushKey, YFO(P_0, md.StatusBar, (YK)10));
			GFA(P_0, AssetResourceKeys.StatusBarSliderThumbHorizontalHighlightNormalBrushKey, YFO(P_0, md.StatusBar, (YK)8));
			GFA(P_0, AssetResourceKeys.StatusBarSliderTrackHorizontalBackgroundNormalBrushKey, YFO(P_0, md.StatusBar, (YK)11));
			KFl(P_0, AssetResourceKeys.StatusBarUseMonochromeImagesBooleanKey, _0020: false);
		}
	}

	private static void wFG(AD P_0)
	{
		eFU(P_0, AssetResourceKeys.TabControlBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.TabControlHeaderBottomMarginNormalThicknessKey, new Thickness(2.0, 0.0, 2.0, 2.0));
		eFU(P_0, AssetResourceKeys.TabControlHeaderLeftMarginNormalThicknessKey, new Thickness(2.0, 2.0, 0.0, 2.0));
		eFU(P_0, AssetResourceKeys.TabControlHeaderRightMarginNormalThicknessKey, new Thickness(0.0, 2.0, 2.0, 2.0));
		eFU(P_0, AssetResourceKeys.TabControlHeaderTopMarginNormalThicknessKey, new Thickness(2.0, 2.0, 2.0, 0.0));
		eFU(P_0, AssetResourceKeys.TabControlPaddingNormalThicknessKey, new Thickness(4.0));
		UFx(P_0, AssetResourceKeys.TabItemBorderNormalCornerRadiusKey, new CornerRadius(P_0.nWI().TabCornerRadius, P_0.nWI().TabCornerRadius, 0.0, 0.0));
		eFU(P_0, AssetResourceKeys.TabItemBorderNormalThicknessKey, new Thickness(1.0, 1.0, 1.0, 0.0));
		eFU(P_0, AssetResourceKeys.TabItemPaddingNormalThicknessKey, new Thickness(6.0, 1.0, 6.0, 1.0));
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.TabControlBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabControlBorderDisabledBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.TabControlBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.TabControlBottomBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabControlLeftBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabControlNewTabButtonForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.TabControlRightBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabControlTopBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabItemBackgroundDisabledBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabItemBackgroundHoverBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabItemBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabItemBackgroundSelectedNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.TabItemBorderDisabledBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.TabItemBorderHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.TabItemBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.TabItemBorderSelectedNormalBrushKey, SystemColors.ControlTextColor);
		}
		else
		{
			GFA(P_0, AssetResourceKeys.TabControlBackgroundNormalBrushKey, FF0(P_0, (md)39));
			GFA(P_0, AssetResourceKeys.TabControlBorderDisabledBrushKey, YFO(P_0, (md)39, YK.Border));
			GFA(P_0, AssetResourceKeys.TabControlBorderNormalBrushKey, YFO(P_0, (md)39, YK.Border));
			GFA(P_0, AssetResourceKeys.TabControlBottomBackgroundNormalBrushKey, FF0(P_0, (md)39));
			GFA(P_0, AssetResourceKeys.TabControlLeftBackgroundNormalBrushKey, FF0(P_0, (md)39));
			GFA(P_0, AssetResourceKeys.TabControlNewTabButtonForegroundNormalBrushKey, YFO(P_0, (md)39, (YK)9));
			GFA(P_0, AssetResourceKeys.TabControlRightBackgroundNormalBrushKey, FF0(P_0, (md)39));
			GFA(P_0, AssetResourceKeys.TabControlTopBackgroundNormalBrushKey, FF0(P_0, (md)39));
			GFA(P_0, AssetResourceKeys.TabItemBackgroundDisabledBrushKey, FF0(P_0, (md)39, (oS)1));
			GFA(P_0, AssetResourceKeys.TabItemBackgroundHoverBrushKey, FF0(P_0, (md)39));
			GFA(P_0, AssetResourceKeys.TabItemBackgroundNormalBrushKey, FF0(P_0, (md)39, (oS)1));
			GFA(P_0, AssetResourceKeys.TabItemBackgroundSelectedNormalBrushKey, FF0(P_0, (md)39));
			GFA(P_0, AssetResourceKeys.TabItemBorderDisabledBrushKey, YFO(P_0, (md)39, YK.Border));
			GFA(P_0, AssetResourceKeys.TabItemBorderHoverBrushKey, YFO(P_0, (md)39, YK.Border));
			GFA(P_0, AssetResourceKeys.TabItemBorderNormalBrushKey, YFO(P_0, (md)39, YK.Border));
			GFA(P_0, AssetResourceKeys.TabItemBorderSelectedNormalBrushKey, YFO(P_0, (md)39, YK.Border));
		}
	}

	private static void tF1(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().PrimaryAccentColorFamilyName);
		UFx(P_0, AssetResourceKeys.ToolBarBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.ToolBarBorderNormalThicknessKey, new Thickness(1.0));
		UFx(P_0, AssetResourceKeys.ToolBarButtonBorderNormalCornerRadiusKey, new CornerRadius(P_0.nWI().ToolBarButtonCornerRadius));
		eFU(P_0, AssetResourceKeys.ToolBarButtonBorderNormalThicknessKey, new Thickness(1.0));
		UFx(P_0, AssetResourceKeys.ToolBarDropDownBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		UFx(P_0, AssetResourceKeys.ToolBarEditBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.ToolBarEditBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.ToolBarHorizontalMarginNormalThicknessKey, new Thickness(1.0, 1.0, 0.0, 1.0));
		eFU(P_0, AssetResourceKeys.ToolBarHorizontalPaddingNormalThicknessKey, new Thickness(2.0, 1.0, 2.0, 1.0));
		eFU(P_0, AssetResourceKeys.ToolBarVerticalMarginNormalThicknessKey, new Thickness(1.0, 1.0, 1.0, 0.0));
		eFU(P_0, AssetResourceKeys.ToolBarVerticalPaddingNormalThicknessKey, new Thickness(1.0, 2.0, 1.0, 2.0));
		GFA(P_0, AssetResourceKeys.ToolBarButtonGroupBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonGroupBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonInnerBorderCheckedHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonInnerBorderCheckedNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonInnerBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonInnerBorderHoverBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonInnerBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonInnerBorderOpenedBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonInnerBorderPressedBrushKey, Colors.Transparent);
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			GFA(P_0, AssetResourceKeys.ToolBarButtonBackgroundCheckedHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBackgroundCheckedNormalBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBackgroundDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBackgroundOpenedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderCheckedHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderCheckedNormalBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderOpenedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonForegroundDisabledBrushKey, SystemColors.GrayTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonForegroundHoverBrushKey, SystemColors.HighlightTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundCheckedHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundCheckedNormalBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundOpenedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonRoundBackgroundDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ToolBarButtonRoundBackgroundHoverBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarButtonRoundBackgroundNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ToolBarButtonRoundBackgroundPressedBrushKey, SystemColors.HighlightColor);
			GFA(P_0, AssetResourceKeys.ToolBarDropDownBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ToolBarDropDownBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarDropDownGlyphBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarEditBackgroundDisabledBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ToolBarEditBackgroundHoverBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ToolBarEditBackgroundNormalBrushKey, SystemColors.WindowColor);
			GFA(P_0, AssetResourceKeys.ToolBarEditBorderDisabledBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarEditBorderHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarEditBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarEditDropDownButtonBorderHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarEditDropDownButtonBorderPressedBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarEditForegroundNormalBrushKey, SystemColors.WindowTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarGalleryBackgroundHoverBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ToolBarGalleryBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ToolBarGalleryBorderHoverBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarGalleryBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarGalleryButtonBackgroundDisabledBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ToolBarGalleryButtonBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ToolBarGalleryButtonBorderDisabledBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarGalleryButtonBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarGalleryButtonInnerBorderDisabledBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ToolBarGalleryButtonInnerBorderNormalBrushKey, Colors.Transparent);
			GFA(P_0, AssetResourceKeys.ToolBarGripperForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarHorizontalBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ToolBarHorizontalBorderNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarMenuForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarOverflowButtonForegroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarOverflowButtonHorizontalBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ToolBarOverflowButtonVerticalBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ToolBarSeparatorBackgroundNormalBrushKey, SystemColors.ControlTextColor);
			GFA(P_0, AssetResourceKeys.ToolBarTrayBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ToolBarVerticalBackgroundNormalBrushKey, SystemColors.ControlColor);
			GFA(P_0, AssetResourceKeys.ToolBarVerticalBorderNormalBrushKey, SystemColors.ControlTextColor);
			return;
		}
		GFA(P_0, AssetResourceKeys.ToolBarButtonBackgroundDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonForegroundDisabledBrushKey, YFO(P_0, (md)44, (YK)11));
		GFA(P_0, AssetResourceKeys.ToolBarButtonForegroundNormalBrushKey, YFO(P_0, (md)44, (YK)8));
		GFA(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonRoundBackgroundDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarButtonRoundBackgroundNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarDropDownBackgroundNormalBrushKey, FF0(P_0, md.ToolBar));
		GFA(P_0, AssetResourceKeys.ToolBarDropDownBorderNormalBrushKey, YFO(P_0, (md)27, YK.Border));
		GFA(P_0, AssetResourceKeys.ToolBarDropDownGlyphBackgroundNormalBrushKey, YFO(P_0, (md)27, (YK)4));
		GFA(P_0, AssetResourceKeys.ToolBarEditBackgroundDisabledBrushKey, YFO(P_0, (md)19, YK.Background, DL.Disabled));
		GFA(P_0, AssetResourceKeys.ToolBarEditBackgroundHoverBrushKey, FF0(P_0, (md)19));
		GFA(P_0, AssetResourceKeys.ToolBarEditBackgroundNormalBrushKey, FF0(P_0, (md)19));
		GFA(P_0, AssetResourceKeys.ToolBarEditBorderDisabledBrushKey, YFO(P_0, (md)19, YK.Border, (DL)32));
		GFA(P_0, AssetResourceKeys.ToolBarEditBorderHoverBrushKey, YFO(P_0, (md)19, YK.Border, (DL)32));
		GFA(P_0, AssetResourceKeys.ToolBarEditBorderNormalBrushKey, YFO(P_0, (md)19, YK.Border, (DL)32));
		GFA(P_0, AssetResourceKeys.ToolBarEditForegroundNormalBrushKey, YFO(P_0, (md)19, (YK)8));
		GFA(P_0, AssetResourceKeys.ToolBarGalleryBackgroundHoverBrushKey, YFO(P_0, (md)46, YK.Background, DL.Hover));
		GFA(P_0, AssetResourceKeys.ToolBarGalleryBackgroundNormalBrushKey, FF0(P_0, (md)46));
		GFA(P_0, AssetResourceKeys.ToolBarGalleryBorderHoverBrushKey, YFO(P_0, (md)46, YK.Border));
		GFA(P_0, AssetResourceKeys.ToolBarGalleryBorderNormalBrushKey, YFO(P_0, (md)46, YK.Border));
		GFA(P_0, AssetResourceKeys.ToolBarGalleryButtonBackgroundDisabledBrushKey, YFO(P_0, (md)44, YK.Background));
		GFA(P_0, AssetResourceKeys.ToolBarGalleryButtonBackgroundNormalBrushKey, FF0(P_0, (md)44));
		GFA(P_0, AssetResourceKeys.ToolBarGalleryButtonBorderDisabledBrushKey, YFO(P_0, (md)44, YK.Border, DL.Disabled));
		GFA(P_0, AssetResourceKeys.ToolBarGalleryButtonBorderNormalBrushKey, YFO(P_0, (md)44, YK.Border, (DL)1));
		GFA(P_0, AssetResourceKeys.ToolBarGalleryButtonInnerBorderDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarGalleryButtonInnerBorderNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.ToolBarGripperForegroundNormalBrushKey, YFO(P_0, md.ToolBar, (YK)11));
		GFA(P_0, AssetResourceKeys.ToolBarHorizontalBackgroundNormalBrushKey, FF0(P_0, md.ToolBar));
		GFA(P_0, AssetResourceKeys.ToolBarHorizontalBorderNormalBrushKey, FF0(P_0, md.ToolBar));
		GFA(P_0, AssetResourceKeys.ToolBarMenuForegroundNormalBrushKey, YFO(P_0, md.ToolBar, (YK)8));
		GFA(P_0, AssetResourceKeys.ToolBarOverflowButtonForegroundNormalBrushKey, YFO(P_0, md.ToolBar, (YK)9));
		GFA(P_0, AssetResourceKeys.ToolBarOverflowButtonHorizontalBackgroundNormalBrushKey, FF0(P_0, md.ToolBar));
		GFA(P_0, AssetResourceKeys.ToolBarOverflowButtonVerticalBackgroundNormalBrushKey, FF0(P_0, md.ToolBar));
		GFA(P_0, AssetResourceKeys.ToolBarSeparatorBackgroundNormalBrushKey, FF0(P_0, md.ToolBar, (oS)2));
		GFA(P_0, AssetResourceKeys.ToolBarTrayBackgroundNormalBrushKey, FF0(P_0, md.ToolBar));
		GFA(P_0, AssetResourceKeys.ToolBarVerticalBackgroundNormalBrushKey, FF0(P_0, md.ToolBar));
		GFA(P_0, AssetResourceKeys.ToolBarVerticalBorderNormalBrushKey, FF0(P_0, md.ToolBar));
		if (P_0.nWI().BarItemBackgroundStateKindResolved == BackgroundStateKind.Accent)
		{
			IFC(P_0, AssetResourceKeys.ToolBarButtonBackgroundCheckedHoverBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Checked, mF4(P_0, colorRamp, (md)45));
			IFC(P_0, AssetResourceKeys.ToolBarButtonBackgroundCheckedNormalBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Checked, mF4(P_0, colorRamp, (md)45));
			IFC(P_0, AssetResourceKeys.ToolBarButtonBackgroundHoverBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Hover, XFw(P_0, colorRamp, (md)45, YK.Background, DL.Hover));
			IFC(P_0, AssetResourceKeys.ToolBarButtonBackgroundOpenedBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Pressed, XFw(P_0, colorRamp, (md)45, YK.Background, (DL)64));
			IFC(P_0, AssetResourceKeys.ToolBarButtonBackgroundPressedBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Pressed, XFw(P_0, colorRamp, (md)45, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderCheckedHoverBrushKey, XFw(P_0, colorRamp, (md)45, YK.Border));
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderCheckedNormalBrushKey, XFw(P_0, colorRamp, (md)45, YK.Border));
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderHoverBrushKey, XFw(P_0, colorRamp, (md)45, YK.Border, DL.Hover));
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderOpenedBrushKey, XFw(P_0, colorRamp, (md)45, YK.Border, (DL)64));
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderPressedBrushKey, XFw(P_0, colorRamp, (md)45, YK.Border, DL.Pressed));
			GFA(P_0, AssetResourceKeys.ToolBarButtonForegroundHoverBrushKey, XFw(P_0, colorRamp, (md)45, (YK)8, DL.Hover));
			IFC(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundCheckedHoverBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Checked, mF4(P_0, colorRamp, (md)45));
			IFC(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundCheckedNormalBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Checked, mF4(P_0, colorRamp, (md)45));
			IFC(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundHoverBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Hover, XFw(P_0, colorRamp, (md)45, YK.Background, DL.Hover));
			IFC(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundOpenedBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Pressed, XFw(P_0, colorRamp, (md)45, YK.Background, (DL)64));
			IFC(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundPressedBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Pressed, XFw(P_0, colorRamp, (md)45, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.ToolBarButtonRoundBackgroundHoverBrushKey, XFw(P_0, colorRamp, (md)45, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.ToolBarButtonRoundBackgroundPressedBrushKey, XFw(P_0, colorRamp, (md)45, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.ToolBarEditDropDownButtonBorderHoverBrushKey, XFw(P_0, colorRamp, (md)45, YK.Border, DL.Hover));
			GFA(P_0, AssetResourceKeys.ToolBarEditDropDownButtonBorderPressedBrushKey, XFw(P_0, colorRamp, (md)45, YK.Border, DL.Pressed));
		}
		else
		{
			IFC(P_0, AssetResourceKeys.ToolBarButtonBackgroundCheckedHoverBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Checked, FF0(P_0, (md)45));
			IFC(P_0, AssetResourceKeys.ToolBarButtonBackgroundCheckedNormalBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Checked, FF0(P_0, (md)45));
			IFC(P_0, AssetResourceKeys.ToolBarButtonBackgroundHoverBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Hover, YFO(P_0, (md)45, YK.Background, DL.Hover));
			IFC(P_0, AssetResourceKeys.ToolBarButtonBackgroundOpenedBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Pressed, YFO(P_0, (md)45, YK.Background, (DL)64));
			IFC(P_0, AssetResourceKeys.ToolBarButtonBackgroundPressedBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Pressed, YFO(P_0, (md)45, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderCheckedHoverBrushKey, YFO(P_0, (md)45, YK.Border));
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderCheckedNormalBrushKey, YFO(P_0, (md)45, YK.Border));
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderHoverBrushKey, YFO(P_0, (md)45, YK.Border, DL.Hover));
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderOpenedBrushKey, YFO(P_0, (md)45, YK.Border, (DL)64));
			GFA(P_0, AssetResourceKeys.ToolBarButtonBorderPressedBrushKey, YFO(P_0, (md)45, YK.Border, DL.Pressed));
			GFA(P_0, AssetResourceKeys.ToolBarButtonForegroundHoverBrushKey, YFO(P_0, (md)45, (YK)8, DL.Hover));
			IFC(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundCheckedHoverBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Checked, FF0(P_0, (md)45));
			IFC(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundCheckedNormalBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Checked, FF0(P_0, (md)45));
			IFC(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundHoverBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Hover, YFO(P_0, (md)45, YK.Background, DL.Hover));
			IFC(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundOpenedBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Pressed, YFO(P_0, (md)45, YK.Background, (DL)64));
			IFC(P_0, AssetResourceKeys.ToolBarButtonLargeBackgroundPressedBrushKey, P_0.nWI().BarItemBackgroundGradientKind, GradientUsageKind.Pressed, YFO(P_0, (md)45, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.ToolBarButtonRoundBackgroundHoverBrushKey, YFO(P_0, (md)45, YK.Background, DL.Hover));
			GFA(P_0, AssetResourceKeys.ToolBarButtonRoundBackgroundPressedBrushKey, YFO(P_0, (md)45, YK.Background, DL.Pressed));
			GFA(P_0, AssetResourceKeys.ToolBarEditDropDownButtonBorderHoverBrushKey, YFO(P_0, (md)45, YK.Border, DL.Hover));
			GFA(P_0, AssetResourceKeys.ToolBarEditDropDownButtonBorderPressedBrushKey, YFO(P_0, (md)45, YK.Border, DL.Pressed));
		}
	}

	private static void FFz(AD P_0)
	{
		bool isDarkTheme = P_0.nWI().IsDarkTheme;
		bool isDarkTheme2 = P_0.nWI().IsDarkTheme;
		UFx(P_0, AssetResourceKeys.KeyTipBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.KeyTipBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.KeyTipPaddingNormalThicknessKey, new Thickness(3.0, 0.0, 3.0, 0.0));
		UFx(P_0, AssetResourceKeys.ToolTipBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		int num = 2;
		IColorRamp yellow = default(IColorRamp);
		Color color3 = default(Color);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 4:
				GFA(P_0, AssetResourceKeys.KeyTipBorderNormalBrushKey, mF4(P_0, yellow, md.ToolTip, (oS)256));
				GFA(P_0, AssetResourceKeys.KeyTipForegroundNormalBrushKey, XFw(P_0, yellow, md.ToolTip, (YK)8, DL.Normal, (oS)256));
				return;
			case 1:
				return;
			default:
				GFA(P_0, AssetResourceKeys.ToolTipForegroundNormalBrushKey, color3);
				if (isDarkTheme2)
				{
					yellow = P_0.IWZ().Yellow;
					GFA(P_0, AssetResourceKeys.KeyTipBackgroundNormalBrushKey, mF4(P_0, yellow, md.ToolTip, (oS)256));
					num = 4;
					break;
				}
				GFA(P_0, AssetResourceKeys.KeyTipBackgroundNormalBrushKey, FF0(P_0, md.ToolTip, (oS)128));
				GFA(P_0, AssetResourceKeys.KeyTipBorderNormalBrushKey, FF0(P_0, md.ToolTip, (oS)128));
				GFA(P_0, AssetResourceKeys.KeyTipForegroundNormalBrushKey, YFO(P_0, md.ToolTip, (YK)8, DL.Normal, (oS)128));
				num = 1;
				if (mfF())
				{
					break;
				}
				goto IL_0005;
			case 3:
				GFA(P_0, AssetResourceKeys.ToolTipForegroundNormalBrushKey, SystemColors.InfoTextColor);
				return;
			case 2:
				{
					eFU(P_0, AssetResourceKeys.ToolTipBorderNormalThicknessKey, new Thickness(1.0));
					eFU(P_0, AssetResourceKeys.ToolTipPaddingNormalThicknessKey, new Thickness(7.0, 4.0, 7.0, 4.0));
					DFa(P_0, AssetResourceKeys.ToolTipShadowElevationInt32Key, 4);
					ThemeIntent intent = P_0.nWI().Intent;
					ThemeIntent themeIntent = intent;
					if (themeIntent == ThemeIntent.HighContrast)
					{
						GFA(P_0, AssetResourceKeys.IntelliPromptToolTipBackgroundNormalBrushKey, SystemColors.InfoColor);
						GFA(P_0, AssetResourceKeys.IntelliPromptToolTipBorderNormalBrushKey, SystemColors.WindowFrameColor);
						GFA(P_0, AssetResourceKeys.IntelliPromptToolTipForegroundNormalBrushKey, SystemColors.InfoTextColor);
						GFA(P_0, AssetResourceKeys.KeyTipBackgroundNormalBrushKey, SystemColors.InfoColor);
						GFA(P_0, AssetResourceKeys.KeyTipBorderNormalBrushKey, SystemColors.WindowFrameColor);
						GFA(P_0, AssetResourceKeys.KeyTipForegroundNormalBrushKey, SystemColors.InfoTextColor);
						GFA(P_0, AssetResourceKeys.ToolTipBackgroundNormalBrushKey, SystemColors.InfoColor);
						GFA(P_0, AssetResourceKeys.ToolTipBorderNormalBrushKey, SystemColors.WindowFrameColor);
						num2 = 3;
					}
					else
					{
						Color color;
						Color color2;
						if (isDarkTheme)
						{
							color = FF0(P_0, md.ToolTip, (oS)256);
							color2 = YFO(P_0, md.ToolTip, YK.Border, DL.Normal, (oS)256);
							color3 = YFO(P_0, md.ToolTip, (YK)8, DL.Normal, (oS)256);
						}
						else
						{
							color = FF0(P_0, md.ToolTip);
							color2 = YFO(P_0, md.ToolTip, YK.Border);
							color3 = YFO(P_0, md.ToolTip, (YK)8);
						}
						GFA(P_0, AssetResourceKeys.IntelliPromptToolTipBackgroundNormalBrushKey, color);
						GFA(P_0, AssetResourceKeys.IntelliPromptToolTipBorderNormalBrushKey, color2);
						GFA(P_0, AssetResourceKeys.IntelliPromptToolTipForegroundNormalBrushKey, color3);
						GFA(P_0, AssetResourceKeys.ToolTipBackgroundNormalBrushKey, color);
						GFA(P_0, AssetResourceKeys.ToolTipBorderNormalBrushKey, color2);
						num = 0;
						if (Ffd() == null)
						{
							break;
						}
					}
					goto IL_0005;
				}
				IL_0005:
				num = num2;
				break;
			}
		}
	}

	private static void Loc(AD P_0)
	{
		IColorRamp colorRamp = P_0.IWZ().GetColorRamp(P_0.nWI().WindowColorFamilyName);
		bool flag = P_0.nWI().WindowTitleBarBackgroundKind == WindowTitleBarBackgroundKind.Accent || P_0.nWI().WindowTitleBarBackgroundKind == WindowTitleBarBackgroundKind.AccentWithDimming || P_0.nWI().Intent == ThemeIntent.HighContrast;
		ThemeIntent intent = P_0.nWI().Intent;
		ThemeIntent themeIntent = intent;
		Color color;
		Color color2;
		Color color3;
		Color color4;
		Color color5;
		Color color6;
		Color color7;
		Color color8;
		Color color9;
		Color color10;
		Color color11;
		Color color12;
		Color color13;
		Color color14;
		Color color15;
		Color color16;
		Color color17;
		Color color18;
		Color color19;
		Color color20;
		Color color21;
		Color color22;
		Color color23;
		Color color24;
		Color color25;
		Color color26;
		Color color27;
		Color color28;
		Color color29;
		Color color30;
		Color color31;
		Color color32;
		Color color33;
		Color color34;
		Color color35;
		Color color36;
		Color color37;
		Color color38;
		if (themeIntent == ThemeIntent.HighContrast)
		{
			color = SystemColors.WindowColor;
			color2 = SystemColors.ActiveBorderColor;
			color3 = SystemColors.InactiveBorderColor;
			color4 = SystemColors.WindowTextColor;
			color5 = SystemColors.ActiveCaptionColor;
			color6 = SystemColors.InactiveCaptionColor;
			color7 = SystemColors.ActiveCaptionColor;
			color8 = SystemColors.InactiveCaptionColor;
			color9 = SystemColors.ActiveCaptionTextColor;
			color10 = SystemColors.InactiveCaptionTextColor;
			color11 = SystemColors.HighlightColor;
			color12 = SystemColors.HighlightColor;
			color13 = SystemColors.HighlightTextColor;
			color14 = SystemColors.HighlightColor;
			color15 = SystemColors.GrayTextColor;
			color16 = SystemColors.HighlightTextColor;
			color17 = SystemColors.InactiveCaptionTextColor;
			color18 = SystemColors.ActiveCaptionTextColor;
			color19 = SystemColors.HighlightTextColor;
			color20 = color11;
			color21 = color12;
			color22 = SystemColors.HighlightTextColor;
			color23 = SystemColors.HighlightColor;
			color24 = color16;
			color25 = color19;
			color26 = SystemColors.WindowColor;
			color27 = SystemColors.WindowColor;
			color28 = SystemColors.WindowTextColor;
			color29 = SystemColors.WindowTextColor;
			color30 = color11;
			color31 = color12;
			color32 = color13;
			color33 = color14;
			color34 = color15;
			color35 = color16;
			color36 = SystemColors.WindowTextColor;
			color37 = SystemColors.WindowTextColor;
			color38 = color19;
		}
		else
		{
			color = FF0(P_0, (md)49);
			color2 = YFO(P_0, (md)49, YK.Border);
			color3 = YFO(P_0, (md)49, YK.Border, (DL)32);
			color4 = YFO(P_0, (md)49, (YK)8);
			color5 = FF0(P_0, (md)49, (oS)1);
			color6 = FF0(P_0, (md)49, (oS)1);
			color7 = color;
			color9 = YFO(P_0, (md)49, (YK)9);
			color10 = YFO(P_0, (md)49, (YK)10);
			color15 = FF0(P_0, (md)49, (oS)4);
			color17 = YFO(P_0, (md)49, (YK)10);
			color18 = YFO(P_0, (md)49, (YK)9);
			if (P_0.nWI().BarItemBackgroundStateKindResolved == BackgroundStateKind.Accent)
			{
				color11 = XFw(P_0, colorRamp, (md)51, YK.Background, DL.Hover);
				color12 = XFw(P_0, colorRamp, (md)51, YK.Background, DL.Pressed);
				color16 = XFw(P_0, colorRamp, (md)51, (YK)7, DL.Hover);
				color19 = XFw(P_0, colorRamp, (md)51, (YK)7, DL.Pressed);
			}
			else
			{
				color11 = YFO(P_0, (md)51, YK.Background, DL.Hover, (oS)1);
				color12 = YFO(P_0, (md)51, YK.Background, DL.Pressed, (oS)1);
				color16 = YFO(P_0, (md)51, (YK)9, DL.Hover, (oS)1);
				color19 = YFO(P_0, (md)51, (YK)9, DL.Pressed, (oS)1);
			}
			if (P_0.nWI().WindowTitleBarBackgroundKind == WindowTitleBarBackgroundKind.ThemeMinimum)
			{
				color7 = FF0(P_0, (md)26);
				color9 = YFO(P_0, (md)26, (YK)9);
				color10 = YFO(P_0, (md)26, (YK)10);
			}
			color26 = color7;
			color27 = color26;
			color28 = color9;
			color29 = color10;
			color30 = color11;
			color31 = color12;
			color32 = color11;
			color33 = color12;
			color34 = color15;
			color35 = color16;
			color36 = color17;
			color37 = color18;
			color38 = color19;
			if (flag)
			{
				color7 = mF4(P_0, colorRamp, (md)49, (oS)256);
				color8 = color7;
				color9 = XFw(P_0, colorRamp, (md)49, (YK)7, DL.Normal, (oS)256);
				color10 = XFw(P_0, colorRamp, (md)49, (YK)9, DL.Normal, (oS)256);
				if (P_0.nWI().WindowTitleBarBackgroundKind == WindowTitleBarBackgroundKind.AccentWithDimming)
				{
					UIColor uIColor = UIColor.FromColor(color8);
					uIColor.HsbSaturation *= 0.85;
					color8 = uIColor.ToColor();
					color10 = XFw(P_0, colorRamp, (md)49, (YK)8, DL.Normal, (oS)256);
				}
				color11 = mF4(P_0, colorRamp, (md)49, (oS)257);
				color12 = mF4(P_0, colorRamp, (md)49, (oS)258);
				color15 = XFw(P_0, colorRamp, (md)49, (YK)11, DL.Normal, (oS)256);
				color16 = XFw(P_0, colorRamp, (md)49, (YK)7, DL.Normal, (oS)257);
				color17 = color10;
				color18 = color9;
				color19 = XFw(P_0, colorRamp, (md)49, (YK)7, DL.Normal, (oS)258);
			}
			else
			{
				color8 = color7;
			}
			color20 = Color.FromRgb(226, 52, 46);
			color21 = Color.FromRgb(154, 16, 12);
			color22 = color20;
			color23 = color21;
			color24 = Color.FromRgb(252, 233, 232);
			color25 = Color.FromRgb(244, 229, 228);
			color13 = color11;
			color14 = color12;
			if (P_0.nWI().WindowBorderKind == WindowBorderKind.Accent)
			{
				color2 = mF4(P_0, colorRamp, (md)49, (oS)256);
				if (!P_0.nWI().IsDarkTheme)
				{
					color3 = YFO(P_0, (md)49, YK.Border, DL.Normal, (oS)4);
				}
			}
		}
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarBackgroundActiveBrushKey, color26);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarBackgroundInactiveBrushKey, color27);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarExtensionBackgroundActiveBrushKey, color26);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarExtensionBackgroundInactiveBrushKey, color27);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarForegroundActiveBrushKey, color28);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarForegroundInactiveBrushKey, color29);
		GFA(P_0, AssetResourceKeys.WindowBackgroundNormalBrushKey, color);
		GFA(P_0, AssetResourceKeys.WindowBorderActiveBrushKey, color2);
		GFA(P_0, AssetResourceKeys.WindowBorderInactiveBrushKey, color3);
		UFx(P_0, AssetResourceKeys.WindowBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.WindowBorderNormalThicknessKey, new Thickness(4.0));
		eFU(P_0, AssetResourceKeys.WindowBorderOuterGlowNormalThicknessKey, new Thickness(13.0));
		UFx(P_0, AssetResourceKeys.WindowControlBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		GFA(P_0, AssetResourceKeys.WindowForegroundNormalBrushKey, color4);
		KFl(P_0, AssetResourceKeys.WindowHasOuterGlowBooleanKey, _0020: true);
		GFA(P_0, AssetResourceKeys.WindowInnerBorderBottomActiveBrushKey, color5);
		GFA(P_0, AssetResourceKeys.WindowInnerBorderBottomInactiveBrushKey, color6);
		GFA(P_0, AssetResourceKeys.WindowInnerBorderLeftActiveBrushKey, color5);
		GFA(P_0, AssetResourceKeys.WindowInnerBorderLeftInactiveBrushKey, color6);
		GFA(P_0, AssetResourceKeys.WindowInnerBorderRightActiveBrushKey, color5);
		GFA(P_0, AssetResourceKeys.WindowInnerBorderRightInactiveBrushKey, color6);
		GFA(P_0, AssetResourceKeys.WindowInnerBorderTopActiveBrushKey, color5);
		GFA(P_0, AssetResourceKeys.WindowInnerBorderTopInactiveBrushKey, color6);
		eFU(P_0, AssetResourceKeys.WindowResizeBorderNormalThicknessKey, new Thickness(1.0));
		GFA(P_0, AssetResourceKeys.WindowTitleBarBackgroundActiveBrushKey, color7);
		GFA(P_0, AssetResourceKeys.WindowTitleBarBackgroundInactiveBrushKey, color8);
		GFA(P_0, AssetResourceKeys.WindowTitleBarExtensionBackgroundActiveBrushKey, color7);
		GFA(P_0, AssetResourceKeys.WindowTitleBarExtensionBackgroundInactiveBrushKey, color8);
		GFn(P_0, AssetResourceKeys.WindowTitleBarFontWeightKey, FontWeights.Normal);
		GFA(P_0, AssetResourceKeys.WindowTitleBarForegroundActiveBrushKey, color9);
		GFA(P_0, AssetResourceKeys.WindowTitleBarForegroundInactiveBrushKey, color10);
		rFr(P_0, AssetResourceKeys.WindowTitleBarMinHeightNormalDoubleKey, 28.0);
		KFl(P_0, AssetResourceKeys.WindowTitleBarUseAccentBooleanKey, flag);
		UFx(P_0, AssetResourceKeys.WindowTitleBarButtonBorderNormalCornerRadiusKey, new CornerRadius(0.0));
		eFU(P_0, AssetResourceKeys.WindowTitleBarButtonBorderNormalThicknessKey, new Thickness(1.0));
		eFU(P_0, AssetResourceKeys.WindowTitleBarButtonMarginNormalThicknessKey, new Thickness(0.0));
		eFU(P_0, AssetResourceKeys.WindowTitleBarButtonPaddingNormalThicknessKey, new Thickness(7.0, 5.0, 7.0, 5.0));
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonBackgroundInactiveDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonBackgroundInactiveNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonBorderInactiveDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonBorderInactiveNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonForegroundInactiveDisabledBrushKey, color15);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonForegroundInactiveNormalBrushKey, color17);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonBackgroundActiveDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonBackgroundActiveHoverBrushKey, color11);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonBackgroundActiveNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonBackgroundActivePressedBrushKey, color12);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonBorderActiveDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonBorderActiveHoverBrushKey, color13);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonBorderActiveNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonBorderActivePressedBrushKey, color14);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonForegroundActiveDisabledBrushKey, color15);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonForegroundActiveHoverBrushKey, color16);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonForegroundActiveNormalBrushKey, color18);
		GFA(P_0, AssetResourceKeys.WindowTitleBarButtonForegroundActivePressedBrushKey, color19);
		GFA(P_0, AssetResourceKeys.CloseWindowTitleBarButtonBackgroundActiveDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.CloseWindowTitleBarButtonBackgroundActiveHoverBrushKey, color20);
		GFA(P_0, AssetResourceKeys.CloseWindowTitleBarButtonBackgroundActiveNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.CloseWindowTitleBarButtonBackgroundActivePressedBrushKey, color21);
		GFA(P_0, AssetResourceKeys.CloseWindowTitleBarButtonBorderActiveDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.CloseWindowTitleBarButtonBorderActiveHoverBrushKey, color22);
		GFA(P_0, AssetResourceKeys.CloseWindowTitleBarButtonBorderActiveNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.CloseWindowTitleBarButtonBorderActivePressedBrushKey, color23);
		GFA(P_0, AssetResourceKeys.CloseWindowTitleBarButtonForegroundActiveDisabledBrushKey, color15);
		GFA(P_0, AssetResourceKeys.CloseWindowTitleBarButtonForegroundActiveHoverBrushKey, color24);
		GFA(P_0, AssetResourceKeys.CloseWindowTitleBarButtonForegroundActiveNormalBrushKey, color18);
		GFA(P_0, AssetResourceKeys.CloseWindowTitleBarButtonForegroundActivePressedBrushKey, color25);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonBackgroundInactiveDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonBackgroundInactiveNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonBorderInactiveDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonBorderInactiveNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonForegroundInactiveDisabledBrushKey, color34);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonForegroundInactiveNormalBrushKey, color36);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonBackgroundActiveDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonBackgroundActiveHoverBrushKey, color30);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonBackgroundActiveNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonBackgroundActivePressedBrushKey, color31);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonBorderActiveDisabledBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonBorderActiveHoverBrushKey, color32);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonBorderActiveNormalBrushKey, Colors.Transparent);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonBorderActivePressedBrushKey, color33);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonForegroundActiveDisabledBrushKey, color34);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonForegroundActiveHoverBrushKey, color35);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonForegroundActiveNormalBrushKey, color37);
		GFA(P_0, AssetResourceKeys.AlternateWindowTitleBarButtonForegroundActivePressedBrushKey, color38);
	}

	[Conditional("DEBUG")]
	private void zoj(ResourceDictionary P_0, string P_1 = null)
	{
		P_1 = P_1 ?? string.Empty;
		HashSet<string> hashSet = new HashSet<string>();
		PropertyInfo[] properties = typeof(AssetResourceKeys).GetProperties();
		PropertyInfo[] array = properties;
		int num = 0;
		int num2 = 1;
		if (!mfF())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		default:
		{
			PropertyInfo propertyInfo = array[num];
			if (propertyInfo.Name.StartsWith(P_1))
			{
				hashSet.Add(propertyInfo.Name);
			}
			num++;
			goto case 1;
		}
		case 1:
			if (num >= array.Length)
			{
				foreach (ComponentResourceKey key in P_0.Keys)
				{
					hashSet.Remove(key.ResourceId.ToString());
				}
				foreach (string item in from n in hashSet.ToArray()
					orderby n
					select n)
				{
					Debug.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105918) + item);
				}
				Debug.WriteLine(string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105940), hashSet.Count));
				Debug.WriteLine(string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105980), P_0.Keys.Count, properties.Length));
				break;
			}
			goto default;
		}
	}

	public ResourceDictionary Generate(ThemeDefinition definition)
	{
		if (definition == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96496));
		}
		AD aD = new AD();
		aD.yWx(definition);
		aD.iWn(new ColorPalette(definition));
		aD.sWW(new ThemedResourceDictionary());
		AD aD2 = aD;
		xFH(aD2);
		WF6(aD2);
		rFV(aD2);
		kF5(aD2);
		dFR(aD2);
		sFE(aD2);
		lFs(aD2);
		gFL(aD2);
		EFd(aD2);
		PFN(aD2);
		FFM(aD2);
		YFK(aD2);
		zFg(aD2);
		XF8(aD2);
		oFD(aD2);
		AFP(aD2);
		wFG(aD2);
		tF1(aD2);
		FFz(aD2);
		Loc(aD2);
		return aD2.dWq();
	}

	public ThemeGenerator()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool mfF()
	{
		return ofk == null;
	}

	internal static ThemeGenerator Ffd()
	{
		return ofk;
	}
}
