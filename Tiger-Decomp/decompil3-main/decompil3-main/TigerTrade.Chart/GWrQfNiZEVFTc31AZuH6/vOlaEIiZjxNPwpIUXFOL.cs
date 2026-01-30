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

namespace GWrQfNiZEVFTc31AZuH6;

[DataContract(Name = "WilliamsADIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("WilliamsAD", "WilliamsAD", false, Type = typeof(vOlaEIiZjxNPwpIUXFOL))]
internal sealed class vOlaEIiZjxNPwpIUXFOL : IndicatorBase
{
	private ChartSeries lrMiZ645sNt;

	internal static vOlaEIiZjxNPwpIUXFOL MSuJjOeReGkYwPlauQP2;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("WilliamsAD")]
	[DataMember(Name = "WAD")]
	public ChartSeries WADSeries
	{
		get
		{
			return lrMiZ645sNt ?? (lrMiZ645sNt = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			if (!object.Equals(objA, lrMiZ645sNt))
			{
				lrMiZ645sNt = objA;
				OnPropertyChanged((string)yELWqEeRcsk44cTHFtid(0x735715F1 ^ 0x7357BF3B));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa != 0)
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
	public List<ChartLevel> r9EiZRB96Ks => base.Levels;

	public vOlaEIiZjxNPwpIUXFOL()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	protected override void Execute()
	{
		double[] data = (double[])AskqvYeRjm1LtfKTLhTR(base.Helper);
		biaBXQeREgm6O9uorYjt(base.Series, new IndicatorSeriesData(data, WADSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		WADSeries.AllColors = CFBOuMeRQA47RJvR4MY6(P_0);
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 1;
		int num2 = num;
		vOlaEIiZjxNPwpIUXFOL vOlaEIiZjxNPwpIUXFOL2 = default(vOlaEIiZjxNPwpIUXFOL);
		while (true)
		{
			switch (num2)
			{
			case 1:
				vOlaEIiZjxNPwpIUXFOL2 = (vOlaEIiZjxNPwpIUXFOL)P_0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf == 0)
				{
					num2 = 0;
				}
				break;
			default:
				WADSeries.CopyTheme(vOlaEIiZjxNPwpIUXFOL2.WADSeries);
				base.CopyTemplate(P_0, P_1);
				return;
			}
		}
	}

	static vOlaEIiZjxNPwpIUXFOL()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool BmvDVdeRskYAAbqM6l5r()
	{
		return MSuJjOeReGkYwPlauQP2 == null;
	}

	internal static vOlaEIiZjxNPwpIUXFOL P7kIUdeRXvioM7h4WvFJ()
	{
		return MSuJjOeReGkYwPlauQP2;
	}

	internal static object yELWqEeRcsk44cTHFtid(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object AskqvYeRjm1LtfKTLhTR(object P_0)
	{
		return ((IndicatorsHelper)P_0).WilliamsAD();
	}

	internal static void biaBXQeREgm6O9uorYjt(object P_0, object P_1)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1);
	}

	internal static XColor CFBOuMeRQA47RJvR4MY6(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}
}
