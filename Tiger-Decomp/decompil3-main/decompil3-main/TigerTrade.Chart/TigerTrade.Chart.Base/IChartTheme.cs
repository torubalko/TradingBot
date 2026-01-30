using TigerTrade.Chart.Objects.Enums;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace TigerTrade.Chart.Base;

public interface IChartTheme
{
	XColor ChartBackColor { get; }

	XBrush ChartBackBrush { get; }

	XColor ChartFontColor { get; }

	XBrush ChartFontBrush { get; }

	XColor ChartGridColor { get; }

	XColor ChartAxisColor { get; }

	XColor CandleUpBackColor { get; }

	XColor CandleUpBorderColor { get; }

	XColor CandleUpWickColor { get; }

	XColor CandleDownBackColor { get; }

	XColor CandleDownBorderColor { get; }

	XColor CandleDownWickColor { get; }

	XColor BarUpBarColor { get; }

	XColor BarDownBarColor { get; }

	XColor ClusterVolumeColor { get; }

	XColor ClusterTradesColor { get; }

	XColor ClusterDeltaPlusColor { get; }

	XColor ClusterDeltaMinusColor { get; }

	XColor ClusterBidColor { get; }

	XColor ClusterAskColor { get; }

	XColor ClusterStrongBidColor { get; }

	XColor ClusterStrongAskColor { get; }

	XColor ClusterNeutralBidAskColor { get; }

	XColor ClusterOpenIntPlusColor { get; }

	XColor ClusterOpenIntMinusColor { get; }

	XColor ClusterUpBarColor { get; }

	XColor ClusterDownBarColor { get; }

	XColor ClusterValueAreaColor { get; }

	XColor ClusterCellBorderColor { get; }

	XColor ClusterCellBorderMaxColor { get; }

	XColor ClusterBorderColor { get; }

	XColor ClusterTextColor { get; }

	XColor HistogramVolumeColor { get; }

	XColor HistogramTradesColor { get; }

	XColor HistogramDeltaPlusColor { get; }

	XColor HistogramDeltaMinusColor { get; }

	XColor HistogramBidColor { get; }

	XColor HistogramAskColor { get; }

	XColor HistogramValueAreaColor { get; }

	XColor HistogramMaximumColor { get; }

	XColor HistogramCellBorderColor { get; }

	XColor HistogramTextColor { get; }

	XColor ChartObjectLineColor { get; }

	XColor ChartObjectFillColor { get; }

	XPen ServerAlertLinePen { get; }

	XPen ServerAlertCpBorderPen { get; }

	XBrush ServerAlertCpBackBrush { get; }

	XBrush ServerAlertLineBrush { get; }

	XColor ServerAlertLineColor { get; }

	XDashStyle ServerAlertLineStyle { get; }

	int ServerAlertLineWidth { get; }

	ObjectTextAlignment ServerAlertBellAlignment { get; }

	XColor ChartCpLineColor { get; }

	XPen ChartCpLinePen { get; }

	XColor ChartCpFillColor { get; }

	XBrush ChartCpFillBrush { get; }

	XColor IndicatorBackColor1 { get; }

	XColor IndicatorBackColor2 { get; }

	XColor IndicatorAlertBackColor { get; }

	XColor PaletteColor1 { get; }

	XColor PaletteColor2 { get; }

	XColor PaletteColor3 { get; }

	XColor PaletteColor4 { get; }

	XColor PaletteColor5 { get; }

	XColor PaletteColor6 { get; }

	XColor PaletteColor7 { get; }

	XColor GetNextColor();
}
