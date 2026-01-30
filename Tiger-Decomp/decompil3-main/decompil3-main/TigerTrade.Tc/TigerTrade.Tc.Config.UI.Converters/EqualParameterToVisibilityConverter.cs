using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Config.UI.Converters;

internal class EqualParameterToVisibilityConverter : IValueConverter
{
	[CompilerGenerated]
	private bool EjSaXdOm8uK;

	internal static EqualParameterToVisibilityConverter C0GaxBxhWf04fULWfDis;

	public bool IsInverted
	{
		[CompilerGenerated]
		get
		{
			return EjSaXdOm8uK;
		}
		[CompilerGenerated]
		set
		{
			EjSaXdOm8uK = ejSaXdOm8uK;
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		bool flag = P_0?.Equals(P_2) ?? false;
		if (IsInverted ^ flag)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_0091;
			}
		}
		int num2 = 2;
		goto IL_0092;
		IL_0092:
		return (Visibility)num2;
		IL_0091:
		num2 = 0;
		goto IL_0092;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		return Binding.DoNothing;
	}

	public EqualParameterToVisibilityConverter()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static EqualParameterToVisibilityConverter()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool o1boDoxhtyc3NxVWO0lO()
	{
		return C0GaxBxhWf04fULWfDis == null;
	}

	internal static EqualParameterToVisibilityConverter zm7U1mxhUxFU59bgEIrZ()
	{
		return C0GaxBxhWf04fULWfDis;
	}
}
