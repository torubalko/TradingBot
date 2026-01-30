using System;
using System.Collections.Generic;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using lFFs11G39ohaRVknaFPC;
using nI0iklG3L4EXgsHYE0T1;
using sIFWheGF3OYNVQk97tur;
using TigerTrade.Tc.Data;
using U0vBVyGFnRQg4TAEWduY;
using u6fBRhYqedGKNWaNEwBZ;
using uja8AYYMLI5RuWOtt72J;
using x97CE55GhEYKgt7TSVZT;

namespace QhqbAlYOEfRLqWo3uZkm;

internal sealed class AKdfKuYOjHbBsC3lCg87
{
	private readonly GFv7xXYMxkL3Kkru2j7I gflYOdDCxLo;

	private long BhvYOgv9XRR;

	private readonly Dictionary<long, long> lrAYORAHqra;

	internal static AKdfKuYOjHbBsC3lCg87 Tts6BaSXnUJU8Yce33Qg;

	public AKdfKuYOjHbBsC3lCg87(GFv7xXYMxkL3Kkru2j7I P_0)
	{
		F6ASEaSXoAhHDKQYUw9Y();
		base._002Ector();
		lrAYORAHqra = new Dictionary<long, long>();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		gflYOdDCxLo = P_0;
	}

	public MarketDepthFullEvent RiWYOQiuvcM(Symbol P_0, byte[] P_1)
	{
		fSe09yYqLrWV6gXnueCG fSe09yYqLrWV6gXnueCG = new fSe09yYqLrWV6gXnueCG(P_1, _0020: true);
		int num = (int)KBE5HnSXvnKCjs3lFiaj(fSe09yYqLrWV6gXnueCG);
		int num2 = 0;
		MarketDepthFullEvent marketDepthFullEvent = default(MarketDepthFullEvent);
		Dictionary<long, long>.Enumerator enumerator = default(Dictionary<long, long>.Enumerator);
		long num4 = default(long);
		long shortPrice = default(long);
		long shortSize = default(long);
		while (true)
		{
			int num3;
			if (num2 < num)
			{
				BhvYOgv9XRR += fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
				num3 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
				{
					num3 = 0;
				}
			}
			else
			{
				fSe09yYqLrWV6gXnueCG.Dispose();
				marketDepthFullEvent = (MarketDepthFullEvent)wjEtWPSXBVAd2a9qGo4Q(P_0);
				num3 = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
				{
					num3 = 5;
				}
			}
			while (true)
			{
				switch (num3)
				{
				case 5:
					vc8UGGSXixPG2cfx3h3G(b7vhoQSXaZ5TwDTNsako(marketDepthFullEvent));
					enumerator = lrAYORAHqra.GetEnumerator();
					num3 = 2;
					break;
				case 4:
					return marketDepthFullEvent;
				case 3:
					lrAYORAHqra.Remove(BhvYOgv9XRR);
					goto end_IL_0009;
				default:
					lrAYORAHqra[BhvYOgv9XRR] = num4;
					goto end_IL_0009;
				case 6:
					if (num4 == 0L)
					{
						num3 = 3;
						break;
					}
					goto default;
				case 2:
					try
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<long, long> current = enumerator.Current;
							int num5 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b == 0)
							{
								num5 = 2;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (current.Value > 0)
									{
										K7Sr5BSXl1vKnqNNxk1y(marketDepthFullEvent, shortPrice, shortSize);
										break;
									}
									goto case 1;
								case 2:
									shortPrice = P_0.GetShortPrice((double)current.Key * gflYOdDCxLo.PriceStep);
									num5 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 == 0)
									{
										num5 = 3;
									}
									continue;
								case 3:
									shortSize = P_0.GetShortSize((double)Math.Abs(current.Value) * gflYOdDCxLo.SizeStep);
									num5 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 == 0)
									{
										num5 = 0;
									}
									continue;
								case 1:
									PsLsrUSX4trqdlnuQlC0(marketDepthFullEvent, shortPrice, shortSize);
									break;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto case 4;
				case 1:
					num4 = KBE5HnSXvnKCjs3lFiaj(fSe09yYqLrWV6gXnueCG);
					num3 = 6;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e != 0)
					{
						num3 = 3;
					}
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
			num2++;
		}
	}

	static AKdfKuYOjHbBsC3lCg87()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void F6ASEaSXoAhHDKQYUw9Y()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static bool oEBO7wSXGWWqfMDWIwdN()
	{
		return Tts6BaSXnUJU8Yce33Qg == null;
	}

	internal static AKdfKuYOjHbBsC3lCg87 aaGCuMSXYhHVxcgSiL7H()
	{
		return Tts6BaSXnUJU8Yce33Qg;
	}

	internal static long KBE5HnSXvnKCjs3lFiaj(object P_0)
	{
		return ((fSe09yYqLrWV6gXnueCG)P_0).NjbYqs43VaK();
	}

	internal static object wjEtWPSXBVAd2a9qGo4Q(object P_0)
	{
		return IlvHiXGF9pA6U4gUK5bq.GElGFDDmQlk((Symbol)P_0);
	}

	internal static object b7vhoQSXaZ5TwDTNsako(object P_0)
	{
		return ((MarketDepthDiffEvent)P_0).Version;
	}

	internal static void vc8UGGSXixPG2cfx3h3G(object P_0)
	{
		((syh8dIG3xetxRkGYZ5kB)P_0).vNpG3X8YCxF();
	}

	internal static void K7Sr5BSXl1vKnqNNxk1y(object P_0, long P_1, long P_2)
	{
		((MarketDepthDiffEvent)P_0).YlHloi6rCYj(P_1, P_2);
	}

	internal static void PsLsrUSX4trqdlnuQlC0(object P_0, long P_1, long P_2)
	{
		((MarketDepthDiffEvent)P_0).AcdlolmAx8M(P_1, P_2);
	}
}
