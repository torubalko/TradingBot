using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

internal sealed class ActiveLinkBrushToVisibilityMultiConverter : IMultiValueConverter
{
	internal static ActiveLinkBrushToVisibilityMultiConverter oPhGAADssbNkbZK6e0xB;

	public object Convert(object[] P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (P_0.Length >= 2 && int.TryParse(P_0[0].ToString(), out var result))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return Visibility.Visible;
				}
				if (!int.TryParse(P_0[1].ToString(), out var result2) || result != 0 || result2 != 1)
				{
					break;
				}
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
				{
					num = 0;
				}
			}
		}
		return Visibility.Collapsed;
	}

	public object[] ConvertBack(object P_0, Type[] P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public ActiveLinkBrushToVisibilityMultiConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static ActiveLinkBrushToVisibilityMultiConverter()
	{
		A8Tv2EDsjZWklaEI1aUd();
	}

	internal static bool K35TMcDsXDxNmMSHr9Be()
	{
		return oPhGAADssbNkbZK6e0xB == null;
	}

	internal static ActiveLinkBrushToVisibilityMultiConverter w935dcDscWgpU1jX5wQ9()
	{
		return oPhGAADssbNkbZK6e0xB;
	}

	internal static void A8Tv2EDsjZWklaEI1aUd()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
