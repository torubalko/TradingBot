using System;
using System.Globalization;
using System.Text.RegularExpressions;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using waDpctGJom9MvAveNXHq;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public abstract class SymbolBase
{
	private static SymbolBase wLVjO153BjZxVw4PeNst;

	public double Step { get; internal set; }

	public double SizeStep { get; set; }

	public double ContractValue { get; set; }

	public bool IsDenomination { get; set; }

	public string Exchange { get; set; }

	public bool NeedHistoryCorrect { get; set; }

	public double HistoryCorrectSizeFactor
	{
		get
		{
			if (!NeedHistoryCorrect)
			{
				return 1.0;
			}
			return ContractValue;
		}
	}

	public long GetShortSize(double size)
	{
		return obDPJA53lbjUTrOSurGO(Math.Round(GetShortSizeRaw(size), MidpointRounding.AwayFromZero));
	}

	public decimal GetShortSizeRaw(double size)
	{
		if (!IsDenomination)
		{
			return DI52a3534OlXatuTSPl7((decimal)size, (decimal)SizeStep);
		}
		return dO4Ccm53Diby7Mw8Gf5F(size);
	}

	public decimal GetShortSizeRaw(decimal size)
	{
		if (!IsDenomination)
		{
			return size / (decimal)SizeStep;
		}
		return size;
	}

	public long GetMinShortSize(decimal size)
	{
		return (long)GetShortSizeRaw(size);
	}

	public long? GetShortSize(double? size)
	{
		if (!size.HasValue)
		{
			return null;
		}
		return GetShortSize(size.Value);
	}

	public double GetRealSize(long size)
	{
		if (!IsDenomination)
		{
			return (double)size * SizeStep;
		}
		return (double)size * ContractValue;
	}

	public string GetSizeInContractsStr(double size)
	{
		return dO4Ccm53Diby7Mw8Gf5F(size / ContractValue).ToString(CultureInfo.InvariantCulture);
	}

	public string FormatRawSizeFull(long size)
	{
		if (IsDenomination)
		{
			return ((double)size * ContractValue).ToString(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--18459671 ^ 0x11941E3));
		}
		if (!(SizeStep < 1.0))
		{
			return size.ToString((string)aTSoh253bv6IyDEDUflo(0x4297C3EB ^ 0x42972E1F));
		}
		double num = (double)size * SizeStep;
		int num2 = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
		{
			num2 = 0;
		}
		return num2 switch
		{
			_ => num.ToString(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-490987856 ^ -490933490)), 
		};
	}

	public string FormatMoneyPnl(double money)
	{
		if (Math.Abs(money) >= 0.1 || money == 0.0 || !cphSok53NXP27OF0HNh7(Exchange))
		{
			return money.ToString(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1487846E ^ 0x14876AAA));
		}
		Regex regex = new Regex(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2123795572 ^ -2123784872));
		string input = money.ToString(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x684F243E ^ 0x684FCB3C));
		Match match = regex.Match(input);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return match.Value;
			}
			if (!BWIieK53k7Regkx8p5lB(match))
			{
				return (string)aTSoh253bv6IyDEDUflo(-520155535 ^ -520101539);
			}
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
			{
				num = 0;
			}
		}
	}

	public double GetQuoteSize(long size, long price)
	{
		if (IsDenomination)
		{
			return (double)price * Step * ((double)size * ContractValue);
		}
		if (!(SizeStep < 1.0))
		{
			return (double)price * Step * (double)size;
		}
		return (double)price * Step * ((double)size * SizeStep);
	}

	protected SymbolBase()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static SymbolBase()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		lUjnuY531wdQnPfo2Aka();
	}

	internal static bool odEHI853ahIQvPA4N6tN()
	{
		return wLVjO153BjZxVw4PeNst == null;
	}

	internal static SymbolBase wo0SKK53ilrfJK8o7bH7()
	{
		return wLVjO153BjZxVw4PeNst;
	}

	internal static long obDPJA53lbjUTrOSurGO(decimal P_0)
	{
		return (long)P_0;
	}

	internal static decimal DI52a3534OlXatuTSPl7(decimal P_0, decimal P_1)
	{
		return P_0 / P_1;
	}

	internal static decimal dO4Ccm53Diby7Mw8Gf5F(double P_0)
	{
		return (decimal)P_0;
	}

	internal static object aTSoh253bv6IyDEDUflo(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool cphSok53NXP27OF0HNh7(object P_0)
	{
		return JLFqEJGJYiHaSdoROJXI.WTeGJv6DrNH((string)P_0);
	}

	internal static bool BWIieK53k7Regkx8p5lB(object P_0)
	{
		return ((Group)P_0).Success;
	}

	internal static void lUjnuY531wdQnPfo2Aka()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
