using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Dx;

namespace sMuIB0iWLi0O62MFuuCQ;

[DataContract(Name = "FractalsIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("Fractals", "Fractals", true, Type = typeof(BubEgZiWxy5rWNssbVYC))]
internal sealed class BubEgZiWxy5rWNssbVYC : IndicatorBase
{
	private int DVXiWQuT7cU;

	private ChartSeries v4ZiWdiTpVn;

	private ChartSeries BiHiWgJTDlg;

	internal static BubEgZiWxy5rWNssbVYC MqK36beEWPb7Qbykw2yQ;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	public int Period
	{
		get
		{
			return DVXiWQuT7cU;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					num3 = B3pIKMeETlgIoi6Sriii(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (num3 == DVXiWQuT7cU)
				{
					return;
				}
				DVXiWQuT7cU = num3;
				OnPropertyChanged((string)WN44ZveEy9a2jwU42XB4(-520155535 ^ -520123961));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x3E0426F0 ^ 0x3E04B7D4));
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[DataMember(Name = "Up")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("Up")]
	public ChartSeries UpSeries
	{
		get
		{
			return v4ZiWdiTpVn ?? (v4ZiWdiTpVn = new ChartSeries(ChartSeriesType.Points, lY7YJqeEZbHbOH7nglZ9()));
		}
		private set
		{
			if (!object.Equals(objA, v4ZiWdiTpVn))
			{
				v4ZiWdiTpVn = objA;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-57768881 ^ -57791381));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	[DisplayName("Down")]
	[DataMember(Name = "Down")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries DownSeries
	{
		get
		{
			return BiHiWgJTDlg ?? (BiHiWgJTDlg = new ChartSeries(ChartSeriesType.Points, W6JqKMeECvoWijXBODIX(hOOobueEVksEIoo7q0OE())));
		}
		private set
		{
			if (!g5uE5eeErBmaUmXqdFKG(chartSeries, BiHiWgJTDlg))
			{
				BiHiWgJTDlg = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--134855371 ^ 0x80912F3));
			}
		}
	}

	public BubEgZiWxy5rWNssbVYC()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 5;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void Execute()
	{
		base.Helper.Fractal(Period, out var up, out var down);
		base.Series.Add(new IndicatorSeriesData(up, UpSeries), new IndicatorSeriesData(down, DownSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		UpSeries.AllColors = PxH6pLeEKhB8xKSb1696(P_0);
		QWonxaeEmlbR4X5cUBk6(DownSeries, PxH6pLeEKhB8xKSb1696(P_0));
		base.ApplyColors(P_0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		BubEgZiWxy5rWNssbVYC bubEgZiWxy5rWNssbVYC = (BubEgZiWxy5rWNssbVYC)P_0;
		Period = bubEgZiWxy5rWNssbVYC.Period;
		UpSeries.CopyTheme(bubEgZiWxy5rWNssbVYC.UpSeries);
		DownSeries.CopyTheme(bubEgZiWxy5rWNssbVYC.DownSeries);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				base.CopyTemplate(P_0, P_1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)WN44ZveEy9a2jwU42XB4(-624753169 ^ -624721377), base.Name, Period);
	}

	static BubEgZiWxy5rWNssbVYC()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		desvIqeEhe8LqhycQRrR();
	}

	internal static int B3pIKMeETlgIoi6Sriii(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object WN44ZveEy9a2jwU42XB4(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool N6i3L0eEtJr62tFxgrdB()
	{
		return MqK36beEWPb7Qbykw2yQ == null;
	}

	internal static BubEgZiWxy5rWNssbVYC AXHo2FeEUbdaiLdQQVyT()
	{
		return MqK36beEWPb7Qbykw2yQ;
	}

	internal static Color lY7YJqeEZbHbOH7nglZ9()
	{
		return Colors.Green;
	}

	internal static Color hOOobueEVksEIoo7q0OE()
	{
		return Colors.Red;
	}

	internal static XColor W6JqKMeECvoWijXBODIX(Color P_0)
	{
		return P_0;
	}

	internal static bool g5uE5eeErBmaUmXqdFKG(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static XColor PxH6pLeEKhB8xKSb1696(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static void QWonxaeEmlbR4X5cUBk6(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static void desvIqeEhe8LqhycQRrR()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
