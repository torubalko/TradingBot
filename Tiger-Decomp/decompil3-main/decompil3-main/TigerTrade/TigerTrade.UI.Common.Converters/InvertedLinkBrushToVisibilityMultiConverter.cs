using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

internal sealed class InvertedLinkBrushToVisibilityMultiConverter : IMultiValueConverter
{
	internal static InvertedLinkBrushToVisibilityMultiConverter EguxCsDsSomAFiLYPaDH;

	public object Convert(object[] P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (P_0.Length >= 2)
		{
			int result2 = default(int);
			int num;
			if (int.TryParse(P_0[0].ToString(), out var result))
			{
				if (!int.TryParse(P_0[1].ToString(), out result2) || result != 0)
				{
					goto IL_00ae;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
				{
					num = 0;
				}
			}
			else
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
				{
					num = 1;
				}
			}
			switch (num)
			{
			default:
				if (result2 == 0)
				{
					return Visibility.Visible;
				}
				break;
			case 1:
				break;
			}
		}
		goto IL_00ae;
		IL_00ae:
		return Visibility.Collapsed;
	}

	public object[] ConvertBack(object P_0, Type[] P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public InvertedLinkBrushToVisibilityMultiConverter()
	{
		tvHC7pDseJykRRemw4GU();
		base._002Ector();
	}

	static InvertedLinkBrushToVisibilityMultiConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool DG2UIZDsxckXmFrbUTxb()
	{
		return EguxCsDsSomAFiLYPaDH == null;
	}

	internal static InvertedLinkBrushToVisibilityMultiConverter xNShfnDsLDLxdKQN8vsH()
	{
		return EguxCsDsSomAFiLYPaDH;
	}

	internal static void tvHC7pDseJykRRemw4GU()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
