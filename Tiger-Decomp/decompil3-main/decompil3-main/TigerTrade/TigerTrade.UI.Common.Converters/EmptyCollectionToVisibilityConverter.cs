using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

internal class EmptyCollectionToVisibilityConverter : IValueConverter
{
	[CompilerGenerated]
	private bool vXRHSxDcMEk;

	private static EmptyCollectionToVisibilityConverter KC8j9GDeLcIV3bKLnTwQ;

	public bool IsInverted
	{
		[CompilerGenerated]
		get
		{
			return vXRHSxDcMEk;
		}
		[CompilerGenerated]
		set
		{
			vXRHSxDcMEk = flag;
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int num = 1;
		int num2 = num;
		IEnumerable enumerable = default(IEnumerable);
		bool flag = default(bool);
		int num3;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (enumerable != null)
				{
					flag = enumerable.Cast<object>().Any();
				}
				if (!(IsInverted ^ flag))
				{
					num2 = 3;
					continue;
				}
				num3 = 0;
				break;
			default:
				enumerable = P_0 as IEnumerable;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
				{
					num2 = 2;
				}
				continue;
			case 3:
				num3 = 2;
				break;
			case 1:
				flag = P_0 != null;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			break;
		}
		return (Visibility)num3;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public EmptyCollectionToVisibilityConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static EmptyCollectionToVisibilityConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool Jibit6Dee5cBuLaRhi4u()
	{
		return KC8j9GDeLcIV3bKLnTwQ == null;
	}

	internal static EmptyCollectionToVisibilityConverter u1MNexDes2Lc3wc65vaP()
	{
		return KC8j9GDeLcIV3bKLnTwQ;
	}
}
