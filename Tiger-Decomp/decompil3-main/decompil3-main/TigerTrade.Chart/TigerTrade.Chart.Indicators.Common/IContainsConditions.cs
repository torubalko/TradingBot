using TigerTrade.Dx;

namespace TigerTrade.Chart.Indicators.Common;

public interface IContainsConditions
{
	XBrush GetBrush(int index, bool isUp);
}
