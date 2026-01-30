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

[DataContract(Name = "UltimateOscillatorSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("UltimateOscillator", Type = typeof(UltimateOscillatorSource))]
public sealed class UltimateOscillatorSource : IndicatorSourceBase
{
	private int _period1;

	private int _period2;

	private int _period3;

	internal static UltimateOscillatorSource ubfvkneiZmTvZB7hneIp;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod1")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period1")]
	public int Period1
	{
		get
		{
			return _period1;
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
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (value != _period1)
					{
						_period1 = value;
						OnPropertyChanged((string)PXjkxXeirOk2heSeioi1(-1461292091 ^ -1461257889));
					}
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod2")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period2")]
	public int Period2
	{
		get
		{
			return _period2;
		}
		set
		{
			value = Math.Max(1, value);
			if (value != _period2)
			{
				_period2 = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1127423276 ^ -1127454600));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod3")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period3")]
	public int Period3
	{
		get
		{
			return _period3;
		}
		set
		{
			value = BHeEhOeiKEjR9TaJa6my(1, value);
			if (value != _period3)
			{
				_period3 = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)PXjkxXeirOk2heSeioi1(0x6D18F862 ^ 0x6D1872DC));
			}
		}
	}

	public UltimateOscillatorSource()
	{
		OTG9aveimUnGlHo5fjcR();
		base._002Ector();
		Period1 = 7;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Period2 = 14;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
				{
					num = 0;
				}
				break;
			default:
				Period3 = 28;
				base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28B345BB ^ 0x28B3CAE9);
				return;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x446AB724 ^ 0x446A3876) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return (double[])O3tSHAeih0A9VOj0G8x9(helper, Period1, Period2, Period3);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 2;
		int num2 = num;
		UltimateOscillatorSource ultimateOscillatorSource = default(UltimateOscillatorSource);
		while (true)
		{
			switch (num2)
			{
			default:
				Period3 = vBM0xtei7a8MBvKmot5K(ultimateOscillatorSource);
				return;
			case 2:
				ultimateOscillatorSource = source as UltimateOscillatorSource;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (ultimateOscillatorSource == null)
				{
					return;
				}
				base.SelectedSeries = ultimateOscillatorSource.SelectedSeries;
				Period1 = rBfpBdeiwmQ10g3LRKZm(ultimateOscillatorSource);
				Period2 = ultimateOscillatorSource.Period2;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)PXjkxXeirOk2heSeioi1(-1522697859 ^ -1522667053), base.Name, Period1, Period2, Period3);
	}

	static UltimateOscillatorSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		aboU4Uei8mOInv6Qr5Pk();
	}

	internal static object PXjkxXeirOk2heSeioi1(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool PZpArYeiV0XRTR9y4oUk()
	{
		return ubfvkneiZmTvZB7hneIp == null;
	}

	internal static UltimateOscillatorSource Aa48rfeiCOgNGDitilmm()
	{
		return ubfvkneiZmTvZB7hneIp;
	}

	internal static int BHeEhOeiKEjR9TaJa6my(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void OTG9aveimUnGlHo5fjcR()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object O3tSHAeih0A9VOj0G8x9(object P_0, int period1, int period2, int period3)
	{
		return ((IndicatorsHelper)P_0).UltOsc(period1, period2, period3);
	}

	internal static int rBfpBdeiwmQ10g3LRKZm(object P_0)
	{
		return ((UltimateOscillatorSource)P_0).Period1;
	}

	internal static int vBM0xtei7a8MBvKmot5K(object P_0)
	{
		return ((UltimateOscillatorSource)P_0).Period3;
	}

	internal static void aboU4Uei8mOInv6Qr5Pk()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
