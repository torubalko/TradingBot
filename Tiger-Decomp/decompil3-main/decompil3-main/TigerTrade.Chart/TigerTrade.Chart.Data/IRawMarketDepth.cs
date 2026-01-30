using System.Collections.Generic;

namespace TigerTrade.Chart.Data;

public interface IRawMarketDepth
{
	long MaxAskPrice { get; }

	long MinAskPrice { get; }

	long MaxBidPrice { get; }

	long MinBidPrice { get; }

	long MaxSize { get; }

	long MaxSizeInQuote { get; }

	IReadOnlyDictionary<long, (long B, long Q)> AskQuotes { get; }

	IReadOnlyDictionary<long, (long B, long Q)> BidQuotes { get; }
}
