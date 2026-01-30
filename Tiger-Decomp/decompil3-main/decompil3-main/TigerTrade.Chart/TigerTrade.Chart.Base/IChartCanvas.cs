using System;
using System.Windows;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Base;

public interface IChartCanvas
{
	IChartTheme Theme { get; }

	XFont ChartFont { get; }

	XFont ChartFontBold { get; }

	Rect Rect { get; }

	ChartStockType StockType { get; }

	bool IsStock { get; }

	double ColumnPercent { get; }

	double ColumnWidth { get; }

	double StepHeight { get; }

	double MaxY { get; }

	double MinY { get; }

	int Start { get; }

	int Count { get; }

	int Stop { get; }

	int AfterBars { get; }

	double GetX(int i);

	double GetXX(int i);

	double GetXScreen(double x);

	int GetIndex(int i);

	double GetY(double d);

	double GetValue(double y);

	Point GetValueFromPos(double x, double y);

	Point GetValueFromPos(double x, double y, bool snapToGrid);

	DateTime IndexToDate(int i);

	int DateToIndex(DateTime dt, int dir);

	int DateToIndex(double dt, int dir);

	DateTime ConvertTimeFromLocal(DateTime dt);

	DateTime ConvertTimeToLocal(DateTime dt);

	string FormatValue(double d);

	string FormatTime(DateTime dt, string format);
}
