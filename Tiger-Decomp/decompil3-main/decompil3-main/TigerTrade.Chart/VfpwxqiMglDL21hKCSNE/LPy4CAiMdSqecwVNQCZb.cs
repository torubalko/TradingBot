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

namespace VfpwxqiMglDL21hKCSNE;

[Indicator("AD", "AD", false, Type = typeof(LPy4CAiMdSqecwVNQCZb))]
[DataContract(Name = "ADIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class LPy4CAiMdSqecwVNQCZb : IndicatorBase
{
	private ChartSeries d1yiMqXMhcF;

	private static LPy4CAiMdSqecwVNQCZb FfvFEFeXe4bp5Kwpu8mM;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "AD")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("AD")]
	public ChartSeries ADSeries
	{
		get
		{
			return d1yiMqXMhcF ?? (d1yiMqXMhcF = new ChartSeries(ChartSeriesType.Line, J1pVCJeXcFN13ogDuVHH(Colors.Blue)));
		}
		private set
		{
			if (!DI5PKheXjNIa2mekku4V(chartSeries, d1yiMqXMhcF))
			{
				d1yiMqXMhcF = chartSeries;
				OnPropertyChanged((string)Ig0Q3FeXEDjRcIZg4hKN(0x4220DA8 ^ 0x422A8CC));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 != 0)
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
	public List<ChartLevel> S6XiMOrAXvs => base.Levels;

	public LPy4CAiMdSqecwVNQCZb()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	protected override void Execute()
	{
		double[] data = base.Helper.AD();
		ckywZ9eXQCv3yQHDMG6u(base.Series, new IndicatorSeriesData(data, ADSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		ADSeries.AllColors = QbJwbdeXdl0JWDj37QHR(P_0);
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		LPy4CAiMdSqecwVNQCZb lPy4CAiMdSqecwVNQCZb = (LPy4CAiMdSqecwVNQCZb)P_0;
		ADSeries.CopyTheme(lPy4CAiMdSqecwVNQCZb.ADSeries);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.CopyTemplate(P_0, P_1);
	}

	static LPy4CAiMdSqecwVNQCZb()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static XColor J1pVCJeXcFN13ogDuVHH(Color P_0)
	{
		return P_0;
	}

	internal static bool IUgN4PeXskSbwJ7Z5lFs()
	{
		return FfvFEFeXe4bp5Kwpu8mM == null;
	}

	internal static LPy4CAiMdSqecwVNQCZb gs46cneXXkBbJvuffuBy()
	{
		return FfvFEFeXe4bp5Kwpu8mM;
	}

	internal static bool DI5PKheXjNIa2mekku4V(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static object Ig0Q3FeXEDjRcIZg4hKN(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void ckywZ9eXQCv3yQHDMG6u(object P_0, object P_1)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1);
	}

	internal static XColor QbJwbdeXdl0JWDj37QHR(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}
}
