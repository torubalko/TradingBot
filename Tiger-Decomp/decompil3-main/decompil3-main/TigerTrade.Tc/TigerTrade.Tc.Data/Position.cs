using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public sealed class Position
{
	private static Position IgGf785uATMA5Yj7LcuR;

	public ConnectionInfo Connection => Account.Connection;

	internal string UniqueID { get; }

	public Symbol Symbol { get; }

	public Account Account { get; }

	public string Register { get; set; }

	public long Quantity { get; set; }

	public double AvgPrice { get; set; }

	public double? Liquidation { get; set; }

	public double? UnrealizedPnl { get; set; }

	public double? RealizedPnl { get; set; }

	public double? Comission { get; set; }

	public double? TpPrice { get; set; }

	public double? SlPrice { get; set; }

	public long PosNumID { get; set; }

	public string PositionID => (string)LMAV3X5uFvqHEuIwwk7l(Connection.ConnectionID, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--737722733 ^ 0x2BF82473), UniqueID);

	public Position(Symbol symbol, Account account, string uniqueID)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				UniqueID = uniqueID;
				return;
			case 1:
				Symbol = symbol;
				Account = account;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static Position()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool l8oY0Y5uPvCi1h6WNxHx()
	{
		return IgGf785uATMA5Yj7LcuR == null;
	}

	internal static Position UgRqxw5uJKuUs9d5tYkL()
	{
		return IgGf785uATMA5Yj7LcuR;
	}

	internal static object LMAV3X5uFvqHEuIwwk7l(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
