using System;

namespace TigerTrade.Chart.Data;

public interface IRawSecurity
{
	long BidPrice { get; }

	long BidSize { get; }

	DateTime BidTime { get; }

	long BidDepthT { get; }

	long NumBids { get; }

	long AskPrice { get; }

	long AskSize { get; }

	DateTime AskTime { get; }

	long OfferDepthT { get; }

	long NumOffers { get; }

	long LastPrice { get; }

	long LastSize { get; }

	DateTime LastTime { get; }

	double HighPrice { get; }

	double LowPrice { get; }

	double OpenPrice { get; }

	double ClosePrice { get; }

	long Volume { get; }

	long Trades { get; }

	long OpenInt { get; }

	double PriceMax { get; }

	double PriceMin { get; }

	double MarginBuy { get; }

	double MarginSell { get; }

	double? NetChange { get; }

	double? Change { get; }
}
