using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Sources;

[DataContract(Name = "AroonSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("Aroon", Type = typeof(AroonSource))]
public sealed class AroonSource : IndicatorSourceBase
{
	private int _period;

	internal static AroonSource jEIOLmeoepW9tYR7hy3p;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Period
	{
		get
		{
			return _period;
		}
		set
		{
			value = Fj70eaeocliaMkAY9PIF(1, value);
			if (value == _period)
			{
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
			else
			{
				_period = value;
				OnPropertyChanged((string)tqyCHjeojr0aK4FSuxe2(--18459671 ^ 0x1192BA1));
			}
		}
	}

	public AroonSource()
	{
		iEj3K0eoExRC0ohBmNmw();
		base._002Ector();
		Period = 14;
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1AB79299 ^ 0x1AB71A95);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string>
		{
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x42D899B5 ^ 0x42D811B9),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-602153869 ^ -602188691)
		};
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		helper.Aroon(Period, out var aroonUp, out var aroonDown);
		string selectedSeries = base.SelectedSeries;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			if (!(selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--737722733 ^ 0x2BF84961)))
			{
				if (IjsXaSeoQ0i4eSksev4L(selectedSeries, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1306877528 ^ -1306908234)))
				{
					return aroonDown;
				}
				return null;
			}
			goto case 1;
		case 1:
			return aroonUp;
		}
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (!(source is AroonSource aroonSource))
		{
			return;
		}
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Period = aroonSource.Period;
				return;
			case 1:
				base.SelectedSeries = aroonSource.SelectedSeries;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		if (crglqaeodlumswjMYNuu(base.SelectedSeries))
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x746ED405 ^ 0x746E53E1);
		}
		return (string)cdJiNBeogv0bD05UWVEw(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-842040449 ^ -842007409), base.SelectedSeries, Period);
	}

	static AroonSource()
	{
		hFh0f1eoRk3CI3OrdwkM();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int Fj70eaeocliaMkAY9PIF(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object tqyCHjeojr0aK4FSuxe2(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool MCTZuweos5fFfCGCa2Mq()
	{
		return jEIOLmeoepW9tYR7hy3p == null;
	}

	internal static AroonSource AKVwMTeoX6uXu3TpSLAH()
	{
		return jEIOLmeoepW9tYR7hy3p;
	}

	internal static void iEj3K0eoExRC0ohBmNmw()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static bool IjsXaSeoQ0i4eSksev4L(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool crglqaeodlumswjMYNuu(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object cdJiNBeogv0bD05UWVEw(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void hFh0f1eoRk3CI3OrdwkM()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
