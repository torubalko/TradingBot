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

[DataContract(Name = "ACSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("AC", Type = typeof(ACSource))]
public sealed class ACSource : IndicatorSourceBase
{
	private int _shortPeriod;

	private int _longPeriod;

	private IndicatorMaType _maType;

	private static ACSource J1ZTBVeY8LjaRCTKrPqE;

	[DataMember(Name = "ShortPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
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
				default:
					if (value != _shortPeriod)
					{
						_shortPeriod = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-527080372 ^ -527047926));
					}
					return;
				case 1:
					value = fbJtwFeYJJkRUp1WZK8X(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa != 0)
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
			value = Math.Max(1, value);
			if (value != _longPeriod)
			{
				_longPeriod = value;
				OnPropertyChanged((string)fNZMCIeYFtsAbMR5Ck02(0x4220DA8 ^ 0x4228AC8));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
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
	[DataMember(Name = "MaType")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
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
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)fNZMCIeYFtsAbMR5Ck02(-991861155 ^ -991829723));
			}
		}
	}

	public ACSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				LongPeriod = 34;
				MaType = IndicatorMaType.EMA;
				base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-3429745 ^ -3461881);
				return;
			case 1:
				ShortPeriod = 5;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xC1DDB3B ^ 0xC1D5CB3) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.AC(_maType, _shortPeriod, _longPeriod);
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (!(source is ACSource aCSource))
		{
			return;
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				base.SelectedSeries = (string)nwY3OJeY3kJcPxH5mKMN(aCSource);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb != 0)
				{
					num = 0;
				}
				break;
			default:
				LongPeriod = aCSource.LongPeriod;
				ShortPeriod = nCFrOSeYpOj7jEgueU1H(aCSource);
				MaType = aCSource.MaType;
				return;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2108526692 ^ -2108495860), base.Name, ShortPeriod, LongPeriod);
	}

	static ACSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int fbJtwFeYJJkRUp1WZK8X(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool II19XKeYAlyoAxD8owSe()
	{
		return J1ZTBVeY8LjaRCTKrPqE == null;
	}

	internal static ACSource NIG81HeYP88cvu9ujvjf()
	{
		return J1ZTBVeY8LjaRCTKrPqE;
	}

	internal static object fNZMCIeYFtsAbMR5Ck02(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object nwY3OJeY3kJcPxH5mKMN(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static int nCFrOSeYpOj7jEgueU1H(object P_0)
	{
		return ((ACSource)P_0).ShortPeriod;
	}
}
