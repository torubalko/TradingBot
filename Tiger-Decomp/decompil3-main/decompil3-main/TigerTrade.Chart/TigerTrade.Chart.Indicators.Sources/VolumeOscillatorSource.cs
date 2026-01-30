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

[DataContract(Name = "VolumeOscillatorSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("VolumeOscillator", Type = typeof(VolumeOscillatorSource))]
public sealed class VolumeOscillatorSource : IndicatorSourceBase
{
	private int _shortPeriod;

	private int _longPeriod;

	private IndicatorMaType _maType;

	private static VolumeOscillatorSource tpMi86eiFBKDYE1M56Jx;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShortPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "ShortPeriod")]
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
				default:
					if (value != _shortPeriod)
					{
						_shortPeriod = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-342738082 ^ -342705128));
					}
					return;
				case 1:
					value = Math.Max(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLongPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "LongPeriod")]
	public int LongPeriod
	{
		get
		{
			return _longPeriod;
		}
		set
		{
			value = tDpbnoeiu75T1tTcaMPG(1, value);
			if (value != _longPeriod)
			{
				_longPeriod = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)Jyy5aseizof9RpwTbejv(-1325234765 ^ -1325268269));
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
			if (value != _maType)
			{
				_maType = value;
				OnPropertyChanged((string)Jyy5aseizof9RpwTbejv(-338769610 ^ -338801074));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
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

	public VolumeOscillatorSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		ShortPeriod = 5;
		LongPeriod = 10;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				MaType = IndicatorMaType.EMA;
				base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1799510641 ^ -1799542261);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1346994499 ^ -1346965191) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.VolumeOscillator(MaType, ShortPeriod, LongPeriod);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (!(source is VolumeOscillatorSource volumeOscillatorSource))
		{
			return;
		}
		base.SelectedSeries = volumeOscillatorSource.SelectedSeries;
		ShortPeriod = volumeOscillatorSource.ShortPeriod;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				LongPeriod = volumeOscillatorSource.LongPeriod;
				MaType = ij4EGZel0hhC6OxAgwbd(volumeOscillatorSource);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)Jyy5aseizof9RpwTbejv(--134855371 ^ 0x8093D5B), base.Name, ShortPeriod, LongPeriod);
	}

	static VolumeOscillatorSource()
	{
		rXIHiGel2f0G7NrPxULx();
		xjCOwZelHNig54ONSLRG();
	}

	internal static bool cciTSBei3Uo09N4E0cDj()
	{
		return tpMi86eiFBKDYE1M56Jx == null;
	}

	internal static VolumeOscillatorSource MsBopmeip3tJhdcmePcM()
	{
		return tpMi86eiFBKDYE1M56Jx;
	}

	internal static int tDpbnoeiu75T1tTcaMPG(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object Jyy5aseizof9RpwTbejv(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static IndicatorMaType ij4EGZel0hhC6OxAgwbd(object P_0)
	{
		return ((VolumeOscillatorSource)P_0).MaType;
	}

	internal static void rXIHiGel2f0G7NrPxULx()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void xjCOwZelHNig54ONSLRG()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
