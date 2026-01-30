using System.Collections.Generic;
using System.Linq;
using System.Threading;
using BfZtb759KlUg4482QKym;
using hLNgjdadfJmAYwpjL3jr;
using K1GcsD5GTtMSlaiJI0Xh;
using k7lvGwG7nsmvY8cRB5pp;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using x97CE55GhEYKgt7TSVZT;

namespace zJnmCrGAyrNEB66VU5ww;

internal static class AFoGv5GAT4PeYBusSBbk
{
	private static readonly Dictionary<string, int[]> PHKGA890CyH;

	private static AFoGv5GAT4PeYBusSBbk kauD7x5m5Se88AKWjKvL;

	public static void Subscribe(SubscriptionFlags flags, XGPMikadHJMQKPWwUlio tickers, params Symbol[] symbols)
	{
		int num = 5;
		int num2 = num;
		int num3 = default(int);
		Symbol[] array = default(Symbol[]);
		List<Symbol> list = default(List<Symbol>);
		Symbol symbol2 = default(Symbol);
		Symbol symbol = default(Symbol);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (num3 >= array.Length)
				{
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 5:
				list = new List<Symbol>();
				num2 = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d != 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				uJTV2a5me0tybnH4kMvs(tickers, symbol2);
				num2 = 8;
				break;
			case 2:
			{
				SubscriptionFlags subscriptionFlags = KidGACPVpXo(symbol2);
				Dictionary<string, int[]> pHKGA890CyH = PHKGA890CyH;
				bool lockTaken = false;
				try
				{
					Monitor.Enter(pHKGA890CyH, ref lockTaken);
					int num4;
					if (!PHKGA890CyH.ContainsKey((string)VcFIau5mLSvt1kq7ZToL(symbol2)))
					{
						num4 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 == 0)
						{
							num4 = 0;
						}
						goto IL_0152;
					}
					goto IL_01aa;
					IL_02a4:
					if (flags.HasFlag(SubscriptionFlags.Level2))
					{
						num4 = 3;
						goto IL_0152;
					}
					goto IL_01da;
					IL_01da:
					if (flags.HasFlag(SubscriptionFlags.Ticks))
					{
						PHKGA890CyH[symbol2.ID][2]++;
					}
					if (flags.HasFlag(SubscriptionFlags.OpenInterest))
					{
						PHKGA890CyH[(string)VcFIau5mLSvt1kq7ZToL(symbol2)][3]++;
						num4 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 != 0)
						{
							num4 = 0;
						}
						goto IL_0152;
					}
					goto end_IL_0140;
					IL_0152:
					while (true)
					{
						switch (num4)
						{
						case 4:
							goto IL_01da;
						case 1:
							goto IL_0288;
						case 2:
							goto IL_02a4;
						case 3:
							PHKGA890CyH[(string)VcFIau5mLSvt1kq7ZToL(symbol2)][1]++;
							num4 = 4;
							continue;
						case 0:
							break;
						}
						break;
					}
					goto end_IL_0140;
					IL_0288:
					PHKGA890CyH.Add(symbol2.ID, new int[4]);
					goto IL_01aa;
					IL_01aa:
					if (!flags.HasFlag(SubscriptionFlags.Level1))
					{
						num4 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
						{
							num4 = 2;
						}
						goto IL_0152;
					}
					PHKGA890CyH[symbol2.ID][0]++;
					goto IL_02a4;
					end_IL_0140:;
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(pHKGA890CyH);
						int num5 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				}
				SubscriptionFlags num6 = KidGACPVpXo(symbol2);
				if (num6 != subscriptionFlags)
				{
					list.Add(symbol2);
				}
				if (num6 != SubscriptionFlags.None)
				{
					num2 = 3;
					break;
				}
				goto case 8;
			}
			default:
				if (symbol != null)
				{
					symbol2 = symbol.GetSymbol();
					if (symbol2 != null)
					{
						num2 = 2;
						break;
					}
				}
				goto case 8;
			case 7:
				symbol = array[num3];
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				array = symbols;
				num3 = 0;
				num2 = 6;
				break;
			case 8:
				num3++;
				goto case 6;
			case 1:
				if (YoT9Jn5msLabId6dsK8O(list) > 0)
				{
					vKPGAVHXUrl((Symbol[])jwHMff5mXbcbY4wvLREI(list));
				}
				return;
			}
		}
	}

	public static void WIDGAZnGmDT(SubscriptionFlags P_0, XGPMikadHJMQKPWwUlio P_1, params Symbol[] symbols)
	{
		int num = 2;
		List<Symbol> list = default(List<Symbol>);
		Dictionary<string, int[]> pHKGA890CyH = default(Dictionary<string, int[]>);
		Symbol symbol = default(Symbol);
		Symbol[] array = default(Symbol[]);
		int num3 = default(int);
		Symbol symbol2 = default(Symbol);
		SubscriptionFlags subscriptionFlags = default(SubscriptionFlags);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				SubscriptionFlags num6;
				switch (num2)
				{
				case 2:
					list = new List<Symbol>();
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
				{
					bool lockTaken = false;
					try
					{
						Monitor.Enter(pHKGA890CyH, ref lockTaken);
						int num4 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 5:
								break;
							case 2:
								if (PHKGA890CyH[symbol.ID][2] > 0)
								{
									PHKGA890CyH[symbol.ID][2]--;
								}
								goto IL_0285;
							case 6:
								PHKGA890CyH[symbol.ID][0]--;
								num4 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
								{
									num4 = 0;
								}
								continue;
							default:
								if (PHKGA890CyH.ContainsKey(symbol.ID))
								{
									if (P_0.HasFlag(SubscriptionFlags.Level1) && PHKGA890CyH[(string)VcFIau5mLSvt1kq7ZToL(symbol)][0] > 0)
									{
										num4 = 6;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
										{
											num4 = 1;
										}
										continue;
									}
									goto case 1;
								}
								num4 = 5;
								continue;
							case 4:
							{
								if (PHKGA890CyH[symbol.ID][1] <= 0)
								{
									goto case 3;
								}
								PHKGA890CyH[(string)VcFIau5mLSvt1kq7ZToL(symbol)][1]--;
								int num5 = 3;
								num4 = num5;
								continue;
							}
							case 1:
								if (P_0.HasFlag(SubscriptionFlags.Level2))
								{
									num4 = 2;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
									{
										num4 = 4;
									}
									continue;
								}
								goto case 3;
							case 3:
								{
									if (P_0.HasFlag(SubscriptionFlags.Ticks))
									{
										num4 = 2;
										continue;
									}
									goto IL_0285;
								}
								IL_0285:
								if (P_0.HasFlag(SubscriptionFlags.OpenInterest) && PHKGA890CyH[(string)VcFIau5mLSvt1kq7ZToL(symbol)][3] > 0)
								{
									PHKGA890CyH[(string)VcFIau5mLSvt1kq7ZToL(symbol)][3]--;
								}
								goto IL_03c1;
							}
							break;
						}
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(pHKGA890CyH);
						}
					}
					goto IL_03b5;
				}
				case 1:
					array = symbols;
					num3 = 0;
					goto IL_012c;
				case 8:
					P_1.kQkadG7VV1L(symbol);
					goto IL_03b5;
				case 6:
					if (list.Count > 0)
					{
						vKPGAVHXUrl(list.ToArray());
						num = 7;
						break;
					}
					return;
				case 3:
					symbol2 = array[num3];
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (symbol2 != null)
					{
						num2 = 5;
						continue;
					}
					goto IL_03b5;
				case 5:
					symbol = (Symbol)rT68Fu5mcDGun0CXirCD(symbol2);
					if (symbol != null)
					{
						subscriptionFlags = xvrKXE5mjNiUDp4Wb70V(symbol);
						pHKGA890CyH = PHKGA890CyH;
						num2 = 4;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto IL_03b5;
				case 7:
					return;
					IL_012c:
					if (num3 < array.Length)
					{
						num2 = 3;
						continue;
					}
					goto case 6;
					IL_03b5:
					num3++;
					goto IL_012c;
					IL_03c1:
					num6 = xvrKXE5mjNiUDp4Wb70V(symbol);
					if (num6 != subscriptionFlags)
					{
						list.Add(symbol);
					}
					if (num6 == SubscriptionFlags.None)
					{
						num = 8;
						break;
					}
					goto IL_03b5;
				}
				break;
			}
		}
	}

	private static void vKPGAVHXUrl(params Symbol[] symbols)
	{
		using IEnumerator<AdVNpgG79ErxvcbgBD1J> enumerator = DataManager.GetConnections().GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.oW1lYsReHKK(symbols);
		}
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

	private static SubscriptionFlags KidGACPVpXo(Symbol P_0)
	{
		SubscriptionFlags result = default(SubscriptionFlags);
		lock (PHKGA890CyH)
		{
			int num;
			if (PHKGA890CyH.ContainsKey(P_0.ID))
			{
				num = 4;
			}
			else
			{
				result = SubscriptionFlags.None;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
				{
					num = 1;
				}
			}
			SubscriptionFlags subscriptionFlags = default(SubscriptionFlags);
			while (true)
			{
				switch (num)
				{
				default:
					if (PHKGA890CyH[P_0.ID][2] > 0)
					{
						subscriptionFlags |= SubscriptionFlags.Ticks;
					}
					if (PHKGA890CyH[(string)VcFIau5mLSvt1kq7ZToL(P_0)][3] > 0)
					{
						num = 5;
						continue;
					}
					goto IL_0119;
				case 5:
					subscriptionFlags |= SubscriptionFlags.OpenInterest;
					goto IL_0119;
				case 2:
					if (PHKGA890CyH[P_0.ID][0] > 0)
					{
						subscriptionFlags |= SubscriptionFlags.Level1;
						goto case 3;
					}
					num = 3;
					continue;
				case 6:
					subscriptionFlags |= SubscriptionFlags.Level2;
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
					{
						num = 0;
					}
					continue;
				case 1:
					break;
				case 4:
					subscriptionFlags = SubscriptionFlags.None;
					num = 2;
					continue;
				case 3:
					{
						if (PHKGA890CyH[P_0.ID][1] > 0)
						{
							num = 6;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
							{
								num = 0;
							}
							continue;
						}
						goto default;
					}
					IL_0119:
					result = subscriptionFlags;
					break;
				}
				break;
			}
		}
		return result;
	}

	internal static bool pJBGArTkG0n(Symbol P_0)
	{
		if (DataManager.Player)
		{
			return true;
		}
		Dictionary<string, int[]> pHKGA890CyH = PHKGA890CyH;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			bool lockTaken = false;
			bool result;
			try
			{
				Monitor.Enter(pHKGA890CyH, ref lockTaken);
				result = PHKGA890CyH.ContainsKey(P_0.ID) && PHKGA890CyH[P_0.ID][0] > 0;
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Upu5dn5mEtRxhpeJYbSJ(pHKGA890CyH);
				}
			}
			return result;
		}
		}
	}

	internal static bool aqRGAKboHm4(Symbol P_0)
	{
		if (KI8QHO5mQnZh9gdJtrkS())
		{
			return true;
		}
		Dictionary<string, int[]> pHKGA890CyH = PHKGA890CyH;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			bool lockTaken = false;
			bool result;
			try
			{
				Monitor.Enter(pHKGA890CyH, ref lockTaken);
				result = PHKGA890CyH.ContainsKey(P_0.ID) && PHKGA890CyH[P_0.ID][1] > 0;
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Upu5dn5mEtRxhpeJYbSJ(pHKGA890CyH);
				}
			}
			return result;
		}
		}
	}

	internal static bool jaKGAmShKvV(Symbol P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return true;
			case 1:
				if (!KI8QHO5mQnZh9gdJtrkS())
				{
					lock (PHKGA890CyH)
					{
						int result;
						if (PHKGA890CyH.ContainsKey(P_0.ID))
						{
							int num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
							{
								num3 = 0;
							}
							switch (num3)
							{
							}
							result = ((PHKGA890CyH[(string)VcFIau5mLSvt1kq7ZToL(P_0)][2] > 0) ? 1 : 0);
						}
						else
						{
							result = 0;
						}
						return (byte)result != 0;
					}
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool yDSGAhtlwnE(Symbol P_0)
	{
		return D7ZGAw893b8((string)VcFIau5mLSvt1kq7ZToL(P_0));
	}

	internal static bool D7ZGAw893b8(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (DataManager.Player)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e != 0)
					{
						num2 = 0;
					}
					break;
				}
				lock (PHKGA890CyH)
				{
					int result;
					if (PHKGA890CyH.ContainsKey(P_0))
					{
						int num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						}
						result = ((PHKGA890CyH[P_0][3] > 0) ? 1 : 0);
					}
					else
					{
						result = 0;
					}
					return (byte)result != 0;
				}
			default:
				return true;
			}
		}
	}

	internal static List<string> asUGA7ukNap()
	{
		lock (PHKGA890CyH)
		{
			return PHKGA890CyH.Keys.ToList();
		}
	}

	static AFoGv5GAT4PeYBusSBbk()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				lNtsnZ5mdmbNfUfsRjeS();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
				{
					num2 = 0;
				}
				break;
			default:
				b3OMlB5mgyTxiKfi8RXl();
				itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
				PHKGA890CyH = new Dictionary<string, int[]>();
				return;
			}
		}
	}

	internal static object VcFIau5mLSvt1kq7ZToL(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static bool uJTV2a5me0tybnH4kMvs(object P_0, object P_1)
	{
		return ((XGPMikadHJMQKPWwUlio)P_0).YF6ad9VHuyo((Symbol)P_1);
	}

	internal static int YoT9Jn5msLabId6dsK8O(object P_0)
	{
		return ((List<Symbol>)P_0).Count;
	}

	internal static object jwHMff5mXbcbY4wvLREI(object P_0)
	{
		return ((List<Symbol>)P_0).ToArray();
	}

	internal static bool a2dE0v5mS2uUyISAaTIF()
	{
		return kauD7x5m5Se88AKWjKvL == null;
	}

	internal static AFoGv5GAT4PeYBusSBbk tx0vA95mxsOQYj6gk14m()
	{
		return kauD7x5m5Se88AKWjKvL;
	}

	internal static object rT68Fu5mcDGun0CXirCD(object P_0)
	{
		return ((Symbol)P_0).GetSymbol();
	}

	internal static SubscriptionFlags xvrKXE5mjNiUDp4Wb70V(object P_0)
	{
		return KidGACPVpXo((Symbol)P_0);
	}

	internal static void Upu5dn5mEtRxhpeJYbSJ(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool KI8QHO5mQnZh9gdJtrkS()
	{
		return DataManager.Player;
	}

	internal static void lNtsnZ5mdmbNfUfsRjeS()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void b3OMlB5mgyTxiKfi8RXl()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
