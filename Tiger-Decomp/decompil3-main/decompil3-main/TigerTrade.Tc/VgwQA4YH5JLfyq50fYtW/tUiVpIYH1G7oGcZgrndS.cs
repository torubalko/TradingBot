using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using BcoytMGPUsbcVatGjnE4;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace VgwQA4YH5JLfyq50fYtW;

internal sealed class tUiVpIYH1G7oGcZgrndS
{
	[Serializable]
	[CompilerGenerated]
	private sealed class xkYwXxaqz2kTHpZbIcks
	{
		public static readonly xkYwXxaqz2kTHpZbIcks RQuaI23PNPP;

		public static Func<TickEvent, DateTime> CIiaIH4yeOI;

		internal static xkYwXxaqz2kTHpZbIcks bXuFg6xzsJ0kt0DJFbHU;

		static xkYwXxaqz2kTHpZbIcks()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			wPGVI8xzjhwxUG57h5ka();
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			RQuaI23PNPP = new xkYwXxaqz2kTHpZbIcks();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public xkYwXxaqz2kTHpZbIcks()
		{
			wk6ZgFxzEsi5Z114xdTU();
			base._002Ector();
		}

		internal DateTime avFaI0CVHra(TickEvent t)
		{
			return Db609wxzQr80OqyXZVkx(t);
		}

		internal static void wPGVI8xzjhwxUG57h5ka()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool n9l0cXxzXbBvnX5BiS23()
		{
			return bXuFg6xzsJ0kt0DJFbHU == null;
		}

		internal static xkYwXxaqz2kTHpZbIcks F5a3Uwxzc2TiZxEIxm5M()
		{
			return bXuFg6xzsJ0kt0DJFbHU;
		}

		internal static void wk6ZgFxzEsi5Z114xdTU()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static DateTime Db609wxzQr80OqyXZVkx(object P_0)
		{
			return ((TickEvent)P_0).Time;
		}
	}

	private readonly Dictionary<string, nmx7s7GPtwKBjsWDiN4X> TpZYHctfh4B;

	private readonly Dictionary<string, List<TickEvent>> KtDYHjWj9bn;

	internal static tUiVpIYH1G7oGcZgrndS wprjTmS0F1A5lg8NrDZi;

	public void ck0YHSAmqWe(Symbol P_0, TickEvent P_1)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (P_0 != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 1:
			{
				if (P_1 == null)
				{
					return;
				}
				Dictionary<string, nmx7s7GPtwKBjsWDiN4X> tpZYHctfh4B = TpZYHctfh4B;
				bool lockTaken = false;
				try
				{
					Monitor.Enter(tpZYHctfh4B, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							VuK5A1S0zVwh8CPG3UMF(TpZYHctfh4B[(string)bYR9QiS0uaOsqKxB4Z36(P_0)], P_1);
							return;
						case 1:
							if (TpZYHctfh4B.ContainsKey(P_0.ID))
							{
								num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 != 0)
								{
									num3 = 0;
								}
								break;
							}
							TpZYHctfh4B.Add((string)bYR9QiS0uaOsqKxB4Z36(P_0), new nmx7s7GPtwKBjsWDiN4X(P_0.Step));
							goto default;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						fMAFMwS20FYmqivKeCS6(tpZYHctfh4B);
					}
				}
			}
			case 0:
				return;
			}
		}
	}

	public void IoKYHxfFYqG(Symbol P_0, TickEvent P_1)
	{
		if (P_0 == null || P_1 == null)
		{
			return;
		}
		Dictionary<string, List<TickEvent>> ktDYHjWj9bn = KtDYHjWj9bn;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
		{
			num = 0;
		}
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num)
			{
			case 1:
				try
				{
					Monitor.Enter(ktDYHjWj9bn, ref lockTaken);
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
					if (!KtDYHjWj9bn.ContainsKey(P_0.ID))
					{
						KtDYHjWj9bn.Add(P_0.ID, new List<TickEvent>());
					}
					KtDYHjWj9bn[P_0.ID].Add(P_1);
					return;
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(ktDYHjWj9bn);
					}
				}
			default:
				lockTaken = false;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public byte[] BmvYHLQv1Ui(string P_0)
	{
		int num = 1;
		int num2 = num;
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> tpZYHctfh4B = default(Dictionary<string, nmx7s7GPtwKBjsWDiN4X>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				tpZYHctfh4B = TpZYHctfh4B;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(tpZYHctfh4B, ref lockTaken);
				int num3 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
				{
					num3 = 1;
				}
				byte[] result;
				switch (num3)
				{
				default:
					result = new byte[0];
					break;
				case 1:
					if (TpZYHctfh4B.ContainsKey(P_0))
					{
						result = TpZYHctfh4B[P_0].cTAGPyTyIW4();
						break;
					}
					goto default;
				}
				return result;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(tpZYHctfh4B);
				}
			}
		}
	}

	public void LUdYHeO05eK(Symbol P_0)
	{
		string iD = P_0.ID;
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> tpZYHctfh4B = TpZYHctfh4B;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(tpZYHctfh4B, ref lockTaken);
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d != 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
			Dictionary<string, List<TickEvent>> ktDYHjWj9bn = KtDYHjWj9bn;
			bool lockTaken2 = false;
			try
			{
				Monitor.Enter(ktDYHjWj9bn, ref lockTaken2);
				if (!KtDYHjWj9bn.ContainsKey(iD))
				{
					return;
				}
				int num3;
				if (!TpZYHctfh4B.ContainsKey(iD))
				{
					num3 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 != 0)
					{
						num3 = 1;
					}
					goto IL_009f;
				}
				goto IL_0211;
				IL_0211:
				IEnumerator<TickEvent> enumerator = KtDYHjWj9bn[iD].OrderBy((TickEvent t) => xkYwXxaqz2kTHpZbIcks.Db609wxzQr80OqyXZVkx(t)).GetEnumerator();
				int num4 = 2;
				num3 = num4;
				goto IL_009f;
				IL_009f:
				switch (num3)
				{
				case 2:
					try
					{
						while (enumerator.MoveNext())
						{
							TickEvent current = enumerator.Current;
							VuK5A1S0zVwh8CPG3UMF(TpZYHctfh4B[P_0.ID], current);
						}
					}
					finally
					{
						if (enumerator == null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 != 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							case 0:
								break;
							}
						}
						else
						{
							enumerator.Dispose();
						}
					}
					goto default;
				case 1:
					break;
				default:
					KtDYHjWj9bn[iD].Clear();
					return;
				}
				TpZYHctfh4B.Add(P_0.ID, new nmx7s7GPtwKBjsWDiN4X(P_0.Step));
				goto IL_0211;
			}
			finally
			{
				if (lockTaken2)
				{
					fMAFMwS20FYmqivKeCS6(ktDYHjWj9bn);
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(tpZYHctfh4B);
			}
		}
	}

	public void Clear()
	{
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> tpZYHctfh4B = TpZYHctfh4B;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(tpZYHctfh4B, ref lockTaken);
			hHbDbIS22BAIfjUjiwjL(TpZYHctfh4B);
		}
		finally
		{
			if (lockTaken)
			{
				fMAFMwS20FYmqivKeCS6(tpZYHctfh4B);
			}
		}
	}

	public void R3iYHsN3iJf()
	{
		int num = 1;
		int num2 = num;
		Dictionary<string, List<TickEvent>> ktDYHjWj9bn = default(Dictionary<string, List<TickEvent>>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				ktDYHjWj9bn = KtDYHjWj9bn;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(ktDYHjWj9bn, ref lockTaken);
				KtDYHjWj9bn.Clear();
				return;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(ktDYHjWj9bn);
				}
			}
		}
	}

	public DateTime nbTYHXGayiQ(string P_0)
	{
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> tpZYHctfh4B = TpZYHctfh4B;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				Monitor.Enter(tpZYHctfh4B, ref lockTaken);
				if (TpZYHctfh4B.ContainsKey(P_0))
				{
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 != 0)
					{
						num2 = 0;
					}
					return num2 switch
					{
						_ => H5GNXjS2HUZgBuArTjBC(TpZYHctfh4B[P_0]), 
					};
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(tpZYHctfh4B);
				}
			}
			return DateTime.MinValue;
		}
	}

	public tUiVpIYH1G7oGcZgrndS()
	{
		vu9WBJS2fsMJrlaZ3UgL();
		TpZYHctfh4B = new Dictionary<string, nmx7s7GPtwKBjsWDiN4X>();
		KtDYHjWj9bn = new Dictionary<string, List<TickEvent>>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static tUiVpIYH1G7oGcZgrndS()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		IM8gGsS29bW9VX0SSEoS();
	}

	internal static object bYR9QiS0uaOsqKxB4Z36(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static void VuK5A1S0zVwh8CPG3UMF(object P_0, object P_1)
	{
		((nmx7s7GPtwKBjsWDiN4X)P_0).B9CGPTomDT2((TickEvent)P_1);
	}

	internal static void fMAFMwS20FYmqivKeCS6(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool HY3ciyS03XU4OlZUovsK()
	{
		return wprjTmS0F1A5lg8NrDZi == null;
	}

	internal static tUiVpIYH1G7oGcZgrndS r9md2nS0pxMXod2T4sKK()
	{
		return wprjTmS0F1A5lg8NrDZi;
	}

	internal static void hHbDbIS22BAIfjUjiwjL(object P_0)
	{
		((Dictionary<string, nmx7s7GPtwKBjsWDiN4X>)P_0).Clear();
	}

	internal static DateTime H5GNXjS2HUZgBuArTjBC(object P_0)
	{
		return ((nmx7s7GPtwKBjsWDiN4X)P_0).KIlGPZKqjr6();
	}

	internal static void vu9WBJS2fsMJrlaZ3UgL()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void IM8gGsS29bW9VX0SSEoS()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
