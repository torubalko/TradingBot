namespace TigerTrade.Chart.Data;

public interface IRawClusterMaxValues
{
	long MaxBid { get; }

	long MaxAsk { get; }

	long MaxVolume { get; }

	int MaxTrades { get; }

	long MaxDelta { get; }

	long MinDelta { get; }

	long MaxOpenPos { get; }

	long MinOpenPos { get; }

	long Poc { get; }

	long MaxBidQuote { get; }

	long MaxAskQuote { get; }

	long MaxVolumeQuote { get; }

	long MaxDeltaQuote { get; }

	long MinDeltaQuote { get; }
}
