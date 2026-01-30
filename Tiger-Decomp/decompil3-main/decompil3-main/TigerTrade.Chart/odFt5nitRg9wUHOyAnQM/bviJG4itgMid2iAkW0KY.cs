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
using TigerTrade.Chart.Indicators.Sources;
using TigerTrade.Dx;

namespace odFt5nitRg9wUHOyAnQM;

[Indicator("LinearRegression", "LinearRegression", true, Type = typeof(bviJG4itgMid2iAkW0KY))]
[DataContract(Name = "LinearRegressionIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class bviJG4itgMid2iAkW0KY : IndicatorBase
{
	private int tYDitTINDUq;

	private int Ai3itydHkWn;

	private IndicatorSourceBase pG6itZ5AJ6f;

	private ChartSeries yA2itVA7LGE;

	private static bviJG4itgMid2iAkW0KY C2KmAxeQX7PX4oUdBbru;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "Period")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	public int Period
	{
		get
		{
			return tYDitTINDUq;
		}
		set
		{
			num = CLuQEYeQEhNxsQqG9t0G(1, num);
			int num2;
			if (num == tYDitTINDUq)
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a == 0)
				{
					num2 = 1;
				}
			}
			else
			{
				tYDitTINDUq = num;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed == 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 1:
				return;
			}
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1461949456 ^ -1461916602));
			OnPropertyChanged((string)cZ5XUweQQDOafffYnqSO(-338769610 ^ -338798574));
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShift")]
	[DataMember(Name = "Shift")]
	public int Shift
	{
		get
		{
			return Ai3itydHkWn;
		}
		set
		{
			num = Math.Max(0, num);
			if (num == Ai3itydHkWn)
			{
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				Ai3itydHkWn = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-45476899 ^ -45434175));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	[DataMember(Name = "Source")]
	public IndicatorSourceBase Source
	{
		get
		{
			return pG6itZ5AJ6f ?? (pG6itZ5AJ6f = new StockSource());
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
				case 0:
					return;
				case 1:
					if (indicatorSourceBase != pG6itZ5AJ6f)
					{
						pG6itZ5AJ6f = indicatorSourceBase;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1583344314 ^ -1583309536));
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-45476899 ^ -45448455));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName("LinReg")]
	[DataMember(Name = "LinReg")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries LinRegSeries
	{
		get
		{
			return yA2itVA7LGE ?? (yA2itVA7LGE = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			if (!object.Equals(objA, yA2itVA7LGE))
			{
				yA2itVA7LGE = objA;
				OnPropertyChanged((string)cZ5XUweQQDOafffYnqSO(-1774602229 ^ -1774644959));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 != 0)
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

	public bviJG4itgMid2iAkW0KY()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Period = 14;
		Shift = 0;
	}

	protected override void Execute()
	{
		int num = 2;
		int num2 = num;
		double[] series = default(double[]);
		double[] array = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				series = Source.GetSeries(base.Helper);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				base.Series.Add(new IndicatorSeriesData(array, LinRegSeries));
				return;
			case 1:
				if (series == null)
				{
					return;
				}
				array = (double[])taTpBNeQddxxE3gHpmcS(base.Helper, series, Period);
				if (Shift > 0)
				{
					array = (double[])RSOn1teQgdm6UTlHDgwh(base.Helper, array, Shift);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		LinRegSeries.AllColors = Bj2GVCeQROjvkEjnN0r3(P_0);
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		bviJG4itgMid2iAkW0KY bviJG4itgMid2iAkW0KY2 = (bviJG4itgMid2iAkW0KY)P_0;
		Period = bviJG4itgMid2iAkW0KY2.Period;
		if (!P_1)
		{
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					Source = (IndicatorSourceBase)nfbdQjeQMpN6vN6exvnt(kqrPfGeQ6JrwQpobwC97(bviJG4itgMid2iAkW0KY2));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa != 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
		}
		LinRegSeries.CopyTheme(bviJG4itgMid2iAkW0KY2.LinRegSeries);
		base.CopyTemplate(P_0, P_1);
	}

	public override string ToString()
	{
		return (string)dylICaeQOfCURw7tcRLO(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-842040449 ^ -842010383), Source, Period);
	}

	static bviJG4itgMid2iAkW0KY()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int CLuQEYeQEhNxsQqG9t0G(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object cZ5XUweQQDOafffYnqSO(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool X9PTAxeQcOVbPcOkG9BE()
	{
		return C2KmAxeQX7PX4oUdBbru == null;
	}

	internal static bviJG4itgMid2iAkW0KY SG2AfqeQjnIvVFI7j1h8()
	{
		return C2KmAxeQX7PX4oUdBbru;
	}

	internal static object taTpBNeQddxxE3gHpmcS(object P_0, object P_1, int period)
	{
		return ((IndicatorsHelper)P_0).LinReg((double[])P_1, period);
	}

	internal static object RSOn1teQgdm6UTlHDgwh(object P_0, object P_1, int shift)
	{
		return ((IndicatorsHelper)P_0).ShiftData((double[])P_1, shift);
	}

	internal static XColor Bj2GVCeQROjvkEjnN0r3(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static object kqrPfGeQ6JrwQpobwC97(object P_0)
	{
		return ((bviJG4itgMid2iAkW0KY)P_0).Source;
	}

	internal static object nfbdQjeQMpN6vN6exvnt(object P_0)
	{
		return ((IndicatorSourceBase)P_0).CloneSource();
	}

	internal static object dylICaeQOfCURw7tcRLO(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
