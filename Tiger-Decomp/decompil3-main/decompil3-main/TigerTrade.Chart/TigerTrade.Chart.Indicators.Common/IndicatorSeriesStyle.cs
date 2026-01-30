using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace TigerTrade.Chart.Indicators.Common;

public sealed class IndicatorSeriesStyle
{
	public bool Visible;

	public string Name;

	public bool DisableMinMax;

	public bool DisableSelect;

	public bool DisableLabel;

	public bool DisableValue;

	public double HighPercent;

	public double LowPercent;

	public ChartSeriesType RenderType;

	public ChartSeriesDotStyle DotType;

	public ChartSeriesColorSplit ColorSplit;

	public XColor Color;

	public XColor Color2;

	public int LineWidth;

	public XDashStyle LineStyle;

	public bool StraightLine;

	private static IndicatorSeriesStyle MHnj4HeOGk3jLHYnypYx;

	public IndicatorSeriesStyle()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b != 0)
		{
			num = 1;
		}
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				return;
			case 5:
				Name = "";
				DisableMinMax = false;
				DisableSelect = false;
				num = 6;
				break;
			case 4:
				LineWidth = 1;
				LineStyle = XDashStyle.Solid;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				LowPercent = 0.0;
				RenderType = ChartSeriesType.Line;
				DotType = ChartSeriesDotStyle.Point;
				ColorSplit = ChartSeriesColorSplit.NoSplit;
				Color = Colors.Transparent;
				num2 = 3;
				goto IL_002f;
			case 6:
				DisableLabel = false;
				DisableValue = false;
				HighPercent = 1.0;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				Visible = true;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
				{
					num = 5;
				}
				break;
			case 3:
				{
					Color2 = Colors.Transparent;
					num2 = 4;
					goto IL_002f;
				}
				IL_002f:
				num = num2;
				break;
			}
		}
	}

	public void Set(ChartSeries series, string name = "")
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				Visible = series.Visible;
				num2 = 3;
				break;
			default:
				ColorSplit = series.ColorSplit;
				Color = L1Hxy7eOBnEs5sap0uZl(series);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Color2 = series.Color2;
				LineWidth = rRv4vgeOaXpWAudVDsda(series);
				LineStyle = series.Style;
				return;
			case 2:
				DisableLabel = !series.ShowMarker;
				RenderType = ewkcyHeOvsyUodJdv3Rh(series);
				DotType = series.DotStyle;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				Name = name;
				DisableMinMax = !series.Visible;
				num2 = 2;
				break;
			}
		}
	}

	public void Set(ChartRegion region)
	{
		Visible = region.Visible;
		DisableMinMax = !region.Visible;
		DisableLabel = true;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Color = MyjpV4eOi5EUYlnJbEfy(region);
				return;
			}
			DisableValue = true;
			RenderType = ChartSeriesType.Region;
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb != 0)
			{
				num = 1;
			}
		}
	}

	public void Set(ChartLine line)
	{
		Visible = HD4soPeOl85i3V6XcCbl(line);
		DisableMinMax = !line.Visible;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				LineWidth = OVp3oneO4F44TP11BV7U(line);
				LineStyle = X970V7eODj2RwrlmZF0R(line);
				return;
			}
			DisableLabel = !line.ShowMarker;
			Color = line.Color;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
			{
				num = 1;
			}
		}
	}

	public void DisableAll()
	{
		DisableLabel = true;
		DisableSelect = true;
		DisableMinMax = true;
		DisableValue = true;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static IndicatorSeriesStyle()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool OMMeIteOYh8TrIWVEtpo()
	{
		return MHnj4HeOGk3jLHYnypYx == null;
	}

	internal static IndicatorSeriesStyle m8sDPaeOotCrqpbU9XZa()
	{
		return MHnj4HeOGk3jLHYnypYx;
	}

	internal static ChartSeriesType ewkcyHeOvsyUodJdv3Rh(object P_0)
	{
		return ((ChartSeries)P_0).Type;
	}

	internal static XColor L1Hxy7eOBnEs5sap0uZl(object P_0)
	{
		return ((ChartSeries)P_0).Color;
	}

	internal static int rRv4vgeOaXpWAudVDsda(object P_0)
	{
		return ((ChartSeries)P_0).Width;
	}

	internal static XColor MyjpV4eOi5EUYlnJbEfy(object P_0)
	{
		return ((ChartRegion)P_0).Color;
	}

	internal static bool HD4soPeOl85i3V6XcCbl(object P_0)
	{
		return ((ChartLine)P_0).Visible;
	}

	internal static int OVp3oneO4F44TP11BV7U(object P_0)
	{
		return ((ChartLine)P_0).Width;
	}

	internal static XDashStyle X970V7eODj2RwrlmZF0R(object P_0)
	{
		return ((ChartLine)P_0).Style;
	}
}
