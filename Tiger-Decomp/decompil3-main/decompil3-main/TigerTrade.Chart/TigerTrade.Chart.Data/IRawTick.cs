using System;

namespace TigerTrade.Chart.Data;

public interface IRawTick
{
	DateTime Time { get; }

	long Price { get; }

	long Size { get; }

	long QuoteSize { get; }

	long OpenInterest { get; }

	bool IsBuy { get; }
}
