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

namespace P8SiYxiIphO83LKnC0dt;

[Indicator("Envelopes", "Envelopes", true, Type = typeof(d2f9ELiI3Gm5uS61DmIp))]
[DataContract(Name = "EnvelopesIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class d2f9ELiI3Gm5uS61DmIp : IndicatorBase
{
	private int CSXiW4Bayw3;

	private int ntgiWDB8qpl;

	private IndicatorMaType Lt3iWbxIaJD;

	private IndicatorSourceBase SImiWNf73l1;

	private ChartSeries kWriWkkQ43w;

	private ChartSeries d31iW13ftwN;

	private ChartSeries bLYiW5gQuIY;

	private ChartRegion nVliWSQNknT;

	private static d2f9ELiI3Gm5uS61DmIp mimDedeE5kWdJS8NqbQJ;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return CSXiW4Bayw3;
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
					OnPropertyChanged((string)eXtlvkeEelDbgWknwOQp(-165474503 ^ -165437923));
					return;
				case 2:
					num3 = lLUhQbeELLdJxImsRbf8(1, num3);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (num3 == CSXiW4Bayw3)
					{
						return;
					}
					CSXiW4Bayw3 = num3;
					OnPropertyChanged((string)eXtlvkeEelDbgWknwOQp(-710503328 ^ -710536234));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsFactor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Factor")]
	public int Factor
	{
		get
		{
			return ntgiWDB8qpl;
		}
		set
		{
			num = Math.Max(1, num);
			int num2;
			if (num == ntgiWDB8qpl)
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
				{
					num2 = 0;
				}
			}
			else
			{
				ntgiWDB8qpl = num;
				OnPropertyChanged((string)eXtlvkeEelDbgWknwOQp(0x2C8374E4 ^ 0x2C83FEA8));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x20B584D2 ^ 0x20B515F6));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 1:
				break;
			case 0:
				break;
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "MaType")]
	public IndicatorMaType MaType
	{
		get
		{
			return Lt3iWbxIaJD;
		}
		set
		{
			if (indicatorMaType != Lt3iWbxIaJD)
			{
				Lt3iWbxIaJD = indicatorMaType;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-838841832 ^ -838808224));
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
			return SImiWNf73l1 ?? (SImiWNf73l1 = new StockSource());
		}
		set
		{
			if (indicatorSourceBase != SImiWNf73l1)
			{
				SImiWNf73l1 = indicatorSourceBase;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)eXtlvkeEelDbgWknwOQp(0xECA3F28 ^ 0xECAB74E));
			}
		}
	}

	[DisplayName("Upper")]
	[Category("Графики")]
	[DataMember(Name = "Upper")]
	public ChartSeries UpperSeries
	{
		get
		{
			return kWriWkkQ43w ?? (kWriWkkQ43w = new ChartSeries(ChartSeriesType.Line, eHHoaJeEs148Ellh1laU(Colors.Blue)));
		}
		private set
		{
			if (!fY4pteeEXaSWhhHqIXvi(chartSeries, kWriWkkQ43w))
			{
				kWriWkkQ43w = chartSeries;
				OnPropertyChanged((string)eXtlvkeEelDbgWknwOQp(0x769C7931 ^ 0x769CDF77));
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
			return d31iW13ftwN ?? (d31iW13ftwN = new ChartSeries(ChartSeriesType.Line, T2Kw1XeEccyKfdhai5U5()));
		}
		private set
		{
			if (!object.Equals(objA, d31iW13ftwN))
			{
				d31iW13ftwN = objA;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1522697859 ^ -1522671843));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
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

	[DisplayName("Lower")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "Lower")]
	public ChartSeries LowerSeries
	{
		get
		{
			return bLYiW5gQuIY ?? (bLYiW5gQuIY = new ChartSeries(ChartSeriesType.Line, cKwWW6eEjAnqaNTsqCR8()));
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
					if (object.Equals(objA, bLYiW5gQuIY))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
						{
							num2 = 0;
						}
						break;
					}
					bLYiW5gQuIY = objA;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1346994499 ^ -1346971455));
					return;
				case 0:
					return;
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
			return nVliWSQNknT ?? (nVliWSQNknT = new ChartRegion(Color.FromArgb(50, 0, 0, 0)));
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
					if (!object.Equals(objA, nVliWSQNknT))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					nVliWSQNknT = objA;
					OnPropertyChanged((string)eXtlvkeEelDbgWknwOQp(0x2D313048 ^ 0x2D3196DE));
					return;
				}
			}
		}
	}

	public d2f9ELiI3Gm5uS61DmIp()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 20;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f != 0)
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
			Factor = 2;
			MaType = IndicatorMaType.SMA;
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
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
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				array = (double[])Vtx20jeEE4pj2J0xVLTL(Source, base.Helper);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (array == null)
			{
				return;
			}
			base.Helper.Envelopes(array, MaType, Period, Factor, out var avg, out var upper, out var lower);
			IndicatorSeriesData indicatorSeriesData = new IndicatorSeriesData(upper, AreaRegion) { [yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x12620268 ^ 0x126280AE)] = lower };
			base.Series.Add(indicatorSeriesData, new IndicatorSeriesData(upper, UpperSeries), new IndicatorSeriesData(avg, MiddleSeries), new IndicatorSeriesData(lower, LowerSeries));
			num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
			{
				num2 = 2;
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
				base.ApplyColors(P_0);
				return;
			case 1:
				C6b1YueEdRBq8jxtbFl1(UpperSeries, P_0.GetNextColor());
				C6b1YueEdRBq8jxtbFl1(LowerSeries, UpperSeries.Color);
				vrPZNleERNZmYyOpoHga(AreaRegion, new XColor(50, gEkepteEgJ42Aib7FE4P(UpperSeries)));
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				MiddleSeries.AllColors = zJWu1qeEQggJJuNxTC9v(P_0);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		d2f9ELiI3Gm5uS61DmIp d2f9ELiI3Gm5uS61DmIp2 = (d2f9ELiI3Gm5uS61DmIp)P_0;
		Period = hy8HGEeE6vuVjIx791r5(d2f9ELiI3Gm5uS61DmIp2);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 2:
				JVVaoUeEOKXsOU096OfF(UpperSeries, d2f9ELiI3Gm5uS61DmIp2.UpperSeries);
				LowerSeries.CopyTheme(d2f9ELiI3Gm5uS61DmIp2.LowerSeries);
				AreaRegion.CopyTheme((ChartRegion)sLWAYbeEqAUx9G5s9pne(d2f9ELiI3Gm5uS61DmIp2));
				base.CopyTemplate(P_0, P_1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
				{
					num = 3;
				}
				break;
			case 1:
				MaType = d2f9ELiI3Gm5uS61DmIp2.MaType;
				if (!P_1)
				{
					Source = ((IndicatorSourceBase)RpWpuleEMduWB6aNC74F(d2f9ELiI3Gm5uS61DmIp2)).CloneSource();
				}
				MiddleSeries.CopyTheme(d2f9ELiI3Gm5uS61DmIp2.MiddleSeries);
				num = 2;
				break;
			default:
				Factor = d2f9ELiI3Gm5uS61DmIp2.Factor;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return (string)dWghVheEIqhf1g4D4aYb(eXtlvkeEelDbgWknwOQp(--500511424 ^ 0x1DD5BA6E), new object[4] { base.Name, Source, Period, Factor });
	}

	static d2f9ELiI3Gm5uS61DmIp()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int lLUhQbeELLdJxImsRbf8(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object eXtlvkeEelDbgWknwOQp(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool kiyF3veESYflQiqJhDWb()
	{
		return mimDedeE5kWdJS8NqbQJ == null;
	}

	internal static d2f9ELiI3Gm5uS61DmIp idXJISeExuUvgiKDR4Wy()
	{
		return mimDedeE5kWdJS8NqbQJ;
	}

	internal static XColor eHHoaJeEs148Ellh1laU(Color P_0)
	{
		return P_0;
	}

	internal static bool fY4pteeEXaSWhhHqIXvi(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static Color T2Kw1XeEccyKfdhai5U5()
	{
		return Colors.Red;
	}

	internal static Color cKwWW6eEjAnqaNTsqCR8()
	{
		return Colors.Blue;
	}

	internal static object Vtx20jeEE4pj2J0xVLTL(object P_0, object P_1)
	{
		return ((IndicatorSourceBase)P_0).GetSeries((IndicatorsHelper)P_1);
	}

	internal static XColor zJWu1qeEQggJJuNxTC9v(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static void C6b1YueEdRBq8jxtbFl1(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static XColor gEkepteEgJ42Aib7FE4P(object P_0)
	{
		return ((ChartSeries)P_0).Color;
	}

	internal static void vrPZNleERNZmYyOpoHga(object P_0, XColor value)
	{
		((ChartRegion)P_0).Color = value;
	}

	internal static int hy8HGEeE6vuVjIx791r5(object P_0)
	{
		return ((d2f9ELiI3Gm5uS61DmIp)P_0).Period;
	}

	internal static object RpWpuleEMduWB6aNC74F(object P_0)
	{
		return ((d2f9ELiI3Gm5uS61DmIp)P_0).Source;
	}

	internal static void JVVaoUeEOKXsOU096OfF(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static object sLWAYbeEqAUx9G5s9pne(object P_0)
	{
		return ((d2f9ELiI3Gm5uS61DmIp)P_0).AreaRegion;
	}

	internal static object dWghVheEIqhf1g4D4aYb(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}
}
