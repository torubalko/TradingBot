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

[IndicatorSource("ChaikinMoneyFlow", Type = typeof(ChaikinMoneyFlowSource))]
[DataContract(Name = "ChaikinMoneyFlowSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class ChaikinMoneyFlowSource : IndicatorSourceBase
{
	private int _period;

	internal static ChaikinMoneyFlowSource H00WPVevRHtsZkMD2uVo;

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
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1306877528 ^ -1306909154));
			}
		}
	}

	public ChaikinMoneyFlowSource()
	{
		aNKMUKevOV08PIXsoMx1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Period = 21;
		base.SelectedSeries = (string)Ex0orwevqJvpK5RBb08S(-520155535 ^ -520124631);
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1583344314 ^ -1583309794) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.CMF(Period);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (source is ChaikinMoneyFlowSource chaikinMoneyFlowSource)
		{
			base.SelectedSeries = chaikinMoneyFlowSource.SelectedSeries;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Period = r1wv7revI7gcP4ZWouZS(chaikinMoneyFlowSource);
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5CD4F15 ^ 0x5CDC669), Period);
	}

	static ChaikinMoneyFlowSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool wyquaGev6QCjxE7EJ2fP()
	{
		return H00WPVevRHtsZkMD2uVo == null;
	}

	internal static ChaikinMoneyFlowSource NGaHewevMRxrdVjJTXsF()
	{
		return H00WPVevRHtsZkMD2uVo;
	}

	internal static void aNKMUKevOV08PIXsoMx1()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object Ex0orwevqJvpK5RBb08S(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static int r1wv7revI7gcP4ZWouZS(object P_0)
	{
		return ((ChaikinMoneyFlowSource)P_0).Period;
	}
}
