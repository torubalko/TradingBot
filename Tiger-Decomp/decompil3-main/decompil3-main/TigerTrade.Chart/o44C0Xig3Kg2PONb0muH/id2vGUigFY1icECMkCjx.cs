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
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.Sources;
using TigerTrade.Dx;

namespace o44C0Xig3Kg2PONb0muH;

[Indicator("Alligator", "Alligator", true, Type = typeof(id2vGUigFY1icECMkCjx))]
[DataContract(Name = "AlligatorIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class id2vGUigFY1icECMkCjx : IndicatorBase
{
	private int mhsiR1u3t3s;

	private int eLhiR5lFR5J;

	private int ekciRSA92BP;

	private int f96iRxND3DO;

	private int iqfiRLDUTXG;

	private int YQniReWIESD;

	private IndicatorMaType a4YiRsoEh4D;

	private IndicatorSourceBase pvgiRXWV2rv;

	private ChartSeries ujxiRcQ8X85;

	private ChartSeries ESmiRjctgVE;

	private ChartSeries xYoiRErYhMC;

	internal static id2vGUigFY1icECMkCjx BPhwrZesWkXZh4PfVkWu;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlligatorJawPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "JawPeriod")]
	public int JawPeriod
	{
		get
		{
			return mhsiR1u3t3s;
		}
		set
		{
			if (mhsiR1u3t3s != num)
			{
				mhsiR1u3t3s = num;
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged((string)hv5L3qesTe5VoDWYNdBj(-3429745 ^ -3470537));
				OnPropertyChanged((string)hv5L3qesTe5VoDWYNdBj(-45476899 ^ -45448455));
			}
		}
	}

	[DataMember(Name = "JawShift")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlligatorJawShift")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int JawShift
	{
		get
		{
			return eLhiR5lFR5J;
		}
		set
		{
			if (eLhiR5lFR5J != num)
			{
				eLhiR5lFR5J = num;
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1311293279 ^ -1311252113));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlligatorTeethPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "TeethPeriod")]
	public int TeethPeriod
	{
		get
		{
			return ekciRSA92BP;
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
					if (ekciRSA92BP == num3)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 != 0)
						{
							num2 = 0;
						}
						break;
					}
					ekciRSA92BP = num3;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x446AB724 ^ 0x446A16C6));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1878953018 ^ -1878924574));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlligatorTeethShift")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "TeethShift")]
	public int TeethShift
	{
		get
		{
			return f96iRxND3DO;
		}
		set
		{
			if (f96iRxND3DO != num)
			{
				f96iRxND3DO = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x50C1C840 ^ 0x50C169BC));
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlligatorLipsPeriod")]
	[DataMember(Name = "LipsPeriod")]
	public int LipsPeriod
	{
		get
		{
			return iqfiRLDUTXG;
		}
		set
		{
			if (iqfiRLDUTXG != num)
			{
				iqfiRLDUTXG = num;
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged((string)hv5L3qesTe5VoDWYNdBj(0x42D899B5 ^ 0x42D83BA1));
				OnPropertyChanged((string)hv5L3qesTe5VoDWYNdBj(0x22BF43FC ^ 0x22BFD2D8));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlligatorLipsShift")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "LipsShift")]
	public int LipsShift
	{
		get
		{
			return YQniReWIESD;
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
					if (YQniReWIESD == num3)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee != 0)
						{
							num2 = 0;
						}
						break;
					}
					YQniReWIESD = num3;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6EC99CAF ^ 0x6EC93E83));
					return;
				case 0:
					return;
				}
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
			return a4YiRsoEh4D;
		}
		set
		{
			if (indicatorMaType != a4YiRsoEh4D)
			{
				a4YiRsoEh4D = indicatorMaType;
				OnPropertyChanged((string)hv5L3qesTe5VoDWYNdBj(0x7DB10E6E ^ 0x7DB18916));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xECA3F28 ^ 0xECAAE0C));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
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

	[DataMember(Name = "Source")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public IndicatorSourceBase Source
	{
		get
		{
			IndicatorSourceBase indicatorSourceBase = pvgiRXWV2rv;
			if (indicatorSourceBase == null)
			{
				StockSource obj = new StockSource
				{
					SelectedSeries = (string)hv5L3qesTe5VoDWYNdBj(-671204305 ^ -671174053)
				};
				IndicatorSourceBase indicatorSourceBase2 = obj;
				pvgiRXWV2rv = obj;
				indicatorSourceBase = indicatorSourceBase2;
			}
			return indicatorSourceBase;
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
					if (indicatorSourceBase == pvgiRXWV2rv)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
						{
							num2 = 0;
						}
						break;
					}
					pvgiRXWV2rv = indicatorSourceBase;
					OnPropertyChanged((string)hv5L3qesTe5VoDWYNdBj(-1848952786 ^ -1848922040));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x706541F3 ^ 0x7065D0D7));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DisplayName("Jaw")]
	[DataMember(Name = "JawSeries")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries JawSeries
	{
		get
		{
			return ujxiRcQ8X85 ?? (ujxiRcQ8X85 = new ChartSeries(ChartSeriesType.Line, new XColor(O1uA68esyWI5Zu1kOUeB())));
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
					ujxiRcQ8X85 = objA;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4297C3EB ^ 0x429761A9));
					return;
				case 1:
					if (object.Equals(objA, ujxiRcQ8X85))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("Teeth")]
	[DataMember(Name = "TeethSeries")]
	public ChartSeries TeethSeries
	{
		get
		{
			return ESmiRjctgVE ?? (ESmiRjctgVE = new ChartSeries(ChartSeriesType.Line, new XColor(Colors.Red)));
		}
		set
		{
			if (!object.Equals(chartSeries, ESmiRjctgVE))
			{
				ESmiRjctgVE = chartSeries;
				OnPropertyChanged((string)hv5L3qesTe5VoDWYNdBj(-203064540 ^ -203040388));
			}
		}
	}

	[DataMember(Name = "LipsSeries")]
	[DisplayName("Lips")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries LipsSeries
	{
		get
		{
			return xYoiRErYhMC ?? (xYoiRErYhMC = new ChartSeries(ChartSeriesType.Line, new XColor(D8W44mesZpGfmXMWnYor())));
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
					if (!object.Equals(objA, xYoiRErYhMC))
					{
						xYoiRErYhMC = objA;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x32DEA4F1 ^ 0x32DE0683));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public id2vGUigFY1icECMkCjx()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		JawPeriod = 13;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				LipsShift = 3;
				MaType = IndicatorMaType.SMMA;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
				{
					num = 1;
				}
				break;
			case 3:
				JawShift = 8;
				TeethPeriod = 8;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				TeethShift = 5;
				LipsPeriod = 5;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	protected override void Execute()
	{
		int num = 2;
		int num2 = num;
		double[] data3 = default(double[]);
		double[] array = default(double[]);
		double[] data = default(double[]);
		double[] data2 = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 4:
				data3 = base.Helper.ShiftData(data3, LipsShift);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				CNgJOCesr62rh4ycwgTF(base.Series, new IndicatorSeriesData(data, JawSeries), new IndicatorSeriesData(data2, TeethSeries), new IndicatorSeriesData(data3, LipsSeries));
				return;
			case 1:
				if (array == null)
				{
					num2 = 3;
					break;
				}
				data = base.Helper.MovingAverage(MaType, array, JawPeriod);
				data = base.Helper.ShiftData(data, JawShift);
				data2 = base.Helper.MovingAverage(MaType, array, TeethPeriod);
				data2 = base.Helper.ShiftData(data2, TeethShift);
				data3 = (double[])mTePUGesCHQZX4BYD2cn(base.Helper, MaType, array, LipsPeriod);
				num2 = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			case 2:
				array = (double[])LNjgUqesVpusNY52HmRh(Source, base.Helper);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
				{
					num2 = 1;
				}
				break;
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
			case 1:
				JawSeries.AllColors = P_0.GetNextColor();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				V5fCvoesKb1Hk5wHLnUS(TeethSeries, P_0.GetNextColor());
				V5fCvoesKb1Hk5wHLnUS(LipsSeries, l4lW2Lesm5Ol7lFqiV6o(P_0));
				base.ApplyColors(P_0);
				return;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		id2vGUigFY1icECMkCjx id2vGUigFY1icECMkCjx2 = (id2vGUigFY1icECMkCjx)P_0;
		JawPeriod = id2vGUigFY1icECMkCjx2.JawPeriod;
		JawShift = DSdhuXesh4XjtwhfxDwc(id2vGUigFY1icECMkCjx2);
		TeethPeriod = id2vGUigFY1icECMkCjx2.TeethPeriod;
		TeethShift = id2vGUigFY1icECMkCjx2.TeethShift;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				MaType = wIuQxneswe2RGLWt5Tv0(id2vGUigFY1icECMkCjx2);
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
				{
					num = 2;
				}
				break;
			default:
				LipsPeriod = id2vGUigFY1icECMkCjx2.LipsPeriod;
				num = 5;
				break;
			case 3:
				if (!P_1)
				{
					Source = id2vGUigFY1icECMkCjx2.Source.CloneSource();
				}
				JawSeries.CopyTheme((ChartSeries)uXEEVUes755grMXrdeft(id2vGUigFY1icECMkCjx2));
				num = 4;
				break;
			case 1:
				base.CopyTemplate(P_0, P_1);
				return;
			case 4:
				bP29nQesAHCWY8bdlMcL(TeethSeries, EAwRLVes8PgmDtvPWsCR(id2vGUigFY1icECMkCjx2));
				bP29nQesAHCWY8bdlMcL(LipsSeries, dgC5yfesPQsUqiwi5lKg(id2vGUigFY1icECMkCjx2));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
				{
					num = 1;
				}
				break;
			case 5:
				LipsShift = id2vGUigFY1icECMkCjx2.LipsShift;
				num = 2;
				break;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)hv5L3qesTe5VoDWYNdBj(-602153869 ^ -602177799), base.Name, MaType, Source, JawPeriod, TeethPeriod, LipsPeriod);
	}

	static id2vGUigFY1icECMkCjx()
	{
		T46DHhesJCWoveHQ8jaO();
		HFqcxgesFelWWOCGjtKn();
	}

	internal static object hv5L3qesTe5VoDWYNdBj(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool ctF3iVestgQEtDD4E6Zg()
	{
		return BPhwrZesWkXZh4PfVkWu == null;
	}

	internal static id2vGUigFY1icECMkCjx sa6Kt1esUKUWLxFMTArV()
	{
		return BPhwrZesWkXZh4PfVkWu;
	}

	internal static Color O1uA68esyWI5Zu1kOUeB()
	{
		return Colors.Blue;
	}

	internal static Color D8W44mesZpGfmXMWnYor()
	{
		return Colors.Green;
	}

	internal static object LNjgUqesVpusNY52HmRh(object P_0, object P_1)
	{
		return ((IndicatorSourceBase)P_0).GetSeries((IndicatorsHelper)P_1);
	}

	internal static object mTePUGesCHQZX4BYD2cn(object P_0, IndicatorMaType maType, object P_2, int period)
	{
		return ((IndicatorsHelper)P_0).MovingAverage(maType, (double[])P_2, period);
	}

	internal static void CNgJOCesr62rh4ycwgTF(object P_0, object P_1, object P_2, object P_3)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1, (IndicatorSeriesData)P_2, (IndicatorSeriesData)P_3);
	}

	internal static void V5fCvoesKb1Hk5wHLnUS(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static XColor l4lW2Lesm5Ol7lFqiV6o(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static int DSdhuXesh4XjtwhfxDwc(object P_0)
	{
		return ((id2vGUigFY1icECMkCjx)P_0).JawShift;
	}

	internal static IndicatorMaType wIuQxneswe2RGLWt5Tv0(object P_0)
	{
		return ((id2vGUigFY1icECMkCjx)P_0).MaType;
	}

	internal static object uXEEVUes755grMXrdeft(object P_0)
	{
		return ((id2vGUigFY1icECMkCjx)P_0).JawSeries;
	}

	internal static object EAwRLVes8PgmDtvPWsCR(object P_0)
	{
		return ((id2vGUigFY1icECMkCjx)P_0).TeethSeries;
	}

	internal static void bP29nQesAHCWY8bdlMcL(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static object dgC5yfesPQsUqiwi5lKg(object P_0)
	{
		return ((id2vGUigFY1icECMkCjx)P_0).LipsSeries;
	}

	internal static void T46DHhesJCWoveHQ8jaO()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void HFqcxgesFelWWOCGjtKn()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
