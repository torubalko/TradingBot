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

[DataContract(Name = "RSISource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("RSI", Type = typeof(RSISource))]
public sealed class RSISource : IndicatorSourceBase
{
	private int _period;

	private IndicatorSourceBase _source;

	private static RSISource XIo2uJeau3wLLtCuNUWX;

	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Period
	{
		get
		{
			return _period;
		}
		set
		{
			value = Math.Max(1, value);
			if (value == _period)
			{
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
			else
			{
				_period = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2BD86B18 ^ 0x2BD8ECAE));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	[DataMember(Name = "Source")]
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
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1606927328 ^ -1606896570));
			}
		}
	}

	public RSISource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 14;
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--134855371 ^ 0x8093751);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
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
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1346994499 ^ -1346964697) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		double[] series = _source.GetSeries(helper);
		if (series != null)
		{
			return (double[])p3ssd5ei2h4M1wAoxxZH(helper, series, _period);
		}
		return null;
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 2;
		int num2 = num;
		RSISource rSISource = default(RSISource);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (rSISource == null)
				{
					return;
				}
				base.SelectedSeries = rSISource.SelectedSeries;
				Period = rSISource.Period;
				Source = rSISource.Source.CloneSource();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				rSISource = source as RSISource;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return (string)F2VqVveiHRaJC4M0il8d(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x37B74BDF ^ 0x37B7CC4F), base.Name, Source, Period);
	}

	static RSISource()
	{
		YNZnhweifDI9rsJ6qxW7();
		N2Ep48ei9HK70PeZ9WfT();
	}

	internal static bool aRuReceazcYZDsc3Miw6()
	{
		return XIo2uJeau3wLLtCuNUWX == null;
	}

	internal static RSISource DcP6Anei0Uv8vrQrGuWp()
	{
		return XIo2uJeau3wLLtCuNUWX;
	}

	internal static object p3ssd5ei2h4M1wAoxxZH(object P_0, object P_1, int period)
	{
		return ((IndicatorsHelper)P_0).RSI((double[])P_1, period);
	}

	internal static object F2VqVveiHRaJC4M0il8d(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void YNZnhweifDI9rsJ6qxW7()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void N2Ep48ei9HK70PeZ9WfT()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
