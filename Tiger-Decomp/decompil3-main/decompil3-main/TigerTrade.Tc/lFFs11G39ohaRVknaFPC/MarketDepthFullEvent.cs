using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using amKgk7GJqUGhPrEY71aU;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using sIFWheGF3OYNVQk97tur;
using TigerTrade.Tc.Data;
using U0vBVyGFnRQg4TAEWduY;
using x97CE55GhEYKgt7TSVZT;

namespace lFFs11G39ohaRVknaFPC;

public class MarketDepthFullEvent : MarketDepthDiffEvent
{
	[CompilerGenerated]
	private long r9tG3i41e4G;

	[CompilerGenerated]
	private long KVwG3lGwvYP;

	[CompilerGenerated]
	private long QYpG34ipwrD;

	[CompilerGenerated]
	private long wsMG3DQREc1;

	[CompilerGenerated]
	private long kWsG3buuQT8;

	[CompilerGenerated]
	private long RhlG3NDrDNA;

	[CompilerGenerated]
	private long YW5G3kqBvnG;

	[CompilerGenerated]
	private long eekG31r4opH;

	[CompilerGenerated]
	private long y9ZG35jWsrd;

	[CompilerGenerated]
	private long mPHG3SYvmyy;

	private static MarketDepthFullEvent lcwMVs58CpT9ojeSHU3e;

	public long BestBidPrice
	{
		[CompilerGenerated]
		get
		{
			return r9tG3i41e4G;
		}
		[CompilerGenerated]
		internal set
		{
			r9tG3i41e4G = num;
		}
	}

	public long BestAskPrice
	{
		[CompilerGenerated]
		get
		{
			return KVwG3lGwvYP;
		}
		[CompilerGenerated]
		internal set
		{
			KVwG3lGwvYP = kVwG3lGwvYP;
		}
	}

	public long BestBidSize
	{
		[CompilerGenerated]
		get
		{
			return QYpG34ipwrD;
		}
		[CompilerGenerated]
		internal set
		{
			QYpG34ipwrD = qYpG34ipwrD;
		}
	}

	public long BestAskSize
	{
		[CompilerGenerated]
		get
		{
			return wsMG3DQREc1;
		}
		[CompilerGenerated]
		internal set
		{
			wsMG3DQREc1 = num;
		}
	}

	public long LastBidPrice
	{
		[CompilerGenerated]
		get
		{
			return kWsG3buuQT8;
		}
		[CompilerGenerated]
		internal set
		{
			kWsG3buuQT8 = num;
		}
	}

	public long LastAskPrice
	{
		[CompilerGenerated]
		get
		{
			return RhlG3NDrDNA;
		}
		[CompilerGenerated]
		internal set
		{
			RhlG3NDrDNA = rhlG3NDrDNA;
		}
	}

	public long LastBidSize
	{
		[CompilerGenerated]
		get
		{
			return YW5G3kqBvnG;
		}
		[CompilerGenerated]
		internal set
		{
			YW5G3kqBvnG = yW5G3kqBvnG;
		}
	}

	public long LastAskSize
	{
		[CompilerGenerated]
		get
		{
			return eekG31r4opH;
		}
		[CompilerGenerated]
		internal set
		{
			eekG31r4opH = num;
		}
	}

	public long BidsSize
	{
		[CompilerGenerated]
		get
		{
			return y9ZG35jWsrd;
		}
		[CompilerGenerated]
		internal set
		{
			y9ZG35jWsrd = num;
		}
	}

	public long AsksSize
	{
		[CompilerGenerated]
		get
		{
			return mPHG3SYvmyy;
		}
		[CompilerGenerated]
		internal set
		{
			mPHG3SYvmyy = num;
		}
	}

	internal void d8mG3nFutXI(MarketDepthDiffEvent P_0)
	{
		int num = 2;
		int num2 = num;
		bool flag = default(bool);
		bool flag2 = default(bool);
		IEnumerator<KeyValuePair<long, long>> enumerator = default(IEnumerator<KeyValuePair<long, long>>);
		long num6 = default(long);
		long num3 = default(long);
		(long, long) tuple = default((long, long));
		while (true)
		{
			switch (num2)
			{
			case 3:
				tuple = AqCG3vjwIsQ(iQsG32Ssypy, BestAskPrice, 1L);
				(BestAskPrice, BestAskSize) = tuple;
				goto IL_043e;
			case 7:
				base.LastPing = P_0.LastPing;
				base.Version.mIPG3siIQQB(P_0.Version);
				flag = false;
				num2 = 6;
				break;
			case 1:
				_ = BestBidPrice;
				num2 = 7;
				break;
			case 6:
				flag2 = false;
				enumerator = P_0.Asks.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<long, long> current = enumerator.Current;
						AsksSize += HgPkxwGJOat6QIA5PDSs.s3yGJt7ppC5(iQsG32Ssypy, current.Key, current.Value, 0L);
						int num5;
						if (BestAskPrice <= current.Key)
						{
							int num4 = 2;
							num5 = num4;
							goto IL_00f2;
						}
						goto IL_0227;
						IL_0227:
						num3 = current.Key;
						num6 = current.Value;
						long num7 = (BestAskPrice = num3);
						num7 = (BestAskSize = num6);
						num5 = 4;
						goto IL_00f2;
						IL_00f2:
						while (true)
						{
							switch (num5)
							{
							case 1:
								if (num3 != 0L)
								{
									break;
								}
								goto case 5;
							case 4:
							{
								long bestAskPrice = BestAskPrice;
								num6 = current.Key;
								num3 = current.Value;
								if (bestAskPrice == num6)
								{
									num5 = 1;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
									{
										num5 = 0;
									}
									continue;
								}
								break;
							}
							case 2:
								if (BestAskPrice != 0L)
								{
									goto case 4;
								}
								goto IL_0227;
							case 3:
								goto IL_0227;
							case 5:
								flag = true;
								num5 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 == 0)
								{
									num5 = 0;
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				goto case 5;
			case 5:
				enumerator = P_0.Bids.GetEnumerator();
				try
				{
					while (KqfWZW58mQR20VYTfN7j(enumerator))
					{
						KeyValuePair<long, long> current2 = enumerator.Current;
						int num10 = 3;
						while (true)
						{
							long bestBidPrice;
							switch (num10)
							{
							default:
							{
								long num7 = (BestBidPrice = num3);
								num10 = 2;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c != 0)
								{
									num10 = 0;
								}
								continue;
							}
							case 1:
								num6 = current2.Value;
								num10 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 == 0)
								{
									num10 = 0;
								}
								continue;
							case 2:
							{
								long num7 = (BestBidSize = num6);
								goto IL_031e;
							}
							case 4:
								flag2 = true;
								break;
							case 3:
								{
									BidsSize += HgPkxwGJOat6QIA5PDSs.s3yGJt7ppC5(WcsG30XNwUn, current2.Key, current2.Value, 0L);
									if (BestBidPrice < current2.Key || BestBidPrice == 0L)
									{
										num3 = current2.Key;
										num10 = 1;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca != 0)
										{
											num10 = 0;
										}
										continue;
									}
									goto IL_031e;
								}
								IL_031e:
								bestBidPrice = BestBidPrice;
								num6 = current2.Key;
								num3 = current2.Value;
								if (bestBidPrice == num6 && num3 == 0L)
								{
									num10 = 4;
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
				goto case 8;
			case 4:
				num3 = (BestBidSize = tuple.Item2);
				return;
			case 8:
				if (flag)
				{
					num2 = 3;
					break;
				}
				goto IL_043e;
			case 2:
				{
					_ = BestAskPrice;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
					{
						num2 = 1;
					}
					break;
				}
				IL_043e:
				if (flag2)
				{
					tuple = c6LG3B79mSE(WcsG30XNwUn, BestBidPrice, -1L);
					num3 = (BestBidPrice = tuple.Item1);
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 != 0)
					{
						num2 = 4;
					}
					break;
				}
				return;
			}
		}
	}

	internal override void YlHloi6rCYj(long P_0, long P_1)
	{
		if (P_1 == 0L)
		{
			return;
		}
		HgPkxwGJOat6QIA5PDSs.Gi6GJWptHb5(WcsG30XNwUn, P_0, P_1);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				if (BestBidPrice == 0L)
				{
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
					{
						num = 1;
					}
					break;
				}
				if (BestBidPrice < P_0)
				{
					goto case 1;
				}
				return;
			case 1:
				BestBidPrice = P_0;
				BestBidSize = P_1;
				return;
			default:
				BidsSize += P_1;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	internal override void AcdlolmAx8M(long P_0, long P_1)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (BestAskPrice != 0L && BestAskPrice <= P_0)
					{
						return;
					}
					goto end_IL_0012;
				case 1:
					return;
				case 2:
					if (P_1 != 0L)
					{
						HgPkxwGJOat6QIA5PDSs.Gi6GJWptHb5(iQsG32Ssypy, P_0, P_1);
						AsksSize += P_1;
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
						{
							num2 = 1;
						}
					}
					break;
				case 3:
					BestAskSize = P_1;
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			BestAskPrice = P_0;
			num = 3;
		}
	}

	internal void tvhG3Giodyj(long P_0, long P_1)
	{
		LastBidPrice = P_0;
		LastBidSize = P_1;
	}

	internal void crlG3Y3Z6h4(long P_0, long P_1)
	{
		LastAskPrice = P_0;
		LastAskSize = P_1;
	}

	internal MarketDepthFullEvent bKjG3oeRQva(Symbol P_0)
	{
		int num = 5;
		int num2 = num;
		MarketDepthFullEvent marketDepthFullEvent = default(MarketDepthFullEvent);
		Dictionary<long, long>.Enumerator enumerator = default(Dictionary<long, long>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 7:
				marketDepthFullEvent.BestAskSize = BestAskSize;
				num2 = 3;
				continue;
			case 5:
				marketDepthFullEvent = (MarketDepthFullEvent)kIdkDl58h2hX4TW4JM51(P_0);
				num2 = 4;
				continue;
			case 2:
				marketDepthFullEvent.LastBidSize = LastBidSize;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d != 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				marketDepthFullEvent.BestAskPrice = BestAskPrice;
				num2 = 5;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d != 0)
				{
					num2 = 7;
				}
				continue;
			case 3:
				kK8kvq5875E05CY3lu31(marketDepthFullEvent, LastBidPrice);
				num2 = 2;
				continue;
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<long, long> current = enumerator.Current;
						marketDepthFullEvent.WcsG30XNwUn[current.Key] = current.Value;
					}
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				return marketDepthFullEvent;
			case 4:
				marketDepthFullEvent.Symbol = P_0;
				marketDepthFullEvent.LastPing = base.LastPing;
				marketDepthFullEvent.Version = base.Version;
				marketDepthFullEvent.BestBidPrice = BestBidPrice;
				e7M3VJ58wJ2VZnSKQmtj(marketDepthFullEvent, BestBidSize);
				num2 = 6;
				continue;
			}
			marketDepthFullEvent.LastAskPrice = LastAskPrice;
			marketDepthFullEvent.LastAskSize = LastAskSize;
			foreach (KeyValuePair<long, long> item in iQsG32Ssypy)
			{
				marketDepthFullEvent.iQsG32Ssypy[item.Key] = item.Value;
				int num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				}
			}
			enumerator = WcsG30XNwUn.GetEnumerator();
			num2 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 != 0)
			{
				num2 = 1;
			}
		}
	}

	public override bool dqLlndlurqO()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					BestBidPrice = 0L;
					BestBidSize = 0L;
					num2 = 5;
					continue;
				case 6:
					BestAskPrice = 0L;
					BestAskSize = 0L;
					num2 = 2;
					continue;
				case 4:
					break;
				default:
					base.Symbol = null;
					base.LastPing = 0;
					base.Version = null;
					AsksSize = 0L;
					BidsSize = 0L;
					num2 = 6;
					continue;
				case 3:
					WcsG30XNwUn.Clear();
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					LastAskPrice = 0L;
					LastAskSize = 0L;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					LastBidPrice = 0L;
					LastBidSize = 0L;
					return true;
				}
				break;
			}
			iQsG32Ssypy.Clear();
			num = 3;
		}
	}

	private (long, long) AqCG3vjwIsQ(IDictionary<long, long> P_0, long P_1, long P_2)
	{
		(long, long) result = (0L, 0L);
		foreach (KeyValuePair<long, long> item in P_0)
		{
			if (item.Value != 0L && (result.Item1 > item.Key || result.Item1 == 0L))
			{
				result = (item.Key, item.Value);
			}
		}
		return result;
	}

	private (long, long) c6LG3B79mSE(IDictionary<long, long> P_0, long P_1, long P_2)
	{
		(long, long) result = (0L, 0L);
		foreach (KeyValuePair<long, long> item in P_0)
		{
			if (item.Value != 0L && (result.Item1 < item.Key || result.Item1 == 0L))
			{
				result = (item.Key, item.Value);
			}
		}
		return result;
	}

	private (long, long) vGxG3aITyO4(IDictionary<long, long> P_0, long P_1, long P_2)
	{
		long value = 0L;
		while (!P_0.TryGetValue(P_1, out value))
		{
			P_1 += P_2;
		}
		return (P_1, value);
	}

	public MarketDepthFullEvent()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static MarketDepthFullEvent()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		N19tsL588f2nvAco3hrZ();
	}

	internal static bool r0GD9w58rRFHJkxXWx98()
	{
		return lcwMVs58CpT9ojeSHU3e == null;
	}

	internal static MarketDepthFullEvent LeROiG58Kixk7SC3Qyed()
	{
		return lcwMVs58CpT9ojeSHU3e;
	}

	internal static bool KqfWZW58mQR20VYTfN7j(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object kIdkDl58h2hX4TW4JM51(object P_0)
	{
		return IlvHiXGF9pA6U4gUK5bq.GElGFDDmQlk((Symbol)P_0);
	}

	internal static void e7M3VJ58wJ2VZnSKQmtj(object P_0, long P_1)
	{
		((MarketDepthFullEvent)P_0).BestBidSize = P_1;
	}

	internal static void kK8kvq5875E05CY3lu31(object P_0, long P_1)
	{
		((MarketDepthFullEvent)P_0).LastBidPrice = P_1;
	}

	internal static void N19tsL588f2nvAco3hrZ()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
