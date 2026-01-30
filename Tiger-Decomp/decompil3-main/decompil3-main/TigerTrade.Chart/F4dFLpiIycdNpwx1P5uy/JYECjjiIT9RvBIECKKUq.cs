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
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.Sources;
using TigerTrade.Dx;

namespace F4dFLpiIycdNpwx1P5uy;

[Indicator("EldersForceIndex", "EldersForceIndex", false, Type = typeof(JYECjjiIT9RvBIECKKUq))]
[DataContract(Name = "EldersForceIndexIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class JYECjjiIT9RvBIECKKUq : IndicatorBase
{
	private int RWDiIACe2wk;

	private IndicatorMaType ADiiIPueiE7;

	private IndicatorSourceBase IHuiIJf6V5j;

	private ChartSeries RQxiIFLmNDG;

	private static JYECjjiIT9RvBIECKKUq xU2rhFeEGRVbDnlrCk0l;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return RWDiIACe2wk;
		}
		set
		{
			num = Rde4EKeEvY6sYRFPLp7P(1, num);
			int num2;
			if (num != RWDiIACe2wk)
			{
				RWDiIACe2wk = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7ADBF691 ^ 0x7ADB7127));
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b != 0)
				{
					num2 = 0;
				}
			}
			else
			{
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa == 0)
				{
					num2 = 1;
				}
			}
			switch (num2)
			{
			case 1:
				return;
			}
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x746ED405 ^ 0x746E4521));
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "MaType")]
	public IndicatorMaType MaType
	{
		get
		{
			return ADiiIPueiE7;
		}
		set
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
					if (indicatorMaType != ADiiIPueiE7)
					{
						ADiiIPueiE7 = indicatorMaType;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-53782092 ^ -53748020));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
					{
						num2 = 0;
					}
					break;
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
			return IHuiIJf6V5j ?? (IHuiIJf6V5j = new StockSource());
		}
		set
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
					if (indicatorSourceBase != IHuiIJf6V5j)
					{
						IHuiIJf6V5j = indicatorSourceBase;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-29702950 ^ -29733700));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName("EFI")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "EFI")]
	public ChartSeries EFISeries
	{
		get
		{
			return RQxiIFLmNDG ?? (RQxiIFLmNDG = new ChartSeries(ChartSeriesType.Line, NX8wNReEagfAdl9tGFil(vxTPTOeEBT1FAPp0raca())));
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
					if (!FWNQRoeEiDdC3jso3kwB(chartSeries, RQxiIFLmNDG))
					{
						RQxiIFLmNDG = chartSeries;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-520155535 ^ -520116609));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
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
	public List<ChartLevel> eqKiI8DAbFW => base.Levels;

	public JYECjjiIT9RvBIECKKUq()
	{
		eU2FLeeElam1oq6vOryV();
		base._002Ector();
		Period = 13;
		MaType = IndicatorMaType.EMA;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			base.Levels.Add(new ChartLevel(0m, jclqZEeE4ZBtBe4Tv6sK()));
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
			{
				num = 0;
			}
		}
	}

	protected override void Execute()
	{
		double[] series = Source.GetSeries(base.Helper);
		if (series != null)
		{
			double[] data = (double[])rcAxcAeEDpM7gtW8JtZU(base.Helper, series, MaType, Period);
			base.Series.Add(new IndicatorSeriesData(data, EFISeries));
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
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

	public override void ApplyColors(IChartTheme P_0)
	{
		qURNHFeEbRxSreScL5ag(EFISeries, P_0.GetNextColor());
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 1;
		int num2 = num;
		JYECjjiIT9RvBIECKKUq jYECjjiIT9RvBIECKKUq = default(JYECjjiIT9RvBIECKKUq);
		while (true)
		{
			switch (num2)
			{
			case 1:
				jYECjjiIT9RvBIECKKUq = (JYECjjiIT9RvBIECKKUq)P_0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Period = udxlcJeENJLdm1YlcehY(jYECjjiIT9RvBIECKKUq);
				MaType = jYECjjiIT9RvBIECKKUq.MaType;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				base.CopyTemplate(P_0, P_1);
				return;
			case 2:
				if (!P_1)
				{
					Source = (IndicatorSourceBase)NvVZEpeEkZwjdE3ssXId(jYECjjiIT9RvBIECKKUq.Source);
				}
				EFISeries.CopyTheme(jYECjjiIT9RvBIECKKUq.EFISeries);
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return (string)mjAsCDeE1TgN17q5Yrao(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--18459671 ^ 0x1192639), Source, Period);
	}

	static JYECjjiIT9RvBIECKKUq()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int Rde4EKeEvY6sYRFPLp7P(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool PbqKu7eEYarj4rHYiltY()
	{
		return xU2rhFeEGRVbDnlrCk0l == null;
	}

	internal static JYECjjiIT9RvBIECKKUq xPuLwYeEou2gLqZ3GUh7()
	{
		return xU2rhFeEGRVbDnlrCk0l;
	}

	internal static Color vxTPTOeEBT1FAPp0raca()
	{
		return Colors.Blue;
	}

	internal static XColor NX8wNReEagfAdl9tGFil(Color P_0)
	{
		return P_0;
	}

	internal static bool FWNQRoeEiDdC3jso3kwB(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void eU2FLeeElam1oq6vOryV()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static Color jclqZEeE4ZBtBe4Tv6sK()
	{
		return Colors.Gray;
	}

	internal static object rcAxcAeEDpM7gtW8JtZU(object P_0, object P_1, IndicatorMaType type, int n)
	{
		return ((IndicatorsHelper)P_0).EFI((double[])P_1, type, n);
	}

	internal static void qURNHFeEbRxSreScL5ag(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static int udxlcJeENJLdm1YlcehY(object P_0)
	{
		return ((JYECjjiIT9RvBIECKKUq)P_0).Period;
	}

	internal static object NvVZEpeEkZwjdE3ssXId(object P_0)
	{
		return ((IndicatorSourceBase)P_0).CloneSource();
	}

	internal static object mjAsCDeE1TgN17q5Yrao(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
