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

[IndicatorSource("WilliamsR", Type = typeof(WilliamsRSource))]
[DataContract(Name = "WilliamsRSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class WilliamsRSource : IndicatorSourceBase
{
	private int _period;

	internal static WilliamsRSource wKoaCJelGJnitAj6vKoy;

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
			value = q8KQDbelvdmpZMuYnkpM(1, value);
			if (value != _period)
			{
				_period = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1962651919 ^ -1962620601));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
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
	}

	public WilliamsRSource()
	{
		gPycgBelBTR7nuhLUpRV();
		base._002Ector();
		Period = 14;
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1461949456 ^ -1461918672);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
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
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-371631841 ^ -371599649) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.WilliamsR(Period);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (!(source is WilliamsRSource williamsRSource))
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
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
			base.SelectedSeries = williamsRSource.SelectedSeries;
			Period = williamsRSource.Period;
		}
	}

	public override string ToString()
	{
		return (string)JFtZ3Pelam4BMvV55m7p(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1346994499 ^ -1346963123), base.Name, Period);
	}

	static WilliamsRSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int q8KQDbelvdmpZMuYnkpM(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool KhZIMUelY1i7k8eFWiNJ()
	{
		return wKoaCJelGJnitAj6vKoy == null;
	}

	internal static WilliamsRSource PknNc3elokjVrT1RJOY1()
	{
		return wKoaCJelGJnitAj6vKoy;
	}

	internal static void gPycgBelBTR7nuhLUpRV()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object JFtZ3Pelam4BMvV55m7p(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
