using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.History;

public sealed class TicksRequest
{
	internal static TicksRequest hUMQ2q5wFY7wh0DfyyNk;

	public Symbol Symbol { get; set; }

	public string RequestID { get; set; }

	public string TargetID { get; }

	public bool CustomData { get; set; }

	internal Symbol InternalSymbol { get; set; }

	internal string InternalCode { get; set; }

	public TicksRequest(Symbol symbol, string requestID, string targetID, bool customData)
	{
		QuZUgL5wuvggy105JGw7();
		base._002Ector();
		Symbol = symbol;
		RequestID = requestID;
		TargetID = targetID;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				CustomData = customData;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				InternalSymbol = symbol.GetSymbol() ?? symbol;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	static TicksRequest()
	{
		dSCbYq5wzQbpahIhB3gn();
		T5W61K570fjbuT9rPpov();
	}

	internal static bool tyLQJi5w3aRdN69aW2Py()
	{
		return hUMQ2q5wFY7wh0DfyyNk == null;
	}

	internal static TicksRequest XGg6CF5wp4mdXly4q53W()
	{
		return hUMQ2q5wFY7wh0DfyyNk;
	}

	internal static void QuZUgL5wuvggy105JGw7()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void dSCbYq5wzQbpahIhB3gn()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void T5W61K570fjbuT9rPpov()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
