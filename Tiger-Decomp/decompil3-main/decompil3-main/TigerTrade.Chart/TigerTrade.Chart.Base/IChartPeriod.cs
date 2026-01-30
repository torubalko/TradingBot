using System;
using TigerTrade.Chart.Base.Enums;

namespace TigerTrade.Chart.Base;

public interface IChartPeriod
{
	ChartPeriodType Type { get; }

	int Interval { get; }

	int GetSequence(ChartPeriodType type, int interval, DateTime dateTime, double timeOffset);

	int GetSequence(ChartPeriodType type, int interval, double dateTime, double timeOffset);
}
