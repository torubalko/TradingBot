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

[IndicatorSource("PriceOscillator", Type = typeof(PriceOscillatorSource))]
[DataContract(Name = "PriceOscillatorSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class PriceOscillatorSource : IndicatorSourceBase
{
	private int _shortPeriod;

	private int _longPeriod;

	private IndicatorMaType _maType;

	private IndicatorSourceBase _source;

	private static PriceOscillatorSource Xjq0ageaUCyxqPQIPjdM;

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
				case 1:
					value = Math.Max(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (value != _shortPeriod)
					{
						_shortPeriod = value;
						OnPropertyChanged((string)apose3eaZpTrb9jGmC9w(--134855371 ^ 0x8093D8D));
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
			value = yxYl0deaVS3Va2OVmv3k(1, value);
			if (value != _longPeriod)
			{
				_longPeriod = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x684F243E ^ 0x684FA35E));
			}
		}
	}

	[DataMember(Name = "MaType")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
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
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-371631841 ^ -371597721));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	[DataMember(Name = "Source")]
	public IndicatorSourceBase Source
	{
		get
		{
			return _source ?? (_source = new StockSource());
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
					if (value == _source)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_source = value;
					OnPropertyChanged((string)apose3eaZpTrb9jGmC9w(-894902996 ^ -894937782));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public PriceOscillatorSource()
	{
		NTZoI1eaCBHgrsqOwBqr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2017337494 ^ -2017373642);
				return;
			}
			ShortPeriod = 10;
			LongPeriod = 21;
			MaType = IndicatorMaType.EMA;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 != 0)
			{
				num = 0;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2123795572 ^ -2123759920) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		double[] series = Source.GetSeries(helper);
		if (series != null)
		{
			return helper.PPO(MaType, series, ShortPeriod, LongPeriod);
		}
		return null;
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		PriceOscillatorSource priceOscillatorSource = source as PriceOscillatorSource;
		int num;
		if (priceOscillatorSource == null)
		{
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e == 0)
			{
				num = 0;
			}
		}
		else
		{
			base.SelectedSeries = (string)lOESlpearKBDLPbOWVbW(priceOscillatorSource);
			ShortPeriod = priceOscillatorSource.ShortPeriod;
			LongPeriod = priceOscillatorSource.LongPeriod;
			MaType = DxAwKweaKmkG9J6CK9jM(priceOscillatorSource);
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
			{
				num = 0;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				return;
			}
			Source = priceOscillatorSource.Source.CloneSource();
			num = 2;
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x741B85CB ^ 0x741B0D65), base.Name, Source, ShortPeriod, LongPeriod);
	}

	static PriceOscillatorSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object apose3eaZpTrb9jGmC9w(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool clr6xVeaTAXEEekILl4s()
	{
		return Xjq0ageaUCyxqPQIPjdM == null;
	}

	internal static PriceOscillatorSource zjYfH3eayGhmkYlm1MvD()
	{
		return Xjq0ageaUCyxqPQIPjdM;
	}

	internal static int yxYl0deaVS3Va2OVmv3k(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void NTZoI1eaCBHgrsqOwBqr()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object lOESlpearKBDLPbOWVbW(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static IndicatorMaType DxAwKweaKmkG9J6CK9jM(object P_0)
	{
		return ((PriceOscillatorSource)P_0).MaType;
	}
}
