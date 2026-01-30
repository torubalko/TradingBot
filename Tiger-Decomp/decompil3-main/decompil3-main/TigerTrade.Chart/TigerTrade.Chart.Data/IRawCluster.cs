using System;
using System.Collections.Generic;

namespace TigerTrade.Chart.Data;

public interface IRawCluster
{
	DateTime Time { get; }

	DateTime OpenTime { get; }

	DateTime CloseTime { get; }

	long Open { get; }

	long High { get; }

	long Low { get; }

	long Close { get; }

	long Bid { get; }

	long Ask { get; }

	long Volume { get; }

	long Delta { get; }

	int BidTrades { get; }

	int AskTrades { get; }

	int Trades { get; }

	long OpenPos { get; }

	long OpenPosHigh { get; }

	long OpenPosLow { get; }

	long OpenPosBidChg { get; }

	long OpenPosAskChg { get; }

	long OpenPosChg { get; }

	long DeltaHigh { get; }

	long DeltaLow { get; }

	long BidQuote { get; }

	long AskQuote { get; }

	long VolumeQuote { get; }

	long DeltaQuote { get; }

	bool IsUp { get; }

	IRawClusterMaxValues MaxValues { get; }

	IReadOnlyCollection<IRawClusterItem> Items { get; }

	SortedSet<long> Prices { get; }

	IRawClusterItem GetItem(long price);

	IRawClusterValueArea GetValueArea(int valueArea);
}
