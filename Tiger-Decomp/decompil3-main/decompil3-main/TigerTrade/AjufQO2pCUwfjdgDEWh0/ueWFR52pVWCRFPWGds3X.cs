using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Dx.Fonts;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace AjufQO2pCUwfjdgDEWh0;

internal sealed class ueWFR52pVWCRFPWGds3X : Image
{
	private static readonly FontFamily BKl2p8QKde8;

	private static readonly Typeface ai72pAobo2C;

	public static readonly DependencyProperty hYn2pPXrJ03;

	public static readonly DependencyProperty IconProperty;

	private static ueWFR52pVWCRFPWGds3X wpWShqDo828fkQxhMXKp;

	public Brush Foreground
	{
		get
		{
			return (Brush)VEmoeIDv27aBqtktThxf(this, hYn2pPXrJ03);
		}
		set
		{
			SetValue(hYn2pPXrJ03, value2);
		}
	}

	public FontAwesomeIcon Icon
	{
		get
		{
			return (FontAwesomeIcon)GetValue(IconProperty);
		}
		set
		{
			SetValue(IconProperty, fontAwesomeIcon);
		}
	}

	static ueWFR52pVWCRFPWGds3X()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		NidFd5DoJXZq9WivdolB();
		BKl2p8QKde8 = new FontFamily(new Uri((string)JiaQyTDoFqqgUT7jFGUB(-1583344314 ^ -1583292156)), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315A4597));
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				ai72pAobo2C = new Typeface(BKl2p8QKde8, FNZdBcDo3JnvqXaYJorQ(), WPnVwIDopnHYixHko884(), FontStretches.Normal);
				hYn2pPXrJ03 = (DependencyProperty)sbcHCrDouPwZQi7n3v4C(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710516564), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777400)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555168)), new PropertyMetadata(Brushes.Black, vpv2pr0nVig));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
				{
					num = 0;
				}
				break;
			default:
				IconProperty = (DependencyProperty)sbcHCrDouPwZQi7n3v4C(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5EA8FF2A ^ 0x5EA84412), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777966)), h3mwTODv0oU0LhAUWJAA(pm6w9oDozKHBFK6GTp9i(33555168)), new PropertyMetadata(FontAwesomeIcon.None, vpv2pr0nVig));
				return;
			}
		}
	}

	private static void vpv2pr0nVig(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		ueWFR52pVWCRFPWGds3X ueWFR52pVWCRFPWGds3X2 = default(ueWFR52pVWCRFPWGds3X);
		while (true)
		{
			switch (num2)
			{
			case 1:
				ueWFR52pVWCRFPWGds3X2 = P_0 as ueWFR52pVWCRFPWGds3X;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (ueWFR52pVWCRFPWGds3X2 != null)
				{
					KNY775Dv9QTbuc73nO8o(ueWFR52pVWCRFPWGds3X2, Image.SourceProperty, R7m2pKV9nhV(ydnQpMDvHOZ0Qnug3oyL(ueWFR52pVWCRFPWGds3X2), (Brush)NGnc91Dvf7fOo7RmfP6c(ueWFR52pVWCRFPWGds3X2)));
				}
				return;
			}
		}
	}

	public static ImageSource R7m2pKV9nhV(FontAwesomeIcon P_0, Brush P_1, double P_2 = 100.0)
	{
		string textToFormat = char.ConvertFromUtf32((int)P_0);
		DrawingVisual drawingVisual = new DrawingVisual();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			using (DrawingContext drawingContext = drawingVisual.RenderOpen())
			{
				FormattedText formattedText = new FormattedText(textToFormat, (CultureInfo)oLbhxlDvnsqqioAttpTX(), FlowDirection.LeftToRight, ai72pAobo2C, P_2, P_1);
				btlOakDvG5kf0yBrEREs(formattedText, TextAlignment.Center);
				drawingContext.DrawText(formattedText, new Point(0.0, 0.0));
			}
			return new DrawingImage(drawingVisual.Drawing);
		}
		}
	}

	public ueWFR52pVWCRFPWGds3X()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	internal static void NidFd5DoJXZq9WivdolB()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object JiaQyTDoFqqgUT7jFGUB(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static FontStyle FNZdBcDo3JnvqXaYJorQ()
	{
		return FontStyles.Normal;
	}

	internal static FontWeight WPnVwIDopnHYixHko884()
	{
		return FontWeights.Normal;
	}

	internal static object sbcHCrDouPwZQi7n3v4C(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}

	internal static RuntimeTypeHandle pm6w9oDozKHBFK6GTp9i(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static Type h3mwTODv0oU0LhAUWJAA(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool oPM00LDoA2fg1MVNjj4a()
	{
		return wpWShqDo828fkQxhMXKp == null;
	}

	internal static ueWFR52pVWCRFPWGds3X nTyrElDoPWUUsJyVFbUE()
	{
		return wpWShqDo828fkQxhMXKp;
	}

	internal static object VEmoeIDv27aBqtktThxf(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static FontAwesomeIcon ydnQpMDvHOZ0Qnug3oyL(object P_0)
	{
		return ((ueWFR52pVWCRFPWGds3X)P_0).Icon;
	}

	internal static object NGnc91Dvf7fOo7RmfP6c(object P_0)
	{
		return ((ueWFR52pVWCRFPWGds3X)P_0).Foreground;
	}

	internal static void KNY775Dv9QTbuc73nO8o(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static object oLbhxlDvnsqqioAttpTX()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static void btlOakDvG5kf0yBrEREs(object P_0, TextAlignment P_1)
	{
		((FormattedText)P_0).TextAlignment = P_1;
	}
}
