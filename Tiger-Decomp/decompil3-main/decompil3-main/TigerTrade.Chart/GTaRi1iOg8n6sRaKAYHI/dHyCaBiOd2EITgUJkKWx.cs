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

namespace GTaRi1iOg8n6sRaKAYHI;

[DataContract(Name = "BearsPowerIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("BearsPower", "BearsPower", false, Type = typeof(dHyCaBiOd2EITgUJkKWx))]
internal sealed class dHyCaBiOd2EITgUJkKWx : IndicatorBase
{
	private int PMliOWv3d0m;

	private ChartSeries jmXiOt4445b;

	private static dHyCaBiOd2EITgUJkKWx h1KhxWecNBe9GZuRr9Cc;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	public int Period
	{
		get
		{
			return PMliOWv3d0m;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == PMliOWv3d0m)
			{
				return;
			}
			PMliOWv3d0m = num;
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1A5F1B9E ^ 0x1A5F9C28));
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-602153869 ^ -602190505));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 != 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[DisplayName("BearsPower")]
	[DataMember(Name = "BearsPower")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries BPSeries
	{
		get
		{
			return jmXiOt4445b ?? (jmXiOt4445b = new ChartSeries(ChartSeriesType.Columns, Q8uwr1ecSqZFwujM6ith(xnVXavec5TpmAYPfhigx())));
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
					jmXiOt4445b = objA;
					OnPropertyChanged((string)ySiNmNecxJA6pGHFUfAw(0x68C7EAE6 ^ 0x68C74CD4));
					return;
				case 1:
					if (object.Equals(objA, jmXiOt4445b))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> AKXiOIVvBHM => base.Levels;

	public dHyCaBiOd2EITgUJkKWx()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 13;
		base.Levels.Add(new ChartLevel(0m, Q8uwr1ecSqZFwujM6ith(Colors.Gray)));
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 == 0)
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
		double[] data = base.Helper.BearsPower(Period);
		dHhncwecL41SJEjkhVif(base.Series, new IndicatorSeriesData(data, BPSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		Sn4HXYece5BfS8W2qi9V(BPSeries, P_0.GetNextColor());
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		dHyCaBiOd2EITgUJkKWx dHyCaBiOd2EITgUJkKWx2 = (dHyCaBiOd2EITgUJkKWx)P_0;
		Period = dHyCaBiOd2EITgUJkKWx2.Period;
		BPSeries.CopyTheme((ChartSeries)DeCxH1ecsBlYn5j0tQjb(dHyCaBiOd2EITgUJkKWx2));
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.CopyTemplate(P_0, P_1);
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-3429745 ^ -3461761), base.Name, Period);
	}

	static dHyCaBiOd2EITgUJkKWx()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		CBpc2TecXdGTNcXHuWKN();
	}

	internal static bool zAsqbKeckp0upb6wd5WQ()
	{
		return h1KhxWecNBe9GZuRr9Cc == null;
	}

	internal static dHyCaBiOd2EITgUJkKWx r6rui4ec1uJ67JsiyGYl()
	{
		return h1KhxWecNBe9GZuRr9Cc;
	}

	internal static Color xnVXavec5TpmAYPfhigx()
	{
		return Colors.Blue;
	}

	internal static XColor Q8uwr1ecSqZFwujM6ith(Color P_0)
	{
		return P_0;
	}

	internal static object ySiNmNecxJA6pGHFUfAw(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void dHhncwecL41SJEjkhVif(object P_0, object P_1)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1);
	}

	internal static void Sn4HXYece5BfS8W2qi9V(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static object DeCxH1ecsBlYn5j0tQjb(object P_0)
	{
		return ((dHyCaBiOd2EITgUJkKWx)P_0).BPSeries;
	}

	internal static void CBpc2TecXdGTNcXHuWKN()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
