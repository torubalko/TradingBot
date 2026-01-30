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

[DataContract(Name = "TRIXSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("TRIX", Type = typeof(TRIXSource))]
public sealed class TRIXSource : IndicatorSourceBase
{
	private int _period;

	private static TRIXSource iGv11peiqCSSsnbnsyw2;

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
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (value != _period)
					{
						_period = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-710503328 ^ -710536234));
					}
					return;
				case 1:
					value = Math.Max(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TRIXSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 18;
		base.SelectedSeries = (string)DsK87peitvmWZWt5wGZS(-839659358 ^ -839688220);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
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
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2017337494 ^ -2017374164) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return (double[])jBMCjveiU3TQoIV2AVSW(helper, Period);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (!(source is TRIXSource tRIXSource))
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 == 0)
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
			base.SelectedSeries = (string)oFMeZYeiTxk1fuDlBYc4(tRIXSource);
			Period = tRIXSource.Period;
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-165474503 ^ -165443383), base.Name, Period);
	}

	static TRIXSource()
	{
		fXUlCieiyqAl1iiuojVs();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool eg8BH9eiI3V3aKPeZ1L1()
	{
		return iGv11peiqCSSsnbnsyw2 == null;
	}

	internal static TRIXSource jb6Iq9eiWYFoLT0FMQJN()
	{
		return iGv11peiqCSSsnbnsyw2;
	}

	internal static object DsK87peitvmWZWt5wGZS(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object jBMCjveiU3TQoIV2AVSW(object P_0, int period)
	{
		return ((IndicatorsHelper)P_0).TRIX(period);
	}

	internal static object oFMeZYeiTxk1fuDlBYc4(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static void fXUlCieiyqAl1iiuojVs()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
