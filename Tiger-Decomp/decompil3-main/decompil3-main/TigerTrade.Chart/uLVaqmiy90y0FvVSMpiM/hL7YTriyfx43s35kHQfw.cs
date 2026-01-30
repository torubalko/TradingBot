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
using TigerTrade.Chart.Indicators.Collections;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Chart.Indicators.Sources;

namespace uLVaqmiy90y0FvVSMpiM;

[Indicator("StandardDeviation", "StandardDeviation", false, Type = typeof(hL7YTriyfx43s35kHQfw))]
[DataContract(Name = "StandardDeviationIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class hL7YTriyfx43s35kHQfw : IndicatorBase
{
	private int l2wiyly3Ydh;

	private IndicatorSourceBase E52iy4uEBsB;

	private ChartSeries KtOiyDSBFNh;

	internal static hL7YTriyfx43s35kHQfw v5vxnAegEhejn139hUr8;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Period
	{
		get
		{
			return l2wiyly3Ydh;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == l2wiyly3Ydh)
			{
				return;
			}
			l2wiyly3Ydh = num;
			OnPropertyChanged((string)CihVkXeggMYMUFvIdHeA(0x735715F1 ^ 0x73579247));
			int num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 != 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--18459671 ^ 0x1193D33));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 != 0)
					{
						num2 = 0;
					}
					break;
				}
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
			return E52iy4uEBsB ?? (E52iy4uEBsB = new StockSource());
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
					if (indicatorSourceBase == E52iy4uEBsB)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a != 0)
						{
							num2 = 0;
						}
						break;
					}
					E52iy4uEBsB = indicatorSourceBase;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-198991962 ^ -199026752));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DisplayName("StdDev")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "StdDev")]
	public ChartSeries StdDevSeries
	{
		get
		{
			return KtOiyDSBFNh ?? (KtOiyDSBFNh = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			if (!object.Equals(chartSeries, KtOiyDSBFNh))
			{
				KtOiyDSBFNh = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)CihVkXeggMYMUFvIdHeA(-1311293279 ^ -1311252407));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	public List<ChartLevel> Df4iyisQCeu => base.Levels;

	public hL7YTriyfx43s35kHQfw()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 20;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void Execute()
	{
		double[] series = Source.GetSeries(base.Helper);
		if (series == null)
		{
			return;
		}
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 != 0)
		{
			num = 0;
		}
		double[] data = default(double[]);
		while (true)
		{
			switch (num)
			{
			default:
				oeLsdhegRdLnVaH8Otv9(base.Series, new IndicatorSeriesData(data, StdDevSeries));
				return;
			case 1:
				data = base.Helper.StdDev(series, Period);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		StdDevSeries.AllColors = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		hL7YTriyfx43s35kHQfw hL7YTriyfx43s35kHQfw2 = (hL7YTriyfx43s35kHQfw)P_0;
		Period = IHpoGReg6Llq8Pxbxfik(hL7YTriyfx43s35kHQfw2);
		int num;
		if (!P_1)
		{
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0048;
		IL_0009:
		switch (num)
		{
		case 1:
			base.CopyTemplate(P_0, P_1);
			return;
		}
		Source = ((IndicatorSourceBase)s5eArvegMEThJF4aAOma(hL7YTriyfx43s35kHQfw2)).CloneSource();
		goto IL_0048;
		IL_0048:
		StdDevSeries.CopyTheme(hL7YTriyfx43s35kHQfw2.StdDevSeries);
		num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	public override string ToString()
	{
		return (string)nuHIGQegOaPHdUi9mJ2h(CihVkXeggMYMUFvIdHeA(-53782092 ^ -53750658), Source, Period);
	}

	static hL7YTriyfx43s35kHQfw()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		iS7ypxegqf98Nd5hgkPk();
	}

	internal static object CihVkXeggMYMUFvIdHeA(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool J0scLkegQk7XRp3n4nWI()
	{
		return v5vxnAegEhejn139hUr8 == null;
	}

	internal static hL7YTriyfx43s35kHQfw yyYy7vegdClmgatuHZJi()
	{
		return v5vxnAegEhejn139hUr8;
	}

	internal static void oeLsdhegRdLnVaH8Otv9(object P_0, object P_1)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1);
	}

	internal static int IHpoGReg6Llq8Pxbxfik(object P_0)
	{
		return ((hL7YTriyfx43s35kHQfw)P_0).Period;
	}

	internal static object s5eArvegMEThJF4aAOma(object P_0)
	{
		return ((hL7YTriyfx43s35kHQfw)P_0).Source;
	}

	internal static object nuHIGQegOaPHdUi9mJ2h(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void iS7ypxegqf98Nd5hgkPk()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
