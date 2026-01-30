namespace TigerTrade.Chart.Data;

public interface IChartClusterMaxValues
{
	decimal MaxBid { get; }

	decimal MaxAsk { get; }

	decimal MaxVolume { get; }

	int MaxTrades { get; }

	decimal MaxDelta { get; }

	decimal MinDelta { get; }

	long MaxOpenPos { get; }

	long MinOpenPos { get; }

	decimal Poc { get; }
}
