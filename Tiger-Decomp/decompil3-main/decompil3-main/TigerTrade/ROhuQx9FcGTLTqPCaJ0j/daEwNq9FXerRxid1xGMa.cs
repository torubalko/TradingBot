using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using Io0TBCnnT6SonDXm9K0y;
using lFFs11G39ohaRVknaFPC;
using TigerTrade.Chart.Data;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using Wf1kTvnGy6XhfTKJgfkM;

namespace ROhuQx9FcGTLTqPCaJ0j;

internal sealed class daEwNq9FXerRxid1xGMa : IRawMarketDepth
{
	private readonly Dictionary<long, (long, long)> UvE9FpubjZ5;

	private readonly Dictionary<long, (long, long)> Lml9Fu7RTUE;

	private readonly Dictionary<long, (long, long)> Fps9Fz6kM7n;

	private readonly Dictionary<long, (long, long)> tZS930UE3gi;

	[CompilerGenerated]
	private long sOr932H21ik;

	[CompilerGenerated]
	private long Dcw93HXPXqc;

	[CompilerGenerated]
	private long m4893fsjX2E;

	[CompilerGenerated]
	private long NFL939ijPNG;

	[CompilerGenerated]
	private long f7093nQSt1T;

	[CompilerGenerated]
	private long TLY93GB0leJ;

	[CompilerGenerated]
	private long BfJ93YWk5sv;

	[CompilerGenerated]
	private long DKK93oqAkPe;

	[CompilerGenerated]
	private long zeJ93vYHMXc;

	[CompilerGenerated]
	private long oq493B09KXA;

	[CompilerGenerated]
	private long wXI93aC4Gip;

	[CompilerGenerated]
	private long gb493i8o66a;

	[CompilerGenerated]
	private long gtm93l0vPPm;

	internal static daEwNq9FXerRxid1xGMa Ehw3t3bm2ecQUMFjTQIp;

	public long BidPrice => MaxBidPrice;

	public long BidSize
	{
		[CompilerGenerated]
		get
		{
			return Dcw93HXPXqc;
		}
		[CompilerGenerated]
		private set
		{
			Dcw93HXPXqc = dcw93HXPXqc;
		}
	}

	public long AskPrice => MinAskPrice;

	public long AskSize
	{
		[CompilerGenerated]
		get
		{
			return NFL939ijPNG;
		}
		[CompilerGenerated]
		private set
		{
			NFL939ijPNG = nFL939ijPNG;
		}
	}

	public long MaxBidPrice
	{
		[CompilerGenerated]
		get
		{
			return f7093nQSt1T;
		}
		[CompilerGenerated]
		private set
		{
			f7093nQSt1T = num;
		}
	}

	public long MinBidPrice
	{
		[CompilerGenerated]
		get
		{
			return TLY93GB0leJ;
		}
		[CompilerGenerated]
		private set
		{
			TLY93GB0leJ = tLY93GB0leJ;
		}
	}

	public long MaxAskPrice
	{
		[CompilerGenerated]
		get
		{
			return BfJ93YWk5sv;
		}
		[CompilerGenerated]
		private set
		{
			BfJ93YWk5sv = bfJ93YWk5sv;
		}
	}

	public long MinAskPrice
	{
		[CompilerGenerated]
		get
		{
			return DKK93oqAkPe;
		}
		[CompilerGenerated]
		private set
		{
			DKK93oqAkPe = dKK93oqAkPe;
		}
	}

	public long MaxSize
	{
		[CompilerGenerated]
		get
		{
			return zeJ93vYHMXc;
		}
		[CompilerGenerated]
		private set
		{
			zeJ93vYHMXc = num;
		}
	}

	public long MaxSizeInQuote
	{
		[CompilerGenerated]
		get
		{
			return oq493B09KXA;
		}
		[CompilerGenerated]
		private set
		{
			oq493B09KXA = num;
		}
	}

	public long MinSize
	{
		[CompilerGenerated]
		get
		{
			return wXI93aC4Gip;
		}
		[CompilerGenerated]
		private set
		{
			wXI93aC4Gip = num;
		}
	}

	public IReadOnlyDictionary<long, (long B, long Q)> AskQuotes => tZS930UE3gi;

	public IReadOnlyDictionary<long, (long B, long Q)> BidQuotes => Fps9Fz6kM7n;

	[SpecialName]
	[CompilerGenerated]
	public long MOr9F63nWYw()
	{
		return sOr932H21ik;
	}

	[SpecialName]
	[CompilerGenerated]
	private void K4W9FMHNPxq(long P_0)
	{
		sOr932H21ik = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public long sZK9Ftv0iH4()
	{
		return m4893fsjX2E;
	}

	[SpecialName]
	[CompilerGenerated]
	private void oWt9FUKUTTb(long P_0)
	{
		m4893fsjX2E = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public long D2L9F80pBSC()
	{
		return gb493i8o66a;
	}

	[SpecialName]
	[CompilerGenerated]
	private void eZh9FAW9Rof(long P_0)
	{
		gb493i8o66a = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public long J4U9FJbJ6dA()
	{
		return gtm93l0vPPm;
	}

	[SpecialName]
	[CompilerGenerated]
	private void OlS9FFeA7C0(long P_0)
	{
		gtm93l0vPPm = P_0;
	}

	public void O2u9FjMqMms(ijsjhhnGTadfwpOyDdrx P_0, MarketDepthFullEvent P_1, int P_2)
	{
		int num = 3;
		long num6 = default(long);
		IEnumerator<KeyValuePair<long, long>> enumerator2 = default(IEnumerator<KeyValuePair<long, long>>);
		KeyValuePair<long, long> current2 = default(KeyValuePair<long, long>);
		long key = default(long);
		long num5 = default(long);
		KeyValuePair<long, long> current6 = default(KeyValuePair<long, long>);
		(long, long) value2 = default((long, long));
		Dictionary<long, (long, long)>.Enumerator enumerator = default(Dictionary<long, (long, long)>.Enumerator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					num6 = 0L;
					if (P_2 > 1)
					{
						num2 = 9;
						break;
					}
					enumerator2 = P_1.Asks.GetEnumerator();
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
					{
						num2 = 8;
					}
					break;
				case 6:
					try
					{
						while (true)
						{
							IL_00f1:
							int num4;
							if (!enumerator2.MoveNext())
							{
								num4 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
								{
									num4 = 1;
								}
							}
							else
							{
								current2 = enumerator2.Current;
								key = MI4nfsnnUf3PYtFXkT2T.h0snnZq2E2e(current2.Key, P_2, _0020: false);
								num4 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
								{
									num4 = 0;
								}
							}
							while (true)
							{
								switch (num4)
								{
								default:
									num5 = current2.Value;
									num4 = 2;
									continue;
								case 2:
									break;
								case 1:
									goto end_IL_00b0;
								}
								num6 = P_0.GetRawQuoteSize(current2.Key, current2.Value, P_2);
								Lml9Fu7RTUE.TryGetValue(key, out var value);
								Lml9Fu7RTUE[key] = (value.Item1 + num5, value.Item2 + num6);
								goto IL_00f1;
								continue;
								end_IL_00b0:
								break;
							}
							break;
						}
					}
					finally
					{
						enumerator2?.Dispose();
					}
					goto end_IL_0012;
				case 7:
					UvE9FpubjZ5.Clear();
					return;
				case 3:
					Clear();
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					eZh9FAW9Rof(P_1.BidsSize);
					OlS9FFeA7C0(xf2qrmbm9b1PkPuaAFJH(P_1));
					K4W9FMHNPxq(P_1.BestBidPrice);
					oWt9FUKUTTb(ic0Osibmn8uopNbJWGYe(P_1));
					key = 0L;
					num5 = 0L;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
					{
						num2 = 1;
					}
					break;
				case 8:
					try
					{
						while (KgsUkwbmo9N8DYOPT5HH(enumerator2))
						{
							KeyValuePair<long, long> current5 = enumerator2.Current;
							int num9 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
							{
								num9 = 1;
							}
							while (true)
							{
								switch (num9)
								{
								case 1:
									num5 = current5.Value;
									num6 = P_0.GetRawQuoteSize(current5.Key, current5.Value, P_2);
									num9 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
									{
										num9 = 0;
									}
									continue;
								}
								break;
							}
							QZb9FEMdXEZ(current5.Key, (num5, num6), Side.Sell);
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							RtGUQibmGH0Xu9ML5bvZ(enumerator2);
						}
					}
					goto default;
				case 9:
					enumerator2 = P_1.Asks.GetEnumerator();
					num2 = 6;
					break;
				default:
				{
					using IEnumerator<KeyValuePair<long, long>> enumerator3 = P_1.Bids.GetEnumerator();
					while (true)
					{
						int num10;
						if (enumerator3.MoveNext())
						{
							current6 = enumerator3.Current;
							num5 = current6.Value;
							num6 = P_0.GetRawQuoteSize(current6.Key, current6.Value, P_2);
							num10 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
							{
								num10 = 0;
							}
						}
						else
						{
							num10 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
							{
								num10 = 1;
							}
						}
						switch (num10)
						{
						case 1:
							return;
						}
						zN69FQV3t7U(current6.Key, (num5, num6), Side.Buy);
					}
				}
				case 5:
					try
					{
						while (true)
						{
							IL_04ea:
							int num8;
							if (enumerator2.MoveNext())
							{
								KeyValuePair<long, long> current4 = enumerator2.Current;
								key = MI4nfsnnUf3PYtFXkT2T.h0snnZq2E2e(current4.Key, P_2, _0020: true);
								num5 = current4.Value;
								num6 = P_0.GetRawQuoteSize(current4.Key, current4.Value, P_2);
								num8 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
								{
									num8 = 0;
								}
							}
							else
							{
								num8 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
								{
									num8 = 1;
								}
							}
							while (true)
							{
								switch (num8)
								{
								default:
									UvE9FpubjZ5.TryGetValue(key, out value2);
									num8 = 2;
									continue;
								case 2:
									break;
								case 1:
									goto end_IL_0481;
								}
								UvE9FpubjZ5[key] = (value2.Item1 + num5, value2.Item2 + num6);
								goto IL_04ea;
								continue;
								end_IL_0481:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							RtGUQibmGH0Xu9ML5bvZ(enumerator2);
						}
					}
					enumerator = UvE9FpubjZ5.GetEnumerator();
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
					{
						num2 = 3;
					}
					break;
				case 10:
					try
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<long, (long, long)> current3 = enumerator.Current;
							zN69FQV3t7U(current3.Key, current3.Value, Side.Buy);
						}
						int num7 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					IbZBSObmYqgP6dslMhoF(Lml9Fu7RTUE);
					num2 = 7;
					break;
				case 4:
					try
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<long, (long, long)> current = enumerator.Current;
							int num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
							{
								num3 = 0;
							}
							switch (num3)
							{
							}
							QZb9FEMdXEZ(current.Key, current.Value, Side.Sell);
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					enumerator2 = P_1.Bids.GetEnumerator();
					num2 = 5;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			enumerator = Lml9Fu7RTUE.GetEnumerator();
			num = 4;
		}
	}

	private void QZb9FEMdXEZ(long P_0, (long, long) P_1, Side P_2)
	{
		if (MaxAskPrice == 0L || P_0 > MaxAskPrice)
		{
			MaxAskPrice = P_0;
		}
		if (MinAskPrice == 0L || P_0 < MinAskPrice)
		{
			MinAskPrice = P_0;
			(AskSize, _) = P_1;
		}
		if (MaxSize < P_1.Item1)
		{
			(MaxSize, _) = P_1;
		}
		if (MinSize > P_1.Item1)
		{
			(MinSize, _) = P_1;
		}
		if (MaxSizeInQuote < P_1.Item2)
		{
			MaxSizeInQuote = P_1.Item2;
		}
		tZS930UE3gi.Add(P_0, P_1);
	}

	private void zN69FQV3t7U(long P_0, (long, long) P_1, Side P_2)
	{
		if (MaxBidPrice == 0L || P_0 > MaxBidPrice)
		{
			MaxBidPrice = P_0;
			(BidSize, _) = P_1;
		}
		if (MinBidPrice == 0L || P_0 < MinBidPrice)
		{
			MinBidPrice = P_0;
		}
		if (MaxSize < P_1.Item1)
		{
			(MaxSize, _) = P_1;
		}
		if (MinSize > P_1.Item1)
		{
			(MinSize, _) = P_1;
		}
		if (MaxSizeInQuote < P_1.Item2)
		{
			MaxSizeInQuote = P_1.Item2;
		}
		Fps9Fz6kM7n.Add(P_0, P_1);
	}

	public long pWf9FdbBnRR()
	{
		return (sZK9Ftv0iH4() + MOr9F63nWYw()) / 2;
	}

	public long E2o9FgnJ4m2()
	{
		long num = BidPrice;
		long num2 = AskPrice;
		if (num == 0L)
		{
			goto IL_0075;
		}
		goto IL_007e;
		IL_007e:
		if (num2 == 0L)
		{
			int num3 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
			{
				num3 = 1;
			}
			while (true)
			{
				switch (num3)
				{
				case 1:
					num2 = num;
					num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
					{
						num3 = 0;
					}
					continue;
				case 2:
					break;
				default:
					goto IL_009f;
				}
				break;
			}
			goto IL_0075;
		}
		goto IL_009f;
		IL_009f:
		return (num + num2) / 2;
		IL_0075:
		num = num2;
		goto IL_007e;
	}

	public void Clear()
	{
		Fps9Fz6kM7n.Clear();
		IbZBSObmYqgP6dslMhoF(tZS930UE3gi);
		MaxBidPrice = 0L;
		MinBidPrice = 0L;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				MaxSizeInQuote = 0L;
				return;
			case 1:
				MaxAskPrice = 0L;
				MinAskPrice = 0L;
				oWt9FUKUTTb(0L);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
				{
					num = 0;
				}
				break;
			case 2:
			{
				MinSize = 0L;
				int num2 = 4;
				num = num2;
				break;
			}
			default:
				K4W9FMHNPxq(0L);
				num = 3;
				break;
			case 3:
				BidSize = 0L;
				AskSize = 0L;
				MaxSize = 0L;
				num = 2;
				break;
			}
		}
	}

	public daEwNq9FXerRxid1xGMa()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		UvE9FpubjZ5 = new Dictionary<long, (long, long)>();
		Lml9Fu7RTUE = new Dictionary<long, (long, long)>();
		Fps9Fz6kM7n = new Dictionary<long, (long, long)>();
		tZS930UE3gi = new Dictionary<long, (long, long)>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static daEwNq9FXerRxid1xGMa()
	{
		HXLt3ubmvcLvdXIjSsSW();
	}

	internal static bool kskwLkbmH9efiAJpumJQ()
	{
		return Ehw3t3bm2ecQUMFjTQIp == null;
	}

	internal static daEwNq9FXerRxid1xGMa qKVQLebmf6TuS9gcc0Cj()
	{
		return Ehw3t3bm2ecQUMFjTQIp;
	}

	internal static long xf2qrmbm9b1PkPuaAFJH(object P_0)
	{
		return ((MarketDepthFullEvent)P_0).AsksSize;
	}

	internal static long ic0Osibmn8uopNbJWGYe(object P_0)
	{
		return ((MarketDepthFullEvent)P_0).BestAskPrice;
	}

	internal static void RtGUQibmGH0Xu9ML5bvZ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void IbZBSObmYqgP6dslMhoF(object P_0)
	{
		((Dictionary<long, (long, long)>)P_0).Clear();
	}

	internal static bool KgsUkwbmo9N8DYOPT5HH(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void HXLt3ubmvcLvdXIjSsSW()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
