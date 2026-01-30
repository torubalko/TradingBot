using System;
using System.ComponentModel;
using System.Globalization;
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

namespace AKbnlIiUFVwvZrYPh69r;

[Indicator("ParabolicSAR", "ParabolicSAR", true, Type = typeof(PeDDR0iUJtlWsqvY44AD))]
[DataContract(Name = "ParabolicSARIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class PeDDR0iUJtlWsqvY44AD : IndicatorBase
{
	private decimal S1TiTHT2w2R;

	private decimal tdEiTfkld7r;

	private ChartSeries gZUiT9G7LRK;

	private static PeDDR0iUJtlWsqvY44AD UVTVjFedjTQPOQ527ecO;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaxStep")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Max")]
	public decimal Max
	{
		get
		{
			return S1TiTHT2w2R;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = Math.Max(0m, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					OnPropertyChanged((string)eXIF5wedgHitqOy87ixG(0x78D396D8 ^ 0x78D31A7A));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-527080372 ^ -527043224));
					return;
				}
				if (xX2FLoeddUBODRExiFih(num3, S1TiTHT2w2R))
				{
					return;
				}
				S1TiTHT2w2R = num3;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[DataMember(Name = "Step")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsStep")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public decimal Step
	{
		get
		{
			return tdEiTfkld7r;
		}
		set
		{
			num = Math.Max(0m, num);
			if (!(num == tdEiTfkld7r))
			{
				tdEiTfkld7r = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2056710528 ^ -2056676820));
				OnPropertyChanged((string)eXIF5wedgHitqOy87ixG(--146713930 ^ 0x8BE3C6E));
				int num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf == 0)
				{
					num2 = 1;
				}
				switch (num2)
				{
				case 0:
					break;
				case 1:
					break;
				}
			}
		}
	}

	[DataMember(Name = "SAR")]
	[DisplayName("SAR")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries SARSeries
	{
		get
		{
			return gZUiT9G7LRK ?? (gZUiT9G7LRK = new ChartSeries(ChartSeriesType.Points, Colors.Blue));
		}
		private set
		{
			if (!epr08gedR1YmWNscvK4i(chartSeries, gZUiT9G7LRK))
			{
				gZUiT9G7LRK = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x16AD7E76 ^ 0x16ADD79A));
			}
		}
	}

	public PeDDR0iUJtlWsqvY44AD()
	{
		zwsLbJed6rQdaBWJJh1t();
		base._002Ector();
		Max = 0.2m;
		Step = 0.02m;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
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
		double[] data = base.Helper.SAR((double)Step, (double)Max);
		base.Series.Add(new IndicatorSeriesData(data, SARSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		SARSeries.AllColors = xljUA9edMi1H3fjWfhLj(P_0);
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		PeDDR0iUJtlWsqvY44AD peDDR0iUJtlWsqvY44AD = (PeDDR0iUJtlWsqvY44AD)P_0;
		Max = peDDR0iUJtlWsqvY44AD.Max;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Step = peDDR0iUJtlWsqvY44AD.Step;
				Tx0jKpedqmik6WPPbJul(SARSeries, pAqYuMedOsorL6tqf4RS(peDDR0iUJtlWsqvY44AD));
				base.CopyTemplate(P_0, P_1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override string ToString()
	{
		return (string)yqAQ8aedW5TH57ffa60p(new string[5]
		{
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-123775059 ^ -123741319),
			Step.ToString((IFormatProvider)V0wJpPedI6xYfbx6HKMr()),
			(string)eXIF5wedgHitqOy87ixG(-1311293279 ^ -1311257535),
			Max.ToString((IFormatProvider)V0wJpPedI6xYfbx6HKMr()),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-991861155 ^ -991879735)
		});
	}

	static PeDDR0iUJtlWsqvY44AD()
	{
		xSVGjhedtUMGciP0UGXq();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool xX2FLoeddUBODRExiFih(decimal P_0, decimal P_1)
	{
		return P_0 == P_1;
	}

	internal static object eXIF5wedgHitqOy87ixG(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool j9qPskedEgYe9RVUXjN5()
	{
		return UVTVjFedjTQPOQ527ecO == null;
	}

	internal static PeDDR0iUJtlWsqvY44AD L06Xp3edQlX04xSqUh3b()
	{
		return UVTVjFedjTQPOQ527ecO;
	}

	internal static bool epr08gedR1YmWNscvK4i(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void zwsLbJed6rQdaBWJJh1t()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static XColor xljUA9edMi1H3fjWfhLj(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static object pAqYuMedOsorL6tqf4RS(object P_0)
	{
		return ((PeDDR0iUJtlWsqvY44AD)P_0).SARSeries;
	}

	internal static void Tx0jKpedqmik6WPPbJul(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static object V0wJpPedI6xYfbx6HKMr()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static object yqAQ8aedW5TH57ffa60p(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static void xSVGjhedtUMGciP0UGXq()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
