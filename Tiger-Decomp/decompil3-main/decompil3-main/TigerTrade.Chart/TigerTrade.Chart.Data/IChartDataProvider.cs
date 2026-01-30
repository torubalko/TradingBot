using System.Collections.Generic;
using TigerTrade.Chart.Base;

namespace TigerTrade.Chart.Data;

public interface IChartDataProvider
{
	IChartPeriod Period { get; }

	IChartSymbol Symbol { get; }

	double[] this[string name] { get; }

	IList<double> Dates { get; }

	double Step { get; }

	int Scale { get; }

	int Count { get; }

	IChartCluster GetCluster(int i);

	IRawCluster GetRawCluster(int i);

	List<IChartTick> GetTicks();

	List<IRawTick> GetRawTicks();

	IChartSecurity GetSecurity();

	IRawSecurity GetRawSecurity();

	IChartMarketDepth GetMarketDepth();

	IRawMarketDepth GetRawMarketDepth();

	List<IChartExecution> GetExecutions();

	List<IChartDeal> GetDeals();
}
