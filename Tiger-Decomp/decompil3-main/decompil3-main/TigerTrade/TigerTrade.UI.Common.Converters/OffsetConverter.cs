using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

internal sealed class OffsetConverter : IValueConverter
{
	internal static OffsetConverter HqDIGaDsEEgZhr14S0BE;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (P_0 == null || P_2 == null)
		{
			goto IL_004b;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				goto end_IL_0009;
			}
			if (bsWlhpDsgWOyeXN26bZc(P_2.ToString(), P_0.ToString()))
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
				{
					num = 1;
				}
				continue;
			}
			goto IL_004b;
			continue;
			end_IL_0009:
			break;
		}
		int num2 = 0;
		goto IL_008c;
		IL_008c:
		return (Visibility)num2;
		IL_004b:
		num2 = 2;
		goto IL_008c;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public OffsetConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static OffsetConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool bsWlhpDsgWOyeXN26bZc(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool yJf9fnDsQOmkRpAPhZFP()
	{
		return HqDIGaDsEEgZhr14S0BE == null;
	}

	internal static OffsetConverter R8ukqiDsdZTCpBCtwWMy()
	{
		return HqDIGaDsEEgZhr14S0BE;
	}
}
