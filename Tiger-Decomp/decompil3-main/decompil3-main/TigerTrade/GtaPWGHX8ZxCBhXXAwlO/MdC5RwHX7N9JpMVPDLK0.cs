using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using aEpmU09nz6MEoNmc0pGJ;
using b1MaBhHjUYXjiIogoUaD;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using zPklhkHXNfgJgwPJbhdn;

namespace GtaPWGHX8ZxCBhXXAwlO;

internal class MdC5RwHX7N9JpMVPDLK0 : CD3s8vHjtnYG2KSjwERJ<Execution, eOqskuHXbmpqXIrs72Bo>
{
	private static MdC5RwHX7N9JpMVPDLK0 zKCI2EDEq0UAZmlSFnPi;

	[SpecialName]
	public static string BwyHXAXrlmH()
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1EFE0A28 ^ 0x1EFDC582);
	}

	[SpecialName]
	public static string bo7HXJZnuN4()
	{
		return (string)c8dopmDEtbiysia0TTWV(-45476899 ^ -45491009);
	}

	[SpecialName]
	public static string t0kHX3MRDi6()
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BD60B4);
	}

	public MdC5RwHX7N9JpMVPDLK0()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(BwyHXAXrlmH());
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		DataManager.OnExecution += DMTl9DqUpsF;
	}

	protected override string fpxl9ipreiH(DateTime P_0)
	{
		return j18iDj9nukSCmEyZs5lH.UyX9G0frMuo(P_0);
	}

	protected override string eW5l9lOVbya(string P_0)
	{
		int num = 1;
		int num2 = num;
		string[] array = default(string[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return "";
			case 1:
				array = (string[])VQ2TVjDEU3CAGYttlyfU(P_0, new char[1] { ',' });
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (array.Length >= 5)
				{
					string text = array[1];
					string text2 = array[4];
					return text + (string)c8dopmDEtbiysia0TTWV(-1346994499 ^ -1347005459) + text2;
				}
				goto case 2;
			}
		}
	}

	protected override long Yrgl94G8xJf(string P_0)
	{
		string[] array = (string[])VQ2TVjDEU3CAGYttlyfU(P_0, new char[1] { ',' });
		if (array.Length < 5)
		{
			return -1L;
		}
		if (long.TryParse(array[4], out var result))
		{
			return result;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => -1L, 
		};
	}

	protected override void DMTl9DqUpsF(Execution P_0)
	{
		int num = 3;
		string key2 = default(string);
		eOqskuHXbmpqXIrs72Bo eOqskuHXbmpqXIrs72Bo = default(eOqskuHXbmpqXIrs72Bo);
		DateTimeOffset dateTimeOffset = default(DateTimeOffset);
		DateTime dateTime = default(DateTime);
		long key = default(long);
		long num3 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				DateTime dateTime2;
				switch (num2)
				{
				case 1:
					qlPHjmBIMkE.TryAdd(key2, new CurrentItem(ywSl9bBBL3E(eOqskuHXbmpqXIrs72Bo), eOqskuHXbmpqXIrs72Bo));
					goto default;
				case 11:
					qeB0iODEKuUjD3yamRfc(this);
					num2 = 9;
					break;
				case 7:
					VJ5f08DErpqLZDlUxlL9(this, GBpHjKpw9Q8, false);
					goto IL_0095;
				default:
					dateTimeOffset = new DateTimeOffset(dateTime.Date);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
					{
						num2 = 8;
					}
					break;
				case 10:
					return;
				case 8:
					key = dateTimeOffset.ToUnixTimeMilliseconds();
					dateTimeOffset = new DateTimeOffset(dateTime);
					num3 = dateTimeOffset.ToUnixTimeMilliseconds();
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
					{
						num2 = 12;
					}
					break;
				case 12:
				{
					if (sbrHj8dPHT1.TryGetValue(key, out var value))
					{
						if (num3 > value)
						{
							sbrHj8dPHT1[key] = num3;
						}
						return;
					}
					sbrHj8dPHT1.Add(key, num3);
					num2 = 10;
					break;
				}
				case 6:
					qlPHjmBIMkE = new ConcurrentDictionary<string, CurrentItem>();
					VJ5f08DErpqLZDlUxlL9(this, GBpHjKpw9Q8, false);
					goto IL_0095;
				case 2:
					dateTime2 = TimeHelper.ConvertFromExchangeTimeToUtc(P_0.Time, (string)fXxpgaDEZ3m6KTU35nQC(P_0.Symbol));
					goto IL_02e4;
				case 3:
					if (!QNdb5jDEyIRNI2dMBDaq(NrvLWLDETWT1fP6qtlp6(P_0)))
					{
						goto end_IL_0012;
					}
					dateTime2 = IltgaSDEVm60BK49hEe3();
					goto IL_02e4;
				case 5:
					GBpHjKpw9Q8 = dateTime;
					num2 = 7;
					break;
				case 9:
					GBpHjKpw9Q8 = dateTime;
					num2 = 6;
					break;
				case 4:
					{
						if (x8EVwDDECFEs82UdxedB(qlPHjmBIMkE) != 0)
						{
							if (dateTime.Date > GBpHjKpw9Q8.Date)
							{
								num2 = 11;
								break;
							}
							goto IL_0095;
						}
						goto case 5;
					}
					IL_02e4:
					dateTime = dateTime2;
					if (qlPHjmBIMkE != null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 5;
					IL_0095:
					eOqskuHXbmpqXIrs72Bo = new eOqskuHXbmpqXIrs72Bo(P_0);
					key2 = eOqskuHXbmpqXIrs72Bo.eFWHXkubHxc();
					if (dateTime.Date == GBpHjKpw9Q8.Date)
					{
						if (!qlPHjmBIMkE.ContainsKey(key2))
						{
							goto case 1;
						}
						goto default;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	protected override string ywSl9bBBL3E(eOqskuHXbmpqXIrs72Bo P_0)
	{
		return (string)GABNpgDEmdlniN6ZMRpq(P_0) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28C965BE ^ 0x28C9B38C) + P_0.TradeId + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1416997007) + P_0.BL8HXxcosuo() + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-176525661 ^ -176506735) + P_0.RV3HXeynAqm() + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1A5F1B9E ^ 0x1A5FCDAC) + (string)G0UnPHDEhM8kb6BXHEWM(P_0) + (string)c8dopmDEtbiysia0TTWV(--134855371 ^ 0x8096CF9) + P_0.Platform + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1087080834 ^ -1087070132) + P_0.PlatformMarketType + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746E0237) + (string)sEXvILDEw93Vjdjak0qO(P_0) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x42D899B5 ^ 0x42D84F87) + P_0.SymbolType + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6EC99CAF ^ 0x6EC94A9D) + P_0.IsCrypto + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x385FFAB ^ 0x3852999) + P_0.Quantity + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461949456 ^ -1461928510) + P_0.Side + (string)c8dopmDEtbiysia0TTWV(0x37B74BDF ^ 0x37B79DED) + (string)x20ejKDE7Abv0Wk3S0N2(P_0) + (string)c8dopmDEtbiysia0TTWV(0x769C7931 ^ 0x769CAF03) + (string)eEDT5SDE8wLFkLjDatJE(P_0) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7394D272 ^ 0x73940440) + (string)FeG5bvDEAlW79qu1xsQX(P_0);
	}

	static MdC5RwHX7N9JpMVPDLK0()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool k2YFetDEIGv9tquGZjLx()
	{
		return zKCI2EDEq0UAZmlSFnPi == null;
	}

	internal static MdC5RwHX7N9JpMVPDLK0 diKm1pDEWREZO5UZh23i()
	{
		return zKCI2EDEq0UAZmlSFnPi;
	}

	internal static object c8dopmDEtbiysia0TTWV(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object VQ2TVjDEU3CAGYttlyfU(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object NrvLWLDETWT1fP6qtlp6(object P_0)
	{
		return ((Execution)P_0).Account;
	}

	internal static bool QNdb5jDEyIRNI2dMBDaq(object P_0)
	{
		return ((Account)P_0).IsPlayer;
	}

	internal static object fXxpgaDEZ3m6KTU35nQC(object P_0)
	{
		return ((SymbolBase)P_0).Exchange;
	}

	internal static DateTime IltgaSDEVm60BK49hEe3()
	{
		return DateTime.UtcNow;
	}

	internal static int x8EVwDDECFEs82UdxedB(object P_0)
	{
		return ((ConcurrentDictionary<string, CurrentItem>)P_0).Count;
	}

	internal static void VJ5f08DErpqLZDlUxlL9(object P_0, DateTime P_1, bool P_2)
	{
		((CD3s8vHjtnYG2KSjwERJ<Execution, eOqskuHXbmpqXIrs72Bo>)P_0).wWNHjZK7UEu(P_1, P_2);
	}

	internal static void qeB0iODEKuUjD3yamRfc(object P_0)
	{
		((CD3s8vHjtnYG2KSjwERJ<Execution, eOqskuHXbmpqXIrs72Bo>)P_0).UpdHjVwu7Yh();
	}

	internal static object GABNpgDEmdlniN6ZMRpq(object P_0)
	{
		return ((eOqskuHXbmpqXIrs72Bo)P_0).UserLicense;
	}

	internal static object G0UnPHDEhM8kb6BXHEWM(object P_0)
	{
		return ((eOqskuHXbmpqXIrs72Bo)P_0).TradeUtcTime;
	}

	internal static object sEXvILDEw93Vjdjak0qO(object P_0)
	{
		return ((eOqskuHXbmpqXIrs72Bo)P_0).SymbolName;
	}

	internal static object x20ejKDE7Abv0Wk3S0N2(object P_0)
	{
		return ((eOqskuHXbmpqXIrs72Bo)P_0).Price;
	}

	internal static object eEDT5SDE8wLFkLjDatJE(object P_0)
	{
		return ((eOqskuHXbmpqXIrs72Bo)P_0).Currency;
	}

	internal static object FeG5bvDEAlW79qu1xsQX(object P_0)
	{
		return ((eOqskuHXbmpqXIrs72Bo)P_0).RecordType;
	}
}
