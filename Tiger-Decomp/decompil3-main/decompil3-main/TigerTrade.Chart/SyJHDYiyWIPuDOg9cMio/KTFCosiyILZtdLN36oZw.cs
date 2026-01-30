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

namespace SyJHDYiyWIPuDOg9cMio;

[DataContract(Name = "TRIXIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("TRIX", "TRIX", false, Type = typeof(KTFCosiyILZtdLN36oZw))]
internal sealed class KTFCosiyILZtdLN36oZw : IndicatorBase
{
	private int gwBiyCJGp5M;

	private ChartSeries Ls9iyrr3NrO;

	internal static KTFCosiyILZtdLN36oZw qCaFOZegAUKRurRhO8dU;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "Period")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	public int Period
	{
		get
		{
			return gwBiyCJGp5M;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3 = Math.Max(1, num3);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
					{
						num2 = 1;
					}
					break;
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x3E0426F0 ^ 0x3E04A146));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7D553BE0 ^ 0x7D55AAC4));
					return;
				case 1:
					if (num3 == gwBiyCJGp5M)
					{
						return;
					}
					gwBiyCJGp5M = num3;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "TRIX")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("TRIX")]
	public ChartSeries TRIXSeries
	{
		get
		{
			return Ls9iyrr3NrO ?? (Ls9iyrr3NrO = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			if (!object.Equals(chartSeries, Ls9iyrr3NrO))
			{
				Ls9iyrr3NrO = chartSeries;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x50C1C840 ^ 0x50C1622C));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> gq0iyV6Cb4X => base.Levels;

	public KTFCosiyILZtdLN36oZw()
	{
		LwbKsSegFSB9UtrVEwVK();
		base._002Ector();
		Period = 18;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.Levels.Add(new ChartLevel(0m, Colors.Gray));
	}

	protected override void Execute()
	{
		double[] data = (double[])rW8qUKeg3c7kJp7gJdVy(base.Helper, Period);
		base.Series.Add(new IndicatorSeriesData(data, TRIXSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		TRIXSeries.AllColors = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		KTFCosiyILZtdLN36oZw kTFCosiyILZtdLN36oZw = (KTFCosiyILZtdLN36oZw)P_0;
		Period = kTFCosiyILZtdLN36oZw.Period;
		TRIXSeries.CopyTheme(kTFCosiyILZtdLN36oZw.TRIXSeries);
		base.CopyTemplate(P_0, P_1);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2BD86B18 ^ 0x2BD8ECE8), base.Name, Period);
	}

	static KTFCosiyILZtdLN36oZw()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool grPKQiegP5RXrUrmBRPR()
	{
		return qCaFOZegAUKRurRhO8dU == null;
	}

	internal static KTFCosiyILZtdLN36oZw ONFkQ0egJkdkCH5G5Ykf()
	{
		return qCaFOZegAUKRurRhO8dU;
	}

	internal static void LwbKsSegFSB9UtrVEwVK()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object rW8qUKeg3c7kJp7gJdVy(object P_0, int period)
	{
		return ((IndicatorsHelper)P_0).TRIX(period);
	}
}
