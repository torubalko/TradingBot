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

[IndicatorSource("ChaikinOscillator", Type = typeof(ChaikinOscillatorSource))]
[DataContract(Name = "ChaikinOscillatorSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class ChaikinOscillatorSource : IndicatorSourceBase
{
	private int _shortPeriod;

	private int _longPeriod;

	private IndicatorMaType _maType;

	private static ChaikinOscillatorSource DFQfg7evWUKWAA2wYrcr;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "ShortPeriod")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShortPeriod")]
	public int ShortPeriod
	{
		get
		{
			return _shortPeriod;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					value = Math.Max(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (value != _shortPeriod)
					{
						_shortPeriod = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1435596783 ^ -1435627689));
					}
					return;
				}
			}
		}
	}

	[DataMember(Name = "LongPeriod")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLongPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int LongPeriod
	{
		get
		{
			return _longPeriod;
		}
		set
		{
			value = EbZAcBevTFbtdHQGkLDA(1, value);
			if (value != _longPeriod)
			{
				_longPeriod = value;
				OnPropertyChanged((string)NDWmNoevy1id1cNcml9H(-2063361985 ^ -2063392929));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
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
				case 0:
					return;
				case 1:
					if (value != _maType)
					{
						_maType = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D313048 ^ 0x2D31B730));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ChaikinOscillatorSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		ShortPeriod = 3;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
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
			LongPeriod = 10;
			MaType = IndicatorMaType.EMA;
			base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1346994499 ^ -1346963667);
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
			{
				num = 1;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-962524685 ^ -962494365) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return (double[])OJFybZevZAdACmQFldoI(helper, MaType, ShortPeriod, LongPeriod);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		ChaikinOscillatorSource chaikinOscillatorSource = source as ChaikinOscillatorSource;
		int num;
		if (chaikinOscillatorSource != null)
		{
			base.SelectedSeries = (string)aheVn6evVDw20r5XfQh4(chaikinOscillatorSource);
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 != 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 1:
			return;
		}
		ShortPeriod = qYH3FbevCvogkfdn5ZaG(chaikinOscillatorSource);
		LongPeriod = W5RYwmevrVAx1xf7Ja9q(chaikinOscillatorSource);
		MaType = chaikinOscillatorSource.MaType;
	}

	public override string ToString()
	{
		return (string)uOOOOyevKPBAjmm9drfj(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-181342698 ^ -181376634), base.Name, ShortPeriod, LongPeriod);
	}

	static ChaikinOscillatorSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		BceKD4evmFMhlXq963tA();
	}

	internal static bool u2iBpJevtR1gP2W4EQgH()
	{
		return DFQfg7evWUKWAA2wYrcr == null;
	}

	internal static ChaikinOscillatorSource Y983y1evUDL1tK6MvfgY()
	{
		return DFQfg7evWUKWAA2wYrcr;
	}

	internal static int EbZAcBevTFbtdHQGkLDA(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object NDWmNoevy1id1cNcml9H(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object OJFybZevZAdACmQFldoI(object P_0, IndicatorMaType maType, int shortPeriod, int longPeriod)
	{
		return ((IndicatorsHelper)P_0).CO(maType, shortPeriod, longPeriod);
	}

	internal static object aheVn6evVDw20r5XfQh4(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static int qYH3FbevCvogkfdn5ZaG(object P_0)
	{
		return ((ChaikinOscillatorSource)P_0).ShortPeriod;
	}

	internal static int W5RYwmevrVAx1xf7Ja9q(object P_0)
	{
		return ((ChaikinOscillatorSource)P_0).LongPeriod;
	}

	internal static object uOOOOyevKPBAjmm9drfj(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void BceKD4evmFMhlXq963tA()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
