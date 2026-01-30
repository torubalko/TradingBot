using System;

namespace TigerTrade.Chart.Data;

public interface IChartSecurity
{
	decimal BidPrice { get; }

	decimal BidSize { get; }

	DateTime BidTime { get; }

	long BidDepthT { get; }

	long NumBids { get; }

	decimal AskPrice { get; }

	decimal AskSize { get; }

	DateTime AskTime { get; }

	long OfferDepthT { get; }

	long NumOffers { get; }

	decimal LastPrice { get; }

	decimal LastSize { get; }

	DateTime LastTime { get; }

	decimal HighPrice { get; }

	decimal LowPrice { get; }

	decimal OpenPrice { get; }

	decimal ClosePrice { get; }

	long Volume { get; }

	long Trades { get; }

	long OpenInt { get; }

	decimal PriceMax { get; }

	decimal PriceMin { get; }

	decimal MarginBuy { get; }

	decimal MarginSell { get; }

	decimal? NetChange { get; }

	decimal? Change { get; }
}
