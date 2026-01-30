using System.Collections.Generic;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Sources;

[DataContract(Name = "CumulativeDeltaSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("CumulativeDelta", Type = typeof(CumulativeDeltaSource))]
public sealed class CumulativeDeltaSource : IndicatorSourceBase
{
	internal static CumulativeDeltaSource s1cYG2eBH5eNg86je6h4;

	public CumulativeDeltaSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		base.SelectedSeries = (string)iqVHLEeBnEqSsFQDxC5Z(0x16AD7E76 ^ 0x16ADF79E);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
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
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4220DA8 ^ 0x4228440) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return (double[])ckPeQJeBGZvit93O19dD(helper);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 1;
		int num2 = num;
		CumulativeDeltaSource cumulativeDeltaSource = default(CumulativeDeltaSource);
		while (true)
		{
			switch (num2)
			{
			case 1:
				cumulativeDeltaSource = source as CumulativeDeltaSource;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (cumulativeDeltaSource != null)
				{
					base.SelectedSeries = cumulativeDeltaSource.SelectedSeries;
				}
				return;
			}
		}
	}

	public override string ToString()
	{
		return base.Name;
	}

	static CumulativeDeltaSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object iqVHLEeBnEqSsFQDxC5Z(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool TbhR1heBfEmfYG8nbT7D()
	{
		return s1cYG2eBH5eNg86je6h4 == null;
	}

	internal static CumulativeDeltaSource oLOLgGeB9YTPZfkGJsiF()
	{
		return s1cYG2eBH5eNg86je6h4;
	}

	internal static object ckPeQJeBGZvit93O19dD(object P_0)
	{
		return ((IndicatorsHelper)P_0).CumDelta();
	}
}
