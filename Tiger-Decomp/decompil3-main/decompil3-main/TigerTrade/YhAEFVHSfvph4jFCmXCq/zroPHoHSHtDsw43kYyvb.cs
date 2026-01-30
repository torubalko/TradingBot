using System;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using ActiproSoftware.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Dx;
using TuAMtrl1Nd3XoZQQUXf0;

namespace YhAEFVHSfvph4jFCmXCq;

public class zroPHoHSHtDsw43kYyvb : DependencyObject, IValueConverter
{
	[CompilerGenerated]
	private SolidColorBrush Qq0HS4K2FlY;

	[CompilerGenerated]
	private SolidColorBrush iPsHSDrPWFm;

	[CompilerGenerated]
	private SolidColorBrush mInHSbMux8H;

	[CompilerGenerated]
	private object x29HSN6bsfi;

	private static zroPHoHSHtDsw43kYyvb T1OQA5DeB4uIplvnVgjH;

	public SolidColorBrush ContrastBrush1
	{
		[CompilerGenerated]
		get
		{
			return Qq0HS4K2FlY;
		}
		[CompilerGenerated]
		set
		{
			Qq0HS4K2FlY = qq0HS4K2FlY;
		}
	}

	public SolidColorBrush ContrastBrush2
	{
		[CompilerGenerated]
		get
		{
			return iPsHSDrPWFm;
		}
		[CompilerGenerated]
		set
		{
			iPsHSDrPWFm = solidColorBrush;
		}
	}

	public SolidColorBrush DefaultBrush
	{
		[CompilerGenerated]
		get
		{
			return mInHSbMux8H;
		}
		[CompilerGenerated]
		set
		{
			mInHSbMux8H = solidColorBrush;
		}
	}

	public object DefaultColorResourceKey
	{
		[CompilerGenerated]
		get
		{
			return x29HSN6bsfi;
		}
		[CompilerGenerated]
		set
		{
			x29HSN6bsfi = obj;
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (!(P_0 is SolidColorBrush solidColorBrush))
		{
			return DefaultBrush;
		}
		XColor xColor = QUm5pRDel4XSy5EA4cF4(solidColorBrush);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
		{
			num = 1;
		}
		UIColor uIColor = default(UIColor);
		UIColor contrastingColor2 = default(UIColor);
		UIColor contrastingColor = default(UIColor);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (DefaultBrush != null && pNJHS9aJd86() == xColor)
				{
					return DefaultBrush;
				}
				uIColor = UIColor.FromColor(zFENLEDe4MmMIqTLEPq1(xColor));
				num = 2;
				break;
			case 2:
				contrastingColor2 = J8FrvGDeDVYw6Meu3WPU(ContrastBrush1.Color);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
				{
					num = 0;
				}
				break;
			case 3:
				if (!(uIColor.GetContrastRatioWith(contrastingColor2) > uIColor.GetContrastRatioWith(contrastingColor)))
				{
					return ContrastBrush2;
				}
				return ContrastBrush1;
			default:
				contrastingColor = UIColor.FromColor(QUm5pRDel4XSy5EA4cF4(ContrastBrush2));
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		return Binding.DoNothing;
	}

	private XColor pNJHS9aJd86()
	{
		if (DefaultColorResourceKey != null && !((Application)byLjULDebk2FFbaOmAih()).Resources.Keys.Cast<object>().Any((object P_0) => P_0 == DefaultColorResourceKey))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
			{
				num = 1;
			}
			SolidColorBrush solidColorBrush = default(SolidColorBrush);
			switch (num)
			{
			case 1:
				solidColorBrush = BF58DwDeNbbQNUfFJmtB(byLjULDebk2FFbaOmAih(), DefaultColorResourceKey) as SolidColorBrush;
				if (solidColorBrush == null)
				{
					break;
				}
				goto default;
			default:
				return solidColorBrush.Color;
			}
		}
		return Color.FromArgb(0, 0, 0, 0);
	}

	public zroPHoHSHtDsw43kYyvb()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	[CompilerGenerated]
	private bool sjRHSn7b7gp(object P_0)
	{
		return P_0 == DefaultColorResourceKey;
	}

	static zroPHoHSHtDsw43kYyvb()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool FyDWRNDease2ot2FyOJZ()
	{
		return T1OQA5DeB4uIplvnVgjH == null;
	}

	internal static zroPHoHSHtDsw43kYyvb VGr0xwDeiyJS39XyWkVI()
	{
		return T1OQA5DeB4uIplvnVgjH;
	}

	internal static Color QUm5pRDel4XSy5EA4cF4(object P_0)
	{
		return ((SolidColorBrush)P_0).Color;
	}

	internal static Color zFENLEDe4MmMIqTLEPq1(XColor P_0)
	{
		return P_0;
	}

	internal static UIColor J8FrvGDeDVYw6Meu3WPU(Color P_0)
	{
		return UIColor.FromColor(P_0);
	}

	internal static object byLjULDebk2FFbaOmAih()
	{
		return Application.Current;
	}

	internal static object BF58DwDeNbbQNUfFJmtB(object P_0, object P_1)
	{
		return ((Application)P_0).TryFindResource(P_1);
	}
}
