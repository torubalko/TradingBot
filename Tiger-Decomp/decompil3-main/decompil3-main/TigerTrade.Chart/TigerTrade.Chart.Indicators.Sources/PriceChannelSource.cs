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

[DataContract(Name = "PriceChannelSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("PriceChannel", Type = typeof(PriceChannelSource))]
public sealed class PriceChannelSource : IndicatorSourceBase
{
	private int _period;

	internal static PriceChannelSource wZocOwead5nho9YP3CdJ;

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
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-837284864 ^ -837252170));
					}
					return;
				case 1:
					value = NNdhfWea6NtgRJlPc75Y(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PriceChannelSource()
	{
		lXf0Q4eaM2yhXUNQhks6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Period = 10;
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1583344314 ^ -1583310418);
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string>
		{
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x741B85CB ^ 0x741B0923),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1999650146 ^ -1999679600),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7F645F3C ^ 0x7F64D20A)
		};
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		helper.PriceChannel(Period, out var avg, out var upper, out var lower);
		string selectedSeries = base.SelectedSeries;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				if (fTQgoIeaqUvcxxLq4Ark(selectedSeries, KDCUSTeaOlsfxSRwT8Rm(0x6E2DFBED ^ 0x6E2D76DB)))
				{
					return lower;
				}
				return null;
			case 1:
				if (!(selectedSeries == (string)KDCUSTeaOlsfxSRwT8Rm(0x22BF43FC ^ 0x22BFCF14)))
				{
					if (!(selectedSeries == (string)KDCUSTeaOlsfxSRwT8Rm(-1009517961 ^ -1009551495)))
					{
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 != 0)
						{
							num = 0;
						}
						break;
					}
					return avg;
				}
				return upper;
			}
		}
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 1;
		int num2 = num;
		PriceChannelSource priceChannelSource = default(PriceChannelSource);
		while (true)
		{
			switch (num2)
			{
			default:
				if (priceChannelSource != null)
				{
					base.SelectedSeries = priceChannelSource.SelectedSeries;
					Period = priceChannelSource.Period;
				}
				return;
			case 1:
				priceChannelSource = source as PriceChannelSource;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		if (xXm1MKeaIsmdqccHom39(base.SelectedSeries))
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28B345BB ^ 0x28B3C25F);
		}
		return (string)ynDyuteaWPJuE89alWLx(KDCUSTeaOlsfxSRwT8Rm(0x4220DA8 ^ 0x4228A58), base.SelectedSeries, Period);
	}

	static PriceChannelSource()
	{
		HlFwAleatSt0nnNoZerh();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int NNdhfWea6NtgRJlPc75Y(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool H4rsBneag8a0XtyUWFck()
	{
		return wZocOwead5nho9YP3CdJ == null;
	}

	internal static PriceChannelSource bhwcvPeaRvbjv0EX992R()
	{
		return wZocOwead5nho9YP3CdJ;
	}

	internal static void lXf0Q4eaM2yhXUNQhks6()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object KDCUSTeaOlsfxSRwT8Rm(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool fTQgoIeaqUvcxxLq4Ark(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool xXm1MKeaIsmdqccHom39(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object ynDyuteaWPJuE89alWLx(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void HlFwAleatSt0nnNoZerh()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
