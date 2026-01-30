using System;
using System.Globalization;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.DocControls.Watchlist.Converters;

public class FieldToFilterToEnableConverter : IValueConverter
{
	private static FieldToFilterToEnableConverter QuMLnt4eXB2eWYeQbURS;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int num2;
		if (P_0 is int num)
		{
			if (num < 0)
			{
				num2 = 0;
				goto IL_0090;
			}
			int num3 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
			{
				num3 = 0;
			}
			switch (num3)
			{
			case 1:
				break;
			default:
				goto IL_0061;
			}
		}
		return false;
		IL_0090:
		return (byte)num2 != 0;
		IL_0061:
		num2 = ((num != 0) ? 1 : 0);
		goto IL_0090;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		return Binding.DoNothing;
	}

	public FieldToFilterToEnableConverter()
	{
		hsirZ54eEo6klGG1CTYY();
		base._002Ector();
	}

	static FieldToFilterToEnableConverter()
	{
		zDB2s24eQg3wGVn6q85Q();
	}

	internal static bool RJtPVi4echnIXAnCMHJ8()
	{
		return QuMLnt4eXB2eWYeQbURS == null;
	}

	internal static FieldToFilterToEnableConverter xQg1sJ4ejyQRc58Hmk2R()
	{
		return QuMLnt4eXB2eWYeQbURS;
	}

	internal static void hsirZ54eEo6klGG1CTYY()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void zDB2s24eQg3wGVn6q85Q()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
