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

[IndicatorSource("ChaikinsVolatility", Type = typeof(ChaikinsVolatilitySource))]
[DataContract(Name = "ChaikinsVolatilitySource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class ChaikinsVolatilitySource : IndicatorSourceBase
{
	private int _period;

	private IndicatorMaType _maType;

	private static ChaikinsVolatilitySource JLjpwtevhutN12QR0tW5;

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
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-342738082 ^ -342704920));
					}
					return;
				case 1:
					value = kujFuWev8qhuqKMDLFY0(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
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
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f != 0)
						{
							num2 = 0;
						}
						break;
					}
					_maType = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-710503328 ^ -710536424));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public ChaikinsVolatilitySource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Period = 10;
			MaType = IndicatorMaType.EMA;
			base.SelectedSeries = (string)rBp4evevATMUQ1S6RFxx(-1435596783 ^ -1435631193);
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
			{
				num = 1;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1346994499 ^ -1346963701) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.ChaikinsVolatility(MaType, Period);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num;
		if (!(source is ChaikinsVolatilitySource chaikinsVolatilitySource))
		{
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
			{
				num = 1;
			}
		}
		else
		{
			base.SelectedSeries = (string)bp8A6GevPEFKgMcKB2LH(chaikinsVolatilitySource);
			Period = chaikinsVolatilitySource.Period;
			MaType = qnJcvKevJ1PpwV9ZHwL3(chaikinsVolatilitySource);
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 != 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 1:
			break;
		case 0:
			break;
		}
	}

	public override string ToString()
	{
		return (string)t9V5DyevFyQyMiZDuesR(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-991861155 ^ -991829587), base.Name, Period);
	}

	static ChaikinsVolatilitySource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int kujFuWev8qhuqKMDLFY0(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool Y9HeN0evwKEb0i070or6()
	{
		return JLjpwtevhutN12QR0tW5 == null;
	}

	internal static ChaikinsVolatilitySource YkiAWWev7OY0Eg73ydD9()
	{
		return JLjpwtevhutN12QR0tW5;
	}

	internal static object rBp4evevATMUQ1S6RFxx(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object bp8A6GevPEFKgMcKB2LH(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static IndicatorMaType qnJcvKevJ1PpwV9ZHwL3(object P_0)
	{
		return ((ChaikinsVolatilitySource)P_0).MaType;
	}

	internal static object t9V5DyevFyQyMiZDuesR(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
