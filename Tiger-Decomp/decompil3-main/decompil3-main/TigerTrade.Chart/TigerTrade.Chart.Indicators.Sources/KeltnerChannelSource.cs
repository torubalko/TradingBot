using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;

namespace TigerTrade.Chart.Indicators.Sources;

[DataContract(Name = "KeltnerChannelSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("KeltnerChannel", Type = typeof(KeltnerChannelSource))]
public sealed class KeltnerChannelSource : IndicatorSourceBase
{
	private int _period;

	private int _factor;

	private IndicatorMaType _maType;

	private IndicatorSourceBase _source;

	private static KeltnerChannelSource s4UokIeBRbFdE5GYnSxx;

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
			value = Math.Max(1, value);
			if (value != _period)
			{
				_period = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)NlYaT6eBOhfdTu0gEg9N(-45476899 ^ -45443989));
			}
		}
	}

	[DataMember(Name = "Factor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsFactor")]
	public int Factor
	{
		get
		{
			return _factor;
		}
		set
		{
			value = Math.Max(1, value);
			if (value != _factor)
			{
				_factor = value;
				OnPropertyChanged((string)NlYaT6eBOhfdTu0gEg9N(-1878953018 ^ -1878918774));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	[DataMember(Name = "MaType")]
	public IndicatorMaType MaType
	{
		get
		{
			return _maType;
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
				case 1:
					if (value == _maType)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
						{
							num2 = 0;
						}
						break;
					}
					_maType = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x68DEE0F ^ 0x68D6977));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	[DataMember(Name = "Source")]
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
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-90307782 ^ -90272932));
			}
		}
	}

	public KeltnerChannelSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Period = 20;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
				{
					num = 0;
				}
				break;
			default:
				Factor = 1;
				MaType = IndicatorMaType.SMA;
				base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1878953018 ^ -1878919040);
				return;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string>
		{
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-837284864 ^ -837253306),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7394D272 ^ 0x7394592A),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-3429745 ^ -3464733)
		};
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		int num = 4;
		int num2 = num;
		double[] series = default(double[]);
		double[] avg = default(double[]);
		double[] upper = default(double[]);
		double[] lower = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 4:
				series = Source.GetSeries(helper);
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				return avg;
			case 1:
				return null;
			case 3:
				if (series != null)
				{
					helper.KeltnerChannel(series, MaType, Period, Factor, out avg, out upper, out lower);
					num2 = 2;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
			{
				string selectedSeries = base.SelectedSeries;
				if (selectedSeries == (string)NlYaT6eBOhfdTu0gEg9N(0x28C965BE ^ 0x28C9EEF8))
				{
					return upper;
				}
				if (audMKReBqBO2omvUcjOK(selectedSeries, NlYaT6eBOhfdTu0gEg9N(-1325234765 ^ -1325265173)))
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (audMKReBqBO2omvUcjOK(selectedSeries, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x78D396D8 ^ 0x78D31DB4)))
				{
					return lower;
				}
				return null;
			}
			}
		}
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (!(source is KeltnerChannelSource keltnerChannelSource))
		{
			return;
		}
		base.SelectedSeries = (string)LmrZRgeBI9nqq4PTx1HK(keltnerChannelSource);
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				MaType = KRo1D6eBWuw0K7QdueFC(keltnerChannelSource);
				Source = keltnerChannelSource.Source.CloneSource();
				return;
			case 2:
				Factor = keltnerChannelSource.Factor;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f != 0)
				{
					num = 0;
				}
				break;
			case 1:
				Period = keltnerChannelSource.Period;
				num = 2;
				break;
			}
		}
	}

	public override string ToString()
	{
		if (string.IsNullOrEmpty(base.SelectedSeries))
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--500511424 ^ 0x1DD5B524);
		}
		return (string)A4caHdeBt2bGZ5nRMtV4(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-342738082 ^ -342707216), new object[4] { base.SelectedSeries, Source, Period, Factor });
	}

	static KeltnerChannelSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object NlYaT6eBOhfdTu0gEg9N(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool g4NZVteB6nq5h9eALfUa()
	{
		return s4UokIeBRbFdE5GYnSxx == null;
	}

	internal static KeltnerChannelSource Qb3CIHeBMu90m82htVZq()
	{
		return s4UokIeBRbFdE5GYnSxx;
	}

	internal static bool audMKReBqBO2omvUcjOK(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object LmrZRgeBI9nqq4PTx1HK(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static IndicatorMaType KRo1D6eBWuw0K7QdueFC(object P_0)
	{
		return ((KeltnerChannelSource)P_0).MaType;
	}

	internal static object A4caHdeBt2bGZ5nRMtV4(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}
}
