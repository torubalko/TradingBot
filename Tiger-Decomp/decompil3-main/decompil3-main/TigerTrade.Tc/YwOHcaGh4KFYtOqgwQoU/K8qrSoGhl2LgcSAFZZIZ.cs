using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using tpDLBrGJAci5JWh2s4im;
using x97CE55GhEYKgt7TSVZT;

namespace YwOHcaGh4KFYtOqgwQoU;

internal class K8qrSoGhl2LgcSAFZZIZ
{
	[Serializable]
	[CompilerGenerated]
	private sealed class CAnEefagpeqNXQQGwhaE
	{
		public static readonly CAnEefagpeqNXQQGwhaE UlxagzfWoG5;

		public static Func<ConnectionInfo, bool> XeeaR08x8k4;

		private static CAnEefagpeqNXQQGwhaE HV3E4yxJJdTWpKPCu8R6;

		static CAnEefagpeqNXQQGwhaE()
		{
			xLBoQVxJp6DIM6KFxQcW();
			KiFthbxJuOJcuEeqeeb1();
			Ksht7JxJzijrtht1uDRD();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			UlxagzfWoG5 = new CAnEefagpeqNXQQGwhaE();
		}

		public CAnEefagpeqNXQQGwhaE()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool dwxagupuOPN(ConnectionInfo c)
		{
			if (c.IsConnected && c.MarketData)
			{
				if (!c.Simulator)
				{
					return !c.Trust;
				}
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
			}
			return false;
		}

		internal static void xLBoQVxJp6DIM6KFxQcW()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}

		internal static void KiFthbxJuOJcuEeqeeb1()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static void Ksht7JxJzijrtht1uDRD()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static bool YaTQ2MxJFoJ6JoJrdf91()
		{
			return HV3E4yxJJdTWpKPCu8R6 == null;
		}

		internal static CAnEefagpeqNXQQGwhaE MkkYInxJ31FePgFf4qG5()
		{
			return HV3E4yxJJdTWpKPCu8R6;
		}
	}

	private readonly Dictionary<string, ConnectionInfo> eZGGhNECMKV;

	internal static K8qrSoGhl2LgcSAFZZIZ tN98gF5WdYCCQ2uXGEao;

	public K8qrSoGhl2LgcSAFZZIZ()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		eZGGhNECMKV = new Dictionary<string, ConnectionInfo>();
	}

	public bool a1SGhDw5nBC(ConnectionInfo P_0, anI4lfGJ8TTwhTlujQ36 P_1)
	{
		if (NtQTgs5W6Oc4KLyQ5pd8())
		{
			return true;
		}
		object obj = aWPu9i5WMFFY1y76pBve(P_1);
		int num;
		if (obj == null)
		{
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		object obj2 = ((Symbol)obj).ID;
		goto IL_00cb;
		IL_00cb:
		string text = (string)obj2;
		ConnectionInfo value = default(ConnectionInfo);
		if (!dkM23T5WOQYWSmH1TF7m(text))
		{
			eZGGhNECMKV.TryGetValue(text, out value);
			num = 2;
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
			{
				num = 0;
			}
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 2:
			kpcGhbIvnCd(P_0, text, ref value);
			eZGGhNECMKV[text] = value;
			if ((string)JBy4q15Wqt1icMnhAE0R(P_0) != value?.ConnectionID)
			{
				return false;
			}
			return true;
		default:
			return false;
		case 1:
			break;
		}
		obj2 = null;
		goto IL_00cb;
	}

	private static void kpcGhbIvnCd(ConnectionInfo P_0, string P_1, ref ConnectionInfo P_2)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
			{
				ConnectionInfo obj = P_2;
				if (obj == null || obj.IsConnected)
				{
					ConnectionInfo obj2 = P_2;
					if (obj2 == null || obj2.MarketData)
					{
						return;
					}
				}
				P_2 = ((IEnumerable<ConnectionInfo>)BjPBTq5WIiU9J1UAJjvB(P_1)).FirstOrDefault(delegate(ConnectionInfo c)
				{
					if (c.IsConnected && c.MarketData)
					{
						if (!c.Simulator)
						{
							return !c.Trust;
						}
						int num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						}
					}
					return false;
				});
				num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				if (P_2 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				P_2 = P_0;
				num2 = 3;
				break;
			}
		}
	}

	static K8qrSoGhl2LgcSAFZZIZ()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool O4YAoR5WgYTIsrHH3ZhU()
	{
		return tN98gF5WdYCCQ2uXGEao == null;
	}

	internal static K8qrSoGhl2LgcSAFZZIZ A2uTdn5WRoKEOt8NSy7c()
	{
		return tN98gF5WdYCCQ2uXGEao;
	}

	internal static bool NtQTgs5W6Oc4KLyQ5pd8()
	{
		return DataManager.Player;
	}

	internal static object aWPu9i5WMFFY1y76pBve(object P_0)
	{
		return ((anI4lfGJ8TTwhTlujQ36)P_0).Symbol;
	}

	internal static bool dkM23T5WOQYWSmH1TF7m(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object JBy4q15Wqt1icMnhAE0R(object P_0)
	{
		return ((ConnectionInfo)P_0).ConnectionID;
	}

	internal static object BjPBTq5WIiU9J1UAJjvB(object P_0)
	{
		return TcManager.GetMarketDataConnections((string)P_0);
	}
}
