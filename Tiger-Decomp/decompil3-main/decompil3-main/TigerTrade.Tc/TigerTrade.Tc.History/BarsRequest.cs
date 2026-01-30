using System;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.History;

public sealed class BarsRequest
{
	private static int _ids;

	internal static BarsRequest lyj9W15wngwXZTNxaRPB;

	public Symbol Symbol { get; set; }

	public string RequestID { get; set; }

	public string TargetID { get; }

	internal DateTime? StartDate { get; set; }

	internal DateTime? EndDate { get; set; }

	internal int PeriodBase { get; set; }

	internal int PeriodRepeat { get; set; }

	internal Symbol InternalSymbol { get; set; }

	internal string InternalID { get; set; }

	internal string InternalCode { get; set; }

	public BarsRequest(Symbol symbol, string requestID, string targetID)
	{
		cQQCIc5woZM27dmHcruk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				RequestID = requestID;
				TargetID = targetID;
				InternalSymbol = (Symbol)(MAgu535wv2IZnCrias5X(symbol) ?? symbol);
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
				{
					num = 0;
				}
				break;
			case 1:
			{
				int num2 = ++_ids;
				InternalID = num2.ToString((string)YZpFbQ5wBY4APJo5XWYI(--500511424 ^ 0x1DD5D76C));
				return;
			}
			default:
				Symbol = symbol;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	static BarsRequest()
	{
		fg6fHq5wags2rRBgVhiO();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool nJxn3Y5wGGfjIMHYpW6R()
	{
		return lyj9W15wngwXZTNxaRPB == null;
	}

	internal static BarsRequest kAHDqA5wY2YYDTeu1THg()
	{
		return lyj9W15wngwXZTNxaRPB;
	}

	internal static void cQQCIc5woZM27dmHcruk()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static object MAgu535wv2IZnCrias5X(object P_0)
	{
		return ((Symbol)P_0).GetSymbol();
	}

	internal static object YZpFbQ5wBY4APJo5XWYI(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void fg6fHq5wags2rRBgVhiO()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
