using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Dx;

namespace i41kqEiqGmxVb5Qg6wKc;

[Indicator("BullsPower", "BullsPower", false, Type = typeof(vVyG2SiqnTDQEkjU5PkJ))]
[DataContract(Name = "BullsPowerIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class vVyG2SiqnTDQEkjU5PkJ : IndicatorBase
{
	private int OWSiql23XZy;

	private ChartSeries jeHiq4plX5d;

	private static vVyG2SiqnTDQEkjU5PkJ fH87y2ecZmxqhvP6AFIM;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	public int Period
	{
		get
		{
			return OWSiql23XZy;
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
					num3 = LpWaTIecrphoWvbXc7yD(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				if (num3 == OWSiql23XZy)
				{
					return;
				}
				OWSiql23XZy = num3;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x446AB724 ^ 0x446A3092));
				OnPropertyChanged((string)bet7ZAecKh4HnacSslZP(-842040449 ^ -842012069));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[DisplayName("BullsPower")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "BullsPower")]
	public ChartSeries BPSeries
	{
		get
		{
			return jeHiq4plX5d ?? (jeHiq4plX5d = new ChartSeries(ChartSeriesType.Columns, Colors.Blue));
		}
		private set
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
					if (!object.Equals(objA, jeHiq4plX5d))
					{
						jeHiq4plX5d = objA;
						OnPropertyChanged((string)bet7ZAecKh4HnacSslZP(-671204305 ^ -671180259));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	public List<ChartLevel> R9KiqibaLaT => base.Levels;

	public vVyG2SiqnTDQEkjU5PkJ()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period = 13;
		base.Levels.Add(new ChartLevel(0m, Colors.Gray));
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void Execute()
	{
		double[] data = (double[])QArbgdecmVbRXgCX3rrx(base.Helper, Period);
		base.Series.Add(new IndicatorSeriesData(data, BPSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		BPSeries.AllColors = L5cl7hechUfZaMUeOb0v(P_0);
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		vVyG2SiqnTDQEkjU5PkJ vVyG2SiqnTDQEkjU5PkJ2 = (vVyG2SiqnTDQEkjU5PkJ)P_0;
		Period = hviYDgecwiC1j4cKaKPF(vVyG2SiqnTDQEkjU5PkJ2);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		IkJ4Bdec8MWwbErqQsyc(BPSeries, FfTH0cec7qQjX8jLrHZ6(vVyG2SiqnTDQEkjU5PkJ2));
		base.CopyTemplate(P_0, P_1);
	}

	public override string ToString()
	{
		return (string)JWEM8WecAYIu8aGMhbR8(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x32DEA4F1 ^ 0x32DE2301), base.Name, Period);
	}

	static vVyG2SiqnTDQEkjU5PkJ()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int LpWaTIecrphoWvbXc7yD(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object bet7ZAecKh4HnacSslZP(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool pFwLpWecVNTSPpUWWfwd()
	{
		return fH87y2ecZmxqhvP6AFIM == null;
	}

	internal static vVyG2SiqnTDQEkjU5PkJ sOkGb3ecCVW11dL5ZVkB()
	{
		return fH87y2ecZmxqhvP6AFIM;
	}

	internal static object QArbgdecmVbRXgCX3rrx(object P_0, int n)
	{
		return ((IndicatorsHelper)P_0).BullsPower(n);
	}

	internal static XColor L5cl7hechUfZaMUeOb0v(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static int hviYDgecwiC1j4cKaKPF(object P_0)
	{
		return ((vVyG2SiqnTDQEkjU5PkJ)P_0).Period;
	}

	internal static object FfTH0cec7qQjX8jLrHZ6(object P_0)
	{
		return ((vVyG2SiqnTDQEkjU5PkJ)P_0).BPSeries;
	}

	internal static void IkJ4Bdec8MWwbErqQsyc(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static object JWEM8WecAYIu8aGMhbR8(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
