using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using TigerTrade.Config.Common;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using v0gxFx27QfQao4Ot85dR;

namespace cIbiwrHkfBj4h5ErI7rI;

internal static class Kn3NMtHkHjy4eIsknyks
{
	private static Kn3NMtHkHjy4eIsknyks HTCi3RDSUBUK8TELdqeZ;

	public static bool BTsHk9LkJvJ(Symbol P_0)
	{
		if (KIjqMUDSZrJrINJYvxX0(j18iDj9nukSCmEyZs5lH.Settings) == AppTradeMode.Player)
		{
			return false;
		}
		if (!j18iDj9nukSCmEyZs5lH.Settings.ConfigViewDeletedSymbols && P_0.IsDeleted)
		{
			return true;
		}
		int num;
		if (!qHwbFmDSVUULGtKClPik(j18iDj9nukSCmEyZs5lH.Settings))
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_0032;
		IL_0032:
		if (j18iDj9nukSCmEyZs5lH.Settings.ShowOnlyUsdtCryptoAssets)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		goto IL_00b2;
		IL_00b2:
		return false;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 2:
				goto IL_005b;
			default:
				return (string)bFh9AODSCBrvEbVFJfNk(P_0) != (string)LtWtUlDSrjxAv6nuiFKB(-198991962 ^ -199004260);
			}
			break;
			IL_005b:
			if (P_0.IsCrypto)
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
				{
					num = 0;
				}
				continue;
			}
			goto IL_00b2;
		}
		if (P_0.Type == SymbolType.Option)
		{
			return true;
		}
		goto IL_0032;
	}

	public static bool aAhHkn8GlCG(Symbol P_0)
	{
		if (!((MhMDPU9v8rkigy1ao0Th)LYbgPfDSKgx5BSwWKUvC()).ConfigViewDeletedSymbols && j18iDj9nukSCmEyZs5lH.Settings.TradeMode != AppTradeMode.Player)
		{
			return P_0.IsDeleted;
		}
		return false;
	}

	public static bfvIex27Er0lPTIgUD0b sDDHkGRcqYR(string P_0, bool P_1)
	{
		int num = 1;
		int num2 = num;
		SymbolType? symbolType = default(SymbolType?);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (symbolType.HasValue)
				{
					switch (symbolType.GetValueOrDefault())
					{
					case SymbolType.Crypto:
						return (bfvIex27Er0lPTIgUD0b)2;
					case SymbolType.Future:
						return (bfvIex27Er0lPTIgUD0b)1;
					}
				}
				return bfvIex27Er0lPTIgUD0b.None;
			default:
				return bfvIex27Er0lPTIgUD0b.None;
			case 3:
				symbolType = SymbolManager.Get(P_0)?.Type;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				if (!mJYUIyDSmNamrZPYtpKl(P_0, string.Empty))
				{
					num2 = 3;
					break;
				}
				goto default;
			case 1:
				if (!P_1)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	static Kn3NMtHkHjy4eIsknyks()
	{
		mFVqmEDShBjc9Yrajoyd();
	}

	internal static AppTradeMode KIjqMUDSZrJrINJYvxX0(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).TradeMode;
	}

	internal static bool qHwbFmDSVUULGtKClPik(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).ConfigViewOptionsSymbols;
	}

	internal static object bFh9AODSCBrvEbVFJfNk(object P_0)
	{
		return ((Symbol)P_0).Currency;
	}

	internal static object LtWtUlDSrjxAv6nuiFKB(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool lW91ODDSTWx5L9TV67BE()
	{
		return HTCi3RDSUBUK8TELdqeZ == null;
	}

	internal static Kn3NMtHkHjy4eIsknyks sSBsvKDSyg613BsODZ1Q()
	{
		return HTCi3RDSUBUK8TELdqeZ;
	}

	internal static object LYbgPfDSKgx5BSwWKUvC()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static bool mJYUIyDSmNamrZPYtpKl(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void mFVqmEDShBjc9Yrajoyd()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
