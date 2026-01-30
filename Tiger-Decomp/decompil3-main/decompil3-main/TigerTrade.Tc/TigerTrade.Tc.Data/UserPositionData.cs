using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public sealed class UserPositionData
{
	private static UserPositionData NDcl425pm7Y1p4tO4KKi;

	internal string ConnectionID { get; }

	internal string PositionID { get; }

	internal int Cmd { get; }

	internal string SymbolID { get; private set; }

	internal string AccountID { get; private set; }

	internal long Price { get; private set; }

	internal long Size { get; private set; }

	internal double Leverage { get; private set; }

	public bool IsPlayer => PositionID.Contains((string)iwxbSb5p7MmKThYMsTQv(--146713930 ^ 0x8BE0B96));

	public bool IsSimulator => s6qEhi5p8iqi7KUGtBqd(PositionID, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2002318893 ^ -2002266557));

	public bool IsLive
	{
		get
		{
			if (!IsPlayer)
			{
				return !IsSimulator;
			}
			return false;
		}
	}

	private UserPositionData(string connectionID, string positionID, int cmd)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		ConnectionID = connectionID;
		PositionID = positionID;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Cmd = cmd;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
			{
				num = 1;
			}
		}
	}

	public static UserPositionData NewPosition(string connectionID, string symbolID, string accountID, long price, long size)
	{
		UserPositionData obj = new UserPositionData(connectionID, "", 1)
		{
			SymbolID = symbolID
		};
		J3kabR5pAZs1pAMAMe48(obj, accountID);
		obj.Price = price;
		obj.Size = size;
		return obj;
	}

	public static UserPositionData EditPosition(string connectionID, string positionID, long price, long size)
	{
		UserPositionData userPositionData = new UserPositionData(connectionID, positionID, 2);
		GhMGwR5pPqBZKoB82GmS(userPositionData, price);
		rIk9s55pJRIJuiKJs56u(userPositionData, size);
		return userPositionData;
	}

	public static UserPositionData ClearPosition(string connectionID, string positionID)
	{
		return new UserPositionData(connectionID, positionID, 3);
	}

	public static UserPositionData ClosePosition(string connectionID, string positionID)
	{
		return new UserPositionData(connectionID, positionID, 4);
	}

	public static UserPositionData HidePosition(string connectionID, string positionID)
	{
		return new UserPositionData(connectionID, positionID, 5);
	}

	public static UserPositionData SetLeverage(string connectionID, string symbolID, string accountID, double leverage)
	{
		return new UserPositionData(connectionID, "", 6)
		{
			SymbolID = symbolID,
			AccountID = accountID,
			Leverage = leverage
		};
	}

	static UserPositionData()
	{
		wRgQ3G5pFT25NutOqZFN();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool WYkaoR5phlhV4PFmGuHB()
	{
		return NDcl425pm7Y1p4tO4KKi == null;
	}

	internal static UserPositionData tXgmRu5pwJZsm6ilQU9Z()
	{
		return NDcl425pm7Y1p4tO4KKi;
	}

	internal static object iwxbSb5p7MmKThYMsTQv(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool s6qEhi5p8iqi7KUGtBqd(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static void J3kabR5pAZs1pAMAMe48(object P_0, object P_1)
	{
		((UserPositionData)P_0).AccountID = (string)P_1;
	}

	internal static void GhMGwR5pPqBZKoB82GmS(object P_0, long value)
	{
		((UserPositionData)P_0).Price = value;
	}

	internal static void rIk9s55pJRIJuiKJs56u(object P_0, long value)
	{
		((UserPositionData)P_0).Size = value;
	}

	internal static void wRgQ3G5pFT25NutOqZFN()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
