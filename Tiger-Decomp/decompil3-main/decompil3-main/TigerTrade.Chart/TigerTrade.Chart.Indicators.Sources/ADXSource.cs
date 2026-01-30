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

[DataContract(Name = "ADXSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("ADX", Type = typeof(ADXSource))]
public sealed class ADXSource : IndicatorSourceBase
{
	private int _period;

	private static ADXSource MIcJLYeo9U91LKPjfglc;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
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
			if (value != _period)
			{
				_period = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--855742383 ^ 0x33011019));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
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

	public ADXSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 14;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-338769610 ^ -338800912);
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string>
		{
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1962651919 ^ -1962620617),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1192989954 ^ -1192956626),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6AB40973 ^ 0x6AB48EA9)
		};
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		int num = 2;
		int num2 = num;
		string selectedSeries = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return (double[])AmOVndeovHPmyUoCY6o3(helper, _period);
			case 2:
				selectedSeries = base.SelectedSeries;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!(selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D3134C9 ^ 0x2D31B30F)))
				{
					if (!(selectedSeries == (string)pecOeKeoYvnp6R5GShOZ(0x20B584D2 ^ 0x20B50302)))
					{
						if (d4WtL7eooPwTZlHFPKjM(selectedSeries, pecOeKeoYvnp6R5GShOZ(-527080372 ^ -527047786)))
						{
							return helper.MinusDI(_period);
						}
						return null;
					}
					return helper.PlusDI(_period);
				}
				goto default;
			}
		}
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 1;
		int num2 = num;
		ADXSource aDXSource = default(ADXSource);
		while (true)
		{
			switch (num2)
			{
			case 1:
				aDXSource = source as ADXSource;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (aDXSource != null)
				{
					base.SelectedSeries = (string)GRYnp9eoBaNd7erfr3GS(aDXSource);
					Period = a7WWhFeoaCGNjE6LjQG9(aDXSource);
				}
				return;
			}
		}
	}

	public override string ToString()
	{
		if (Xqd0mFeoiT8MY1qYZ4I4(base.SelectedSeries))
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1583344314 ^ -1583312222);
		}
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2108526692 ^ -2108495764), base.SelectedSeries, Period);
	}

	static ADXSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool Jbm2S8eonsgrCfR5xkXv()
	{
		return MIcJLYeo9U91LKPjfglc == null;
	}

	internal static ADXSource x6ZJXFeoGs5DGTPulsa4()
	{
		return MIcJLYeo9U91LKPjfglc;
	}

	internal static object pecOeKeoYvnp6R5GShOZ(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool d4WtL7eooPwTZlHFPKjM(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object AmOVndeovHPmyUoCY6o3(object P_0, int period)
	{
		return ((IndicatorsHelper)P_0).ADX(period);
	}

	internal static object GRYnp9eoBaNd7erfr3GS(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static int a7WWhFeoaCGNjE6LjQG9(object P_0)
	{
		return ((ADXSource)P_0).Period;
	}

	internal static bool Xqd0mFeoiT8MY1qYZ4I4(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
