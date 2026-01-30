using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using aEpmU09nz6MEoNmc0pGJ;
using b1MaBhHjUYXjiIogoUaD;
using e5U3LQHshWhJmnHURKwr;
using ECOEgqlSad8NUJZ2Dr9n;
using PIK1LVHjqnwZDfDQB94a;
using TigerTrade.Tc;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace VuiGJlHXimZ8NsZe0QlI;

internal class IJVesUHXaYO5Og9P3vb3 : CD3s8vHjtnYG2KSjwERJ<Portfolio, PW2qlaHsmc0FKeEHtfs1>
{
	private static IJVesUHXaYO5Og9P3vb3 q1RLNkDE9n9haDHAwrEl;

	[SpecialName]
	public static string NXnHX4IIcRO()
	{
		return (string)m6Rj09DEYUVhywnJbABR(-1346994499 ^ -1347047197);
	}

	public IJVesUHXaYO5Og9P3vb3()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(NXnHX4IIcRO());
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		DataManager.OnPortfolio += DMTl9DqUpsF;
	}

	protected override string fpxl9ipreiH(DateTime P_0)
	{
		return j18iDj9nukSCmEyZs5lH.Bl69G2OdN8o(P_0);
	}

	protected override string eW5l9lOVbya(string P_0)
	{
		string[] array = (string[])sJx7ThDEoNZ7mIUWe266(P_0, new char[1] { ',' });
		if (array.Length < 10)
		{
			return "";
		}
		return array[6] + array[7] + array[9] + array[4] + array[5];
	}

	protected override long Yrgl94G8xJf(string P_0)
	{
		return -1L;
	}

	private static string GcTHXlBOWO2(Portfolio P_0)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				string text2 = (string)Ro3ndmDEipfYRnNaac8m(P_0.Connection);
				return text + text3 + text4 + text5 + text2;
			}
			case 1:
				text = PHiyjfHjO4OeOgqVJPSo.slbHjISNkXJ(P_0.Connection.ConnectionName);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			text3 = PHiyjfHjO4OeOgqVJPSo.slbHjISNkXJ((string)mTULSFDEvkUMGHLFWMPq(P_0));
			text4 = (string)NgPrjMDEBlcJ5Zx98237(P_0);
			text5 = (string)GYtFRIDEaVT69lXVL29F(P_0.Connection);
			num2 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
			{
				num2 = 2;
			}
		}
	}

	protected override void DMTl9DqUpsF(Portfolio P_0)
	{
		DateTime date = DateTime.UtcNow.Date;
		int num = 3;
		string key = default(string);
		CurrentItem value = default(CurrentItem);
		PW2qlaHsmc0FKeEHtfs1 pW2qlaHsmc0FKeEHtfs = default(PW2qlaHsmc0FKeEHtfs1);
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 3:
				if (qlPHjmBIMkE != null)
				{
					num = 9;
					continue;
				}
				break;
			case 6:
				key = (string)GRVfasDE4lexH2rSitfe(P_0);
				if (qlPHjmBIMkE.TryGetValue(key, out value) || !(vRwH2RDEDxLpD3JkVmrQ(P_0) <= 0.0))
				{
					pW2qlaHsmc0FKeEHtfs = new PW2qlaHsmc0FKeEHtfs1(P_0, GBpHjKpw9Q8);
					text = ywSl9bBBL3E(pW2qlaHsmc0FKeEHtfs);
					int num2 = 4;
					num = num2;
					continue;
				}
				return;
			default:
				qlPHjmBIMkE[key] = new CurrentItem(text, pW2qlaHsmc0FKeEHtfs);
				return;
			case 4:
				if (value != null)
				{
					if (!(value.mGWnr7VQHvZ != text))
					{
						return;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
					{
						num = 0;
					}
					continue;
				}
				goto default;
			case 9:
				if (qlPHjmBIMkE.Count == 0)
				{
					break;
				}
				goto case 1;
			case 8:
				GBpHjKpw9Q8 = date;
				qlPHjmBIMkE = new ConcurrentDictionary<string, CurrentItem>();
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
				{
					num = 5;
				}
				continue;
			case 2:
				wWNHjZK7UEu(GBpHjKpw9Q8);
				num = 6;
				continue;
			case 5:
				BwcOWUDElMmqJf5gN1Pg(this, GBpHjKpw9Q8, false);
				goto case 6;
			case 7:
				break;
			case 1:
				if (date > GBpHjKpw9Q8)
				{
					if (P_0.Balance <= 0.0)
					{
						return;
					}
					UpdHjVwu7Yh();
					num = 8;
					continue;
				}
				goto case 6;
			}
			if (P_0.Balance <= 0.0)
			{
				break;
			}
			GBpHjKpw9Q8 = date;
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
			{
				num = 1;
			}
		}
	}

	protected override string ywSl9bBBL3E(PW2qlaHsmc0FKeEHtfs1 P_0)
	{
		return (string)aw350fDESALM5eQXxZws(new string[19]
		{
			P_0.UserLicense,
			(string)m6Rj09DEYUVhywnJbABR(-1763895751 ^ -1763852277),
			(string)mEHHjODEbsS3w6q10R7M(P_0),
			stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2BD86B18 ^ 0x2BD8BD2A),
			(string)tJdf5BDENZYx3tFqRYbR(P_0),
			stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xAD5B8B3 ^ 0xAD56E81),
			P_0.BalanceDate,
			(string)m6Rj09DEYUVhywnJbABR(0x11D1040B ^ 0x11D1D239),
			(string)AGHVSRDEkZTj5LjH8hKM(P_0),
			stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x12620268 ^ 0x1262D45A),
			P_0.PlatformMarketType,
			stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1380525184 ^ -1380577870),
			(string)PfQZh4DE139y2QTdMAab(P_0),
			(string)m6Rj09DEYUVhywnJbABR(-5977659 ^ -6021129),
			(string)ynEOOwDE5rubw0ktYBIB(P_0),
			(string)m6Rj09DEYUVhywnJbABR(-842040449 ^ -842027699),
			P_0.Balance,
			(string)m6Rj09DEYUVhywnJbABR(--134855371 ^ 0x8096CF9),
			P_0.Currency
		});
	}

	static IJVesUHXaYO5Og9P3vb3()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object m6Rj09DEYUVhywnJbABR(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool BS8A3nDEnh0EpbHv5IPS()
	{
		return q1RLNkDE9n9haDHAwrEl == null;
	}

	internal static IJVesUHXaYO5Og9P3vb3 Hv2LVoDEGg9GeGrPH8k5()
	{
		return q1RLNkDE9n9haDHAwrEl;
	}

	internal static object sJx7ThDEoNZ7mIUWe266(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object mTULSFDEvkUMGHLFWMPq(object P_0)
	{
		return ((Portfolio)P_0).Name;
	}

	internal static object NgPrjMDEBlcJ5Zx98237(object P_0)
	{
		return ((Portfolio)P_0).Currency;
	}

	internal static object GYtFRIDEaVT69lXVL29F(object P_0)
	{
		return ((ConnectionInfo)P_0).TradeClientName;
	}

	internal static object Ro3ndmDEipfYRnNaac8m(object P_0)
	{
		return ((ConnectionInfo)P_0).MarketType;
	}

	internal static void BwcOWUDElMmqJf5gN1Pg(object P_0, DateTime P_1, bool P_2)
	{
		((CD3s8vHjtnYG2KSjwERJ<Portfolio, PW2qlaHsmc0FKeEHtfs1>)P_0).wWNHjZK7UEu(P_1, P_2);
	}

	internal static object GRVfasDE4lexH2rSitfe(object P_0)
	{
		return GcTHXlBOWO2((Portfolio)P_0);
	}

	internal static double vRwH2RDEDxLpD3JkVmrQ(object P_0)
	{
		return ((Portfolio)P_0).Balance;
	}

	internal static object mEHHjODEbsS3w6q10R7M(object P_0)
	{
		return ((PW2qlaHsmc0FKeEHtfs1)P_0).t15Hs7vIIlk();
	}

	internal static object tJdf5BDENZYx3tFqRYbR(object P_0)
	{
		return ((PW2qlaHsmc0FKeEHtfs1)P_0).UmvHsA58cDf();
	}

	internal static object AGHVSRDEkZTj5LjH8hKM(object P_0)
	{
		return ((PW2qlaHsmc0FKeEHtfs1)P_0).Platform;
	}

	internal static object PfQZh4DE139y2QTdMAab(object P_0)
	{
		return ((PW2qlaHsmc0FKeEHtfs1)P_0).PlatformUserName;
	}

	internal static object ynEOOwDE5rubw0ktYBIB(object P_0)
	{
		return ((PW2qlaHsmc0FKeEHtfs1)P_0).Name;
	}

	internal static object aw350fDESALM5eQXxZws(object P_0)
	{
		return string.Concat((string[])P_0);
	}
}
