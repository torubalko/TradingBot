using System;
using System.Collections.Generic;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using k56rXOGpHcZIas56ia8y;
using lFFs11G39ohaRVknaFPC;
using LPq3llG3QX4HMCBL7b1Q;
using U0vBVyGFnRQg4TAEWduY;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public sealed class Security
{
	private double? _netChange;

	private double? _change;

	internal static Security lViqSS5uzOfJlkb6acD2;

	public string SecurityID => Symbol.ID;

	public Symbol Symbol { get; }

	public bool? IsTradingNow { get; set; }

	public long BidPrice { get; set; }

	public long BidSize { get; set; }

	public DateTime BidTime { get; set; }

	public long BidDepthT { get; set; }

	public long NumBids { get; set; }

	public long AskPrice { get; set; }

	public long AskSize { get; set; }

	public DateTime AskTime { get; set; }

	public long OfferDepthT { get; set; }

	public long NumOffers { get; set; }

	public long LastPrice { get; set; }

	public long LastSize { get; set; }

	public DateTime LastTime { get; set; }

	public Side LastSide { get; set; }

	public long LastMarketCenter { get; set; }

	public string LastMarket { get; set; }

	public string LastConditions { get; set; }

	public bool LastIsNotQualified { get; set; }

	public double HighPrice { get; set; }

	public double LowPrice { get; set; }

	public double OpenPrice { get; set; }

	public double ClosePrice { get; set; }

	public long Volume { get; set; }

	public long Trades { get; set; }

	public long Value { get; set; }

	public long OpenInt { get; set; }

	public double PriceMax { get; set; }

	public double PriceMin { get; set; }

	public double MarginBuy { get; set; }

	public double MarginSell { get; set; }

	public double Volatility { get; set; }

	public double TheoreticalPrice { get; set; }

	public double? NetChange
	{
		get
		{
			if (_netChange.HasValue)
			{
				return _netChange.Value;
			}
			double? result = null;
			if (ClosePrice > 0.0 && LastPrice > 0)
			{
				double realPrice = Symbol.GetRealPrice(LastPrice);
				result = realPrice - ClosePrice;
			}
			return result;
		}
		internal set
		{
			_netChange = value;
		}
	}

	public double? Change
	{
		get
		{
			if (_change.HasValue)
			{
				return _change.Value;
			}
			double? result = null;
			if (ClosePrice > 0.0 && LastPrice > 0)
			{
				double realPrice = Symbol.GetRealPrice(LastPrice);
				result = realPrice / ClosePrice - 1.0;
			}
			return result;
		}
		internal set
		{
			_change = value;
		}
	}

	public double? FundingRate { get; set; }

	public long? FundingNext { get; set; }

	public Security(Symbol symbol)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Symbol = symbol;
	}

	public void Apply(SecurityEvent se)
	{
		int num = 12;
		while (true)
		{
			int num2 = num;
			long openInt;
			while (true)
			{
				switch (num2)
				{
				case 12:
					BidPrice = se.BidPrice ?? BidPrice;
					num2 = 11;
					break;
				case 11:
					BidSize = se.BidSize ?? BidSize;
					num2 = 5;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					BidTime = se.BidTime ?? BidTime;
					num2 = 4;
					break;
				case 4:
					BidDepthT = se.BidDepthT ?? BidDepthT;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
					{
						num2 = 0;
					}
					break;
				default:
					AskPrice = se.AskPrice ?? AskPrice;
					AskSize = se.AskSize ?? AskSize;
					num2 = 6;
					break;
				case 6:
					AskTime = se.AskTime ?? AskTime;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					OfferDepthT = se.OfferDepthT ?? OfferDepthT;
					num2 = 2;
					break;
				case 2:
					LastPrice = se.LastPrice ?? LastPrice;
					num2 = 10;
					break;
				case 10:
					LastSize = se.LastSize ?? LastSize;
					LastTime = se.LastTime ?? LastTime;
					OpenPrice = se.OpenPrice ?? OpenPrice;
					HighPrice = se.HighPrice ?? HighPrice;
					num2 = 8;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
					{
						num2 = 6;
					}
					break;
				case 8:
					LowPrice = se.LowPrice ?? LowPrice;
					ClosePrice = se.ClosePrice ?? ClosePrice;
					Volume = se.Volume ?? Volume;
					Trades = se.Trades ?? Trades;
					num2 = 7;
					break;
				case 7:
					Value = se.Value ?? Value;
					openInt = se.OpenInt ?? OpenInt;
					goto end_IL_0012;
				case 9:
					MarginBuy = se.MarginBuy ?? MarginBuy;
					MarginSell = se.MarginSell ?? MarginSell;
					PriceMax = se.PriceMax ?? PriceMax;
					PriceMin = se.PriceMin ?? PriceMin;
					num2 = 3;
					break;
				case 3:
					Volatility = se.Volatility ?? Volatility;
					TheoreticalPrice = se.TheoreticalPrice ?? TheoreticalPrice;
					FundingRate = se.FundingRate ?? FundingRate;
					FundingNext = se.FundingNext ?? FundingNext;
					NetChange = se.NetChange ?? NetChange;
					Change = se.Change ?? Change;
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			OpenInt = openInt;
			num = 9;
		}
	}

	public void Apply(MarketDepthFullEvent marketDepth)
	{
		if (MAsj2U5zHwRePU3wo4fV(marketDepth.Bids) > 0)
		{
			BidPrice = marketDepth.BestBidPrice;
			BidSize = fUVx3Y5zfdUeY6HZjr8s(marketDepth);
			goto IL_00ec;
		}
		BidPrice = 0L;
		int num = 3;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 4:
				break;
			case 3:
				goto IL_0090;
			case 1:
				return;
			case 2:
				AskSize = 0L;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 != 0)
				{
					num = 0;
				}
				continue;
			}
			break;
		}
		goto IL_007f;
		IL_007f:
		AskPrice = marketDepth.BestAskPrice;
		AskSize = MZXoyK5z9fQFKZSDbcgH(marketDepth);
		num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_00ec:
		if (MAsj2U5zHwRePU3wo4fV(marketDepth.Asks) <= 0)
		{
			AskPrice = 0L;
			num = 2;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_007f;
		IL_0090:
		BidSize = 0L;
		goto IL_00ec;
	}

	public void Apply(TickEvent tick)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				LastSize = eXEkdS5zG9qtlmxaP2Dv(tick);
				LastTime = tick.Time;
				return;
			case 1:
				LastPrice = YBp2CK5znNudglXnHqFe(tick);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Apply(g62JgfGp2rGReTRRFt16 ticker)
	{
		BidPrice = ticker.BidPrice ?? BidPrice;
		AskPrice = ticker.AskPrice ?? AskPrice;
		LastPrice = ticker.LastPrice ?? LastPrice;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public SecurityEvent GetEvent(Symbol symbol)
	{
		return GetEvent(IlvHiXGF9pA6U4gUK5bq.W24GFlpvq8h(symbol));
	}

	public SecurityEvent GetEvent(SecurityEvent e)
	{
		e.BidPrice = BidPrice;
		e.BidSize = BidSize;
		int num = 3;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
		{
			num = 2;
		}
		while (true)
		{
			int num2;
			switch (num)
			{
			case 7:
				e.LowPrice = LowPrice;
				num = 5;
				break;
			case 10:
				e.Trades = Trades;
				e.Value = Value;
				e.OpenInt = OpenInt;
				num = 12;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 != 0)
				{
					num = 2;
				}
				break;
			case 3:
				e.BidTime = BidTime;
				e.BidDepthT = BidDepthT;
				e.AskPrice = AskPrice;
				e.AskSize = AskSize;
				e.AskTime = AskTime;
				e.OfferDepthT = OfferDepthT;
				e.LastPrice = LastPrice;
				e.LastSize = LastSize;
				e.LastTime = LastTime;
				num = 11;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 != 0)
				{
					num = 10;
				}
				break;
			case 8:
				e.NumBids = NumBids;
				e.NumOffers = NumOffers;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 != 0)
				{
					num = 0;
				}
				break;
			case 4:
				e.NetChange = NetChange;
				e.Change = Change;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
				{
					num = 1;
				}
				break;
			case 6:
				e.PriceMin = PriceMin;
				e.Volatility = Volatility;
				e.TheoreticalPrice = TheoreticalPrice;
				num = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 == 0)
				{
					num = 3;
				}
				break;
			default:
				return e;
			case 2:
				e.Volume = Volume;
				num = 10;
				break;
			case 1:
				e.FundingRate = FundingRate;
				num2 = 9;
				goto IL_0005;
			case 9:
				e.FundingNext = FundingNext;
				num = 8;
				break;
			case 5:
				e.ClosePrice = ClosePrice;
				num = 2;
				break;
			case 11:
				e.OpenPrice = OpenPrice;
				e.HighPrice = HighPrice;
				num = 7;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
				{
					num = 2;
				}
				break;
			case 12:
				{
					e.MarginBuy = MarginBuy;
					e.MarginSell = MarginSell;
					e.PriceMax = PriceMax;
					num2 = 6;
					goto IL_0005;
				}
				IL_0005:
				num = num2;
				break;
			}
		}
	}

	static Security()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		TdAWDw5zYjEWh3wSR1df();
	}

	internal static bool h3so445z0medr5wddoPy()
	{
		return lViqSS5uzOfJlkb6acD2 == null;
	}

	internal static Security l3F8kx5z2Gguqm9dY3tj()
	{
		return lViqSS5uzOfJlkb6acD2;
	}

	internal static int MAsj2U5zHwRePU3wo4fV(object P_0)
	{
		return ((IReadOnlyCollection<KeyValuePair<long, long>>)P_0).Count;
	}

	internal static long fUVx3Y5zfdUeY6HZjr8s(object P_0)
	{
		return ((MarketDepthFullEvent)P_0).BestBidSize;
	}

	internal static long MZXoyK5z9fQFKZSDbcgH(object P_0)
	{
		return ((MarketDepthFullEvent)P_0).BestAskSize;
	}

	internal static long YBp2CK5znNudglXnHqFe(object P_0)
	{
		return ((TickEvent)P_0).Price;
	}

	internal static long eXEkdS5zG9qtlmxaP2Dv(object P_0)
	{
		return ((TickEvent)P_0).Size;
	}

	internal static void TdAWDw5zYjEWh3wSR1df()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
