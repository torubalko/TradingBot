using System.Collections.Generic;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Sources;

[IndicatorSource("WilliamsAD", Type = typeof(WilliamsADSource))]
[DataContract(Name = "WilliamsADSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class WilliamsADSource : IndicatorSourceBase
{
	internal static WilliamsADSource N8pjBKelf20KrFm882WD;

	public WilliamsADSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1461292091 ^ -1461257107);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
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
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--927068468 ^ 0x37417E9C) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.WilliamsAD();
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (source is WilliamsADSource williamsADSource)
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			base.SelectedSeries = williamsADSource.SelectedSeries;
		}
	}

	public override string ToString()
	{
		return base.Name;
	}

	static WilliamsADSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool wQyc3mel9hn8grOs6caA()
	{
		return N8pjBKelf20KrFm882WD == null;
	}

	internal static WilliamsADSource C7aOHJelnm7QIxZ5PC93()
	{
		return N8pjBKelf20KrFm882WD;
	}
}
