using System.Collections.Generic;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Sources;

[IndicatorSource("BWMFI", Type = typeof(BWMFISource))]
[DataContract(Name = "BWMFISource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class BWMFISource : IndicatorSourceBase
{
	internal static BWMFISource IOE6QcevnPTY2k7DZYjx;

	public BWMFISource()
	{
		LRpbcuevoLot0xMBAPm5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.SelectedSeries = (string)Xvi0XEevvpENBMKHLT6H(0x37B74BDF ^ 0x37B7C331);
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-602153869 ^ -602188643) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.BWMFI();
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 1;
		int num2 = num;
		BWMFISource bWMFISource = default(BWMFISource);
		while (true)
		{
			switch (num2)
			{
			case 1:
				bWMFISource = source as BWMFISource;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (bWMFISource != null)
				{
					base.SelectedSeries = bWMFISource.SelectedSeries;
				}
				return;
			}
		}
	}

	public override string ToString()
	{
		return base.Name;
	}

	static BWMFISource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void LRpbcuevoLot0xMBAPm5()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object Xvi0XEevvpENBMKHLT6H(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool nexoPbevG5GsJepj5X4r()
	{
		return IOE6QcevnPTY2k7DZYjx == null;
	}

	internal static BWMFISource pKktKoevYx5p3YjxDQe4()
	{
		return IOE6QcevnPTY2k7DZYjx;
	}
}
