using System.Collections.Generic;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ft4IOl2kyqsXh3EvCREm;
using IjOA1p2GDNqxxbHTeea;
using lFsEWXfkgLYLS0FUKGT5;
using SkKgIr9fEeymCi059XGT;
using TigerTrade.Market.Settings;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TigerTrade.UI.DocControls.Charting.Settings;
using TigerTrade.UI.DocControls.Trading.Settings;
using TuAMtrl1Nd3XoZQQUXf0;
using vwaruI999smF85ZbYXcY;
using YhJPRb918lTUP3Yh9Vro;

namespace OZ65ngfB5c7bG1vuvCsP;

internal static class T3TrZWfB19BlXX1UJ3Ie
{
	internal static T3TrZWfB19BlXX1UJ3Ie FCV9xUDKqACoEg83xBKj;

	public static Account QJRfBS5l6Ha(ChartingSettings P_0)
	{
		return U5BfBLHUWZa(P_0, (MarketSettings)VHJDcIDKtLrpITIbZZEk(P_0));
	}

	public static Account Q1gfBxw3D56(TradingSettings P_0)
	{
		return U5BfBLHUWZa(P_0, P_0.MarketSettings);
	}

	private static Account U5BfBLHUWZa(KqZtUj2kTEAQfYBkeSKy P_0, MarketSettings P_1)
	{
		if (!string.IsNullOrEmpty(P_0?.Qom210PQiuE))
		{
			Symbol symbol = SymbolManager.Get(P_0.Qom210PQiuE);
			if (symbol != null)
			{
				int num = 10;
				Account account = default(Account);
				List<Account> accounts = default(List<Account>);
				string text = default(string);
				while (true)
				{
					switch (num)
					{
					case 12:
						goto IL_00b1;
					case 9:
						break;
					case 7:
						account = null;
						num = 8;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
						{
							num = 3;
						}
						continue;
					case 3:
						if (symbol.Type != SymbolType.Index)
						{
							num = 5;
							continue;
						}
						goto case 2;
					case 8:
						if (BL2PkiDKZ8Y7LNiSs9vh() && ((zObClP99fKcOtAs5v4hK)ARKh5ZDKVBd8VRCTCGeD()).GlP99ZiPicA == F2cKZE9fjI5S8KBSOEwr.None && account == null)
						{
							num = 14;
							continue;
						}
						goto case 2;
					case 5:
						if (accounts.Count > 0)
						{
							account = accounts[0];
							goto case 2;
						}
						num = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
						{
							num = 2;
						}
						continue;
					case 10:
						if (symbol.Type != SymbolType.Index)
						{
							accounts = DataManager.GetAccounts(symbol);
							num = 11;
						}
						else
						{
							num = 9;
						}
						continue;
					case 1:
						account = null;
						num = 4;
						continue;
					case 14:
						if (!TcManager.AreConnectionsInitialized)
						{
							if (symbol == null)
							{
								num = 13;
								continue;
							}
							goto case 3;
						}
						num = 6;
						continue;
					case 2:
					case 6:
					case 13:
						return account;
					case 11:
						text = P_0.cWO2kZ9hC6O();
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
						{
							num = 1;
						}
						continue;
					case 4:
						switch (((MhMDPU9v8rkigy1ao0Th)AibnjDDKUFDZk9rrUBBP()).TradingAccountSelection)
						{
						case A2AjND917cr9YMkbSbKx.pqH91Pwmm3c:
							if (string.IsNullOrEmpty(text))
							{
								text = P_1.Account;
							}
							account = DataManager.GetAccount(text);
							goto IL_00b1;
						case A2AjND917cr9YMkbSbKx.zeF91Ahfesy:
							goto IL_00b1;
						case A2AjND917cr9YMkbSbKx.Foa91J1d49t:
							goto IL_02c9;
						}
						num = 12;
						continue;
					default:
						goto IL_02c9;
						IL_02c9:
						account = (Account)C91qSWDKToMJwkuO8Dy7(text);
						if ((account == null || !accounts.Contains(account)) && K3BGNbDKyyZ4Jb2TbP0A(accounts) == 1)
						{
							account = accounts[0];
						}
						goto IL_00b1;
						IL_00b1:
						if (!accounts.Contains(account))
						{
							num = 7;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 8;
					}
					break;
				}
			}
			return null;
		}
		return null;
	}

	public static void W7VfBePBUKG(string P_0, string P_1, MarketSettings P_2)
	{
		MarketSettings marketSettings = EKVIQxfkdb0qc2T2DNLL.hvRfkWM7bY4(P_0, P_1);
		if (marketSettings != null)
		{
			P_2.Account = (string)EUMwJ5DKCEr2hdCdiTcR(marketSettings);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	static T3TrZWfB19BlXX1UJ3Ie()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object VHJDcIDKtLrpITIbZZEk(object P_0)
	{
		return ((ChartingSettings)P_0).MarketSettings;
	}

	internal static bool AxxOBeDKISeQZo1RWLl7()
	{
		return FCV9xUDKqACoEg83xBKj == null;
	}

	internal static T3TrZWfB19BlXX1UJ3Ie GBC6TWDKWpOTEMjGHYNV()
	{
		return FCV9xUDKqACoEg83xBKj;
	}

	internal static object AibnjDDKUFDZk9rrUBBP()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static object C91qSWDKToMJwkuO8Dy7(object P_0)
	{
		return DataManager.GetAccount((string)P_0);
	}

	internal static int K3BGNbDKyyZ4Jb2TbP0A(object P_0)
	{
		return ((List<Account>)P_0).Count;
	}

	internal static bool BL2PkiDKZ8Y7LNiSs9vh()
	{
		return I9v8Sd2n8JEKu0t2tYj.Gqe25c7say();
	}

	internal static object ARKh5ZDKVBd8VRCTCGeD()
	{
		return j18iDj9nukSCmEyZs5lH.lmf9GS9l7aG();
	}

	internal static object EUMwJ5DKCEr2hdCdiTcR(object P_0)
	{
		return ((MarketSettings)P_0).Account;
	}
}
