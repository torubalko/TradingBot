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

[IndicatorSource("StandardDeviation", Type = typeof(StandardDeviationSource))]
[DataContract(Name = "StandardDeviationSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class StandardDeviationSource : IndicatorSourceBase
{
	private int _period;

	private IndicatorSourceBase _source;

	private static StandardDeviationSource faHGoEeinttB5jx6WyxW;

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
			value = pgMdBteioGAQWOkk1XW2(1, value);
			if (value == _period)
			{
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 != 0)
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x684F243E ^ 0x684FA388));
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
			return _source ?? (_source = new StockSource());
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
					if (value != _source)
					{
						_source = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1306877528 ^ -1306908210));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public StandardDeviationSource()
	{
		YmXjuCeivCdRMFNPtAfd();
		base._002Ector();
		Period = 20;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.SelectedSeries = (string)Ln2joeeiBYrGTU6II38u(-1346994499 ^ -1346964711);
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-5977659 ^ -6011807) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		double[] series = Source.GetSeries(helper);
		if (series != null)
		{
			return helper.StdDev(series, Period);
		}
		return null;
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		StandardDeviationSource standardDeviationSource = source as StandardDeviationSource;
		int num;
		if (standardDeviationSource != null)
		{
			base.SelectedSeries = standardDeviationSource.SelectedSeries;
			Period = standardDeviationSource.Period;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee != 0)
			{
				num = 1;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 0:
			break;
		case 1:
			Source = ((IndicatorSourceBase)l0mZaieiacg8VcYp5Hhi(standardDeviationSource)).CloneSource();
			break;
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1009517961 ^ -1009551427), Source, Period);
	}

	static StandardDeviationSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		KNbHWgeii9JMk0bLMG5F();
	}

	internal static int pgMdBteioGAQWOkk1XW2(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool M2R6y5eiGnboV8YcXIH2()
	{
		return faHGoEeinttB5jx6WyxW == null;
	}

	internal static StandardDeviationSource CCiB96eiYoRJxsdyffoq()
	{
		return faHGoEeinttB5jx6WyxW;
	}

	internal static void YmXjuCeivCdRMFNPtAfd()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object Ln2joeeiBYrGTU6II38u(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object l0mZaieiacg8VcYp5Hhi(object P_0)
	{
		return ((StandardDeviationSource)P_0).Source;
	}

	internal static void KNbHWgeii9JMk0bLMG5F()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
