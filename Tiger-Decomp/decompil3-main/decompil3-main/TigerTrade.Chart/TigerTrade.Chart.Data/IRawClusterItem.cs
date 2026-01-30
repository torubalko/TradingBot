namespace TigerTrade.Chart.Data;

public interface IRawClusterItem
{
	long Price { get; }

	long Bid { get; }

	long Ask { get; }

	long Volume { get; }

	long Delta { get; }

	long BidQuote { get; }

	long AskQuote { get; }

	long VolumeQuote { get; }

	long DeltaQuote { get; }

	int BidTrades { get; }

	int AskTrades { get; }

	int Trades { get; }

	long OpenPosBid { get; }

	long OpenPosAsk { get; }

	long OpenPos { get; }
}
