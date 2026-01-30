using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

internal class IntToBoolConverter : IValueConverter
{
	private static IntToBoolConverter dLo3neDxtZMKm6QckBcL;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		try
		{
			int? num = (int?)P_0;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
			{
				num2 = 0;
			}
			return num2 switch
			{
				_ => num == 0, 
			};
		}
		catch (Exception)
		{
			return Visibility.Visible;
		}
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public IntToBoolConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static IntToBoolConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool Ru5llxDxUbwg7VssQEbC()
	{
		return dLo3neDxtZMKm6QckBcL == null;
	}

	internal static IntToBoolConverter iCWmfGDxT3M1pK8Kbkpk()
	{
		return dLo3neDxtZMKm6QckBcL;
	}
}
