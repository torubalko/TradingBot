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

namespace pmgNAJiT8NO512T5EgVW;

[DataContract(Name = "RSIIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("RSI", "RSI", false, Type = typeof(rgjbdViT7JFB7tcnOFNW))]
internal sealed class rgjbdViT7JFB7tcnOFNW : IndicatorBase
{
	private int z4oiy0GmJCR;

	private IndicatorSourceBase OeFiy2ZP5ML;

	private ChartSeries ICfiyHekFd5;

	internal static rgjbdViT7JFB7tcnOFNW gDsSaPegbOMC9ZejARZ6;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return z4oiy0GmJCR;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == z4oiy0GmJCR)
			{
				return;
			}
			z4oiy0GmJCR = num;
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--500511424 ^ 0x1DD5B576));
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x741B85CB ^ 0x741B14EF));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
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
			return OeFiy2ZP5ML ?? (OeFiy2ZP5ML = new StockSource());
		}
		set
		{
			if (indicatorSourceBase != OeFiy2ZP5ML)
			{
				OeFiy2ZP5ML = indicatorSourceBase;
				OnPropertyChanged((string)U68vTyeg1VkamEoiRS3r(-1801468030 ^ -1801498652));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "RSI")]
	[DisplayName("RSI")]
	public ChartSeries RSISeries
	{
		get
		{
			return ICfiyHekFd5 ?? (ICfiyHekFd5 = new ChartSeries(ChartSeriesType.Line, aRMkWqeg5amKsmeJnHK9()));
		}
		private set
		{
			if (!object.Equals(chartSeries, ICfiyHekFd5))
			{
				ICfiyHekFd5 = chartSeries;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7ADBF691 ^ 0x7ADB5CBF));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 == 0)
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
	public List<ChartLevel> kuPiTzF9YRU => base.Levels;

	public rgjbdViT7JFB7tcnOFNW()
	{
		AFBap1egSJookEOPQynK();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf != 0)
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
				base.Levels.Add(new ChartLevel(70m, kFa2eBegx9sQdci1InVD(Colors.Gray)));
				base.Levels.Add(new ChartLevel(30m, Colors.Gray));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
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
		double[] series = Source.GetSeries(base.Helper);
		if (series == null)
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
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
			double[] data = (double[])wK7ewtegLxxgXXfJ9MQl(base.Helper, series, Period);
			base.Series.Add(new IndicatorSeriesData(data, RSISeries));
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		VIpkguegeoANbwyRyFof(RSISeries, P_0.GetNextColor());
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		rgjbdViT7JFB7tcnOFNW rgjbdViT7JFB7tcnOFNW2 = (rgjbdViT7JFB7tcnOFNW)P_0;
		Period = plNfkKegsL3lWJUI35f7(rgjbdViT7JFB7tcnOFNW2);
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 != 0)
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
					Source = (IndicatorSourceBase)Fg6Ad9egXNUeBfbg5p7g(rgjbdViT7JFB7tcnOFNW2.Source);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
			break;
		}
		RSISeries.CopyTheme(rgjbdViT7JFB7tcnOFNW2.RSISeries);
		base.CopyTemplate(P_0, P_1);
	}

	public override string ToString()
	{
		return (string)SPQshNegcDeKldb3SCFc(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1251569705 ^ -1251604409), base.Name, Source, Period);
	}

	static rgjbdViT7JFB7tcnOFNW()
	{
		zOsR6xegjPZFwM3sTVDP();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool Qj9x9segNB9pBv9IiHd0()
	{
		return gDsSaPegbOMC9ZejARZ6 == null;
	}

	internal static rgjbdViT7JFB7tcnOFNW MPUG0uegkWeTtnBfPFgQ()
	{
		return gDsSaPegbOMC9ZejARZ6;
	}

	internal static object U68vTyeg1VkamEoiRS3r(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static Color aRMkWqeg5amKsmeJnHK9()
	{
		return Colors.Blue;
	}

	internal static void AFBap1egSJookEOPQynK()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static XColor kFa2eBegx9sQdci1InVD(Color P_0)
	{
		return P_0;
	}

	internal static object wK7ewtegLxxgXXfJ9MQl(object P_0, object P_1, int period)
	{
		return ((IndicatorsHelper)P_0).RSI((double[])P_1, period);
	}

	internal static void VIpkguegeoANbwyRyFof(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static int plNfkKegsL3lWJUI35f7(object P_0)
	{
		return ((rgjbdViT7JFB7tcnOFNW)P_0).Period;
	}

	internal static object Fg6Ad9egXNUeBfbg5p7g(object P_0)
	{
		return ((IndicatorSourceBase)P_0).CloneSource();
	}

	internal static object SPQshNegcDeKldb3SCFc(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void zOsR6xegjPZFwM3sTVDP()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
