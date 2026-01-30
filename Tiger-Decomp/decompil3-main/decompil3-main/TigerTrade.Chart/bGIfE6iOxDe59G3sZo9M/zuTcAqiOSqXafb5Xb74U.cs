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

namespace bGIfE6iOxDe59G3sZo9M;

[Indicator("ATR", "ATR", false, Type = typeof(zuTcAqiOSqXafb5Xb74U))]
[DataContract(Name = "ATRIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class zuTcAqiOSqXafb5Xb74U : IndicatorBase
{
	private int Y1yiOEGWYJu;

	private ChartSeries H2MiOQdgLrZ;

	private static zuTcAqiOSqXafb5Xb74U g8tclIecBcnSr9GN9RxD;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return Y1yiOEGWYJu;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-490987856 ^ -490956538));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4297C3EB ^ 0x429752CF));
					return;
				case 2:
					num3 = Math.Max(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (num3 == Y1yiOEGWYJu)
					{
						return;
					}
					Y1yiOEGWYJu = num3;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "ATR")]
	[DisplayName("ATR")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries ATRSeries
	{
		get
		{
			return H2MiOQdgLrZ ?? (H2MiOQdgLrZ = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
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
					if (GQp91seclsUYROVhA4R2(chartSeries, H2MiOQdgLrZ))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
						{
							num2 = 0;
						}
						break;
					}
					H2MiOQdgLrZ = chartSeries;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-342738082 ^ -342713022));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> uIqiOjGUnUq => base.Levels;

	public zuTcAqiOSqXafb5Xb74U()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 14;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 != 0)
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
		double[] data = base.Helper.ATR(Period);
		base.Series.Add(new IndicatorSeriesData(data, ATRSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		ATRSeries.AllColors = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 1;
		int num2 = num;
		zuTcAqiOSqXafb5Xb74U zuTcAqiOSqXafb5Xb74U2 = default(zuTcAqiOSqXafb5Xb74U);
		while (true)
		{
			switch (num2)
			{
			default:
				Period = OOu9ggec4jsWLN9v2Swu(zuTcAqiOSqXafb5Xb74U2);
				ATRSeries.CopyTheme((ChartSeries)m650CCecDy4difCKrLDi(zuTcAqiOSqXafb5Xb74U2));
				base.CopyTemplate(P_0, P_1);
				return;
			case 1:
				zuTcAqiOSqXafb5Xb74U2 = (zuTcAqiOSqXafb5Xb74U)P_0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2108526692 ^ -2108495764), base.Name, Period);
	}

	static zuTcAqiOSqXafb5Xb74U()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		mLMDaZecbjxsKnGdZhdo();
	}

	internal static bool XfJkwmecaVJieEaNbiWo()
	{
		return g8tclIecBcnSr9GN9RxD == null;
	}

	internal static zuTcAqiOSqXafb5Xb74U c6d9mJeciNuaZ8Jgelij()
	{
		return g8tclIecBcnSr9GN9RxD;
	}

	internal static bool GQp91seclsUYROVhA4R2(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static int OOu9ggec4jsWLN9v2Swu(object P_0)
	{
		return ((zuTcAqiOSqXafb5Xb74U)P_0).Period;
	}

	internal static object m650CCecDy4difCKrLDi(object P_0)
	{
		return ((zuTcAqiOSqXafb5Xb74U)P_0).ATRSeries;
	}

	internal static void mLMDaZecbjxsKnGdZhdo()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
