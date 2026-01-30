using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Collections;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace G6EkLaix4Rb48th5GL3M;

[DataContract(Name = "HighLowIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("HighLow", "HighLow", true, Type = typeof(qt78w7ixl4X3xwgBDGaM))]
internal sealed class qt78w7ixl4X3xwgBDGaM : IndicatorBase
{
	private IndicatorPeriodType I66ixLV2kqN;

	private ChartLine UmPixekNENx;

	private ChartLine SxYixseo2px;

	private ChartLine XOmixXfF0Wc;

	private static qt78w7ixl4X3xwgBDGaM xJBgAjekm6yb1WBQgxG0;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	public IndicatorPeriodType Period
	{
		get
		{
			return I66ixLV2kqN;
		}
		set
		{
			if (indicatorPeriodType != I66ixLV2kqN)
			{
				I66ixLV2kqN = indicatorPeriodType;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x385FFAB ^ 0x385781D));
			}
		}
	}

	[DisplayName("High/Low")]
	[DataMember(Name = "HighLow")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartLine HighLowSeries
	{
		get
		{
			return UmPixekNENx ?? (UmPixekNENx = new ChartLine());
		}
		private set
		{
			if (!object.Equals(chartLine, UmPixekNENx))
			{
				UmPixekNENx = chartLine;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)nKGcFpek71yIG5dfVNhB(-181342698 ^ -181372998));
			}
		}
	}

	[DataMember(Name = "Median")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("Median")]
	public ChartLine MedianSeries
	{
		get
		{
			return SxYixseo2px ?? (SxYixseo2px = new ChartLine());
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
					if (object.Equals(chartLine, SxYixseo2px))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 != 0)
						{
							num2 = 0;
						}
						break;
					}
					SxYixseo2px = chartLine;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1153206687 ^ -1153175637));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "PrevMedian")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("PrevMedian")]
	public ChartLine PrevMedianSeries
	{
		get
		{
			ChartLine chartLine = XOmixXfF0Wc;
			if (chartLine == null)
			{
				ChartLine chartLine2 = new ChartLine();
				UNv0anek8nZKn64e3tot(chartLine2, XDashStyle.Dash);
				ChartLine chartLine3 = chartLine2;
				XOmixXfF0Wc = chartLine2;
				chartLine = chartLine3;
			}
			return chartLine;
		}
		private set
		{
			if (!pe7cSJekAEOmLdmWasV3(chartLine, XOmixXfF0Wc))
			{
				XOmixXfF0Wc = chartLine;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-3429745 ^ -3460247));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
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

	[Browsable(false)]
	public override IndicatorCalculation DefaultCalculation => IndicatorCalculation.OnBarClose;

	public qt78w7ixl4X3xwgBDGaM()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Period = IndicatorPeriodType.Day;
	}

	protected override void Execute()
	{
		double[] array = (double[])k5G0UCekPo3HgC5GNkVQ(base.Helper);
		double[] array2 = (double[])jdDCwNekJBNTlyJH15JW(base.Helper);
		int num = 9;
		int num6 = default(int);
		int num3 = default(int);
		double timeOffset = default(double);
		double[] array4 = default(double[]);
		double num4 = default(double);
		double[] array5 = default(double[]);
		double num8 = default(double);
		double[] array6 = default(double[]);
		double num5 = default(double);
		double[] array7 = default(double[]);
		IndicatorPeriodType indicatorPeriodType = default(IndicatorPeriodType);
		bool[] array8 = default(bool[]);
		int num7 = default(int);
		double[] low = default(double[]);
		while (true)
		{
			switch (num)
			{
			case 6:
				num6 = MTxnm0ekpPSoVgpSkway(hyTCDmekuQVf4d4lW5Vx(base.DataProvider), ChartPeriodType.Month, 1, array[num3], timeOffset);
				num = 2;
				break;
			case 17:
				array4[num3] = num4;
				num = 13;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
				{
					num = 1;
				}
				break;
			case 8:
				num4 = double.NaN;
				timeOffset = U3JG6bek3aoV6bqZhTEN(pqViQ9ekFbM1ZEMkVry6(base.DataProvider.Symbol));
				num3 = 0;
				goto default;
			case 14:
				goto IL_00ea;
			case 16:
				array5[num3] = num8;
				array6[num3] = num5;
				array7[num3] = (num8 + num5) / 2.0;
				num = 17;
				break;
			default:
				if (num3 >= array.Length)
				{
					num = 4;
					break;
				}
				num6 = 1;
				num = 18;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
				{
					num = 15;
				}
				break;
			case 10:
				num5 = 0.0;
				num = 8;
				break;
			case 18:
				indicatorPeriodType = Period;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 != 0)
				{
					num = 1;
				}
				break;
			case 2:
			case 7:
				goto IL_01ca;
			case 12:
				return;
			case 15:
			{
				array8 = new bool[array.Length];
				num7 = -1;
				num8 = 0.0;
				int num9 = 10;
				num = num9;
				break;
			}
			case 3:
				array8[num3] = true;
				num = 11;
				break;
			case 5:
				goto IL_02a6;
			case 1:
				switch (indicatorPeriodType)
				{
				case IndicatorPeriodType.Month:
					break;
				case IndicatorPeriodType.Week:
					goto IL_00ea;
				default:
					goto IL_01ca;
				case IndicatorPeriodType.Day:
					goto IL_02a6;
				}
				goto case 6;
			case 11:
				num8 = Math.Max(num8, array2[num3]);
				num5 = NNoIAsekzbqGUUNO7SvD(num5, low[num3]);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
				{
					num = 16;
				}
				break;
			case 13:
				num3++;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
				{
					num = 0;
				}
				break;
			case 9:
				low = base.Helper.Low;
				array5 = new double[array.Length];
				array6 = new double[array.Length];
				array7 = new double[array.Length];
				array4 = new double[array.Length];
				num = 15;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d != 0)
				{
					num = 15;
				}
				break;
			case 4:
				{
					IndicatorSeries series = base.Series;
					IndicatorSeriesData[] array3 = new IndicatorSeriesData[4];
					IndicatorSeriesData indicatorSeriesData = new IndicatorSeriesData(array4, PrevMedianSeries);
					indicatorSeriesData.Style.DisableMinMax = true;
					indicatorSeriesData.Style.StraightLine = true;
					array3[0] = indicatorSeriesData;
					IndicatorSeriesData indicatorSeriesData2 = new IndicatorSeriesData(array5, HighLowSeries);
					indicatorSeriesData2.Style.DisableMinMax = true;
					((IndicatorSeriesStyle)lQqxO5e10O2V7fgSpo6s(indicatorSeriesData2)).StraightLine = true;
					array3[1] = indicatorSeriesData2;
					IndicatorSeriesData indicatorSeriesData3 = new IndicatorSeriesData(array6, HighLowSeries);
					((IndicatorSeriesStyle)lQqxO5e10O2V7fgSpo6s(indicatorSeriesData3)).DisableMinMax = true;
					((IndicatorSeriesStyle)lQqxO5e10O2V7fgSpo6s(indicatorSeriesData3)).StraightLine = true;
					array3[2] = indicatorSeriesData3;
					IndicatorSeriesData indicatorSeriesData4 = new IndicatorSeriesData(array7, MedianSeries);
					indicatorSeriesData4.Style.DisableMinMax = true;
					indicatorSeriesData4.Style.StraightLine = true;
					array3[3] = indicatorSeriesData4;
					series.Add(array3);
					using IEnumerator<IndicatorSeriesData> enumerator = base.Series.GetEnumerator();
					while (enumerator.MoveNext())
					{
						IndicatorSeriesData current = enumerator.Current;
						current.UserData[nKGcFpek71yIG5dfVNhB(-1799510641 ^ -1799537293)] = array8;
						aUTRD9e12Uw3Yo7vjeUe(current.UserData, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-176525661 ^ -176490591), true);
					}
					int num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					case 0:
						break;
					}
					return;
				}
				IL_02a6:
				num6 = MTxnm0ekpPSoVgpSkway(base.DataProvider.Period, ChartPeriodType.Day, 1, array[num3], timeOffset);
				goto IL_01ca;
				IL_01ca:
				if (num6 != num7)
				{
					num7 = num6;
					num8 = array2[num3];
					num5 = low[num3];
					if (num3 > 0 && array7.Length > num3)
					{
						num4 = array7[num3 - 1];
						num = 3;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
						{
							num = 1;
						}
						break;
					}
					goto case 3;
				}
				goto case 11;
				IL_00ea:
				num6 = MTxnm0ekpPSoVgpSkway(base.DataProvider.Period, ChartPeriodType.Week, 1, array[num3], timeOffset);
				num = 7;
				break;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		HdyK5me1ffMnKx5lracP(HighLowSeries, r6TeN0e1H7PbjXC8WwUA(P_0));
		MedianSeries.Color = P_0.GetNextColor();
		PrevMedianSeries.Color = r6TeN0e1H7PbjXC8WwUA(P_0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		qt78w7ixl4X3xwgBDGaM qt78w7ixl4X3xwgBDGaM2 = (qt78w7ixl4X3xwgBDGaM)P_0;
		Period = qt78w7ixl4X3xwgBDGaM2.Period;
		da0jt2e1nJSeLQ0Qo1a2(HighLowSeries, k3t283e190TJii1IeD29(qt78w7ixl4X3xwgBDGaM2));
		MedianSeries.CopyTheme(qt78w7ixl4X3xwgBDGaM2.MedianSeries);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				da0jt2e1nJSeLQ0Qo1a2(PrevMedianSeries, ndRQo5e1GHRUZMBBwBgx(qt78w7ixl4X3xwgBDGaM2));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed != 0)
				{
					num = 0;
				}
				break;
			default:
				base.CopyTemplate(P_0, P_1);
				return;
			}
		}
	}

	public override string ToString()
	{
		return (string)SV8Cese1Y1tbBLVNZepk(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x68C7EAE6 ^ 0x68C77E7A), base.Name, Period);
	}

	static qt78w7ixl4X3xwgBDGaM()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool wU82nBekhbDbURhFRuae()
	{
		return xJBgAjekm6yb1WBQgxG0 == null;
	}

	internal static qt78w7ixl4X3xwgBDGaM sggiVdekwAtTsQ5skWRq()
	{
		return xJBgAjekm6yb1WBQgxG0;
	}

	internal static object nKGcFpek71yIG5dfVNhB(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void UNv0anek8nZKn64e3tot(object P_0, XDashStyle value)
	{
		((ChartLine)P_0).Style = value;
	}

	internal static bool pe7cSJekAEOmLdmWasV3(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static object k5G0UCekPo3HgC5GNkVQ(object P_0)
	{
		return ((IndicatorsHelper)P_0).Date;
	}

	internal static object jdDCwNekJBNTlyJH15JW(object P_0)
	{
		return ((IndicatorsHelper)P_0).High;
	}

	internal static object pqViQ9ekFbM1ZEMkVry6(object P_0)
	{
		return ((IChartSymbol)P_0).Exchange;
	}

	internal static double U3JG6bek3aoV6bqZhTEN(object P_0)
	{
		return TimeHelper.GetSessionOffset((string)P_0);
	}

	internal static int MTxnm0ekpPSoVgpSkway(object P_0, ChartPeriodType type, int interval, double dateTime, double timeOffset)
	{
		return ((IChartPeriod)P_0).GetSequence(type, interval, dateTime, timeOffset);
	}

	internal static object hyTCDmekuQVf4d4lW5Vx(object P_0)
	{
		return ((IChartDataProvider)P_0).Period;
	}

	internal static double NNoIAsekzbqGUUNO7SvD(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object lQqxO5e10O2V7fgSpo6s(object P_0)
	{
		return ((IndicatorSeriesData)P_0).Style;
	}

	internal static void aUTRD9e12Uw3Yo7vjeUe(object P_0, object P_1, object P_2)
	{
		((Hashtable)P_0)[P_1] = P_2;
	}

	internal static XColor r6TeN0e1H7PbjXC8WwUA(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static void HdyK5me1ffMnKx5lracP(object P_0, XColor value)
	{
		((ChartLine)P_0).Color = value;
	}

	internal static object k3t283e190TJii1IeD29(object P_0)
	{
		return ((qt78w7ixl4X3xwgBDGaM)P_0).HighLowSeries;
	}

	internal static void da0jt2e1nJSeLQ0Qo1a2(object P_0, object P_1)
	{
		((ChartLine)P_0).CopyTheme((ChartLine)P_1);
	}

	internal static object ndRQo5e1GHRUZMBBwBgx(object P_0)
	{
		return ((qt78w7ixl4X3xwgBDGaM)P_0).PrevMedianSeries;
	}

	internal static object SV8Cese1Y1tbBLVNZepk(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
