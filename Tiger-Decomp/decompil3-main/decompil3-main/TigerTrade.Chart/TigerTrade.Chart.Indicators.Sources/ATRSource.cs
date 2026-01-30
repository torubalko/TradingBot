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

[DataContract(Name = "ATRSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("ATR", Type = typeof(ATRSource))]
public sealed class ATRSource : IndicatorSourceBase
{
	private int _period;

	internal static ATRSource v5xRKHeo6YrIxRsT2Ewj;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return _period;
		}
		set
		{
			value = Math.Max(1, value);
			if (value != _period)
			{
				_period = value;
				OnPropertyChanged((string)TSwZr3eoqdPjwSQYVxPT(-1962651919 ^ -1962620601));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
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

	public ATRSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 14;
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-82860344 ^ -82891012);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
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
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x735715F1 ^ 0x73579DC5) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return (double[])GLv68FeoIcxFiAr1w73o(helper, _period);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (!(source is ATRSource aTRSource))
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
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
			base.SelectedSeries = aTRSource.SelectedSeries;
			Period = qf9ahJeoWa2VwG6Uov8G(aTRSource);
		}
	}

	public override string ToString()
	{
		if (string.IsNullOrEmpty(base.SelectedSeries))
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x746ED405 ^ 0x746E53E1);
		}
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2C8374E4 ^ 0x2C83F314), base.SelectedSeries, Period);
	}

	static ATRSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		drePn8eotCyIEOoci0SU();
	}

	internal static object TSwZr3eoqdPjwSQYVxPT(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool ffHfG1eoMu0oCBCUxeoY()
	{
		return v5xRKHeo6YrIxRsT2Ewj == null;
	}

	internal static ATRSource dWLZ7QeoOQ5CqbfQDIjh()
	{
		return v5xRKHeo6YrIxRsT2Ewj;
	}

	internal static object GLv68FeoIcxFiAr1w73o(object P_0, int period)
	{
		return ((IndicatorsHelper)P_0).ATR(period);
	}

	internal static int qf9ahJeoWa2VwG6Uov8G(object P_0)
	{
		return ((ATRSource)P_0).Period;
	}

	internal static void drePn8eotCyIEOoci0SU()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
