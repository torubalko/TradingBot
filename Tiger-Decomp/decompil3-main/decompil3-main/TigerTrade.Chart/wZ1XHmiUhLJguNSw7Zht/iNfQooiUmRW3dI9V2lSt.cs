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

namespace wZ1XHmiUhLJguNSw7Zht;

[DataContract(Name = "OnBalanceVolumeIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("OnBalanceVolume", "OnBalanceVolume", false, Type = typeof(iNfQooiUmRW3dI9V2lSt))]
internal sealed class iNfQooiUmRW3dI9V2lSt : IndicatorBase
{
	private ChartSeries ukIiUPqnmUS;

	private static iNfQooiUmRW3dI9V2lSt Vi68xQed55ZRQHrkDkfw;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "OBV")]
	[DisplayName("OBV")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries OBVSeries
	{
		get
		{
			return ukIiUPqnmUS ?? (ukIiUPqnmUS = new ChartSeries(ChartSeriesType.Line, ljqyeoedLPgtKqBBk3C4(Colors.Blue)));
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
					ukIiUPqnmUS = chartSeries;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2002318893 ^ -2002280443));
					return;
				case 1:
					if (onnuvfedeRLEpJmDFgOT(chartSeries, ukIiUPqnmUS))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 == 0)
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
	public List<ChartLevel> nYOiUAufD0y => base.Levels;

	public iNfQooiUmRW3dI9V2lSt()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	protected override void Execute()
	{
		double[] data = base.Helper.OBV();
		s1mRMqedsmw1WQpEvk2c(base.Series, new IndicatorSeriesData(data, OBVSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		AJZrBKedXsirYZMge0YK(OBVSeries, P_0.GetNextColor());
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 1;
		int num2 = num;
		iNfQooiUmRW3dI9V2lSt iNfQooiUmRW3dI9V2lSt2 = default(iNfQooiUmRW3dI9V2lSt);
		while (true)
		{
			switch (num2)
			{
			default:
				OBVSeries.CopyTheme((ChartSeries)dBi5vAedcC70DbSpdU9t(iNfQooiUmRW3dI9V2lSt2));
				base.CopyTemplate(P_0, P_1);
				return;
			case 1:
				iNfQooiUmRW3dI9V2lSt2 = (iNfQooiUmRW3dI9V2lSt)P_0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static iNfQooiUmRW3dI9V2lSt()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static XColor ljqyeoedLPgtKqBBk3C4(Color P_0)
	{
		return P_0;
	}

	internal static bool nnyqqFedSValPLOji9ns()
	{
		return Vi68xQed55ZRQHrkDkfw == null;
	}

	internal static iNfQooiUmRW3dI9V2lSt n9DdrKedxtLh2j8SkcGv()
	{
		return Vi68xQed55ZRQHrkDkfw;
	}

	internal static bool onnuvfedeRLEpJmDFgOT(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void s1mRMqedsmw1WQpEvk2c(object P_0, object P_1)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1);
	}

	internal static void AJZrBKedXsirYZMge0YK(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static object dBi5vAedcC70DbSpdU9t(object P_0)
	{
		return ((iNfQooiUmRW3dI9V2lSt)P_0).OBVSeries;
	}
}
