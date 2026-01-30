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

namespace tfuhuBiTGHCk9OwRFaft;

[Indicator("PriceChannel", "PriceChannel", true, Type = typeof(Fh4FZdiTnxvcBRirfL8s))]
[DataContract(Name = "PriceChannelIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class Fh4FZdiTnxvcBRirfL8s : IndicatorBase
{
	private int d1YiTNlBfnf;

	private ChartSeries MvmiTk35Rjc;

	private ChartSeries IjQiT1cXs20;

	private ChartSeries xcKiT5JhTpX;

	private ChartRegion gqCiTS6WLOH;

	internal static Fh4FZdiTnxvcBRirfL8s mPd8SIedUhyV3UAd0WHG;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Period
	{
		get
		{
			return d1YiTNlBfnf;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == d1YiTNlBfnf)
			{
				return;
			}
			d1YiTNlBfnf = num;
			int num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					OnPropertyChanged((string)DIKujxedZILAMojWnCJq(-1346994499 ^ -1346963189));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
					{
						num2 = 0;
					}
					break;
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-338769610 ^ -338798574));
					return;
				}
			}
		}
	}

	[DataMember(Name = "Upper")]
	[DisplayName("Upper")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries UpperSeries
	{
		get
		{
			return MvmiTk35Rjc ?? (MvmiTk35Rjc = new ChartSeries(ChartSeriesType.Line, ABrLbjedVkluvSMUwRry(Colors.Blue)));
		}
		private set
		{
			if (!ckjVNkedCaw6WlTNqvuw(chartSeries, MvmiTk35Rjc))
			{
				MvmiTk35Rjc = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)DIKujxedZILAMojWnCJq(-225822163 ^ -225797013));
			}
		}
	}

	[DisplayName("Middle")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "Middle")]
	public ChartSeries MiddleSeries
	{
		get
		{
			return IjQiT1cXs20 ?? (IjQiT1cXs20 = new ChartSeries(ChartSeriesType.Line, Colors.Red));
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
					IjQiT1cXs20 = chartSeries;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x769C7931 ^ 0x769CDF51));
					return;
				case 1:
					if (object.Equals(chartSeries, IjQiT1cXs20))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName("Lower")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "Lower")]
	public ChartSeries LowerSeries
	{
		get
		{
			return xcKiT5JhTpX ?? (xcKiT5JhTpX = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!object.Equals(objA, xcKiT5JhTpX))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					xcKiT5JhTpX = objA;
					OnPropertyChanged((string)DIKujxedZILAMojWnCJq(0x741B85CB ^ 0x741B23B7));
					return;
				}
			}
		}
	}

	[DisplayName("Area")]
	[DataMember(Name = "Area")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartRegion AreaRegion
	{
		get
		{
			return gqCiTS6WLOH ?? (gqCiTS6WLOH = new ChartRegion(Color.FromArgb(50, 0, 0, 0)));
		}
		private set
		{
			if (!ckjVNkedCaw6WlTNqvuw(chartRegion, gqCiTS6WLOH))
			{
				gqCiTS6WLOH = chartRegion;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--18459671 ^ 0x1190A81));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 != 0)
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

	public Fh4FZdiTnxvcBRirfL8s()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Period = 10;
	}

	protected override void Execute()
	{
		base.Helper.PriceChannel(Period, out var avg, out var upper, out var lower);
		IndicatorSeriesData indicatorSeriesData = new IndicatorSeriesData(upper, AreaRegion);
		wI65nnedrvExy6vZuRy5(indicatorSeriesData, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2002318893 ^ -2002285803), lower);
		IndicatorSeriesData indicatorSeriesData2 = indicatorSeriesData;
		base.Series.Add(indicatorSeriesData2, new IndicatorSeriesData(upper, UpperSeries), new IndicatorSeriesData(avg, MiddleSeries), new IndicatorSeriesData(lower, LowerSeries));
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		MiddleSeries.AllColors = P_0.GetNextColor();
		SN7fvledKqgGp6IVbG4e(UpperSeries, P_0.GetNextColor());
		LowerSeries.AllColors = UpperSeries.Color;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
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
			ICgJCwedwIhd6FXdUoPF(AreaRegion, new XColor(50, qo9SmOedhuDrbTV6f81M(VorFeMedmgv0swTcIZXF(UpperSeries))));
			base.ApplyColors(P_0);
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
			{
				num = 1;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 2;
		int num2 = num;
		Fh4FZdiTnxvcBRirfL8s fh4FZdiTnxvcBRirfL8s = default(Fh4FZdiTnxvcBRirfL8s);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Period = fh4FZdiTnxvcBRirfL8s.Period;
				JKcyfQed7HRUotV1Sx9f(MiddleSeries, fh4FZdiTnxvcBRirfL8s.MiddleSeries);
				UpperSeries.CopyTheme(fh4FZdiTnxvcBRirfL8s.UpperSeries);
				LowerSeries.CopyTheme((ChartSeries)Bw78Jded8f5MeAqXPK0L(fh4FZdiTnxvcBRirfL8s));
				num2 = 3;
				break;
			case 2:
				fh4FZdiTnxvcBRirfL8s = (Fh4FZdiTnxvcBRirfL8s)P_0;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				base.CopyTemplate(P_0, P_1);
				return;
			case 3:
				GNVexTedPA0kibvocq8l(AreaRegion, xpyKLxedA8CxQWAIGRkq(fh4FZdiTnxvcBRirfL8s));
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return (string)JSdAsZedJBitZoUVAtiX(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-176525661 ^ -176494253), base.Name, Period);
	}

	static Fh4FZdiTnxvcBRirfL8s()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		rnY6DAedFnK5WERuy49c();
	}

	internal static object DIKujxedZILAMojWnCJq(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool K6QLduedT2ZN3PHU42r8()
	{
		return mPd8SIedUhyV3UAd0WHG == null;
	}

	internal static Fh4FZdiTnxvcBRirfL8s gysgk7edyWZa2vZWF4fS()
	{
		return mPd8SIedUhyV3UAd0WHG;
	}

	internal static XColor ABrLbjedVkluvSMUwRry(Color P_0)
	{
		return P_0;
	}

	internal static bool ckjVNkedCaw6WlTNqvuw(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void wI65nnedrvExy6vZuRy5(object P_0, object P_1, object P_2)
	{
		((IndicatorSeriesData)P_0)[(string)P_1] = (double[])P_2;
	}

	internal static void SN7fvledKqgGp6IVbG4e(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static XColor VorFeMedmgv0swTcIZXF(object P_0)
	{
		return ((ChartSeries)P_0).Color;
	}

	internal static Color qo9SmOedhuDrbTV6f81M(XColor P_0)
	{
		return P_0;
	}

	internal static void ICgJCwedwIhd6FXdUoPF(object P_0, XColor value)
	{
		((ChartRegion)P_0).Color = value;
	}

	internal static void JKcyfQed7HRUotV1Sx9f(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static object Bw78Jded8f5MeAqXPK0L(object P_0)
	{
		return ((Fh4FZdiTnxvcBRirfL8s)P_0).LowerSeries;
	}

	internal static object xpyKLxedA8CxQWAIGRkq(object P_0)
	{
		return ((Fh4FZdiTnxvcBRirfL8s)P_0).AreaRegion;
	}

	internal static void GNVexTedPA0kibvocq8l(object P_0, object P_1)
	{
		((ChartRegion)P_0).CopyTheme((ChartRegion)P_1);
	}

	internal static object JSdAsZedJBitZoUVAtiX(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void rnY6DAedFnK5WERuy49c()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
