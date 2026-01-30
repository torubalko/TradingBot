using System.Collections.Generic;

namespace TigerTrade.Chart.Data;

public interface IChartMarketDepth
{
	decimal MaxAskPrice { get; }

	decimal MinAskPrice { get; }

	decimal MaxBidPrice { get; }

	decimal MinBidPrice { get; }

	decimal MaxSize { get; }

	IReadOnlyDictionary<decimal, decimal> AskQuotes { get; }

	IReadOnlyDictionary<decimal, decimal> BidQuotes { get; }
}
