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

[DataContract(Name = "CMOSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("CMO", Type = typeof(CMOSource))]
public sealed class CMOSource : IndicatorSourceBase
{
	private int _period;

	private IndicatorSourceBase _source;

	private static CMOSource O8guZJev3klMZRkog7iK;

	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
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
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D313048 ^ 0x2D31B7FE));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	[DataMember(Name = "Source")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public IndicatorSourceBase Source
	{
		get
		{
			return _source ?? (_source = new StockSource());
		}
		set
		{
			if (value != _source)
			{
				_source = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x12620268 ^ 0x12628A0E));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 == 0)
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

	public CMOSource()
	{
		Vg56LfevzVQGhZybmemt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Period = 14;
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7F55E538 ^ 0x7F556CE6);
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-530053095 ^ -530021945) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		int num = 1;
		int num2 = num;
		double[] series = default(double[]);
		while (true)
		{
			switch (num2)
			{
			default:
				if (series != null)
				{
					return helper.CMO(series, Period);
				}
				return null;
			case 1:
				series = Source.GetSeries(helper);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (!(source is CMOSource cMOSource))
		{
			return;
		}
		base.SelectedSeries = cMOSource.SelectedSeries;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 != 0)
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
			Period = cMOSource.Period;
			Source = (IndicatorSourceBase)c4BJrqeB0B7ettn7Vkni(cMOSource.Source);
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)cmdtO3eB2HO9HY9h5q8r(--146713930 ^ 0x8BE2ADA), base.Name, Source, Period);
	}

	static CMOSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool wVUmSqevp5jThpZskoJM()
	{
		return O8guZJev3klMZRkog7iK == null;
	}

	internal static CMOSource hviIhOevubKgFuoqAnJi()
	{
		return O8guZJev3klMZRkog7iK;
	}

	internal static void Vg56LfevzVQGhZybmemt()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object c4BJrqeB0B7ettn7Vkni(object P_0)
	{
		return ((IndicatorSourceBase)P_0).CloneSource();
	}

	internal static object cmdtO3eB2HO9HY9h5q8r(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}
}
