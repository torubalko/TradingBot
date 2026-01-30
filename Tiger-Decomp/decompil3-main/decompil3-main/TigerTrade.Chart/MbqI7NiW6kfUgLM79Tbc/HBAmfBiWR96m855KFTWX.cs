using System;
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

namespace MbqI7NiW6kfUgLM79Tbc;

[Indicator("Ichimoku", "Ichimoku", true, Type = typeof(HBAmfBiWR96m855KFTWX))]
[DataContract(Name = "IchimokuIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class HBAmfBiWR96m855KFTWX : IndicatorBase
{
	private int uyniWFwjmE7;

	private int eWNiW3EciFG;

	private int D0uiWpZVA6E;

	private int BCbiWupeWin;

	private int l6uiWz17483;

	private ChartSeries NYAit0YwbAq;

	private ChartSeries Fn9it2wVcZF;

	private ChartSeries nWWitHkKCJy;

	private ChartSeries pYUitfE9AFk;

	private ChartSeries iBVit9C8qXp;

	private ChartRegion ThQitnqggCN;

	private static HBAmfBiWR96m855KFTWX lPlWqQeEwVMxSYH8cLFv;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "Period1")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DisplayName("Tenkan")]
	public int Period1
	{
		get
		{
			return uyniWFwjmE7;
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
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D3134C9 ^ 0x2D31A5ED));
					return;
				case 2:
					num3 = Math.Max(1, num3);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (num3 == uyniWFwjmE7)
					{
						return;
					}
					uyniWFwjmE7 = num3;
					OnPropertyChanged((string)TwQ1uWeEA0OYggQ9oiTS(-1309555870 ^ -1309586952));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period2")]
	[DisplayName("Kijun")]
	public int Period2
	{
		get
		{
			return eWNiW3EciFG;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == eWNiW3EciFG)
			{
				return;
			}
			eWNiW3EciFG = num;
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 != 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1841489831 ^ -1841458443));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28B345BB ^ 0x28B3D49F));
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b != 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShift")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period3")]
	public int Period3
	{
		get
		{
			return D0uiWpZVA6E;
		}
		set
		{
			num = Math.Max(1, num);
			int num2;
			if (num == D0uiWpZVA6E)
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
				{
					num2 = 1;
				}
			}
			else
			{
				D0uiWpZVA6E = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x34407BB ^ 0x3448D05));
				OnPropertyChanged((string)TwQ1uWeEA0OYggQ9oiTS(-894902996 ^ -894940152));
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 1:
				break;
			case 0:
				break;
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period4")]
	[DisplayName("SenkouB")]
	public int Period4
	{
		get
		{
			return BCbiWupeWin;
		}
		set
		{
			num = VihuSneEPy8WqyPINRYu(1, num);
			if (num == BCbiWupeWin)
			{
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				BCbiWupeWin = num;
				OnPropertyChanged((string)TwQ1uWeEA0OYggQ9oiTS(-1416986301 ^ -1417016429));
			}
		}
	}

	[DisplayName("Chikou")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period5")]
	public int Period5
	{
		get
		{
			return l6uiWz17483;
		}
		set
		{
			num = Math.Max(1, num);
			if (num != l6uiWz17483)
			{
				l6uiWz17483 = num;
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--18459671 ^ 0x11926F5));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("Tenkan")]
	[DataMember(Name = "Tenkan")]
	public ChartSeries TenkanSeries
	{
		get
		{
			return NYAit0YwbAq ?? (NYAit0YwbAq = new ChartSeries(ChartSeriesType.Line, YarcqqeEFJnksJwdqfOk(pwyTi5eEJahbOkdoUp7N())));
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
					if (!object.Equals(chartSeries, NYAit0YwbAq))
					{
						NYAit0YwbAq = chartSeries;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1A5F1B9E ^ 0x1A5FB3CE));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("Kijun")]
	[DataMember(Name = "Kijun")]
	public ChartSeries KijunSeries
	{
		get
		{
			return Fn9it2wVcZF ?? (Fn9it2wVcZF = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
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
				case 1:
					if (object.Equals(chartSeries, Fn9it2wVcZF))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
						{
							num2 = 0;
						}
						break;
					}
					Fn9it2wVcZF = chartSeries;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x37B74BDF ^ 0x37B7E3B3));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("SenkouA")]
	[DataMember(Name = "SenkouA")]
	public ChartSeries SenkouASeries
	{
		get
		{
			return nWWitHkKCJy ?? (nWWitHkKCJy = new ChartSeries(ChartSeriesType.Line, pwyTi5eEJahbOkdoUp7N()));
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
				case 1:
					if (ybXwogeE30lAjp0Akvpu(chartSeries, nWWitHkKCJy))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
						{
							num2 = 0;
						}
						break;
					}
					nWWitHkKCJy = chartSeries;
					OnPropertyChanged((string)TwQ1uWeEA0OYggQ9oiTS(-1416986301 ^ -1417008699));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("SenkouB")]
	[DataMember(Name = "SenkouB")]
	public ChartSeries SenkouBSeries
	{
		get
		{
			return pYUitfE9AFk ?? (pYUitfE9AFk = new ChartSeries(ChartSeriesType.Line, YarcqqeEFJnksJwdqfOk(Colors.Blue)));
		}
		private set
		{
			if (!object.Equals(objA, pYUitfE9AFk))
			{
				pYUitfE9AFk = objA;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-45476899 ^ -45433991));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
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

	[DataMember(Name = "Chikou")]
	[DisplayName("Chikou")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries ChikouSeries
	{
		get
		{
			return iBVit9C8qXp ?? (iBVit9C8qXp = new ChartSeries(ChartSeriesType.Line, pwyTi5eEJahbOkdoUp7N()));
		}
		private set
		{
			if (!object.Equals(objA, iBVit9C8qXp))
			{
				iBVit9C8qXp = objA;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-90307782 ^ -90264584));
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
		}
	}

	[DataMember(Name = "Kumo")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("Kumo")]
	public ChartRegion KumoRegion
	{
		get
		{
			return ThQitnqggCN ?? (ThQitnqggCN = new ChartRegion(YarcqqeEFJnksJwdqfOk(Color.FromArgb(50, 0, 0, 0))));
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
				case 1:
					if (ybXwogeE30lAjp0Akvpu(chartRegion, ThQitnqggCN))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
						{
							num2 = 0;
						}
						break;
					}
					ThQitnqggCN = chartRegion;
					OnPropertyChanged((string)TwQ1uWeEA0OYggQ9oiTS(-371631841 ^ -371592767));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public HBAmfBiWR96m855KFTWX()
	{
		X6nvZgeEpWq6lOCeRb0x();
		base._002Ector();
		Period1 = 9;
		Period2 = 26;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				Period4 = 52;
				Period5 = 26;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb == 0)
				{
					num = 2;
				}
				break;
			default:
				Period3 = 26;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		base.Helper.Ichimoku(Period1, Period2, Period3, Period4, Period5, out var tenkan, out var kijun, out var senkouA, out var senkouB, out var chikou);
		IndicatorSeriesData indicatorSeriesData = new IndicatorSeriesData(senkouA, KumoRegion) { [(string)TwQ1uWeEA0OYggQ9oiTS(--855742383 ^ 0x33011569)] = senkouB };
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.Series.Add(new IndicatorSeriesData(tenkan, TenkanSeries), new IndicatorSeriesData(kijun, KijunSeries), new IndicatorSeriesData(senkouA, SenkouASeries), new IndicatorSeriesData(senkouB, SenkouBSeries), indicatorSeriesData, new IndicatorSeriesData(chikou, ChikouSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		C0R6uheEzqRiT0p0WReU(TenkanSeries, fKFRqleEu0ZpPZtUlS5y(P_0));
		KijunSeries.AllColors = P_0.GetNextColor();
		C0R6uheEzqRiT0p0WReU(ChikouSeries, fKFRqleEu0ZpPZtUlS5y(P_0));
		SenkouASeries.AllColors = fKFRqleEu0ZpPZtUlS5y(P_0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				mwwaw5eQ0L3YPJxMFwv8(KumoRegion, new XColor(50, SenkouASeries.Color));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				base.ApplyColors(P_0);
				return;
			case 1:
				SenkouBSeries.AllColors = SenkouASeries.Color;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 2;
		HBAmfBiWR96m855KFTWX hBAmfBiWR96m855KFTWX = default(HBAmfBiWR96m855KFTWX);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					SenkouASeries.CopyTheme((ChartSeries)J36VGweQGJQnxUpUS7mC(hBAmfBiWR96m855KFTWX));
					SenkouBSeries.CopyTheme((ChartSeries)aa9SnyeQYaMdTdMKn3ZY(hBAmfBiWR96m855KFTWX));
					KumoRegion.CopyTheme((ChartRegion)wZ6YjfeQoJve4mZ7SMZh(hBAmfBiWR96m855KFTWX));
					num2 = 4;
					continue;
				case 2:
					hBAmfBiWR96m855KFTWX = (HBAmfBiWR96m855KFTWX)P_0;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					Period4 = hBAmfBiWR96m855KFTWX.Period4;
					Period5 = hBAmfBiWR96m855KFTWX.Period5;
					TenkanSeries.CopyTheme(hBAmfBiWR96m855KFTWX.TenkanSeries);
					KijunSeries.CopyTheme((ChartSeries)dZSkaSeQfrF9tPlP5emJ(hBAmfBiWR96m855KFTWX));
					d9kfFieQn63NSGLF5Mc3(ChikouSeries, N4RkXJeQ9BDQNVEGQNTb(hBAmfBiWR96m855KFTWX));
					num2 = 5;
					continue;
				case 4:
					base.CopyTemplate(P_0, P_1);
					return;
				case 1:
					Period1 = PpgaDoeQ2bhPKZfnx57t(hBAmfBiWR96m855KFTWX);
					Period2 = hBAmfBiWR96m855KFTWX.Period2;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			Period3 = nKFq44eQHyw0WXotPxEy(hBAmfBiWR96m855KFTWX);
			num = 3;
		}
	}

	public override string ToString()
	{
		return (string)gr9RqpeQvXbmNTkJdIeC(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1346994499 ^ -1346963949), new object[4] { base.Name, Period1, Period2, Period3 });
	}

	static HBAmfBiWR96m855KFTWX()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object TwQ1uWeEA0OYggQ9oiTS(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool jfWvWWeE71NnnAiAKC06()
	{
		return lPlWqQeEwVMxSYH8cLFv == null;
	}

	internal static HBAmfBiWR96m855KFTWX E0x94LeE8aWramUVT5kA()
	{
		return lPlWqQeEwVMxSYH8cLFv;
	}

	internal static int VihuSneEPy8WqyPINRYu(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static Color pwyTi5eEJahbOkdoUp7N()
	{
		return Colors.Blue;
	}

	internal static XColor YarcqqeEFJnksJwdqfOk(Color P_0)
	{
		return P_0;
	}

	internal static bool ybXwogeE30lAjp0Akvpu(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void X6nvZgeEpWq6lOCeRb0x()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static XColor fKFRqleEu0ZpPZtUlS5y(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static void C0R6uheEzqRiT0p0WReU(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static void mwwaw5eQ0L3YPJxMFwv8(object P_0, XColor value)
	{
		((ChartRegion)P_0).Color = value;
	}

	internal static int PpgaDoeQ2bhPKZfnx57t(object P_0)
	{
		return ((HBAmfBiWR96m855KFTWX)P_0).Period1;
	}

	internal static int nKFq44eQHyw0WXotPxEy(object P_0)
	{
		return ((HBAmfBiWR96m855KFTWX)P_0).Period3;
	}

	internal static object dZSkaSeQfrF9tPlP5emJ(object P_0)
	{
		return ((HBAmfBiWR96m855KFTWX)P_0).KijunSeries;
	}

	internal static object N4RkXJeQ9BDQNVEGQNTb(object P_0)
	{
		return ((HBAmfBiWR96m855KFTWX)P_0).ChikouSeries;
	}

	internal static void d9kfFieQn63NSGLF5Mc3(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static object J36VGweQGJQnxUpUS7mC(object P_0)
	{
		return ((HBAmfBiWR96m855KFTWX)P_0).SenkouASeries;
	}

	internal static object aa9SnyeQYaMdTdMKn3ZY(object P_0)
	{
		return ((HBAmfBiWR96m855KFTWX)P_0).SenkouBSeries;
	}

	internal static object wZ6YjfeQoJve4mZ7SMZh(object P_0)
	{
		return ((HBAmfBiWR96m855KFTWX)P_0).KumoRegion;
	}

	internal static object gr9RqpeQvXbmNTkJdIeC(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}
}
