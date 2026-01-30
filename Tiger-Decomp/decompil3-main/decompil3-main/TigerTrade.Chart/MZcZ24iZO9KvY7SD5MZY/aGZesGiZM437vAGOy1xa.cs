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
using TigerTrade.Chart.Indicators.Collections;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Dx;

namespace MZcZ24iZO9KvY7SD5MZY;

[DataContract(Name = "WilliamsRIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("WilliamsR", "WilliamsR", false, Type = typeof(aGZesGiZM437vAGOy1xa))]
internal sealed class aGZesGiZM437vAGOy1xa : IndicatorBase
{
	private int yEhiZymL8CT;

	private ChartSeries iVZiZZ7As21;

	internal static aGZesGiZM437vAGOy1xa PuIVLIeRdqVv0IKhJiQR;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return yEhiZymL8CT;
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
					num3 = T2W1j2eR6RM5QKIkQDuX(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				if (num3 != yEhiZymL8CT)
				{
					yEhiZymL8CT = num3;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6D18F862 ^ 0x6D187FD4));
					OnPropertyChanged((string)o7hmxceRMIGAlhCtbDS9(0x11D1040B ^ 0x11D1952F));
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 != 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[DataMember(Name = "WR")]
	[DisplayName("WilliamsR")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries WRSeries
	{
		get
		{
			return iVZiZZ7As21 ?? (iVZiZZ7As21 = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			if (!object.Equals(objA, iVZiZZ7As21))
			{
				iVZiZZ7As21 = objA;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-710503328 ^ -710525312));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> Ly0iZTfInp3 => base.Levels;

	public aGZesGiZM437vAGOy1xa()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Period = 14;
				base.Levels.Add(new ChartLevel(-20m, fWyLgjeROtRt3eLCIImM()));
				base.Levels.Add(new ChartLevel(-80m, Colors.Gray));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void Execute()
	{
		double[] data = base.Helper.WilliamsR(Period);
		AZPqekeRqJG2pS65AYGK(base.Series, new IndicatorSeriesData(data, WRSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		WRSeries.AllColors = sGqMm5eRIQny3iXsVMBu(P_0);
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		aGZesGiZM437vAGOy1xa aGZesGiZM437vAGOy1xa2 = (aGZesGiZM437vAGOy1xa)P_0;
		Period = aGZesGiZM437vAGOy1xa2.Period;
		WRSeries.CopyTheme(aGZesGiZM437vAGOy1xa2.WRSeries);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.CopyTemplate(P_0, P_1);
	}

	public override string ToString()
	{
		return string.Format((string)o7hmxceRMIGAlhCtbDS9(-838841832 ^ -838808088), base.Name, Period);
	}

	static aGZesGiZM437vAGOy1xa()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		UYkcDCeRWPNE84tyEuKk();
	}

	internal static int T2W1j2eR6RM5QKIkQDuX(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object o7hmxceRMIGAlhCtbDS9(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool Lrhv7WeRg8JP7uWTIaXj()
	{
		return PuIVLIeRdqVv0IKhJiQR == null;
	}

	internal static aGZesGiZM437vAGOy1xa evPmUfeRRr9E097T1BDi()
	{
		return PuIVLIeRdqVv0IKhJiQR;
	}

	internal static Color fWyLgjeROtRt3eLCIImM()
	{
		return Colors.Gray;
	}

	internal static void AZPqekeRqJG2pS65AYGK(object P_0, object P_1)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1);
	}

	internal static XColor sGqMm5eRIQny3iXsVMBu(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static void UYkcDCeRWPNE84tyEuKk()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
