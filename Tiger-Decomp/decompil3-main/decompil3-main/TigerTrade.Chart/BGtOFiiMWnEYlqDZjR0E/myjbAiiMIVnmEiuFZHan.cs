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

namespace BGtOFiiMWnEYlqDZjR0E;

[Indicator("ADX", "ADX", false, Type = typeof(myjbAiiMIVnmEiuFZHan))]
[DataContract(Name = "ADXIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class myjbAiiMIVnmEiuFZHan : IndicatorBase
{
	private int zAUiMh2R38R;

	private ChartSeries DA0iMwguM81;

	private ChartSeries JX8iM71Ze2F;

	private ChartSeries vXOiM85l1yk;

	internal static myjbAiiMIVnmEiuFZHan RF1jsyeXg8r72FLCpB0V;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	public int Period
	{
		get
		{
			return zAUiMh2R38R;
		}
		set
		{
			num = jP2ZyieXMwPWRg1aiAlI(1, num);
			int num2;
			if (num == zAUiMh2R38R)
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
				{
					num2 = 0;
				}
			}
			else
			{
				zAUiMh2R38R = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6D18F862 ^ 0x6D187FD4));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc != 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 1:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2123795572 ^ -2123767128));
				break;
			case 0:
				break;
			}
		}
	}

	[DataMember(Name = "ADX")]
	[DisplayName("ADX")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries ADXSeries
	{
		get
		{
			return DA0iMwguM81 ?? (DA0iMwguM81 = new ChartSeries(ChartSeriesType.Line, zaTGYveXOxR1cPdksjU0(Colors.Blue)));
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
				case 0:
					return;
				case 1:
					if (!jNB7VQeXqELD3f7u3lm4(chartSeries, DA0iMwguM81))
					{
						DA0iMwguM81 = chartSeries;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-45476899 ^ -45435227));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "PlusDI")]
	[DisplayName("+DI")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries PlusDISeries
	{
		get
		{
			return JX8iM71Ze2F ?? (JX8iM71Ze2F = new ChartSeries(ChartSeriesType.Line, zaTGYveXOxR1cPdksjU0(AQ3vdbeXIGejUTLK4Uyy())));
		}
		private set
		{
			if (!object.Equals(chartSeries, JX8iM71Ze2F))
			{
				JX8iM71Ze2F = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)creKTceXWYDL0hOqpCGw(-1380525184 ^ -1380549106));
			}
		}
	}

	[DataMember(Name = "MinusDI")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("-DI")]
	public ChartSeries MinusDISeries
	{
		get
		{
			return vXOiM85l1yk ?? (vXOiM85l1yk = new ChartSeries(ChartSeriesType.Line, Colors.Red));
		}
		private set
		{
			if (!jNB7VQeXqELD3f7u3lm4(chartSeries, vXOiM85l1yk))
			{
				vXOiM85l1yk = chartSeries;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1325234765 ^ -1325260775));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> APyiMmibLZC => base.Levels;

	public myjbAiiMIVnmEiuFZHan()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
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
		double[] data = (double[])EHap6KeXtj95DVchB6MC(base.Helper, Period);
		double[] data2 = base.Helper.PlusDI(Period);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		double[] data3 = (double[])rrJBVfeXUFwlP2T60E7a(base.Helper, Period);
		base.Series.Add(new IndicatorSeriesData(data, ADXSeries), new IndicatorSeriesData(data2, PlusDISeries, (string)creKTceXWYDL0hOqpCGw(-673683647 ^ -673652591)), new IndicatorSeriesData(data3, MinusDISeries, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2108526692 ^ -2108495802)));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		Q7iPqCeXTSIedtQMwVuw(ADXSeries, P_0.GetNextColor());
		PlusDISeries.AllColors = bJPF3veXy2FrcNekuoRw(P_0);
		MinusDISeries.AllColors = P_0.GetNextColor();
		base.ApplyColors(P_0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d != 0)
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
		int num = 1;
		int num2 = num;
		myjbAiiMIVnmEiuFZHan myjbAiiMIVnmEiuFZHan2 = default(myjbAiiMIVnmEiuFZHan);
		while (true)
		{
			switch (num2)
			{
			case 1:
				myjbAiiMIVnmEiuFZHan2 = (myjbAiiMIVnmEiuFZHan)P_0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			Period = pAxyJueXZFg6xfhAvJ5u(myjbAiiMIVnmEiuFZHan2);
			ufeqwgeXVZCLsqixZZbU(ADXSeries, myjbAiiMIVnmEiuFZHan2.ADXSeries);
			ufeqwgeXVZCLsqixZZbU(PlusDISeries, FXNc85eXCNAoFbbbiuKo(myjbAiiMIVnmEiuFZHan2));
			MinusDISeries.CopyTheme(myjbAiiMIVnmEiuFZHan2.MinusDISeries);
			base.CopyTemplate(P_0, P_1);
			num2 = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 != 0)
			{
				num2 = 2;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)creKTceXWYDL0hOqpCGw(-203064540 ^ -203031340), base.Name, Period);
	}

	static myjbAiiMIVnmEiuFZHan()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int jP2ZyieXMwPWRg1aiAlI(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool g21mM6eXRr3DMFAxZleB()
	{
		return RF1jsyeXg8r72FLCpB0V == null;
	}

	internal static myjbAiiMIVnmEiuFZHan F4TMMieX6MfOXb84bebc()
	{
		return RF1jsyeXg8r72FLCpB0V;
	}

	internal static XColor zaTGYveXOxR1cPdksjU0(Color P_0)
	{
		return P_0;
	}

	internal static bool jNB7VQeXqELD3f7u3lm4(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static Color AQ3vdbeXIGejUTLK4Uyy()
	{
		return Colors.Green;
	}

	internal static object creKTceXWYDL0hOqpCGw(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object EHap6KeXtj95DVchB6MC(object P_0, int period)
	{
		return ((IndicatorsHelper)P_0).ADX(period);
	}

	internal static object rrJBVfeXUFwlP2T60E7a(object P_0, int period)
	{
		return ((IndicatorsHelper)P_0).MinusDI(period);
	}

	internal static void Q7iPqCeXTSIedtQMwVuw(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static XColor bJPF3veXy2FrcNekuoRw(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static int pAxyJueXZFg6xfhAvJ5u(object P_0)
	{
		return ((myjbAiiMIVnmEiuFZHan)P_0).Period;
	}

	internal static void ufeqwgeXVZCLsqixZZbU(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static object FXNc85eXCNAoFbbbiuKo(object P_0)
	{
		return ((myjbAiiMIVnmEiuFZHan)P_0).PlusDISeries;
	}
}
