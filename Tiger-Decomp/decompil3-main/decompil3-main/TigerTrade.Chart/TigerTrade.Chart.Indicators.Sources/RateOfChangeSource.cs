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

[IndicatorSource("RateOfChange", Type = typeof(RateOfChangeSource))]
[DataContract(Name = "RateOfChangeSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class RateOfChangeSource : IndicatorSourceBase
{
	private int _period;

	private IndicatorSourceBase _source;

	private static RateOfChangeSource yld3JZeamSkBbMKv0JTF;

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
			if (value != _period)
			{
				_period = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x60620FC1 ^ 0x60628877));
			}
		}
	}

	[DataMember(Name = "Source")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public IndicatorSourceBase Source
	{
		get
		{
			return _source ?? (_source = new StockSource());
		}
		set
		{
			if (value != _source)
			{
				_source = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)zFL0XIea7nPDh4VkDGMo(--871424829 ^ 0x33F06B5B));
			}
		}
	}

	public RateOfChangeSource()
	{
		ObNteAea8mMm1h1XWG8a();
		base._002Ector();
		Period = 14;
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--855742383 ^ 0x33011AD1);
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

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-671204305 ^ -671174319) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		double[] array = (double[])EAyV4GeaANmEW30h5Ihm(Source, helper);
		if (array != null)
		{
			return (double[])iUouKXeaPT8lY96IA23b(helper, array, Period);
		}
		return null;
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (source is RateOfChangeSource rateOfChangeSource)
		{
			base.SelectedSeries = rateOfChangeSource.SelectedSeries;
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
				Period = xwbrDkeaJAelO27b9joY(rateOfChangeSource);
				Source = ((IndicatorSourceBase)FFufS2eaFHnddpq4w96v(rateOfChangeSource)).CloneSource();
				break;
			case 0:
				break;
			}
		}
	}

	public override string ToString()
	{
		return (string)DNuiYtea3Qh3sPJwHkD8(zFL0XIea7nPDh4VkDGMo(-1251569705 ^ -1251604409), base.Name, Source, Period);
	}

	static RateOfChangeSource()
	{
		aTmtqveap5mALClg8SlK();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool PwRx9FeahogC6Wk7PBgg()
	{
		return yld3JZeamSkBbMKv0JTF == null;
	}

	internal static RateOfChangeSource IaV0LFeaw3Ix4yeRlqYV()
	{
		return yld3JZeamSkBbMKv0JTF;
	}

	internal static object zFL0XIea7nPDh4VkDGMo(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void ObNteAea8mMm1h1XWG8a()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object EAyV4GeaANmEW30h5Ihm(object P_0, object P_1)
	{
		return ((IndicatorSourceBase)P_0).GetSeries((IndicatorsHelper)P_1);
	}

	internal static object iUouKXeaPT8lY96IA23b(object P_0, object P_1, int period)
	{
		return ((IndicatorsHelper)P_0).ROC((double[])P_1, period);
	}

	internal static int xwbrDkeaJAelO27b9joY(object P_0)
	{
		return ((RateOfChangeSource)P_0).Period;
	}

	internal static object FFufS2eaFHnddpq4w96v(object P_0)
	{
		return ((RateOfChangeSource)P_0).Source;
	}

	internal static object DNuiYtea3Qh3sPJwHkD8(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void aTmtqveap5mALClg8SlK()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
