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
using TigerTrade.Dx;

namespace fng5LNitrlaxe4YX9osh;

[DataContract(Name = "MACDIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("MACD", "MACD", false, Type = typeof(Bf0efDitC2TPgGB0QBdm))]
internal sealed class Bf0efDitC2TPgGB0QBdm : IndicatorBase
{
	private int Ej0iUHThAYQ;

	private int kMSiUfvdvc2;

	private int HuwiU9yTidn;

	private IndicatorSourceBase MkuiUnoJJgm;

	private ChartSeries XPIiUGdYerZ;

	private ChartSeries nkciUYQrmf4;

	private ChartSeries jXniUosYj35;

	private static Bf0efDitC2TPgGB0QBdm OHvtGveQqXr77sTXhV0a;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSlowPeriod")]
	[DataMember(Name = "Slow")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Slow
	{
		get
		{
			return Ej0iUHThAYQ;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == Ej0iUHThAYQ)
			{
				return;
			}
			Ej0iUHThAYQ = num;
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b != 0)
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
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28C965BE ^ 0x28C9EE0C));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1487846E ^ 0x1487154A));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
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
	[DataMember(Name = "Fast")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsFastPeriod")]
	public int Fast
	{
		get
		{
			return kMSiUfvdvc2;
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
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6EC99CAF ^ 0x6EC90D8B));
					return;
				case 2:
					num3 = Math.Max(1, num3);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (num3 == kMSiUfvdvc2)
					{
						return;
					}
					kMSiUfvdvc2 = num3;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-57768881 ^ -57798671));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Signal")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSignalPeriod")]
	public int Signal
	{
		get
		{
			return HuwiU9yTidn;
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
				case 0:
					return;
				case 2:
					num3 = Math.Max(1, num3);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (num3 == HuwiU9yTidn)
					{
						return;
					}
					HuwiU9yTidn = num3;
					OnPropertyChanged((string)SwbVnEeQtPKOC1FirF3N(-1583344314 ^ -1583309172));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-3429745 ^ -3458133));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
					{
						num2 = 0;
					}
					break;
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
			return MkuiUnoJJgm ?? (MkuiUnoJJgm = new StockSource());
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
					if (indicatorSourceBase == MkuiUnoJJgm)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 != 0)
						{
							num2 = 0;
						}
						break;
					}
					MkuiUnoJJgm = indicatorSourceBase;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6EC99CAF ^ 0x6EC914C9));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("MACD")]
	[DataMember(Name = "MACD")]
	public ChartSeries MACDSeries
	{
		get
		{
			return XPIiUGdYerZ ?? (XPIiUGdYerZ = new ChartSeries(ChartSeriesType.Line, tEHPuGeQTjSYv8qeG56G(xFMAyCeQUNVsrpF2oMIV())));
		}
		private set
		{
			if (!object.Equals(chartSeries, XPIiUGdYerZ))
			{
				XPIiUGdYerZ = chartSeries;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-338769610 ^ -338796432));
			}
		}
	}

	[DisplayName("Signal")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "AVG")]
	public ChartSeries AVGSeries
	{
		get
		{
			return nkciUYQrmf4 ?? (nkciUYQrmf4 = new ChartSeries(ChartSeriesType.Line, tEHPuGeQTjSYv8qeG56G(Colors.Red)));
		}
		private set
		{
			if (!object.Equals(objA, nkciUYQrmf4))
			{
				nkciUYQrmf4 = objA;
				OnPropertyChanged((string)SwbVnEeQtPKOC1FirF3N(0x7394D272 ^ 0x73947B2C));
			}
		}
	}

	[DataMember(Name = "DIFF")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("Diff")]
	public ChartSeries DIFFSeries
	{
		get
		{
			return jXniUosYj35 ?? (jXniUosYj35 = new ChartSeries(ChartSeriesType.Columns, Colors.Green));
		}
		private set
		{
			if (!fk5mR6eQyALmZSualkvM(chartSeries, jXniUosYj35))
			{
				jXniUosYj35 = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1841489831 ^ -1841450707));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> E5EiU2qnLcS => base.Levels;

	public Bf0efDitC2TPgGB0QBdm()
	{
		jgvXP5eQZGCaxmHEfdKm();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Signal = 9;
				return;
			case 1:
				Slow = 26;
				Fast = 12;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		double[] series = Source.GetSeries(base.Helper);
		if (series != null)
		{
			base.Helper.MACD(series, Fast, Slow, Signal, out var macd, out var macdSignal, out var macdHist);
			base.Series.Add(new IndicatorSeriesData(macdHist, DIFFSeries), new IndicatorSeriesData(macd, MACDSeries), new IndicatorSeriesData(macdSignal, AVGSeries));
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b != 0)
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

	public override void ApplyColors(IChartTheme P_0)
	{
		MACDSeries.AllColors = P_0.GetNextColor();
		AVGSeries.AllColors = ItTamweQV7wWX9fGkgMd(P_0);
		gi7eMBeQC7INv8qUHCiv(DIFFSeries, P_0.GetNextColor());
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 == 0)
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
			DIFFSeries.Color2 = P_0.GetNextColor();
			base.ApplyColors(P_0);
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
			{
				num = 1;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 3;
		int num2 = num;
		Bf0efDitC2TPgGB0QBdm bf0efDitC2TPgGB0QBdm = default(Bf0efDitC2TPgGB0QBdm);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Source = ((IndicatorSourceBase)unP3NleQrTK4meEjACVL(bf0efDitC2TPgGB0QBdm)).CloneSource();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				Slow = bf0efDitC2TPgGB0QBdm.Slow;
				Fast = bf0efDitC2TPgGB0QBdm.Fast;
				Signal = bf0efDitC2TPgGB0QBdm.Signal;
				if (!P_1)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 4:
				DIFFSeries.CopyTheme(bf0efDitC2TPgGB0QBdm.DIFFSeries);
				base.CopyTemplate(P_0, P_1);
				return;
			case 3:
				bf0efDitC2TPgGB0QBdm = (Bf0efDitC2TPgGB0QBdm)P_0;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
				{
					num2 = 2;
				}
				continue;
			}
			MACDSeries.CopyTheme((ChartSeries)qwaXZ3eQKfSkSt59MEU5(bf0efDitC2TPgGB0QBdm));
			AVGSeries.CopyTheme((ChartSeries)HeqbgIeQmklFfaSHcQdq(bf0efDitC2TPgGB0QBdm));
			num2 = 4;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
			{
				num2 = 0;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)SwbVnEeQtPKOC1FirF3N(--18459671 ^ 0x1192005), base.Name, Source, Slow, Fast, Signal);
	}

	static Bf0efDitC2TPgGB0QBdm()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool phtEr9eQIOqZfGghNb07()
	{
		return OHvtGveQqXr77sTXhV0a == null;
	}

	internal static Bf0efDitC2TPgGB0QBdm plReEIeQWNHLCmMOya12()
	{
		return OHvtGveQqXr77sTXhV0a;
	}

	internal static object SwbVnEeQtPKOC1FirF3N(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static Color xFMAyCeQUNVsrpF2oMIV()
	{
		return Colors.Blue;
	}

	internal static XColor tEHPuGeQTjSYv8qeG56G(Color P_0)
	{
		return P_0;
	}

	internal static bool fk5mR6eQyALmZSualkvM(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void jgvXP5eQZGCaxmHEfdKm()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static XColor ItTamweQV7wWX9fGkgMd(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static void gi7eMBeQC7INv8qUHCiv(object P_0, XColor value)
	{
		((ChartSeries)P_0).Color = value;
	}

	internal static object unP3NleQrTK4meEjACVL(object P_0)
	{
		return ((Bf0efDitC2TPgGB0QBdm)P_0).Source;
	}

	internal static object qwaXZ3eQKfSkSt59MEU5(object P_0)
	{
		return ((Bf0efDitC2TPgGB0QBdm)P_0).MACDSeries;
	}

	internal static object HeqbgIeQmklFfaSHcQdq(object P_0)
	{
		return ((Bf0efDitC2TPgGB0QBdm)P_0).AVGSeries;
	}
}
