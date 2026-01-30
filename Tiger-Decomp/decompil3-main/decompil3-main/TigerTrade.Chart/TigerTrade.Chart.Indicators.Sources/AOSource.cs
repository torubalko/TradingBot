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

[DataContract(Name = "AOSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("AO", Type = typeof(AOSource))]
public sealed class AOSource : IndicatorSourceBase
{
	private int _shortPeriod;

	private int _longPeriod;

	private IndicatorMaType _maType;

	private static AOSource OpJXgJeol3QFtDTasRmx;

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
						OnPropertyChanged((string)GcKtmOeoNglbZQW7W0ic(-991861155 ^ -991829733));
					}
					return;
				case 1:
					value = Qu5xOQeobQAopjen6wFi(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "LongPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLongPeriod")]
	public int LongPeriod
	{
		get
		{
			return _longPeriod;
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
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (value != _longPeriod)
					{
						_longPeriod = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xECA3F28 ^ 0xECAB848));
					}
					return;
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
			if (value != _maType)
			{
				_maType = value;
				OnPropertyChanged((string)GcKtmOeoNglbZQW7W0ic(0x769C7931 ^ 0x769CFE49));
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

	public AOSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		ShortPeriod = 5;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
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
			LongPeriod = 34;
			MaType = IndicatorMaType.EMA;
			base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28BBDCA ^ 0x28B35CE);
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 == 0)
			{
				num = 1;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2002318893 ^ -2002288169) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.AO(MaType, ShortPeriod, LongPeriod);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (!(source is AOSource aOSource))
		{
			return;
		}
		base.SelectedSeries = (string)ervql5eokO2h8Ib25yRE(aOSource);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				LongPeriod = N7b1uNeo5MefxqowIeLa(aOSource);
				MaType = Xsvd6TeoSqXCWTC5unnd(aOSource);
				return;
			}
			ShortPeriod = AAadlpeo1sxwuOsYVGvw(aOSource);
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
			{
				num = 0;
			}
		}
	}

	public override string ToString()
	{
		return (string)qWGR6Teox50BL1qOAG4X(GcKtmOeoNglbZQW7W0ic(-842040449 ^ -842007313), base.Name, ShortPeriod, LongPeriod);
	}

	static AOSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		BR2wtHeoL2OVKbFf48iF();
	}

	internal static int Qu5xOQeobQAopjen6wFi(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object GcKtmOeoNglbZQW7W0ic(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool MbVgs9eo4klBHfPeaitT()
	{
		return OpJXgJeol3QFtDTasRmx == null;
	}

	internal static AOSource FMpry5eoDOkSFO8kE5xa()
	{
		return OpJXgJeol3QFtDTasRmx;
	}

	internal static object ervql5eokO2h8Ib25yRE(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static int AAadlpeo1sxwuOsYVGvw(object P_0)
	{
		return ((AOSource)P_0).ShortPeriod;
	}

	internal static int N7b1uNeo5MefxqowIeLa(object P_0)
	{
		return ((AOSource)P_0).LongPeriod;
	}

	internal static IndicatorMaType Xsvd6TeoSqXCWTC5unnd(object P_0)
	{
		return ((AOSource)P_0).MaType;
	}

	internal static object qWGR6Teox50BL1qOAG4X(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void BR2wtHeoL2OVKbFf48iF()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
