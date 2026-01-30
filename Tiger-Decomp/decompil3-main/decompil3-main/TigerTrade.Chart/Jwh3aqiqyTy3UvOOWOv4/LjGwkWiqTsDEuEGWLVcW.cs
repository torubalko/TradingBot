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
using TigerTrade.Dx;

namespace Jwh3aqiqyTy3UvOOWOv4;

[DataContract(Name = "CCIIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("CCI", "CCI", false, Type = typeof(LjGwkWiqTsDEuEGWLVcW))]
internal sealed class LjGwkWiqTsDEuEGWLVcW : IndicatorBase
{
	private int HDQiqhtkXvT;

	private ChartSeries Rspiqw9AN1H;

	private static LjGwkWiqTsDEuEGWLVcW bINK5Pejic7YYYrD1mID;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return HDQiqhtkXvT;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == HDQiqhtkXvT)
			{
				return;
			}
			HDQiqhtkXvT = num;
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 != 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2108526692 ^ -2108490056));
					return;
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1380525184 ^ -1380557770));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[DisplayName("CCI")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "CCI")]
	public ChartSeries CCISeries
	{
		get
		{
			return Rspiqw9AN1H ?? (Rspiqw9AN1H = new ChartSeries(ChartSeriesType.Line, z7V5KBejbewjspncXXtd(V7HpC4ejDBQw2IlbIqu0())));
		}
		private set
		{
			if (!object.Equals(chartSeries, Rspiqw9AN1H))
			{
				Rspiqw9AN1H = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)qYu4weejN8bfFaU5qpsr(--146713930 ^ 0x8BE0AE8));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	public List<ChartLevel> RFkiqmeaL1f => base.Levels;

	public LjGwkWiqTsDEuEGWLVcW()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 20;
		base.Levels.Add(new ChartLevel(100m, Colors.Gray));
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
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
			base.Levels.Add(new ChartLevel(-100m, Colors.Gray));
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
			{
				num = 1;
			}
		}
	}

	protected override void Execute()
	{
		double[] data = base.Helper.CCI(Period);
		base.Series.Add(new IndicatorSeriesData(data, CCISeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		ItJblUej11dL13jb9x4y(CCISeries, N7clU5ejkVLUAU42WbfS(P_0));
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		LjGwkWiqTsDEuEGWLVcW ljGwkWiqTsDEuEGWLVcW = (LjGwkWiqTsDEuEGWLVcW)P_0;
		Period = ljGwkWiqTsDEuEGWLVcW.Period;
		fym0J8ej5PCgGwr3AuMn(CCISeries, ljGwkWiqTsDEuEGWLVcW.CCISeries);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
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
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1736566656 ^ -1736532112), base.Name, Period);
	}

	static LjGwkWiqTsDEuEGWLVcW()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		VQSLXwejSnygso5ETwhl();
	}

	internal static bool D8Fi17ejl3ZOmgD2Da8R()
	{
		return bINK5Pejic7YYYrD1mID == null;
	}

	internal static LjGwkWiqTsDEuEGWLVcW rcBhQOej4yTg54HuRyMH()
	{
		return bINK5Pejic7YYYrD1mID;
	}

	internal static Color V7HpC4ejDBQw2IlbIqu0()
	{
		return Colors.Blue;
	}

	internal static XColor z7V5KBejbewjspncXXtd(Color P_0)
	{
		return P_0;
	}

	internal static object qYu4weejN8bfFaU5qpsr(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static XColor N7clU5ejkVLUAU42WbfS(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static void ItJblUej11dL13jb9x4y(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static void fym0J8ej5PCgGwr3AuMn(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static void VQSLXwejSnygso5ETwhl()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
