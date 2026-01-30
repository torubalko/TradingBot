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
using TigerTrade.Chart.Indicators.Sources;
using TigerTrade.Dx;

namespace t7rtRliIQAb1PfsIpx4N;

[DataContract(Name = "CMOIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("CMO", "CMO", false, Type = typeof(OR5AGtiIE98TLccCpc1n))]
internal sealed class OR5AGtiIE98TLccCpc1n : IndicatorBase
{
	private int iG4iIWtunHX;

	private IndicatorSourceBase qhaiItJSI53;

	private ChartSeries qMxiIU6LZ0d;

	private static OR5AGtiIE98TLccCpc1n nZhaeQej3sKUoIV7ZqAi;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Period
	{
		get
		{
			return iG4iIWtunHX;
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
					num3 = Math.Max(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				if (num3 == iG4iIWtunHX)
				{
					return;
				}
				iG4iIWtunHX = num3;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4662F6AF ^ 0x46627119));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--855742383 ^ 0x3301068B));
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 != 0)
				{
					num2 = 0;
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
			return qhaiItJSI53 ?? (qhaiItJSI53 = new StockSource());
		}
		set
		{
			if (indicatorSourceBase != qhaiItJSI53)
			{
				qhaiItJSI53 = indicatorSourceBase;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1311293279 ^ -1311258425));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
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

	[DataMember(Name = "CMO")]
	[DisplayName("CMO")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries CMOSeries
	{
		get
		{
			return qMxiIU6LZ0d ?? (qMxiIU6LZ0d = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
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
					if (!object.Equals(objA, qMxiIU6LZ0d))
					{
						qMxiIU6LZ0d = objA;
						OnPropertyChanged((string)PvD911ejz9eLapMVoQ7p(0x6D18F862 ^ 0x6D185F9A));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa == 0)
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
	public List<ChartLevel> QW3iII0I1ug => base.Levels;

	public OR5AGtiIE98TLccCpc1n()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base.Levels.Add(new ChartLevel(50m, lUsZSmeE06kKWxkZVph6(Colors.Gray)));
				base.Levels.Add(new ChartLevel(-50m, lUsZSmeE06kKWxkZVph6(Colors.Gray)));
				return;
			}
			Period = 14;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
			{
				num = 1;
			}
		}
	}

	protected override void Execute()
	{
		double[] array = (double[])pFhxGAeE25guM6hCdUcp(Source, base.Helper);
		if (array == null)
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
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
			double[] data = (double[])GsAK9YeEH1W7wAlsVJEE(base.Helper, array, Period);
			base.Series.Add(new IndicatorSeriesData(data, CMOSeries));
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		CMOSeries.AllColors = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		OR5AGtiIE98TLccCpc1n oR5AGtiIE98TLccCpc1n = (OR5AGtiIE98TLccCpc1n)P_0;
		Period = xr7EUWeEfKI3Yem961n3(oR5AGtiIE98TLccCpc1n);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				if (!P_1)
				{
					Source = oR5AGtiIE98TLccCpc1n.Source.CloneSource();
				}
				CMOSeries.CopyTheme((ChartSeries)r0tNcweE9AVnpPMn1nD2(oR5AGtiIE98TLccCpc1n));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 != 0)
				{
					num = 0;
				}
				break;
			default:
				base.CopyTemplate(P_0, P_1);
				return;
			}
		}
	}

	public override string ToString()
	{
		return (string)s8rHdoeEnxfQFvUuwhdT(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28B345BB ^ 0x28B3C22B), base.Name, Source, Period);
	}

	static OR5AGtiIE98TLccCpc1n()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool c9JabyejphT0afV8V2ha()
	{
		return nZhaeQej3sKUoIV7ZqAi == null;
	}

	internal static OR5AGtiIE98TLccCpc1n HfM2uieju1pqeqhbUOhl()
	{
		return nZhaeQej3sKUoIV7ZqAi;
	}

	internal static object PvD911ejz9eLapMVoQ7p(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static XColor lUsZSmeE06kKWxkZVph6(Color P_0)
	{
		return P_0;
	}

	internal static object pFhxGAeE25guM6hCdUcp(object P_0, object P_1)
	{
		return ((IndicatorSourceBase)P_0).GetSeries((IndicatorsHelper)P_1);
	}

	internal static object GsAK9YeEH1W7wAlsVJEE(object P_0, object P_1, int period)
	{
		return ((IndicatorsHelper)P_0).CMO((double[])P_1, period);
	}

	internal static int xr7EUWeEfKI3Yem961n3(object P_0)
	{
		return ((OR5AGtiIE98TLccCpc1n)P_0).Period;
	}

	internal static object r0tNcweE9AVnpPMn1nD2(object P_0)
	{
		return ((OR5AGtiIE98TLccCpc1n)P_0).CMOSeries;
	}

	internal static object s8rHdoeEnxfQFvUuwhdT(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}
}
