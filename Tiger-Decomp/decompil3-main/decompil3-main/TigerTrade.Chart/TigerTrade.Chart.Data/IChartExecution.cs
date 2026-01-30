using System;

namespace TigerTrade.Chart.Data;

public interface IChartExecution
{
	DateTime Time { get; }

	double Price { get; }

	long Quantity { get; }

	bool IsBuy { get; }
}
