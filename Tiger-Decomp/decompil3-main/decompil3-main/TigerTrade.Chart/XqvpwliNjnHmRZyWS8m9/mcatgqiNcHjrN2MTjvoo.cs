using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace XqvpwliNjnHmRZyWS8m9;

[DataContract(Name = "ClusterStatisticIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("ClusterStatistic", "ClusterStatistic", false, Type = typeof(mcatgqiNcHjrN2MTjvoo))]
internal sealed class mcatgqiNcHjrN2MTjvoo : IndicatorBase
{
	private ClusterStatisticPeriodType oXmiNmu8sOD;

	private bool H0GiNhCnGqE;

	private IndicatorIntParam xrBiNwS48oX;

	private bool JdWiN7oiuTq;

	private bool HHKiN8RCtTQ;

	private bool jMliNAoQ7m4;

	private bool jGciNPoGhMy;

	private bool LdBiNJ3bs6q;

	internal static mcatgqiNcHjrN2MTjvoo Kn7IrneDU15UN5F5PUmZ;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public ClusterStatisticPeriodType Period
	{
		get
		{
			return oXmiNmu8sOD;
		}
		set
		{
			if (clusterStatisticPeriodType != oXmiNmu8sOD)
			{
				oXmiNmu8sOD = clusterStatisticPeriodType;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1153206687 ^ -1153175081));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimizeValues")]
	[DataMember(Name = "MinimizeValues")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public bool MinimizeValues
	{
		get
		{
			return H0GiNhCnGqE;
		}
		set
		{
			if (flag != H0GiNhCnGqE)
			{
				H0GiNhCnGqE = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1161619942 ^ -1161588212));
			}
		}
	}

	[DataMember(Name = "RoundValueParam")]
	public IndicatorIntParam CkTiNOWm0ac
	{
		get
		{
			return xrBiNwS48oX ?? (xrBiNwS48oX = new IndicatorIntParam(0));
		}
		set
		{
			xrBiNwS48oX = indicatorIntParam;
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsRoundValues")]
	[DefaultValue(0)]
	public int RoundValues
	{
		get
		{
			return CkTiNOWm0ac.Get(base.SettingsLongKey);
		}
		set
		{
			if (CkTiNOWm0ac.Set(base.SettingsLongKey, value2, -4, 4))
			{
				OnPropertyChanged((string)Yr8KrQeDZ6Im9u818Sw6(-530053095 ^ -530019281));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStatisticData")]
	[DisplayName("Ask")]
	[DataMember(Name = "ShowAsk")]
	public bool ShowAsk
	{
		get
		{
			return JdWiN7oiuTq;
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
					if (flag != JdWiN7oiuTq)
					{
						JdWiN7oiuTq = flag;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-176525661 ^ -176489815));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName("Bid")]
	[DataMember(Name = "ShowBid")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStatisticData")]
	public bool ShowBid
	{
		get
		{
			return HHKiN8RCtTQ;
		}
		set
		{
			if (flag != HHKiN8RCtTQ)
			{
				HHKiN8RCtTQ = flag;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1A5F1B9E ^ 0x1A5F8F82));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStatisticData")]
	[DisplayName("Delta")]
	[DataMember(Name = "ShowDelta")]
	public bool ShowDelta
	{
		get
		{
			return jMliNAoQ7m4;
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
				case 1:
					if (flag == jMliNAoQ7m4)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c != 0)
						{
							num2 = 0;
						}
						break;
					}
					jMliNAoQ7m4 = flag;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1009517961 ^ -1009553831));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DisplayName("Volume")]
	[DataMember(Name = "ShowVolume")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStatisticData")]
	public bool ShowVolume
	{
		get
		{
			return jGciNPoGhMy;
		}
		set
		{
			if (flag != jGciNPoGhMy)
			{
				jGciNPoGhMy = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-842040449 ^ -842010821));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStatisticData")]
	[DataMember(Name = "ShowTrades")]
	[DisplayName("Trades")]
	public bool ShowTrades
	{
		get
		{
			return LdBiNJ3bs6q;
		}
		set
		{
			if (flag != LdBiNJ3bs6q)
			{
				LdBiNJ3bs6q = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1841489831 ^ -1841460219));
			}
		}
	}

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override bool ShowIndicatorLabels => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	public mcatgqiNcHjrN2MTjvoo()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		ShowIndicatorTitle = false;
		Period = ClusterStatisticPeriodType.Day;
		int num = 3;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				ShowTrades = true;
				return;
			case 3:
				MinimizeValues = false;
				ShowAsk = true;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 != 0)
				{
					num = 0;
				}
				break;
			default:
				ShowBid = true;
				ShowDelta = true;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d != 0)
				{
					num = 1;
				}
				break;
			case 1:
				ShowVolume = true;
				num = 2;
				break;
			}
		}
	}

	protected override void Execute()
	{
	}

	public override void Render(DxVisualQueue P_0)
	{
		List<string> list = new List<string>();
		if (ShowVolume)
		{
			list.Add((string)Yr8KrQeDZ6Im9u818Sw6(-617064403 ^ -617032035));
		}
		if (ShowTrades)
		{
			list.Add(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x385FFAB ^ 0x385710B));
		}
		int num;
		if (ShowDelta)
		{
			num = 56;
			goto IL_0009;
		}
		goto IL_036b;
		IL_0009:
		string text2 = default(string);
		int num23 = default(int);
		int num20 = default(int);
		ClusterStatisticPeriodType clusterStatisticPeriodType = default(ClusterStatisticPeriodType);
		bool flag = default(bool);
		int num22 = default(int);
		int round = default(int);
		XBrush xBrush = default(XBrush);
		IChartCluster cluster2 = default(IChartCluster);
		decimal num4 = default(decimal);
		int num8 = default(int);
		int num11 = default(int);
		Rect rect2 = default(Rect);
		double num19 = default(double);
		Rect rect = default(Rect);
		double num2 = default(double);
		Rect rect3 = default(Rect);
		double num3 = default(double);
		decimal num6 = default(decimal);
		IChartCluster chartCluster = default(IChartCluster);
		int num7 = default(int);
		string text = default(string);
		IChartSymbol chartSymbol = default(IChartSymbol);
		double xX = default(double);
		Rect rect4 = default(Rect);
		int num16 = default(int);
		int num21 = default(int);
		int num9 = default(int);
		int count = default(int);
		IChartCluster cluster = default(IChartCluster);
		XPen xPen = default(XPen);
		XBrush xBrush2 = default(XBrush);
		long num5 = default(long);
		XBrush xBrush4 = default(XBrush);
		IChartCluster cluster3 = default(IChartCluster);
		int num10 = default(int);
		int num15 = default(int);
		double sessionOffset = default(double);
		int num17 = default(int);
		XBrush xBrush3 = default(XBrush);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		int num12 = default(int);
		int num25 = default(int);
		while (true)
		{
			switch (num)
			{
			case 10:
			case 13:
				break;
			case 17:
				if (!GnQgP8eb2EyH8NMwA14e(text2, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-377195341 ^ -377161113)))
				{
					num = 19;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 == 0)
					{
						num = 15;
					}
					continue;
				}
				goto case 5;
			case 18:
				goto IL_01a5;
			case 11:
				num23 = 1;
				num = 15;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
				{
					num = 6;
				}
				continue;
			case 37:
				num20 = 0;
				goto IL_01e0;
			case 57:
				clusterStatisticPeriodType = Period;
				if (clusterStatisticPeriodType == ClusterStatisticPeriodType.VisibleBars)
				{
					flag = false;
					num22 = 0;
					goto IL_01a5;
				}
				if (clusterStatisticPeriodType == ClusterStatisticPeriodType.AllBars)
				{
					flag = false;
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
					{
						num = 0;
					}
					continue;
				}
				goto case 12;
			case 7:
				round = RoundValues;
				num = 4;
				continue;
			case 58:
				xBrush = new XBrush(LyRD8Web0yXCk5JiveCv(jYyAOBeD8iANYT4pP6V6(base.Canvas)).ChangeOpacity(cluster2.Volume, num4));
				num = 59;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
				{
					num = 39;
				}
				continue;
			case 32:
				if (num20 == 0)
				{
					num = 49;
					continue;
				}
				goto IL_0880;
			case 14:
			{
				int num18 = num8 * num11 + 2;
				rect2 = new Rect(new Point((int)num19, rect.Bottom - (double)num18 + 1.0), new Point((int)num2, rect.Bottom - (double)(num18 - num8) + (double)((num11 == 1) ? 2 : 0)));
				rect3 = new Rect(new Point(num19 + 2.0, rect.Bottom - (double)num18), new Point(num19 + num3 - 2.0, rect.Bottom - (double)(num18 - num8)));
				num = 25;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
				{
					num = 64;
				}
				continue;
			}
			case 67:
				num6 = Math.Max(num6, Math.Abs(chartCluster.Delta));
				goto case 41;
			case 6:
				num7 = list.Count * num8 + 2;
				num = 23;
				continue;
			case 12:
				num8 = (int)NQDTAieDwLY3RVRhmmI5(LtPiOqeDhXkO3yepRyai(base.Canvas)) + 4;
				num = 6;
				continue;
			case 56:
				goto end_IL_0009;
			case 62:
				text = (string)sZlbxBeb9h4qQnOQGwEh(chartSymbol, VwVtoZebffSTQRrN6LUV(cluster2), round, MinimizeValues);
				goto case 8;
			case 5:
				text = chartSymbol.FormatSize(cluster2.Delta, round, MinimizeValues);
				goto case 8;
			case 22:
				clusterStatisticPeriodType = Period;
				num = 43;
				continue;
			case 21:
				num19 = xX - num3 * 0.5;
				num = 32;
				continue;
			case 49:
				num2 = num19 + num3;
				rect4 = new Rect(new Point(rect.Left, rect.Bottom - (double)(num8 * list.Count) - 2.0), new Point(num2, rect.Bottom));
				num = 16;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
				{
					num = 7;
				}
				continue;
			case 39:
				if (num16 <= list.Count)
				{
					goto case 9;
				}
				goto IL_0880;
			case 48:
				num21 = num23;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
				{
					num = 1;
				}
				continue;
			case 27:
				return;
			case 28:
				if (cluster2 != null)
				{
					goto IL_0264;
				}
				goto IL_094c;
			case 24:
				if (num9 < count)
				{
					cluster = base.DataProvider.GetCluster(num9);
					num = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
					{
						num = 54;
					}
					continue;
				}
				goto case 12;
			case 25:
				goto IL_060f;
			case 47:
				num21 = -1;
				num = 40;
				continue;
			case 9:
			{
				int num24 = num8 * num16 + 2;
				P_0.DrawLine(xPen, new Point(rect.Left, rect.Bottom - (double)num24), new Point(xX + num3 * 0.5, rect.Bottom - (double)num24));
				num16++;
				num = 39;
				continue;
			}
			case 59:
				xBrush2 = new XBrush(((IChartTheme)jYyAOBeD8iANYT4pP6V6(base.Canvas)).ClusterTradesColor.ChangeOpacity(e5MeKXeDpjDdgx1d4UOP(cluster2), num5));
				num = 31;
				continue;
			case 31:
				xBrush4 = new XBrush(((IChartTheme)jYyAOBeD8iANYT4pP6V6(base.Canvas)).ClusterTextColor);
				num11 = 1;
				num = 26;
				continue;
			case 2:
				num4 = default(decimal);
				num5 = 0L;
				num = 36;
				continue;
			case 20:
				text = (string)PafkKXebHywTEpLn7O6L(chartSymbol, e5MeKXeDpjDdgx1d4UOP(cluster2), round, MinimizeValues);
				goto case 8;
			case 51:
				num4 = BW2yrEeDma5dqkGEq7me(num4, cluster3.Volume);
				num = 44;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
				{
					num = 28;
				}
				continue;
			case 46:
				if (!GnQgP8eb2EyH8NMwA14e(text2, Yr8KrQeDZ6Im9u818Sw6(-1763895751 ^ -1763862375)))
				{
					num = 17;
					continue;
				}
				goto case 20;
			case 66:
				goto IL_08b3;
			case 41:
				num10--;
				num = 29;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
				{
					num = 0;
				}
				continue;
			case 1:
				goto IL_0957;
			case 19:
				if (text2 == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-671204305 ^ -671173905))
				{
					num = 62;
					continue;
				}
				if (!GnQgP8eb2EyH8NMwA14e(text2, Yr8KrQeDZ6Im9u818Sw6(-1583344314 ^ -1583309940)))
				{
					num = 8;
					continue;
				}
				text = chartSymbol.FormatSize(cluster2.Ask, round, MinimizeValues);
				goto case 8;
			case 45:
				num2 = num19;
				goto IL_094c;
			case 15:
				clusterStatisticPeriodType = Period;
				num = 66;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
				{
					num = 19;
				}
				continue;
			case 43:
				goto IL_0a66;
			case 65:
				goto IL_0a83;
			case 55:
				num15 = 2;
				num = 50;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
				{
					num = 2;
				}
				continue;
			case 44:
				num5 = Math.Max(num5, cluster3.Trades);
				num6 = BW2yrEeDma5dqkGEq7me(num6, Math.Abs(cluster3.Delta));
				num = 25;
				continue;
			case 34:
			case 42:
			case 61:
				goto IL_0b26;
			case 40:
				num4 = default(decimal);
				num = 60;
				continue;
			case 4:
				sessionOffset = TimeHelper.GetSessionOffset(base.DataProvider.Symbol.Exchange);
				num = 37;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
				{
					num = 36;
				}
				continue;
			case 36:
				num6 = default(decimal);
				num10 = num17;
				goto IL_0f87;
			case 3:
				num9++;
				num = 24;
				continue;
			case 8:
				if (!string.IsNullOrEmpty(text))
				{
					P_0.FillRectangle(GnQgP8eb2EyH8NMwA14e(text2, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D313048 ^ 0x2D31BEF8)) ? xBrush : (GnQgP8eb2EyH8NMwA14e(text2, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1763895751 ^ -1763862375)) ? xBrush2 : xBrush3), rect2);
					SelFAIebnf66cpqKmKtJ(P_0, text, LtPiOqeDhXkO3yepRyai(base.Canvas), xBrush4, rect3, XTextAlignment.Left);
				}
				num11++;
				goto case 26;
			case 38:
				cluster2 = base.DataProvider.GetCluster(num17);
				num = 28;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
				{
					num = 7;
				}
				continue;
			case 16:
				P_0.FillRectangle(XBrush.White, rect4);
				fROoiVeDA8Jm3Xp2Ltfi(P_0, ((IChartTheme)jYyAOBeD8iANYT4pP6V6(base.Canvas)).ChartBackBrush, rect4);
				num16 = 1;
				goto case 39;
			case 33:
				xX = base.Canvas.GetXX(num20);
				num = 21;
				continue;
			case 30:
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						int num14 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c != 0)
						{
							num14 = 0;
						}
						while (true)
						{
							switch (num14)
							{
							case 1:
								break;
							default:
								num15 += num8;
								num14 = 2;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa != 0)
								{
									num14 = 0;
								}
								continue;
							case 2:
								P_0.DrawLine(xPen, new Point(rect.Left, rect.Bottom - (double)num15), new Point(rect.Left + (double)num12, rect.Bottom - (double)num15));
								num14 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb != 0)
								{
									num14 = 1;
								}
								continue;
							}
							break;
						}
						P_0.DrawString(rect: new Rect(new Point(rect.Left + 2.0, rect.Bottom - (double)num15), new Point(rect.Left + (double)num12 - 2.0, rect.Bottom - (double)(num15 - num8))), text: current, font: base.Canvas.ChartFont, brush: (XBrush)g9aKWVebBUcMG3o6639o(jYyAOBeD8iANYT4pP6V6(base.Canvas)));
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			case 26:
				if (num11 <= xmZdZ2ebGf8RDGodYGo3(list))
				{
					text2 = list[num11 - 1];
					num = 14;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 != 0)
					{
						num = 13;
					}
				}
				else
				{
					num = 45;
				}
				continue;
			case 63:
				return;
			case 35:
			{
				Lp2Bagebvmp64DAaBpfx(P_0, xPen, new Point(rect.Left + (double)num12, rect.Bottom - (double)num7), new Point(rect.Left + (double)num12, rect.Bottom));
				int num13 = 55;
				num = num13;
				continue;
			}
			case 60:
				num5 = 0L;
				num6 = default(decimal);
				flag = true;
				num = 57;
				continue;
			case 52:
				num5 = Math.Max(num5, e5MeKXeDpjDdgx1d4UOP(chartCluster));
				num = 67;
				continue;
			case 29:
				goto IL_0f87;
			case 64:
				text = "";
				if (GnQgP8eb2EyH8NMwA14e(text2, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x16AD7E76 ^ 0x16ADF0C6)))
				{
					text = chartSymbol.FormatSize(KIb04feDCk8PoFMchCut(cluster2), round, MinimizeValues);
					goto case 8;
				}
				num = 46;
				continue;
			case 50:
				enumerator = list.GetEnumerator();
				num = 30;
				continue;
			default:
				count = base.DataProvider.Count;
				num9 = 0;
				goto case 24;
			case 54:
				if (cluster != null)
				{
					num4 = Math.Max(num4, KIb04feDCk8PoFMchCut(cluster));
					num5 = Math.Max(num5, cluster.Trades);
					num6 = Math.Max(num6, Math.Abs(cVvWICeDr60vxICwo4o8(cluster)));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
					{
						num = 3;
					}
					continue;
				}
				goto case 3;
			case 23:
				num2 = 0.0;
				num3 = o8Lf9PeD7QaVlIvDXFVE(base.Canvas);
				rect = base.Canvas.Rect;
				num = 7;
				continue;
			case 53:
				goto IL_1159;
				IL_01e0:
				if (num20 >= yIOCRgebYS786DvmiYjf(base.Canvas))
				{
					num12 = list.Aggregate(0, (int num26, string text3) => (int)zeZAPfebDwiM84Gfe25S(num26, vUmaQaeb4Y8OECSG6HaN(base.Canvas.ChartFont, text3))) + 5;
					fROoiVeDA8Jm3Xp2Ltfi(P_0, PMmeIOeboNbGf3d81Obp(base.Canvas.Theme), new Rect(new Point(rect.Left, rect.Bottom - (double)num7), new Point(rect.Left + (double)num12, rect.Bottom)));
					num = 35;
					continue;
				}
				goto case 33;
				IL_0880:
				P_0.DrawLine(xPen, new Point(num19 + num3, rect.Bottom - (double)num7), new Point(num19 + num3, rect.Bottom));
				num17 = KKygBYeDKA5iiCGfAcDu(base.Canvas, num20);
				num = 38;
				continue;
				IL_094c:
				num20++;
				goto IL_01e0;
			}
			goto IL_0123;
			IL_1159:
			XColor xColor = ((IChartTheme)jYyAOBeD8iANYT4pP6V6(base.Canvas)).ClusterDeltaPlusColor;
			goto IL_1169;
			IL_0f87:
			if (num10 >= 0)
			{
				chartCluster = (IChartCluster)ybl44jeDFbAKaq9a87Bh(base.DataProvider, num10);
				if (chartCluster == null)
				{
					num = 41;
					continue;
				}
				num25 = 1;
				num = 22;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
				{
					num = 10;
				}
				continue;
			}
			goto IL_107b;
			IL_0484:
			num23 = base.DataProvider.Period.GetSequence(ChartPeriodType.Day, 1, cluster2.Time, sessionOffset);
			num = 13;
			continue;
			IL_0264:
			if (flag)
			{
				num = 11;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
				{
					num = 11;
				}
				continue;
			}
			goto IL_107b;
			IL_01a5:
			if (num22 >= base.Canvas.Count)
			{
				num = 12;
				continue;
			}
			cluster3 = base.DataProvider.GetCluster(KKygBYeDKA5iiCGfAcDu(base.Canvas, num22));
			if (cluster3 != null)
			{
				num = 36;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 == 0)
				{
					num = 51;
				}
				continue;
			}
			goto IL_060f;
			IL_107b:
			if (!(cluster2.Delta > 0m))
			{
				xColor = M1s1nDeDuALSOc4PpocB(jYyAOBeD8iANYT4pP6V6(base.Canvas));
				goto IL_1169;
			}
			num = 53;
			continue;
			IL_0a66:
			switch (clusterStatisticPeriodType)
			{
			case ClusterStatisticPeriodType.Week:
				break;
			default:
				num = 61;
				continue;
			case ClusterStatisticPeriodType.Month:
				num25 = ((IChartPeriod)crFi59eD3n74KAyL2G6F(base.DataProvider)).GetSequence(ChartPeriodType.Month, 1, WK4VfjeDPeJutNDmHEAt(chartCluster), sessionOffset);
				num = 42;
				continue;
			case ClusterStatisticPeriodType.Day:
				num25 = base.DataProvider.Period.GetSequence(ChartPeriodType.Day, 1, WK4VfjeDPeJutNDmHEAt(chartCluster), sessionOffset);
				num = 34;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
				{
					num = 25;
				}
				continue;
			}
			num25 = base.DataProvider.Period.GetSequence(ChartPeriodType.Week, 1, chartCluster.Time, sessionOffset);
			goto IL_0b26;
			IL_0123:
			if (num23 != num21)
			{
				num = 48;
				continue;
			}
			goto IL_107b;
			IL_0b26:
			if (num25 == num23)
			{
				num4 = Math.Max(num4, chartCluster.Volume);
				num = 52;
				continue;
			}
			goto IL_107b;
			IL_060f:
			num22++;
			num = 18;
			continue;
			IL_08b3:
			switch (clusterStatisticPeriodType)
			{
			case ClusterStatisticPeriodType.Day:
				goto IL_0484;
			case ClusterStatisticPeriodType.Week:
				goto IL_073a;
			case ClusterStatisticPeriodType.Month:
				goto IL_0a83;
			}
			goto IL_0123;
			IL_0a83:
			num23 = base.DataProvider.Period.GetSequence(ChartPeriodType.Month, 1, cluster2.Time, sessionOffset);
			goto IL_0123;
			IL_073a:
			num23 = BMGx5xeDJlDadmLBt2IS(base.DataProvider.Period, ChartPeriodType.Week, 1, WK4VfjeDPeJutNDmHEAt(cluster2), sessionOffset);
			num = 10;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
			{
				num = 4;
			}
			continue;
			IL_1169:
			XColor xColor2 = xColor;
			xBrush3 = new XBrush(xColor2.ChangeOpacity(gSdfP1eDzYS9ZVN1tqDS(cluster2.Delta), num6));
			num = 58;
			continue;
			end_IL_0009:
			break;
		}
		list.Add((string)Yr8KrQeDZ6Im9u818Sw6(-490987856 ^ -490958748));
		goto IL_036b;
		IL_1123:
		if (list.Count != 0)
		{
			chartSymbol = (IChartSymbol)PL8aQqeDVXXMtb34wZuo(base.DataProvider);
			xPen = new XPen(new XBrush(base.Canvas.Theme.ChartAxisColor), 1);
			num = 32;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 != 0)
			{
				num = 47;
			}
		}
		else
		{
			num = 24;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
			{
				num = 27;
			}
		}
		goto IL_0009;
		IL_036b:
		if (ShowBid)
		{
			list.Add(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1461292091 ^ -1461256955));
		}
		if (ShowAsk)
		{
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_1123;
		IL_0957:
		list.Add(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4662F6AF ^ 0x46627865));
		goto IL_1123;
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 1;
		mcatgqiNcHjrN2MTjvoo mcatgqiNcHjrN2MTjvoo2 = default(mcatgqiNcHjrN2MTjvoo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					ShowDelta = mcatgqiNcHjrN2MTjvoo2.ShowDelta;
					ShowVolume = mcatgqiNcHjrN2MTjvoo2.ShowVolume;
					ShowTrades = jtib0heblaWkHhyy6ldd(mcatgqiNcHjrN2MTjvoo2);
					base.CopyTemplate(P_0, P_1);
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					mcatgqiNcHjrN2MTjvoo2 = (mcatgqiNcHjrN2MTjvoo)P_0;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					Period = mcatgqiNcHjrN2MTjvoo2.Period;
					MinimizeValues = mcatgqiNcHjrN2MTjvoo2.MinimizeValues;
					CkTiNOWm0ac.Copy((IndicatorParam<int>)hcwC7debarmK6jGWeU0h(mcatgqiNcHjrN2MTjvoo2));
					ShowAsk = mcatgqiNcHjrN2MTjvoo2.ShowAsk;
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					break;
				case 3:
					return;
				}
				break;
			}
			ShowBid = hrH3UOebig1cWamxfPLV(mcatgqiNcHjrN2MTjvoo2);
			num = 4;
		}
	}

	[CompilerGenerated]
	private int KxXiNEGO6MM(int P_0, string P_1)
	{
		return (int)zeZAPfebDwiM84Gfe25S(P_0, vUmaQaeb4Y8OECSG6HaN(base.Canvas.ChartFont, P_1));
	}

	static mcatgqiNcHjrN2MTjvoo()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool FtpKh9eDTFRpXX9bi2Ux()
	{
		return Kn7IrneDU15UN5F5PUmZ == null;
	}

	internal static mcatgqiNcHjrN2MTjvoo wxIPlyeDyVhPkdyZONiT()
	{
		return Kn7IrneDU15UN5F5PUmZ;
	}

	internal static object Yr8KrQeDZ6Im9u818Sw6(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object PL8aQqeDVXXMtb34wZuo(object P_0)
	{
		return ((IChartDataProvider)P_0).Symbol;
	}

	internal static decimal KIb04feDCk8PoFMchCut(object P_0)
	{
		return ((IChartCluster)P_0).Volume;
	}

	internal static decimal cVvWICeDr60vxICwo4o8(object P_0)
	{
		return ((IChartCluster)P_0).Delta;
	}

	internal static int KKygBYeDKA5iiCGfAcDu(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetIndex(i);
	}

	internal static decimal BW2yrEeDma5dqkGEq7me(decimal P_0, decimal P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object LtPiOqeDhXkO3yepRyai(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static double NQDTAieDwLY3RVRhmmI5(object P_0)
	{
		return ((XFont)P_0).GetHeight();
	}

	internal static double o8Lf9PeD7QaVlIvDXFVE(object P_0)
	{
		return ((IChartCanvas)P_0).ColumnWidth;
	}

	internal static object jYyAOBeD8iANYT4pP6V6(object P_0)
	{
		return ((IChartCanvas)P_0).Theme;
	}

	internal static void fROoiVeDA8Jm3Xp2Ltfi(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static DateTime WK4VfjeDPeJutNDmHEAt(object P_0)
	{
		return ((IChartCluster)P_0).Time;
	}

	internal static int BMGx5xeDJlDadmLBt2IS(object P_0, ChartPeriodType type, int interval, DateTime dateTime, double timeOffset)
	{
		return ((IChartPeriod)P_0).GetSequence(type, interval, dateTime, timeOffset);
	}

	internal static object ybl44jeDFbAKaq9a87Bh(object P_0, int i)
	{
		return ((IChartDataProvider)P_0).GetCluster(i);
	}

	internal static object crFi59eD3n74KAyL2G6F(object P_0)
	{
		return ((IChartDataProvider)P_0).Period;
	}

	internal static int e5MeKXeDpjDdgx1d4UOP(object P_0)
	{
		return ((IChartCluster)P_0).Trades;
	}

	internal static XColor M1s1nDeDuALSOc4PpocB(object P_0)
	{
		return ((IChartTheme)P_0).ClusterDeltaMinusColor;
	}

	internal static decimal gSdfP1eDzYS9ZVN1tqDS(decimal P_0)
	{
		return Math.Abs(P_0);
	}

	internal static XColor LyRD8Web0yXCk5JiveCv(object P_0)
	{
		return ((IChartTheme)P_0).ClusterVolumeColor;
	}

	internal static bool GnQgP8eb2EyH8NMwA14e(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object PafkKXebHywTEpLn7O6L(object P_0, long trades, int round, bool minimize)
	{
		return ((IChartSymbol)P_0).FormatTrades(trades, round, minimize);
	}

	internal static decimal VwVtoZebffSTQRrN6LUV(object P_0)
	{
		return ((IChartCluster)P_0).Bid;
	}

	internal static object sZlbxBeb9h4qQnOQGwEh(object P_0, decimal size, int round, bool minimize)
	{
		return ((IChartSymbol)P_0).FormatSize(size, round, minimize);
	}

	internal static void SelFAIebnf66cpqKmKtJ(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static int xmZdZ2ebGf8RDGodYGo3(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static int yIOCRgebYS786DvmiYjf(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static object PMmeIOeboNbGf3d81Obp(object P_0)
	{
		return ((IChartTheme)P_0).ChartBackBrush;
	}

	internal static void Lp2Bagebvmp64DAaBpfx(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static object g9aKWVebBUcMG3o6639o(object P_0)
	{
		return ((IChartTheme)P_0).ChartFontBrush;
	}

	internal static object hcwC7debarmK6jGWeU0h(object P_0)
	{
		return ((mcatgqiNcHjrN2MTjvoo)P_0).CkTiNOWm0ac;
	}

	internal static bool hrH3UOebig1cWamxfPLV(object P_0)
	{
		return ((mcatgqiNcHjrN2MTjvoo)P_0).ShowBid;
	}

	internal static bool jtib0heblaWkHhyy6ldd(object P_0)
	{
		return ((mcatgqiNcHjrN2MTjvoo)P_0).ShowTrades;
	}

	internal static double vUmaQaeb4Y8OECSG6HaN(object P_0, object P_1)
	{
		return ((XFont)P_0).GetWidth((string)P_1);
	}

	internal static double zeZAPfebDwiM84Gfe25S(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}
}
