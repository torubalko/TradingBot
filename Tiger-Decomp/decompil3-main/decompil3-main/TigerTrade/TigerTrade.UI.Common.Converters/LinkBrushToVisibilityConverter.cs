using System;
using System.Globalization;
using System.Windows;
using ECOEgqlSad8NUJZ2Dr9n;
using MyaWdtHSy6ythDGO9eDx;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

internal sealed class LinkBrushToVisibilityConverter : wqu3BaHSTIpqeB2qWhad<LinkBrushToVisibilityConverter>
{
	private static LinkBrushToVisibilityConverter w2i4RTDsBMyrYfIRbeBP;

	public override object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int num = 1;
		int num2 = num;
		int num3;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (P_0 != null)
				{
					if (!P_0.Equals(P_2))
					{
						goto default;
					}
					num3 = 0;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				num3 = 2;
				break;
			}
			break;
		}
		return (Visibility)num3;
	}

	public LinkBrushToVisibilityConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static LinkBrushToVisibilityConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool yM0bf3DsauEhAZelA2Cl()
	{
		return w2i4RTDsBMyrYfIRbeBP == null;
	}

	internal static LinkBrushToVisibilityConverter TKfMQYDsiiUj2gOUixLc()
	{
		return w2i4RTDsBMyrYfIRbeBP;
	}
}
