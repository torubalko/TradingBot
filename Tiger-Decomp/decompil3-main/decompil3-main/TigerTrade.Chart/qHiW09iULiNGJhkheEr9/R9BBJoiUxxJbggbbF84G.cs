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
using TigerTrade.Dx;

namespace qHiW09iULiNGJhkheEr9;

[Indicator("MoneyFlowIndex", "MoneyFlowIndex", false, Type = typeof(R9BBJoiUxxJbggbbF84G))]
[DataContract(Name = "MoneyFlowIndexIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class R9BBJoiUxxJbggbbF84G : IndicatorBase
{
	private int Yi2iUQs5fHU;

	private ChartSeries Nf8iUd90HBA;

	internal static R9BBJoiUxxJbggbbF84G QeMO2XeQpKj6IHT6Rpp9;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Period
	{
		get
		{
			return Yi2iUQs5fHU;
		}
		set
		{
			num = DLNqUsed0PSk1ZnFjRQL(1, num);
			int num2;
			if (num == Yi2iUQs5fHU)
			{
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c != 0)
				{
					num2 = 1;
				}
			}
			else
			{
				Yi2iUQs5fHU = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1736566656 ^ -1736532170));
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa != 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 1:
				return;
			}
			OnPropertyChanged((string)Jfgbmped2jQpBmV2ALZp(0x28BBDCA ^ 0x28B2CEE));
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "MFI")]
	[DisplayName("MFI")]
	public ChartSeries MFISeries
	{
		get
		{
			return Nf8iUd90HBA ?? (Nf8iUd90HBA = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
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
					if (!object.Equals(chartSeries, Nf8iUd90HBA))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					Nf8iUd90HBA = chartSeries;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-448941864 ^ -448980620));
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> KvkiUEOBLrV => base.Levels;

	public R9BBJoiUxxJbggbbF84G()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 14;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base.Levels.Add(new ChartLevel(80m, HCls2UedfA8326S2aMdQ(VF4wCtedHhmyrrNHSvAJ())));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
				{
					num = 0;
				}
				break;
			default:
				base.Levels.Add(new ChartLevel(20m, HCls2UedfA8326S2aMdQ(Colors.Gray)));
				return;
			}
		}
	}

	protected override void Execute()
	{
		double[] data = (double[])TKZfg9ed9KypHpWEEGke(base.Helper, Period);
		HgeKA0ednsEa9pOSV8d1(base.Series, new IndicatorSeriesData(data, MFISeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		MFISeries.AllColors = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		R9BBJoiUxxJbggbbF84G r9BBJoiUxxJbggbbF84G = (R9BBJoiUxxJbggbbF84G)P_0;
		Period = cQkNVnedGXTjolDVabIp(r9BBJoiUxxJbggbbF84G);
		MFISeries.CopyTheme(r9BBJoiUxxJbggbbF84G.MFISeries);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.CopyTemplate(P_0, P_1);
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-203064540 ^ -203031340), base.Name, Period);
	}

	static R9BBJoiUxxJbggbbF84G()
	{
		cHvO2SedYM6TSpuoxYLf();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int DLNqUsed0PSk1ZnFjRQL(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object Jfgbmped2jQpBmV2ALZp(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool DJkm0WeQubaYaf7EF0Em()
	{
		return QeMO2XeQpKj6IHT6Rpp9 == null;
	}

	internal static R9BBJoiUxxJbggbbF84G Ciu4p1eQzGBpiARnpg8Y()
	{
		return QeMO2XeQpKj6IHT6Rpp9;
	}

	internal static Color VF4wCtedHhmyrrNHSvAJ()
	{
		return Colors.Gray;
	}

	internal static XColor HCls2UedfA8326S2aMdQ(Color P_0)
	{
		return P_0;
	}

	internal static object TKZfg9ed9KypHpWEEGke(object P_0, int period)
	{
		return ((IndicatorsHelper)P_0).MFI(period);
	}

	internal static void HgeKA0ednsEa9pOSV8d1(object P_0, object P_1)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1);
	}

	internal static int cQkNVnedGXTjolDVabIp(object P_0)
	{
		return ((R9BBJoiUxxJbggbbF84G)P_0).Period;
	}

	internal static void cHvO2SedYM6TSpuoxYLf()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
