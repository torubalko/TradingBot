using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;

namespace TigerTrade.Chart.Indicators.Sources;

[IndicatorSource("BollingerBands", Type = typeof(BollingerBandsSource))]
[DataContract(Name = "BollingerBandsSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class BollingerBandsSource : IndicatorSourceBase
{
	private int _period;

	private decimal _stdDev;

	private IndicatorMaType _maType;

	private IndicatorSourceBase _source;

	internal static BollingerBandsSource kkEUxQeoKirc5fgrfZKK;

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
				case 1:
					value = Math.Max(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (value != _period)
					{
						_period = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x20B584D2 ^ 0x20B50364));
					}
					return;
				}
			}
		}
	}

	[DataMember(Name = "StdDev")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsStdDev")]
	public decimal StdDev
	{
		get
		{
			return _stdDev;
		}
		set
		{
			value = q50YHPeow56chVC4xxqC(0m, value);
			if (!(value == _stdDev))
			{
				_stdDev = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)R43umHeo7BZtjQ6TRYPc(-2017337494 ^ -2017372356));
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
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-82860344 ^ -82894416));
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
			if (value != _source)
			{
				_source = value;
				OnPropertyChanged((string)R43umHeo7BZtjQ6TRYPc(-1325234765 ^ -1325265451));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb == 0)
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

	public BollingerBandsSource()
	{
		pen0MFeo8ZuwkOsLxeOT();
		base._002Ector();
		Period = 20;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
		{
			num = 1;
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
				StdDev = 2m;
				MaType = IndicatorMaType.SMA;
				base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6E2DFBED ^ 0x6E2D739B);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string>
		{
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x60620FC1 ^ 0x606287B7),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-671204305 ^ -671173465),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x32DEA4F1 ^ 0x32DE2C6D)
		};
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		int num = 2;
		int num2 = num;
		double[] array = default(double[]);
		double[] upperBand = default(double[]);
		double[] middleBand = default(double[]);
		double[] lowerBand = default(double[]);
		string selectedSeries = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				array = (double[])MF8MIFeoAmXbccnbKwr0(Source, helper);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				if (array == null)
				{
					return null;
				}
				helper.BBands(array, Period, (double)StdDev, Qse4uceoPnFpqlVB7e0l(StdDev), MaType, out upperBand, out middleBand, out lowerBand);
				selectedSeries = base.SelectedSeries;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				if (selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1763895751 ^ -1763860827))
				{
					return lowerBand;
				}
				return null;
			}
			if (!(selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1962651919 ^ -1962621305)))
			{
				if (!(selectedSeries == (string)R43umHeo7BZtjQ6TRYPc(--871424829 ^ 0x33F06BB5)))
				{
					num2 = 3;
					continue;
				}
				return middleBand;
			}
			return upperBand;
		}
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 1;
		int num2 = num;
		BollingerBandsSource bollingerBandsSource = default(BollingerBandsSource);
		while (true)
		{
			switch (num2)
			{
			case 3:
				MaType = bollingerBandsSource.MaType;
				Source = (IndicatorSourceBase)ykPLxheoFGSdU2jy281x(mwnt7neoJpbFOUKfyk2T(bollingerBandsSource));
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				bollingerBandsSource = source as BollingerBandsSource;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			if (bollingerBandsSource == null)
			{
				return;
			}
			base.SelectedSeries = bollingerBandsSource.SelectedSeries;
			Period = bollingerBandsSource.Period;
			StdDev = bollingerBandsSource.StdDev;
			num2 = 3;
		}
	}

	public override string ToString()
	{
		if (mip3hyeo3D25dkd6Le6m(base.SelectedSeries))
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x32DEA4F1 ^ 0x32DE2315);
		}
		return string.Format((string)R43umHeo7BZtjQ6TRYPc(0x78D396D8 ^ 0x78D31E76), base.SelectedSeries, Source, Period, StdDev.ToString(CultureInfo.InvariantCulture));
	}

	static BollingerBandsSource()
	{
		RTRsUOeopEN2Hw1dP5Tu();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool HtV27PeomYZgIVCaKWQK()
	{
		return kkEUxQeoKirc5fgrfZKK == null;
	}

	internal static BollingerBandsSource GNL1lNeohU2MfSAxSv8P()
	{
		return kkEUxQeoKirc5fgrfZKK;
	}

	internal static decimal q50YHPeow56chVC4xxqC(decimal P_0, decimal P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object R43umHeo7BZtjQ6TRYPc(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void pen0MFeo8ZuwkOsLxeOT()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object MF8MIFeoAmXbccnbKwr0(object P_0, object P_1)
	{
		return ((IndicatorSourceBase)P_0).GetSeries((IndicatorsHelper)P_1);
	}

	internal static double Qse4uceoPnFpqlVB7e0l(decimal P_0)
	{
		return (double)P_0;
	}

	internal static object mwnt7neoJpbFOUKfyk2T(object P_0)
	{
		return ((BollingerBandsSource)P_0).Source;
	}

	internal static object ykPLxheoFGSdU2jy281x(object P_0)
	{
		return ((IndicatorSourceBase)P_0).CloneSource();
	}

	internal static bool mip3hyeo3D25dkd6Le6m(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void RTRsUOeopEN2Hw1dP5Tu()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
