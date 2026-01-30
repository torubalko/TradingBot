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
using TigerTrade.Dx;

namespace ovLvigiOvhEdxUN6XmWE;

[DataContract(Name = "AroonIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("Aroon", "Aroon", false, Type = typeof(OxyaN3iOougA2J7Z0VGl))]
internal sealed class OxyaN3iOougA2J7Z0VGl : IndicatorBase
{
	private int w7fiOkYwQIp;

	private ChartSeries lwDiO1TYmpr;

	private ChartSeries kWaiO5vB0IB;

	internal static OxyaN3iOougA2J7Z0VGl exVUbOeXuikAfYf0dF9E;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return w7fiOkYwQIp;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == w7fiOkYwQIp)
			{
				return;
			}
			w7fiOkYwQIp = num;
			int num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xB15786A ^ 0xB15FFDC));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					OnPropertyChanged((string)lEyhpBec2XR1kWEliVpG(-1841489831 ^ -1841460867));
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "AroonUp")]
	[DisplayName("Up")]
	public ChartSeries AroonUpSeries
	{
		get
		{
			return lwDiO1TYmpr ?? (lwDiO1TYmpr = new ChartSeries(ChartSeriesType.Line, A6QdUcecHA9LEqWS2h3y()));
		}
		private set
		{
			if (!SNSP1gecfE63Aav7d0tI(chartSeries, lwDiO1TYmpr))
			{
				lwDiO1TYmpr = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)lEyhpBec2XR1kWEliVpG(0xC1DDB3B ^ 0xC1D7EE7));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("Down")]
	[DataMember(Name = "AroonDown")]
	public ChartSeries AroonDownSeries
	{
		get
		{
			return kWaiO5vB0IB ?? (kWaiO5vB0IB = new ChartSeries(ChartSeriesType.Line, Colors.Red));
		}
		private set
		{
			if (!SNSP1gecfE63Aav7d0tI(chartSeries, kWaiO5vB0IB))
			{
				kWaiO5vB0IB = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x769C7931 ^ 0x769CDCCB));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> MebiONdfPDl => base.Levels;

	public OxyaN3iOougA2J7Z0VGl()
	{
		kRGuNWec9iDSIO0ak3HA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Period = 14;
	}

	protected override void Execute()
	{
		base.Helper.Aroon(Period, out var aroonUp, out var aroonDown);
		Gw11J2ecnIDgUuliWgmG(base.Series, new IndicatorSeriesData(aroonUp, AroonUpSeries), new IndicatorSeriesData(aroonDown, AroonDownSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		ELYEBqecYAHuyIrLMZQZ(AroonUpSeries, KIxpEXecG0m40XKLRBS4(P_0));
		AroonDownSeries.AllColors = P_0.GetNextColor();
		base.ApplyColors(P_0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		OxyaN3iOougA2J7Z0VGl oxyaN3iOougA2J7Z0VGl = (OxyaN3iOougA2J7Z0VGl)P_0;
		Period = fO5XSVecoqGsMbPo1TOa(oxyaN3iOougA2J7Z0VGl);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base.CopyTemplate(P_0, P_1);
				return;
			}
			AroonUpSeries.CopyTheme(oxyaN3iOougA2J7Z0VGl.AroonUpSeries);
			sb3B7Zecvj01XpmuCsQn(AroonDownSeries, oxyaN3iOougA2J7Z0VGl.AroonDownSeries);
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
			{
				num = 0;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-671204305 ^ -671171617), base.Name, Period);
	}

	static OxyaN3iOougA2J7Z0VGl()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object lEyhpBec2XR1kWEliVpG(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool RABwJWeXz0PX5Ly3coLa()
	{
		return exVUbOeXuikAfYf0dF9E == null;
	}

	internal static OxyaN3iOougA2J7Z0VGl YRgtwAec0IUNlb7HARpu()
	{
		return exVUbOeXuikAfYf0dF9E;
	}

	internal static Color A6QdUcecHA9LEqWS2h3y()
	{
		return Colors.Green;
	}

	internal static bool SNSP1gecfE63Aav7d0tI(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void kRGuNWec9iDSIO0ak3HA()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static void Gw11J2ecnIDgUuliWgmG(object P_0, object P_1, object P_2)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1, (IndicatorSeriesData)P_2);
	}

	internal static XColor KIxpEXecG0m40XKLRBS4(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static void ELYEBqecYAHuyIrLMZQZ(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static int fO5XSVecoqGsMbPo1TOa(object P_0)
	{
		return ((OxyaN3iOougA2J7Z0VGl)P_0).Period;
	}

	internal static void sb3B7Zecvj01XpmuCsQn(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}
}
