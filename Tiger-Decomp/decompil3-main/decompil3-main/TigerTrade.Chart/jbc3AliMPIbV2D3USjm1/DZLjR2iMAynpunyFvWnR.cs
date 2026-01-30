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

namespace jbc3AliMPIbV2D3USjm1;

[DataContract(Name = "AOIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("AO", "AO", false, Type = typeof(DZLjR2iMAynpunyFvWnR))]
internal sealed class DZLjR2iMAynpunyFvWnR : IndicatorBase
{
	private int rEhiO9Zhtkh;

	private int TJ9iOnwyLcQ;

	private IndicatorMaType Il1iOGf3G5W;

	private ChartSeries YV0iOYypj1T;

	private static DZLjR2iMAynpunyFvWnR zYI9T0eXrHhHGOqY35Y3;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "ShortPeriod")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShortPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int ShortPeriod
	{
		get
		{
			return rEhiO9Zhtkh;
		}
		set
		{
			num = QdrcX7eXhgOL6DCZAN9i(1, num);
			int num2;
			if (num != rEhiO9Zhtkh)
			{
				rEhiO9Zhtkh = num;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
				{
					num2 = 0;
				}
			}
			else
			{
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 == 0)
				{
					num2 = 1;
				}
			}
			switch (num2)
			{
			case 1:
				return;
			}
			OnPropertyChanged((string)BAM9tbeXwu7Tn5ZkPA2T(-1346994499 ^ -1346962949));
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1774602229 ^ -1774638801));
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLongPeriod")]
	[DataMember(Name = "LongPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int LongPeriod
	{
		get
		{
			return TJ9iOnwyLcQ;
		}
		set
		{
			if (num != TJ9iOnwyLcQ)
			{
				TJ9iOnwyLcQ = num;
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-527080372 ^ -527047892));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x22BF43FC ^ 0x22BFD2D8));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "MaType")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	public IndicatorMaType MaType
	{
		get
		{
			return Il1iOGf3G5W;
		}
		set
		{
			if (indicatorMaType != Il1iOGf3G5W)
			{
				Il1iOGf3G5W = indicatorMaType;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6EC99CAF ^ 0x6EC91BD7));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "AO")]
	[DisplayName("AO")]
	public ChartSeries AOSeries
	{
		get
		{
			return YV0iOYypj1T ?? (YV0iOYypj1T = new ChartSeries(ChartSeriesType.Columns, Colors.Blue));
		}
		private set
		{
			if (!vTT1ePeX7j9PsWmE5PEs(chartSeries, YV0iOYypj1T))
			{
				YV0iOYypj1T = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)BAM9tbeXwu7Tn5ZkPA2T(-1841489831 ^ -1841447535));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> WWxiOfUFGKu => base.Levels;

	public DZLjR2iMAynpunyFvWnR()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				ShortPeriod = 5;
				LongPeriod = 34;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f != 0)
				{
					num = 0;
				}
				break;
			default:
				MaType = IndicatorMaType.EMA;
				base.Levels.Add(new ChartLevel(0m, uLv82EeX8M8NtuFiWqw5(Colors.Gray)));
				return;
			}
		}
	}

	protected override void Execute()
	{
		double[] data = (double[])KPZ8BCeXAnFovlMnfSoa(base.Helper, MaType, ShortPeriod, LongPeriod);
		gtOd8UeXPx8TW33u8kTa(base.Series, new IndicatorSeriesData(data, AOSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		AOSeries.AllColors = cRNH0neXJXg5L7oQi7AJ(P_0);
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		DZLjR2iMAynpunyFvWnR dZLjR2iMAynpunyFvWnR = (DZLjR2iMAynpunyFvWnR)P_0;
		ShortPeriod = dZLjR2iMAynpunyFvWnR.ShortPeriod;
		LongPeriod = dZLjR2iMAynpunyFvWnR.LongPeriod;
		MaType = LiUW29eXFAyGjYfmZiMr(dZLjR2iMAynpunyFvWnR);
		AOSeries.CopyTheme((ChartSeries)Iud5cdeX3KToGytfoe4X(dZLjR2iMAynpunyFvWnR));
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
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
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)BAM9tbeXwu7Tn5ZkPA2T(0x2C8374E4 ^ 0x2C83F374), base.Name, ShortPeriod, LongPeriod);
	}

	static DZLjR2iMAynpunyFvWnR()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		eEj6HGeXphGJSu0BKoKU();
	}

	internal static int QdrcX7eXhgOL6DCZAN9i(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object BAM9tbeXwu7Tn5ZkPA2T(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool K1puv3eXKfbyC4Yv1cRC()
	{
		return zYI9T0eXrHhHGOqY35Y3 == null;
	}

	internal static DZLjR2iMAynpunyFvWnR ARjPy6eXmjGMvuU3FBlJ()
	{
		return zYI9T0eXrHhHGOqY35Y3;
	}

	internal static bool vTT1ePeX7j9PsWmE5PEs(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static XColor uLv82EeX8M8NtuFiWqw5(Color P_0)
	{
		return P_0;
	}

	internal static object KPZ8BCeXAnFovlMnfSoa(object P_0, IndicatorMaType type, int shortN, int longN)
	{
		return ((IndicatorsHelper)P_0).AO(type, shortN, longN);
	}

	internal static void gtOd8UeXPx8TW33u8kTa(object P_0, object P_1)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1);
	}

	internal static XColor cRNH0neXJXg5L7oQi7AJ(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static IndicatorMaType LiUW29eXFAyGjYfmZiMr(object P_0)
	{
		return ((DZLjR2iMAynpunyFvWnR)P_0).MaType;
	}

	internal static object Iud5cdeX3KToGytfoe4X(object P_0)
	{
		return ((DZLjR2iMAynpunyFvWnR)P_0).AOSeries;
	}

	internal static void eEj6HGeXphGJSu0BKoKU()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
