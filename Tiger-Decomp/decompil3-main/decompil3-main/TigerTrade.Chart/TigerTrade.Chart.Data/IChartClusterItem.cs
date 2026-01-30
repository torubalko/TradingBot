namespace TigerTrade.Chart.Data;

public interface IChartClusterItem
{
	decimal Price { get; }

	decimal Bid { get; }

	decimal Ask { get; }

	decimal Volume { get; }

	decimal Delta { get; }

	int BidTrades { get; }

	int AskTrades { get; }

	int Trades { get; }

	long OpenPosBid { get; }

	long OpenPosAsk { get; }

	long OpenPos { get; }
}
