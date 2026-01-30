using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace TigerTrade.UI.Common.Converters;

internal sealed class MultConverter : DependencyObject, IValueConverter
{
	public static readonly DependencyProperty X2QHkJ2I3Pn;

	private static MultConverter Ut2QBEDxrAMXG29VXNpU;

	public object Multiplier
	{
		get
		{
			return GetValue(X2QHkJ2I3Pn);
		}
		set
		{
			UAQfcNDxhkSfYS534MNY(this, X2QHkJ2I3Pn, obj);
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (P_0 is double num)
		{
			object obj = Multiplier;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				default:
				{
					double num3 = (double)obj;
					return num * num3;
				}
				case 1:
					break;
				}
				if (!(obj is double))
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
				{
					num2 = 0;
				}
			}
		}
		throw new NotSupportedException();
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotSupportedException();
	}

	public MultConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static MultConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		ADq2LpDxwoGH16RXKDRC();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		X2QHkJ2I3Pn = DependencyProperty.Register((string)fcDb8UDx7UaBkPqy8JyC(0x3E0426F0 ^ 0x3E050488), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240)), Type.GetTypeFromHandle(eVsyhTDx8KTxqfmSFWwL(33555316)));
	}

	internal static bool IoAEDADxKimHFTSHSAVj()
	{
		return Ut2QBEDxrAMXG29VXNpU == null;
	}

	internal static MultConverter efhMD7Dxm9gRdTx755Pp()
	{
		return Ut2QBEDxrAMXG29VXNpU;
	}

	internal static void UAQfcNDxhkSfYS534MNY(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void ADq2LpDxwoGH16RXKDRC()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object fcDb8UDx7UaBkPqy8JyC(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static RuntimeTypeHandle eVsyhTDx8KTxqfmSFWwL(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
