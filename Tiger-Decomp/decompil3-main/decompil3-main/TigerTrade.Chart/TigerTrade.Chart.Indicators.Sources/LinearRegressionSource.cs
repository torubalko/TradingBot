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

[IndicatorSource("LinearRegression", Type = typeof(LinearRegressionSource))]
[DataContract(Name = "LinearRegressionSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class LinearRegressionSource : IndicatorSourceBase
{
	private int _period;

	private IndicatorSourceBase _source;

	private static LinearRegressionSource MSFaRMeBUy8P3xfsPEtQ;

	[DataMember(Name = "Period")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	public int Period
	{
		get
		{
			return _period;
		}
		set
		{
			value = MAX5mQeBZSRCaLCRZhyd(1, value);
			if (value == _period)
			{
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd != 0)
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5EA8FF2A ^ 0x5EA8789C));
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
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (value != _source)
					{
						_source = value;
						OnPropertyChanged((string)okh3YGeBVI4VH9Omal17(0xB15786A ^ 0xB15F00C));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LinearRegressionSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 14;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.SelectedSeries = (string)okh3YGeBVI4VH9Omal17(-1192989954 ^ -1192959616);
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1325234765 ^ -1325265203) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		double[] series = _source.GetSeries(helper);
		if (series != null)
		{
			return (double[])L4cnGNeBCGUi40gkrFl2(helper, series, _period);
		}
		return null;
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 2;
		int num2 = num;
		LinearRegressionSource linearRegressionSource = default(LinearRegressionSource);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (linearRegressionSource == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 == 0)
					{
						num2 = 0;
					}
					break;
				}
				base.SelectedSeries = linearRegressionSource.SelectedSeries;
				Period = linearRegressionSource.Period;
				Source = linearRegressionSource.Source.CloneSource();
				return;
			case 2:
				linearRegressionSource = source as LinearRegressionSource;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)okh3YGeBVI4VH9Omal17(0x130FEA25 ^ 0x130F61AB), Source, Period);
	}

	static LinearRegressionSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int MAX5mQeBZSRCaLCRZhyd(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool JMwmnNeBTpel82X7LA93()
	{
		return MSFaRMeBUy8P3xfsPEtQ == null;
	}

	internal static LinearRegressionSource R0DT6eeBy7SHpOiuubIk()
	{
		return MSFaRMeBUy8P3xfsPEtQ;
	}

	internal static object okh3YGeBVI4VH9Omal17(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object L4cnGNeBCGUi40gkrFl2(object P_0, object P_1, int period)
	{
		return ((IndicatorsHelper)P_0).LinReg((double[])P_1, period);
	}
}
