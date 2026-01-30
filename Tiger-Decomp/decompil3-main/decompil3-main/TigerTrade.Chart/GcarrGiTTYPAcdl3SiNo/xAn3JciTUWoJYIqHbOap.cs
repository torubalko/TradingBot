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
using TigerTrade.Chart.Indicators.Collections;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Chart.Indicators.Sources;
using TigerTrade.Dx;

namespace GcarrGiTTYPAcdl3SiNo;

[DataContract(Name = "RateOfChangeIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("RateOfChange", "RateOfChange", false, Type = typeof(xAn3JciTUWoJYIqHbOap))]
internal sealed class xAn3JciTUWoJYIqHbOap : IndicatorBase
{
	private int Qc5iTmnYggZ;

	private IndicatorSourceBase LODiThx5UV6;

	private ChartSeries bHFiTw7J3fs;

	internal static xAn3JciTUWoJYIqHbOap gaypE1egGQnVfjXJbSbO;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return Qc5iTmnYggZ;
		}
		set
		{
			num = TtyxF6egvNpGkhdDj0uy(1, num);
			if (num == Qc5iTmnYggZ)
			{
				return;
			}
			Qc5iTmnYggZ = num;
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 == 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--855742383 ^ 0x33011019));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1009517961 ^ -1009554605));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Source")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	public IndicatorSourceBase Source
	{
		get
		{
			return LODiThx5UV6 ?? (LODiThx5UV6 = new StockSource());
		}
		set
		{
			if (indicatorSourceBase != LODiThx5UV6)
			{
				LODiThx5UV6 = indicatorSourceBase;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2017337494 ^ -2017372404));
			}
		}
	}

	[DisplayName("ROC")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "ROC")]
	public ChartSeries ROCSeries
	{
		get
		{
			return bHFiTw7J3fs ?? (bHFiTw7J3fs = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			if (!object.Equals(objA, bHFiTw7J3fs))
			{
				bHFiTw7J3fs = objA;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)FYViOpegBhuMJHaiDgO5(-2017337494 ^ -2017364622));
			}
		}
	}

	public xAn3JciTUWoJYIqHbOap()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 14;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.Levels.Add(new ChartLevel(0m, fid9PyegapvtqpKcQ43E(Colors.Gray)));
	}

	protected override void Execute()
	{
		double[] series = Source.GetSeries(base.Helper);
		if (series != null)
		{
			double[] data = base.Helper.ROC(series, Period);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			L0QEjIegidIHlsYj2e1Y(base.Series, new IndicatorSeriesData(data, ROCSeries));
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		mcO0Ynegl7RGd8qgNJ6c(ROCSeries, P_0.GetNextColor());
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		xAn3JciTUWoJYIqHbOap xAn3JciTUWoJYIqHbOap2 = (xAn3JciTUWoJYIqHbOap)P_0;
		Period = xAn3JciTUWoJYIqHbOap2.Period;
		int num;
		if (!P_1)
		{
			Source = xAn3JciTUWoJYIqHbOap2.Source.CloneSource();
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f != 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_001b;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 1:
			break;
		case 0:
			return;
		}
		goto IL_001b;
		IL_001b:
		dJtg9ZegDTERiH6l7fC6(ROCSeries, JbQQULeg4rjU53OQt7i6(xAn3JciTUWoJYIqHbOap2));
		base.CopyTemplate(P_0, P_1);
		num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 != 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	public override string ToString()
	{
		return string.Format((string)FYViOpegBhuMJHaiDgO5(0x6E2DFBED ^ 0x6E2D7C7D), base.Name, Source, Period);
	}

	static xAn3JciTUWoJYIqHbOap()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int TtyxF6egvNpGkhdDj0uy(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool jHUaKmegYSMMMRf3OlsB()
	{
		return gaypE1egGQnVfjXJbSbO == null;
	}

	internal static xAn3JciTUWoJYIqHbOap dXsxmcegoYu3JoJB48ty()
	{
		return gaypE1egGQnVfjXJbSbO;
	}

	internal static object FYViOpegBhuMJHaiDgO5(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static XColor fid9PyegapvtqpKcQ43E(Color P_0)
	{
		return P_0;
	}

	internal static void L0QEjIegidIHlsYj2e1Y(object P_0, object P_1)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1);
	}

	internal static void mcO0Ynegl7RGd8qgNJ6c(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static object JbQQULeg4rjU53OQt7i6(object P_0)
	{
		return ((xAn3JciTUWoJYIqHbOap)P_0).ROCSeries;
	}

	internal static void dJtg9ZegDTERiH6l7fC6(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}
}
