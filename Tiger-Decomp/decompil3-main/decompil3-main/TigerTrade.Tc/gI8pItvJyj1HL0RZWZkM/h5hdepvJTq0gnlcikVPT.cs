using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using BfZtb759KlUg4482QKym;
using gQ80RYoF52Cr7su4JSBU;
using hjIYe9BYkMG24aIXOTpq;
using K1GcsD5GTtMSlaiJI0Xh;
using lFFs11G39ohaRVknaFPC;
using Newtonsoft.Json.Linq;
using sIFWheGF3OYNVQk97tur;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace gI8pItvJyj1HL0RZWZkM;

internal sealed class h5hdepvJTq0gnlcikVPT : vdq7k7oF1bjOLTKJ5ZnM
{
	private bool pRYvJCmP31J;

	private readonly object GGbvJrCT8oA;

	private static h5hdepvJTq0gnlcikVPT bhXVN3x5bgPB20bN6g1o;

	protected override long DNflvNiDi2o(decimal P_0, Symbol P_1)
	{
		return (long)Math.Round(P_0 / (decimal)N8WNF1x51eORI27OOdeE(P_1), MidpointRounding.AwayFromZero);
	}

	protected override long m23lvbn47Kv(decimal P_0, Symbol P_1)
	{
		return bpUIDex5SmMRFAu5C9Uk(P_0 / GlolwXx55kk18Kj8ljXf(P_1.SizeStep));
	}

	protected override long ScaleValue(long value, long scale, bool byLower)
	{
		return base.ScaleValue(value, 1L, byLower);
	}

	public h5hdepvJTq0gnlcikVPT()
	{
		n16mGqx5xoO2H4FYOjiG();
		GGbvJrCT8oA = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		pRYvJCmP31J = false;
	}

	public void h3WvJZ2Wlrj(ImTwNZBYNhbcBtcejAZX P_0)
	{
		int num = 1;
		int num2 = num;
		object gGbvJrCT8oA = default(object);
		IEnumerator<JToken> enumerator = default(IEnumerator<JToken>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				gGbvJrCT8oA = GGbvJrCT8oA;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(gGbvJrCT8oA, ref lockTaken);
				pRYvJCmP31J = true;
				int num3 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 2:
						if (P_0 != null)
						{
							Clear();
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						return;
					case 1:
						enumerator = P_0.Bids.GetEnumerator();
						num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c != 0)
						{
							num3 = 0;
						}
						continue;
					}
					try
					{
						while (enumerator.MoveNext())
						{
							JToken current = enumerator.Current;
							if (current == null)
							{
								continue;
							}
							while (true)
							{
								IL_014b:
								double num4 = current[(object)0].ToObject<double>();
								double num5 = current[(object)1].ToObject<double>();
								int num6 = 2;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
								{
									num6 = 1;
								}
								while (true)
								{
									switch (num6)
									{
									case 2:
										U4ioFLPLW7Z(num4, num5);
										num6 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 == 0)
										{
											num6 = 0;
										}
										continue;
									case 1:
										goto IL_014b;
									}
									break;
								}
								break;
							}
						}
					}
					finally
					{
						enumerator?.Dispose();
					}
					enumerator = P_0.Asks.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							while (true)
							{
								IL_025a:
								JToken current2 = enumerator.Current;
								if (current2 == null)
								{
									break;
								}
								double num7 = current2[(object)0].ToObject<double>();
								int num8 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
								{
									num8 = 0;
								}
								while (true)
								{
									switch (num8)
									{
									case 2:
										break;
									case 1:
										goto IL_025a;
									default:
									{
										double num9 = current2[(object)1].ToObject<double>();
										i5KoFxXiln5(num7, num9);
										num8 = 1;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 == 0)
										{
											num8 = 2;
										}
										continue;
									}
									}
									break;
								}
								break;
							}
						}
						return;
					}
					finally
					{
						if (enumerator != null)
						{
							AiTPGfx5Ljpocx2XafFy(enumerator);
						}
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					WMbvESx5ecQ82oKJ0tqF(gGbvJrCT8oA);
				}
			}
		}
	}

	public bool XXVvJVDRWip(ImTwNZBYNhbcBtcejAZX P_0)
	{
		object gGbvJrCT8oA = GGbvJrCT8oA;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			bool result = default(bool);
			try
			{
				Monitor.Enter(gGbvJrCT8oA, ref lockTaken);
				if (!pRYvJCmP31J)
				{
					result = false;
				}
				else
				{
					int num2 = 2;
					IEnumerator<JToken> enumerator = default(IEnumerator<JToken>);
					double num8 = default(double);
					double num9 = default(double);
					JToken current = default(JToken);
					double num4 = default(double);
					double num5 = default(double);
					while (true)
					{
						switch (num2)
						{
						case 2:
							enumerator = P_0.Bids.GetEnumerator();
							num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 == 0)
							{
								num2 = 0;
							}
							continue;
						default:
							try
							{
								while (S05cWXx5X2IoILuoy4Sj(enumerator))
								{
									JToken current2 = enumerator.Current;
									int num7 = 2;
									while (true)
									{
										switch (num7)
										{
										default:
											num8 = current2[(object)0].ToObject<double>();
											num9 = ((JToken)vCyVlUx5sCpXk6IiMa48(current2, 1)).ToObject<double>();
											num7 = 1;
											if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 != 0)
											{
												num7 = 0;
											}
											continue;
										case 1:
											U4ioFLPLW7Z(num8, num9);
											break;
										case 2:
											if (current2 != null)
											{
												num7 = 0;
												if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 == 0)
												{
													num7 = 0;
												}
												continue;
											}
											break;
										}
										break;
									}
								}
							}
							finally
							{
								enumerator?.Dispose();
							}
							enumerator = P_0.Asks.GetEnumerator();
							num2 = 3;
							continue;
						case 3:
							try
							{
								while (true)
								{
									IL_022c:
									int num3;
									if (!S05cWXx5X2IoILuoy4Sj(enumerator))
									{
										num3 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
										{
											num3 = 1;
										}
									}
									else
									{
										current = enumerator.Current;
										if (current == null)
										{
											continue;
										}
										num3 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
										{
											num3 = 0;
										}
									}
									while (true)
									{
										switch (num3)
										{
										default:
											num4 = ((JToken)vCyVlUx5sCpXk6IiMa48(current, 0)).ToObject<double>();
											num5 = current[(object)1].ToObject<double>();
											num3 = 1;
											if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
											{
												num3 = 2;
											}
											continue;
										case 2:
											i5KoFxXiln5(num4, num5);
											break;
										case 1:
											goto end_IL_01cf;
										}
										goto IL_022c;
										continue;
										end_IL_01cf:
										break;
									}
									break;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									AiTPGfx5Ljpocx2XafFy(enumerator);
									int num6 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									case 0:
										break;
									}
								}
							}
							result = true;
							num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c != 0)
							{
								num2 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(gGbvJrCT8oA);
				}
			}
			return result;
		}
		}
	}

	public override void odClvnSDwKl(Symbol P_0, MarketDepthFullEvent P_1)
	{
		long num = 0L;
		long num2 = 0L;
		int num3 = 3;
		while (true)
		{
			switch (num3)
			{
			case 1:
				return;
			default:
				num2 = 0L;
				num3 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 != 0)
				{
					num3 = 1;
				}
				break;
			case 3:
			{
				IEnumerator<KeyValuePair<decimal, decimal>> enumerator2 = NyAoFcXcgb8.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						KeyValuePair<decimal, decimal> current2 = enumerator2.Current;
						int num5 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								num = P_0.GetShortPrice(mYrR78x5cToZ7RLAqrl2(current2.Key));
								num2 = P_0.GetShortSize(mYrR78x5cToZ7RLAqrl2(current2.Value) * P_0.ContractValue);
								num5 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d != 0)
								{
									num5 = 0;
								}
								continue;
							}
							break;
						}
						P_1.AcdlolmAx8M(num, num2);
					}
				}
				finally
				{
					if (enumerator2 == null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					else
					{
						enumerator2.Dispose();
					}
				}
				P_1.crlG3Y3Z6h4(num, num2);
				num = 0L;
				num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
				{
					num3 = 0;
				}
				break;
			}
			case 2:
			{
				using (IEnumerator<KeyValuePair<decimal, decimal>> enumerator = NvsoFjJFZ1G.GetEnumerator())
				{
					while (S05cWXx5X2IoILuoy4Sj(enumerator))
					{
						KeyValuePair<decimal, decimal> current = enumerator.Current;
						num = P_0.GetShortPrice((double)current.Key);
						int num4 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								num2 = P_0.GetShortSize((double)current.Value * P_0.ContractValue);
								num4 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac != 0)
								{
									num4 = 0;
								}
								continue;
							}
							break;
						}
						KGv6dHx5jMbq8ce2R92v(P_1, num, num2);
					}
				}
				P_1.tvhG3Giodyj(num, num2);
				num3 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca != 0)
				{
					num3 = 0;
				}
				break;
			}
			}
		}
	}

	static h5hdepvJTq0gnlcikVPT()
	{
		H1eVotx5EJeQo45mHqRl();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static double N8WNF1x51eORI27OOdeE(object P_0)
	{
		return ((SymbolBase)P_0).Step;
	}

	internal static bool NZ81y1x5NJbv0TIHRBWV()
	{
		return bhXVN3x5bgPB20bN6g1o == null;
	}

	internal static h5hdepvJTq0gnlcikVPT wxUMQHx5kt7SWCkIrfvd()
	{
		return bhXVN3x5bgPB20bN6g1o;
	}

	internal static decimal GlolwXx55kk18Kj8ljXf(double P_0)
	{
		return (decimal)P_0;
	}

	internal static long bpUIDex5SmMRFAu5C9Uk(decimal P_0)
	{
		return (long)P_0;
	}

	internal static void n16mGqx5xoO2H4FYOjiG()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void AiTPGfx5Ljpocx2XafFy(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void WMbvESx5ecQ82oKJ0tqF(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object vCyVlUx5sCpXk6IiMa48(object P_0, object P_1)
	{
		return ((JToken)P_0)[P_1];
	}

	internal static bool S05cWXx5X2IoILuoy4Sj(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static double mYrR78x5cToZ7RLAqrl2(decimal P_0)
	{
		return (double)P_0;
	}

	internal static void KGv6dHx5jMbq8ce2R92v(object P_0, long P_1, long P_2)
	{
		((MarketDepthDiffEvent)P_0).YlHloi6rCYj(P_1, P_2);
	}

	internal static void H1eVotx5EJeQo45mHqRl()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
