using System.Collections.Generic;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Sources;

[IndicatorSource("OBV", Type = typeof(OBVSource))]
[DataContract(Name = "OBVSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class OBVSource : IndicatorSourceBase
{
	internal static OBVSource O9IlkWeakG5jquuEwZjt;

	public OBVSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.SelectedSeries = (string)ycmqSdeaSI0j0QLmaVip(-2074141628 ^ -2074111804);
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-602153869 ^ -602189581) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return (double[])y4uBAJeaxO3eSDwbtWBa(helper);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (source is OBVSource oBVSource)
		{
			base.SelectedSeries = (string)ma7bvIeaLVQqLHo2sYHk(oBVSource);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
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
		return base.Name;
	}

	static OBVSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object ycmqSdeaSI0j0QLmaVip(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool BdLCimea1MG4JiXdSo6M()
	{
		return O9IlkWeakG5jquuEwZjt == null;
	}

	internal static OBVSource wOHEBDea5jXkDABjejkM()
	{
		return O9IlkWeakG5jquuEwZjt;
	}

	internal static object y4uBAJeaxO3eSDwbtWBa(object P_0)
	{
		return ((IndicatorsHelper)P_0).OBV();
	}

	internal static object ma7bvIeaLVQqLHo2sYHk(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}
}
