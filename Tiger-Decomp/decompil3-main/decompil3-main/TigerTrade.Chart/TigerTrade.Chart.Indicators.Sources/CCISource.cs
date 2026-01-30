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

[IndicatorSource("CCI", Type = typeof(CCISource))]
[DataContract(Name = "CCISource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class CCISource : IndicatorSourceBase
{
	private int _period;

	private static CCISource WlIE3BevccJpF03gSOX3;

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
			value = sO8PrCevQcQ81gWUPYI6(1, value);
			if (value == _period)
			{
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7DB10E6E ^ 0x7DB189D8));
			}
		}
	}

	public CCISource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 20;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1416986301 ^ -1417017331);
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x684F243E ^ 0x684FAD70) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.CCI(Period);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (!(source is CCISource cCISource))
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
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
			base.SelectedSeries = cCISource.SelectedSeries;
			Period = cCISource.Period;
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-991861155 ^ -991829587), base.Name, Period);
	}

	static CCISource()
	{
		qQDNWhevdJpALOpJBXcU();
		clt8Rcevg5BryDb1Hw4j();
	}

	internal static int sO8PrCevQcQ81gWUPYI6(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool uoOcLNevjSBhr3MAQ7gU()
	{
		return WlIE3BevccJpF03gSOX3 == null;
	}

	internal static CCISource nCiSLfevECBnVVk5cgaD()
	{
		return WlIE3BevccJpF03gSOX3;
	}

	internal static void qQDNWhevdJpALOpJBXcU()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void clt8Rcevg5BryDb1Hw4j()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
