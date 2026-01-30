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
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.Sources;
using TigerTrade.Dx;

namespace s8EyykiOTcbYQYoC6ul0;

[DataContract(Name = "BollingerBandsIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("BollingerBands", "BollingerBands", true, Type = typeof(W6T6CJiOUetLhLYpn8Al))]
internal sealed class W6T6CJiOUetLhLYpn8Al : IndicatorBase
{
	private int GV8iOpPeiy5;

	private decimal tvMiOuU2dMP;

	private IndicatorMaType RWsiOzUIB8H;

	private IndicatorSourceBase w3Oiq0VR8RS;

	private ChartSeries ORriq2c0IXD;

	private ChartSeries mb2iqHUxnem;

	private ChartSeries IHdiqfMtPoc;

	private ChartRegion WuLiq9F6SvS;

	internal static W6T6CJiOUetLhLYpn8Al JEwT2MeccoRlbVvmGd9C;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Period
	{
		get
		{
			return GV8iOpPeiy5;
		}
		set
		{
			num = Math.Max(1, num);
			int num2;
			if (num != GV8iOpPeiy5)
			{
				GV8iOpPeiy5 = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x735715F1 ^ 0x73579247));
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
				{
					num2 = 0;
				}
			}
			else
			{
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 1:
				return;
			}
			OnPropertyChanged((string)WtZdnPecQCWjE3O0a8IE(--871424829 ^ 0x33F07219));
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsStdDev")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "StdDev")]
	public decimal StdDev
	{
		get
		{
			return tvMiOuU2dMP;
		}
		set
		{
			num = Math.Max(num, 0m);
			if (yDFOR3ecdpwKjRxQ4Fef(num, tvMiOuU2dMP))
			{
				return;
			}
			tvMiOuU2dMP = num;
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1461949456 ^ -1461912876));
					return;
				case 1:
					OnPropertyChanged((string)WtZdnPecQCWjE3O0a8IE(-962524685 ^ -962494043));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Type")]
	public IndicatorMaType MaType
	{
		get
		{
			return RWsiOzUIB8H;
		}
		set
		{
			if (indicatorMaType != RWsiOzUIB8H)
			{
				RWsiOzUIB8H = indicatorMaType;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)WtZdnPecQCWjE3O0a8IE(0x1487846E ^ 0x14870316));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Source")]
	public IndicatorSourceBase Source
	{
		get
		{
			return w3Oiq0VR8RS ?? (w3Oiq0VR8RS = new StockSource());
		}
		set
		{
			if (indicatorSourceBase != w3Oiq0VR8RS)
			{
				w3Oiq0VR8RS = indicatorSourceBase;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x50C1C840 ^ 0x50C14026));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1878953018 ^ -1878924574));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
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

	[DisplayName("Upper")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "Upper")]
	public ChartSeries UpperSeries
	{
		get
		{
			return ORriq2c0IXD ?? (ORriq2c0IXD = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			if (!object.Equals(chartSeries, ORriq2c0IXD))
			{
				ORriq2c0IXD = chartSeries;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2108526692 ^ -2108503590));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 == 0)
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

	[DataMember(Name = "Middle")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("Middle")]
	public ChartSeries MiddleSeries
	{
		get
		{
			return mb2iqHUxnem ?? (mb2iqHUxnem = new ChartSeries(ChartSeriesType.Line, Colors.Red));
		}
		private set
		{
			if (!object.Equals(objA, mb2iqHUxnem))
			{
				mb2iqHUxnem = objA;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1161619942 ^ -1161580422));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "Lower")]
	[DisplayName("Lower")]
	public ChartSeries LowerSeries
	{
		get
		{
			return IHdiqfMtPoc ?? (IHdiqfMtPoc = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
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
					IHdiqfMtPoc = chartSeries;
					OnPropertyChanged((string)WtZdnPecQCWjE3O0a8IE(-838841832 ^ -838800284));
					return;
				case 1:
					if (t6Fd4SecgAk7kHor9j4n(chartSeries, IHdiqfMtPoc))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName("Area")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "Area")]
	public ChartRegion AreaRegion
	{
		get
		{
			return WuLiq9F6SvS ?? (WuLiq9F6SvS = new ChartRegion(ptAAkuecRYRXM1A0xwy4(Color.FromArgb(50, 0, 0, 0))));
		}
		private set
		{
			if (!t6Fd4SecgAk7kHor9j4n(chartRegion, WuLiq9F6SvS))
			{
				WuLiq9F6SvS = chartRegion;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)WtZdnPecQCWjE3O0a8IE(-1801468030 ^ -1801494252));
			}
		}
	}

	public W6T6CJiOUetLhLYpn8Al()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 20;
		StdDev = 2m;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 != 0)
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
			MaType = IndicatorMaType.SMA;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
			{
				num = 1;
			}
		}
	}

	protected override void Execute()
	{
		int num = 1;
		int num2 = num;
		double[] array = default(double[]);
		double[] upperBand = default(double[]);
		double[] middleBand = default(double[]);
		double[] lowerBand = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				array = (double[])OH0vLRec6uQxe8ZxTiHf(Source, base.Helper);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (array == null)
				{
					return;
				}
				base.Helper.BBands(array, Period, OQfGuTecM3Y7kbMRBko1(StdDev), (double)StdDev, MaType, out upperBand, out middleBand, out lowerBand);
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
			{
				IndicatorSeriesData indicatorSeriesData = new IndicatorSeriesData(upperBand, AreaRegion);
				Lp1WCaecO4ASEUiNtO4q(indicatorSeriesData, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1192989954 ^ -1192957896), lowerBand);
				IndicatorSeriesData indicatorSeriesData2 = indicatorSeriesData;
				base.Series.Add(indicatorSeriesData2, new IndicatorSeriesData(upperBand, UpperSeries), new IndicatorSeriesData(middleBand, MiddleSeries), new IndicatorSeriesData(lowerBand, LowerSeries));
				return;
			}
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				KFapiaecIp32OKh1orlR(UpperSeries, Wmj4VCecqTXCijouHyt0(P_0));
				LowerSeries.AllColors = UpperSeries.Color;
				AreaRegion.Color = new XColor(50, UpperSeries.Color);
				return;
			case 1:
				MiddleSeries.AllColors = P_0.GetNextColor();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		W6T6CJiOUetLhLYpn8Al w6T6CJiOUetLhLYpn8Al = (W6T6CJiOUetLhLYpn8Al)P_0;
		Period = PQwW86ecWFhUtDbG7CH4(w6T6CJiOUetLhLYpn8Al);
		int num = 2;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 3:
				StdDev = w6T6CJiOUetLhLYpn8Al.StdDev;
				num = 2;
				break;
			default:
				base.CopyTemplate(P_0, P_1);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				MaType = HMoHZdectXnS0e7GxboZ(w6T6CJiOUetLhLYpn8Al);
				if (!P_1)
				{
					Source = w6T6CJiOUetLhLYpn8Al.Source.CloneSource();
				}
				HTVZoqecT5hyXhw6QTHr(MiddleSeries, SBR8H8ecUcVksMQYDo8C(w6T6CJiOUetLhLYpn8Al));
				UpperSeries.CopyTheme(w6T6CJiOUetLhLYpn8Al.UpperSeries);
				LowerSeries.CopyTheme(w6T6CJiOUetLhLYpn8Al.LowerSeries);
				swn6n2ecyDla8sK9jxi3(AreaRegion, w6T6CJiOUetLhLYpn8Al.AreaRegion);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-90307782 ^ -90266220), Source, Period, StdDev.ToString(CultureInfo.InvariantCulture));
	}

	static W6T6CJiOUetLhLYpn8Al()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object WtZdnPecQCWjE3O0a8IE(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool XXxKitecjMSgJMcOTnW3()
	{
		return JEwT2MeccoRlbVvmGd9C == null;
	}

	internal static W6T6CJiOUetLhLYpn8Al ENWBvQecElmAfxZIaHkr()
	{
		return JEwT2MeccoRlbVvmGd9C;
	}

	internal static bool yDFOR3ecdpwKjRxQ4Fef(decimal P_0, decimal P_1)
	{
		return P_0 == P_1;
	}

	internal static bool t6Fd4SecgAk7kHor9j4n(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static XColor ptAAkuecRYRXM1A0xwy4(Color P_0)
	{
		return P_0;
	}

	internal static object OH0vLRec6uQxe8ZxTiHf(object P_0, object P_1)
	{
		return ((IndicatorSourceBase)P_0).GetSeries((IndicatorsHelper)P_1);
	}

	internal static double OQfGuTecM3Y7kbMRBko1(decimal P_0)
	{
		return (double)P_0;
	}

	internal static void Lp1WCaecO4ASEUiNtO4q(object P_0, object P_1, object P_2)
	{
		((IndicatorSeriesData)P_0)[(string)P_1] = (double[])P_2;
	}

	internal static XColor Wmj4VCecqTXCijouHyt0(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static void KFapiaecIp32OKh1orlR(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static int PQwW86ecWFhUtDbG7CH4(object P_0)
	{
		return ((W6T6CJiOUetLhLYpn8Al)P_0).Period;
	}

	internal static IndicatorMaType HMoHZdectXnS0e7GxboZ(object P_0)
	{
		return ((W6T6CJiOUetLhLYpn8Al)P_0).MaType;
	}

	internal static object SBR8H8ecUcVksMQYDo8C(object P_0)
	{
		return ((W6T6CJiOUetLhLYpn8Al)P_0).MiddleSeries;
	}

	internal static void HTVZoqecT5hyXhw6QTHr(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static void swn6n2ecyDla8sK9jxi3(object P_0, object P_1)
	{
		((ChartRegion)P_0).CopyTheme((ChartRegion)P_1);
	}
}
