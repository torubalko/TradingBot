using System;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

public class BaselineMarginConverter : IMultiValueConverter
{
	[Serializable]
	[CompilerGenerated]
	private sealed class PqoPuKnyH3rQw6N1p8yW
	{
		public static readonly PqoPuKnyH3rQw6N1p8yW Rnfny95E5QZ;

		public static Func<object, bool> rPfnyn3m9pZ;

		private static PqoPuKnyH3rQw6N1p8yW HG3PB8NLDXbKl2fOohxs;

		static PqoPuKnyH3rQw6N1p8yW()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			Rnfny95E5QZ = new PqoPuKnyH3rQw6N1p8yW();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public PqoPuKnyH3rQw6N1p8yW()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool N9VnyfhdO7y(object v)
		{
			return v == null;
		}

		internal static bool c71JMKNLb5RvclaqyLAS()
		{
			return HG3PB8NLDXbKl2fOohxs == null;
		}

		internal static PqoPuKnyH3rQw6N1p8yW DnVahONLNAyy3nBPpDrm()
		{
			return HG3PB8NLDXbKl2fOohxs;
		}
	}

	private static readonly System.Windows.ThicknessConverter O2FH5J4x1EC;

	private static readonly Thickness uGgH5FDgwyO;

	internal static BaselineMarginConverter POvHd1DL3xpqjKb7jjnN;

	public object Convert(object[] P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int num = 2;
		int num2 = num;
		Typeface typeface = default(Typeface);
		Thickness thickness = default(Thickness);
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 3:
			{
				if (typeface == null)
				{
					return thickness;
				}
				double num4 = BCyH5AwARZb(typeface, num3, P_0[1] is Menu);
				return new Thickness(thickness.Left, thickness.Top, thickness.Right, thickness.Bottom + num4);
			}
			default:
				return thickness;
			case 2:
				thickness = znNH5PSj2i6(P_2);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (P_0.Length >= 2 && !P_0.Any((object v) => v == null))
				{
					num3 = (double)P_0[0];
					typeface = on1H58nlHtU(P_0[1]);
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	private static Typeface on1H58nlHtU(object P_0)
	{
		int num = 1;
		int num2 = num;
		TextBlock textBlock = default(TextBlock);
		Control control = default(Control);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (textBlock != null)
				{
					return new Typeface((FontFamily)Q0gx37DLz5KGP1u6gjMa(textBlock), textBlock.FontStyle, textBlock.FontWeight, Fq57JfDe0AYcQ0hb6uqd(textBlock));
				}
				return null;
			case 1:
				control = P_0 as Control;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (control == null)
			{
				textBlock = P_0 as TextBlock;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			return new Typeface(control.FontFamily, control.FontStyle, control.FontWeight, control.FontStretch);
		}
	}

	private static double BCyH5AwARZb(Typeface P_0, double P_1, bool P_2)
	{
		FormattedText formattedText = new FormattedText((string)lXvkQLDe20oRKLokyFy1(0x1AB79299 ^ 0x1AB7AF8F), (CultureInfo)duQA4bDeHJHNDTcMMTer(), FlowDirection.LeftToRight, P_0, P_1, Brushes.Black, 96.0);
		return formattedText.Baseline - (P_2 ? MathHelper.Round(RoundMode.CeilingToEven, Math.Round(formattedText.Height, MidpointRounding.ToEven)) : formattedText.Height);
	}

	private static Thickness znNH5PSj2i6(object P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (P_0 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (P_0 is Thickness)
				{
					return (Thickness)P_0;
				}
				if (O2FH5J4x1EC.CanConvertFrom(P_0.GetType()))
				{
					return (Thickness)O2FH5J4x1EC.ConvertFrom(null, (CultureInfo)sl4RuODefWu65GeThKLJ(), P_0);
				}
				return uGgH5FDgwyO;
			default:
				return uGgH5FDgwyO;
			}
		}
	}

	public object[] ConvertBack(object P_0, Type[] P_1, object P_2, CultureInfo P_3)
	{
		return null;
	}

	public BaselineMarginConverter()
	{
		Ogf0f6De9X410mtkD0fM();
		base._002Ector();
	}

	static BaselineMarginConverter()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Ogf0f6De9X410mtkD0fM();
				O2FH5J4x1EC = new System.Windows.ThicknessConverter();
				uGgH5FDgwyO = new Thickness(0.0);
				return;
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool In3kgpDLpqXKjcIHG4bK()
	{
		return POvHd1DL3xpqjKb7jjnN == null;
	}

	internal static BaselineMarginConverter cSvE3WDLuCQGIUu3FhaB()
	{
		return POvHd1DL3xpqjKb7jjnN;
	}

	internal static object Q0gx37DLz5KGP1u6gjMa(object P_0)
	{
		return ((TextBlock)P_0).FontFamily;
	}

	internal static FontStretch Fq57JfDe0AYcQ0hb6uqd(object P_0)
	{
		return ((TextBlock)P_0).FontStretch;
	}

	internal static object lXvkQLDe20oRKLokyFy1(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object duQA4bDeHJHNDTcMMTer()
	{
		return CultureInfo.CurrentCulture;
	}

	internal static object sl4RuODefWu65GeThKLJ()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static void Ogf0f6De9X410mtkD0fM()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
