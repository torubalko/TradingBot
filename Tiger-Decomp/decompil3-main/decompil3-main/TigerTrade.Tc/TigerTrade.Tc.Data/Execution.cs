using System;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using mLJY4pY2D5OUPvF9bslY;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public sealed class Execution
{
	public static readonly string[] UsdtCurrency;

	private static long _localExecutionID;

	private static Execution HZpuef5zN0qWbrhGj5dj;

	public string ID { get; }

	public string ExecutionID { get; set; }

	public string OrderID { get; set; }

	public Symbol Symbol { get; }

	public Account Account { get; }

	public string Currency { get; set; }

	public DateTime Time { get; set; }

	public long Price { get; set; }

	public long Quantity { get; set; }

	public double? RealQuantity { get; set; }

	public Side Side { get; set; }

	public double? Comission { get; set; }

	public double? QuoteComission { get; set; }

	public bool IsBaseComission { get; set; }

	public qIRyR9Y24XhFakDdJT1k ComissionCurrency { get; set; }

	public double? RealizedPnl { get; set; }

	internal bool IgnorePosition { get; set; }

	internal bool IgnoreChecks { get; set; }

	internal string CombinedID => (string)vMT66j5z5FKHu3HREglK(ExecutionID, OrderID);

	internal string Message { get; set; }

	public ConnectionInfo Connection => (ConnectionInfo)o6TFIR5zSN62Eu0D6p8S(Account);

	public Execution(Symbol symbol, Account account)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				ID = Guid.NewGuid().ToString();
				return;
			}
			Symbol = symbol;
			Account = account;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 == 0)
			{
				num = 1;
			}
		}
	}

	internal static string GetLocalID()
	{
		long num = ++_localExecutionID;
		return num.ToString(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6EC99CAF ^ 0x6EC97903));
	}

	internal string Print()
	{
		return (string)qadvi65zxGDi3CEl8lCE(--134855371 ^ 0x809424D) + ExecutionID + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x741B85CB ^ 0x741B7D69) + OrderID + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x86EFEF6 ^ 0x86E064E) + Symbol?.Name + (string)qadvi65zxGDi3CEl8lCE(-490987856 ^ -490936708) + Account?.Name + (string)qadvi65zxGDi3CEl8lCE(-1311293279 ^ -1311252029) + string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x385FFAB ^ 0x3850749), Time, Price, Quantity, Side, IsBaseComission ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1763895751 ^ -1763839091) : ((ComissionCurrency == (qIRyR9Y24XhFakDdJT1k)2) ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x404ED0BE ^ 0x404E29E2) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-45476899 ^ -45418905)), Comission) + Message;
	}

	static Execution()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		UsdtCurrency = new string[4]
		{
			(string)qadvi65zxGDi3CEl8lCE(0xECA3F28 ^ 0xECAC64A),
			F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--737722733 ^ 0x2BF83803),
			F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-45476899 ^ -45421913),
			(string)qadvi65zxGDi3CEl8lCE(-1416986301 ^ -1416988469)
		};
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool OxB0CS5zkRLB1KBDSUOV()
	{
		return HZpuef5zN0qWbrhGj5dj == null;
	}

	internal static Execution fYyhWK5z1xIZBMvGg2SU()
	{
		return HZpuef5zN0qWbrhGj5dj;
	}

	internal static object vMT66j5z5FKHu3HREglK(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object o6TFIR5zSN62Eu0D6p8S(object P_0)
	{
		return ((Account)P_0).Connection;
	}

	internal static object qadvi65zxGDi3CEl8lCE(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}
}
