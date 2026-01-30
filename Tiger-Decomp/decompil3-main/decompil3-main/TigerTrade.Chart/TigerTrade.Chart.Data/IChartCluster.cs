using System;
using System.Collections.Generic;

namespace TigerTrade.Chart.Data;

public interface IChartCluster
{
	DateTime Time { get; }

	DateTime OpenTime { get; }

	DateTime CloseTime { get; }

	decimal Open { get; }

	decimal High { get; }

	decimal Low { get; }

	decimal Close { get; }

	decimal Bid { get; }

	decimal Ask { get; }

	decimal Volume { get; }

	decimal Delta { get; }

	int BidTrades { get; }

	int AskTrades { get; }

	int Trades { get; }

	long OpenPos { get; }

	long OpenPosHigh { get; }

	long OpenPosLow { get; }

	long OpenPosBidChg { get; }

	long OpenPosAskChg { get; }

	long OpenPosChg { get; }

	decimal DeltaHigh { get; }

	decimal DeltaLow { get; }

	bool IsUp { get; }

	IChartClusterMaxValues MaxValues { get; }

	List<IChartClusterItem> Items { get; }

	IChartClusterItem GetItem(decimal price);
}
