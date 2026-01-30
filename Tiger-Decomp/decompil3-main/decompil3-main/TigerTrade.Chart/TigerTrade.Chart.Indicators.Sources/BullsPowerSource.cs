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

[IndicatorSource("BullsPower", Type = typeof(BullsPowerSource))]
[DataContract(Name = "BullsPowerSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class BullsPowerSource : IndicatorSourceBase
{
	private int _period;

	private static BullsPowerSource eHOGbaeou19f234DbflS;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
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
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)tRJ3KTev2vBfVE7PkhPA(0x68DEE0F ^ 0x68D69B9));
			}
		}
	}

	public BullsPowerSource()
	{
		tyFIDNevHrOXYpm4CRtt();
		base._002Ector();
		Period = 13;
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1047165041 ^ -1047195815);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
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
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-991861155 ^ -991826293) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.BullsPower(Period);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (source is BullsPowerSource bullsPowerSource)
		{
			base.SelectedSeries = (string)s5utEjevf7TQfscWO0VV(bullsPowerSource);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Period = bullsPowerSource.Period;
		}
	}

	public override string ToString()
	{
		return (string)vxSqqgev9AMc3q5KAGJP(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-60853733 ^ -60819989), base.Name, Period);
	}

	static BullsPowerSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object tRJ3KTev2vBfVE7PkhPA(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool teWPxVeozOKK38WKRCwP()
	{
		return eHOGbaeou19f234DbflS == null;
	}

	internal static BullsPowerSource JGREvxev0XUPjM05lmEf()
	{
		return eHOGbaeou19f234DbflS;
	}

	internal static void tyFIDNevHrOXYpm4CRtt()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object s5utEjevf7TQfscWO0VV(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static object vxSqqgev9AMc3q5KAGJP(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
