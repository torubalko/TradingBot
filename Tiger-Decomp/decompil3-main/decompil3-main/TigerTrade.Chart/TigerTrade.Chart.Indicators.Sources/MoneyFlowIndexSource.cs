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

[IndicatorSource("MoneyFlowIndex", Type = typeof(MoneyFlowIndexSource))]
[DataContract(Name = "MoneyFlowIndexSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class MoneyFlowIndexSource : IndicatorSourceBase
{
	private int _period;

	private static MoneyFlowIndexSource UgkMgYealxokoDIxPlNK;

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
			value = Math.Max(1, value);
			if (value != _period)
			{
				_period = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--500511424 ^ 0x1DD5B576));
			}
		}
	}

	public MoneyFlowIndexSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 14;
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xB15786A ^ 0xB15F40A);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
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
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--18459671 ^ 0x1192077) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.MFI(Period);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (source is MoneyFlowIndexSource moneyFlowIndexSource)
		{
			base.SelectedSeries = moneyFlowIndexSource.SelectedSeries;
			Period = moneyFlowIndexSource.Period;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
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

	public override string ToString()
	{
		return string.Format((string)aditteeabhZP65LBGpiE(-1435596783 ^ -1435627551), base.Name, Period);
	}

	static MoneyFlowIndexSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		RpFM10eaNms1JIBSnIop();
	}

	internal static bool be1NQrea4HZPLGtDnO6S()
	{
		return UgkMgYealxokoDIxPlNK == null;
	}

	internal static MoneyFlowIndexSource ySxO6FeaDo726C2HSZcp()
	{
		return UgkMgYealxokoDIxPlNK;
	}

	internal static object aditteeabhZP65LBGpiE(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void RpFM10eaNms1JIBSnIop()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
