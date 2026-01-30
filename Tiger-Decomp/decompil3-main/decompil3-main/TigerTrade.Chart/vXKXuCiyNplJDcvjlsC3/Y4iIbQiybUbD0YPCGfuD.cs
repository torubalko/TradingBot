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
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace vXKXuCiyNplJDcvjlsC3;

[DataContract(Name = "StochasticIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("Stochastic", "Stochastic", false, Type = typeof(Y4iIbQiybUbD0YPCGfuD))]
internal sealed class Y4iIbQiybUbD0YPCGfuD : IndicatorBase
{
	private int JCliygjddcp;

	private int cKDiyRvrjTE;

	private int ATFiy6UfATZ;

	private IndicatorMaType fS0iyMvlV8q;

	private ChartSeries SiriyOcB4bb;

	private ChartSeries vi9iyqX4BYw;

	private static Y4iIbQiybUbD0YPCGfuD Ej7vowegIxojwtefZWI1;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "FastK")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParametersPK")]
	public int FastK
	{
		get
		{
			return JCliygjddcp;
		}
		set
		{
			num = Math.Max(1, num);
			int num2;
			if (num == JCliygjddcp)
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
				{
					num2 = 0;
				}
			}
			else
			{
				JCliygjddcp = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1325234765 ^ -1325266851));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e == 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 0:
				break;
			case 1:
				OnPropertyChanged((string)IcB84UegUCdT3UrukBed(-1325234765 ^ -1325263721));
				break;
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSmooth")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParametersPK")]
	[DataMember(Name = "Smooth")]
	public int Smooth
	{
		get
		{
			return cKDiyRvrjTE;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (num3 == cKDiyRvrjTE)
					{
						return;
					}
					cKDiyRvrjTE = num3;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
					{
						num2 = 0;
					}
					break;
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-90307782 ^ -90272058));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x37B74BDF ^ 0x37B7DAFB));
					return;
				case 2:
					num3 = XahUVDegTKx951rQCjbX(1, num3);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "SlowD")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParametersPD")]
	public int SlowD
	{
		get
		{
			return ATFiy6UfATZ;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (num3 == ATFiy6UfATZ)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 != 0)
						{
							num2 = 0;
						}
						break;
					}
					ATFiy6UfATZ = num3;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x37B74BDF ^ 0x37B7C5D3));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-710503328 ^ -710539964));
					return;
				case 2:
					num3 = Math.Max(1, num3);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 != 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	[DataMember(Name = "SlowDMA")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParametersPD")]
	public IndicatorMaType SlowDMaType
	{
		get
		{
			return fS0iyMvlV8q;
		}
		set
		{
			if (indicatorMaType != fS0iyMvlV8q)
			{
				fS0iyMvlV8q = indicatorMaType;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x9F0F634 ^ 0x9F0782E));
			}
		}
	}

	[DisplayName("%K")]
	[DataMember(Name = "PK")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries PKSeries
	{
		get
		{
			return SiriyOcB4bb ?? (SiriyOcB4bb = new ChartSeries(ChartSeriesType.Line, CHF7TdegyCcKGun3T9uw()));
		}
		private set
		{
			if (!p4rJ8kegZYkjMSNT3LEY(chartSeries, SiriyOcB4bb))
			{
				SiriyOcB4bb = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1161619942 ^ -1161577378));
			}
		}
	}

	[DisplayName("%D")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "PD")]
	public ChartSeries PDSeries
	{
		get
		{
			return vi9iyqX4BYw ?? (vi9iyqX4BYw = new ChartSeries(ChartSeriesType.Line, u0pn0BegVVAX7BCiamAF(), XDashStyle.Dash));
		}
		private set
		{
			if (!p4rJ8kegZYkjMSNT3LEY(chartSeries, vi9iyqX4BYw))
			{
				vi9iyqX4BYw = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)IcB84UegUCdT3UrukBed(-1461949456 ^ -1461927512));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> KQRiydxSZ9P => base.Levels;

	public Y4iIbQiybUbD0YPCGfuD()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		FastK = 14;
		Smooth = 1;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				SlowD = 3;
				num = 2;
				break;
			case 1:
				base.Levels.Add(new ChartLevel(20m, sxs1NPegCsXxq6fKpA9r()));
				return;
			case 2:
				SlowDMaType = IndicatorMaType.SMA;
				base.Levels.Add(new ChartLevel(80m, Colors.Gray));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		base.Helper.Stoch(FastK, Smooth, IndicatorMaType.SMA, SlowD, SlowDMaType, out var slowK, out var slowD);
		SYEvXtegr1y40PObUO4d(base.Series, new IndicatorSeriesData(slowK, PKSeries), new IndicatorSeriesData(slowD, PDSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		m1qHrIegmEtMD0lAy1Fs(PKSeries, NY1fIbegKn1keyUY1v0c(P_0));
		PDSeries.AllColors = P_0.GetNextColor();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		Y4iIbQiybUbD0YPCGfuD y4iIbQiybUbD0YPCGfuD = (Y4iIbQiybUbD0YPCGfuD)P_0;
		FastK = CXXUF4eghmpqdOy38XUB(y4iIbQiybUbD0YPCGfuD);
		Smooth = YVQe04egwSi4XUf8rZB3(y4iIbQiybUbD0YPCGfuD);
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				SlowD = y4iIbQiybUbD0YPCGfuD.SlowD;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e == 0)
				{
					num = 0;
				}
				continue;
			}
			SlowDMaType = JMPR0Ueg7FOon3Sdma7f(y4iIbQiybUbD0YPCGfuD);
			PKSeries.CopyTheme(y4iIbQiybUbD0YPCGfuD.PKSeries);
			PDSeries.CopyTheme(y4iIbQiybUbD0YPCGfuD.PDSeries);
			base.CopyTemplate(P_0, P_1);
			num = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
			{
				num = 2;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)IcB84UegUCdT3UrukBed(-1127423276 ^ -1127454086), base.Name, FastK, Smooth, SlowD);
	}

	static Y4iIbQiybUbD0YPCGfuD()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		WFCX1Feg86X2xC2mKPg4();
	}

	internal static object IcB84UegUCdT3UrukBed(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool MRrDdFegWuoFN8sj05Tu()
	{
		return Ej7vowegIxojwtefZWI1 == null;
	}

	internal static Y4iIbQiybUbD0YPCGfuD TbNWLXegtAk2UbjsfWey()
	{
		return Ej7vowegIxojwtefZWI1;
	}

	internal static int XahUVDegTKx951rQCjbX(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static Color CHF7TdegyCcKGun3T9uw()
	{
		return Colors.Green;
	}

	internal static bool p4rJ8kegZYkjMSNT3LEY(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static Color u0pn0BegVVAX7BCiamAF()
	{
		return Colors.Red;
	}

	internal static Color sxs1NPegCsXxq6fKpA9r()
	{
		return Colors.Gray;
	}

	internal static void SYEvXtegr1y40PObUO4d(object P_0, object P_1, object P_2)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1, (IndicatorSeriesData)P_2);
	}

	internal static XColor NY1fIbegKn1keyUY1v0c(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static void m1qHrIegmEtMD0lAy1Fs(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static int CXXUF4eghmpqdOy38XUB(object P_0)
	{
		return ((Y4iIbQiybUbD0YPCGfuD)P_0).FastK;
	}

	internal static int YVQe04egwSi4XUf8rZB3(object P_0)
	{
		return ((Y4iIbQiybUbD0YPCGfuD)P_0).Smooth;
	}

	internal static IndicatorMaType JMPR0Ueg7FOon3Sdma7f(object P_0)
	{
		return ((Y4iIbQiybUbD0YPCGfuD)P_0).SlowDMaType;
	}

	internal static void WFCX1Feg86X2xC2mKPg4()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
