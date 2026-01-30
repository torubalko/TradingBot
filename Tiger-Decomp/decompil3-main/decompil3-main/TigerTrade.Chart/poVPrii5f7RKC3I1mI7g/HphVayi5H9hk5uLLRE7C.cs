using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace poVPrii5f7RKC3I1mI7g;

[DataContract(Name = "DepthOfMarketIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("DepthOfMarket", "DepthOfMarket", true, Type = typeof(HphVayi5H9hk5uLLRE7C))]
internal sealed class HphVayi5H9hk5uLLRE7C : IndicatorBase
{
	private int FtYi5TXZAqP;

	private IndicatorNullIntParam wPvi5yueKG9;

	private DepthOfMarketScaleAlignment JTMi5ZuxjSq;

	private bool eOWi5VtmvN0;

	private bool zSyi5CCipDi;

	private bool W5xi5rG94Yj;

	private IndicatorIntParam Qx8i5KqytxX;

	private XBrush b4Ti5mOZZRo;

	private XColor LNmi5hXGEMi;

	private XBrush yNHi5wB5ev7;

	private XColor n82i57Puwg8;

	private XBrush pqZi58ugw57;

	private XColor PTBi5ALAE4i;

	private XBrush NvJi5PqOQDY;

	private XColor fovi5JftFsK;

	private XBrush eJKi5FODt3E;

	private XColor JWji53mIiu0;

	private XBrush FBgi5pdi4ah;

	private XPen KGui5uToOmn;

	private XColor Lssi5zmHkD4;

	private XBrush bpFiS0VkONR;

	private XPen etiiS2N9pqk;

	private XColor DYYiSHNCpC1;

	private XBrush T3AiSf9lGxm;

	private XColor l28iS90Ubac;

	private XBrush p5iiSnTVK3X;

	private XColor wGAiSGRZNKW;

	internal static HphVayi5H9hk5uLLRE7C ADcaOJeNQLK67s0GKjUQ;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsScaleWidth")]
	[DataMember(Name = "ScaleWidth")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int ScaleWidth
	{
		get
		{
			return FtYi5TXZAqP;
		}
		set
		{
			num = Math.Max(0, num);
			if (num != FtYi5TXZAqP)
			{
				FtYi5TXZAqP = num;
				OnPropertyChanged((string)QX9LTYeNRHbS1ylNBhfj(-1736566656 ^ -1736536482));
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

	[DataMember(Name = "ScaleVolumeParam")]
	public IndicatorNullIntParam vUPi5o0eM99
	{
		get
		{
			return wPvi5yueKG9 ?? (wPvi5yueKG9 = new IndicatorNullIntParam(null));
		}
		set
		{
			wPvi5yueKG9 = indicatorNullIntParam;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsScaleVolume")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DefaultValue(null)]
	public int? ScaleVolume
	{
		get
		{
			return vUPi5o0eM99.Get(base.SettingsShortKey);
		}
		set
		{
			if (vUPi5o0eM99.Set(base.SettingsShortKey, value2, 1))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-690510723 ^ -690539893));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsScaleAlignment")]
	[DataMember(Name = "DepthOfMarketScaleAlignment")]
	public DepthOfMarketScaleAlignment ScaleAlignment
	{
		get
		{
			return JTMi5ZuxjSq;
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
					if (depthOfMarketScaleAlignment == JTMi5ZuxjSq)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
						{
							num2 = 0;
						}
						break;
					}
					JTMi5ZuxjSq = depthOfMarketScaleAlignment;
					OnPropertyChanged((string)QX9LTYeNRHbS1ylNBhfj(0x315AB1E3 ^ 0x315A26F3));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "AddMargins")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAddMargins")]
	public bool AddMargins
	{
		get
		{
			return eOWi5VtmvN0;
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
					if (flag != eOWi5VtmvN0)
					{
						eOWi5VtmvN0 = flag;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4220DA8 ^ 0x4229A98));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "ShowValues")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShowValues")]
	public bool ShowValues
	{
		get
		{
			return zSyi5CCipDi;
		}
		set
		{
			if (flag != zSyi5CCipDi)
			{
				zSyi5CCipDi = flag;
				OnPropertyChanged((string)QX9LTYeNRHbS1ylNBhfj(0x4220DA8 ^ 0x4228E56));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimizeValues")]
	[DataMember(Name = "MinimizeValues")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public bool MinimizeValues
	{
		get
		{
			return W5xi5rG94Yj;
		}
		set
		{
			if (flag != W5xi5rG94Yj)
			{
				W5xi5rG94Yj = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x22BF43FC ^ 0x22BFC7EA));
			}
		}
	}

	[DataMember(Name = "RoundValueParam")]
	public IndicatorIntParam Eani5SdmQQQ
	{
		get
		{
			return Qx8i5KqytxX ?? (Qx8i5KqytxX = new IndicatorIntParam(0));
		}
		set
		{
			Qx8i5KqytxX = qx8i5KqytxX;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsRoundValues")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DefaultValue(0)]
	public int RoundValues
	{
		get
		{
			return Eani5SdmQQQ.Get(base.SettingsLongKey);
		}
		set
		{
			if (Eani5SdmQQQ.Set(base.SettingsLongKey, value2, -4, 4))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2108526692 ^ -2108494934));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBidQuoteColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "BidQuoteColor")]
	public XColor BidQuoteColor
	{
		get
		{
			return LNmi5hXGEMi;
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
					if (!QnvKsKeN6vRIxO348ojT(LNmi5hXGEMi, xColor))
					{
						LNmi5hXGEMi = xColor;
						b4Ti5mOZZRo = new XBrush(xColor);
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x769C7931 ^ 0x769CEE79));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "BestBidQuoteColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBestBidQuoteColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor BestBidQuoteColor
	{
		get
		{
			return n82i57Puwg8;
		}
		set
		{
			if (!QnvKsKeN6vRIxO348ojT(n82i57Puwg8, xColor))
			{
				n82i57Puwg8 = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				yNHi5wB5ev7 = new XBrush(xColor);
				OnPropertyChanged((string)QX9LTYeNRHbS1ylNBhfj(-57768881 ^ -57797847));
			}
		}
	}

	[DataMember(Name = "AskQuoteColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAskQuoteColor")]
	public XColor AskQuoteColor
	{
		get
		{
			return PTBi5ALAE4i;
		}
		set
		{
			if (QnvKsKeN6vRIxO348ojT(PTBi5ALAE4i, xColor))
			{
				return;
			}
			PTBi5ALAE4i = xColor;
			pqZi58ugw57 = new XBrush(xColor);
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-338769610 ^ -338796870));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBestAskQuoteColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "BestAskQuoteColor")]
	public XColor BestAskQuoteColor
	{
		get
		{
			return fovi5JftFsK;
		}
		set
		{
			if (!(fovi5JftFsK == xColor))
			{
				fovi5JftFsK = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				NvJi5PqOQDY = new XBrush(xColor);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1325234765 ^ -1325264359));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "EmptyQuoteColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsEmptyQuoteColor")]
	[Browsable(false)]
	public XColor EmptyQuoteColor
	{
		get
		{
			return JWji53mIiu0;
		}
		set
		{
			if (!QnvKsKeN6vRIxO348ojT(JWji53mIiu0, xColor))
			{
				JWji53mIiu0 = xColor;
				eJKi5FODt3E = new XBrush(xColor);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--871424829 ^ 0x33F074ED));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBidVolumeColor")]
	[DataMember(Name = "BidVolumeColor")]
	public XColor BidVolumeColor
	{
		get
		{
			return Lssi5zmHkD4;
		}
		set
		{
			if (Lssi5zmHkD4 == xColor)
			{
				return;
			}
			Lssi5zmHkD4 = xColor;
			FBgi5pdi4ah = new XBrush(xColor);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 != 0)
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
				KGui5uToOmn = new XPen(FBgi5pdi4ah, 1);
				OnPropertyChanged((string)QX9LTYeNRHbS1ylNBhfj(-1416986301 ^ -1417013583));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
				{
					num = 0;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAskVolumeColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "AskVolumeColor")]
	public XColor AskVolumeColor
	{
		get
		{
			return DYYiSHNCpC1;
		}
		set
		{
			if (DYYiSHNCpC1 == xColor)
			{
				return;
			}
			DYYiSHNCpC1 = xColor;
			bpFiS0VkONR = new XBrush(xColor);
			etiiS2N9pqk = new XPen(bpFiS0VkONR, 1);
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					OnPropertyChanged((string)QX9LTYeNRHbS1ylNBhfj(0x28B345BB ^ 0x28B3DDA9));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsTextColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "TextColor")]
	public XColor TextColor
	{
		get
		{
			return l28iS90Ubac;
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
					if (l28iS90Ubac == xColor)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
						{
							num2 = 0;
						}
						break;
					}
					l28iS90Ubac = xColor;
					T3AiSf9lGxm = new XBrush(xColor);
					OnPropertyChanged((string)QX9LTYeNRHbS1ylNBhfj(-45476899 ^ -45454205));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBackColor")]
	[DataMember(Name = "BackColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor BackColor
	{
		get
		{
			return wGAiSGRZNKW;
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
					if (wGAiSGRZNKW == xColor)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 != 0)
						{
							num2 = 0;
						}
						break;
					}
					wGAiSGRZNKW = xColor;
					p5iiSnTVK3X = new XBrush(xColor);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1087080834 ^ -1087049394));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override bool ShowIndicatorLabels => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	public HphVayi5H9hk5uLLRE7C()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		ShowIndicatorTitle = false;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
			{
				AskQuoteColor = Colors.Transparent;
				BestAskQuoteColor = Colors.Transparent;
				EmptyQuoteColor = Colors.Transparent;
				int num2 = 4;
				num = num2;
				break;
			}
			case 2:
				BestBidQuoteColor = Colors.Transparent;
				num = 3;
				break;
			case 4:
				BidVolumeColor = uxyFjNeNMft4yrMEaM4s(Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue));
				AskVolumeColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
				num = 5;
				break;
			case 1:
				ScaleWidth = 0;
				ScaleAlignment = DepthOfMarketScaleAlignment.Right;
				AddMargins = false;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
				{
					num = 0;
				}
				break;
			case 6:
				BackColor = uxyFjNeNMft4yrMEaM4s(Colors.Transparent);
				return;
			case 5:
				TextColor = dLtZj7eNO6MKOYnVFeOh();
				num = 6;
				break;
			default:
				ShowValues = true;
				MinimizeValues = false;
				BidQuoteColor = Colors.Transparent;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
	}

	public override void Render(DxVisualQueue P_0)
	{
		IChartDataProvider dataProvider = base.DataProvider;
		IRawMarketDepth rawMarketDepth = dataProvider.GetRawMarketDepth();
		double num = edkfZ0eNqDa4B5TBqeDL(dataProvider);
		IChartSymbol chartSymbol = (IChartSymbol)aCWbNOeNI5KRxKAw1Lde(dataProvider);
		Rect rect = base.Canvas.Rect;
		double num2 = ((ScaleWidth > 0) ? ((double)ScaleWidth) : (rect.Width * 0.1));
		int num3 = 36;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
		{
			num3 = 7;
		}
		int num12 = default(int);
		int num24 = default(int);
		int num8 = default(int);
		int num11 = default(int);
		string text = default(string);
		long item2 = default(long);
		int round = default(int);
		long num18 = default(long);
		(long, long) value2 = default((long, long));
		double num16 = default(double);
		long num22 = default(long);
		long num5 = default(long);
		int? num30 = default(int?);
		int num31 = default(int);
		double width2 = default(double);
		XFont xFont = default(XFont);
		int num10 = default(int);
		long num15 = default(long);
		double num23 = default(double);
		int num19 = default(int);
		string text2 = default(string);
		Rect rect5 = default(Rect);
		int num25 = default(int);
		int num36 = default(int);
		int num37 = default(int);
		int num13 = default(int);
		IEnumerator<KeyValuePair<long, (long, long)>> enumerator = default(IEnumerator<KeyValuePair<long, (long, long)>>);
		int num34 = default(int);
		int num35 = default(int);
		KeyValuePair<long, (long, long)> current = default(KeyValuePair<long, (long, long)>);
		long key = default(long);
		Point p = default(Point);
		Point p2 = default(Point);
		int num27 = default(int);
		long num4 = default(long);
		(long, long) value = default((long, long));
		int num9 = default(int);
		Rect rect6 = default(Rect);
		int num7 = default(int);
		long item = default(long);
		int num14 = default(int);
		Rect rect2 = default(Rect);
		while (true)
		{
			long num20;
			int num21;
			int num17;
			Rect rect3;
			Rect rect4;
			switch (num3)
			{
			case 6:
				num20 = rawMarketDepth.MaxSize;
				goto IL_0e76;
			case 24:
				num12 = Math.Max(num24 - num8, 1);
				num11 = num8;
				num3 = 25;
				break;
			case 5:
				return;
			case 4:
				text = chartSymbol.FormatRawSize(item2, round, MinimizeValues);
				num3 = 23;
				break;
			case 25:
				num8 = num24;
				if (rawMarketDepth.AskQuotes.TryGetValue(num18, out value2))
				{
					if (!((double)num24 < rect.Top))
					{
						num3 = 3;
						break;
					}
					goto case 22;
				}
				num3 = 22;
				break;
			case 16:
				if (num16 <= 1.0)
				{
					num3 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
					{
						num3 = 2;
					}
					break;
				}
				num8 = (int)GetY((double)s1EmeleNVZ61MYb3vn3O(rawMarketDepth) * num + num / 2.0);
				num22 = Math.Min((long)Math.Round(bIgEb5eNCYkMf0hha4ko(base.Canvas, rect.Top) / num), s1EmeleNVZ61MYb3vn3O(rawMarketDepth));
				num5 = SIdx4AeNmQik8cOQc9fo((long)SABPW0eNrKDwDlJkAplE(bIgEb5eNCYkMf0hha4ko(base.Canvas, rect.Bottom) / num), CK9RGKeNKVi8VXwFAP89(rawMarketDepth));
				if (num22 - num5 > 5000)
				{
					return;
				}
				round = RoundValues;
				num18 = num22;
				num3 = 27;
				break;
			case 13:
				if (!(num30 > num31))
				{
					num3 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 == 0)
					{
						num3 = 5;
					}
					break;
				}
				num30 = ScaleVolume;
				num20 = chartSymbol.CorrectSizeFilter(num30.Value);
				goto IL_0e76;
			case 3:
				if (num18 == rawMarketDepth.MinAskPrice)
				{
					P_0.FillRectangle(rect: new Rect(new Point(rect.Right - num2, num11), new Point(rect.Right, num11 + num12)), brush: NvJi5PqOQDY);
				}
				item2 = value2.Item1;
				num3 = 4;
				break;
			case 31:
				num21 = 0;
				goto IL_0e7e;
			case 23:
				width2 = xFont.GetWidth(text);
				num10 = (int)Math.Min((double)item2 * num2 / (double)num15, num2);
				if (!ShowValues)
				{
					num3 = 33;
					break;
				}
				goto case 28;
			case 10:
				xFont = new XFont(base.Canvas.ChartFont.Name, num23);
				num3 = 29;
				break;
			case 11:
				if (num15 < 1)
				{
					num17 = 35;
					goto IL_0005;
				}
				if (!AddMargins)
				{
					num3 = 31;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
					{
						num3 = 23;
					}
					break;
				}
				num21 = -1;
				goto IL_0e7e;
			case 19:
				num19 = (int)GetY((double)rawMarketDepth.MinAskPrice * num + num / 2.0);
				num3 = 15;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
				{
					num3 = 21;
				}
				break;
			case 22:
				num18--;
				goto case 27;
			case 8:
				if (ShowValues && num16 > 8.0)
				{
					P_0.DrawString(text2, xFont, T3AiSf9lGxm, rect5, (ScaleAlignment == DepthOfMarketScaleAlignment.Right) ? XTextAlignment.Right : XTextAlignment.Left);
					num3 = 17;
					break;
				}
				goto case 17;
			case 12:
				return;
			case 21:
				UKfESeeNUaQHMG8LwsAw(P_0, pqZi58ugw57, new Rect(new Point(rect.Right - num2, num25), new Point(rect.Right, num19)));
				num36 = (int)GetY((double)rawMarketDepth.MaxBidPrice * num - num / 2.0);
				num37 = (int)GetY((double)rawMarketDepth.MinBidPrice * num - num / 2.0);
				num3 = 40;
				break;
			case 40:
				P_0.FillRectangle(b4Ti5mOZZRo, new Rect(new Point(rect.Right - num2, num36), new Point(rect.Right, num37)));
				num3 = 16;
				break;
			case 14:
				rect3 = new Rect(new Point(rect.Right - num2, num11), new Point(rect.Right - (num2 - (double)num10), num11 + WtYBXEeNhCda8lg0q6MJ(num12 + num13, 1)));
				goto IL_0eb8;
			case 18:
				num23 = nVwKNYeNtJxaF35jsMxn(num23, Jd922LeNWmBIsTBRY40R(base.Canvas.ChartFont));
				num3 = 10;
				break;
			case 2:
				enumerator = rawMarketDepth.AskQuotes.GetEnumerator();
				num3 = 15;
				break;
			case 15:
				try
				{
					while (enumerator.MoveNext())
					{
						while (true)
						{
							KeyValuePair<long, (long, long)> current2 = enumerator.Current;
							long key2 = current2.Key;
							int num32 = 3;
							int num33 = num32;
							while (true)
							{
								switch (num33)
								{
								case 1:
									num34 = (int)nVwKNYeNtJxaF35jsMxn((double)current2.Value.Item1 * num2 / (double)num15, num2);
									num33 = 0;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c != 0)
									{
										num33 = 0;
									}
									continue;
								case 3:
									goto IL_069a;
								case 4:
									goto end_IL_0613;
								case 2:
									goto IL_0739;
								case 5:
									goto IL_0762;
								}
								if (ScaleAlignment != DepthOfMarketScaleAlignment.Right)
								{
									num33 = 5;
									continue;
								}
								Point point = new Point(rect.Right - (double)num34, num35);
								goto IL_0791;
								IL_0762:
								point = new Point(rect.Right - num2, num35);
								goto IL_0791;
								IL_0739:
								if ((double)num35 > rect.Bottom)
								{
									goto end_IL_06bb;
								}
								num33 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
								{
									num33 = 1;
								}
								continue;
								IL_069a:
								num35 = (int)GetY((double)key2 * num - num / 2.0);
								if ((double)num35 < rect.Top)
								{
									goto end_IL_06bb;
								}
								num33 = 2;
								continue;
								IL_0791:
								Point point2 = point;
								Point point3 = ((ScaleAlignment == DepthOfMarketScaleAlignment.Right) ? new Point(rect.Right, num35) : new Point(rect.Right - (num2 - (double)num34), num35));
								JIRUieeNTd80F1Mdyi98(P_0, etiiS2N9pqk, point2, point3);
								goto end_IL_06bb;
								continue;
								end_IL_0613:
								break;
							}
							continue;
							end_IL_06bb:
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						W924IIeNyfNJaYt0ieVh(enumerator);
					}
				}
				enumerator = rawMarketDepth.BidQuotes.GetEnumerator();
				num3 = 20;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
				{
					num3 = 2;
				}
				break;
			case 36:
				num30 = ScaleVolume;
				num31 = 0;
				num3 = 13;
				break;
			case 35:
				return;
			case 27:
				if (num18 < num5)
				{
					num8 = (int)GetY((double)lbbP5UeNwuvRxVR0a4S5(rawMarketDepth) * num + num / 2.0);
					num22 = Math.Min((long)Math.Round(base.Canvas.GetValue(rect.Top) / num), rawMarketDepth.MaxBidPrice);
					num3 = 9;
					break;
				}
				num24 = (int)GetY((double)num18 * num - num / 2.0);
				num3 = 24;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
				{
					num3 = 18;
				}
				break;
			case 20:
				try
				{
					while (true)
					{
						int num26;
						if (!ywIvZNeNZ3k2wVkyjsfl(enumerator))
						{
							num26 = 5;
						}
						else
						{
							current = enumerator.Current;
							num26 = 1;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
							{
								num26 = 1;
							}
						}
						while (true)
						{
							switch (num26)
							{
							case 1:
								key = current.Key;
								num26 = 4;
								continue;
							case 3:
								P_0.DrawLine(KGui5uToOmn, p, p2);
								num26 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
								{
									num26 = 0;
								}
								continue;
							case 4:
								num27 = (int)GetY((double)key * num - num / 2.0);
								num26 = 2;
								continue;
							case 2:
								if (!((double)num27 < rect.Top) && !((double)num27 > rect.Bottom))
								{
									int num28 = (int)Math.Min((double)current.Value.Item1 * num2 / (double)num15, num2);
									p = ((ScaleAlignment == DepthOfMarketScaleAlignment.Right) ? new Point(rect.Right - (double)num28, num27) : new Point(rect.Right - num2, num27));
									p2 = ((ScaleAlignment == DepthOfMarketScaleAlignment.Right) ? new Point(rect.Right, num27) : new Point(rect.Right - (num2 - (double)num28), num27));
									int num29 = 3;
									num26 = num29;
									continue;
								}
								break;
							case 5:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
			case 38:
				UKfESeeNUaQHMG8LwsAw(P_0, FBgi5pdi4ah, rect5);
				num3 = 8;
				break;
			case 29:
				P_0.FillRectangle(p5iiSnTVK3X, new Rect(rect.Right - num2, rect.Y, num2, rect.Height));
				num25 = (int)GetY((double)rawMarketDepth.MaxAskPrice * num + num / 2.0);
				num3 = 19;
				break;
			case 28:
				if (num16 > 8.0)
				{
					num10 = (int)nVwKNYeNtJxaF35jsMxn(Math.Max(num10, width2), num2);
					num3 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
					{
						num3 = 1;
					}
					break;
				}
				goto case 1;
			case 32:
				if (!rawMarketDepth.BidQuotes.TryGetValue(num4, out value) || (double)num9 > rect.Bottom)
				{
					goto case 17;
				}
				if (num4 == rawMarketDepth.MaxBidPrice)
				{
					num3 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 != 0)
					{
						num3 = 0;
					}
					break;
				}
				goto case 30;
			default:
				rect6 = new Rect(new Point(rect.Right - num2, num9), new Point(rect.Right, num9 + num7));
				num3 = 39;
				break;
			case 9:
				num5 = Math.Max((long)SABPW0eNrKDwDlJkAplE(bIgEb5eNCYkMf0hha4ko(base.Canvas, rect.Bottom) / num), rawMarketDepth.MinBidPrice);
				if (num22 - num5 > 5000)
				{
					num3 = 12;
					break;
				}
				num4 = num22;
				goto IL_0a17;
			case 34:
				text2 = (string)y8gHNReN7aIZP4fC1Tm0(chartSymbol, item, round, MinimizeValues);
				num17 = 7;
				goto IL_0005;
			case 17:
				num4--;
				goto IL_0a17;
			case 39:
				P_0.FillRectangle(yNHi5wB5ev7, rect6);
				num3 = 30;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
				{
					num3 = 28;
				}
				break;
			case 1:
			case 33:
				if (ScaleAlignment != DepthOfMarketScaleAlignment.Right)
				{
					num3 = 12;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd == 0)
					{
						num3 = 14;
					}
					break;
				}
				rect3 = new Rect(new Point(rect.Right - (double)num10, num11), new Point(rect.Right, num11 + Math.Max(num12 + num13, 1)));
				goto IL_0eb8;
			case 30:
				item = value.Item1;
				num3 = 34;
				break;
			case 7:
			{
				double width = xFont.GetWidth(text2);
				num14 = (int)Math.Min((double)item * num2 / (double)num15, num2);
				if (ShowValues && num16 > 8.0)
				{
					num14 = (int)Math.Min(Math.Max(num14, width), num2);
				}
				if (ScaleAlignment != DepthOfMarketScaleAlignment.Right)
				{
					num17 = 26;
					goto IL_0005;
				}
				rect4 = new Rect(new Point(rect.Right - (double)num14, num9), new Point(rect.Right, num9 + Math.Max(num7 + num13, 1)));
				goto IL_0f1c;
			}
			case 26:
				rect4 = new Rect(new Point(rect.Right - num2, num9), new Point(rect.Right - (num2 - (double)num14), num9 + Math.Max(num7 + num13, 1)));
				goto IL_0f1c;
			case 37:
				{
					P_0.DrawString(text, xFont, T3AiSf9lGxm, rect2, (ScaleAlignment == DepthOfMarketScaleAlignment.Right) ? XTextAlignment.Right : XTextAlignment.Left);
					goto case 22;
				}
				IL_0a17:
				if (num4 >= num5)
				{
					int num6 = (int)GetY((double)num4 * num - num / 2.0);
					num7 = Math.Max(num6 - num8, 1);
					num9 = num8;
					num8 = num6;
					num3 = 32;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
					{
						num3 = 0;
					}
				}
				else
				{
					num3 = 5;
				}
				break;
				IL_0eb8:
				rect2 = rect3;
				P_0.FillRectangle(bpFiS0VkONR, rect2);
				if (ShowValues && num16 > 8.0)
				{
					num3 = 37;
					break;
				}
				goto case 22;
				IL_0f1c:
				rect5 = rect4;
				num3 = 38;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
				{
					num3 = 0;
				}
				break;
				IL_0e7e:
				num13 = num21;
				num16 = Math.Max(GetY(0.0) - GetY(num), 1.0);
				num23 = Math.Min(num16 + (double)num13 - 2.0, 18.0) * 96.0 / 72.0;
				num3 = 18;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
				{
					num3 = 8;
				}
				break;
				IL_0e76:
				num15 = num20;
				if (!(num2 < 5.0))
				{
					num17 = 11;
					goto IL_0005;
				}
				return;
				IL_0005:
				num3 = num17;
				break;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		BidVolumeColor = P_0.PaletteColor6;
		AskVolumeColor = CH1vJVeN8OSZKXT9uG9Y(P_0);
		TextColor = P_0.ChartFontColor;
		base.ApplyColors(P_0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		HphVayi5H9hk5uLLRE7C hphVayi5H9hk5uLLRE7C = (HphVayi5H9hk5uLLRE7C)P_0;
		ScaleWidth = hphVayi5H9hk5uLLRE7C.ScaleWidth;
		int num = 3;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				vUPi5o0eM99.Copy((IndicatorParam<int?>)QPgQakeNPETWLtjZnm12(hphVayi5H9hk5uLLRE7C));
				Eani5SdmQQQ.Copy(hphVayi5H9hk5uLLRE7C.Eani5SdmQQQ);
				num = 7;
				break;
			case 4:
				OnPropertyChanged((string)QX9LTYeNRHbS1ylNBhfj(-710503328 ^ -710540650));
				base.CopyTemplate(P_0, P_1);
				return;
			case 3:
				ScaleAlignment = hphVayi5H9hk5uLLRE7C.ScaleAlignment;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd != 0)
				{
					num = 0;
				}
				break;
			case 7:
				BidQuoteColor = hphVayi5H9hk5uLLRE7C.BidQuoteColor;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
				{
					num = 0;
				}
				break;
			default:
				BestBidQuoteColor = HEfgTweNJrsOjjeeM7wy(hphVayi5H9hk5uLLRE7C);
				AskQuoteColor = hphVayi5H9hk5uLLRE7C.AskQuoteColor;
				BestAskQuoteColor = hphVayi5H9hk5uLLRE7C.BestAskQuoteColor;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 != 0)
				{
					num = 2;
				}
				break;
			case 1:
				AddMargins = HOe76VeNAQeZjYZIdXsf(hphVayi5H9hk5uLLRE7C);
				ShowValues = hphVayi5H9hk5uLLRE7C.ShowValues;
				MinimizeValues = hphVayi5H9hk5uLLRE7C.MinimizeValues;
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
				{
					num = 5;
				}
				break;
			case 2:
				EmptyQuoteColor = hphVayi5H9hk5uLLRE7C.EmptyQuoteColor;
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
				{
					num = 6;
				}
				break;
			case 6:
			{
				BidVolumeColor = Hjqn9TeNFJSpGR1yojYQ(hphVayi5H9hk5uLLRE7C);
				AskVolumeColor = hphVayi5H9hk5uLLRE7C.AskVolumeColor;
				TextColor = YiHUUHeN3GkJ4NMvaDBe(hphVayi5H9hk5uLLRE7C);
				BackColor = hphVayi5H9hk5uLLRE7C.BackColor;
				int num2 = 4;
				num = num2;
				break;
			}
			}
		}
	}

	static HphVayi5H9hk5uLLRE7C()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		qYL8EaeNpYWPnhppcm6l();
	}

	internal static object QX9LTYeNRHbS1ylNBhfj(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool gNIq6ieNdOfaA5RfFXcv()
	{
		return ADcaOJeNQLK67s0GKjUQ == null;
	}

	internal static HphVayi5H9hk5uLLRE7C nnjQ3UeNg551CYLSAfdO()
	{
		return ADcaOJeNQLK67s0GKjUQ;
	}

	internal static bool QnvKsKeN6vRIxO348ojT(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static XColor uxyFjNeNMft4yrMEaM4s(Color P_0)
	{
		return P_0;
	}

	internal static Color dLtZj7eNO6MKOYnVFeOh()
	{
		return Colors.White;
	}

	internal static double edkfZ0eNqDa4B5TBqeDL(object P_0)
	{
		return ((IChartDataProvider)P_0).Step;
	}

	internal static object aCWbNOeNI5KRxKAw1Lde(object P_0)
	{
		return ((IChartDataProvider)P_0).Symbol;
	}

	internal static int Jd922LeNWmBIsTBRY40R(object P_0)
	{
		return ((XFont)P_0).Size;
	}

	internal static double nVwKNYeNtJxaF35jsMxn(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static void UKfESeeNUaQHMG8LwsAw(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static void JIRUieeNTd80F1Mdyi98(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static void W924IIeNyfNJaYt0ieVh(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool ywIvZNeNZ3k2wVkyjsfl(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static long s1EmeleNVZ61MYb3vn3O(object P_0)
	{
		return ((IRawMarketDepth)P_0).MaxAskPrice;
	}

	internal static double bIgEb5eNCYkMf0hha4ko(object P_0, double y)
	{
		return ((IChartCanvas)P_0).GetValue(y);
	}

	internal static double SABPW0eNrKDwDlJkAplE(double P_0)
	{
		return Math.Round(P_0);
	}

	internal static long CK9RGKeNKVi8VXwFAP89(object P_0)
	{
		return ((IRawMarketDepth)P_0).MinAskPrice;
	}

	internal static long SIdx4AeNmQik8cOQc9fo(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static int WtYBXEeNhCda8lg0q6MJ(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static long lbbP5UeNwuvRxVR0a4S5(object P_0)
	{
		return ((IRawMarketDepth)P_0).MaxBidPrice;
	}

	internal static object y8gHNReN7aIZP4fC1Tm0(object P_0, long size, int round, bool minimize)
	{
		return ((IChartSymbol)P_0).FormatRawSize(size, round, minimize);
	}

	internal static XColor CH1vJVeN8OSZKXT9uG9Y(object P_0)
	{
		return ((IChartTheme)P_0).PaletteColor7;
	}

	internal static bool HOe76VeNAQeZjYZIdXsf(object P_0)
	{
		return ((HphVayi5H9hk5uLLRE7C)P_0).AddMargins;
	}

	internal static object QPgQakeNPETWLtjZnm12(object P_0)
	{
		return ((HphVayi5H9hk5uLLRE7C)P_0).vUPi5o0eM99;
	}

	internal static XColor HEfgTweNJrsOjjeeM7wy(object P_0)
	{
		return ((HphVayi5H9hk5uLLRE7C)P_0).BestBidQuoteColor;
	}

	internal static XColor Hjqn9TeNFJSpGR1yojYQ(object P_0)
	{
		return ((HphVayi5H9hk5uLLRE7C)P_0).BidVolumeColor;
	}

	internal static XColor YiHUUHeN3GkJ4NMvaDBe(object P_0)
	{
		return ((HphVayi5H9hk5uLLRE7C)P_0).TextColor;
	}

	internal static void qYL8EaeNpYWPnhppcm6l()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
