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

[IndicatorSource("BearsPower", Type = typeof(BearsPowerSource))]
[DataContract(Name = "BearsPowerSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class BearsPowerSource : IndicatorSourceBase
{
	private int _period;

	internal static BearsPowerSource UrKMiEeoU7M2U9MaMU4j;

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
			if (value == _period)
			{
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6F7F734B ^ 0x6F7FF4FD));
			}
		}
	}

	public BearsPowerSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 13;
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-165474503 ^ -165443833);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
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
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1736566656 ^ -1736535874) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.BearsPower(Period);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (source is BearsPowerSource bearsPowerSource)
		{
			base.SelectedSeries = (string)iMVaeeeoZpIiU1VdN9PI(bearsPowerSource);
			Period = bearsPowerSource.Period;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
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
		return string.Format((string)nxolIAeoVYXXskYebYJV(0x6E2DFBED ^ 0x6E2D7C1D), base.Name, Period);
	}

	static BearsPowerSource()
	{
		BxYEO1eoC0HECG8Ov0Cy();
		HBrTLpeorgR86l2OLRjf();
	}

	internal static bool WaUsaaeoT70W7KV9hsab()
	{
		return UrKMiEeoU7M2U9MaMU4j == null;
	}

	internal static BearsPowerSource jX4bhweoyZI2xc30hIkY()
	{
		return UrKMiEeoU7M2U9MaMU4j;
	}

	internal static object iMVaeeeoZpIiU1VdN9PI(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static object nxolIAeoVYXXskYebYJV(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void BxYEO1eoC0HECG8Ov0Cy()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void HBrTLpeorgR86l2OLRjf()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
