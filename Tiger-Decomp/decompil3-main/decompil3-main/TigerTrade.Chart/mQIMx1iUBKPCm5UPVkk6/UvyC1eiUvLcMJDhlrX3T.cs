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
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Chart.Indicators.Sources;

namespace mQIMx1iUBKPCm5UPVkk6;

[Indicator("Momentum", "Momentum", false, Type = typeof(UvyC1eiUvLcMJDhlrX3T))]
[DataContract(Name = "MomentumIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class UvyC1eiUvLcMJDhlrX3T : IndicatorBase
{
	private int oAXiU1cUD8u;

	private IndicatorSourceBase qRKiU5aa802;

	private ChartSeries it9iUSEiyqY;

	internal static UvyC1eiUvLcMJDhlrX3T Ae0tfceQhQcgh5cNoLbR;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "Period")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	public int Period
	{
		get
		{
			return oAXiU1cUD8u;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == oAXiU1cUD8u)
			{
				return;
			}
			oAXiU1cUD8u = num;
			OnPropertyChanged((string)LBk8hOeQ8MLGft076jQM(-2056710528 ^ -2056679114));
			int num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 == 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1325234765 ^ -1325263721));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	[DataMember(Name = "Source")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public IndicatorSourceBase Source
	{
		get
		{
			return qRKiU5aa802 ?? (qRKiU5aa802 = new StockSource());
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (indicatorSourceBase == qRKiU5aa802)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
						{
							num2 = 0;
						}
						break;
					}
					qRKiU5aa802 = indicatorSourceBase;
					OnPropertyChanged((string)LBk8hOeQ8MLGft076jQM(-2074141628 ^ -2074110942));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DisplayName("Momentum")]
	[DataMember(Name = "Momentum")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries MomentumSeries
	{
		get
		{
			return it9iUSEiyqY ?? (it9iUSEiyqY = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			if (!bgnHv2eQAVCxk3Yy1Kde(chartSeries, it9iUSEiyqY))
			{
				it9iUSEiyqY = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)LBk8hOeQ8MLGft076jQM(-1774602229 ^ -1774644857));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	public List<ChartLevel> i8KiUktrvpu => base.Levels;

	public UvyC1eiUvLcMJDhlrX3T()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Period = 10;
		base.Levels.Add(new ChartLevel(0m, CgSjOReQPxDgxFKcVB3Z()));
	}

	protected override void Execute()
	{
		double[] series = Source.GetSeries(base.Helper);
		if (series == null)
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			double[] data = base.Helper.Momentum(series, Period);
			base.Series.Add(new IndicatorSeriesData(data, MomentumSeries));
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		MomentumSeries.AllColors = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		UvyC1eiUvLcMJDhlrX3T uvyC1eiUvLcMJDhlrX3T = (UvyC1eiUvLcMJDhlrX3T)P_0;
		Period = uvyC1eiUvLcMJDhlrX3T.Period;
		int num;
		if (!P_1)
		{
			Source = ((IndicatorSourceBase)UUjITCeQJGhCkcIifAQP(uvyC1eiUvLcMJDhlrX3T)).CloneSource();
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0094;
		IL_0009:
		switch (num)
		{
		case 1:
			return;
		}
		goto IL_0094;
		IL_0094:
		s3efHkeQFTRls4t4h7cN(MomentumSeries, MomentumSeries);
		base.CopyTemplate(P_0, P_1);
		num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 == 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x24085900 ^ 0x2408DE90), base.Name, Source, Period);
	}

	static UvyC1eiUvLcMJDhlrX3T()
	{
		P5IRH9eQ3ZJDyCV0o5cb();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object LBk8hOeQ8MLGft076jQM(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool cGvbhmeQwjjm13HsuDcG()
	{
		return Ae0tfceQhQcgh5cNoLbR == null;
	}

	internal static UvyC1eiUvLcMJDhlrX3T h1s5v6eQ7uJv1IR4JbxQ()
	{
		return Ae0tfceQhQcgh5cNoLbR;
	}

	internal static bool bgnHv2eQAVCxk3Yy1Kde(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static Color CgSjOReQPxDgxFKcVB3Z()
	{
		return Colors.Gray;
	}

	internal static object UUjITCeQJGhCkcIifAQP(object P_0)
	{
		return ((UvyC1eiUvLcMJDhlrX3T)P_0).Source;
	}

	internal static void s3efHkeQFTRls4t4h7cN(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static void P5IRH9eQ3ZJDyCV0o5cb()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
