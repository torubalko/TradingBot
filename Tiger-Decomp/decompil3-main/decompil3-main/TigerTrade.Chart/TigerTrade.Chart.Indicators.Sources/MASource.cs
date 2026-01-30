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

[DataContract(Name = "MASource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("MA", Type = typeof(MASource))]
public sealed class MASource : IndicatorSourceBase
{
	private int _period;

	private IndicatorMaType _maType;

	private IndicatorSourceBase _source;

	internal static MASource TRhjLZeBFCxN0eFZmieL;

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
			value = GTJVFeeBur0ZUSUIWShO(1, value);
			if (value != _period)
			{
				_period = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x22BF43FC ^ 0x22BFC44A));
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
			if (value != _maType)
			{
				_maType = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x315AB1E3 ^ 0x315A369B));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee != 0)
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

	[DataMember(Name = "Source")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
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
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-448941864 ^ -448972610));
			}
		}
	}

	public MASource()
	{
		HY7mCfeBzRmtgb7Ewibb();
		base._002Ector();
		Period = 14;
		MaType = IndicatorMaType.EMA;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
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
			base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-176525661 ^ -176495897);
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
			{
				num = 1;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-181342698 ^ -181378478) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		double[] series = _source.GetSeries(helper);
		if (series != null)
		{
			return helper.MovingAverage(_maType, series, _period);
		}
		return null;
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 1;
		int num2 = num;
		MASource mASource = default(MASource);
		while (true)
		{
			switch (num2)
			{
			case 1:
				mASource = source as MASource;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				MaType = mASource.MaType;
				Source = mASource.Source.CloneSource();
				return;
			}
			if (mASource == null)
			{
				return;
			}
			base.SelectedSeries = mASource.SelectedSeries;
			Period = tLLiKHea0k2muPMpI5CR(mASource);
			num2 = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 != 0)
			{
				num2 = 2;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1309555870 ^ -1309588238), MaType, Source, Period);
	}

	static MASource()
	{
		fF2lamea2Nwt0TN2MApl();
		FnOD0ZeaHvmKmM7E5RaC();
	}

	internal static int GTJVFeeBur0ZUSUIWShO(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool uk6cuFeB38kAUshDkJv6()
	{
		return TRhjLZeBFCxN0eFZmieL == null;
	}

	internal static MASource on1CuZeBpk0LEW8pElPi()
	{
		return TRhjLZeBFCxN0eFZmieL;
	}

	internal static void HY7mCfeBzRmtgb7Ewibb()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static int tLLiKHea0k2muPMpI5CR(object P_0)
	{
		return ((MASource)P_0).Period;
	}

	internal static void fF2lamea2Nwt0TN2MApl()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void FnOD0ZeaHvmKmM7E5RaC()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
