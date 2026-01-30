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

public class SymbolExchangeToObjectConverter : DependencyObject, IValueConverter
{
	public static readonly DependencyProperty Du8H1RYXKwK;

	public static readonly DependencyProperty bTSH163G615;

	public static readonly DependencyProperty BVSH1MG0IWU;

	public static readonly DependencyProperty YMKH1O7r8a8;

	public static readonly DependencyProperty p8bH1qRVMtd;

	public static readonly DependencyProperty AM5H1I6btCI;

	public static readonly DependencyProperty I2IH1W5tvGw;

	public static readonly DependencyProperty rJtH1tngJG9;

	public static readonly DependencyProperty NUoH1U01v7c;

	public static readonly DependencyProperty BAFH1T8vMAL;

	public static readonly DependencyProperty A8OH1y7hw9B;

	public static readonly DependencyProperty ID3H1Zu0iXL;

	public static readonly DependencyProperty z1NH1VJB55E;

	public static readonly DependencyProperty JxHH1CIOmrN;

	public static readonly DependencyProperty ReqH1rB5Cvp;

	public static readonly DependencyProperty WKLH1K9WXXB;

	public static readonly DependencyProperty EOLH1mLVG62;

	public static readonly DependencyProperty L6HH1hnNkfT;

	public static readonly DependencyProperty KmcH1wBxdgk;

	internal static SymbolExchangeToObjectConverter ryoLRvDLnPAUsAQVh4s2;

	public ControlTemplate Nyse
	{
		get
		{
			return (ControlTemplate)v2qXK7DLoJxyweenCt9L(this, Du8H1RYXKwK);
		}
		set
		{
			SetValue(Du8H1RYXKwK, value2);
		}
	}

	public ControlTemplate Nasdaq
	{
		get
		{
			return (ControlTemplate)v2qXK7DLoJxyweenCt9L(this, bTSH163G615);
		}
		set
		{
			SetValue(bTSH163G615, value2);
		}
	}

	public ControlTemplate Moex
	{
		get
		{
			return (ControlTemplate)GetValue(BVSH1MG0IWU);
		}
		set
		{
			SetValue(BVSH1MG0IWU, value2);
		}
	}

	public ControlTemplate Ice
	{
		get
		{
			return (ControlTemplate)v2qXK7DLoJxyweenCt9L(this, YMKH1O7r8a8);
		}
		set
		{
			vTHc4FDLv4q9hJq1cNok(this, YMKH1O7r8a8, controlTemplate);
		}
	}

	public ControlTemplate Cme
	{
		get
		{
			return (ControlTemplate)GetValue(p8bH1qRVMtd);
		}
		set
		{
			vTHc4FDLv4q9hJq1cNok(this, p8bH1qRVMtd, controlTemplate);
		}
	}

	public ControlTemplate Fxcm
	{
		get
		{
			return (ControlTemplate)GetValue(AM5H1I6btCI);
		}
		set
		{
			SetValue(AM5H1I6btCI, value2);
		}
	}

	public ControlTemplate Eurex
	{
		get
		{
			return (ControlTemplate)GetValue(I2IH1W5tvGw);
		}
		set
		{
			vTHc4FDLv4q9hJq1cNok(this, I2IH1W5tvGw, controlTemplate);
		}
	}

	public ControlTemplate Backpack
	{
		get
		{
			return (ControlTemplate)GetValue(rJtH1tngJG9);
		}
		set
		{
			SetValue(rJtH1tngJG9, value2);
		}
	}

	public ControlTemplate Binance
	{
		get
		{
			return (ControlTemplate)GetValue(NUoH1U01v7c);
		}
		set
		{
			SetValue(NUoH1U01v7c, value2);
		}
	}

	public ControlTemplate BinanceX
	{
		get
		{
			return (ControlTemplate)v2qXK7DLoJxyweenCt9L(this, BAFH1T8vMAL);
		}
		set
		{
			SetValue(BAFH1T8vMAL, value2);
		}
	}

	public ControlTemplate Bybit
	{
		get
		{
			return (ControlTemplate)GetValue(A8OH1y7hw9B);
		}
		set
		{
			SetValue(A8OH1y7hw9B, value2);
		}
	}

	public ControlTemplate Bitfinex
	{
		get
		{
			return (ControlTemplate)GetValue(ID3H1Zu0iXL);
		}
		set
		{
			SetValue(ID3H1Zu0iXL, value2);
		}
	}

	public ControlTemplate Bitmex
	{
		get
		{
			return (ControlTemplate)GetValue(z1NH1VJB55E);
		}
		set
		{
			SetValue(z1NH1VJB55E, value2);
		}
	}

	public ControlTemplate GateIo
	{
		get
		{
			return (ControlTemplate)v2qXK7DLoJxyweenCt9L(this, JxHH1CIOmrN);
		}
		set
		{
			SetValue(JxHH1CIOmrN, value2);
		}
	}

	public ControlTemplate Mexc
	{
		get
		{
			return (ControlTemplate)GetValue(ReqH1rB5Cvp);
		}
		set
		{
			vTHc4FDLv4q9hJq1cNok(this, ReqH1rB5Cvp, controlTemplate);
		}
	}

	public ControlTemplate Okx
	{
		get
		{
			return (ControlTemplate)GetValue(WKLH1K9WXXB);
		}
		set
		{
			SetValue(WKLH1K9WXXB, value2);
		}
	}

	public ControlTemplate OkxX
	{
		get
		{
			return (ControlTemplate)GetValue(EOLH1mLVG62);
		}
		set
		{
			SetValue(EOLH1mLVG62, value2);
		}
	}

	public ControlTemplate Bitget
	{
		get
		{
			return (ControlTemplate)GetValue(L6HH1hnNkfT);
		}
		set
		{
			SetValue(L6HH1hnNkfT, value2);
		}
	}

	public ControlTemplate Undefined
	{
		get
		{
			return (ControlTemplate)v2qXK7DLoJxyweenCt9L(this, KmcH1wBxdgk);
		}
		set
		{
			SetValue(KmcH1wBxdgk, value2);
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (!(P_0 is Symbol symbol))
		{
			return null;
		}
		if (symbol.IsBinance)
		{
			return Binance;
		}
		int num;
		if (symbol.IsBinanceX)
		{
			num = 10;
		}
		else
		{
			if (hiot4oDLBTbOXHZ7Ztrb(symbol))
			{
				return Bybit;
			}
			if (!zBv6b4DLabvjcTA70sZe(symbol))
			{
				if (symbol.IsOkxX)
				{
					goto IL_0196;
				}
				if (symbol.IsMEXC)
				{
					return Mexc;
				}
				if (symbol.IsGateIo)
				{
					return GateIo;
				}
				if (cE9IUTDLi06eBhF0DsYa(symbol))
				{
					return Bitfinex;
				}
				if (symbol.IsBitMEX)
				{
					goto IL_0079;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
				{
					num = 0;
				}
			}
			else
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
				{
					num = 1;
				}
			}
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				return Cme;
			case 6:
				break;
			default:
				goto IL_0080;
			case 9:
				goto IL_009e;
			case 1:
				return Okx;
			case 10:
				return BinanceX;
			case 2:
				return Eurex;
			case 8:
				goto IL_0196;
			case 3:
				return Ice;
			case 7:
				return Nyse;
			case 4:
				return Backpack;
			}
			break;
			IL_0080:
			if (OKukO6DLlSf9rjDPl40J(symbol))
			{
				return Bitget;
			}
			if (symbol.IsBackpack)
			{
				int num2 = 4;
				num = num2;
				continue;
			}
			if (symbol.IsMoex)
			{
				goto IL_009e;
			}
			if (!symbol.IsCme)
			{
				if (BesN5FDL4HPQ7rQ61vMF(symbol))
				{
					num = 3;
					continue;
				}
				if (!symbol.IsEurex)
				{
					if (NZQbBBDLDbPH7e2our0H(symbol))
					{
						return Fxcm;
					}
					if (symbol.IsNyse)
					{
						num = 7;
						continue;
					}
					goto IL_0236;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
				{
					num = 2;
				}
				continue;
			}
			num = 5;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
			{
				num = 4;
			}
			continue;
			IL_009e:
			return Moex;
		}
		goto IL_0079;
		IL_0196:
		return OkxX;
		IL_0236:
		if (symbol.IsNasdaq)
		{
			return Nasdaq;
		}
		return Undefined;
		IL_0079:
		return Bitmex;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public SymbolExchangeToObjectConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static SymbolExchangeToObjectConverter()
	{
		lUQy2MDLb3vjVZNEWSlQ();
		jsBEhkDLNy00JKjQxIft();
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 6:
				JxHH1CIOmrN = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1999650146 ^ -1999707744), Eh0FyZDL152Xey3WRhSQ(lA5NxODLSCBiySPFdWsw(16777453)), Type.GetTypeFromHandle(lA5NxODLSCBiySPFdWsw(33555320)));
				ReqH1rB5Cvp = (DependencyProperty)FPUDoxDL5oaKKa0R2BhS(F7oIOmDLklQm7XbRquQg(0x6D18F862 ^ 0x6D19DB2C), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				num = 4;
				break;
			case 8:
				BVSH1MG0IWU = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x22BF43FC ^ 0x22BE6150), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
				{
					num = 2;
				}
				break;
			case 3:
				rJtH1tngJG9 = DependencyProperty.Register((string)F7oIOmDLklQm7XbRquQg(0x6AB40973 ^ 0x6AB464F7), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
				{
					num = 0;
				}
				break;
			case 5:
				AM5H1I6btCI = (DependencyProperty)FPUDoxDL5oaKKa0R2BhS(F7oIOmDLklQm7XbRquQg(--146713930 ^ 0x8BF8F86), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				I2IH1W5tvGw = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x130FEA25 ^ 0x130EC8FD), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Eh0FyZDL152Xey3WRhSQ(lA5NxODLSCBiySPFdWsw(33555320)));
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				WKLH1K9WXXB = (DependencyProperty)FPUDoxDL5oaKKa0R2BhS(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-690510723 ^ -690583769), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				EOLH1mLVG62 = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E050594), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				L6HH1hnNkfT = (DependencyProperty)FPUDoxDL5oaKKa0R2BhS(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29709906), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Type.GetTypeFromHandle(lA5NxODLSCBiySPFdWsw(33555320)));
				KmcH1wBxdgk = DependencyProperty.Register((string)F7oIOmDLklQm7XbRquQg(0x68C7EAE6 ^ 0x68C6C996), Type.GetTypeFromHandle(lA5NxODLSCBiySPFdWsw(16777453)), Type.GetTypeFromHandle(lA5NxODLSCBiySPFdWsw(33555320)));
				return;
			case 7:
				Du8H1RYXKwK = (DependencyProperty)FPUDoxDL5oaKKa0R2BhS(F7oIOmDLklQm7XbRquQg(--18459671 ^ 0x1188E87), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				bTSH163G615 = (DependencyProperty)FPUDoxDL5oaKKa0R2BhS(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842114589), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
				{
					num = 8;
				}
				break;
			default:
				NUoH1U01v7c = (DependencyProperty)FPUDoxDL5oaKKa0R2BhS(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53839022), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				BAFH1T8vMAL = (DependencyProperty)FPUDoxDL5oaKKa0R2BhS(F7oIOmDLklQm7XbRquQg(0x6EC99CAF ^ 0x6EC8BE57), Type.GetTypeFromHandle(lA5NxODLSCBiySPFdWsw(16777453)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				A8OH1y7hw9B = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x130FEA25 ^ 0x130EC929), Type.GetTypeFromHandle(lA5NxODLSCBiySPFdWsw(16777453)), Eh0FyZDL152Xey3WRhSQ(lA5NxODLSCBiySPFdWsw(33555320)));
				ID3H1Zu0iXL = DependencyProperty.Register((string)F7oIOmDLklQm7XbRquQg(0x446AB724 ^ 0x446B943E), Eh0FyZDL152Xey3WRhSQ(lA5NxODLSCBiySPFdWsw(16777453)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				z1NH1VJB55E = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28BBDCA ^ 0x28A9EE4), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
				{
					num = 6;
				}
				break;
			case 2:
				YMKH1O7r8a8 = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461292091 ^ -1461235331), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				p8bH1qRVMtd = DependencyProperty.Register((string)F7oIOmDLklQm7XbRquQg(-671204305 ^ -671146259), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), Eh0FyZDL152Xey3WRhSQ(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555320)));
				num = 5;
				break;
			}
		}
	}

	internal static object v2qXK7DLoJxyweenCt9L(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static bool zISyUgDLGrGyBPLWpQXX()
	{
		return ryoLRvDLnPAUsAQVh4s2 == null;
	}

	internal static SymbolExchangeToObjectConverter hXDxakDLYvf4IltE03OY()
	{
		return ryoLRvDLnPAUsAQVh4s2;
	}

	internal static void vTHc4FDLv4q9hJq1cNok(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static bool hiot4oDLBTbOXHZ7Ztrb(object P_0)
	{
		return ((Symbol)P_0).IsBybit;
	}

	internal static bool zBv6b4DLabvjcTA70sZe(object P_0)
	{
		return ((Symbol)P_0).IsOKX;
	}

	internal static bool cE9IUTDLi06eBhF0DsYa(object P_0)
	{
		return ((Symbol)P_0).IsBitFinex;
	}

	internal static bool OKukO6DLlSf9rjDPl40J(object P_0)
	{
		return ((Symbol)P_0).IsBitget;
	}

	internal static bool BesN5FDL4HPQ7rQ61vMF(object P_0)
	{
		return ((Symbol)P_0).IsIce;
	}

	internal static bool NZQbBBDLDbPH7e2our0H(object P_0)
	{
		return ((Symbol)P_0).IsFxcm;
	}

	internal static void lUQy2MDLb3vjVZNEWSlQ()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void jsBEhkDLNy00JKjQxIft()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object F7oIOmDLklQm7XbRquQg(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static Type Eh0FyZDL152Xey3WRhSQ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object FPUDoxDL5oaKKa0R2BhS(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}

	internal static RuntimeTypeHandle lA5NxODLSCBiySPFdWsw(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
