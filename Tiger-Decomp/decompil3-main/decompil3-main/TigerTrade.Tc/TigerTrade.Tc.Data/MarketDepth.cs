using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using amKgk7GJqUGhPrEY71aU;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using lFFs11G39ohaRVknaFPC;
using nI0iklG3L4EXgsHYE0T1;
using sIFWheGF3OYNVQk97tur;
using U0vBVyGFnRQg4TAEWduY;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public sealed class MarketDepth
{
	private static readonly ActivitySource activitySource;

	private readonly Activity root;

	private readonly long PriceStep;

	private readonly syh8dIG3xetxRkGYZ5kB version;

	private readonly ReaderWriterLockSlim locker;

	private static MarketDepth J1aDK45uoUChPF0nTjZV;

	public syh8dIG3xetxRkGYZ5kB Version => version;

	public Symbol Symbol { get; internal set; }

	public int LastPing { get; internal set; }

	public long BestBidPrice { get; internal set; }

	public long BestAskPrice { get; internal set; }

	public long BestBidSize { get; internal set; }

	public long BestAskSize { get; internal set; }

	public long LastBidPrice { get; internal set; }

	public long LastAskPrice { get; internal set; }

	public long LastBidSize { get; internal set; }

	public long LastAskSize { get; internal set; }

	public long BidsSize { get; internal set; }

	public long AsksSize { get; internal set; }

	public Dictionary<long, long> Bids { get; internal set; }

	public Dictionary<long, long> Asks { get; internal set; }

	public MarketDepth(Symbol symbol)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		PriceStep = 1L;
		version = syh8dIG3xetxRkGYZ5kB.Default;
		locker = new ReaderWriterLockSlim();
		base._002Ector();
		root = activitySource.StartActivity(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7394D272 ^ 0x73942042));
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 1:
			{
				ActivitySource obj = activitySource;
				object name = L3CCDG5uaSQ81vmGiq7i(symbol);
				Activity activity = root;
				Activity? activity2 = obj.StartActivity((string)name, ActivityKind.Internal, (activity != null) ? yN7Xe85uia5kWsUrneMY(activity) : default(ActivityContext));
				Symbol = symbol;
				Bids = new Dictionary<long, long>(512);
				Asks = new Dictionary<long, long>(512);
				activity2?.SetTag(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2056710528 ^ -2056707958), symbol.Name);
				if (activity2 == null)
				{
					break;
				}
				activity2.Dispose();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 == 0)
				{
					num = 0;
				}
				continue;
			}
			case 2:
				return;
			}
			Activity activity3 = root;
			if (activity3 == null)
			{
				num = 2;
				continue;
			}
			nNoHSF5ulUpQMvIGJhFE(activity3);
			num = 3;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
			{
				num = 3;
			}
		}
	}

	internal void Apply(MarketDepthFullEvent e)
	{
		vFP9Kn5u43PXSGrMl44O(locker);
		h2Ze8c5uD7938SlEEcT4(version, e.Version);
		LastPing = e.LastPing;
		int num = 7;
		int num2 = num;
		IEnumerator<KeyValuePair<long, long>> enumerator = default(IEnumerator<KeyValuePair<long, long>>);
		long num3 = default(long);
		long bestAskSize = default(long);
		while (true)
		{
			switch (num2)
			{
			case 2:
				enumerator = e.Bids.GetEnumerator();
				try
				{
					while (K0gN225ubPj1lxgCpoch(enumerator))
					{
						while (true)
						{
							KeyValuePair<long, long> current = enumerator.Current;
							if (current.Value != 0L)
							{
								HgPkxwGJOat6QIA5PDSs.Gi6GJWptHb5(Bids, current.Key, current.Value);
								BidsSize += current.Value;
								int num15 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 != 0)
								{
									num15 = 1;
								}
								switch (num15)
								{
								case 1:
									break;
								default:
									continue;
								}
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						enumerator.Dispose();
						int num16 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_70b4b4a3c8d3471f9796e8c8caf6f35b != 0)
						{
							num16 = 0;
						}
						switch (num16)
						{
						case 0:
							break;
						}
					}
				}
				AsksSize = XHgqCN5uN1lMQm5e4B1Y(e);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 != 0)
				{
					num2 = 3;
				}
				break;
			case 5:
			{
				bestAskSize = FsulRI5u1RSXt2Kan9N2(e);
				long num4 = (LastAskPrice = num3);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 6:
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<long, long> current2 = enumerator.Current;
						if (current2.Value == 0L)
						{
							continue;
						}
						HgPkxwGJOat6QIA5PDSs.Gi6GJWptHb5(Asks, current2.Key, current2.Value);
						int num18 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 != 0)
						{
							num18 = 0;
						}
						while (true)
						{
							switch (num18)
							{
							case 1:
								AsksSize += current2.Value;
								num18 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
								{
									num18 = 0;
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
				goto case 2;
			case 1:
				num3 = (BestAskSize = 0L);
				num3 = (BestBidPrice = 0L);
				num3 = (BestBidSize = 0L);
				num2 = 8;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 != 0)
				{
					num2 = 8;
				}
				break;
			case 3:
			{
				BidsSize = e.BidsSize;
				num3 = e.BestAskPrice;
				bestAskSize = e.BestAskSize;
				long num4 = (BestAskPrice = num3);
				num4 = (BestAskSize = bestAskSize);
				bestAskSize = W6ibql5ukWFkk3D3Kf93(e);
				num2 = 11;
				break;
			}
			case 9:
				num3 = e.LastAskPrice;
				num2 = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 != 0)
				{
					num2 = 5;
				}
				break;
			case 13:
				bestAskSize = k58t475u5ZApykW8ZHZY(e);
				num2 = 4;
				break;
			case 7:
				Asks.Clear();
				Bids.Clear();
				AsksSize = 0L;
				BidsSize = 0L;
				num3 = (BestAskPrice = 0L);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				enumerator = e.Asks.GetEnumerator();
				num2 = 6;
				break;
			case 14:
				locker.ExitWriteLock();
				return;
			case 4:
				num3 = e.LastBidSize;
				num2 = 12;
				break;
			default:
			{
				long num4 = (LastAskSize = bestAskSize);
				num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab != 0)
				{
					num2 = 13;
				}
				break;
			}
			case 10:
			{
				long num4 = (BestBidPrice = bestAskSize);
				num4 = (BestBidSize = num3);
				num2 = 9;
				break;
			}
			case 12:
			{
				long num4 = (LastBidPrice = bestAskSize);
				num4 = (LastBidSize = num3);
				num2 = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
				{
					num2 = 14;
				}
				break;
			}
			case 11:
				num3 = e.BestBidSize;
				num2 = 10;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	internal void Apply(MarketDepthDiffEvent e)
	{
		_ = BestAskPrice;
		_ = BestBidPrice;
		locker.EnterWriteLock();
		LastPing = e.LastPing;
		version.mIPG3siIQQB(e.Version);
		bool flag = false;
		int num = 6;
		IEnumerator<KeyValuePair<long, long>> enumerator = default(IEnumerator<KeyValuePair<long, long>>);
		long num7 = default(long);
		long num3 = default(long);
		bool flag2 = default(bool);
		while (true)
		{
			switch (num)
			{
			default:
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<long, long> current = enumerator.Current;
						AsksSize += HgPkxwGJOat6QIA5PDSs.s3yGJt7ppC5(Asks, current.Key, current.Value, 0L);
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
						{
							num2 = 1;
						}
						while (true)
						{
							switch (num2)
							{
							case 4:
							{
								long bestAskPrice = BestAskPrice;
								num7 = current.Key;
								num3 = current.Value;
								if (bestAskPrice == num7)
								{
									num2 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
									{
										num2 = 0;
									}
									continue;
								}
								break;
							}
							case 3:
								num7 = current.Value;
								num2 = 2;
								continue;
							default:
								if (num3 == 0L)
								{
									flag = true;
								}
								break;
							case 5:
								if (BestAskPrice != 0L)
								{
									num2 = 4;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
									{
										num2 = 4;
									}
									continue;
								}
								goto IL_00e2;
							case 2:
							{
								long num4 = (BestAskPrice = num3);
								num4 = (BestAskSize = num7);
								goto case 4;
							}
							case 1:
								{
									if (BestAskPrice <= current.Key)
									{
										num2 = 5;
										continue;
									}
									goto IL_00e2;
								}
								IL_00e2:
								num3 = current.Key;
								num2 = 3;
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						IxIMlc5uSdj6SaTAhQ8c(enumerator);
					}
				}
				goto case 11;
			case 8:
				return;
			case 7:
				num3 = (BestBidSize = 0L);
				num = 9;
				break;
			case 3:
			{
				if (Asks.Count != 0)
				{
					num = 4;
					break;
				}
				num3 = (BestAskPrice = 0L);
				int num13 = 5;
				num = num13;
				break;
			}
			case 5:
				num3 = (BestAskSize = 0L);
				goto IL_023e;
			case 10:
				if (flag)
				{
					num = 3;
					break;
				}
				goto IL_023e;
			case 1:
			case 2:
			case 9:
				locker.ExitWriteLock();
				num = 8;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 != 0)
				{
					num = 4;
				}
				break;
			case 4:
			{
				(long, long) tuple = FindNextBestAsk(Asks, BestAskPrice, PriceStep);
				(BestAskPrice, _) = tuple;
				num3 = (BestAskSize = tuple.Item2);
				goto IL_023e;
			}
			case 11:
				enumerator = e.Bids.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						while (true)
						{
							KeyValuePair<long, long> current2 = enumerator.Current;
							BidsSize += HgPkxwGJOat6QIA5PDSs.s3yGJt7ppC5(Bids, current2.Key, current2.Value, 0L);
							int num8 = 5;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
							{
								num8 = 0;
							}
							while (true)
							{
								long bestBidPrice;
								switch (num8)
								{
								case 2:
									num3 = current2.Key;
									num7 = current2.Value;
									num8 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c == 0)
									{
										num8 = 0;
									}
									continue;
								case 5:
									if (BestBidPrice < current2.Key || BestBidPrice == 0L)
									{
										goto case 2;
									}
									goto IL_0390;
								case 4:
									break;
								case 3:
									goto end_IL_03e0;
								case 1:
									if (num3 == 0L)
									{
										flag2 = true;
										num8 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc != 0)
										{
											num8 = 3;
										}
										continue;
									}
									goto end_IL_03e0;
								default:
									{
										long num4 = (BestBidPrice = num3);
										num4 = (BestBidSize = num7);
										goto IL_0390;
									}
									IL_0390:
									bestBidPrice = BestBidPrice;
									num7 = current2.Key;
									num3 = current2.Value;
									if (bestBidPrice == num7)
									{
										num8 = 1;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
										{
											num8 = 1;
										}
										continue;
									}
									goto end_IL_03e0;
								}
								break;
							}
							continue;
							end_IL_03e0:
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						IxIMlc5uSdj6SaTAhQ8c(enumerator);
					}
				}
				goto case 10;
			case 6:
				{
					flag2 = false;
					enumerator = e.Asks.GetEnumerator();
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
					{
						num = 0;
					}
					break;
				}
				IL_023e:
				if (!flag2)
				{
					num = 2;
				}
				else if (Bids.Count != 0)
				{
					(long, long) tuple = FindNextBestBid(Bids, BestBidPrice, -PriceStep);
					(BestBidPrice, _) = tuple;
					num3 = (BestBidSize = tuple.Item2);
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
					{
						num = 1;
					}
				}
				else
				{
					num3 = (BestBidPrice = 0L);
					num = 7;
				}
				break;
			}
		}
	}

	internal MarketDepthFullEvent GetEvent(Symbol symbol)
	{
		int num = 6;
		int num2 = num;
		Dictionary<long, long>.Enumerator enumerator2 = default(Dictionary<long, long>.Enumerator);
		MarketDepthFullEvent marketDepthFullEvent = default(MarketDepthFullEvent);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					while (enumerator2.MoveNext())
					{
						KeyValuePair<long, long> current2 = enumerator2.Current;
						marketDepthFullEvent.YlHloi6rCYj(current2.Key, current2.Value);
					}
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
				break;
			case 6:
				Tqkm2d5ux0DxokjvftjF(locker);
				num2 = 5;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				marketDepthFullEvent = IlvHiXGF9pA6U4gUK5bq.GElGFDDmQlk(symbol);
				num2 = 2;
				continue;
			case 1:
				MYy7dV5usPkwjT1wO51u(marketDepthFullEvent, LastAskSize);
				F1F4ma5uX1GXhArm2cAs(marketDepthFullEvent, LastBidPrice);
				marketDepthFullEvent.LastBidSize = LastBidSize;
				marketDepthFullEvent.AsksSize = AsksSize;
				marketDepthFullEvent.BidsSize = BidsSize;
				locker.ExitReadLock();
				return marketDepthFullEvent;
			case 4:
				foreach (KeyValuePair<long, long> ask in Asks)
				{
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					}
					bUni6e5uLSyKVnk9IipQ(marketDepthFullEvent, ask.Key, ask.Value);
				}
				enumerator2 = Bids.GetEnumerator();
				num2 = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace != 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				marketDepthFullEvent.Version.vNpG3X8YCxF();
				num2 = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
				{
					num2 = 1;
				}
				continue;
			}
			OBcJgX5ueUrqBRj7dQMu(marketDepthFullEvent, LastAskPrice);
			num2 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
			{
				num2 = 1;
			}
		}
	}

	[Obsolete("Remove after Rithmic")]
	internal void Add(long price, long size, Side side)
	{
		if (size <= 0)
		{
			return;
		}
		locker.EnterWriteLock();
		int num;
		if (Asks.ContainsKey(price))
		{
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_00da;
		IL_00fd:
		Asks.Remove(price);
		goto IL_00da;
		IL_00da:
		if (Bids.ContainsKey(price))
		{
			Bids.Remove(price);
			num = 3;
			goto IL_0009;
		}
		goto IL_005d;
		IL_005d:
		if (side != Side.Buy)
		{
			Asks.Add(price, size);
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b == 0)
			{
				num = 0;
			}
		}
		else
		{
			Bids.Add(price, size);
			num = 2;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 3:
			break;
		case 4:
			return;
		default:
			locker.ExitWriteLock();
			return;
		case 1:
			goto IL_00fd;
		}
		goto IL_005d;
	}

	private (long newBestPrice, long newBestSize) FindNextBestAsk(IDictionary<long, long> source, long price, long step)
	{
		(long, long) result = (0L, 0L);
		foreach (KeyValuePair<long, long> item in source)
		{
			if (item.Value != 0L && (result.Item1 > item.Key || result.Item1 == 0L))
			{
				result = (item.Key, item.Value);
			}
		}
		return result;
	}

	private (long newBestPrice, long newBestSize) FindNextBestBid(IDictionary<long, long> source, long price, long step)
	{
		(long, long) result = (0L, 0L);
		foreach (KeyValuePair<long, long> item in source)
		{
			if (item.Value != 0L && (result.Item1 < item.Key || result.Item1 == 0L))
			{
				result = (item.Key, item.Value);
			}
		}
		return result;
	}

	private (long newBestPrice, long newBestSize) FindNextBest(IDictionary<long, long> source, long price, long step)
	{
		long value = 0L;
		while (!source.TryGetValue(price, out value))
		{
			price += step;
		}
		return (newBestPrice: price, newBestSize: value);
	}

	private void EnrichActivity(Activity activity, MarketDepthDiffEvent e)
	{
		activity?.SetTag(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x9F0F634 ^ 0x9F0047E), bquEqL5ucnyJqPMH8qXl(version));
		int num;
		if (activity != null)
		{
			activity.SetTag(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x11D1040B ^ 0x11D128E7), e.Version);
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_00a2;
		IL_00a2:
		if (activity != null)
		{
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_00c2;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 3:
				goto IL_00c2;
			default:
				activity.SetTag(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1583344314 ^ -1583290592), BestAskPrice);
				num = 3;
				continue;
			case 2:
				goto IL_0136;
			}
			break;
		}
		goto IL_00a2;
		IL_00c2:
		if (activity != null)
		{
			activity.SetTag(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-338769610 ^ -338805836), BestBidPrice);
			num = 2;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0136;
		IL_0136:
		activity?.SetStatus((BestAskPrice > BestBidPrice) ? ActivityStatusCode.Ok : ActivityStatusCode.Error);
	}

	static MarketDepth()
	{
		RbDH9e5ujeshYYkjMhu6();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		activitySource = new ActivitySource(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x706541F3 ^ 0x7065B3C3));
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool fENldm5uvKKXEsR5HH1u()
	{
		return J1aDK45uoUChPF0nTjZV == null;
	}

	internal static MarketDepth JNcwyW5uBerEe1i1RtOA()
	{
		return J1aDK45uoUChPF0nTjZV;
	}

	internal static object L3CCDG5uaSQ81vmGiq7i(object P_0)
	{
		return ((Symbol)P_0).Name;
	}

	internal static ActivityContext yN7Xe85uia5kWsUrneMY(object P_0)
	{
		return ((Activity)P_0).Context;
	}

	internal static void nNoHSF5ulUpQMvIGJhFE(object P_0)
	{
		((Activity)P_0).Dispose();
	}

	internal static void vFP9Kn5u43PXSGrMl44O(object P_0)
	{
		((ReaderWriterLockSlim)P_0).EnterWriteLock();
	}

	internal static void h2Ze8c5uD7938SlEEcT4(object P_0, object P_1)
	{
		((syh8dIG3xetxRkGYZ5kB)P_0).mIPG3siIQQB((syh8dIG3xetxRkGYZ5kB)P_1);
	}

	internal static bool K0gN225ubPj1lxgCpoch(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static long XHgqCN5uN1lMQm5e4B1Y(object P_0)
	{
		return ((MarketDepthFullEvent)P_0).AsksSize;
	}

	internal static long W6ibql5ukWFkk3D3Kf93(object P_0)
	{
		return ((MarketDepthFullEvent)P_0).BestBidPrice;
	}

	internal static long FsulRI5u1RSXt2Kan9N2(object P_0)
	{
		return ((MarketDepthFullEvent)P_0).LastAskSize;
	}

	internal static long k58t475u5ZApykW8ZHZY(object P_0)
	{
		return ((MarketDepthFullEvent)P_0).LastBidPrice;
	}

	internal static void IxIMlc5uSdj6SaTAhQ8c(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void Tqkm2d5ux0DxokjvftjF(object P_0)
	{
		((ReaderWriterLockSlim)P_0).EnterReadLock();
	}

	internal static void bUni6e5uLSyKVnk9IipQ(object P_0, long P_1, long P_2)
	{
		((MarketDepthDiffEvent)P_0).AcdlolmAx8M(P_1, P_2);
	}

	internal static void OBcJgX5ueUrqBRj7dQMu(object P_0, long P_1)
	{
		((MarketDepthFullEvent)P_0).LastAskPrice = P_1;
	}

	internal static void MYy7dV5usPkwjT1wO51u(object P_0, long P_1)
	{
		((MarketDepthFullEvent)P_0).LastAskSize = P_1;
	}

	internal static void F1F4ma5uX1GXhArm2cAs(object P_0, long P_1)
	{
		((MarketDepthFullEvent)P_0).LastBidPrice = P_1;
	}

	internal static long bquEqL5ucnyJqPMH8qXl(object P_0)
	{
		return ((syh8dIG3xetxRkGYZ5kB)P_0).LastUpdateId;
	}

	internal static void RbDH9e5ujeshYYkjMhu6()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
