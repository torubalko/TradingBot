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
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.Sources;
using TigerTrade.Dx;

namespace pnMUkuitYy2x1DyxoIaF;

[Indicator("KeltnerChannel", "KeltnerChannel", true, Type = typeof(ucGuM1itGC0aLneb7k7Y))]
[DataContract(Name = "KeltnerChannelIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class ucGuM1itGC0aLneb7k7Y : IndicatorBase
{
	private int ljmiteLCq3K;

	private decimal V4EitsEXX9i;

	private IndicatorMaType mvgitXK1f5U;

	private IndicatorSourceBase TbOitcDUhMT;

	private ChartSeries W2fitjmM0bR;

	private ChartSeries WwditEVejdJ;

	private ChartSeries IEYitQoKFb1;

	private ChartRegion hyKitdKPcHp;

	internal static ucGuM1itGC0aLneb7k7Y fPRgRweQBNse3YGkNQxJ;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Period
	{
		get
		{
			return ljmiteLCq3K;
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
					num3 = KoAeQJeQliQ6q15GSWBh(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (num3 != ljmiteLCq3K)
				{
					ljmiteLCq3K = num3;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1774602229 ^ -1774633027));
					OnPropertyChanged((string)sf7Y41eQ43ld6fR7LGcb(0x4662F6AF ^ 0x4662678B));
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[DataMember(Name = "Factor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsFactor")]
	public decimal Factor
	{
		get
		{
			return V4EitsEXX9i;
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
					return;
				case 2:
					num3 = Math.Max(0.1m, num3);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 != 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					if (num3 == V4EitsEXX9i)
					{
						return;
					}
					V4EitsEXX9i = num3;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2056710528 ^ -2056676148));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x9F0F634 ^ 0x9F06710));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	[DataMember(Name = "MaType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public IndicatorMaType MaType
	{
		get
		{
			return mvgitXK1f5U;
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
					if (indicatorMaType == mvgitXK1f5U)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 != 0)
						{
							num2 = 0;
						}
						break;
					}
					mvgitXK1f5U = indicatorMaType;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x9F0F634 ^ 0x9F0714C));
					return;
				case 0:
					return;
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
			return TbOitcDUhMT ?? (TbOitcDUhMT = new StockSource());
		}
		set
		{
			if (indicatorSourceBase != TbOitcDUhMT)
			{
				TbOitcDUhMT = indicatorSourceBase;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x20B584D2 ^ 0x20B50CB4));
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
			return W2fitjmM0bR ?? (W2fitjmM0bR = new ChartSeries(ChartSeriesType.Line, AHWeUmeQDC9YObexE6tw()));
		}
		private set
		{
			if (!Rp0SXGeQbPNh9WWNrSJy(chartSeries, W2fitjmM0bR))
			{
				W2fitjmM0bR = chartSeries;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1251569705 ^ -1251595887));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
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

	[DisplayName("Middle")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "Middle")]
	public ChartSeries MiddleSeries
	{
		get
		{
			return WwditEVejdJ ?? (WwditEVejdJ = new ChartSeries(ChartSeriesType.Line, Colors.Red));
		}
		private set
		{
			if (!object.Equals(chartSeries, WwditEVejdJ))
			{
				WwditEVejdJ = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x37B74BDF ^ 0x37B7EDBF));
			}
		}
	}

	[DataMember(Name = "Lower")]
	[DisplayName("Lower")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries LowerSeries
	{
		get
		{
			return IEYitQoKFb1 ?? (IEYitQoKFb1 = new ChartSeries(ChartSeriesType.Line, MkDR6xeQN3vRkENE0XDT(Colors.Blue)));
		}
		private set
		{
			if (!Rp0SXGeQbPNh9WWNrSJy(chartSeries, IEYitQoKFb1))
			{
				IEYitQoKFb1 = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x50C1C840 ^ 0x50C16E3C));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("Area")]
	[DataMember(Name = "Area")]
	public ChartRegion AreaRegion
	{
		get
		{
			return hyKitdKPcHp ?? (hyKitdKPcHp = new ChartRegion(MkDR6xeQN3vRkENE0XDT(ako1b0eQknDFTrsK72eq(50, 0, 0, 0))));
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
					hyKitdKPcHp = chartRegion;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--146713930 ^ 0x8BE0BDC));
					return;
				case 1:
					if (Rp0SXGeQbPNh9WWNrSJy(chartRegion, hyKitdKPcHp))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ucGuM1itGC0aLneb7k7Y()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 20;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				MaType = IndicatorMaType.SMA;
				return;
			case 1:
				Factor = 1m;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		double[] array = (double[])zaW6MCeQ1MTxIy843MXP(Source, base.Helper);
		if (array == null)
		{
			return;
		}
		base.Helper.KeltnerChannel(array, MaType, Period, lfUG5WeQ5sqvPfJUUFSg(Factor), out var avg, out var upper, out var lower);
		IndicatorSeriesData indicatorSeriesData = new IndicatorSeriesData(upper, AreaRegion);
		YbYBIreQSy8w0aLgiBGP(indicatorSeriesData, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1009517961 ^ -1009551183), lower);
		IndicatorSeriesData indicatorSeriesData2 = indicatorSeriesData;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
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
			base.Series.Add(indicatorSeriesData2, new IndicatorSeriesData(upper, UpperSeries), new IndicatorSeriesData(avg, MiddleSeries), new IndicatorSeriesData(lower, LowerSeries));
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa != 0)
			{
				num = 1;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				LowerSeries.AllColors = sDfEAXeQxaZmvmxm4Lpq(UpperSeries);
				AreaRegion.Color = new XColor(50, UpperSeries.Color);
				base.ApplyColors(P_0);
				return;
			case 1:
				UpperSeries.AllColors = P_0.GetNextColor();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				MiddleSeries.AllColors = P_0.GetNextColor();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		ucGuM1itGC0aLneb7k7Y ucGuM1itGC0aLneb7k7Y2 = (ucGuM1itGC0aLneb7k7Y)P_0;
		Period = ucGuM1itGC0aLneb7k7Y2.Period;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				UpperSeries.CopyTheme((ChartSeries)lNL6XLeQe4gHoZW0QiRu(ucGuM1itGC0aLneb7k7Y2));
				A99RmveQsNALrp9T2ZlC(LowerSeries, ucGuM1itGC0aLneb7k7Y2.LowerSeries);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			case 2:
				Factor = ucGuM1itGC0aLneb7k7Y2.Factor;
				MaType = ucGuM1itGC0aLneb7k7Y2.MaType;
				if (!P_1)
				{
					Source = ucGuM1itGC0aLneb7k7Y2.Source.CloneSource();
				}
				MiddleSeries.CopyTheme((ChartSeries)YH8YtXeQL3LhqXnsfWho(ucGuM1itGC0aLneb7k7Y2));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
				{
					num = 1;
				}
				break;
			default:
				AreaRegion.CopyTheme(ucGuM1itGC0aLneb7k7Y2.AreaRegion);
				base.CopyTemplate(P_0, P_1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 != 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xECA3F28 ^ 0xECA97DE), Source, Period, Factor);
	}

	static ucGuM1itGC0aLneb7k7Y()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int KoAeQJeQliQ6q15GSWBh(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object sf7Y41eQ43ld6fR7LGcb(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool c33nmyeQavwEZo7mkrB3()
	{
		return fPRgRweQBNse3YGkNQxJ == null;
	}

	internal static ucGuM1itGC0aLneb7k7Y zdPvZteQiE0jBkAvLgld()
	{
		return fPRgRweQBNse3YGkNQxJ;
	}

	internal static Color AHWeUmeQDC9YObexE6tw()
	{
		return Colors.Blue;
	}

	internal static bool Rp0SXGeQbPNh9WWNrSJy(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static XColor MkDR6xeQN3vRkENE0XDT(Color P_0)
	{
		return P_0;
	}

	internal static Color ako1b0eQknDFTrsK72eq(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static object zaW6MCeQ1MTxIy843MXP(object P_0, object P_1)
	{
		return ((IndicatorSourceBase)P_0).GetSeries((IndicatorsHelper)P_1);
	}

	internal static double lfUG5WeQ5sqvPfJUUFSg(decimal P_0)
	{
		return (double)P_0;
	}

	internal static void YbYBIreQSy8w0aLgiBGP(object P_0, object P_1, object P_2)
	{
		((IndicatorSeriesData)P_0)[(string)P_1] = (double[])P_2;
	}

	internal static XColor sDfEAXeQxaZmvmxm4Lpq(object P_0)
	{
		return ((ChartSeries)P_0).Color;
	}

	internal static object YH8YtXeQL3LhqXnsfWho(object P_0)
	{
		return ((ucGuM1itGC0aLneb7k7Y)P_0).MiddleSeries;
	}

	internal static object lNL6XLeQe4gHoZW0QiRu(object P_0)
	{
		return ((ucGuM1itGC0aLneb7k7Y)P_0).UpperSeries;
	}

	internal static void A99RmveQsNALrp9T2ZlC(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}
}
