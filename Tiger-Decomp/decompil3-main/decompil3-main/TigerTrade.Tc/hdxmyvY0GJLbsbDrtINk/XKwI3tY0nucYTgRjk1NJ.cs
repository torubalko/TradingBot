using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using x97CE55GhEYKgt7TSVZT;

namespace hdxmyvY0GJLbsbDrtINk;

internal class XKwI3tY0nucYTgRjk1NJ
{
	private static XKwI3tY0nucYTgRjk1NJ Aju89x5Foh8IlAideIAv;

	internal static bool D91Y0YYo7tX(Account P_0)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!WODOkX5FaLlIfMU2XGc9())
				{
					num2 = 4;
					continue;
				}
				goto IL_00a6;
			case 1:
				if (gSEHaa5FiUtjxk1NRwEq())
				{
					return P_0.IsPlayer;
				}
				goto IL_00e0;
			case 4:
				if (P_0.IsLive)
				{
					break;
				}
				goto IL_00a6;
			case 3:
				{
					if (!DataManager.Player)
					{
						num2 = 2;
						continue;
					}
					goto IL_00a6;
				}
				IL_00e0:
				return false;
				IL_00a6:
				if (!DataManager.Simulator || DataManager.Player || !P_0.IsSimulator)
				{
					if (WODOkX5FaLlIfMU2XGc9())
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_00e0;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a == 0)
				{
					num2 = 0;
				}
				continue;
			}
			break;
		}
		return true;
	}

	internal static bool YZ2Y0oSIoZq(UserPositionData P_0)
	{
		int num;
		if (!DataManager.Player)
		{
			if (DataManager.Simulator)
			{
				num = 2;
				goto IL_0009;
			}
			goto IL_003e;
		}
		goto IL_005d;
		IL_005d:
		if (!WODOkX5FaLlIfMU2XGc9() || DataManager.Player || !P_0.IsSimulator)
		{
			if (DataManager.Simulator)
			{
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 == 0)
				{
					num = 1;
				}
				goto IL_0009;
			}
			goto IL_003a;
		}
		goto IL_003c;
		IL_003e:
		if (P_0.IsLive)
		{
			goto IL_003c;
		}
		goto IL_005d;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				return xK5eno5Fl9Au4ArciLXd(P_0);
			case 3:
				break;
			case 2:
				goto IL_005d;
			case 1:
				goto IL_008a;
			}
			break;
			IL_008a:
			if (gSEHaa5FiUtjxk1NRwEq())
			{
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac != 0)
				{
					num = 0;
				}
				continue;
			}
			goto IL_003a;
		}
		goto IL_003e;
		IL_003c:
		return true;
		IL_003a:
		return false;
	}

	public XKwI3tY0nucYTgRjk1NJ()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static XKwI3tY0nucYTgRjk1NJ()
	{
		oRe9Hd5F4To0Cvu0aJJ2();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool WODOkX5FaLlIfMU2XGc9()
	{
		return DataManager.Simulator;
	}

	internal static bool gSEHaa5FiUtjxk1NRwEq()
	{
		return DataManager.Player;
	}

	internal static bool HP5H9P5FvKZXoaSch4Dr()
	{
		return Aju89x5Foh8IlAideIAv == null;
	}

	internal static XKwI3tY0nucYTgRjk1NJ yESBYD5FBYIVeVCf1bPK()
	{
		return Aju89x5Foh8IlAideIAv;
	}

	internal static bool xK5eno5Fl9Au4ArciLXd(object P_0)
	{
		return ((UserPositionData)P_0).IsPlayer;
	}

	internal static void oRe9Hd5F4To0Cvu0aJJ2()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
