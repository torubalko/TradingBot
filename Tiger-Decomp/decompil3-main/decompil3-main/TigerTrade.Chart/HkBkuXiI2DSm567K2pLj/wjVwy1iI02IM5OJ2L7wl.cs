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

namespace HkBkuXiI2DSm567K2pLj;

[Indicator("ChaikinOscillator", "ChaikinOscillator", false, Type = typeof(wjVwy1iI02IM5OJ2L7wl))]
[DataContract(Name = "ChaikinOscillatorIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class wjVwy1iI02IM5OJ2L7wl : IndicatorBase
{
	private int icoiIippCxJ;

	private int FjxiIlgJtVD;

	private IndicatorMaType rImiI4cJ8hU;

	private ChartSeries llUiIDVLTGP;

	private static wjVwy1iI02IM5OJ2L7wl xfd5BMejghQDrubPZmah;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShortPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "ShortPeriod")]
	public int ShortPeriod
	{
		get
		{
			return icoiIippCxJ;
		}
		set
		{
			num = Math.Max(1, num);
			int num2;
			if (num == icoiIippCxJ)
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
				{
					num2 = 0;
				}
			}
			else
			{
				icoiIippCxJ = num;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 1:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-82860344 ^ -82894450));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x68DEE0F ^ 0x68D7F2B));
				break;
			case 0:
				break;
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLongPeriod")]
	[DataMember(Name = "LongPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int LongPeriod
	{
		get
		{
			return FjxiIlgJtVD;
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
					num3 = pR7PZkejMJoegoNoe4nn(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (num3 == FjxiIlgJtVD)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
					{
						num2 = 2;
					}
					continue;
				}
				FjxiIlgJtVD = num3;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1878953018 ^ -1878920026));
				OnPropertyChanged((string)FYMqjQejO94ksB2x0180(0x78D396D8 ^ 0x78D307FC));
				return;
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
			return rImiI4cJ8hU;
		}
		set
		{
			if (indicatorMaType != rImiI4cJ8hU)
			{
				rImiI4cJ8hU = indicatorMaType;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x404ED0BE ^ 0x404E57C6));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f != 0)
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

	[DataMember(Name = "CO")]
	[DisplayName("CO")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries COSeries
	{
		get
		{
			return llUiIDVLTGP ?? (llUiIDVLTGP = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
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
					if (object.Equals(objA, llUiIDVLTGP))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
						{
							num2 = 0;
						}
						break;
					}
					llUiIDVLTGP = objA;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1435596783 ^ -1435619361));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> s5jiIafEUSm => base.Levels;

	public wjVwy1iI02IM5OJ2L7wl()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		ShortPeriod = 3;
		LongPeriod = 10;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				MaType = IndicatorMaType.EMA;
				base.Levels.Add(new ChartLevel(0m, nTZIcTejIl2oGLXKoNnB(BT6JOwejqvZgGU1ib9X6())));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		double[] data = (double[])atTpTbejWoteZaxDQPrx(base.Helper, MaType, ShortPeriod, LongPeriod);
		base.Series.Add(new IndicatorSeriesData(data, COSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		COSeries.AllColors = Yd2cZrejt31SpisPcVx7(P_0);
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		wjVwy1iI02IM5OJ2L7wl wjVwy1iI02IM5OJ2L7wl2 = (wjVwy1iI02IM5OJ2L7wl)P_0;
		ShortPeriod = wjVwy1iI02IM5OJ2L7wl2.ShortPeriod;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
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
			LongPeriod = MZxYTnejUQ6EqEpcCuuQ(wjVwy1iI02IM5OJ2L7wl2);
			MaType = sVb9rwejT4JnvDl2pTSg(wjVwy1iI02IM5OJ2L7wl2);
			JlCIG8ejyZgVeCUgDeiG(COSeries, wjVwy1iI02IM5OJ2L7wl2.COSeries);
			base.CopyTemplate(P_0, P_1);
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		return (string)GG1HfCejZ7NNx5oeAJ7O(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1801468030 ^ -1801502702), base.Name, ShortPeriod, LongPeriod);
	}

	static wjVwy1iI02IM5OJ2L7wl()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		zuJFaiejV1UOYOI2wowg();
	}

	internal static bool erv9pfejRLdQTG7P9J1Z()
	{
		return xfd5BMejghQDrubPZmah == null;
	}

	internal static wjVwy1iI02IM5OJ2L7wl FINQh3ej6fi8vccHAK0n()
	{
		return xfd5BMejghQDrubPZmah;
	}

	internal static int pR7PZkejMJoegoNoe4nn(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object FYMqjQejO94ksB2x0180(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static Color BT6JOwejqvZgGU1ib9X6()
	{
		return Colors.Gray;
	}

	internal static XColor nTZIcTejIl2oGLXKoNnB(Color P_0)
	{
		return P_0;
	}

	internal static object atTpTbejWoteZaxDQPrx(object P_0, IndicatorMaType maType, int shortPeriod, int longPeriod)
	{
		return ((IndicatorsHelper)P_0).CO(maType, shortPeriod, longPeriod);
	}

	internal static XColor Yd2cZrejt31SpisPcVx7(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static int MZxYTnejUQ6EqEpcCuuQ(object P_0)
	{
		return ((wjVwy1iI02IM5OJ2L7wl)P_0).LongPeriod;
	}

	internal static IndicatorMaType sVb9rwejT4JnvDl2pTSg(object P_0)
	{
		return ((wjVwy1iI02IM5OJ2L7wl)P_0).MaType;
	}

	internal static void JlCIG8ejyZgVeCUgDeiG(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static object GG1HfCejZ7NNx5oeAJ7O(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void zuJFaiejV1UOYOI2wowg()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
