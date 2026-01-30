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
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Dx;

namespace tHkBRXiZlGKs0VSsqgJS;

[DataContract(Name = "VolumeOscillatorIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("VolumeOscillator", "VolumeOscillator", false, Type = typeof(YyrTmUiZi0opWy1LKKkZ))]
internal sealed class YyrTmUiZi0opWy1LKKkZ : IndicatorBase
{
	private int Hw1iZeCLtwb;

	private int sv0iZsiKLcs;

	private IndicatorMaType drMiZXCk7CQ;

	private ChartSeries ojsiZcRI0hn;

	internal static YyrTmUiZi0opWy1LKKkZ wIN4KieRlfTAXYAw4iF3;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "ShortPeriod")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShortPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int ShortPeriod
	{
		get
		{
			return Hw1iZeCLtwb;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == Hw1iZeCLtwb)
			{
				return;
			}
			Hw1iZeCLtwb = num;
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5EA8FF2A ^ 0x5EA8786C));
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1251569705 ^ -1251598605));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[DataMember(Name = "LongPeriod")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLongPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int LongPeriod
	{
		get
		{
			return sv0iZsiKLcs;
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
					num3 = Math.Max(1, num3);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (num3 == sv0iZsiKLcs)
					{
						return;
					}
					sv0iZsiKLcs = num3;
					OnPropertyChanged((string)FA2RK7eRbqai9utFjPDZ(-1309555870 ^ -1309588478));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2BD86B18 ^ 0x2BD8FA3C));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 != 0)
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

	[DataMember(Name = "MaType")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public IndicatorMaType MaType
	{
		get
		{
			return drMiZXCk7CQ;
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
					if (indicatorMaType != drMiZXCk7CQ)
					{
						drMiZXCk7CQ = indicatorMaType;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1461949456 ^ -1461916536));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName("VO")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "VO")]
	public ChartSeries VOSeries
	{
		get
		{
			return ojsiZcRI0hn ?? (ojsiZcRI0hn = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
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
					ojsiZcRI0hn = objA;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2056710528 ^ -2056668106));
					return;
				case 1:
					if (object.Equals(objA, ojsiZcRI0hn))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	public List<ChartLevel> iKkiZLG9oHq => base.Levels;

	public YyrTmUiZi0opWy1LKKkZ()
	{
		qeGOq0eRN6650LOMyNn1();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
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
				ShortPeriod = 5;
				LongPeriod = 10;
				MaType = IndicatorMaType.EMA;
				base.Levels.Add(new ChartLevel(0m, Colors.Gray));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void Execute()
	{
		double[] data = (double[])v41rd1eRkaoxyobZQBdf(base.Helper, MaType, ShortPeriod, LongPeriod);
		base.Series.Add(new IndicatorSeriesData(data, VOSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		VOSeries.AllColors = p7IdOReR1OcsFcm8i3It(P_0);
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		YyrTmUiZi0opWy1LKKkZ yyrTmUiZi0opWy1LKKkZ = (YyrTmUiZi0opWy1LKKkZ)P_0;
		ShortPeriod = yyrTmUiZi0opWy1LKKkZ.ShortPeriod;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				MaType = eE2ctPeR5m1wT551EfAc(yyrTmUiZi0opWy1LKKkZ);
				r26l4geRSRPZ6IsLFw0H(VOSeries, yyrTmUiZi0opWy1LKKkZ.VOSeries);
				base.CopyTemplate(P_0, P_1);
				return;
			case 1:
				LongPeriod = yyrTmUiZi0opWy1LKKkZ.LongPeriod;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-203064540 ^ -203031372), base.Name, ShortPeriod, LongPeriod);
	}

	static YyrTmUiZi0opWy1LKKkZ()
	{
		XU7PUkeRxGcK37w8vINu();
		SdbPnWeRLe98thnJr1Ei();
	}

	internal static bool i2qySweR4l0GKJbH2tPV()
	{
		return wIN4KieRlfTAXYAw4iF3 == null;
	}

	internal static YyrTmUiZi0opWy1LKKkZ t7HxeHeRD7AUigf8r4Jr()
	{
		return wIN4KieRlfTAXYAw4iF3;
	}

	internal static object FA2RK7eRbqai9utFjPDZ(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void qeGOq0eRN6650LOMyNn1()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object v41rd1eRkaoxyobZQBdf(object P_0, IndicatorMaType type, int shortN, int longN)
	{
		return ((IndicatorsHelper)P_0).VolumeOscillator(type, shortN, longN);
	}

	internal static XColor p7IdOReR1OcsFcm8i3It(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static IndicatorMaType eE2ctPeR5m1wT551EfAc(object P_0)
	{
		return ((YyrTmUiZi0opWy1LKKkZ)P_0).MaType;
	}

	internal static void r26l4geRSRPZ6IsLFw0H(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static void XU7PUkeRxGcK37w8vINu()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void SdbPnWeRLe98thnJr1Ei()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
