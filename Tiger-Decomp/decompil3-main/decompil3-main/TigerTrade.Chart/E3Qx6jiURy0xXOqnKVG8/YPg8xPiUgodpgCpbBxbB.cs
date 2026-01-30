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

namespace E3Qx6jiURy0xXOqnKVG8;

[DataContract(Name = "MovingAverageIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("MovingAverage", "MovingAverage", true, Type = typeof(YPg8xPiUgodpgCpbBxbB))]
internal sealed class YPg8xPiUgodpgCpbBxbB : IndicatorBase
{
	private int JBQiUZaF7HB;

	private int tOKiUVgaiLD;

	private IndicatorMaType Lh6iUCEtvyu;

	private IndicatorSourceBase MDjiUrbgHnG;

	private ChartSeries kWLiUKiOCtv;

	private static YPg8xPiUgodpgCpbBxbB LHCrDnedoWELcLJBB5S5;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return JBQiUZaF7HB;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (num3 == JBQiUZaF7HB)
					{
						return;
					}
					JBQiUZaF7HB = num3;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					num3 = Math.Max(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
					{
						num2 = 1;
					}
					break;
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-602153869 ^ -602186811));
					OnPropertyChanged((string)PAa9smedaiMx1iVuPG3r(-1311293279 ^ -1311256187));
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShift")]
	[DataMember(Name = "Shift")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Shift
	{
		get
		{
			return tOKiUVgaiLD;
		}
		set
		{
			num = Math.Max(0, num);
			if (num != tOKiUVgaiLD)
			{
				tOKiUVgaiLD = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-225822163 ^ -225799375));
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 != 0)
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
	[DataMember(Name = "MaType")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	public IndicatorMaType MaType
	{
		get
		{
			return Lh6iUCEtvyu;
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
					if (indicatorMaType != Lh6iUCEtvyu)
					{
						Lh6iUCEtvyu = indicatorMaType;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1309555870 ^ -1309588454));
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-671204305 ^ -671175413));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e == 0)
					{
						num2 = 0;
					}
					break;
				}
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
			return MDjiUrbgHnG ?? (MDjiUrbgHnG = new StockSource());
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
					if (indicatorSourceBase == MDjiUrbgHnG)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
						{
							num2 = 0;
						}
						break;
					}
					MDjiUrbgHnG = indicatorSourceBase;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x404ED0BE ^ 0x404E58D8));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x37B74BDF ^ 0x37B7DAFB));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "MA")]
	[DisplayName("MA")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries MASeries
	{
		get
		{
			return kWLiUKiOCtv ?? (kWLiUKiOCtv = new ChartSeries(ChartSeriesType.Line, t3e6SBediEF9dhRJsHiq(Colors.Blue)));
		}
		private set
		{
			if (!object.Equals(objA, kWLiUKiOCtv))
			{
				kWLiUKiOCtv = objA;
				OnPropertyChanged((string)PAa9smedaiMx1iVuPG3r(0x1D7BA1ED ^ 0x1D7B082F));
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

	public YPg8xPiUgodpgCpbBxbB()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 14;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
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
				Shift = 0;
				MaType = IndicatorMaType.EMA;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		double[] array = (double[])hU2oKQedlF4nFJHLw4tt(Source, base.Helper);
		if (array == null)
		{
			return;
		}
		double[] data = (double[])GoAxBEed4yyhEF13cBdZ(base.Helper, MaType, array, Period);
		int num;
		if (Shift > 0)
		{
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_0059;
		IL_0059:
		base.Series.Add(new IndicatorSeriesData(data, MASeries));
		num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 1:
			break;
		case 0:
			return;
		}
		data = base.Helper.ShiftData(data, Shift);
		goto IL_0059;
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		MASeries.AllColors = BTc4HIedDkkFrCSnKPsK(P_0);
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		YPg8xPiUgodpgCpbBxbB yPg8xPiUgodpgCpbBxbB = (YPg8xPiUgodpgCpbBxbB)P_0;
		Period = JeExc1edbCQnhjF1Qrqr(yPg8xPiUgodpgCpbBxbB);
		MaType = yPg8xPiUgodpgCpbBxbB.MaType;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				base.CopyTemplate(P_0, P_1);
				return;
			case 1:
				Source = (IndicatorSourceBase)vN2LJgedNl1qJjRYYC8J(yPg8xPiUgodpgCpbBxbB.Source);
				goto IL_001f;
			case 2:
				{
					if (!P_1)
					{
						num = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce != 0)
						{
							num = 1;
						}
						break;
					}
					goto IL_001f;
				}
				IL_001f:
				MASeries.CopyTheme((ChartSeries)DBiS4DedkSIfWYgqHV9e(yPg8xPiUgodpgCpbBxbB));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x12620268 ^ 0x126285F8), MaType, Source, Period);
	}

	static YPg8xPiUgodpgCpbBxbB()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		R2KDl1ed1PRaIFJE1Ets();
	}

	internal static object PAa9smedaiMx1iVuPG3r(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool quq2cFedvZMcNQ2yIiwk()
	{
		return LHCrDnedoWELcLJBB5S5 == null;
	}

	internal static YPg8xPiUgodpgCpbBxbB j7bjUYedBuDq9hXlJyGc()
	{
		return LHCrDnedoWELcLJBB5S5;
	}

	internal static XColor t3e6SBediEF9dhRJsHiq(Color P_0)
	{
		return P_0;
	}

	internal static object hU2oKQedlF4nFJHLw4tt(object P_0, object P_1)
	{
		return ((IndicatorSourceBase)P_0).GetSeries((IndicatorsHelper)P_1);
	}

	internal static object GoAxBEed4yyhEF13cBdZ(object P_0, IndicatorMaType maType, object P_2, int period)
	{
		return ((IndicatorsHelper)P_0).MovingAverage(maType, (double[])P_2, period);
	}

	internal static XColor BTc4HIedDkkFrCSnKPsK(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static int JeExc1edbCQnhjF1Qrqr(object P_0)
	{
		return ((YPg8xPiUgodpgCpbBxbB)P_0).Period;
	}

	internal static object vN2LJgedNl1qJjRYYC8J(object P_0)
	{
		return ((IndicatorSourceBase)P_0).CloneSource();
	}

	internal static object DBiS4DedkSIfWYgqHV9e(object P_0)
	{
		return ((YPg8xPiUgodpgCpbBxbB)P_0).MASeries;
	}

	internal static void R2KDl1ed1PRaIFJE1Ets()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
