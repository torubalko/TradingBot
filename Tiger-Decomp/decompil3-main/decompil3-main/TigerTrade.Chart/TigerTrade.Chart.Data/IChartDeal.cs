using System;

namespace TigerTrade.Chart.Data;

public interface IChartDeal
{
	DateTime OpenTime { get; }

	double OpenPrice { get; }

	DateTime CloseTime { get; }

	double ClosePrice { get; }

	bool IsBuy { get; }

	double Quantity { get; }

	double Points { get; }

	double Profit { get; }
}
