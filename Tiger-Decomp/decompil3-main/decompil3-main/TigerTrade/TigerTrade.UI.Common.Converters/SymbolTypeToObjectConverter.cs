using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace TigerTrade.UI.Common.Converters;

public class SymbolTypeToObjectConverter : DependencyObject, IValueConverter
{
	public static readonly DependencyProperty HoIH5KtmG1m;

	public static readonly DependencyProperty q7aH5mxlvko;

	internal static SymbolTypeToObjectConverter gjiRb6DLURiHFvURZpGx;

	public ControlTemplate Crypto
	{
		get
		{
			return (ControlTemplate)GetValue(HoIH5KtmG1m);
		}
		set
		{
			SetValue(HoIH5KtmG1m, value2);
		}
	}

	public ControlTemplate Future
	{
		get
		{
			return (ControlTemplate)fs02EiDLZISkoMxXgeOu(this, q7aH5mxlvko);
		}
		set
		{
			SetValue(q7aH5mxlvko, value2);
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (!(P_0 is SymbolType symbolType))
		{
			return null;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				switch (symbolType)
				{
				case SymbolType.Crypto:
					return Crypto;
				case SymbolType.Future:
					return Future;
				case SymbolType.Unknown:
				case SymbolType.Index:
				case SymbolType.Option:
				case SymbolType.Stock:
				case SymbolType.Currency:
				case SymbolType.Forex:
					break;
				default:
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
			break;
		}
		return null;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public SymbolTypeToObjectConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static SymbolTypeToObjectConverter()
	{
		XburrdDLVipnfxACmBkI();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		HoIH5KtmG1m = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-371631841 ^ -371650107), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), e5nkKaDLCGR1QmDxLg0A(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555324)));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		q7aH5mxlvko = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B19A2E), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555324)));
	}

	internal static bool NeuEyBDLTkbmo76ImWio()
	{
		return gjiRb6DLURiHFvURZpGx == null;
	}

	internal static SymbolTypeToObjectConverter SQLnjwDLylCHQxrTX5AZ()
	{
		return gjiRb6DLURiHFvURZpGx;
	}

	internal static object fs02EiDLZISkoMxXgeOu(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void XburrdDLVipnfxACmBkI()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static Type e5nkKaDLCGR1QmDxLg0A(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
