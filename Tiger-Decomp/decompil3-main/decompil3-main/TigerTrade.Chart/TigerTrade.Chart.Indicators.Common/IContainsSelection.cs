using TigerTrade.Dx;

namespace TigerTrade.Chart.Indicators.Common;

public interface IContainsSelection
{
	XBrush GetSelection(int index, long price, int type);
}
