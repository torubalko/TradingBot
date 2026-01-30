using System.Collections.Generic;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Sources;

[DataContract(Name = "ADSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("AD", Type = typeof(ADSource))]
public sealed class ADSource : IndicatorSourceBase
{
	internal static ADSource YBBP9weYu14AcDtAyDcO;

	public ADSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.SelectedSeries = (string)NEt1Yseo2xSJQxXKUkCJ(-837284864 ^ -837252178);
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2BD86B18 ^ 0x2BD8ECB6) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.AD();
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 1;
		int num2 = num;
		ADSource aDSource = default(ADSource);
		while (true)
		{
			switch (num2)
			{
			default:
				if (aDSource != null)
				{
					base.SelectedSeries = (string)pbMO9TeoH9UDgwhshVUk(aDSource);
				}
				return;
			case 1:
				aDSource = source as ADSource;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return base.Name;
	}

	static ADSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		OVKw9ueofSSuh6buek8T();
	}

	internal static object NEt1Yseo2xSJQxXKUkCJ(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool X9Qq5XeYz94GajTciJPl()
	{
		return YBBP9weYu14AcDtAyDcO == null;
	}

	internal static ADSource q57gBSeo0G0Ki01LtVBR()
	{
		return YBBP9weYu14AcDtAyDcO;
	}

	internal static object pbMO9TeoH9UDgwhshVUk(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static void OVKw9ueofSSuh6buek8T()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
