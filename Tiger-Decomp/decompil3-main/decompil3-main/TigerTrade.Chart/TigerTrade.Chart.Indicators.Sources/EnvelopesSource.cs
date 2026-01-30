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

[IndicatorSource("Envelopes", Type = typeof(EnvelopesSource))]
[DataContract(Name = "EnvelopesSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class EnvelopesSource : IndicatorSourceBase
{
	private int _period;

	private int _factor;

	private IndicatorMaType _maType;

	private IndicatorSourceBase _source;

	internal static EnvelopesSource vZ0JOWeBN20AXMs7KJde;

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
			value = Math.Max(1, value);
			if (value != _period)
			{
				_period = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xAD5B8B3 ^ 0xAD53F05));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd != 0)
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
	[DataMember(Name = "Factor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsFactor")]
	public int Factor
	{
		get
		{
			return _factor;
		}
		set
		{
			if (value != _factor)
			{
				_factor = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)tquYkveB5AIofjQlS9UX(-2002318893 ^ -2002287713));
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
			if (value != _maType)
			{
				_maType = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)tquYkveB5AIofjQlS9UX(-624753169 ^ -624721257));
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
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x706541F3 ^ 0x7065C995));
			}
		}
	}

	public EnvelopesSource()
	{
		KIIt3HeBSt2dddYdIQ8a();
		base._002Ector();
		Period = 20;
		Factor = 2;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base.SelectedSeries = (string)tquYkveB5AIofjQlS9UX(0x37B74BDF ^ 0x37B7C183);
				return;
			}
			MaType = IndicatorMaType.SMA;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
			{
				num = 1;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string>
		{
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1606927328 ^ -1606896004),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--855742383 ^ 0x33011DDF),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x68C7EAE6 ^ 0x68C76060)
		};
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		double[] array = (double[])zJDTADeBxtJIRoh4Wj7B(Source, helper);
		if (array == null)
		{
			return null;
		}
		helper.Envelopes(array, MaType, Period, Factor, out var avg, out var upper, out var lower);
		string selectedSeries = base.SelectedSeries;
		int num2;
		if (NXaHF3eBLwQMSYrLh86e(selectedSeries, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6AB40973 ^ 0x6AB4832F)))
		{
			int num = 3;
			num2 = num;
			goto IL_0009;
		}
		goto IL_00a4;
		IL_0009:
		switch (num2)
		{
		case 1:
		case 3:
			return upper;
		case 2:
			return lower;
		}
		goto IL_00a4;
		IL_00a4:
		if (selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2BD86B18 ^ 0x2BD8E168))
		{
			return avg;
		}
		if (!(selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-837284864 ^ -837253498)))
		{
			return null;
		}
		num2 = 2;
		goto IL_0009;
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		EnvelopesSource envelopesSource = source as EnvelopesSource;
		int num;
		if (envelopesSource != null)
		{
			base.SelectedSeries = envelopesSource.SelectedSeries;
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
			{
				num = 2;
			}
		}
		else
		{
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
			{
				num = 1;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				Period = envelopesSource.Period;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
				{
					num = 0;
				}
				break;
			default:
				Factor = envelopesSource.Factor;
				MaType = envelopesSource.MaType;
				Source = envelopesSource.Source.CloneSource();
				return;
			}
		}
	}

	public override string ToString()
	{
		if (string.IsNullOrEmpty(base.SelectedSeries))
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1161619942 ^ -1161588226);
		}
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-520155535 ^ -520124705), base.SelectedSeries, Source, Period, Factor);
	}

	static EnvelopesSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		MsT3ZoeBehY7sqmEhH9c();
	}

	internal static bool AbsSVkeBkGNY5Cw5sxqa()
	{
		return vZ0JOWeBN20AXMs7KJde == null;
	}

	internal static EnvelopesSource ILx1CweB1b8drfaIPUcA()
	{
		return vZ0JOWeBN20AXMs7KJde;
	}

	internal static object tquYkveB5AIofjQlS9UX(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void KIIt3HeBSt2dddYdIQ8a()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object zJDTADeBxtJIRoh4Wj7B(object P_0, object P_1)
	{
		return ((IndicatorSourceBase)P_0).GetSeries((IndicatorsHelper)P_1);
	}

	internal static bool NXaHF3eBLwQMSYrLh86e(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void MsT3ZoeBehY7sqmEhH9c()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
