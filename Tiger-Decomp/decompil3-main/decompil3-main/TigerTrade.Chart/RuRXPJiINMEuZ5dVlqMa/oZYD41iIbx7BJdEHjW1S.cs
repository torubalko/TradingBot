using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Indicators.Collections;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Dx;

namespace RuRXPJiINMEuZ5dVlqMa;

[DataContract(Name = "ChaikinsVolatilityIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("ChaikinsVolatility", "ChaikinsVolatility", false, Type = typeof(oZYD41iIbx7BJdEHjW1S))]
internal sealed class oZYD41iIbx7BJdEHjW1S : IndicatorBase
{
	private int NrEiIXAgspQ;

	private IndicatorMaType mw8iIcntcoB;

	private ChartSeries q2DiIjg1R7H;

	internal static oZYD41iIbx7BJdEHjW1S taTSJrejCFfhqnroyxa9;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	public int Period
	{
		get
		{
			return NrEiIXAgspQ;
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
					num3 = YFROQjejm0RX3gYsHBVy(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (num3 == NrEiIXAgspQ)
				{
					return;
				}
				NrEiIXAgspQ = num3;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1192989954 ^ -1192956600));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-671204305 ^ -671175413));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[DataMember(Name = "MaType")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public IndicatorMaType MaType
	{
		get
		{
			return mw8iIcntcoB;
		}
		set
		{
			if (indicatorMaType != mw8iIcntcoB)
			{
				mw8iIcntcoB = indicatorMaType;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2123795572 ^ -2123762444));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "CHV")]
	[DisplayName("CHV")]
	public ChartSeries CHVSeries
	{
		get
		{
			return q2DiIjg1R7H ?? (q2DiIjg1R7H = new ChartSeries(ChartSeriesType.Line, apPYjEejhhLrKYLHJOvI(Colors.Blue)));
		}
		private set
		{
			if (!SwUvZJejwmBefidGUApB(chartSeries, q2DiIjg1R7H))
			{
				q2DiIjg1R7H = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-673683647 ^ -673660765));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> ip0iIs96jFB => base.Levels;

	public oZYD41iIbx7BJdEHjW1S()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Period = 10;
			MaType = IndicatorMaType.EMA;
			base.Levels.Add(new ChartLevel(0m, apPYjEejhhLrKYLHJOvI(Colors.Gray)));
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
			{
				num = 1;
			}
		}
	}

	protected override void Execute()
	{
		double[] data = base.Helper.ChaikinsVolatility(MaType, Period);
		gV1aclej7mHrA9e1WSqX(base.Series, new IndicatorSeriesData(data, CHVSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		CHVSeries.AllColors = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		oZYD41iIbx7BJdEHjW1S oZYD41iIbx7BJdEHjW1S2 = (oZYD41iIbx7BJdEHjW1S)P_0;
		Period = y9qZPIej8ea68Vbb2VYV(oZYD41iIbx7BJdEHjW1S2);
		MaType = oZYD41iIbx7BJdEHjW1S2.MaType;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			hJvI7LejP6C2IoBHcxL1(CHVSeries, KHo1BwejAGLhE2AdNUhW(oZYD41iIbx7BJdEHjW1S2));
			base.CopyTemplate(P_0, P_1);
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x769C7931 ^ 0x769CFEC1), base.Name, Period);
	}

	static oZYD41iIbx7BJdEHjW1S()
	{
		CAxxHNejJONAcyCQHE5Z();
		HrUUSCejFpUIw8FIxf24();
	}

	internal static int YFROQjejm0RX3gYsHBVy(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool lwbfbSejryw2VkTbHW5Y()
	{
		return taTSJrejCFfhqnroyxa9 == null;
	}

	internal static oZYD41iIbx7BJdEHjW1S weNkGsejKLtv6eR6e7ba()
	{
		return taTSJrejCFfhqnroyxa9;
	}

	internal static XColor apPYjEejhhLrKYLHJOvI(Color P_0)
	{
		return P_0;
	}

	internal static bool SwUvZJejwmBefidGUApB(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void gV1aclej7mHrA9e1WSqX(object P_0, object P_1)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1);
	}

	internal static int y9qZPIej8ea68Vbb2VYV(object P_0)
	{
		return ((oZYD41iIbx7BJdEHjW1S)P_0).Period;
	}

	internal static object KHo1BwejAGLhE2AdNUhW(object P_0)
	{
		return ((oZYD41iIbx7BJdEHjW1S)P_0).CHVSeries;
	}

	internal static void hJvI7LejP6C2IoBHcxL1(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static void CAxxHNejJONAcyCQHE5Z()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void HrUUSCejFpUIw8FIxf24()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
