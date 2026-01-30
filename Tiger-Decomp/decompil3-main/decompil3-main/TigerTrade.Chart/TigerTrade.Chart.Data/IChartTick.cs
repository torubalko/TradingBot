using System;

namespace TigerTrade.Chart.Data;

public interface IChartTick
{
	DateTime Time { get; }

	decimal Price { get; }

	decimal Size { get; }

	long OpenInterest { get; }

	bool IsBuy { get; }
}
