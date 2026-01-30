using System;

namespace TigerTrade.Chart.Base;

public interface IChartSymbol
{
	string Code { get; }

	string Name { get; }

	string Exchange { get; }

	int Decimals { get; }

	decimal StepPrice { get; }

	bool IsDenomination { get; }

	double GetPrice(long rawPrice);

	decimal GetSize(long rawSize);

	long GetRawQuoteSize(long price, long size, int scale = 1);

	long CorrectSizeFilter(double filter);

	long? CorrectSizeFilter(double? filter);

	string FormatPrice(decimal price, bool shortDecimals = false);

	string FormatRawPrice(long price, bool shortDecimals = false);

	string FormatSize(decimal size, int round = 2);

	string FormatSize(decimal size, int round, bool minimize);

	string FormatSizeShort(decimal size);

	string FormatSizeFull(decimal size);

	string FormatRawSize(long size, int round = 2);

	string FormatRawSize(long size, int round, bool minimize);

	string FormatRawQuoteSize(long size, int round, bool minimize);

	string FormatRawSizeShort(long size);

	string FormatRawSizeFull(long size);

	string FormatTrades(long trades);

	string FormatTrades(long trades, int round, bool minimize);

	string FormatTime(DateTime dt, string format);

	DateTime ConvertTimeToLocal(DateTime dt);

	DateTime ConvertTimeFromLocal(DateTime dt);

	double CalculateVolumeToFilter(double volume);

	double CalculateVolumeInQuoteToFilter(double volumeInQuote);
}
