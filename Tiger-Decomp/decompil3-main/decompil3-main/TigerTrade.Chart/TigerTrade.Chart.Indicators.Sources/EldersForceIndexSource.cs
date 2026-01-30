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

[DataContract(Name = "EldersForceIndexSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("EldersForceIndex", Type = typeof(EldersForceIndexSource))]
public sealed class EldersForceIndexSource : IndicatorSourceBase
{
	private int _period;

	private IndicatorMaType _maType;

	private IndicatorSourceBase _source;

	private static EldersForceIndexSource mcDJaheBYatFZH7cHiCS;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return _period;
		}
		set
		{
			value = oPxM01eBBPJmgVsr6jba(1, value);
			if (value == _period)
			{
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			else
			{
				_period = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x3544E813 ^ 0x35446FA5));
			}
		}
	}

	[DataMember(Name = "MaType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
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
						OnPropertyChanged((string)SpQ3IaeBaxda0dwNRsFh(-377195341 ^ -377162805));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Source")]
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
				OnPropertyChanged((string)SpQ3IaeBaxda0dwNRsFh(0x741B85CB ^ 0x741B0DAD));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
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

	public EldersForceIndexSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 13;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
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
			MaType = IndicatorMaType.EMA;
			base.SelectedSeries = (string)SpQ3IaeBaxda0dwNRsFh(0x16AD7E76 ^ 0x16ADF47C);
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c != 0)
			{
				num = 1;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-342738082 ^ -342707884) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		double[] array = (double[])eau8cBeBiE2fagsd0f1m(Source, helper);
		if (array != null)
		{
			return helper.EFI(array, MaType, Period);
		}
		return null;
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (!(source is EldersForceIndexSource eldersForceIndexSource))
		{
			return;
		}
		base.SelectedSeries = (string)C1RnyMeBllJIN4KV49R4(eldersForceIndexSource);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
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
			Period = DQdVG0eB4NGkf85oELiV(eldersForceIndexSource);
			MaType = eldersForceIndexSource.MaType;
			Source = (IndicatorSourceBase)JGOoB6eBDBTedIagETHn(eldersForceIndexSource.Source);
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 != 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2074141628 ^ -2074110358), Source, Period);
	}

	static EldersForceIndexSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		PWV4jLeBb59trXpgtSBs();
	}

	internal static int oPxM01eBBPJmgVsr6jba(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool ctBkNveBoBsvbVe1fNqR()
	{
		return mcDJaheBYatFZH7cHiCS == null;
	}

	internal static EldersForceIndexSource N7SPMdeBv7KAfe0Ertp0()
	{
		return mcDJaheBYatFZH7cHiCS;
	}

	internal static object SpQ3IaeBaxda0dwNRsFh(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object eau8cBeBiE2fagsd0f1m(object P_0, object P_1)
	{
		return ((IndicatorSourceBase)P_0).GetSeries((IndicatorsHelper)P_1);
	}

	internal static object C1RnyMeBllJIN4KV49R4(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static int DQdVG0eB4NGkf85oELiV(object P_0)
	{
		return ((EldersForceIndexSource)P_0).Period;
	}

	internal static object JGOoB6eBDBTedIagETHn(object P_0)
	{
		return ((IndicatorSourceBase)P_0).CloneSource();
	}

	internal static void PWV4jLeBb59trXpgtSBs()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
