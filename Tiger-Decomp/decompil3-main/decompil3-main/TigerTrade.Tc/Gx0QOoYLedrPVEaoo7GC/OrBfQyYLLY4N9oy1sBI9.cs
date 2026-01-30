using System.Collections.Generic;
using System.Threading;
using BcoytMGPUsbcVatGjnE4;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace Gx0QOoYLedrPVEaoo7GC;

internal sealed class OrBfQyYLLY4N9oy1sBI9
{
	private readonly Dictionary<string, nmx7s7GPtwKBjsWDiN4X> eRjYLcyWFJl;

	internal static OrBfQyYLLY4N9oy1sBI9 VlwLCASNhQJSi0SxnhND;

	public void O01YLsQkA5g(Symbol P_0, TickEvent P_1)
	{
		int num = 2;
		int num2 = num;
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> dictionary = default(Dictionary<string, nmx7s7GPtwKBjsWDiN4X>);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (P_0 == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				if (P_1 == null)
				{
					return;
				}
				dictionary = eRjYLcyWFJl;
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				Monitor.Enter(dictionary, ref lockTaken);
				if (eRjYLcyWFJl.ContainsKey(P_0.ID))
				{
					eRjYLcyWFJl[P_0.ID].B9CGPTomDT2(P_1);
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						break;
					}
				}
				eRjYLcyWFJl.Add(P_0.ID, new nmx7s7GPtwKBjsWDiN4X(P_0.Step));
				return;
			}
			finally
			{
				if (lockTaken)
				{
					BN9tYZSN8fBZrTdXjkxv(dictionary);
				}
			}
		}
	}

	public byte[] pQOYLXaC82N(string P_0)
	{
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> dictionary = eRjYLcyWFJl;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(dictionary, ref lockTaken);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => eRjYLcyWFJl.ContainsKey(P_0) ? eRjYLcyWFJl[P_0].cTAGPyTyIW4() : new byte[0], 
			};
		}
		finally
		{
			if (lockTaken)
			{
				BN9tYZSN8fBZrTdXjkxv(dictionary);
			}
		}
	}

	public void Clear()
	{
		int num = 1;
		int num2 = num;
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> obj = default(Dictionary<string, nmx7s7GPtwKBjsWDiN4X>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = eRjYLcyWFJl;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				yv7ayoSNAVZQKvZhf6k1(eRjYLcyWFJl);
				return;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
		}
	}

	public OrBfQyYLLY4N9oy1sBI9()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		eRjYLcyWFJl = new Dictionary<string, nmx7s7GPtwKBjsWDiN4X>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static OrBfQyYLLY4N9oy1sBI9()
	{
		skdXOnSNPFR59RDasWjf();
		vFkW8mSNJ3gND1Ltl6Ra();
	}

	internal static void BN9tYZSN8fBZrTdXjkxv(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool BltkFSSNwPov7skQc0lu()
	{
		return VlwLCASNhQJSi0SxnhND == null;
	}

	internal static OrBfQyYLLY4N9oy1sBI9 rQ9uStSN7Q1NrlJCYq7X()
	{
		return VlwLCASNhQJSi0SxnhND;
	}

	internal static void yv7ayoSNAVZQKvZhf6k1(object P_0)
	{
		((Dictionary<string, nmx7s7GPtwKBjsWDiN4X>)P_0).Clear();
	}

	internal static void skdXOnSNPFR59RDasWjf()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void vFkW8mSNJ3gND1Ltl6Ra()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
