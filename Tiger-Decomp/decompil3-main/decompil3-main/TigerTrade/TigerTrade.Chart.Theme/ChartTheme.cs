using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows.Media;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using MIA3eC2ZXsuRyAB0mjn;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Annotations;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Objects.Enums;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.Chart.Theme;

[ReadOnly(true)]
[DataContract(Name = "ChartTheme", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Theme")]
internal sealed class ChartTheme : IChartTheme, INotifyPropertyChanged, ICloneable
{
	private XColor _chartBackColor;

	private XColor _chartFontColor;

	private XColor _chartGridColor;

	private XColor _chartAxisColor;

	private XColor _chartSessionLineColor;

	private XColor _candleUpBackColor;

	private XColor _candleUpBorderColor;

	private XColor _candleUpWickColor;

	private XColor _candleDownBackColor;

	private XColor _candleDownBorderColor;

	private XColor _candleDownWickColor;

	private XColor _barUpBarColor;

	private XColor _barDownBarColor;

	private XColor _lineColor;

	private XColor _areaLineColor;

	private XColor _areaColor;

	private XColor _clusterVolumeColor;

	private XColor _clusterTradesColor;

	private XColor _clusterDeltaPlusColor;

	private XColor _clusterDeltaMinusColor;

	private XColor _clusterBidColor;

	private XColor _clusterAskColor;

	private XColor _clusterStrongBidColor;

	private XColor _clusterStrongAskColor;

	private XColor _clusterNeutralBidAskColor;

	private XColor _clusterOpenIntPlusColor;

	private XColor _clusterOpenIntMinusColor;

	private XColor _clusterUpBarColor;

	private XColor _clusterDownBarColor;

	private XColor _clusterValueAreaColor;

	private XColor _clusterCellBorderColor;

	private XColor _clusterCellBorderMaxColor;

	private XColor _clusterBorderColor;

	private XColor _clusterTextColor;

	private XColor _histogramVolumeColor;

	private XColor _histogramTradesColor;

	private XColor _histogramDeltaPlusColor;

	private XColor _histogramDeltaMinusColor;

	private XColor _histogramBidColor;

	private XColor _histogramAskColor;

	private XColor _histogramValueAreaColor;

	private XColor _histogramMaximumColor;

	private XColor _histogramCellBorderColor;

	private XColor _histogramTextColor;

	private XColor _domBackColor;

	private XColor _domTextColor;

	private XColor _domLineColor;

	private XColor _domGridColor;

	private XColor _quoteBuyColor;

	private XColor _quoteBestBuyColor;

	private XColor _quoteSellColor;

	private XColor _quoteBestSellColor;

	private XColor _quoteBuyVolumeColor;

	private XColor _quoteSellVolumeColor;

	private XColor _domProfitColor;

	private XColor _domLossColor;

	private XColor _quoteSelectedColor;

	private XColor _quoteLimitOrderColor;

	private XColor _quoteStopOrderColor;

	private XColor _quoteTriggerOrderColor;

	private XColor _cursorMarkerBackColor;

	private XColor _cursorMarkerTextColor;

	private XColor _cursorLineColor;

	private XColor _chartObjectLineColor;

	private XColor _chartObjectFillColor;

	private XColor _chartCpLineColor;

	private XColor _chartCpFillColor;

	private XColor _buyTradeColor;

	private XColor _buyTradeBorderColor;

	private XColor _sellTradeColor;

	private XColor _sellTradeBorderColor;

	private XColor _openLongPositionColor;

	private XColor _closeLongPositionColor;

	private XColor _openShortPositionColor;

	private XColor _closeShortPositionColor;

	private XColor _positionLineColor;

	private XColor _buyLimitOrderColor;

	private XColor _sellLimitOrderColor;

	private XColor _buyStopOrderColor;

	private XColor _sellStopOrderColor;

	private XColor _buyTriggerOrderColor;

	private XColor _sellTriggerOrderColor;

	private XColor _longPositionColor;

	private XColor _shortPositionColor;

	private XColor _positivePnLColor;

	private XColor _negativePnLColor;

	private XColor _takeProfitColor;

	private XColor _stopLossColor;

	private XColor _indicatorBackColor1;

	private XColor _indicatorBackColor2;

	private XColor _indicatorAlertBackColor;

	private XColor _paletteColor1;

	private XColor _paletteColor2;

	private XColor _paletteColor3;

	private XColor _paletteColor4;

	private XColor _paletteColor5;

	private XColor _paletteColor6;

	private XColor _paletteColor7;

	private XColor _selectionFillColor;

	private int _colorID;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static XColor _invalidColor;

	internal static ChartTheme bJey8vbL1J8txNQ3RIgD;

	[Browsable(false)]
	[DataMember(Name = "ThemeID")]
	public string ThemeID { get; set; }

	[DataMember(Name = "ThemeName")]
	[Browsable(false)]
	public string ThemeName { get; set; }

	[Browsable(false)]
	public XBrush ChartBackBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeMainColors")]
	[DataMember(Name = "ChartBackColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBackColor")]
	public XColor ChartBackColor
	{
		get
		{
			return _chartBackColor;
		}
		set
		{
			value = new XColor(byte.MaxValue, value);
			int num;
			if (value == _chartBackColor)
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
				{
					num = 0;
				}
			}
			else
			{
				_chartBackColor = value;
				ChartBackBrush = new XBrush(_chartBackColor);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
				{
					num = 1;
				}
			}
			switch (num)
			{
			case 1:
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--18459671 ^ 0x11DF861));
				break;
			case 0:
				break;
			}
		}
	}

	[Browsable(false)]
	public XBrush ChartFontBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeTextColor")]
	[DataMember(Name = "ChartFontColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeMainColors")]
	public XColor ChartFontColor
	{
		get
		{
			return _chartFontColor;
		}
		set
		{
			if (!(value == _chartFontColor))
			{
				_chartFontColor = value;
				ChartFontBrush = new XBrush(_chartFontColor);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -529769329));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
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

	[Browsable(false)]
	public XBrush ChartGridBrush { get; private set; }

	[Browsable(false)]
	public XPen ChartGridPen { get; private set; }

	[DataMember(Name = "ChartGridColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeGridColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeMainColors")]
	public XColor ChartGridColor
	{
		get
		{
			return _chartGridColor;
		}
		set
		{
			if (value == _chartGridColor)
			{
				return;
			}
			_chartGridColor = value;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					ChartGridPen = new XPen(ChartGridBrush, 1, XDashStyle.Solid);
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-671204305 ^ -671455079));
					return;
				case 1:
					ChartGridBrush = new XBrush(_chartGridColor);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush ChartAxisBrush { get; private set; }

	[Browsable(false)]
	public XPen ChartAxisPen { get; private set; }

	[DataMember(Name = "ChartAxisColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeScaleColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeMainColors")]
	public XColor ChartAxisColor
	{
		get
		{
			return _chartAxisColor;
		}
		set
		{
			if (value == _chartAxisColor)
			{
				return;
			}
			_chartAxisColor = value;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
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
					ChartAxisBrush = new XBrush(_chartAxisColor);
					ChartAxisPen = new XPen(ChartAxisBrush, 1);
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x6AB40973 ^ 0x6AB05DA5));
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
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

	[Browsable(false)]
	public XBrush ChartSessionLineBrush { get; private set; }

	[Browsable(false)]
	public XPen ChartSessionLinePen { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeSessionLineColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeMainColors")]
	[DataMember(Name = "ChartSessionLineColor")]
	public XColor ChartSessionLineColor
	{
		get
		{
			return _chartSessionLineColor;
		}
		set
		{
			if (value == _chartSessionLineColor)
			{
				return;
			}
			_chartSessionLineColor = value;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-203064540 ^ -203345966));
					return;
				}
				ChartSessionLineBrush = new XBrush(_chartSessionLineColor);
				ChartSessionLinePen = new XPen(ChartSessionLineBrush, 1);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush CandleUpBackBrush { get; private set; }

	[Browsable(false)]
	public XPen CandleUpBackPen { get; private set; }

	[DataMember(Name = "CandleUpBackColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCandles")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeUpCandleBackColor")]
	public XColor CandleUpBackColor
	{
		get
		{
			return _candleUpBackColor;
		}
		set
		{
			if (value == _candleUpBackColor)
			{
				return;
			}
			_candleUpBackColor = value;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
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
					CandleUpBackBrush = new XBrush(_candleUpBackColor);
					CandleUpBackPen = new XPen(CandleUpBackBrush, 1);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xAD5B8B3 ^ 0xAD1ED97));
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
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

	[Browsable(false)]
	public XBrush CandleUpBorderBrush { get; private set; }

	[Browsable(false)]
	public XPen CandleUpBorderPen { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeUpCandleBorderColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCandles")]
	[DataMember(Name = "CandleUpBorderColor")]
	public XColor CandleUpBorderColor
	{
		get
		{
			return _candleUpBorderColor;
		}
		set
		{
			if (value == _candleUpBorderColor)
			{
				return;
			}
			_candleUpBorderColor = value;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					CandleUpBorderPen = new XPen(CandleUpBorderBrush, 1);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1763895751 ^ -1764146317));
					return;
				}
				CandleUpBorderBrush = new XBrush(_candleUpBorderColor);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush CandleUpWickBrush { get; private set; }

	[Browsable(false)]
	public XPen CandleUpWickPen { get; private set; }

	[DataMember(Name = "CandleUpWickColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeUpCandleWickColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCandles")]
	public XColor CandleUpWickColor
	{
		get
		{
			return _candleUpWickColor;
		}
		set
		{
			if (!(value == _candleUpWickColor))
			{
				_candleUpWickColor = value;
				CandleUpWickBrush = new XBrush(_candleUpWickColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return;
				}
				CandleUpWickPen = new XPen(CandleUpWickBrush, 1);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127696480));
			}
		}
	}

	[Browsable(false)]
	public XBrush CandleDownBackBrush { get; private set; }

	[Browsable(false)]
	public XPen CandleDownBackPen { get; private set; }

	[DataMember(Name = "CandleDownBackColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeDownCandleBackColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCandles")]
	public XColor CandleDownBackColor
	{
		get
		{
			return _candleDownBackColor;
		}
		set
		{
			if (value == _candleDownBackColor)
			{
				return;
			}
			_candleDownBackColor = value;
			CandleDownBackBrush = new XBrush(_candleDownBackColor);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7B26D1));
					return;
				}
				CandleDownBackPen = new XPen(CandleDownBackBrush, 1);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush CandleDownBorderBrush { get; private set; }

	[Browsable(false)]
	public XPen CandleDownBorderPen { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeDownCandleBorderColor")]
	[DataMember(Name = "CandleDownBorderColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCandles")]
	public XColor CandleDownBorderColor
	{
		get
		{
			return _candleDownBorderColor;
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
					return;
				case 2:
					if (!AZAnigbLLcWn0OlKT4b6(value, _candleDownBorderColor))
					{
						_candleDownBorderColor = value;
						CandleDownBorderBrush = new XBrush(_candleDownBorderColor);
						CandleDownBorderPen = new XPen(CandleDownBorderBrush, 1);
						OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-2002318893 ^ -2002559977));
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
						{
							num2 = 1;
						}
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush CandleDownWickBrush { get; private set; }

	[Browsable(false)]
	public XPen CandleDownWickPen { get; private set; }

	[DataMember(Name = "CandleDownWickColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCandles")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeDownCandleWickColor")]
	public XColor CandleDownWickColor
	{
		get
		{
			return _candleDownWickColor;
		}
		set
		{
			if (AZAnigbLLcWn0OlKT4b6(value, _candleDownWickColor))
			{
				return;
			}
			_candleDownWickColor = value;
			CandleDownWickBrush = new XBrush(_candleDownWickColor);
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
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
					CandleDownWickPen = new XPen(CandleDownWickBrush, 1);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461292091 ^ -1461574089));
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
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

	[Browsable(false)]
	public XBrush BarUpBarBrush { get; private set; }

	[DataMember(Name = "BarUpBarColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeUpBarColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeBars")]
	public XColor BarUpBarColor
	{
		get
		{
			return _barUpBarColor;
		}
		set
		{
			if (!(value == _barUpBarColor))
			{
				_barUpBarColor = value;
				BarUpBarBrush = new XBrush(_barUpBarColor);
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1306877528 ^ -1306593356));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
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

	[Browsable(false)]
	public XBrush BarDownBarBrush { get; private set; }

	[DataMember(Name = "BarDownBarColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeBars")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeDownBarColor")]
	public XColor BarDownBarColor
	{
		get
		{
			return _barDownBarColor;
		}
		set
		{
			if (!(value == _barDownBarColor))
			{
				_barDownBarColor = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				BarDownBarBrush = new XBrush(_barDownBarColor);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839416168));
			}
		}
	}

	[Browsable(false)]
	public XBrush LineBrush { get; private set; }

	[DataMember(Name = "LineColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeLineColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeLine")]
	public XColor LineColor
	{
		get
		{
			return _lineColor;
		}
		set
		{
			if (!(value == _lineColor))
			{
				_lineColor = value;
				LineBrush = new XBrush(_lineColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-45476899 ^ -45207117));
			}
		}
	}

	[Browsable(false)]
	public XBrush ServerAlertLineBrush => (XBrush)INd4TwbLekZog9viqQ7N(j18iDj9nukSCmEyZs5lH.Settings);

	[Browsable(false)]
	public XPen ServerAlertLinePen => ((MhMDPU9v8rkigy1ao0Th)mlcSAXbLsTXLCy2CEVmm()).RsK9DQRW7Ud;

	[Browsable(false)]
	public XPen ServerAlertCpBorderPen => ((MhMDPU9v8rkigy1ao0Th)mlcSAXbLsTXLCy2CEVmm()).ixk9DtsiD1G;

	[Browsable(false)]
	public XBrush ServerAlertCpBackBrush => ((MhMDPU9v8rkigy1ao0Th)mlcSAXbLsTXLCy2CEVmm()).gOt9DVyDjpE;

	[Browsable(false)]
	public XColor ServerAlertLineColor
	{
		get
		{
			return ((MhMDPU9v8rkigy1ao0Th)mlcSAXbLsTXLCy2CEVmm()).ServerAlertLevelColor;
		}
		set
		{
			if (!(value == ((MhMDPU9v8rkigy1ao0Th)mlcSAXbLsTXLCy2CEVmm()).ServerAlertLevelColor))
			{
				j18iDj9nukSCmEyZs5lH.Settings.ServerAlertLevelColor = value;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1416702177));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
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

	[Browsable(false)]
	public int ServerAlertLineWidth
	{
		get
		{
			return j18iDj9nukSCmEyZs5lH.Settings.ServerAlertLevelWidth;
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
					if (value != j18iDj9nukSCmEyZs5lH.Settings.ServerAlertLevelWidth)
					{
						j18iDj9nukSCmEyZs5lH.Settings.ServerAlertLevelWidth = value;
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342463018));
					}
					return;
				case 1:
					value = Math.Max(1, HHMnojbLX2lIPJYnQNbv(10, value));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XDashStyle ServerAlertLineStyle
	{
		get
		{
			return j18iDj9nukSCmEyZs5lH.Settings.ServerAlertLevelStyle;
		}
		set
		{
			if (value != j18iDj9nukSCmEyZs5lH.Settings.ServerAlertLevelStyle)
			{
				((MhMDPU9v8rkigy1ao0Th)mlcSAXbLsTXLCy2CEVmm()).ServerAlertLevelStyle = value;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1324952825));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
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

	[Browsable(false)]
	public ObjectTextAlignment ServerAlertBellAlignment
	{
		get
		{
			return tyry14bLcvB6iwC1gJhB(j18iDj9nukSCmEyZs5lH.Settings);
		}
		set
		{
			if (value != j18iDj9nukSCmEyZs5lH.Settings.ServerAlertBellAlignment)
			{
				VOkus5bLj9rXnJixeSct(j18iDj9nukSCmEyZs5lH.Settings, value);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x385FFAB ^ 0x381AE67));
			}
		}
	}

	[Browsable(false)]
	public XBrush AreaLineBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeLineColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeArea")]
	[DataMember(Name = "AreaLineColor")]
	public XColor AreaLineColor
	{
		get
		{
			return _areaLineColor;
		}
		set
		{
			if (!(value == _areaLineColor))
			{
				_areaLineColor = value;
				AreaLineBrush = new XBrush(_areaLineColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1999650146 ^ -1999924098));
			}
		}
	}

	[Browsable(false)]
	public XBrush AreaBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeAreaColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeArea")]
	[DataMember(Name = "AreaColor")]
	public XColor AreaColor
	{
		get
		{
			return _areaColor;
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
					if (!(value == _areaColor))
					{
						_areaColor = value;
						AreaBrush = new XBrush(_areaColor);
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1D7BA1ED ^ 0x1D7FF713));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterVolumeBrush { get; private set; }

	[DataMember(Name = "ClusterVolumeColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeVolumeColor")]
	public XColor ClusterVolumeColor
	{
		get
		{
			return _clusterVolumeColor;
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
					if (!(value == _clusterVolumeColor))
					{
						_clusterVolumeColor = value;
						ClusterVolumeBrush = new XBrush(_clusterVolumeColor);
						OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x5EA8FF2A ^ 0x5EACDBB0));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterTradesBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	[DataMember(Name = "ClusterTradesColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeTradesColor")]
	public XColor ClusterTradesColor
	{
		get
		{
			return _clusterTradesColor;
		}
		set
		{
			if (!(value == _clusterTradesColor))
			{
				_clusterTradesColor = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return;
				}
				ClusterTradesBrush = new XBrush(_clusterTradesColor);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xECA3F28 ^ 0xECE1BEA));
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterDeltaPlusBrush { get; private set; }

	[DataMember(Name = "ClusterDeltaPlusColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeDeltaPlusColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	public XColor ClusterDeltaPlusColor
	{
		get
		{
			return _clusterDeltaPlusColor;
		}
		set
		{
			if (!AZAnigbLLcWn0OlKT4b6(value, _clusterDeltaPlusColor))
			{
				_clusterDeltaPlusColor = value;
				ClusterDeltaPlusBrush = new XBrush(_clusterDeltaPlusColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1047165041 ^ -1047420221));
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterDeltaMinusBrush { get; private set; }

	[DataMember(Name = "ClusterDeltaMinusColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeDeltaMinusColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	public XColor ClusterDeltaMinusColor
	{
		get
		{
			return _clusterDeltaMinusColor;
		}
		set
		{
			if (!(value == _clusterDeltaMinusColor))
			{
				_clusterDeltaMinusColor = value;
				ClusterDeltaMinusBrush = new XBrush(_clusterDeltaMinusColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x12620268 ^ 0x12662712));
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterBidBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBidColor")]
	[DataMember(Name = "ClusterBidColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	public XColor ClusterBidColor
	{
		get
		{
			return _clusterBidColor;
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
					if (!(value == _clusterBidColor))
					{
						_clusterBidColor = value;
						ClusterBidBrush = new XBrush(_clusterBidColor);
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -124030457));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterAskBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	[DataMember(Name = "ClusterAskColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeAskColor")]
	public XColor ClusterAskColor
	{
		get
		{
			return _clusterAskColor;
		}
		set
		{
			if (!AZAnigbLLcWn0OlKT4b6(value, _clusterAskColor))
			{
				_clusterAskColor = value;
				ClusterAskBrush = new XBrush(_clusterAskColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1435596783 ^ -1435849251));
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterStrongBidBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeStrongBidColor")]
	[DataMember(Name = "ClusterStrongBidColor")]
	public XColor ClusterStrongBidColor
	{
		get
		{
			return _clusterStrongBidColor;
		}
		set
		{
			if (!(value == _clusterStrongBidColor))
			{
				_clusterStrongBidColor = value;
				ClusterStrongBidBrush = new XBrush(_clusterStrongBidColor);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53511078));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
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

	[Browsable(false)]
	public XBrush ClusterStrongAskBrush { get; private set; }

	[DataMember(Name = "ClusterStrongAskColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeStrongAskColor")]
	public XColor ClusterStrongAskColor
	{
		get
		{
			return _clusterStrongAskColor;
		}
		set
		{
			if (!(value == _clusterStrongAskColor))
			{
				_clusterStrongAskColor = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ClusterStrongAskBrush = new XBrush(_clusterStrongAskColor);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1324964945));
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterNeutralBidAskBrush { get; private set; }

	[DataMember(Name = "ClusterNeutralBidAskColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeNeutralBidAskColor")]
	public XColor ClusterNeutralBidAskColor
	{
		get
		{
			return _clusterNeutralBidAskColor;
		}
		set
		{
			if (!(value == _clusterNeutralBidAskColor))
			{
				_clusterNeutralBidAskColor = value;
				ClusterNeutralBidAskBrush = new XBrush(_clusterNeutralBidAskColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x4662F6AF ^ 0x4666D0E5));
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterOpenIntPlusBrush { get; private set; }

	[DataMember(Name = "ClusterOpenIntPlusColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeOpenIntPlusColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	public XColor ClusterOpenIntPlusColor
	{
		get
		{
			return _clusterOpenIntPlusColor;
		}
		set
		{
			if (!AZAnigbLLcWn0OlKT4b6(value, _clusterOpenIntPlusColor))
			{
				_clusterOpenIntPlusColor = value;
				ClusterOpenIntPlusBrush = new XBrush(_clusterOpenIntPlusColor);
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x28B345BB ^ 0x28B7633B));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					break;
				case 0:
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterOpenIntMinusBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeOpenIntMinusColor")]
	[DataMember(Name = "ClusterOpenIntMinusColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	public XColor ClusterOpenIntMinusColor
	{
		get
		{
			return _clusterOpenIntMinusColor;
		}
		set
		{
			if (!(value == _clusterOpenIntMinusColor))
			{
				_clusterOpenIntMinusColor = value;
				ClusterOpenIntMinusBrush = new XBrush(_clusterOpenIntMinusColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342483476));
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterUpBarBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	[DataMember(Name = "ClusterUpBarColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeUpBarColor")]
	public XColor ClusterUpBarColor
	{
		get
		{
			return _clusterUpBarColor;
		}
		set
		{
			if (!(value == _clusterUpBarColor))
			{
				_clusterUpBarColor = value;
				ClusterUpBarBrush = new XBrush(_clusterUpBarColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xB15786A ^ 0xB115E8C));
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterDownBarBrush { get; private set; }

	[DataMember(Name = "ClusterDownBarColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeDownBarColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	public XColor ClusterDownBarColor
	{
		get
		{
			return _clusterDownBarColor;
		}
		set
		{
			if (!(value == _clusterDownBarColor))
			{
				_clusterDownBarColor = value;
				ClusterDownBarBrush = new XBrush(_clusterDownBarColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x741B85CB ^ 0x741FA2C7));
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterValueAreaBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeValueAreaColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	[DataMember(Name = "ClusterValueAreaColor")]
	public XColor ClusterValueAreaColor
	{
		get
		{
			return _clusterValueAreaColor;
		}
		set
		{
			if (!(value == _clusterValueAreaColor))
			{
				_clusterValueAreaColor = value;
				ClusterValueAreaBrush = new XBrush(_clusterValueAreaColor);
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x5CD4F15 ^ 0x5C96823));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
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

	[Browsable(false)]
	public XBrush ClusterCellBorderBrush { get; private set; }

	[Browsable(false)]
	public XPen ClusterCellBorderPen { get; private set; }

	[DataMember(Name = "ClusterCellBorderColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeCellBorderColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	public XColor ClusterCellBorderColor
	{
		get
		{
			return _clusterCellBorderColor;
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
					if (!(value == _clusterCellBorderColor))
					{
						_clusterCellBorderColor = value;
						ClusterCellBorderBrush = new XBrush(_clusterCellBorderColor);
						ClusterCellBorderPen = new XPen(ClusterCellBorderBrush, 1);
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2056710528 ^ -2056441372));
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
						{
							num2 = 0;
						}
					}
					break;
				case 2:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterCellBorderMaxBrush { get; private set; }

	[Browsable(false)]
	public XPen ClusterCellBorderMaxPen { get; private set; }

	[DataMember(Name = "ClusterCellBorderMaxColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeCellBorderMaxColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	public XColor ClusterCellBorderMaxColor
	{
		get
		{
			return _clusterCellBorderMaxColor;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (value == _clusterCellBorderMaxColor)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
						{
							num2 = 1;
						}
						break;
					}
					_clusterCellBorderMaxColor = value;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return;
				default:
					ClusterCellBorderMaxBrush = new XBrush(_clusterCellBorderMaxColor);
					ClusterCellBorderMaxPen = new XPen(ClusterCellBorderMaxBrush, 1);
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1841489831 ^ -1841741875));
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterBorderBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBorderColor")]
	[DataMember(Name = "ClusterBorderColor")]
	public XColor ClusterBorderColor
	{
		get
		{
			return _clusterBorderColor;
		}
		set
		{
			if (!(value == _clusterBorderColor))
			{
				_clusterBorderColor = value;
				ClusterBorderBrush = new XBrush(_clusterBorderColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x4293E421));
			}
		}
	}

	[Browsable(false)]
	public XBrush ClusterTextBrush { get; private set; }

	[DataMember(Name = "ClusterTextColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCluster")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeTextColor")]
	public XColor ClusterTextColor
	{
		get
		{
			return _clusterTextColor;
		}
		set
		{
			if (!(value == _clusterTextColor))
			{
				_clusterTextColor = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ClusterTextBrush = new XBrush(_clusterTextColor);
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1346994499 ^ -1347266225));
			}
		}
	}

	[Browsable(false)]
	public XBrush HistogramVolumeBrush { get; private set; }

	[DataMember(Name = "HistogramVolumeColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeVolumeColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeHistogram")]
	public XColor HistogramVolumeColor
	{
		get
		{
			return _histogramVolumeColor;
		}
		set
		{
			if (!(value == _histogramVolumeColor))
			{
				_histogramVolumeColor = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				HistogramVolumeBrush = new XBrush(_histogramVolumeColor);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-203064540 ^ -203336738));
			}
		}
	}

	[Browsable(false)]
	public XBrush HistogramTradesBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeHistogram")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeTradesColor")]
	[DataMember(Name = "HistogramTradesColor")]
	public XColor HistogramTradesColor
	{
		get
		{
			return _histogramTradesColor;
		}
		set
		{
			if (!(value == _histogramTradesColor))
			{
				_histogramTradesColor = value;
				HistogramTradesBrush = new XBrush(_histogramTradesColor);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x60620FC1 ^ 0x606626E7));
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 0:
					break;
				case 1:
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush HistogramDeltaPlusBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeHistogram")]
	[DataMember(Name = "HistogramDeltaPlusColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeDeltaPlusColor")]
	public XColor HistogramDeltaPlusColor
	{
		get
		{
			return _histogramDeltaPlusColor;
		}
		set
		{
			if (!AZAnigbLLcWn0OlKT4b6(value, _histogramDeltaPlusColor))
			{
				_histogramDeltaPlusColor = value;
				HistogramDeltaPlusBrush = new XBrush(_histogramDeltaPlusColor);
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1801468030 ^ -1801720112));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
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

	[Browsable(false)]
	public XBrush HistogramDeltaMinusBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeHistogram")]
	[DataMember(Name = "HistogramDeltaMinusColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeDeltaMinusColor")]
	public XColor HistogramDeltaMinusColor
	{
		get
		{
			return _histogramDeltaMinusColor;
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
					_histogramDeltaMinusColor = value;
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (value == _histogramDeltaMinusColor)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					HistogramDeltaMinusBrush = new XBrush(_histogramDeltaMinusColor);
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-5977659 ^ -6234047));
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush HistogramBidBrush { get; private set; }

	[DataMember(Name = "HistogramBidColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeHistogram")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBidColor")]
	public XColor HistogramBidColor
	{
		get
		{
			return _histogramBidColor;
		}
		set
		{
			if (!(value == _histogramBidColor))
			{
				_histogramBidColor = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				HistogramBidBrush = new XBrush(_histogramBidColor);
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1309555870 ^ -1309283622));
			}
		}
	}

	[Browsable(false)]
	public XBrush HistogramAskBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeHistogram")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeAskColor")]
	[DataMember(Name = "HistogramAskColor")]
	public XColor HistogramAskColor
	{
		get
		{
			return _histogramAskColor;
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
					if (!(value == _histogramAskColor))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 2:
					return;
				default:
					_histogramAskColor = value;
					HistogramAskBrush = new XBrush(_histogramAskColor);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E29D233));
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush HistogramValueAreaBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeValueAreaColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeHistogram")]
	[DataMember(Name = "HistogramValueAreaColor")]
	public XColor HistogramValueAreaColor
	{
		get
		{
			return _histogramValueAreaColor;
		}
		set
		{
			if (!AZAnigbLLcWn0OlKT4b6(value, _histogramValueAreaColor))
			{
				_histogramValueAreaColor = value;
				HistogramValueAreaBrush = new XBrush(_histogramValueAreaColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-45476899 ^ -45205031));
			}
		}
	}

	[Browsable(false)]
	public XBrush HistogramMaximumBrush { get; private set; }

	[DataMember(Name = "HistogramMaximumColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemePocColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeHistogram")]
	public XColor HistogramMaximumColor
	{
		get
		{
			return _histogramMaximumColor;
		}
		set
		{
			if (!AZAnigbLLcWn0OlKT4b6(value, _histogramMaximumColor))
			{
				_histogramMaximumColor = value;
				HistogramMaximumBrush = new XBrush(_histogramMaximumColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -339025152));
			}
		}
	}

	[Browsable(false)]
	public XBrush HistogramCellBorderBrush { get; private set; }

	[Browsable(false)]
	public XPen HistogramCellBorderPen { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeCellBorderColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeHistogram")]
	[DataMember(Name = "HistogramCellBorderColor")]
	public XColor HistogramCellBorderColor
	{
		get
		{
			return _histogramCellBorderColor;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				default:
					_histogramCellBorderColor = value;
					HistogramCellBorderBrush = new XBrush(_histogramCellBorderColor);
					HistogramCellBorderPen = new XPen(HistogramCellBorderBrush, 1);
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x446AB724 ^ 0x446E9D40));
					return;
				case 1:
					if (value == _histogramCellBorderColor)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush HistogramTextBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeHistogram")]
	[DataMember(Name = "HistogramTextColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeTextColor")]
	public XColor HistogramTextColor
	{
		get
		{
			return _histogramTextColor;
		}
		set
		{
			if (!(value == _histogramTextColor))
			{
				_histogramTextColor = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				HistogramTextBrush = new XBrush(_histogramTextColor);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-527080372 ^ -527348012));
			}
		}
	}

	[Browsable(false)]
	public XBrush DomBackBrush { get; private set; }

	[Browsable(false)]
	public XPen DomBackPen { get; private set; }

	[DataMember(Name = "DomBackColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBackColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	public XColor DomBackColor
	{
		get
		{
			return _domBackColor;
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
					value = new XColor(byte.MaxValue, RP9iVtbLEOMkW1JfaXAf(value));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				if (AZAnigbLLcWn0OlKT4b6(value, _domBackColor))
				{
					return;
				}
				_domBackColor = value;
				DomBackBrush = new XBrush(value);
				DomBackPen = new XPen(DomBackBrush, 1);
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x28C965BE ^ 0x28CD32AA));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d != 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush DomTextBrush { get; private set; }

	[DataMember(Name = "DomTextColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeTextColor")]
	public XColor DomTextColor
	{
		get
		{
			return _domTextColor;
		}
		set
		{
			if (!AZAnigbLLcWn0OlKT4b6(value, _domTextColor))
			{
				_domTextColor = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				DomTextBrush = new XBrush(value);
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x12620268 ^ 0x12665558));
			}
		}
	}

	[Browsable(false)]
	public XBrush DomLineBrush { get; private set; }

	[Browsable(false)]
	public XPen DomLinePen { get; private set; }

	[DataMember(Name = "DomLineColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeLineColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	public XColor DomLineColor
	{
		get
		{
			return _domLineColor;
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
					_domLineColor = value;
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					DomLineBrush = new XBrush(value);
					DomLinePen = new XPen(DomLineBrush, 1);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B1D39E));
					return;
				case 1:
					if (AZAnigbLLcWn0OlKT4b6(value, _domLineColor))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush DomGridBrush { get; private set; }

	[Browsable(false)]
	public XPen DomGridPen { get; private set; }

	[DataMember(Name = "DomGridColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeGridColor")]
	public XColor DomGridColor
	{
		get
		{
			return _domGridColor;
		}
		set
		{
			if (AZAnigbLLcWn0OlKT4b6(value, _domGridColor))
			{
				return;
			}
			_domGridColor = value;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-624753169 ^ -624471417));
					return;
				}
				DomGridBrush = new XBrush(value);
				DomGridPen = new XPen(DomGridBrush, 1);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
				{
					num = 1;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush QuoteBuyBrush { get; private set; }

	[DataMember(Name = "QuoteBuyColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBidQuoteColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	public XColor QuoteBuyColor
	{
		get
		{
			return _quoteBuyColor;
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
					_quoteBuyColor = value;
					QuoteBuyBrush = new XBrush(value);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (AZAnigbLLcWn0OlKT4b6(value, _quoteBuyColor))
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1962651919 ^ -1962909107));
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush QuoteBestBuyBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBestBidQuoteColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[DataMember(Name = "QuoteBestBuyColor")]
	public XColor QuoteBestBuyColor
	{
		get
		{
			return _quoteBestBuyColor;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710756166));
					return;
				case 1:
					if (!(value == _quoteBestBuyColor))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					_quoteBestBuyColor = value;
					QuoteBestBuyBrush = new XBrush(value);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush QuoteSellBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeAskQuoteColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[DataMember(Name = "QuoteSellColor")]
	public XColor QuoteSellColor
	{
		get
		{
			return _quoteSellColor;
		}
		set
		{
			if (!AZAnigbLLcWn0OlKT4b6(value, _quoteSellColor))
			{
				_quoteSellColor = value;
				QuoteSellBrush = new XBrush(value);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28B345BB ^ 0x28B768BB));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
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

	[Browsable(false)]
	public XBrush QuoteBestSellBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[DataMember(Name = "QuoteBestSellColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBestAskQuoteColor")]
	public XColor QuoteBestSellColor
	{
		get
		{
			return _quoteBestSellColor;
		}
		set
		{
			if (!(value == _quoteBestSellColor))
			{
				_quoteBestSellColor = value;
				QuoteBestSellBrush = new XBrush(value);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x28BBDCA ^ 0x28F90EA));
			}
		}
	}

	[Browsable(false)]
	public XBrush QuoteBuyVolumeBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBidQuoteVolumeColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[DataMember(Name = "QuoteBuyVolumeColor")]
	public XColor QuoteBuyVolumeColor
	{
		get
		{
			return _quoteBuyVolumeColor;
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
					if (value == _quoteBuyVolumeColor)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
						{
							num2 = 0;
						}
						break;
					}
					_quoteBuyVolumeColor = value;
					QuoteBuyVolumeBrush = new XBrush(value);
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-527080372 ^ -527349172));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush QuoteSellVolumeBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeAskQuoteVolumeColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[DataMember(Name = "QuoteSellVolumeColor")]
	public XColor QuoteSellVolumeColor
	{
		get
		{
			return _quoteSellVolumeColor;
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
				case 0:
					return;
				case 1:
					_quoteSellVolumeColor = value;
					QuoteSellVolumeBrush = new XBrush(value);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x4293EDC1));
					return;
				case 2:
					if (value == _quoteSellVolumeColor)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush DomProfitBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeProfitIndicatorColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[DataMember(Name = "DomProfitColor")]
	public XColor DomProfitColor
	{
		get
		{
			return _domProfitColor;
		}
		set
		{
			if (!(value == _domProfitColor))
			{
				_domProfitColor = value;
				DomProfitBrush = new XBrush(value);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3544E813 ^ 0x3540C645));
			}
		}
	}

	[Browsable(false)]
	public XBrush DomLossBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeLossIndicatorColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[DataMember(Name = "DomLossColor")]
	public XColor DomLossColor
	{
		get
		{
			return _domLossColor;
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
					if (!AZAnigbLLcWn0OlKT4b6(value, _domLossColor))
					{
						_domLossColor = value;
						DomLossBrush = new XBrush(value);
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2017337494 ^ -2017070820));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush QuoteSelectedBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeQuoteSelectionMarkerColor")]
	[DataMember(Name = "QuoteSelectedColor")]
	public XColor QuoteSelectedColor
	{
		get
		{
			return _quoteSelectedColor;
		}
		set
		{
			if (!(value == _quoteSelectedColor))
			{
				_quoteSelectedColor = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				QuoteSelectedBrush = new XBrush(value);
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-29702950 ^ -29431224));
			}
		}
	}

	[Browsable(false)]
	public XBrush QuoteLimitOrderBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeLimitOrderMarkerColor")]
	[DataMember(Name = "QuoteLimitOrderColor")]
	public XColor QuoteLimitOrderColor
	{
		get
		{
			return _quoteLimitOrderColor;
		}
		set
		{
			if (!AZAnigbLLcWn0OlKT4b6(value, _quoteLimitOrderColor))
			{
				_quoteLimitOrderColor = value;
				QuoteLimitOrderBrush = new XBrush(value);
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1799510641 ^ -1799779679));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
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

	[Browsable(false)]
	public XBrush QuoteStopOrderBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[DataMember(Name = "QuoteStopOrderColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeStopOrderMarkerColor")]
	public XColor QuoteStopOrderColor
	{
		get
		{
			return _quoteStopOrderColor;
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
					if (value == _quoteStopOrderColor)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
						{
							num2 = 0;
						}
						break;
					}
					_quoteStopOrderColor = value;
					QuoteStopOrderBrush = new XBrush(value);
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1962651919 ^ -1962909383));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush QuoteTriggerOrderBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeTriggerOrderMarkerColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDom")]
	[DataMember(Name = "QuoteTriggerOrderColor")]
	public XColor QuoteTriggerOrderColor
	{
		get
		{
			return _quoteTriggerOrderColor;
		}
		set
		{
			if (!(value == _quoteTriggerOrderColor))
			{
				_quoteTriggerOrderColor = value;
				QuoteTriggerOrderBrush = new XBrush(value);
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 0:
					break;
				case 1:
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-520155535 ^ -520405459));
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush CursorMarkerBackBrush { get; private set; }

	[DataMember(Name = "CursorMarkerBackColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeMarkerBackColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeCursor")]
	public XColor CursorMarkerBackColor
	{
		get
		{
			return _cursorMarkerBackColor;
		}
		set
		{
			if (!AZAnigbLLcWn0OlKT4b6(value, _cursorMarkerBackColor))
			{
				_cursorMarkerBackColor = value;
				CursorMarkerBackBrush = new XBrush(_cursorMarkerBackColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D1CAFE6));
			}
		}
	}

	[Browsable(false)]
	public XBrush CursorMarkerTextBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeCursor")]
	[DataMember(Name = "CursorMarkerTextColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeMarkerTextColor")]
	public XColor CursorMarkerTextColor
	{
		get
		{
			return _cursorMarkerTextColor;
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
					if (!(value == _cursorMarkerTextColor))
					{
						_cursorMarkerTextColor = value;
						CursorMarkerTextBrush = new XBrush(_cursorMarkerTextColor);
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B4EE54));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush CursorLineBrush { get; private set; }

	[Browsable(false)]
	public XBrush CursorLine2Brush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeCursor")]
	[DataMember(Name = "CursorLineColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeLineColor")]
	public XColor CursorLineColor
	{
		get
		{
			return _cursorLineColor;
		}
		set
		{
			if (value == _cursorLineColor)
			{
				return;
			}
			_cursorLineColor = value;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
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
				CursorLineBrush = new XBrush(_cursorLineColor);
				CursorLine2Brush = new XBrush(new XColor((byte)(_cursorLineColor.Alpha / 2), _cursorLineColor));
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x1EFE0A28 ^ 0x1EFA5DC8));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeLineColor")]
	[DataMember(Name = "ChartObjectLineColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeDrawingObjects")]
	public XColor ChartObjectLineColor
	{
		get
		{
			return _chartObjectLineColor;
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
					if (value == _chartObjectLineColor)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_chartObjectLineColor = value;
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-338769610 ^ -339046092));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartThemeDrawingObjects")]
	[DataMember(Name = "ChartObjectFillColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBackColor")]
	public XColor ChartObjectFillColor
	{
		get
		{
			return _chartObjectFillColor;
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
					if (AZAnigbLLcWn0OlKT4b6(value, _chartObjectFillColor))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
						{
							num2 = 0;
						}
						break;
					}
					_chartObjectFillColor = value;
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(--927068468 ^ 0x3745A91A));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush ChartCpLineBrush { get; private set; }

	[Browsable(false)]
	public XPen ChartCpLinePen { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeLineColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeControlPoints")]
	[DataMember(Name = "ChartCpLineColor")]
	public XColor ChartCpLineColor
	{
		get
		{
			return _chartCpLineColor;
		}
		set
		{
			if (value == _chartCpLineColor)
			{
				return;
			}
			_chartCpLineColor = value;
			ChartCpLineBrush = new XBrush(_chartCpLineColor);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
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
				ChartCpLinePen = new XPen(ChartCpLineBrush, 1);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-377195341 ^ -377475863));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
				{
					num = 1;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush ChartCpFillBrush { get; private set; }

	[DataMember(Name = "ChartCpFillColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeControlPoints")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBackColor")]
	public XColor ChartCpFillColor
	{
		get
		{
			return _chartCpFillColor;
		}
		set
		{
			if (!AZAnigbLLcWn0OlKT4b6(value, _chartCpFillColor))
			{
				_chartCpFillColor = value;
				ChartCpFillBrush = new XBrush(_chartCpFillColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -339046072));
			}
		}
	}

	[Browsable(false)]
	public XBrush BuyTradeBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBuyTrade")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[DataMember(Name = "BuyTradeColor")]
	public XColor BuyTradeColor
	{
		get
		{
			return _buyTradeColor;
		}
		set
		{
			if (!(value == _buyTradeColor))
			{
				_buyTradeColor = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				BuyTradeBrush = new XBrush(_buyTradeColor);
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x3E0426F0 ^ 0x3E007E52));
			}
		}
	}

	[Browsable(false)]
	public XBrush BuyTradeBorderBrush { get; private set; }

	[Browsable(false)]
	public XPen BuyTradeBorderPen { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBuyTradeBorder")]
	[DataMember(Name = "BuyTradeBorderColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	public XColor BuyTradeBorderColor
	{
		get
		{
			return _buyTradeBorderColor;
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
					return;
				case 2:
					if (!(value == _buyTradeBorderColor))
					{
						_buyTradeBorderColor = value;
						BuyTradeBorderBrush = new XBrush(_buyTradeBorderColor);
						BuyTradeBorderPen = new XPen(BuyTradeBorderBrush, 2);
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1306877528 ^ -1306592920));
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
						{
							num2 = 1;
						}
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush SellTradeBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeSellTrade")]
	[DataMember(Name = "SellTradeColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	public XColor SellTradeColor
	{
		get
		{
			return _sellTradeColor;
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
					if (value == _sellTradeColor)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
						{
							num2 = 0;
						}
						break;
					}
					_sellTradeColor = value;
					SellTradeBrush = new XBrush(_sellTradeColor);
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-710503328 ^ -710751094));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush SellTradeBorderBrush { get; private set; }

	[Browsable(false)]
	public XPen SellTradeBorderPen { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeSellTradeBorder")]
	[DataMember(Name = "SellTradeBorderColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	public XColor SellTradeBorderColor
	{
		get
		{
			return _sellTradeBorderColor;
		}
		set
		{
			if (AZAnigbLLcWn0OlKT4b6(value, _sellTradeBorderColor))
			{
				return;
			}
			_sellTradeBorderColor = value;
			SellTradeBorderBrush = new XBrush(_sellTradeBorderColor);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					SellTradeBorderPen = new XPen(SellTradeBorderBrush, 2);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
					{
						num = 0;
					}
					break;
				default:
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x42D899B5 ^ 0x42DCC0BF));
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush OpenLongPositionBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeOpenLongPosition")]
	[DataMember(Name = "OpenLongPositionColor")]
	public XColor OpenLongPositionColor
	{
		get
		{
			return _openLongPositionColor;
		}
		set
		{
			if (!(value == _openLongPositionColor))
			{
				_openLongPositionColor = value;
				OpenLongPositionBrush = new XBrush(_openLongPositionColor);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446EEE12));
			}
		}
	}

	[Browsable(false)]
	public XBrush CloseLongPositionBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeCloseLongPosition")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[DataMember(Name = "CloseLongPositionColor")]
	public XColor CloseLongPositionColor
	{
		get
		{
			return _closeLongPositionColor;
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
					if (!(value == _closeLongPositionColor))
					{
						_closeLongPositionColor = value;
						CloseLongPositionBrush = new XBrush(_closeLongPositionColor);
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-176525661 ^ -176277561));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush OpenShortPositionBrush { get; private set; }

	[DataMember(Name = "OpenShortPositionColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeOpenShortPosition")]
	public XColor OpenShortPositionColor
	{
		get
		{
			return _openShortPositionColor;
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
					if (value == _openShortPositionColor)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_openShortPositionColor = value;
					OpenShortPositionBrush = new XBrush(_openShortPositionColor);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D313048 ^ 0x2D3569DC));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush CloseShortPositionBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeCloseShortPosition")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[DataMember(Name = "CloseShortPositionColor")]
	public XColor CloseShortPositionColor
	{
		get
		{
			return _closeShortPositionColor;
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
					if (!(value == _closeShortPositionColor))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 2:
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xB15786A ^ 0xB1121AE));
					return;
				default:
					_closeShortPositionColor = value;
					CloseShortPositionBrush = new XBrush(_closeShortPositionColor);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush PositionLineBrush { get; private set; }

	[Browsable(false)]
	public XPen PositionLinePen { get; private set; }

	[DataMember(Name = "PositionLineColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemePositionLine")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	public XColor PositionLineColor
	{
		get
		{
			return _positionLineColor;
		}
		set
		{
			if (AZAnigbLLcWn0OlKT4b6(value, _positionLineColor))
			{
				return;
			}
			_positionLineColor = value;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
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
				PositionLineBrush = new XBrush(_positionLineColor);
				PositionLinePen = new XPen(PositionLineBrush, 2, XDashStyle.Dash);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446EEED2));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num = 1;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush BuyLimitOrderBrush { get; private set; }

	[Browsable(false)]
	public XBrush BuyLimitOrderTempBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[DataMember(Name = "BuyLimitOrderColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBuyLimitOrder")]
	public XColor BuyLimitOrderColor
	{
		get
		{
			return _buyLimitOrderColor;
		}
		set
		{
			int num = 3;
			int num2 = num;
			Color color = default(Color);
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (AZAnigbLLcWn0OlKT4b6(value, _buyLimitOrderColor))
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
						{
							num2 = 0;
						}
						break;
					}
					_buyLimitOrderColor = value;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					BuyLimitOrderTempBrush = new XBrush(q9AvUrbLQViuIQ0nd0qd(color));
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1736566656 ^ -1736818020));
					return;
				case 2:
					return;
				default:
					color = _buyLimitOrderColor;
					color.A /= 2;
					BuyLimitOrderBrush = new XBrush(_buyLimitOrderColor);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush SellLimitOrderBrush { get; private set; }

	[Browsable(false)]
	public XBrush SellLimitOrderTempBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeSellLimitOrder")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[DataMember(Name = "SellLimitOrderColor")]
	public XColor SellLimitOrderColor
	{
		get
		{
			return _sellLimitOrderColor;
		}
		set
		{
			int num = 3;
			int num2 = num;
			Color color = default(Color);
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (value == _sellLimitOrderColor)
					{
						num2 = 2;
						break;
					}
					_sellLimitOrderColor = value;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					color.A /= 2;
					SellLimitOrderBrush = new XBrush(_sellLimitOrderColor);
					SellLimitOrderTempBrush = new XBrush(color);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53541904));
					return;
				case 2:
					return;
				default:
					color = RP9iVtbLEOMkW1JfaXAf(_sellLimitOrderColor);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush BuyStopOrderBrush { get; private set; }

	[Browsable(false)]
	public XBrush BuyStopOrderTempBrush { get; private set; }

	[DataMember(Name = "BuyStopOrderColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBuyStopOrder")]
	public XColor BuyStopOrderColor
	{
		get
		{
			return _buyStopOrderColor;
		}
		set
		{
			if (value == _buyStopOrderColor)
			{
				return;
			}
			_buyStopOrderColor = value;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225550269));
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
					{
						num = 2;
					}
					break;
				case 2:
					return;
				case 1:
				{
					Color color = RP9iVtbLEOMkW1JfaXAf(_buyStopOrderColor);
					color.A /= 2;
					BuyStopOrderBrush = new XBrush(_buyStopOrderColor);
					BuyStopOrderTempBrush = new XBrush(color);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
					{
						num = 0;
					}
					break;
				}
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush SellStopOrderBrush { get; private set; }

	[Browsable(false)]
	public XBrush SellStopOrderTempBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeSellStopOrder")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[DataMember(Name = "SellStopOrderColor")]
	public XColor SellStopOrderColor
	{
		get
		{
			return _sellStopOrderColor;
		}
		set
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xECA3F28 ^ 0xECE65BC));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 3:
				{
					if (value == _sellStopOrderColor)
					{
						num2 = 2;
						break;
					}
					_sellStopOrderColor = value;
					Color color = _sellStopOrderColor;
					color.A /= 2;
					SellStopOrderBrush = new XBrush(_sellStopOrderColor);
					SellStopOrderTempBrush = new XBrush(color);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 != 0)
					{
						num2 = 1;
					}
					break;
				}
				case 2:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush BuyTriggerOrderBrush { get; private set; }

	[Browsable(false)]
	public XBrush BuyTriggerOrderTempBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeBuyTriggerOrder")]
	[DataMember(Name = "BuyTriggerOrderColor")]
	public XColor BuyTriggerOrderColor
	{
		get
		{
			return _buyTriggerOrderColor;
		}
		set
		{
			int num = 1;
			int num2 = num;
			Color color = default(Color);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					BuyTriggerOrderTempBrush = new XBrush(q9AvUrbLQViuIQ0nd0qd(color));
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x7F645F3C ^ 0x7F600580));
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
					{
						num2 = 3;
					}
					break;
				case 0:
					return;
				case 3:
					return;
				case 1:
					if (!(value == _buyTriggerOrderColor))
					{
						_buyTriggerOrderColor = value;
						color = RP9iVtbLEOMkW1JfaXAf(_buyTriggerOrderColor);
						color.A /= 2;
						BuyTriggerOrderBrush = new XBrush(_buyTriggerOrderColor);
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
						{
							num2 = 0;
						}
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush SellTriggerOrderBrush { get; private set; }

	[Browsable(false)]
	public XBrush SellTriggerOrderTempBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeSellTriggerOrder")]
	[DataMember(Name = "SellTriggerOrderColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	public XColor SellTriggerOrderColor
	{
		get
		{
			return _sellTriggerOrderColor;
		}
		set
		{
			int num = 2;
			int num2 = num;
			Color color = default(Color);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				default:
					SellTriggerOrderBrush = new XBrush(_sellTriggerOrderColor);
					SellTriggerOrderTempBrush = new XBrush(q9AvUrbLQViuIQ0nd0qd(color));
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-82860344 ^ -83100640));
					num2 = 3;
					break;
				case 1:
					_sellTriggerOrderColor = value;
					color = _sellTriggerOrderColor;
					color.A /= 2;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (AZAnigbLLcWn0OlKT4b6(value, _sellTriggerOrderColor))
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush LongPositionBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[DataMember(Name = "LongPositionColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeLongPosition")]
	public XColor LongPositionColor
	{
		get
		{
			return _longPositionColor;
		}
		set
		{
			if (!(value == _longPositionColor))
			{
				_longPositionColor = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				LongPositionBrush = new XBrush(_longPositionColor);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E007DE6));
			}
		}
	}

	[Browsable(false)]
	public XBrush ShortPositionBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeShortPosition")]
	[DataMember(Name = "ShortPositionColor")]
	public XColor ShortPositionColor
	{
		get
		{
			return _shortPositionColor;
		}
		set
		{
			if (value == _shortPositionColor)
			{
				return;
			}
			_shortPositionColor = value;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
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
				ShortPositionBrush = new XBrush(_shortPositionColor);
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(0x68C7EAE6 ^ 0x68C3B1DA));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush PositivePnLBrush { get; private set; }

	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[DataMember(Name = "PositivePnLColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemePositivePnL")]
	public XColor PositivePnLColor
	{
		get
		{
			return _positivePnLColor;
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
					if (AZAnigbLLcWn0OlKT4b6(value, _positivePnLColor))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
						{
							num2 = 0;
						}
						break;
					}
					_positivePnLColor = value;
					PositivePnLBrush = new XBrush(_positivePnLColor);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -6253919));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush NegativePnLBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeNegativePnL")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[DataMember(Name = "NegativePnLColor")]
	public XColor NegativePnLColor
	{
		get
		{
			return _negativePnLColor;
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
					if (value == _negativePnLColor)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
						{
							num2 = 0;
						}
						break;
					}
					_negativePnLColor = value;
					NegativePnLBrush = new XBrush(_negativePnLColor);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1435596783 ^ -1435839591));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush TakeProfitBrush { get; private set; }

	[Browsable(false)]
	public XBrush TakeProfitTempBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeTakeProfit")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	[DataMember(Name = "TakeProfitColor")]
	public XColor TakeProfitColor
	{
		get
		{
			return _takeProfitColor;
		}
		set
		{
			int num = 1;
			int num2 = num;
			Color color = default(Color);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (value == _takeProfitColor)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_takeProfitColor = value;
					color = _takeProfitColor;
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					return;
				case 2:
					color.A /= 2;
					TakeProfitBrush = new XBrush(_takeProfitColor);
					TakeProfitTempBrush = new XBrush(color);
					OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1841489831 ^ -1841740811));
					num2 = 3;
					break;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush StopLossBrush { get; private set; }

	[Browsable(false)]
	public XBrush StopLossTempBrush { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeStopLoss")]
	[DataMember(Name = "StopLossColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeTrading")]
	public XColor StopLossColor
	{
		get
		{
			return _stopLossColor;
		}
		set
		{
			int num = 2;
			Color color = default(Color);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-527080372 ^ -527351934));
						return;
					case 3:
						StopLossBrush = new XBrush(_stopLossColor);
						StopLossTempBrush = new XBrush(color);
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						return;
					case 2:
						if (!AZAnigbLLcWn0OlKT4b6(value, _stopLossColor))
						{
							_stopLossColor = value;
							color = RP9iVtbLEOMkW1JfaXAf(_stopLossColor);
							color.A /= 2;
							num = 3;
							goto end_IL_0012;
						}
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
						{
							num2 = 0;
						}
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush IndicatorBackBrush1 { get; private set; }

	[DataMember(Name = "IndicatorBackColor1")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeIndicatorBackColor1")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeIndicators")]
	public XColor IndicatorBackColor1
	{
		get
		{
			return _indicatorBackColor1;
		}
		set
		{
			value = new XColor(byte.MaxValue, RP9iVtbLEOMkW1JfaXAf(value));
			if (value == _indicatorBackColor1)
			{
				return;
			}
			_indicatorBackColor1 = value;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					IndicatorBackBrush1 = new XBrush(_indicatorBackColor1);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x42939807));
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush IndicatorBackBrush2 { get; private set; }

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeIndicatorBackColor2")]
	[DataMember(Name = "IndicatorBackColor2")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeIndicators")]
	public XColor IndicatorBackColor2
	{
		get
		{
			return _indicatorBackColor2;
		}
		set
		{
			value = new XColor(byte.MaxValue, value);
			int num;
			if (value == _indicatorBackColor2)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
				{
					num = 1;
				}
			}
			else
			{
				_indicatorBackColor2 = value;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
				{
					num = 0;
				}
			}
			switch (num)
			{
			case 1:
				return;
			}
			IndicatorBackBrush2 = new XBrush(_indicatorBackColor2);
			OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1435596783 ^ -1435839481));
		}
	}

	[Browsable(false)]
	public XBrush IndicatorAlertBackBrush { get; private set; }

	[DataMember(Name = "IndicatorAlertBackColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeIndicatorAlertBackColor")]
	[T4IXj62qBfXCaxs2RI5("ChartThemeIndicators")]
	public XColor IndicatorAlertBackColor
	{
		get
		{
			return _indicatorAlertBackColor;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					IndicatorAlertBackBrush = new XBrush(_indicatorAlertBackColor);
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-602153869 ^ -601915341));
					return;
				case 1:
					value = new XColor(byte.MaxValue, value);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (value == _indicatorAlertBackColor)
				{
					return;
				}
				_indicatorAlertBackColor = value;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[DataMember(Name = "PaletteColor1")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeColor1")]
	[T4IXj62qBfXCaxs2RI5("ChartThemePalette")]
	public XColor PaletteColor1
	{
		get
		{
			return _paletteColor1;
		}
		set
		{
			if (!(value == _paletteColor1))
			{
				_paletteColor1 = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-1583344314 ^ -1583068876));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeColor2")]
	[DataMember(Name = "PaletteColor2")]
	[T4IXj62qBfXCaxs2RI5("ChartThemePalette")]
	public XColor PaletteColor2
	{
		get
		{
			return _paletteColor2;
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
					if (AZAnigbLLcWn0OlKT4b6(value, _paletteColor2))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
						{
							num2 = 0;
						}
						break;
					}
					_paletteColor2 = value;
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2017337494 ^ -2017098758));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeColor3")]
	[DataMember(Name = "PaletteColor3")]
	[T4IXj62qBfXCaxs2RI5("ChartThemePalette")]
	public XColor PaletteColor3
	{
		get
		{
			return _paletteColor3;
		}
		set
		{
			if (!(value == _paletteColor3))
			{
				_paletteColor3 = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-448941864 ^ -449188746));
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartThemePalette")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeColor4")]
	[DataMember(Name = "PaletteColor4")]
	public XColor PaletteColor4
	{
		get
		{
			return _paletteColor4;
		}
		set
		{
			if (!(value == _paletteColor4))
			{
				_paletteColor4 = value;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1774602229 ^ -1774328633));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
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

	[DataMember(Name = "PaletteColor5")]
	[T4IXj62qBfXCaxs2RI5("ChartThemePalette")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeColor5")]
	public XColor PaletteColor5
	{
		get
		{
			return _paletteColor5;
		}
		set
		{
			if (!(value == _paletteColor5))
			{
				_paletteColor5 = value;
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(-225822163 ^ -225548601));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
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

	[DataMember(Name = "PaletteColor6")]
	[T4IXj62qBfXCaxs2RI5("ChartThemePalette")]
	[bBo0Zd2ycQQr3LNHQf4("ChartThemeColor6")]
	public XColor PaletteColor6
	{
		get
		{
			return _paletteColor6;
		}
		set
		{
			if (!AZAnigbLLcWn0OlKT4b6(value, _paletteColor6))
			{
				_paletteColor6 = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6EC99CAF ^ 0x6ECDC1A7));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartThemeColor7")]
	[T4IXj62qBfXCaxs2RI5("ChartThemePalette")]
	[DataMember(Name = "PaletteColor7")]
	public XColor PaletteColor7
	{
		get
		{
			return _paletteColor7;
		}
		set
		{
			if (!(value == _paletteColor7))
			{
				_paletteColor7 = value;
				OnPropertyChanged((string)RLEwCXbLxM74YBHmFleH(--927068468 ^ 0x3745AC12));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
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

	[Browsable(false)]
	public XBrush SelectionFillBrush { get; private set; }

	[Browsable(false)]
	[IgnoreDataMember]
	public XColor SelectionFillColor
	{
		get
		{
			return _selectionFillColor;
		}
		set
		{
			_selectionFillColor = value;
			SelectionFillBrush = new XBrush(value);
		}
	}

	public static ChartTheme DarkTheme
	{
		get
		{
			ChartTheme chartTheme = new ChartTheme();
			bwZDwAbengRS1jIGCNh7(chartTheme, RLEwCXbLxM74YBHmFleH(0x68DEE0F ^ 0x689DA43));
			mprFRgbeGSYcxby7UYCE(chartTheme, Resources.ChartThemeDark);
			return chartTheme;
		}
	}

	public static ChartTheme DarkTigerTheme
	{
		get
		{
			ChartTheme obj = new ChartTheme
			{
				ThemeID = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741FB02D)
			};
			mprFRgbeGSYcxby7UYCE(obj, Resources.ChartThemeDarkTiger);
			nDuGk2beYA6yVFZgeWw2(obj, Color.FromArgb(32, 24, 22, 34));
			obj.AreaLineColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 115, 0));
			obj.BarDownBarColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 85, 85, 85));
			obj.BarUpBarColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 115, 0);
			dOhnQGbeo1NMhWme782e(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 149, 117, 205));
			obj.BuyStopOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 149, 117, 205));
			DfWx2Gbevh3GoFvsCauF(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 149, 117, 205)));
			obj.BuyTradeColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 149, 117, 205));
			obj.BuyTriggerOrderColor = Color.FromArgb(byte.MaxValue, 149, 117, 205);
			obj.CandleDownBackColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 96, 88, 88);
			obj.CandleDownBorderColor = Color.FromArgb(byte.MaxValue, 187, 171, 171);
			obj.CandleDownWickColor = Color.FromArgb(byte.MaxValue, 165, 165, 165);
			obj.CandleUpBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0));
			obj.CandleUpBorderColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0);
			obj.CandleUpWickColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0));
			obj.ChartAxisColor = Color.FromArgb(byte.MaxValue, 136, 136, 136);
			movDIqbeBLqWP4reBcqe(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 24, 22, 34));
			obj.ChartCpFillColor = Color.FromArgb(byte.MaxValue, 251, 176, 64);
			JSZWRJbeaS5cGfjFiJHU(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 115, 0));
			obj.ChartFontColor = Color.FromArgb(byte.MaxValue, 216, 222, 233);
			obj.ChartGridColor = Color.FromArgb(byte.MaxValue, 41, 41, 42);
			DTYEWrbeiTZUCuFHeARC(obj, Color.FromArgb(32, 24, 22, 34));
			obj.ChartObjectLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 177, 108, 234));
			oLl3C3belLsArWusgsLR(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 72, 72, 72)));
			obj.CloseLongPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 177, 108, 234);
			pUMBKsbe4ZBYwQQG6j37(obj, Color.FromArgb(byte.MaxValue, 176, 176, 176));
			obj.ClusterAskColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 115, 0));
			l8UZQBbeDtXcT0y4Rx5K(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 149, 117, 205));
			bWgWl0beb2g52LjGq9Kf(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(32, 24, 22, 34)));
			AMODkJbeNpu7M1sJhs6K(obj, Color.FromArgb(32, 24, 22, 34));
			obj.ClusterCellBorderMaxColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 136, 136, 136);
			obj.ClusterDeltaMinusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 85, 85, 85));
			obj.ClusterDeltaPlusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0));
			obj.ClusterDownBarColor = Color.FromArgb(byte.MaxValue, 85, 85, 85);
			xvFxjsbekMQovg4S4X1D(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 136, 136, 136)));
			XUUB0Fbe13TmyD8MFCrx(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 176, 176, 176));
			obj.ClusterOpenIntPlusColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0);
			obj.ClusterStrongAskColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 115, 0);
			obj.ClusterStrongBidColor = Color.FromArgb(byte.MaxValue, 176, 176, 176);
			obj.ClusterTextColor = Color.FromArgb(byte.MaxValue, 216, 222, 233);
			OOQg4Ebe5mj40b8x0mQ8(obj, Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0));
			obj.ClusterUpBarColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 115, 0);
			OMEewCbeS7qScN3xRfLb(obj, pKRGyrbLdyNmK2CbFTuV(32, byte.MaxValue, 209, 102));
			obj.ClusterVolumeColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 177, 108, 234));
			obj.CursorLineColor = Color.FromArgb(32, 136, 136, 136);
			obj.CursorMarkerBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(32, 24, 22, 34));
			zKTbWSbex6B7EEuO1A9Q(obj, Color.FromArgb(byte.MaxValue, 216, 222, 233));
			obj.DomBackColor = Color.FromArgb(byte.MaxValue, 24, 22, 34);
			L2qQ9fbeLs8ywwP2WjkR(obj, Color.FromArgb(byte.MaxValue, 24, 22, 34));
			obj.DomLineColor = Color.FromArgb(byte.MaxValue, 24, 22, 34);
			NDO2C9beeCMs6Jybs9X2(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 176, 176, 176)));
			obj.DomProfitColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 177, 108, 234);
			obj.DomTextColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 216, 222, 233);
			obj.HistogramAskColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 247, 147, 26));
			obj.HistogramBidColor = Color.FromArgb(byte.MaxValue, 177, 108, 234);
			obj.HistogramCellBorderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(32, 24, 22, 34));
			obj.HistogramDeltaMinusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 176, 176, 176));
			OVWg0HbespswqoFRXdWL(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 247, 147, 26)));
			obj.HistogramMaximumColor = Color.FromArgb(byte.MaxValue, 216, 222, 233);
			obj.HistogramTextColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 216, 222, 233));
			obj.HistogramTradesColor = Color.FromArgb(byte.MaxValue, 247, 147, 26);
			obj.HistogramValueAreaColor = Color.FromArgb(32, 24, 22, 34);
			obj.HistogramVolumeColor = Color.FromArgb(byte.MaxValue, 177, 108, 234);
			obj.IndicatorAlertBackColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 247, 147, 26));
			obj.IndicatorBackColor1 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 251, 176, 64));
			obj.IndicatorBackColor2 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 24, 22, 34));
			mcc3dobeXAlLgnv6r1ex(obj, Color.FromArgb(byte.MaxValue, 247, 147, 26));
			obj.LongPositionColor = Color.FromArgb(byte.MaxValue, 177, 108, 234);
			obj.NegativePnLColor = Color.FromArgb(byte.MaxValue, 240, 128, 128);
			obj.OpenLongPositionColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(128, 177, 108, 234));
			RC7caqbecDUGo3iiqsa1(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(128, 35, 39, 46)));
			obj.PaletteColor1 = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 247, 147, 26));
			PevY0nbej1BI9G6ZH0dL(obj, Color.FromArgb(byte.MaxValue, 177, 108, 234));
			obj.PaletteColor3 = Color.FromArgb(byte.MaxValue, 191, 196, 201);
			s0s6jFbeEKFjEZY9KBCp(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 230, 230, 230)));
			ljFYT9beQVArWALZ3USF(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201));
			iqxNfRbedA8wBx1XH1WJ(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 177, 108, 234));
			obj.PaletteColor7 = Color.FromArgb(byte.MaxValue, 247, 147, 26);
			zDdfFZbegQt50JQLgio8(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 136, 136, 136)));
			z8lrZWbeRYo8ROSM0q8x(obj, Color.FromArgb(byte.MaxValue, 177, 108, 234));
			obj.QuoteBestBuyColor = Color.FromArgb(byte.MaxValue, 177, 108, 234);
			obj.QuoteBestSellColor = Color.FromArgb(byte.MaxValue, 247, 147, 26);
			obj.QuoteBuyColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(128, 177, 108, 234));
			obj.QuoteBuyVolumeColor = Color.FromArgb(128, 177, 108, 234);
			obj.QuoteLimitOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 177, 108, 234));
			vX5c1Zbe6fLVrPy3lwhU(obj, Color.FromArgb(32, 24, 22, 34));
			JIwT4AbeMI3pHnpi4aF7(obj, Color.FromArgb(128, 247, 147, 26));
			obj.QuoteSellVolumeColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(128, 247, 147, 26));
			obj.QuoteStopOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 51, 51, 51);
			obj.QuoteTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 177, 108, 234));
			obj.SellLimitOrderColor = Color.FromArgb(byte.MaxValue, 51, 51, 51);
			obj.SellStopOrderColor = Color.FromArgb(byte.MaxValue, 51, 51, 51);
			obj.SellTradeBorderColor = Color.FromArgb(byte.MaxValue, 51, 51, 51);
			ci71arbeOXHP3uiasXYC(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 51, 51, 51)));
			obj.SellTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 51, 51, 51));
			obj.ShortPositionColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 51, 51, 51));
			obj.StopLossColor = Color.FromArgb(byte.MaxValue, 51, 51, 51);
			q6A733beqM7B6XguST6u(obj, Color.FromArgb(byte.MaxValue, 177, 108, 234));
			return obj;
		}
	}

	public static ChartTheme DarkNeoTheme
	{
		get
		{
			ChartTheme obj = new ChartTheme
			{
				ThemeID = (string)RLEwCXbLxM74YBHmFleH(-1799510641 ^ -1799778257),
				ThemeName = (string)stCCu3beI0TYOFxC9RUB(),
				AreaColor = pKRGyrbLdyNmK2CbFTuV(32, 24, 24, 24),
				AreaLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 38, 166, 154)
			};
			tns3gSbeWcnybZoCqvQX(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 239, 83, 80));
			obj.BarUpBarColor = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			obj.BuyLimitOrderColor = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			obj.BuyStopOrderColor = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			DfWx2Gbevh3GoFvsCauF(obj, Color.FromArgb(byte.MaxValue, 38, 166, 154));
			obj.BuyTradeColor = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			XIXKLmbetkNW2HjFb4u8(obj, Color.FromArgb(byte.MaxValue, 38, 166, 154));
			obj.CandleDownBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 239, 83, 80));
			obj.CandleDownBorderColor = Color.FromArgb(byte.MaxValue, 239, 83, 80);
			obj.CandleDownWickColor = Color.FromArgb(byte.MaxValue, 239, 83, 80);
			wJGORRbeUG9kywserkKE(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 38, 166, 154)));
			obj.CandleUpBorderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 38, 166, 154);
			obj.CandleUpWickColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 38, 166, 154));
			JX8E20beT5K54i0JhdUH(obj, Color.FromArgb(byte.MaxValue, 136, 136, 136));
			obj.ChartBackColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 24, 24, 24);
			diBt5DbeykHN17pg1X4D(obj, Color.FromArgb(byte.MaxValue, 38, 166, 154));
			obj.ChartCpLineColor = Color.FromArgb(byte.MaxValue, 136, 136, 136);
			obj.ChartFontColor = Color.FromArgb(byte.MaxValue, 216, 222, 233);
			obj.ChartGridColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(82, 55, 53, 53));
			obj.ChartObjectFillColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(32, 24, 24, 24));
			obj.ChartObjectLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 38, 166, 154);
			oLl3C3belLsArWusgsLR(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(32, 24, 24, 24)));
			cJA9q3beZlTXOiBWyRTo(obj, Color.FromArgb(byte.MaxValue, 38, 166, 154));
			pUMBKsbe4ZBYwQQG6j37(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 239, 83, 80)));
			obj.ClusterAskColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 239, 83, 80));
			obj.ClusterBidColor = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			bWgWl0beb2g52LjGq9Kf(obj, pKRGyrbLdyNmK2CbFTuV(32, 24, 24, 24));
			AMODkJbeNpu7M1sJhs6K(obj, pKRGyrbLdyNmK2CbFTuV(32, 24, 24, 24));
			cmxvJcbeVZAYbS3tWLx8(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 136, 136, 136)));
			o8irAibeCInM8TZMdHWY(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 239, 83, 80)));
			obj.ClusterDeltaPlusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 38, 166, 154));
			obj.ClusterDownBarColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 239, 83, 80);
			xvFxjsbekMQovg4S4X1D(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 136, 136, 136)));
			obj.ClusterOpenIntMinusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 239, 83, 80);
			obj.ClusterOpenIntPlusColor = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			obj.ClusterStrongAskColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 239, 83, 80));
			obj.ClusterStrongBidColor = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			obj.ClusterTextColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 216, 222, 233));
			obj.ClusterTradesColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 38, 166, 154));
			obj.ClusterUpBarColor = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			obj.ClusterValueAreaColor = pKRGyrbLdyNmK2CbFTuV(32, byte.MaxValue, 209, 102);
			obj.ClusterVolumeColor = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			dvuoqFberKGfBLA9PoXH(obj, pKRGyrbLdyNmK2CbFTuV(252, 63, 63, 63));
			obj.CursorMarkerBackColor = Color.FromArgb(252, 39, 39, 39);
			obj.CursorMarkerTextColor = pKRGyrbLdyNmK2CbFTuV(252, 199, 199, 199);
			Amm5Z9beK58LRPOI5OoY(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 24, 24, 24));
			L2qQ9fbeLs8ywwP2WjkR(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(32, 24, 24, 24)));
			BoQAKpbem2vci3FguR9o(obj, pKRGyrbLdyNmK2CbFTuV(32, 24, 24, 24));
			NDO2C9beeCMs6Jybs9X2(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 239, 83, 80));
			obj.DomProfitColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 38, 166, 154));
			obj.DomTextColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 216, 222, 233));
			obj.HistogramAskColor = Color.FromArgb(byte.MaxValue, 239, 83, 80);
			obj.HistogramBidColor = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			jTtKJabehwMsxcbMQ7Od(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(32, 24, 24, 24)));
			obj.HistogramDeltaMinusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 239, 83, 80));
			obj.HistogramDeltaPlusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 38, 166, 154);
			gN5aQUbew7FiIPGpOsx9(obj, Color.FromArgb(byte.MaxValue, 216, 222, 233));
			n90dVYbe7TLOPlVhDDLK(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 216, 222, 233)));
			obj.HistogramTradesColor = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			oKSUxYbe8PHs1X1Vg0Om(obj, Color.FromArgb(32, 24, 24, 24));
			obj.HistogramVolumeColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 38, 166, 154));
			obj.IndicatorAlertBackColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 239, 83, 80));
			obj.IndicatorBackColor1 = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			BSxkagbeAFMeacbxEht0(obj, Color.FromArgb(byte.MaxValue, 24, 24, 24));
			mcc3dobeXAlLgnv6r1ex(obj, Color.FromArgb(byte.MaxValue, 38, 166, 154));
			obj.LongPositionColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 38, 166, 154));
			obj.NegativePnLColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 239, 83, 80));
			obj.OpenLongPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 38, 166, 154);
			obj.OpenShortPositionColor = Color.FromArgb(byte.MaxValue, 239, 83, 80);
			obj.PaletteColor1 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 38, 166, 154));
			obj.PaletteColor2 = Color.FromArgb(byte.MaxValue, 65, 105, 225);
			CtpBpSbePMag6frum2ym(obj, Color.FromArgb(byte.MaxValue, 239, 83, 80));
			s0s6jFbeEKFjEZY9KBCp(obj, Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue));
			obj.PaletteColor5 = Color.FromArgb(byte.MaxValue, 244, 164, 96);
			obj.PaletteColor6 = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			obj.PaletteColor7 = Color.FromArgb(byte.MaxValue, 239, 83, 80);
			obj.PositionLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 136, 136, 136));
			z8lrZWbeRYo8ROSM0q8x(obj, Color.FromArgb(byte.MaxValue, 38, 166, 154));
			obj.QuoteBestBuyColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 38, 166, 154);
			obj.QuoteBestSellColor = Color.FromArgb(byte.MaxValue, 239, 83, 80);
			obj.QuoteBuyColor = Color.FromArgb(128, 38, 166, 154);
			obj.QuoteBuyVolumeColor = pKRGyrbLdyNmK2CbFTuV(128, 38, 166, 154);
			obj.QuoteLimitOrderColor = Color.FromArgb(byte.MaxValue, 38, 166, 154);
			vX5c1Zbe6fLVrPy3lwhU(obj, pKRGyrbLdyNmK2CbFTuV(32, 24, 24, 24));
			JIwT4AbeMI3pHnpi4aF7(obj, pKRGyrbLdyNmK2CbFTuV(128, 239, 83, 80));
			obj.QuoteSellVolumeColor = pKRGyrbLdyNmK2CbFTuV(128, 239, 83, 80);
			obj.QuoteStopOrderColor = Color.FromArgb(byte.MaxValue, 239, 83, 80);
			eDZ5aWbeJtRMWuFX2OCL(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 38, 166, 154));
			mVuPFYbeFfT35wkAsJIQ(obj, Color.FromArgb(byte.MaxValue, 239, 83, 80));
			obj.SellStopOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 239, 83, 80));
			gMMjQxbe3abXQEhnAQ5n(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 239, 83, 80));
			obj.SellTradeColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 239, 83, 80));
			HH3FPxbepYU0RyVIiXHE(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 239, 83, 80)));
			obj.ShortPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 239, 83, 80);
			obj.StopLossColor = Color.FromArgb(byte.MaxValue, 239, 83, 80);
			q6A733beqM7B6XguST6u(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 38, 166, 154));
			return obj;
		}
	}

	public static ChartTheme DarkPurpleGrayTheme
	{
		get
		{
			ChartTheme chartTheme = new ChartTheme();
			bwZDwAbengRS1jIGCNh7(chartTheme, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1309555870 ^ -1309280546));
			mprFRgbeGSYcxby7UYCE(chartTheme, Resources.ChartThemeDarkPurpleGray);
			nDuGk2beYA6yVFZgeWw2(chartTheme, Color.FromArgb(32, 24, 24, 24));
			chartTheme.AreaLineColor = Color.FromArgb(byte.MaxValue, 142, 36, 170);
			tns3gSbeWcnybZoCqvQX(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 189, 189, 189)));
			chartTheme.BarUpBarColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 36, 170));
			chartTheme.BuyLimitOrderColor = Color.FromArgb(byte.MaxValue, 142, 36, 170);
			j7RL5sbeujpDYe3RR2Mb(chartTheme, Color.FromArgb(byte.MaxValue, 142, 36, 170));
			chartTheme.BuyTradeBorderColor = Color.FromArgb(139, 0, byte.MaxValue, byte.MaxValue);
			YEQ6GpbezEuU0s8HhYP0(chartTheme, pKRGyrbLdyNmK2CbFTuV(178, 0, byte.MaxValue, byte.MaxValue));
			chartTheme.BuyTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 36, 170));
			JRvaxWbs0Isbym17F8Q2(chartTheme, Color.FromArgb(byte.MaxValue, 189, 189, 189));
			pQ4BLybs2qq4jgRKJW8H(chartTheme, Color.FromArgb(byte.MaxValue, 189, 189, 189));
			chartTheme.CandleDownWickColor = Color.FromArgb(byte.MaxValue, 189, 189, 189);
			chartTheme.CandleUpBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 142, 36, 170));
			chartTheme.CandleUpBorderColor = Color.FromArgb(byte.MaxValue, 142, 36, 170);
			chartTheme.CandleUpWickColor = Color.FromArgb(byte.MaxValue, 142, 36, 170);
			chartTheme.ChartAxisColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 136, 136, 136));
			chartTheme.ChartBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 24, 24, 24));
			diBt5DbeykHN17pg1X4D(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 142, 36, 170)));
			chartTheme.ChartCpLineColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 136, 136, 136));
			chartTheme.ChartFontColor = Color.FromArgb(byte.MaxValue, 216, 222, 233);
			chartTheme.ChartGridColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 24, 24, 24);
			DTYEWrbeiTZUCuFHeARC(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(32, 24, 24, 24)));
			chartTheme.ChartObjectLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 36, 170);
			oLl3C3belLsArWusgsLR(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 24, 24, 24)));
			chartTheme.CloseLongPositionColor = Color.FromArgb(byte.MaxValue, 0, 100, 0);
			pUMBKsbe4ZBYwQQG6j37(chartTheme, Color.FromArgb(byte.MaxValue, 70, 68, 68));
			ANg3DKbsHOtbFhc01cLZ(chartTheme, Color.FromArgb(byte.MaxValue, 189, 189, 189));
			chartTheme.ClusterBidColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 142, 36, 170));
			chartTheme.ClusterBorderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(32, 24, 24, 24));
			AMODkJbeNpu7M1sJhs6K(chartTheme, Color.FromArgb(32, 24, 24, 24));
			chartTheme.ClusterCellBorderMaxColor = Color.FromArgb(byte.MaxValue, 136, 136, 136);
			chartTheme.ClusterDeltaMinusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 189, 189, 189);
			chartTheme.ClusterDeltaPlusColor = Color.FromArgb(byte.MaxValue, 142, 36, 170);
			chartTheme.ClusterDownBarColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 189, 189, 189));
			xvFxjsbekMQovg4S4X1D(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 136, 136, 136)));
			chartTheme.ClusterOpenIntMinusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 189, 189, 189));
			chartTheme.ClusterOpenIntPlusColor = Color.FromArgb(byte.MaxValue, 142, 36, 170);
			chartTheme.ClusterStrongAskColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 189, 189, 189);
			chartTheme.ClusterStrongBidColor = Color.FromArgb(byte.MaxValue, 142, 36, 170);
			fUmVP9bsfk7WGIiPLOyV(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 216, 222, 233));
			chartTheme.ClusterTradesColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 36, 170);
			chartTheme.ClusterUpBarColor = Color.FromArgb(byte.MaxValue, 142, 36, 170);
			chartTheme.ClusterValueAreaColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(32, byte.MaxValue, 209, 102));
			chartTheme.ClusterVolumeColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 36, 170));
			chartTheme.CursorLineColor = Color.FromArgb(94, 197, 197, 197);
			chartTheme.CursorMarkerBackColor = pKRGyrbLdyNmK2CbFTuV(162, 148, 0, 211);
			chartTheme.CursorMarkerTextColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 216, 222, 233));
			Amm5Z9beK58LRPOI5OoY(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 24, 24, 24));
			chartTheme.DomGridColor = Color.FromArgb(byte.MaxValue, 24, 24, 24);
			BoQAKpbem2vci3FguR9o(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 24, 24, 24)));
			chartTheme.DomLossColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 189, 189, 189));
			Yhb5qKbs9HWA3xoQ1Hjs(chartTheme, Color.FromArgb(byte.MaxValue, 142, 36, 170));
			chartTheme.DomTextColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 216, 222, 233));
			chartTheme.HistogramAskColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 189, 189, 189));
			kdGN5DbsnYgcagWhgTv8(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 36, 170));
			chartTheme.HistogramCellBorderColor = pKRGyrbLdyNmK2CbFTuV(32, 24, 24, 24);
			chartTheme.HistogramDeltaMinusColor = Color.FromArgb(byte.MaxValue, 189, 189, 189);
			chartTheme.HistogramDeltaPlusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 36, 170);
			gN5aQUbew7FiIPGpOsx9(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 216, 222, 233)));
			chartTheme.HistogramTextColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 216, 222, 233);
			z1UBSQbsGXKNFmCFiTj3(chartTheme, Color.FromArgb(byte.MaxValue, 142, 36, 170));
			oKSUxYbe8PHs1X1Vg0Om(chartTheme, Color.FromArgb(32, 24, 24, 24));
			chartTheme.HistogramVolumeColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 36, 170);
			chartTheme.IndicatorAlertBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 189, 189, 189));
			mRjr8cbsYIrL5TP1UAmw(chartTheme, Color.FromArgb(byte.MaxValue, 142, 36, 170));
			chartTheme.IndicatorBackColor2 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 24, 24, 24));
			mcc3dobeXAlLgnv6r1ex(chartTheme, Color.FromArgb(byte.MaxValue, 142, 36, 170));
			chartTheme.LongPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 36, 170);
			chartTheme.NegativePnLColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 163, 47, 47);
			chartTheme.OpenLongPositionColor = Color.FromArgb(byte.MaxValue, 0, 100, 0);
			RC7caqbecDUGo3iiqsa1(chartTheme, Color.FromArgb(byte.MaxValue, 178, 34, 34));
			jMr1wVbsopCUn42VWOJM(chartTheme, Color.FromArgb(byte.MaxValue, 218, 112, 214));
			PevY0nbej1BI9G6ZH0dL(chartTheme, Color.FromArgb(byte.MaxValue, 0, 128, 128));
			CtpBpSbePMag6frum2ym(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 165, 0)));
			s0s6jFbeEKFjEZY9KBCp(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 64, 224, 208)));
			chartTheme.PaletteColor5 = Color.FromArgb(byte.MaxValue, 142, 36, 170);
			chartTheme.PaletteColor6 = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 36, 170));
			chartTheme.PaletteColor7 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 50, 205, 50);
			chartTheme.PositionLineColor = Color.FromArgb(byte.MaxValue, 136, 136, 136);
			z8lrZWbeRYo8ROSM0q8x(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 100, 0));
			chartTheme.QuoteBestBuyColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 36, 170);
			chartTheme.QuoteBestSellColor = Color.FromArgb(byte.MaxValue, 94, 94, 94);
			chartTheme.QuoteBuyColor = Color.FromArgb(128, 142, 36, 170);
			chartTheme.QuoteBuyVolumeColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(128, 142, 36, 170));
			chartTheme.QuoteLimitOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 142, 36, 170));
			chartTheme.QuoteSelectedColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(32, 24, 24, 24));
			chartTheme.QuoteSellColor = Color.FromArgb(128, 189, 189, 189);
			chartTheme.QuoteSellVolumeColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(128, 39, 39, 39));
			F0e8gKbsvn9oiwwG8YVW(chartTheme, Color.FromArgb(byte.MaxValue, 61, 61, 61));
			eDZ5aWbeJtRMWuFX2OCL(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 36, 170)));
			mVuPFYbeFfT35wkAsJIQ(chartTheme, Color.FromArgb(byte.MaxValue, 70, 68, 68));
			chartTheme.SellStopOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 70, 68, 68));
			chartTheme.SellTradeBorderColor = Color.FromArgb(130, byte.MaxValue, 69, 0);
			ci71arbeOXHP3uiasXYC(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 69, 0));
			HH3FPxbepYU0RyVIiXHE(chartTheme, Color.FromArgb(byte.MaxValue, 70, 68, 68));
			GFqREJbsBhTliLWLx9ul(chartTheme, Color.FromArgb(byte.MaxValue, 70, 68, 67));
			HEfcGJbsa5uS2nBmhvjw(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 189, 189, 189)));
			q6A733beqM7B6XguST6u(chartTheme, Color.FromArgb(byte.MaxValue, 142, 36, 170));
			return chartTheme;
		}
	}

	public static ChartTheme DarkDimmedTheme
	{
		get
		{
			ChartTheme obj = new ChartTheme
			{
				ThemeID = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461949456 ^ -1462215026),
				ThemeName = Resources.ChartThemeDarkDimmed,
				AreaColor = Color.FromArgb(32, 26, 28, 30)
			};
			uWHaA5bsi7sKiHNjNga2(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122)));
			obj.BarDownBarColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 199, 92, 92));
			obj.BarUpBarColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122));
			obj.BuyLimitOrderColor = Color.FromArgb(byte.MaxValue, 63, 164, 122);
			obj.BuyStopOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			obj.BuyTradeBorderColor = Color.FromArgb(byte.MaxValue, 63, 164, 122);
			obj.BuyTradeColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			obj.BuyTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 63, 164, 122));
			obj.CandleDownBackColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 89, 28, 36);
			obj.CandleDownBorderColor = pKRGyrbLdyNmK2CbFTuV(154, 199, 92, 92);
			obj.CandleDownWickColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(155, 204, 59, 59));
			obj.CandleUpBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(68, 13, 126, 73));
			T9uBw1bslOksZ3mTVsY2(obj, Color.FromArgb(153, 20, 197, 123));
			obj.CandleUpWickColor = Color.FromArgb(158, 40, 122, 88);
			obj.ChartAxisColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 83, 83, 83);
			movDIqbeBLqWP4reBcqe(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 23, 25, 26)));
			obj.ChartCpFillColor = Color.FromArgb(byte.MaxValue, 63, 164, 122);
			obj.ChartCpLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 68, 71, 74));
			F3X2Wobs4O8PmmF2mYPY(obj, Color.FromArgb(174, byte.MaxValue, byte.MaxValue, byte.MaxValue));
			obj.ChartGridColor = Color.FromArgb(55, 80, 80, 80);
			obj.ChartObjectFillColor = Color.FromArgb(32, 26, 28, 30);
			obj.ChartObjectLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			obj.ChartSessionLineColor = Color.FromArgb(28, 89, 89, 89);
			obj.CloseLongPositionColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 63, 164, 122));
			obj.CloseShortPositionColor = Color.FromArgb(byte.MaxValue, 199, 92, 92);
			obj.ClusterAskColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 199, 92, 92));
			obj.ClusterBidColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			bWgWl0beb2g52LjGq9Kf(obj, pKRGyrbLdyNmK2CbFTuV(32, 26, 28, 30));
			obj.ClusterCellBorderColor = pKRGyrbLdyNmK2CbFTuV(32, 26, 28, 30);
			cmxvJcbeVZAYbS3tWLx8(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 68, 71, 74));
			obj.ClusterDeltaMinusColor = Color.FromArgb(byte.MaxValue, 199, 92, 92);
			cDZmIxbsDtvI8Zo0rfh0(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 63, 164, 122)));
			TgDbZ7bsb6NJxi5g8vL7(obj, Color.FromArgb(byte.MaxValue, 199, 92, 92));
			obj.ClusterNeutralBidAskColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 68, 71, 74));
			obj.ClusterOpenIntMinusColor = Color.FromArgb(byte.MaxValue, 199, 92, 92);
			obj.ClusterOpenIntPlusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			MJjw94bsNK5xANJYxMhC(obj, Color.FromArgb(byte.MaxValue, 199, 92, 92));
			obj.ClusterStrongBidColor = Color.FromArgb(byte.MaxValue, 63, 164, 122);
			fUmVP9bsfk7WGIiPLOyV(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201));
			obj.ClusterTradesColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			uKknHlbskRkATkxUQH37(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122)));
			OMEewCbeS7qScN3xRfLb(obj, Color.FromArgb(175, 201, 201, 201));
			ASDK0Zbs17BOmhObH4eI(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122));
			obj.CursorLineColor = pKRGyrbLdyNmK2CbFTuV(82, 164, 166, 167);
			obj.CursorMarkerBackColor = Color.FromArgb(156, 26, 28, 30);
			obj.CursorMarkerTextColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(230, 211, 217, 223));
			Amm5Z9beK58LRPOI5OoY(obj, Color.FromArgb(byte.MaxValue, 24, 26, 27));
			L2qQ9fbeLs8ywwP2WjkR(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(32, 26, 28, 30)));
			BoQAKpbem2vci3FguR9o(obj, Color.FromArgb(32, 26, 28, 30));
			obj.DomLossColor = Color.FromArgb(byte.MaxValue, 199, 92, 92);
			obj.DomProfitColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122));
			obj.DomTextColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 196, 201));
			obj.HistogramAskColor = Color.FromArgb(byte.MaxValue, 199, 92, 92);
			kdGN5DbsnYgcagWhgTv8(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 63, 164, 122)));
			obj.HistogramCellBorderColor = pKRGyrbLdyNmK2CbFTuV(32, 26, 28, 30);
			obj.HistogramDeltaMinusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 199, 92, 92);
			OVWg0HbespswqoFRXdWL(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 63, 164, 122)));
			obj.HistogramMaximumColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201));
			obj.HistogramTextColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 196, 201));
			obj.HistogramTradesColor = Color.FromArgb(byte.MaxValue, 63, 164, 122);
			obj.HistogramValueAreaColor = pKRGyrbLdyNmK2CbFTuV(32, 26, 28, 30);
			l1ZVTNbs53j1AZcsI8eK(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 63, 164, 122)));
			obj.IndicatorAlertBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 199, 92, 92));
			obj.IndicatorBackColor1 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			BSxkagbeAFMeacbxEht0(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 117, 176)));
			mcc3dobeXAlLgnv6r1ex(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122)));
			obj.LongPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			obj.NegativePnLColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 199, 92, 92));
			obj.OpenLongPositionColor = Color.FromArgb(byte.MaxValue, 63, 164, 122);
			obj.OpenShortPositionColor = Color.FromArgb(byte.MaxValue, 199, 92, 92);
			jMr1wVbsopCUn42VWOJM(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122));
			obj.PaletteColor2 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 20, 147);
			obj.PaletteColor3 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 199, 92, 92));
			obj.PaletteColor4 = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 106, 90, 205));
			obj.PaletteColor5 = Color.FromArgb(byte.MaxValue, 63, 164, 122);
			iqxNfRbedA8wBx1XH1WJ(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 16, 96, 49)));
			obj.PaletteColor7 = Color.FromArgb(byte.MaxValue, 244, 164, 96);
			obj.PositionLineColor = Color.FromArgb(byte.MaxValue, 68, 71, 74);
			obj.PositivePnLColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 63, 164, 122));
			yhwItFbsS87sG5V3S9uc(obj, Color.FromArgb(byte.MaxValue, 63, 164, 122));
			dGOsOmbsxLlqBFNGBBOX(obj, Color.FromArgb(byte.MaxValue, 199, 92, 92));
			jlO8StbsLE8TJUWfquZx(obj, Color.FromArgb(128, 63, 164, 122));
			obj.QuoteBuyVolumeColor = Color.FromArgb(128, 63, 164, 122);
			obj.QuoteLimitOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			vX5c1Zbe6fLVrPy3lwhU(obj, Color.FromArgb(32, 26, 28, 30));
			obj.QuoteSellColor = Color.FromArgb(128, 199, 92, 92);
			obj.QuoteSellVolumeColor = pKRGyrbLdyNmK2CbFTuV(128, 199, 92, 92);
			F0e8gKbsvn9oiwwG8YVW(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 199, 92, 92));
			eDZ5aWbeJtRMWuFX2OCL(obj, Color.FromArgb(byte.MaxValue, 63, 164, 122));
			obj.SellLimitOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 199, 92, 92);
			SQxrYmbsekoq9EpPCu8p(obj, Color.FromArgb(byte.MaxValue, 199, 92, 92));
			gMMjQxbe3abXQEhnAQ5n(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 199, 92, 92)));
			obj.SellTradeColor = Color.FromArgb(byte.MaxValue, 199, 92, 92);
			HH3FPxbepYU0RyVIiXHE(obj, Color.FromArgb(byte.MaxValue, 199, 92, 92));
			obj.ShortPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 199, 92, 92);
			obj.StopLossColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 199, 92, 92);
			obj.TakeProfitColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 63, 164, 122));
			return obj;
		}
	}

	public static ChartTheme DarkBlueAmberTheme
	{
		get
		{
			ChartTheme obj = new ChartTheme
			{
				ThemeID = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-671204305 ^ -671479431)
			};
			mprFRgbeGSYcxby7UYCE(obj, Resources.ChartThemeDarkBlueAmber);
			obj.AreaColor = Color.FromArgb(32, 24, 24, 24);
			obj.AreaLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 33, 150, 243));
			tns3gSbeWcnybZoCqvQX(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0)));
			obj.BarUpBarColor = Color.FromArgb(byte.MaxValue, 33, 150, 243);
			dOhnQGbeo1NMhWme782e(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 33, 150, 243));
			j7RL5sbeujpDYe3RR2Mb(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 33, 150, 243));
			obj.BuyTradeBorderColor = Color.FromArgb(0, 33, 150, 243);
			YEQ6GpbezEuU0s8HhYP0(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0));
			XIXKLmbetkNW2HjFb4u8(obj, Color.FromArgb(byte.MaxValue, 33, 150, 243));
			JRvaxWbs0Isbym17F8Q2(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 179, 0));
			obj.CandleDownBorderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0));
			obj.CandleDownWickColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0);
			obj.CandleUpBackColor = Color.FromArgb(byte.MaxValue, 33, 150, 243);
			obj.CandleUpBorderColor = Color.FromArgb(byte.MaxValue, 33, 150, 243);
			obj.CandleUpWickColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 33, 150, 243);
			obj.ChartAxisColor = Color.FromArgb(byte.MaxValue, 136, 136, 136);
			obj.ChartBackColor = Color.FromArgb(byte.MaxValue, 24, 24, 24);
			obj.ChartCpFillColor = Color.FromArgb(byte.MaxValue, 33, 150, 243);
			obj.ChartCpLineColor = Color.FromArgb(byte.MaxValue, 136, 136, 136);
			obj.ChartFontColor = Color.FromArgb(byte.MaxValue, 216, 222, 233);
			obj.ChartGridColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(24, byte.MaxValue, 215, 0));
			obj.ChartObjectFillColor = Color.FromArgb(32, 24, 24, 24);
			obj.ChartObjectLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 33, 150, 243));
			obj.ChartSessionLineColor = Color.FromArgb(32, 24, 24, 24);
			cJA9q3beZlTXOiBWyRTo(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 33, 150, 243));
			pUMBKsbe4ZBYwQQG6j37(obj, Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0));
			obj.ClusterAskColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 179, 0);
			obj.ClusterBidColor = Color.FromArgb(byte.MaxValue, 33, 150, 243);
			obj.ClusterBorderColor = Color.FromArgb(32, 24, 24, 24);
			AMODkJbeNpu7M1sJhs6K(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(32, 24, 24, 24)));
			obj.ClusterCellBorderMaxColor = Color.FromArgb(byte.MaxValue, 136, 136, 136);
			o8irAibeCInM8TZMdHWY(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 179, 0));
			obj.ClusterDeltaPlusColor = Color.FromArgb(byte.MaxValue, 33, 150, 243);
			TgDbZ7bsb6NJxi5g8vL7(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 179, 0)));
			xvFxjsbekMQovg4S4X1D(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 136, 136, 136));
			obj.ClusterOpenIntMinusColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0);
			obj.ClusterOpenIntPlusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 33, 150, 243));
			MJjw94bsNK5xANJYxMhC(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0)));
			obj.ClusterStrongBidColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 33, 150, 243);
			obj.ClusterTextColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 216, 222, 233);
			OOQg4Ebe5mj40b8x0mQ8(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 33, 150, 243)));
			obj.ClusterUpBarColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 33, 150, 243));
			obj.ClusterValueAreaColor = Color.FromArgb(32, byte.MaxValue, 209, 102);
			obj.ClusterVolumeColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 33, 150, 243));
			dvuoqFberKGfBLA9PoXH(obj, Color.FromArgb(94, byte.MaxValue, 165, 0));
			CVpPt7bss2mCqw60X9Hs(obj, pKRGyrbLdyNmK2CbFTuV(208, byte.MaxValue, 215, 0));
			obj.CursorMarkerTextColor = Color.FromArgb(byte.MaxValue, 42, 42, 42);
			obj.DomBackColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 24, 24, 24);
			L2qQ9fbeLs8ywwP2WjkR(obj, Color.FromArgb(32, 24, 24, 24));
			obj.DomLineColor = Color.FromArgb(32, 24, 24, 24);
			NDO2C9beeCMs6Jybs9X2(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0)));
			obj.DomProfitColor = Color.FromArgb(byte.MaxValue, 33, 150, 243);
			gILH1ybsXrtZo4w3pP4h(obj, Color.FromArgb(byte.MaxValue, 216, 222, 233));
			obj.HistogramAskColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0);
			kdGN5DbsnYgcagWhgTv8(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 33, 150, 243)));
			jTtKJabehwMsxcbMQ7Od(obj, pKRGyrbLdyNmK2CbFTuV(32, 24, 24, 24));
			obj.HistogramDeltaMinusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 179, 0);
			obj.HistogramDeltaPlusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 33, 150, 243));
			gN5aQUbew7FiIPGpOsx9(obj, Color.FromArgb(byte.MaxValue, 216, 222, 233));
			n90dVYbe7TLOPlVhDDLK(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 216, 222, 233)));
			obj.HistogramTradesColor = Color.FromArgb(byte.MaxValue, 33, 150, 243);
			obj.HistogramValueAreaColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(32, 24, 24, 24));
			l1ZVTNbs53j1AZcsI8eK(obj, Color.FromArgb(byte.MaxValue, 33, 150, 243));
			oINd8Dbsc9Uvwphbxct2(obj, Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0));
			obj.IndicatorBackColor1 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 33, 150, 243));
			obj.IndicatorBackColor2 = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 24, 24, 24));
			mcc3dobeXAlLgnv6r1ex(obj, Color.FromArgb(byte.MaxValue, 33, 150, 243));
			obj.LongPositionColor = Color.FromArgb(byte.MaxValue, 33, 150, 243);
			xYHTstbsjE0HY1iZwAS1(obj, Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0));
			obj.OpenLongPositionColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 33, 150, 243));
			obj.OpenShortPositionColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0));
			obj.PaletteColor1 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 33, 150, 243);
			PevY0nbej1BI9G6ZH0dL(obj, Color.FromArgb(byte.MaxValue, 218, 112, 214));
			obj.PaletteColor3 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 179, 0);
			obj.PaletteColor4 = Color.FromArgb(byte.MaxValue, byte.MaxValue, 69, 0);
			obj.PaletteColor5 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 33, 150, 243);
			iqxNfRbedA8wBx1XH1WJ(obj, Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue));
			obj.PaletteColor7 = Color.FromArgb(byte.MaxValue, byte.MaxValue, 165, 0);
			zDdfFZbegQt50JQLgio8(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 136, 136, 136)));
			obj.PositivePnLColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 33, 150, 243));
			obj.QuoteBestBuyColor = Color.FromArgb(byte.MaxValue, 33, 150, 243);
			obj.QuoteBestSellColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 179, 0);
			obj.QuoteBuyColor = Color.FromArgb(128, 33, 150, 243);
			obj.QuoteBuyVolumeColor = pKRGyrbLdyNmK2CbFTuV(128, 33, 150, 243);
			obj.QuoteLimitOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 33, 150, 243);
			obj.QuoteSelectedColor = Color.FromArgb(32, 24, 24, 24);
			JIwT4AbeMI3pHnpi4aF7(obj, pKRGyrbLdyNmK2CbFTuV(128, byte.MaxValue, 179, 0));
			obj.QuoteSellVolumeColor = Color.FromArgb(128, byte.MaxValue, 179, 0);
			F0e8gKbsvn9oiwwG8YVW(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 179, 0));
			eDZ5aWbeJtRMWuFX2OCL(obj, Color.FromArgb(byte.MaxValue, 33, 150, 243));
			obj.SellLimitOrderColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0);
			obj.SellStopOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0));
			obj.SellTradeBorderColor = Color.FromArgb(0, byte.MaxValue, 69, 0);
			obj.SellTradeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 69, 0);
			obj.SellTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0));
			obj.ShortPositionColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 179, 0));
			HEfcGJbsa5uS2nBmhvjw(obj, Color.FromArgb(byte.MaxValue, byte.MaxValue, 179, 0));
			q6A733beqM7B6XguST6u(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 33, 150, 243)));
			return obj;
		}
	}

	public static ChartTheme LightTigerTheme
	{
		get
		{
			ChartTheme chartTheme = new ChartTheme();
			bwZDwAbengRS1jIGCNh7(chartTheme, RLEwCXbLxM74YBHmFleH(0x24085900 ^ 0x240C6C34));
			mprFRgbeGSYcxby7UYCE(chartTheme, Resources.ChartThemeLightTiger);
			chartTheme.AreaColor = Color.FromArgb(26, 247, 147, 26);
			chartTheme.AreaLineColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0);
			chartTheme.BarDownBarColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 119, 119, 119);
			k9e04UbsE5LqiI39nqWt(chartTheme, Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0));
			chartTheme.BuyLimitOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 149, 117, 205);
			chartTheme.BuyStopOrderColor = Color.FromArgb(byte.MaxValue, 149, 117, 205);
			chartTheme.BuyTradeBorderColor = Color.FromArgb(byte.MaxValue, 149, 117, 205);
			YEQ6GpbezEuU0s8HhYP0(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 149, 117, 205)));
			chartTheme.BuyTriggerOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 149, 117, 205);
			chartTheme.CandleDownBackColor = Color.FromArgb(byte.MaxValue, 119, 119, 119);
			chartTheme.CandleDownBorderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 119, 119, 119);
			XZpx9qbsQiDU2munWwpg(chartTheme, Color.FromArgb(byte.MaxValue, 119, 119, 119));
			chartTheme.CandleUpBackColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 115, 0);
			T9uBw1bslOksZ3mTVsY2(chartTheme, Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0));
			chartTheme.CandleUpWickColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0);
			chartTheme.ChartAxisColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 230, 230, 230);
			chartTheme.ChartBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
			diBt5DbeykHN17pg1X4D(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 251, 176, 64)));
			chartTheme.ChartCpLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 115, 0);
			F3X2Wobs4O8PmmF2mYPY(chartTheme, Color.FromArgb(byte.MaxValue, 35, 39, 46));
			chartTheme.ChartGridColor = pKRGyrbLdyNmK2CbFTuV(39, 87, 87, 87);
			chartTheme.ChartObjectFillColor = Color.FromArgb(26, 149, 117, 205);
			chartTheme.ChartObjectLineColor = Color.FromArgb(byte.MaxValue, 149, 117, 205);
			chartTheme.ChartSessionLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201);
			chartTheme.CloseLongPositionColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 230, 230, 230));
			chartTheme.CloseShortPositionColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 230, 230, 230));
			chartTheme.ClusterAskColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 115, 0));
			chartTheme.ClusterBidColor = Color.FromArgb(byte.MaxValue, 149, 117, 205);
			bWgWl0beb2g52LjGq9Kf(chartTheme, Color.FromArgb(byte.MaxValue, 230, 230, 230));
			AMODkJbeNpu7M1sJhs6K(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 196, 201)));
			cmxvJcbeVZAYbS3tWLx8(chartTheme, Color.FromArgb(byte.MaxValue, 0, 0, 0));
			o8irAibeCInM8TZMdHWY(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 119, 119, 119));
			cDZmIxbsDtvI8Zo0rfh0(chartTheme, Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0));
			chartTheme.ClusterDownBarColor = Color.FromArgb(byte.MaxValue, 119, 119, 119);
			chartTheme.ClusterNeutralBidAskColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 230, 230, 230);
			chartTheme.ClusterOpenIntMinusColor = Color.FromArgb(byte.MaxValue, 119, 119, 119);
			GAcS6Vbsddx0P1HylaXk(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 115, 0));
			MJjw94bsNK5xANJYxMhC(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0)));
			chartTheme.ClusterStrongBidColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 119, 119, 119));
			chartTheme.ClusterTextColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 35, 39, 46));
			OOQg4Ebe5mj40b8x0mQ8(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 115, 0)));
			chartTheme.ClusterUpBarColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 115, 0);
			chartTheme.ClusterValueAreaColor = Color.FromArgb(byte.MaxValue, 191, 196, 201);
			chartTheme.ClusterVolumeColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 149, 117, 205));
			chartTheme.CursorLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(107, byte.MaxValue, 165, 0));
			chartTheme.CursorMarkerBackColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 165, 0));
			chartTheme.CursorMarkerTextColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 35, 39, 46));
			Amm5Z9beK58LRPOI5OoY(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue)));
			L2qQ9fbeLs8ywwP2WjkR(chartTheme, Color.FromArgb(25, 191, 196, 201));
			BoQAKpbem2vci3FguR9o(chartTheme, Color.FromArgb(byte.MaxValue, 230, 230, 230));
			NDO2C9beeCMs6Jybs9X2(chartTheme, pKRGyrbLdyNmK2CbFTuV(25, 247, 147, 26));
			Yhb5qKbs9HWA3xoQ1Hjs(chartTheme, Color.FromArgb(25, 177, 108, 234));
			chartTheme.DomTextColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 35, 39, 46);
			chartTheme.HistogramAskColor = Color.FromArgb(byte.MaxValue, 247, 147, 26);
			chartTheme.HistogramBidColor = Color.FromArgb(byte.MaxValue, 177, 108, 234);
			chartTheme.HistogramCellBorderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 196, 201));
			chartTheme.HistogramDeltaMinusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 35, 39, 46));
			chartTheme.HistogramDeltaPlusColor = Color.FromArgb(byte.MaxValue, 247, 147, 26);
			chartTheme.HistogramMaximumColor = Color.FromArgb(byte.MaxValue, 247, 147, 26);
			chartTheme.HistogramTextColor = Color.FromArgb(byte.MaxValue, 35, 39, 46);
			chartTheme.HistogramTradesColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 247, 147, 26));
			chartTheme.HistogramValueAreaColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201));
			l1ZVTNbs53j1AZcsI8eK(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 177, 108, 234));
			oINd8Dbsc9Uvwphbxct2(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 247, 147, 26)));
			chartTheme.IndicatorBackColor1 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 251, 176, 64);
			chartTheme.IndicatorBackColor2 = Color.FromArgb(byte.MaxValue, 228, 228, 228);
			chartTheme.LineColor = Color.FromArgb(byte.MaxValue, 247, 147, 26);
			chartTheme.LongPositionColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 177, 108, 234));
			xYHTstbsjE0HY1iZwAS1(chartTheme, Color.FromArgb(byte.MaxValue, 240, 128, 128));
			Kq91JRbsg1od5nEARom8(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(128, 177, 108, 234)));
			RC7caqbecDUGo3iiqsa1(chartTheme, Color.FromArgb(128, 35, 39, 46));
			chartTheme.PaletteColor1 = Color.FromArgb(byte.MaxValue, 247, 147, 26);
			PevY0nbej1BI9G6ZH0dL(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 177, 108, 234)));
			CtpBpSbePMag6frum2ym(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 128, 128));
			chartTheme.PaletteColor4 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 218, 112, 214));
			ljFYT9beQVArWALZ3USF(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 69, 0));
			chartTheme.PaletteColor6 = Color.FromArgb(byte.MaxValue, 177, 108, 234);
			LK0gXcbsRWSAo6dtxmHR(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 139, 69, 19)));
			chartTheme.PositionLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 211, 211, 211);
			chartTheme.PositivePnLColor = Color.FromArgb(208, 0, 191, byte.MaxValue);
			chartTheme.QuoteBestBuyColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
			chartTheme.QuoteBestSellColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
			chartTheme.QuoteBuyColor = Color.FromArgb(127, 70, 130, 180);
			chartTheme.QuoteBuyVolumeColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 227, 108, 9));
			fvRytObs6fNRDyD6qvkp(chartTheme, pKRGyrbLdyNmK2CbFTuV(231, 149, 117, 205));
			vX5c1Zbe6fLVrPy3lwhU(chartTheme, pKRGyrbLdyNmK2CbFTuV(50, 0, 0, 0));
			chartTheme.QuoteSellColor = Color.FromArgb(byte.MaxValue, 119, 119, 119);
			y4Kl6FbsMH4eqqmVE96V(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 251, 176, 64)));
			chartTheme.QuoteStopOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 85, 85, 85);
			eDZ5aWbeJtRMWuFX2OCL(chartTheme, Color.FromArgb(byte.MaxValue, 149, 117, 205));
			mVuPFYbeFfT35wkAsJIQ(chartTheme, Color.FromArgb(byte.MaxValue, 119, 119, 119));
			chartTheme.SellStopOrderColor = Color.FromArgb(byte.MaxValue, 119, 119, 119);
			chartTheme.SellTradeBorderColor = Color.FromArgb(byte.MaxValue, 119, 119, 119);
			chartTheme.SellTradeColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 119, 119, 119);
			chartTheme.SellTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 119, 119, 119));
			GFqREJbsBhTliLWLx9ul(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 119, 119, 119)));
			chartTheme.StopLossColor = Color.FromArgb(byte.MaxValue, 119, 119, 119);
			chartTheme.TakeProfitColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 177, 108, 234));
			return chartTheme;
		}
	}

	public static ChartTheme LightNeoTheme
	{
		get
		{
			ChartTheme chartTheme = new ChartTheme();
			bwZDwAbengRS1jIGCNh7(chartTheme, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710762358));
			chartTheme.ThemeName = Resources.ChartThemeLightNeo;
			chartTheme.AreaColor = Color.FromArgb(26, 0, 128, 128);
			chartTheme.AreaLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 128, 128);
			tns3gSbeWcnybZoCqvQX(chartTheme, Color.FromArgb(byte.MaxValue, 222, 92, 92));
			chartTheme.BarUpBarColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			chartTheme.BuyLimitOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 135, 206, 235));
			chartTheme.BuyStopOrderColor = Color.FromArgb(byte.MaxValue, 135, 206, 235);
			DfWx2Gbevh3GoFvsCauF(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 135, 206, 235)));
			YEQ6GpbezEuU0s8HhYP0(chartTheme, Color.FromArgb(byte.MaxValue, 135, 206, 235));
			XIXKLmbetkNW2HjFb4u8(chartTheme, Color.FromArgb(byte.MaxValue, 135, 206, 235));
			chartTheme.CandleDownBackColor = Color.FromArgb(byte.MaxValue, 222, 92, 92);
			chartTheme.CandleDownBorderColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
			XZpx9qbsQiDU2munWwpg(chartTheme, Color.FromArgb(byte.MaxValue, 178, 34, 34));
			chartTheme.CandleUpBackColor = Color.FromArgb(byte.MaxValue, 63, 164, 122);
			chartTheme.CandleUpBorderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			lBMj6QbsOI9LIbYCmiSE(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 63, 164, 122)));
			chartTheme.ChartAxisColor = Color.FromArgb(byte.MaxValue, 204, 204, 204);
			movDIqbeBLqWP4reBcqe(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue)));
			chartTheme.ChartCpFillColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 242, 178));
			JSZWRJbeaS5cGfjFiJHU(chartTheme, Color.FromArgb(byte.MaxValue, byte.MaxValue, 215, 0));
			chartTheme.ChartFontColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 0, 0, 0));
			chartTheme.ChartGridColor = Color.FromArgb(25, 191, 196, 201);
			chartTheme.ChartObjectFillColor = Color.FromArgb(26, 63, 164, 122);
			chartTheme.ChartObjectLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			oLl3C3belLsArWusgsLR(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201));
			cJA9q3beZlTXOiBWyRTo(chartTheme, Color.FromArgb(byte.MaxValue, 204, 204, 204));
			pUMBKsbe4ZBYwQQG6j37(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 204, 204, 204));
			ANg3DKbsHOtbFhc01cLZ(chartTheme, Color.FromArgb(byte.MaxValue, 63, 164, 122));
			chartTheme.ClusterBidColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 222, 92, 92));
			bWgWl0beb2g52LjGq9Kf(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 204, 204, 204)));
			chartTheme.ClusterCellBorderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 196, 201));
			chartTheme.ClusterCellBorderMaxColor = Color.FromArgb(byte.MaxValue, 0, 0, 0);
			chartTheme.ClusterDeltaMinusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 222, 92, 92);
			chartTheme.ClusterDeltaPlusColor = Color.FromArgb(byte.MaxValue, 63, 164, 122);
			chartTheme.ClusterDownBarColor = Color.FromArgb(byte.MaxValue, 222, 92, 92);
			chartTheme.ClusterNeutralBidAskColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 204, 204, 204));
			XUUB0Fbe13TmyD8MFCrx(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 222, 92, 92));
			GAcS6Vbsddx0P1HylaXk(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122));
			chartTheme.ClusterStrongAskColor = Color.FromArgb(byte.MaxValue, 63, 164, 122);
			chartTheme.ClusterStrongBidColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 222, 92, 92);
			chartTheme.ClusterTextColor = Color.FromArgb(byte.MaxValue, 0, 0, 0);
			chartTheme.ClusterTradesColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122));
			chartTheme.ClusterUpBarColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 63, 164, 122));
			chartTheme.ClusterValueAreaColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201));
			chartTheme.ClusterVolumeColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122);
			chartTheme.CursorLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(80, 76, 76, 76));
			CVpPt7bss2mCqw60X9Hs(chartTheme, pKRGyrbLdyNmK2CbFTuV(197, 105, 108, 111));
			zKTbWSbex6B7EEuO1A9Q(chartTheme, Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
			chartTheme.DomBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
			chartTheme.DomGridColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(25, 191, 196, 201));
			BoQAKpbem2vci3FguR9o(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 204, 204, 204)));
			chartTheme.DomLossColor = Color.FromArgb(25, 222, 92, 92);
			chartTheme.DomProfitColor = Color.FromArgb(25, 63, 164, 122);
			chartTheme.DomTextColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 0, 0);
			chartTheme.HistogramAskColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122));
			chartTheme.HistogramBidColor = Color.FromArgb(byte.MaxValue, 222, 92, 92);
			jTtKJabehwMsxcbMQ7Od(chartTheme, Color.FromArgb(byte.MaxValue, 191, 196, 201));
			chartTheme.HistogramDeltaMinusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 222, 92, 92);
			chartTheme.HistogramDeltaPlusColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122));
			chartTheme.HistogramMaximumColor = Color.FromArgb(byte.MaxValue, 222, 92, 92);
			chartTheme.HistogramTextColor = Color.FromArgb(byte.MaxValue, 0, 0, 0);
			z1UBSQbsGXKNFmCFiTj3(chartTheme, Color.FromArgb(byte.MaxValue, 63, 164, 122));
			chartTheme.HistogramValueAreaColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 196, 201));
			l1ZVTNbs53j1AZcsI8eK(chartTheme, Color.FromArgb(byte.MaxValue, 63, 164, 122));
			chartTheme.IndicatorAlertBackColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 222, 92, 92);
			mRjr8cbsYIrL5TP1UAmw(chartTheme, Color.FromArgb(byte.MaxValue, byte.MaxValue, 242, 178));
			chartTheme.IndicatorBackColor2 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 228, 228, 228));
			chartTheme.LineColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 63, 164, 122));
			FgPJ7pbsqpiA3mm1dYbi(chartTheme, Color.FromArgb(byte.MaxValue, 135, 206, 235));
			xYHTstbsjE0HY1iZwAS1(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 182, 193)));
			chartTheme.OpenLongPositionColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(128, 63, 164, 122));
			RC7caqbecDUGo3iiqsa1(chartTheme, Color.FromArgb(128, 222, 92, 92));
			chartTheme.PaletteColor1 = Color.FromArgb(byte.MaxValue, 63, 164, 122);
			chartTheme.PaletteColor2 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 222, 92, 92));
			chartTheme.PaletteColor3 = Color.FromArgb(byte.MaxValue, 100, 149, 237);
			chartTheme.PaletteColor4 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 222, 184, 135);
			chartTheme.PaletteColor5 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34);
			chartTheme.PaletteColor6 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 63, 164, 122));
			LK0gXcbsRWSAo6dtxmHR(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 222, 92, 92)));
			chartTheme.PositionLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 211, 211, 211));
			chartTheme.PositivePnLColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(208, 0, 191, byte.MaxValue));
			chartTheme.QuoteBestBuyColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
			chartTheme.QuoteBestSellColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 178, 34, 34));
			chartTheme.QuoteBuyColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(127, 70, 130, 180));
			chartTheme.QuoteBuyVolumeColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 227, 108, 9));
			chartTheme.QuoteLimitOrderColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
			chartTheme.QuoteSelectedColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(127, byte.MaxValue, byte.MaxValue, byte.MaxValue));
			chartTheme.QuoteSellColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(127, 178, 34, 34));
			y4Kl6FbsMH4eqqmVE96V(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 227, 108, 9));
			F0e8gKbsvn9oiwwG8YVW(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34)));
			chartTheme.QuoteTriggerOrderColor = Color.FromArgb(byte.MaxValue, 227, 108, 9);
			chartTheme.SellLimitOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128));
			chartTheme.SellStopOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 240, 128, 128));
			chartTheme.SellTradeBorderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128);
			chartTheme.SellTradeColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128));
			chartTheme.SellTriggerOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128);
			chartTheme.ShortPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128);
			chartTheme.StopLossColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 240, 128, 128));
			chartTheme.TakeProfitColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 135, 206, 235));
			return chartTheme;
		}
	}

	public static ChartTheme LightPurpleGrayTheme
	{
		get
		{
			ChartTheme chartTheme = new ChartTheme();
			bwZDwAbengRS1jIGCNh7(chartTheme, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1848952786 ^ -1848701658));
			chartTheme.ThemeName = Resources.ChartThemeLightPurpleGray;
			chartTheme.AreaColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(26, 142, 124, 195));
			chartTheme.AreaLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 124, 195);
			chartTheme.BarDownBarColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 166, 201));
			chartTheme.BarUpBarColor = Color.FromArgb(byte.MaxValue, 142, 124, 195);
			chartTheme.BuyLimitOrderColor = Color.FromArgb(byte.MaxValue, 135, 206, 235);
			chartTheme.BuyStopOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 135, 206, 235));
			chartTheme.BuyTradeBorderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 135, 206, 235));
			chartTheme.BuyTradeColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 135, 206, 235));
			chartTheme.BuyTriggerOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 135, 206, 235);
			chartTheme.CandleDownBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 166, 201));
			pQ4BLybs2qq4jgRKJW8H(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 166, 201)));
			chartTheme.CandleDownWickColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 166, 201));
			chartTheme.CandleUpBackColor = Color.FromArgb(byte.MaxValue, 142, 124, 195);
			chartTheme.CandleUpBorderColor = Color.FromArgb(byte.MaxValue, 142, 124, 195);
			chartTheme.CandleUpWickColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 124, 195);
			JX8E20beT5K54i0JhdUH(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 230, 230, 230)));
			chartTheme.ChartBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 250, 250, byte.MaxValue));
			diBt5DbeykHN17pg1X4D(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 234, 230, 250)));
			chartTheme.ChartCpLineColor = Color.FromArgb(byte.MaxValue, 191, 166, 201);
			chartTheme.ChartFontColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 0, 0));
			SduekjbsIB9MvHpW910V(chartTheme, Color.FromArgb(25, 191, 196, 201));
			chartTheme.ChartObjectFillColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(26, 142, 124, 195));
			chartTheme.ChartObjectLineColor = Color.FromArgb(byte.MaxValue, 142, 124, 195);
			oLl3C3belLsArWusgsLR(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201));
			chartTheme.CloseLongPositionColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 230, 230, 230));
			chartTheme.CloseShortPositionColor = Color.FromArgb(byte.MaxValue, 230, 230, 230);
			ANg3DKbsHOtbFhc01cLZ(chartTheme, Color.FromArgb(byte.MaxValue, 142, 124, 195));
			chartTheme.ClusterBidColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 166, 201));
			bWgWl0beb2g52LjGq9Kf(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 230, 230, 230)));
			chartTheme.ClusterCellBorderColor = Color.FromArgb(byte.MaxValue, 191, 196, 201);
			cmxvJcbeVZAYbS3tWLx8(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 0, 0)));
			o8irAibeCInM8TZMdHWY(chartTheme, Color.FromArgb(byte.MaxValue, 191, 166, 201));
			chartTheme.ClusterDeltaPlusColor = Color.FromArgb(byte.MaxValue, 142, 124, 195);
			chartTheme.ClusterDownBarColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 166, 201);
			xvFxjsbekMQovg4S4X1D(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 230, 230, 230)));
			chartTheme.ClusterOpenIntMinusColor = Color.FromArgb(byte.MaxValue, 191, 166, 201);
			chartTheme.ClusterOpenIntPlusColor = Color.FromArgb(byte.MaxValue, 142, 124, 195);
			MJjw94bsNK5xANJYxMhC(chartTheme, Color.FromArgb(byte.MaxValue, 142, 124, 195));
			chartTheme.ClusterStrongBidColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 166, 201));
			fUmVP9bsfk7WGIiPLOyV(chartTheme, Color.FromArgb(byte.MaxValue, 0, 0, 0));
			chartTheme.ClusterTradesColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 124, 195);
			chartTheme.ClusterUpBarColor = Color.FromArgb(byte.MaxValue, 142, 124, 195);
			chartTheme.ClusterValueAreaColor = Color.FromArgb(byte.MaxValue, 191, 196, 201);
			ASDK0Zbs17BOmhObH4eI(chartTheme, Color.FromArgb(byte.MaxValue, 142, 124, 195));
			dvuoqFberKGfBLA9PoXH(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(197, 106, 90, 205)));
			chartTheme.CursorMarkerBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(207, 106, 90, 205));
			chartTheme.CursorMarkerTextColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
			chartTheme.DomBackColor = Color.FromArgb(byte.MaxValue, 250, 250, byte.MaxValue);
			chartTheme.DomGridColor = Color.FromArgb(25, 191, 196, 201);
			chartTheme.DomLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 230, 230, 230);
			chartTheme.DomLossColor = pKRGyrbLdyNmK2CbFTuV(25, 191, 166, 201);
			chartTheme.DomProfitColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(25, 142, 124, 195));
			chartTheme.DomTextColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 0, 0));
			chartTheme.HistogramAskColor = Color.FromArgb(byte.MaxValue, 142, 124, 195);
			chartTheme.HistogramBidColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 166, 201));
			chartTheme.HistogramCellBorderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 196, 201));
			chartTheme.HistogramDeltaMinusColor = Color.FromArgb(byte.MaxValue, 191, 166, 201);
			chartTheme.HistogramDeltaPlusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 142, 124, 195));
			chartTheme.HistogramMaximumColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 166, 201));
			chartTheme.HistogramTextColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 0, 0, 0));
			z1UBSQbsGXKNFmCFiTj3(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 142, 124, 195));
			chartTheme.HistogramValueAreaColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 196, 201));
			chartTheme.HistogramVolumeColor = Color.FromArgb(byte.MaxValue, 142, 124, 195);
			chartTheme.IndicatorAlertBackColor = Color.FromArgb(byte.MaxValue, 191, 166, 201);
			chartTheme.IndicatorBackColor1 = Color.FromArgb(byte.MaxValue, 234, 230, 250);
			BSxkagbeAFMeacbxEht0(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 228, 228, 228)));
			chartTheme.LineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 142, 124, 195));
			chartTheme.LongPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 135, 206, 235);
			xYHTstbsjE0HY1iZwAS1(chartTheme, Color.FromArgb(byte.MaxValue, byte.MaxValue, 182, 193));
			chartTheme.OpenLongPositionColor = pKRGyrbLdyNmK2CbFTuV(128, 142, 124, 195);
			chartTheme.OpenShortPositionColor = Color.FromArgb(128, 191, 166, 201);
			jMr1wVbsopCUn42VWOJM(chartTheme, Color.FromArgb(byte.MaxValue, 142, 124, 195));
			PevY0nbej1BI9G6ZH0dL(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 166, 201));
			chartTheme.PaletteColor3 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201);
			s0s6jFbeEKFjEZY9KBCp(chartTheme, Color.FromArgb(byte.MaxValue, 230, 230, 230));
			ljFYT9beQVArWALZ3USF(chartTheme, Color.FromArgb(byte.MaxValue, 191, 196, 201));
			iqxNfRbedA8wBx1XH1WJ(chartTheme, Color.FromArgb(byte.MaxValue, 142, 124, 195));
			chartTheme.PaletteColor7 = Color.FromArgb(byte.MaxValue, 191, 166, 201);
			chartTheme.PositionLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 211, 211, 211);
			chartTheme.PositivePnLColor = pKRGyrbLdyNmK2CbFTuV(208, 0, 191, byte.MaxValue);
			yhwItFbsS87sG5V3S9uc(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 70, 130, 180)));
			chartTheme.QuoteBestSellColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 178, 34, 34));
			chartTheme.QuoteBuyColor = Color.FromArgb(127, 70, 130, 180);
			chartTheme.QuoteBuyVolumeColor = Color.FromArgb(byte.MaxValue, 227, 108, 9);
			fvRytObs6fNRDyD6qvkp(chartTheme, Color.FromArgb(byte.MaxValue, 70, 130, 180));
			chartTheme.QuoteSelectedColor = pKRGyrbLdyNmK2CbFTuV(127, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			chartTheme.QuoteSellColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(127, 178, 34, 34));
			chartTheme.QuoteSellVolumeColor = Color.FromArgb(byte.MaxValue, 227, 108, 9);
			chartTheme.QuoteStopOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34);
			chartTheme.QuoteTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 227, 108, 9));
			chartTheme.SellLimitOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 240, 128, 128));
			chartTheme.SellStopOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128));
			chartTheme.SellTradeBorderColor = Color.FromArgb(byte.MaxValue, 240, 128, 128);
			chartTheme.SellTradeColor = Color.FromArgb(byte.MaxValue, 240, 128, 128);
			chartTheme.SellTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128));
			chartTheme.ShortPositionColor = Color.FromArgb(byte.MaxValue, 240, 128, 128);
			HEfcGJbsa5uS2nBmhvjw(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128)));
			chartTheme.TakeProfitColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 135, 206, 235));
			return chartTheme;
		}
	}

	public static ChartTheme LightDimmedTheme
	{
		get
		{
			ChartTheme chartTheme = new ChartTheme();
			bwZDwAbengRS1jIGCNh7(chartTheme, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1192989954 ^ -1193255368));
			chartTheme.ThemeName = Resources.ChartThemeLightDimmed;
			chartTheme.AreaColor = pKRGyrbLdyNmK2CbFTuV(26, 70, 130, 180);
			uWHaA5bsi7sKiHNjNga2(chartTheme, Color.FromArgb(byte.MaxValue, 70, 130, 180));
			chartTheme.BarDownBarColor = Color.FromArgb(byte.MaxValue, 205, 140, 140);
			chartTheme.BarUpBarColor = Color.FromArgb(byte.MaxValue, 95, 158, 160);
			dOhnQGbeo1NMhWme782e(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 95, 158, 160)));
			chartTheme.BuyStopOrderColor = Color.FromArgb(byte.MaxValue, 95, 158, 160);
			chartTheme.BuyTradeBorderColor = Color.FromArgb(byte.MaxValue, 95, 158, 160);
			chartTheme.BuyTradeColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 95, 158, 160));
			chartTheme.BuyTriggerOrderColor = Color.FromArgb(byte.MaxValue, 95, 158, 160);
			JRvaxWbs0Isbym17F8Q2(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 205, 140, 140)));
			pQ4BLybs2qq4jgRKJW8H(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 180, 125, 125)));
			chartTheme.CandleDownWickColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 180, 125, 125);
			wJGORRbeUG9kywserkKE(chartTheme, Color.FromArgb(byte.MaxValue, 95, 158, 160));
			chartTheme.CandleUpBorderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 78, 132, 137));
			chartTheme.CandleUpWickColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 78, 132, 137));
			chartTheme.ChartAxisColor = Color.FromArgb(byte.MaxValue, 192, 192, 192);
			chartTheme.ChartBackColor = Color.FromArgb(byte.MaxValue, 248, 249, 250);
			diBt5DbeykHN17pg1X4D(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 215, 0));
			JSZWRJbeaS5cGfjFiJHU(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 165, 0)));
			chartTheme.ChartFontColor = Color.FromArgb(byte.MaxValue, 0, 0, 0);
			chartTheme.ChartGridColor = pKRGyrbLdyNmK2CbFTuV(61, 191, 196, 201);
			chartTheme.ChartObjectFillColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(26, 144, 202, 249));
			kUrmWAbsWOOnwy6hhtUj(chartTheme, Color.FromArgb(byte.MaxValue, 144, 202, 249));
			chartTheme.ChartSessionLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 196, 201));
			chartTheme.CloseLongPositionColor = Color.FromArgb(byte.MaxValue, 211, 211, 211);
			pUMBKsbe4ZBYwQQG6j37(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 211, 211, 211)));
			chartTheme.ClusterAskColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 95, 158, 160));
			l8UZQBbeDtXcT0y4Rx5K(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 205, 140, 140)));
			chartTheme.ClusterBorderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 211, 211, 211);
			chartTheme.ClusterCellBorderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 196, 201));
			cmxvJcbeVZAYbS3tWLx8(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 0, 0, 0)));
			chartTheme.ClusterDeltaMinusColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 205, 140, 140));
			chartTheme.ClusterDeltaPlusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 95, 158, 160);
			chartTheme.ClusterDownBarColor = Color.FromArgb(byte.MaxValue, 205, 140, 140);
			chartTheme.ClusterNeutralBidAskColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 211, 211, 211));
			XUUB0Fbe13TmyD8MFCrx(chartTheme, Color.FromArgb(byte.MaxValue, 205, 140, 140));
			GAcS6Vbsddx0P1HylaXk(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 95, 158, 160));
			chartTheme.ClusterStrongAskColor = Color.FromArgb(byte.MaxValue, 95, 158, 160);
			chartTheme.ClusterStrongBidColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 205, 140, 140));
			fUmVP9bsfk7WGIiPLOyV(chartTheme, Color.FromArgb(byte.MaxValue, 0, 0, 0));
			chartTheme.ClusterTradesColor = Color.FromArgb(byte.MaxValue, 95, 158, 160);
			uKknHlbskRkATkxUQH37(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 95, 158, 160)));
			OMEewCbeS7qScN3xRfLb(chartTheme, Color.FromArgb(byte.MaxValue, 191, 196, 201));
			chartTheme.ClusterVolumeColor = Color.FromArgb(byte.MaxValue, 95, 158, 160);
			chartTheme.CursorLineColor = Color.FromArgb(170, 95, 158, 160);
			chartTheme.CursorMarkerBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 95, 158, 160));
			zKTbWSbex6B7EEuO1A9Q(chartTheme, Color.FromArgb(byte.MaxValue, 0, 0, 0));
			chartTheme.DomBackColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 248, 249, 250));
			chartTheme.DomGridColor = pKRGyrbLdyNmK2CbFTuV(25, 191, 196, 201);
			BoQAKpbem2vci3FguR9o(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 211, 211, 211)));
			NDO2C9beeCMs6Jybs9X2(chartTheme, pKRGyrbLdyNmK2CbFTuV(25, 240, 128, 128));
			chartTheme.DomProfitColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(25, 135, 206, 235));
			chartTheme.DomTextColor = Color.FromArgb(byte.MaxValue, 0, 0, 0);
			chartTheme.HistogramAskColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 135, 206, 235));
			chartTheme.HistogramBidColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128));
			jTtKJabehwMsxcbMQ7Od(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201));
			chartTheme.HistogramDeltaMinusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128);
			OVWg0HbespswqoFRXdWL(chartTheme, Color.FromArgb(byte.MaxValue, 135, 206, 235));
			gN5aQUbew7FiIPGpOsx9(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 240, 128, 128)));
			n90dVYbe7TLOPlVhDDLK(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 0, 0, 0)));
			z1UBSQbsGXKNFmCFiTj3(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 135, 206, 235)));
			chartTheme.HistogramValueAreaColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201);
			chartTheme.HistogramVolumeColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 135, 206, 235));
			chartTheme.IndicatorAlertBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 240, 128, 128));
			chartTheme.IndicatorBackColor1 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 250, 250, 210);
			BSxkagbeAFMeacbxEht0(chartTheme, Color.FromArgb(byte.MaxValue, 228, 228, 228));
			chartTheme.LineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 144, 202, 249));
			chartTheme.LongPositionColor = Color.FromArgb(byte.MaxValue, 135, 206, 235);
			chartTheme.NegativePnLColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 182, 193));
			chartTheme.OpenLongPositionColor = pKRGyrbLdyNmK2CbFTuV(128, 135, 206, 235);
			chartTheme.OpenShortPositionColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(128, 240, 128, 128));
			jMr1wVbsopCUn42VWOJM(chartTheme, Color.FromArgb(byte.MaxValue, 144, 202, 249));
			chartTheme.PaletteColor2 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 165, 0);
			chartTheme.PaletteColor3 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 218, 112, 214);
			s0s6jFbeEKFjEZY9KBCp(chartTheme, Color.FromArgb(byte.MaxValue, 64, 224, 208));
			chartTheme.PaletteColor5 = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 105, 180));
			chartTheme.PaletteColor6 = Color.FromArgb(byte.MaxValue, 0, 128, 128);
			chartTheme.PaletteColor7 = Color.FromArgb(byte.MaxValue, 240, 128, 128);
			chartTheme.PositionLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 211, 211, 211);
			chartTheme.PositivePnLColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(208, 0, 191, byte.MaxValue));
			chartTheme.QuoteBestBuyColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
			chartTheme.QuoteBestSellColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 178, 34, 34));
			chartTheme.QuoteBuyColor = pKRGyrbLdyNmK2CbFTuV(127, 70, 130, 180);
			R6ZnlabstSGcgtcrK42q(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 227, 108, 9));
			chartTheme.QuoteLimitOrderColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
			chartTheme.QuoteSelectedColor = Color.FromArgb(127, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			JIwT4AbeMI3pHnpi4aF7(chartTheme, Color.FromArgb(127, 178, 34, 34));
			chartTheme.QuoteSellVolumeColor = Color.FromArgb(byte.MaxValue, 227, 108, 9);
			chartTheme.QuoteStopOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34);
			eDZ5aWbeJtRMWuFX2OCL(chartTheme, Color.FromArgb(byte.MaxValue, 227, 108, 9));
			mVuPFYbeFfT35wkAsJIQ(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 205, 140, 140)));
			SQxrYmbsekoq9EpPCu8p(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 205, 140, 140)));
			chartTheme.SellTradeBorderColor = Color.FromArgb(byte.MaxValue, 205, 140, 140);
			chartTheme.SellTradeColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 205, 140, 140));
			HH3FPxbepYU0RyVIiXHE(chartTheme, Color.FromArgb(byte.MaxValue, 205, 140, 140));
			chartTheme.ShortPositionColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 240, 128, 128));
			chartTheme.StopLossColor = Color.FromArgb(byte.MaxValue, 240, 128, 128);
			q6A733beqM7B6XguST6u(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 135, 206, 235)));
			return chartTheme;
		}
	}

	public static ChartTheme LightBlueAmberTheme
	{
		get
		{
			ChartTheme obj = new ChartTheme
			{
				ThemeID = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D1CCCFE)
			};
			mprFRgbeGSYcxby7UYCE(obj, Resources.ChartThemeLightBlueAmber);
			obj.AreaColor = pKRGyrbLdyNmK2CbFTuV(26, 0, 148, byte.MaxValue);
			obj.AreaLineColor = Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue);
			tns3gSbeWcnybZoCqvQX(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 161, 90)));
			obj.BarUpBarColor = Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue);
			dOhnQGbeo1NMhWme782e(obj, Color.FromArgb(byte.MaxValue, 135, 206, 235));
			j7RL5sbeujpDYe3RR2Mb(obj, Color.FromArgb(byte.MaxValue, 135, 206, 235));
			obj.BuyTradeBorderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 135, 206, 235);
			obj.BuyTradeColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 135, 206, 235));
			obj.BuyTriggerOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 135, 206, 235);
			JRvaxWbs0Isbym17F8Q2(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 161, 90));
			obj.CandleDownBorderColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 106, 0);
			obj.CandleDownWickColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 106, 0);
			wJGORRbeUG9kywserkKE(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 148, byte.MaxValue)));
			obj.CandleUpBorderColor = Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue);
			lBMj6QbsOI9LIbYCmiSE(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 148, byte.MaxValue)));
			JX8E20beT5K54i0JhdUH(obj, Color.FromArgb(byte.MaxValue, 230, 230, 230));
			obj.ChartBackColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 250, 252, byte.MaxValue);
			diBt5DbeykHN17pg1X4D(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 230, 178));
			obj.ChartCpLineColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 161, 90);
			obj.ChartFontColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 0, 0, 0));
			obj.ChartGridColor = Color.FromArgb(25, 191, 196, 201);
			obj.ChartObjectFillColor = Color.FromArgb(26, 0, 148, byte.MaxValue);
			obj.ChartObjectLineColor = Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue);
			oLl3C3belLsArWusgsLR(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201));
			obj.CloseLongPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 230, 230, 230);
			obj.CloseShortPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 230, 230, 230);
			ANg3DKbsHOtbFhc01cLZ(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 148, byte.MaxValue));
			l8UZQBbeDtXcT0y4Rx5K(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 161, 90)));
			obj.ClusterBorderColor = Color.FromArgb(byte.MaxValue, 230, 230, 230);
			obj.ClusterCellBorderColor = Color.FromArgb(byte.MaxValue, 191, 196, 201);
			obj.ClusterCellBorderMaxColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 0, 0, 0));
			obj.ClusterDeltaMinusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 161, 90));
			obj.ClusterDeltaPlusColor = Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue);
			obj.ClusterDownBarColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 161, 90);
			obj.ClusterNeutralBidAskColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 230, 230, 230);
			XUUB0Fbe13TmyD8MFCrx(obj, Color.FromArgb(byte.MaxValue, byte.MaxValue, 161, 90));
			GAcS6Vbsddx0P1HylaXk(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 148, byte.MaxValue));
			obj.ClusterStrongAskColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue));
			Ec7RNObsUw6MOwApl1f4(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 161, 90)));
			obj.ClusterTextColor = Color.FromArgb(byte.MaxValue, 0, 0, 0);
			OOQg4Ebe5mj40b8x0mQ8(obj, Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue));
			obj.ClusterUpBarColor = Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue);
			OMEewCbeS7qScN3xRfLb(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 196, 201)));
			ASDK0Zbs17BOmhObH4eI(obj, Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue));
			obj.CursorLineColor = pKRGyrbLdyNmK2CbFTuV(155, 30, 144, byte.MaxValue);
			CVpPt7bss2mCqw60X9Hs(obj, Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue));
			obj.CursorMarkerTextColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			obj.DomBackColor = Color.FromArgb(byte.MaxValue, 250, 252, byte.MaxValue);
			obj.DomGridColor = pKRGyrbLdyNmK2CbFTuV(25, 191, 196, 201);
			obj.DomLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 230, 230, 230));
			obj.DomLossColor = pKRGyrbLdyNmK2CbFTuV(25, byte.MaxValue, 161, 90);
			Yhb5qKbs9HWA3xoQ1Hjs(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(25, 0, 148, byte.MaxValue)));
			obj.DomTextColor = Color.FromArgb(byte.MaxValue, 0, 0, 0);
			obj.HistogramAskColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 148, byte.MaxValue);
			obj.HistogramBidColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 161, 90));
			obj.HistogramCellBorderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201);
			obj.HistogramDeltaMinusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 161, 90);
			obj.HistogramDeltaPlusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue));
			obj.HistogramMaximumColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 161, 90);
			obj.HistogramTextColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 0, 0, 0));
			obj.HistogramTradesColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 148, byte.MaxValue);
			oKSUxYbe8PHs1X1Vg0Om(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201)));
			obj.HistogramVolumeColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 148, byte.MaxValue);
			obj.IndicatorAlertBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 161, 90));
			obj.IndicatorBackColor1 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 230, 178);
			obj.IndicatorBackColor2 = Color.FromArgb(byte.MaxValue, 228, 228, 228);
			obj.LineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue));
			FgPJ7pbsqpiA3mm1dYbi(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 135, 206, 235));
			obj.NegativePnLColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 182, 193));
			obj.OpenLongPositionColor = Color.FromArgb(128, 0, 148, byte.MaxValue);
			obj.OpenShortPositionColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(128, byte.MaxValue, 161, 90));
			jMr1wVbsopCUn42VWOJM(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 148, byte.MaxValue)));
			obj.PaletteColor2 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 161, 90);
			obj.PaletteColor3 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 191, 196, 201));
			obj.PaletteColor4 = Color.FromArgb(byte.MaxValue, 230, 230, 230);
			ljFYT9beQVArWALZ3USF(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 191, 196, 201));
			obj.PaletteColor6 = Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue);
			obj.PaletteColor7 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 161, 90));
			zDdfFZbegQt50JQLgio8(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 211, 211, 211));
			obj.PositivePnLColor = pKRGyrbLdyNmK2CbFTuV(208, 0, 191, byte.MaxValue);
			yhwItFbsS87sG5V3S9uc(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 70, 130, 180)));
			obj.QuoteBestSellColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34);
			jlO8StbsLE8TJUWfquZx(obj, pKRGyrbLdyNmK2CbFTuV(127, 70, 130, 180));
			obj.QuoteBuyVolumeColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 227, 108, 9);
			fvRytObs6fNRDyD6qvkp(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 70, 130, 180)));
			vX5c1Zbe6fLVrPy3lwhU(obj, Color.FromArgb(127, byte.MaxValue, byte.MaxValue, byte.MaxValue));
			obj.QuoteSellColor = Color.FromArgb(127, 178, 34, 34);
			obj.QuoteSellVolumeColor = Color.FromArgb(byte.MaxValue, 227, 108, 9);
			F0e8gKbsvn9oiwwG8YVW(obj, Color.FromArgb(byte.MaxValue, 178, 34, 34));
			obj.QuoteTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 227, 108, 9));
			obj.SellLimitOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 240, 128, 128));
			SQxrYmbsekoq9EpPCu8p(obj, Color.FromArgb(byte.MaxValue, 240, 128, 128));
			obj.SellTradeBorderColor = Color.FromArgb(byte.MaxValue, 240, 128, 128);
			ci71arbeOXHP3uiasXYC(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128));
			obj.SellTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128));
			obj.ShortPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128);
			obj.StopLossColor = Color.FromArgb(byte.MaxValue, 240, 128, 128);
			obj.TakeProfitColor = Color.FromArgb(byte.MaxValue, 135, 206, 235);
			return obj;
		}
	}

	public static ChartTheme LightTheme
	{
		get
		{
			ChartTheme obj = new ChartTheme
			{
				ThemeID = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461949456 ^ -1462214766)
			};
			mprFRgbeGSYcxby7UYCE(obj, Resources.ChartThemeLight);
			obj.ChartBackColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			F3X2Wobs4O8PmmF2mYPY(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 0, 0));
			SduekjbsIB9MvHpW910V(obj, Color.FromArgb(byte.MaxValue, 230, 230, 230));
			obj.ChartAxisColor = Color.FromArgb(byte.MaxValue, 192, 192, 192);
			obj.ChartSessionLineColor = Color.FromArgb(byte.MaxValue, 120, 120, 120);
			obj.CandleUpBackColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 64, 224, 208);
			obj.CandleUpBorderColor = Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue);
			obj.CandleUpWickColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue));
			obj.CandleDownBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 0));
			obj.CandleDownBorderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34);
			obj.CandleDownWickColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 178, 34, 34));
			obj.BarUpBarColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 30, 144, byte.MaxValue);
			tns3gSbeWcnybZoCqvQX(obj, Color.FromArgb(byte.MaxValue, 178, 34, 34));
			mcc3dobeXAlLgnv6r1ex(obj, Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue));
			nDuGk2beYA6yVFZgeWw2(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(127, 30, 144, byte.MaxValue)));
			obj.AreaLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue));
			obj.ClusterVolumeColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 70, 130, 180);
			obj.ClusterTradesColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
			obj.ClusterDeltaPlusColor = Color.FromArgb(byte.MaxValue, 46, 139, 87);
			obj.ClusterDeltaMinusColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
			l8UZQBbeDtXcT0y4Rx5K(obj, Color.FromArgb(byte.MaxValue, 178, 34, 34));
			obj.ClusterAskColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
			obj.ClusterStrongBidColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
			obj.ClusterStrongAskColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
			obj.ClusterNeutralBidAskColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 192, 192, 192);
			obj.ClusterOpenIntPlusColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
			obj.ClusterOpenIntMinusColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
			obj.ClusterUpBarColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
			obj.ClusterDownBarColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34);
			obj.ClusterValueAreaColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 0, 0);
			AMODkJbeNpu7M1sJhs6K(obj, Color.FromArgb(byte.MaxValue, 127, 127, 127));
			obj.ClusterCellBorderMaxColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 0, 0);
			bWgWl0beb2g52LjGq9Kf(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 192, 192, 192)));
			fUmVP9bsfk7WGIiPLOyV(obj, Color.FromArgb(byte.MaxValue, 0, 0, 0));
			l1ZVTNbs53j1AZcsI8eK(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 70, 130, 180)));
			z1UBSQbsGXKNFmCFiTj3(obj, Color.FromArgb(byte.MaxValue, 70, 130, 180));
			OVWg0HbespswqoFRXdWL(obj, Color.FromArgb(byte.MaxValue, 46, 139, 87));
			D84J26bsTuZHb0HfOgcZ(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 178, 34, 34)));
			obj.HistogramBidColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
			obj.HistogramAskColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 70, 130, 180);
			obj.HistogramValueAreaColor = Color.FromArgb(byte.MaxValue, 128, 128, 128);
			obj.HistogramMaximumColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 178, 34, 34));
			obj.HistogramCellBorderColor = Color.FromArgb(byte.MaxValue, 127, 127, 127);
			obj.HistogramTextColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 0, 0);
			Amm5Z9beK58LRPOI5OoY(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
			obj.DomTextColor = Color.FromArgb(byte.MaxValue, 0, 0, 0);
			obj.DomLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 192, 192, 192));
			L2qQ9fbeLs8ywwP2WjkR(obj, Color.FromArgb(127, 97, 97, 97));
			obj.QuoteBuyColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 152, 251, 152);
			obj.QuoteBestBuyColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 143, 188, 143));
			obj.QuoteSellColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 228, 225);
			obj.QuoteBestSellColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 182, 193));
			R6ZnlabstSGcgtcrK42q(obj, Color.FromArgb(byte.MaxValue, byte.MaxValue, 165, 0));
			y4Kl6FbsMH4eqqmVE96V(obj, Color.FromArgb(byte.MaxValue, byte.MaxValue, 165, 0));
			obj.DomProfitColor = (Color)ColorConverter.ConvertFromString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342464822));
			obj.DomLossColor = (Color)ColorConverter.ConvertFromString((string)RLEwCXbLxM74YBHmFleH(0x1D7BA1ED ^ 0x1D7FFC47));
			obj.QuoteSelectedColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(50, 0, 0, 0));
			fvRytObs6fNRDyD6qvkp(obj, Color.FromArgb(231, 240, 128, 128));
			obj.QuoteStopOrderColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 0);
			eDZ5aWbeJtRMWuFX2OCL(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 165, 42, 42)));
			CVpPt7bss2mCqw60X9Hs(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 192, 192, 192)));
			obj.CursorMarkerTextColor = Color.FromArgb(byte.MaxValue, 0, 0, 0);
			obj.CursorLineColor = Color.FromArgb(byte.MaxValue, 192, 192, 192);
			obj.ChartObjectLineColor = Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue);
			obj.ChartObjectFillColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(30, 30, 144, byte.MaxValue));
			obj.ChartCpLineColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 165, 0);
			obj.ChartCpFillColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 215, 0));
			obj.BuyTradeColor = Color.FromArgb(200, 46, 139, 87);
			obj.BuyTradeBorderColor = Color.FromArgb(200, 46, 139, 87);
			ci71arbeOXHP3uiasXYC(obj, Color.FromArgb(200, 178, 34, 34));
			gMMjQxbe3abXQEhnAQ5n(obj, Color.FromArgb(200, 178, 34, 34));
			obj.OpenLongPositionColor = pKRGyrbLdyNmK2CbFTuV(200, 46, 139, 87);
			cJA9q3beZlTXOiBWyRTo(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 192, 192, 192)));
			obj.OpenShortPositionColor = Color.FromArgb(200, 178, 34, 34);
			obj.CloseShortPositionColor = Color.FromArgb(byte.MaxValue, 192, 192, 192);
			obj.PositionLineColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 211, 211, 211);
			obj.BuyLimitOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 135, 206, 235));
			obj.SellLimitOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128));
			j7RL5sbeujpDYe3RR2Mb(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 135, 206, 235)));
			obj.SellStopOrderColor = Color.FromArgb(byte.MaxValue, 240, 128, 128);
			XIXKLmbetkNW2HjFb4u8(obj, Color.FromArgb(byte.MaxValue, 135, 206, 235));
			HH3FPxbepYU0RyVIiXHE(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128)));
			FgPJ7pbsqpiA3mm1dYbi(obj, Color.FromArgb(byte.MaxValue, 135, 206, 235));
			GFqREJbsBhTliLWLx9ul(obj, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 240, 128, 128)));
			obj.PositivePnLColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 144, 238, 144);
			obj.NegativePnLColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 182, 193));
			obj.TakeProfitColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 135, 206, 235);
			HEfcGJbsa5uS2nBmhvjw(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 240, 128, 128)));
			mRjr8cbsYIrL5TP1UAmw(obj, (Color)ColorConverter.ConvertFromString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1A5F1B9E ^ 0x1A5B46EE)));
			obj.IndicatorBackColor2 = (Color)e5lg7fbLgAsYQ91k5UpZ(RLEwCXbLxM74YBHmFleH(0x5CD4F15 ^ 0x5C912D5));
			oINd8Dbsc9Uvwphbxct2(obj, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 0, 0));
			jMr1wVbsopCUn42VWOJM(obj, Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue));
			obj.PaletteColor2 = Color.FromArgb(byte.MaxValue, byte.MaxValue, 106, 0);
			obj.PaletteColor3 = Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 110);
			s0s6jFbeEKFjEZY9KBCp(obj, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 153, 21, 21)));
			ljFYT9beQVArWALZ3USF(obj, Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 0));
			obj.PaletteColor6 = Color.FromArgb(byte.MaxValue, 64, 224, 208);
			LK0gXcbsRWSAo6dtxmHR(obj, Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 0));
			ufKVo9bsytlIC1iPGPXp(obj, Color.FromArgb(127, 113, 147, byte.MaxValue));
			return obj;
		}
	}

	public static ChartTheme DarkModernTheme
	{
		get
		{
			ChartTheme chartTheme = new ChartTheme();
			bwZDwAbengRS1jIGCNh7(chartTheme, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1763895751 ^ -1764154813));
			chartTheme.ThemeName = (string)NdFCpcbsZLGOpIlXsK2M();
			movDIqbeBLqWP4reBcqe(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 22, 22, 22));
			chartTheme.ChartFontColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 245, 245, 245));
			chartTheme.ChartGridColor = Color.FromArgb(11, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			chartTheme.ChartAxisColor = Color.FromArgb(byte.MaxValue, 120, 120, 120);
			chartTheme.ChartSessionLineColor = Color.FromArgb(127, 112, 128, 144);
			wJGORRbeUG9kywserkKE(chartTheme, Color.FromArgb(byte.MaxValue, 36, 194, 203));
			chartTheme.CandleUpBorderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 36, 194, 203);
			chartTheme.CandleUpWickColor = Color.FromArgb(byte.MaxValue, 234, 231, 214);
			chartTheme.CandleDownBackColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 219, 7, 61);
			chartTheme.CandleDownBorderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 219, 7, 61));
			chartTheme.CandleDownWickColor = Color.FromArgb(byte.MaxValue, 234, 231, 214);
			chartTheme.BarUpBarColor = Color.FromArgb(byte.MaxValue, 36, 194, 203);
			chartTheme.BarDownBarColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 219, 7, 61));
			mcc3dobeXAlLgnv6r1ex(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 36, 194, 203));
			nDuGk2beYA6yVFZgeWw2(chartTheme, Color.FromArgb(101, 36, 194, 203));
			chartTheme.AreaLineColor = Color.FromArgb(byte.MaxValue, 36, 194, 203);
			chartTheme.ClusterVolumeColor = Color.FromArgb(byte.MaxValue, 112, 128, 144);
			chartTheme.ClusterTradesColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 112, 128, 144));
			chartTheme.ClusterDeltaPlusColor = Color.FromArgb(byte.MaxValue, 36, 194, 203);
			chartTheme.ClusterDeltaMinusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 219, 7, 61);
			l8UZQBbeDtXcT0y4Rx5K(chartTheme, Color.FromArgb(byte.MaxValue, 219, 7, 61));
			chartTheme.ClusterAskColor = Color.FromArgb(byte.MaxValue, 36, 194, 203);
			Ec7RNObsUw6MOwApl1f4(chartTheme, Color.FromArgb(byte.MaxValue, 219, 7, 61));
			chartTheme.ClusterStrongAskColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 36, 194, 203));
			chartTheme.ClusterNeutralBidAskColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 245, 245, 245));
			GAcS6Vbsddx0P1HylaXk(chartTheme, Color.FromArgb(byte.MaxValue, 36, 194, 203));
			chartTheme.ClusterOpenIntMinusColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 219, 7, 61));
			uKknHlbskRkATkxUQH37(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 36, 194, 203)));
			chartTheme.ClusterDownBarColor = Color.FromArgb(byte.MaxValue, 219, 7, 61);
			chartTheme.ClusterValueAreaColor = Color.FromArgb(byte.MaxValue, 211, 211, 211);
			chartTheme.ClusterCellBorderColor = Color.FromArgb(byte.MaxValue, 169, 169, 169);
			chartTheme.ClusterCellBorderMaxColor = Color.FromArgb(byte.MaxValue, 234, 231, 214);
			chartTheme.ClusterBorderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 112, 128, 144));
			chartTheme.ClusterTextColor = Color.FromArgb(byte.MaxValue, 245, 245, 245);
			l1ZVTNbs53j1AZcsI8eK(chartTheme, Color.FromArgb(byte.MaxValue, 13, 105, 134));
			chartTheme.HistogramTradesColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 13, 105, 134));
			chartTheme.HistogramDeltaPlusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 13, 105, 134);
			chartTheme.HistogramDeltaMinusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 172, 7, 61));
			kdGN5DbsnYgcagWhgTv8(chartTheme, Color.FromArgb(byte.MaxValue, 172, 7, 61));
			pIbWf3bsVhcMf9cyhbSI(chartTheme, Color.FromArgb(byte.MaxValue, 13, 105, 134));
			chartTheme.HistogramValueAreaColor = Color.FromArgb(byte.MaxValue, 112, 128, 144);
			chartTheme.HistogramMaximumColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
			chartTheme.HistogramCellBorderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 169, 169, 169));
			chartTheme.HistogramTextColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 245, 245, 245);
			chartTheme.DomBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 22, 22, 22));
			chartTheme.DomTextColor = Color.FromArgb(byte.MaxValue, 245, 245, 245);
			BoQAKpbem2vci3FguR9o(chartTheme, pKRGyrbLdyNmK2CbFTuV(127, 192, 192, 192));
			L2qQ9fbeLs8ywwP2WjkR(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(127, 92, 92, 92)));
			chartTheme.QuoteBuyColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(51, 36, 194, 203));
			chartTheme.QuoteBestBuyColor = Color.FromArgb(90, 36, 194, 203);
			chartTheme.QuoteSellColor = Color.FromArgb(51, 218, 37, 54);
			chartTheme.QuoteBestSellColor = Color.FromArgb(90, 218, 37, 54);
			R6ZnlabstSGcgtcrK42q(chartTheme, Color.FromArgb(189, 36, 194, 203));
			chartTheme.QuoteSellVolumeColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(189, 218, 37, 54));
			chartTheme.DomProfitColor = (Color)ColorConverter.ConvertFromString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x50C1C840 ^ 0x50C59592));
			chartTheme.DomLossColor = (Color)e5lg7fbLgAsYQ91k5UpZ(RLEwCXbLxM74YBHmFleH(0x24085900 ^ 0x240C04E8));
			chartTheme.QuoteSelectedColor = Color.FromArgb(98, 112, 128, 144);
			fvRytObs6fNRDyD6qvkp(chartTheme, pKRGyrbLdyNmK2CbFTuV(231, 112, 128, 144));
			chartTheme.QuoteStopOrderColor = Color.FromArgb(byte.MaxValue, 220, 20, 60);
			chartTheme.QuoteTriggerOrderColor = Color.FromArgb(byte.MaxValue, 165, 42, 42);
			chartTheme.CursorMarkerBackColor = Color.FromArgb(byte.MaxValue, 112, 128, 144);
			chartTheme.CursorMarkerTextColor = Color.FromArgb(byte.MaxValue, 245, 245, 245);
			dvuoqFberKGfBLA9PoXH(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 112, 128, 144));
			chartTheme.ChartObjectLineColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 13, 105, 134));
			chartTheme.ChartObjectFillColor = Color.FromArgb(30, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			chartTheme.ChartCpLineColor = Color.FromArgb(byte.MaxValue, 13, 105, 134);
			diBt5DbeykHN17pg1X4D(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 13, 105, 134)));
			chartTheme.BuyTradeColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
			chartTheme.BuyTradeBorderColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
			chartTheme.SellTradeColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
			gMMjQxbe3abXQEhnAQ5n(chartTheme, Color.FromArgb(byte.MaxValue, 178, 34, 34));
			chartTheme.OpenLongPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 70, 130, 180);
			cJA9q3beZlTXOiBWyRTo(chartTheme, Color.FromArgb(byte.MaxValue, 120, 120, 120));
			chartTheme.OpenShortPositionColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34));
			pUMBKsbe4ZBYwQQG6j37(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 120, 120, 120)));
			zDdfFZbegQt50JQLgio8(chartTheme, Color.FromArgb(byte.MaxValue, 120, 120, 120));
			chartTheme.BuyLimitOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 27, 84, 139);
			chartTheme.SellLimitOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 122, 22, 42));
			chartTheme.BuyStopOrderColor = Color.FromArgb(byte.MaxValue, 27, 84, 139);
			chartTheme.SellStopOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 122, 22, 42));
			XIXKLmbetkNW2HjFb4u8(chartTheme, q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 27, 84, 139)));
			chartTheme.SellTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 122, 22, 42));
			chartTheme.LongPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 27, 84, 139);
			GFqREJbsBhTliLWLx9ul(chartTheme, q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 122, 22, 42)));
			z8lrZWbeRYo8ROSM0q8x(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 127, 0));
			chartTheme.NegativePnLColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 0, 0));
			chartTheme.TakeProfitColor = Color.FromArgb(byte.MaxValue, 27, 84, 139);
			HEfcGJbsa5uS2nBmhvjw(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 122, 22, 42));
			mRjr8cbsYIrL5TP1UAmw(chartTheme, (Color)ColorConverter.ConvertFromString((string)RLEwCXbLxM74YBHmFleH(-338769610 ^ -339045306)));
			chartTheme.IndicatorBackColor2 = (Color)e5lg7fbLgAsYQ91k5UpZ(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x16AD7E76 ^ 0x16A923B6));
			oINd8Dbsc9Uvwphbxct2(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 0, 0));
			chartTheme.PaletteColor1 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 36, 194, 203);
			chartTheme.PaletteColor2 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 219, 7, 61);
			chartTheme.PaletteColor3 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 211, 211, 211);
			s0s6jFbeEKFjEZY9KBCp(chartTheme, Color.FromArgb(byte.MaxValue, 13, 105, 134));
			ljFYT9beQVArWALZ3USF(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 7, 72, 91));
			chartTheme.PaletteColor6 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 36, 194, 203);
			LK0gXcbsRWSAo6dtxmHR(chartTheme, pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 219, 7, 61));
			chartTheme.SelectionFillColor = pKRGyrbLdyNmK2CbFTuV(127, 113, 147, byte.MaxValue);
			return chartTheme;
		}
	}

	public static List<ChartTheme> StdThemes { get; }

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
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
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
					{
						num = 1;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						break;
					}
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	public ChartTheme()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		ThemeID = "";
		int num = 42;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				return;
			case 40:
				SellStopOrderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 122, 22, 42);
				num = 37;
				break;
			case 44:
				IndicatorBackColor1 = q9AvUrbLQViuIQ0nd0qd((Color)e5lg7fbLgAsYQ91k5UpZ(RLEwCXbLxM74YBHmFleH(-1087080834 ^ -1087362290)));
				num = 17;
				break;
			case 32:
				PaletteColor4 = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 153, 21, 21));
				num = 18;
				break;
			case 42:
				ThemeName = "";
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
				{
					num = 3;
				}
				break;
			case 33:
				CandleUpBackColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 30, 144, byte.MaxValue));
				CandleUpBorderColor = Color.FromArgb(byte.MaxValue, 64, 224, 208);
				num = 39;
				break;
			case 9:
				CandleDownWickColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 0);
				BarUpBarColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 64, 224, 208));
				BarDownBarColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 0, 0));
				LineColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
				num = 41;
				break;
			case 3:
				SellTradeColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(208, 220, 20, 60));
				SellTradeBorderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(208, 220, 20, 60));
				OpenLongPositionColor = Color.FromArgb(208, 0, 191, byte.MaxValue);
				CloseLongPositionColor = Color.FromArgb(byte.MaxValue, 192, 192, 192);
				num = 15;
				break;
			case 39:
				CandleUpWickColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 64, 224, 208));
				num = 11;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
				{
					num = 2;
				}
				break;
			case 10:
				QuoteTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 227, 108, 9));
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
				{
					num = 3;
				}
				break;
			case 14:
				DomLossColor = (Color)ColorConverter.ConvertFromString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24085900 ^ 0x240C045A));
				QuoteSelectedColor = Color.FromArgb(127, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				QuoteLimitOrderColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
				QuoteStopOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34));
				num = 10;
				break;
			case 22:
				DomBackColor = Color.FromArgb(byte.MaxValue, 24, 24, 24);
				DomTextColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				DomLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(0, 192, 192, 192));
				DomGridColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(127, 92, 92, 92));
				num = 26;
				break;
			case 23:
				ChartFontColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				ChartGridColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 39, 39, 39));
				num = 34;
				break;
			case 34:
				ChartAxisColor = Color.FromArgb(byte.MaxValue, 120, 120, 120);
				ChartSessionLineColor = Color.FromArgb(byte.MaxValue, 120, 120, 120);
				num = 33;
				break;
			case 8:
				LongPositionColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 27, 84, 139);
				num = 20;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
				{
					num = 4;
				}
				break;
			case 7:
				SelectionFillColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(127, 113, 147, byte.MaxValue));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				ChartObjectLineColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				num = 35;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
				{
					num = 35;
				}
				break;
			case 0:
				return;
			case 36:
				ClusterStrongBidColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34));
				ClusterStrongAskColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 70, 130, 180));
				ClusterNeutralBidAskColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 192, 192, 192));
				ClusterOpenIntPlusColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
				num = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae != 0)
				{
					num = 19;
				}
				break;
			case 29:
				PaletteColor6 = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 30, 144, byte.MaxValue);
				PaletteColor7 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 178, 34, 34));
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
				{
					num = 7;
				}
				break;
			case 30:
				HistogramMaximumColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
				HistogramCellBorderColor = Color.FromArgb(byte.MaxValue, 127, 127, 127);
				num2 = 21;
				goto IL_001a;
			case 43:
				QuoteBestBuyColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 70, 130, 180);
				QuoteSellColor = Color.FromArgb(127, 178, 34, 34);
				QuoteBestSellColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34));
				QuoteBuyVolumeColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 227, 108, 9));
				QuoteSellVolumeColor = Color.FromArgb(byte.MaxValue, 227, 108, 9);
				DomProfitColor = (Color)e5lg7fbLgAsYQ91k5UpZ(RLEwCXbLxM74YBHmFleH(0x1A5F1B9E ^ 0x1A5B46DA));
				num = 14;
				break;
			case 31:
				PositionLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 211, 211, 211));
				BuyLimitOrderColor = Color.FromArgb(byte.MaxValue, 27, 84, 139);
				SellLimitOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 122, 22, 42));
				num = 24;
				break;
			case 20:
				ShortPositionColor = Color.FromArgb(byte.MaxValue, 122, 22, 42);
				num2 = 4;
				goto IL_001a;
			case 11:
				CandleDownBackColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
				CandleDownBorderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, 0, 0);
				num = 9;
				break;
			case 35:
				ChartObjectFillColor = Color.FromArgb(30, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				ChartCpLineColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 211, 211, 211));
				num = 13;
				break;
			case 21:
				HistogramTextColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				num = 22;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
				{
					num = 10;
				}
				break;
			case 15:
				OpenShortPositionColor = Color.FromArgb(208, 220, 20, 60);
				num = 38;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
				{
					num = 5;
				}
				break;
			case 17:
				IndicatorBackColor2 = (Color)ColorConverter.ConvertFromString((string)RLEwCXbLxM74YBHmFleH(0x42D899B5 ^ 0x42DCC437));
				IndicatorAlertBackColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 0));
				PaletteColor1 = Color.FromArgb(byte.MaxValue, 0, 148, byte.MaxValue);
				PaletteColor2 = Color.FromArgb(byte.MaxValue, byte.MaxValue, 106, 0);
				PaletteColor3 = Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 110);
				num = 32;
				break;
			case 25:
				ClusterCellBorderMaxColor = Color.FromArgb(byte.MaxValue, 192, 192, 192);
				ClusterBorderColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 192, 192, 192);
				ClusterTextColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				HistogramVolumeColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 70, 130, 180));
				HistogramTradesColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
				num = 12;
				break;
			case 41:
				AreaColor = Color.FromArgb(127, 70, 130, 180);
				num2 = 28;
				goto IL_001a;
			case 19:
				ClusterOpenIntMinusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34);
				ClusterUpBarColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 70, 130, 180);
				ClusterDownBarColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 178, 34, 34));
				ClusterValueAreaColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 165, 0));
				ClusterCellBorderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 127, 127, 127));
				num = 25;
				break;
			case 6:
				ChartBackColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 24, 24, 24);
				num = 10;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
				{
					num = 23;
				}
				break;
			case 26:
				QuoteBuyColor = Color.FromArgb(127, 70, 130, 180);
				num = 43;
				break;
			case 18:
				PaletteColor5 = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 0));
				num = 29;
				break;
			case 28:
				AreaLineColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
				ClusterVolumeColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 70, 130, 180));
				ClusterTradesColor = Color.FromArgb(byte.MaxValue, 70, 130, 180);
				num = 16;
				break;
			case 24:
				BuyStopOrderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 27, 84, 139));
				num = 40;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
				{
					num = 20;
				}
				break;
			case 16:
				ClusterDeltaPlusColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 46, 139, 87));
				ClusterDeltaMinusColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34));
				ClusterBidColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
				ClusterAskColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 70, 130, 180));
				num = 36;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
				{
					num = 29;
				}
				break;
			case 4:
				PositivePnLColor = pKRGyrbLdyNmK2CbFTuV(208, 0, 191, byte.MaxValue);
				NegativePnLColor = Color.FromArgb(208, 220, 20, 60);
				TakeProfitColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 27, 84, 139));
				StopLossColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 122, 22, 42));
				num = 21;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
				{
					num = 44;
				}
				break;
			case 38:
				CloseShortPositionColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 192, 192, 192));
				num2 = 31;
				goto IL_001a;
			case 13:
				ChartCpFillColor = Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue);
				BuyTradeColor = pKRGyrbLdyNmK2CbFTuV(208, 0, 191, byte.MaxValue);
				BuyTradeBorderColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(208, 0, 191, byte.MaxValue));
				num = 3;
				break;
			case 2:
				HistogramAskColor = q9AvUrbLQViuIQ0nd0qd(Color.FromArgb(byte.MaxValue, 70, 130, 180));
				HistogramValueAreaColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 128, 128, 128);
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
				{
					num = 30;
				}
				break;
			case 12:
				HistogramDeltaPlusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 46, 139, 87);
				HistogramDeltaMinusColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
				{
					num = 27;
				}
				break;
			case 37:
				BuyTriggerOrderColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 27, 84, 139));
				SellTriggerOrderColor = Color.FromArgb(byte.MaxValue, 122, 22, 42);
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 != 0)
				{
					num = 8;
				}
				break;
			case 5:
				CursorMarkerBackColor = Color.FromArgb(byte.MaxValue, 192, 192, 192);
				CursorMarkerTextColor = q9AvUrbLQViuIQ0nd0qd(pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 0, 0, 0));
				CursorLineColor = Color.FromArgb(byte.MaxValue, 192, 192, 192);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
				{
					num = 1;
				}
				break;
			case 27:
				{
					HistogramBidColor = pKRGyrbLdyNmK2CbFTuV(byte.MaxValue, 178, 34, 34);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 != 0)
					{
						num = 2;
					}
					break;
				}
				IL_001a:
				num = num2;
				break;
			}
		}
	}

	public void CopyTheme(ChartTheme theme)
	{
		int num = 25;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					ClusterNeutralBidAskColor = theme.ClusterNeutralBidAskColor;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
					{
						num2 = 21;
					}
					continue;
				case 12:
					HistogramVolumeColor = zxe1XUbLyBWlRh7647rk(theme);
					num2 = 43;
					continue;
				case 2:
					ChartSessionLineColor = grWWrXbLMW8RsSUhilmT(theme);
					CandleUpBackColor = y2YaPvbLOl0DhbG2CiDn(theme);
					CandleDownBackColor = C2NmQvbLqXLOvY4us61R(theme);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
					{
						num2 = 35;
					}
					continue;
				case 25:
					ChartBackColor = theme.ChartBackColor;
					num2 = 24;
					continue;
				case 32:
					QuoteBuyVolumeColor = theme.QuoteBuyVolumeColor;
					QuoteSellVolumeColor = Qr7hxSbLhSGJ6RcFrcrK(theme);
					num2 = 20;
					continue;
				case 30:
					PaletteColor6 = gR8H2hbe9kyvKIE4sVr5(theme);
					num2 = 17;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 != 0)
					{
						num2 = 27;
					}
					continue;
				case 28:
					HistogramCellBorderColor = theme.HistogramCellBorderColor;
					DomBackColor = theme.DomBackColor;
					DomTextColor = theme.DomTextColor;
					num2 = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
					{
						num2 = 0;
					}
					continue;
				case 40:
					IndicatorBackColor2 = theme.IndicatorBackColor2;
					IndicatorAlertBackColor = theme.IndicatorAlertBackColor;
					num2 = 18;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
					{
						num2 = 1;
					}
					continue;
				case 39:
					ClusterVolumeColor = theme.ClusterVolumeColor;
					ClusterTradesColor = YMGG09bLWJDEiEiB9xP2(theme);
					num = 4;
					break;
				case 16:
					SellTradeColor = theme.SellTradeColor;
					SellTradeBorderColor = theme.SellTradeBorderColor;
					OpenLongPositionColor = theme.OpenLongPositionColor;
					num2 = 34;
					continue;
				case 13:
					DomLineColor = theme.DomLineColor;
					DomGridColor = mC349CbLK1eq14FisCOL(theme);
					QuoteBuyColor = theme.QuoteBuyColor;
					QuoteBestBuyColor = theme.QuoteBestBuyColor;
					QuoteSellColor = theme.QuoteSellColor;
					num2 = 15;
					continue;
				case 34:
					CloseLongPositionColor = theme.CloseLongPositionColor;
					num2 = 19;
					continue;
				case 37:
					BuyTradeColor = LpGh0HbL3oweVwM5GKkv(theme);
					BuyTradeBorderColor = theme.BuyTradeBorderColor;
					num2 = 16;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
					{
						num2 = 10;
					}
					continue;
				case 15:
					QuoteBestSellColor = pKqUoqbLm1TfIfJvEnPc(theme);
					num2 = 32;
					continue;
				case 43:
					HistogramTradesColor = nU7ZrXbLZgwbSOM3OS1N(theme);
					HistogramDeltaPlusColor = theme.HistogramDeltaPlusColor;
					num2 = 42;
					continue;
				case 38:
					ClusterStrongAskColor = uWHc7abLUOSrtPHfhJ8B(theme);
					num2 = 3;
					continue;
				case 44:
					ClusterDeltaMinusColor = theme.ClusterDeltaMinusColor;
					ClusterBidColor = theme.ClusterBidColor;
					ClusterAskColor = theme.ClusterAskColor;
					ClusterStrongBidColor = dPmCDdbLtXOeq9HaQJuu(theme);
					num2 = 38;
					continue;
				case 5:
					BuyTriggerOrderColor = PMdsmqbLzitejf38Shqx(theme);
					SellTriggerOrderColor = theme.SellTriggerOrderColor;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
					{
						num2 = 1;
					}
					continue;
				case 22:
					ClusterCellBorderMaxColor = theme.ClusterCellBorderMaxColor;
					ClusterBorderColor = theme.ClusterBorderColor;
					ClusterTextColor = theme.ClusterTextColor;
					num2 = 12;
					continue;
				case 11:
					SelectionFillColor = theme.SelectionFillColor;
					return;
				case 29:
					PaletteColor4 = theme.PaletteColor4;
					PaletteColor5 = theme.PaletteColor5;
					num = 30;
					break;
				case 42:
					HistogramDeltaMinusColor = zHCIaHbLVbaLH9lyjZEU(theme);
					num2 = 33;
					continue;
				case 9:
					LineColor = theme.LineColor;
					AreaColor = theme.AreaColor;
					num2 = 14;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
					{
						num2 = 26;
					}
					continue;
				case 41:
					CursorMarkerTextColor = vlWudbbLAls9kcctmgU0(theme);
					num2 = 6;
					continue;
				case 24:
					ChartFontColor = scOHmybLR5vOwJHYE9xT(theme);
					ChartGridColor = theme.ChartGridColor;
					ChartAxisColor = asgcwZbL6SwyWlXgfHac(theme);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					QuoteSelectedColor = theme.QuoteSelectedColor;
					QuoteLimitOrderColor = theme.QuoteLimitOrderColor;
					QuoteStopOrderColor = theme.QuoteStopOrderColor;
					QuoteTriggerOrderColor = QYvj14bL79AnNbQXq144(theme);
					CursorMarkerBackColor = QSVY7TbL8s5afBsKwuoW(theme);
					num2 = 41;
					continue;
				case 35:
					CandleUpBorderColor = theme.CandleUpBorderColor;
					num2 = 23;
					continue;
				case 20:
					DomProfitColor = S9VvHkbLwRvhsBGqXvWt(theme);
					DomLossColor = theme.DomLossColor;
					num2 = 14;
					continue;
				case 1:
					LongPositionColor = theme.LongPositionColor;
					ShortPositionColor = theme.ShortPositionColor;
					PositivePnLColor = UtTCIYbe0j69qxPW2Mkh(theme);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					ChartCpFillColor = theme.ChartCpFillColor;
					num2 = 37;
					continue;
				case 27:
					PaletteColor7 = theme.PaletteColor7;
					num2 = 11;
					continue;
				case 6:
					CursorLineColor = mJHDjcbLPisn5hhvDrtH(theme);
					ChartObjectLineColor = cPViqUbLJD6jjBsSTpZJ(theme);
					ChartObjectFillColor = l3eEAWbLFpdMJjjenTvd(theme);
					ChartCpLineColor = theme.ChartCpLineColor;
					num2 = 10;
					continue;
				case 26:
					AreaLineColor = xu6ejMbLIsMNcqWfU30J(theme);
					num2 = 39;
					continue;
				case 18:
					PaletteColor1 = theme.PaletteColor1;
					PaletteColor2 = I1QeAbbefEmxGLuJuWWl(theme);
					num2 = 31;
					continue;
				case 17:
					TakeProfitColor = HJktASbe2IL8v3BEk4x5(theme);
					StopLossColor = a1QZ3cbeHOIGNomRqRuE(theme);
					IndicatorBackColor1 = theme.IndicatorBackColor1;
					num2 = 40;
					continue;
				case 31:
					PaletteColor3 = theme.PaletteColor3;
					num2 = 29;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
					{
						num2 = 14;
					}
					continue;
				case 8:
					BarDownBarColor = theme.BarDownBarColor;
					num2 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
					{
						num2 = 9;
					}
					continue;
				case 33:
					HistogramBidColor = theme.HistogramBidColor;
					HistogramAskColor = theme.HistogramAskColor;
					HistogramValueAreaColor = theme.HistogramValueAreaColor;
					HistogramMaximumColor = rL6HZObLCEOcZyjh9MAW(theme);
					HistogramTextColor = DobwM9bLrRhDWa8f1dKp(theme);
					num2 = 28;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
					{
						num2 = 6;
					}
					continue;
				case 4:
					ClusterDeltaPlusColor = theme.ClusterDeltaPlusColor;
					num2 = 44;
					continue;
				case 19:
					OpenShortPositionColor = theme.OpenShortPositionColor;
					CloseShortPositionColor = KYS2fQbLpLyXarCc84rI(theme);
					PositionLineColor = theme.PositionLineColor;
					BuyLimitOrderColor = theme.BuyLimitOrderColor;
					SellLimitOrderColor = zaFoBfbLunqKtty7EbnI(theme);
					BuyStopOrderColor = theme.BuyStopOrderColor;
					SellStopOrderColor = theme.SellStopOrderColor;
					num2 = 5;
					continue;
				case 36:
					CandleUpWickColor = theme.CandleUpWickColor;
					CandleDownWickColor = theme.CandleDownWickColor;
					BarUpBarColor = theme.BarUpBarColor;
					num2 = 8;
					continue;
				case 21:
					ClusterOpenIntPlusColor = theme.ClusterOpenIntPlusColor;
					ClusterOpenIntMinusColor = theme.ClusterOpenIntMinusColor;
					ClusterUpBarColor = theme.ClusterUpBarColor;
					ClusterDownBarColor = theme.ClusterDownBarColor;
					ClusterValueAreaColor = Oua2pEbLTCMlAvI6iR1K(theme);
					num2 = 7;
					continue;
				case 23:
					CandleDownBorderColor = theme.CandleDownBorderColor;
					num2 = 36;
					continue;
				default:
					NegativePnLColor = theme.NegativePnLColor;
					num = 17;
					break;
				case 7:
					ClusterCellBorderColor = theme.ClusterCellBorderColor;
					num2 = 22;
					continue;
				}
				break;
			}
		}
	}

	public XColor GetNextColor()
	{
		if (_colorID >= 5)
		{
			_colorID = 0;
		}
		_colorID++;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
		{
			num = 1;
		}
		switch (num)
		{
		case 1:
			switch (_colorID)
			{
			case 1:
				break;
			case 2:
				return PaletteColor2;
			case 3:
				return PaletteColor3;
			case 4:
				return PaletteColor4;
			case 5:
				return PaletteColor5;
			default:
				return q9AvUrbLQViuIQ0nd0qd(Colors.Red);
			}
			break;
		}
		return PaletteColor1;
	}

	static ChartTheme()
	{
		isScgPbsCq3d8b6mj8y8();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		_invalidColor = new XColor(1, 2, 3, 4);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		StdThemes = new List<ChartTheme>
		{
			(ChartTheme)xH9eVKbsrMZaZvIPP73n(),
			DarkDimmedTheme,
			DarkTheme,
			DarkModernTheme,
			(ChartTheme)XPqkaObsKbC7acSSd0nX(),
			(ChartTheme)CtOZrfbsmrlooJBMiXe2(),
			(ChartTheme)DD9cddbshe9PtKy9PptN(),
			DarkBlueAmberTheme,
			LightTigerTheme,
			LightNeoTheme,
			LightPurpleGrayTheme,
			LightDimmedTheme,
			LightBlueAmberTheme
		};
	}

	[NotifyPropertyChangedInvocator]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	[OnDeserializing]
	private void SetValuesOnDeserializing(StreamingContext context)
	{
		CopyTheme(DarkTheme);
		BuyTradeBorderColor = _invalidColor;
		SellTradeBorderColor = _invalidColor;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[OnDeserialized]
	private void SetValuesOnDeserialized(StreamingContext context)
	{
		if (AZAnigbLLcWn0OlKT4b6(BuyTradeBorderColor, _invalidColor))
		{
			BuyTradeBorderColor = BuyTradeColor;
		}
		if (SellTradeBorderColor == _invalidColor)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			SellTradeBorderColor = SellTradeColor;
		}
	}

	public object Clone()
	{
		ChartTheme obj = new ChartTheme
		{
			ThemeID = ThemeID
		};
		mprFRgbeGSYcxby7UYCE(obj, ThemeName);
		obj.ChartBackColor = ChartBackColor;
		obj.ChartFontColor = ChartFontColor;
		obj.ChartGridColor = ChartGridColor;
		obj.ChartAxisColor = ChartAxisColor;
		obj.ChartSessionLineColor = ChartSessionLineColor;
		wJGORRbeUG9kywserkKE(obj, CandleUpBackColor);
		T9uBw1bslOksZ3mTVsY2(obj, CandleUpBorderColor);
		obj.CandleUpWickColor = CandleUpWickColor;
		obj.CandleDownBackColor = CandleDownBackColor;
		pQ4BLybs2qq4jgRKJW8H(obj, CandleDownBorderColor);
		XZpx9qbsQiDU2munWwpg(obj, CandleDownWickColor);
		obj.BarUpBarColor = BarUpBarColor;
		obj.BarDownBarColor = BarDownBarColor;
		mcc3dobeXAlLgnv6r1ex(obj, LineColor);
		obj.AreaLineColor = AreaLineColor;
		obj.AreaColor = AreaColor;
		ASDK0Zbs17BOmhObH4eI(obj, ClusterVolumeColor);
		obj.ClusterTradesColor = ClusterTradesColor;
		cDZmIxbsDtvI8Zo0rfh0(obj, ClusterDeltaPlusColor);
		obj.ClusterDeltaMinusColor = ClusterDeltaMinusColor;
		obj.ClusterBidColor = ClusterBidColor;
		obj.ClusterAskColor = ClusterAskColor;
		obj.ClusterStrongBidColor = ClusterStrongBidColor;
		MJjw94bsNK5xANJYxMhC(obj, ClusterStrongAskColor);
		obj.ClusterNeutralBidAskColor = ClusterNeutralBidAskColor;
		obj.ClusterOpenIntPlusColor = ClusterOpenIntPlusColor;
		obj.ClusterOpenIntMinusColor = ClusterOpenIntMinusColor;
		obj.ClusterUpBarColor = ClusterUpBarColor;
		TgDbZ7bsb6NJxi5g8vL7(obj, ClusterDownBarColor);
		OMEewCbeS7qScN3xRfLb(obj, ClusterValueAreaColor);
		AMODkJbeNpu7M1sJhs6K(obj, ClusterCellBorderColor);
		obj.ClusterCellBorderMaxColor = ClusterCellBorderMaxColor;
		obj.ClusterBorderColor = ClusterBorderColor;
		obj.ClusterTextColor = ClusterTextColor;
		obj.HistogramVolumeColor = HistogramVolumeColor;
		z1UBSQbsGXKNFmCFiTj3(obj, HistogramTradesColor);
		OVWg0HbespswqoFRXdWL(obj, HistogramDeltaPlusColor);
		D84J26bsTuZHb0HfOgcZ(obj, HistogramDeltaMinusColor);
		obj.HistogramBidColor = HistogramBidColor;
		obj.HistogramAskColor = HistogramAskColor;
		obj.HistogramValueAreaColor = HistogramValueAreaColor;
		obj.HistogramMaximumColor = HistogramMaximumColor;
		obj.HistogramCellBorderColor = HistogramCellBorderColor;
		n90dVYbe7TLOPlVhDDLK(obj, HistogramTextColor);
		Amm5Z9beK58LRPOI5OoY(obj, DomBackColor);
		obj.DomTextColor = DomTextColor;
		BoQAKpbem2vci3FguR9o(obj, DomLineColor);
		L2qQ9fbeLs8ywwP2WjkR(obj, DomGridColor);
		obj.QuoteBuyColor = QuoteBuyColor;
		obj.QuoteBestBuyColor = QuoteBestBuyColor;
		JIwT4AbeMI3pHnpi4aF7(obj, QuoteSellColor);
		obj.QuoteBestSellColor = QuoteBestSellColor;
		obj.QuoteBuyVolumeColor = QuoteBuyVolumeColor;
		obj.QuoteSellVolumeColor = QuoteSellVolumeColor;
		obj.DomProfitColor = DomProfitColor;
		NDO2C9beeCMs6Jybs9X2(obj, DomLossColor);
		obj.QuoteSelectedColor = QuoteSelectedColor;
		fvRytObs6fNRDyD6qvkp(obj, QuoteLimitOrderColor);
		F0e8gKbsvn9oiwwG8YVW(obj, QuoteStopOrderColor);
		obj.QuoteTriggerOrderColor = QuoteTriggerOrderColor;
		obj.CursorMarkerBackColor = CursorMarkerBackColor;
		obj.CursorMarkerTextColor = CursorMarkerTextColor;
		obj.CursorLineColor = CursorLineColor;
		obj.ChartObjectLineColor = ChartObjectLineColor;
		DTYEWrbeiTZUCuFHeARC(obj, ChartObjectFillColor);
		obj.ChartCpLineColor = ChartCpLineColor;
		obj.ChartCpFillColor = ChartCpFillColor;
		obj.BuyTradeColor = BuyTradeColor;
		DfWx2Gbevh3GoFvsCauF(obj, BuyTradeBorderColor);
		ci71arbeOXHP3uiasXYC(obj, SellTradeColor);
		obj.SellTradeBorderColor = SellTradeBorderColor;
		obj.OpenLongPositionColor = OpenLongPositionColor;
		obj.CloseLongPositionColor = CloseLongPositionColor;
		obj.OpenShortPositionColor = OpenShortPositionColor;
		pUMBKsbe4ZBYwQQG6j37(obj, CloseShortPositionColor);
		zDdfFZbegQt50JQLgio8(obj, PositionLineColor);
		obj.BuyLimitOrderColor = BuyLimitOrderColor;
		mVuPFYbeFfT35wkAsJIQ(obj, SellLimitOrderColor);
		obj.BuyStopOrderColor = BuyStopOrderColor;
		obj.SellStopOrderColor = SellStopOrderColor;
		obj.BuyTriggerOrderColor = BuyTriggerOrderColor;
		obj.SellTriggerOrderColor = SellTriggerOrderColor;
		obj.LongPositionColor = LongPositionColor;
		obj.ShortPositionColor = ShortPositionColor;
		z8lrZWbeRYo8ROSM0q8x(obj, PositivePnLColor);
		obj.NegativePnLColor = NegativePnLColor;
		obj.TakeProfitColor = TakeProfitColor;
		HEfcGJbsa5uS2nBmhvjw(obj, StopLossColor);
		obj.IndicatorBackColor1 = _indicatorBackColor1;
		obj.IndicatorBackColor2 = _indicatorBackColor2;
		oINd8Dbsc9Uvwphbxct2(obj, IndicatorAlertBackColor);
		obj.PaletteColor1 = PaletteColor1;
		obj.PaletteColor2 = PaletteColor2;
		obj.PaletteColor3 = PaletteColor3;
		s0s6jFbeEKFjEZY9KBCp(obj, PaletteColor4);
		ljFYT9beQVArWALZ3USF(obj, PaletteColor5);
		obj.PaletteColor6 = PaletteColor6;
		LK0gXcbsRWSAo6dtxmHR(obj, PaletteColor7);
		return obj;
	}

	internal static bool afoMWnbL59325hllwMg7()
	{
		return bJey8vbL1J8txNQ3RIgD == null;
	}

	internal static ChartTheme KFsjcsbLSfQi5AvIlOcE()
	{
		return bJey8vbL1J8txNQ3RIgD;
	}

	internal static object RLEwCXbLxM74YBHmFleH(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool AZAnigbLLcWn0OlKT4b6(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static object INd4TwbLekZog9viqQ7N(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).iyK9DcB3mGw;
	}

	internal static object mlcSAXbLsTXLCy2CEVmm()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static int HHMnojbLX2lIPJYnQNbv(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static ObjectTextAlignment tyry14bLcvB6iwC1gJhB(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).ServerAlertBellAlignment;
	}

	internal static void VOkus5bLj9rXnJixeSct(object P_0, ObjectTextAlignment P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).ServerAlertBellAlignment = P_1;
	}

	internal static Color RP9iVtbLEOMkW1JfaXAf(XColor P_0)
	{
		return P_0;
	}

	internal static XColor q9AvUrbLQViuIQ0nd0qd(Color P_0)
	{
		return P_0;
	}

	internal static Color pKRGyrbLdyNmK2CbFTuV(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static object e5lg7fbLgAsYQ91k5UpZ(object P_0)
	{
		return ColorConverter.ConvertFromString((string)P_0);
	}

	internal static XColor scOHmybLR5vOwJHYE9xT(object P_0)
	{
		return ((ChartTheme)P_0).ChartFontColor;
	}

	internal static XColor asgcwZbL6SwyWlXgfHac(object P_0)
	{
		return ((ChartTheme)P_0).ChartAxisColor;
	}

	internal static XColor grWWrXbLMW8RsSUhilmT(object P_0)
	{
		return ((ChartTheme)P_0).ChartSessionLineColor;
	}

	internal static XColor y2YaPvbLOl0DhbG2CiDn(object P_0)
	{
		return ((ChartTheme)P_0).CandleUpBackColor;
	}

	internal static XColor C2NmQvbLqXLOvY4us61R(object P_0)
	{
		return ((ChartTheme)P_0).CandleDownBackColor;
	}

	internal static XColor xu6ejMbLIsMNcqWfU30J(object P_0)
	{
		return ((ChartTheme)P_0).AreaLineColor;
	}

	internal static XColor YMGG09bLWJDEiEiB9xP2(object P_0)
	{
		return ((ChartTheme)P_0).ClusterTradesColor;
	}

	internal static XColor dPmCDdbLtXOeq9HaQJuu(object P_0)
	{
		return ((ChartTheme)P_0).ClusterStrongBidColor;
	}

	internal static XColor uWHc7abLUOSrtPHfhJ8B(object P_0)
	{
		return ((ChartTheme)P_0).ClusterStrongAskColor;
	}

	internal static XColor Oua2pEbLTCMlAvI6iR1K(object P_0)
	{
		return ((ChartTheme)P_0).ClusterValueAreaColor;
	}

	internal static XColor zxe1XUbLyBWlRh7647rk(object P_0)
	{
		return ((ChartTheme)P_0).HistogramVolumeColor;
	}

	internal static XColor nU7ZrXbLZgwbSOM3OS1N(object P_0)
	{
		return ((ChartTheme)P_0).HistogramTradesColor;
	}

	internal static XColor zHCIaHbLVbaLH9lyjZEU(object P_0)
	{
		return ((ChartTheme)P_0).HistogramDeltaMinusColor;
	}

	internal static XColor rL6HZObLCEOcZyjh9MAW(object P_0)
	{
		return ((ChartTheme)P_0).HistogramMaximumColor;
	}

	internal static XColor DobwM9bLrRhDWa8f1dKp(object P_0)
	{
		return ((ChartTheme)P_0).HistogramTextColor;
	}

	internal static XColor mC349CbLK1eq14FisCOL(object P_0)
	{
		return ((ChartTheme)P_0).DomGridColor;
	}

	internal static XColor pKqUoqbLm1TfIfJvEnPc(object P_0)
	{
		return ((ChartTheme)P_0).QuoteBestSellColor;
	}

	internal static XColor Qr7hxSbLhSGJ6RcFrcrK(object P_0)
	{
		return ((ChartTheme)P_0).QuoteSellVolumeColor;
	}

	internal static XColor S9VvHkbLwRvhsBGqXvWt(object P_0)
	{
		return ((ChartTheme)P_0).DomProfitColor;
	}

	internal static XColor QYvj14bL79AnNbQXq144(object P_0)
	{
		return ((ChartTheme)P_0).QuoteTriggerOrderColor;
	}

	internal static XColor QSVY7TbL8s5afBsKwuoW(object P_0)
	{
		return ((ChartTheme)P_0).CursorMarkerBackColor;
	}

	internal static XColor vlWudbbLAls9kcctmgU0(object P_0)
	{
		return ((ChartTheme)P_0).CursorMarkerTextColor;
	}

	internal static XColor mJHDjcbLPisn5hhvDrtH(object P_0)
	{
		return ((ChartTheme)P_0).CursorLineColor;
	}

	internal static XColor cPViqUbLJD6jjBsSTpZJ(object P_0)
	{
		return ((ChartTheme)P_0).ChartObjectLineColor;
	}

	internal static XColor l3eEAWbLFpdMJjjenTvd(object P_0)
	{
		return ((ChartTheme)P_0).ChartObjectFillColor;
	}

	internal static XColor LpGh0HbL3oweVwM5GKkv(object P_0)
	{
		return ((ChartTheme)P_0).BuyTradeColor;
	}

	internal static XColor KYS2fQbLpLyXarCc84rI(object P_0)
	{
		return ((ChartTheme)P_0).CloseShortPositionColor;
	}

	internal static XColor zaFoBfbLunqKtty7EbnI(object P_0)
	{
		return ((ChartTheme)P_0).SellLimitOrderColor;
	}

	internal static XColor PMdsmqbLzitejf38Shqx(object P_0)
	{
		return ((ChartTheme)P_0).BuyTriggerOrderColor;
	}

	internal static XColor UtTCIYbe0j69qxPW2Mkh(object P_0)
	{
		return ((ChartTheme)P_0).PositivePnLColor;
	}

	internal static XColor HJktASbe2IL8v3BEk4x5(object P_0)
	{
		return ((ChartTheme)P_0).TakeProfitColor;
	}

	internal static XColor a1QZ3cbeHOIGNomRqRuE(object P_0)
	{
		return ((ChartTheme)P_0).StopLossColor;
	}

	internal static XColor I1QeAbbefEmxGLuJuWWl(object P_0)
	{
		return ((ChartTheme)P_0).PaletteColor2;
	}

	internal static XColor gR8H2hbe9kyvKIE4sVr5(object P_0)
	{
		return ((ChartTheme)P_0).PaletteColor6;
	}

	internal static void bwZDwAbengRS1jIGCNh7(object P_0, object P_1)
	{
		((ChartTheme)P_0).ThemeID = (string)P_1;
	}

	internal static void mprFRgbeGSYcxby7UYCE(object P_0, object P_1)
	{
		((ChartTheme)P_0).ThemeName = (string)P_1;
	}

	internal static void nDuGk2beYA6yVFZgeWw2(object P_0, XColor value)
	{
		((ChartTheme)P_0).AreaColor = value;
	}

	internal static void dOhnQGbeo1NMhWme782e(object P_0, XColor value)
	{
		((ChartTheme)P_0).BuyLimitOrderColor = value;
	}

	internal static void DfWx2Gbevh3GoFvsCauF(object P_0, XColor value)
	{
		((ChartTheme)P_0).BuyTradeBorderColor = value;
	}

	internal static void movDIqbeBLqWP4reBcqe(object P_0, XColor value)
	{
		((ChartTheme)P_0).ChartBackColor = value;
	}

	internal static void JSZWRJbeaS5cGfjFiJHU(object P_0, XColor value)
	{
		((ChartTheme)P_0).ChartCpLineColor = value;
	}

	internal static void DTYEWrbeiTZUCuFHeARC(object P_0, XColor value)
	{
		((ChartTheme)P_0).ChartObjectFillColor = value;
	}

	internal static void oLl3C3belLsArWusgsLR(object P_0, XColor value)
	{
		((ChartTheme)P_0).ChartSessionLineColor = value;
	}

	internal static void pUMBKsbe4ZBYwQQG6j37(object P_0, XColor value)
	{
		((ChartTheme)P_0).CloseShortPositionColor = value;
	}

	internal static void l8UZQBbeDtXcT0y4Rx5K(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterBidColor = value;
	}

	internal static void bWgWl0beb2g52LjGq9Kf(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterBorderColor = value;
	}

	internal static void AMODkJbeNpu7M1sJhs6K(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterCellBorderColor = value;
	}

	internal static void xvFxjsbekMQovg4S4X1D(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterNeutralBidAskColor = value;
	}

	internal static void XUUB0Fbe13TmyD8MFCrx(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterOpenIntMinusColor = value;
	}

	internal static void OOQg4Ebe5mj40b8x0mQ8(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterTradesColor = value;
	}

	internal static void OMEewCbeS7qScN3xRfLb(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterValueAreaColor = value;
	}

	internal static void zKTbWSbex6B7EEuO1A9Q(object P_0, XColor value)
	{
		((ChartTheme)P_0).CursorMarkerTextColor = value;
	}

	internal static void L2qQ9fbeLs8ywwP2WjkR(object P_0, XColor value)
	{
		((ChartTheme)P_0).DomGridColor = value;
	}

	internal static void NDO2C9beeCMs6Jybs9X2(object P_0, XColor value)
	{
		((ChartTheme)P_0).DomLossColor = value;
	}

	internal static void OVWg0HbespswqoFRXdWL(object P_0, XColor value)
	{
		((ChartTheme)P_0).HistogramDeltaPlusColor = value;
	}

	internal static void mcc3dobeXAlLgnv6r1ex(object P_0, XColor value)
	{
		((ChartTheme)P_0).LineColor = value;
	}

	internal static void RC7caqbecDUGo3iiqsa1(object P_0, XColor value)
	{
		((ChartTheme)P_0).OpenShortPositionColor = value;
	}

	internal static void PevY0nbej1BI9G6ZH0dL(object P_0, XColor value)
	{
		((ChartTheme)P_0).PaletteColor2 = value;
	}

	internal static void s0s6jFbeEKFjEZY9KBCp(object P_0, XColor value)
	{
		((ChartTheme)P_0).PaletteColor4 = value;
	}

	internal static void ljFYT9beQVArWALZ3USF(object P_0, XColor value)
	{
		((ChartTheme)P_0).PaletteColor5 = value;
	}

	internal static void iqxNfRbedA8wBx1XH1WJ(object P_0, XColor value)
	{
		((ChartTheme)P_0).PaletteColor6 = value;
	}

	internal static void zDdfFZbegQt50JQLgio8(object P_0, XColor value)
	{
		((ChartTheme)P_0).PositionLineColor = value;
	}

	internal static void z8lrZWbeRYo8ROSM0q8x(object P_0, XColor value)
	{
		((ChartTheme)P_0).PositivePnLColor = value;
	}

	internal static void vX5c1Zbe6fLVrPy3lwhU(object P_0, XColor value)
	{
		((ChartTheme)P_0).QuoteSelectedColor = value;
	}

	internal static void JIwT4AbeMI3pHnpi4aF7(object P_0, XColor value)
	{
		((ChartTheme)P_0).QuoteSellColor = value;
	}

	internal static void ci71arbeOXHP3uiasXYC(object P_0, XColor value)
	{
		((ChartTheme)P_0).SellTradeColor = value;
	}

	internal static void q6A733beqM7B6XguST6u(object P_0, XColor value)
	{
		((ChartTheme)P_0).TakeProfitColor = value;
	}

	internal static object stCCu3beI0TYOFxC9RUB()
	{
		return Resources.ChartThemeDarkNeo;
	}

	internal static void tns3gSbeWcnybZoCqvQX(object P_0, XColor value)
	{
		((ChartTheme)P_0).BarDownBarColor = value;
	}

	internal static void XIXKLmbetkNW2HjFb4u8(object P_0, XColor value)
	{
		((ChartTheme)P_0).BuyTriggerOrderColor = value;
	}

	internal static void wJGORRbeUG9kywserkKE(object P_0, XColor value)
	{
		((ChartTheme)P_0).CandleUpBackColor = value;
	}

	internal static void JX8E20beT5K54i0JhdUH(object P_0, XColor value)
	{
		((ChartTheme)P_0).ChartAxisColor = value;
	}

	internal static void diBt5DbeykHN17pg1X4D(object P_0, XColor value)
	{
		((ChartTheme)P_0).ChartCpFillColor = value;
	}

	internal static void cJA9q3beZlTXOiBWyRTo(object P_0, XColor value)
	{
		((ChartTheme)P_0).CloseLongPositionColor = value;
	}

	internal static void cmxvJcbeVZAYbS3tWLx8(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterCellBorderMaxColor = value;
	}

	internal static void o8irAibeCInM8TZMdHWY(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterDeltaMinusColor = value;
	}

	internal static void dvuoqFberKGfBLA9PoXH(object P_0, XColor value)
	{
		((ChartTheme)P_0).CursorLineColor = value;
	}

	internal static void Amm5Z9beK58LRPOI5OoY(object P_0, XColor value)
	{
		((ChartTheme)P_0).DomBackColor = value;
	}

	internal static void BoQAKpbem2vci3FguR9o(object P_0, XColor value)
	{
		((ChartTheme)P_0).DomLineColor = value;
	}

	internal static void jTtKJabehwMsxcbMQ7Od(object P_0, XColor value)
	{
		((ChartTheme)P_0).HistogramCellBorderColor = value;
	}

	internal static void gN5aQUbew7FiIPGpOsx9(object P_0, XColor value)
	{
		((ChartTheme)P_0).HistogramMaximumColor = value;
	}

	internal static void n90dVYbe7TLOPlVhDDLK(object P_0, XColor value)
	{
		((ChartTheme)P_0).HistogramTextColor = value;
	}

	internal static void oKSUxYbe8PHs1X1Vg0Om(object P_0, XColor value)
	{
		((ChartTheme)P_0).HistogramValueAreaColor = value;
	}

	internal static void BSxkagbeAFMeacbxEht0(object P_0, XColor value)
	{
		((ChartTheme)P_0).IndicatorBackColor2 = value;
	}

	internal static void CtpBpSbePMag6frum2ym(object P_0, XColor value)
	{
		((ChartTheme)P_0).PaletteColor3 = value;
	}

	internal static void eDZ5aWbeJtRMWuFX2OCL(object P_0, XColor value)
	{
		((ChartTheme)P_0).QuoteTriggerOrderColor = value;
	}

	internal static void mVuPFYbeFfT35wkAsJIQ(object P_0, XColor value)
	{
		((ChartTheme)P_0).SellLimitOrderColor = value;
	}

	internal static void gMMjQxbe3abXQEhnAQ5n(object P_0, XColor value)
	{
		((ChartTheme)P_0).SellTradeBorderColor = value;
	}

	internal static void HH3FPxbepYU0RyVIiXHE(object P_0, XColor value)
	{
		((ChartTheme)P_0).SellTriggerOrderColor = value;
	}

	internal static void j7RL5sbeujpDYe3RR2Mb(object P_0, XColor value)
	{
		((ChartTheme)P_0).BuyStopOrderColor = value;
	}

	internal static void YEQ6GpbezEuU0s8HhYP0(object P_0, XColor value)
	{
		((ChartTheme)P_0).BuyTradeColor = value;
	}

	internal static void JRvaxWbs0Isbym17F8Q2(object P_0, XColor value)
	{
		((ChartTheme)P_0).CandleDownBackColor = value;
	}

	internal static void pQ4BLybs2qq4jgRKJW8H(object P_0, XColor value)
	{
		((ChartTheme)P_0).CandleDownBorderColor = value;
	}

	internal static void ANg3DKbsHOtbFhc01cLZ(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterAskColor = value;
	}

	internal static void fUmVP9bsfk7WGIiPLOyV(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterTextColor = value;
	}

	internal static void Yhb5qKbs9HWA3xoQ1Hjs(object P_0, XColor value)
	{
		((ChartTheme)P_0).DomProfitColor = value;
	}

	internal static void kdGN5DbsnYgcagWhgTv8(object P_0, XColor value)
	{
		((ChartTheme)P_0).HistogramBidColor = value;
	}

	internal static void z1UBSQbsGXKNFmCFiTj3(object P_0, XColor value)
	{
		((ChartTheme)P_0).HistogramTradesColor = value;
	}

	internal static void mRjr8cbsYIrL5TP1UAmw(object P_0, XColor value)
	{
		((ChartTheme)P_0).IndicatorBackColor1 = value;
	}

	internal static void jMr1wVbsopCUn42VWOJM(object P_0, XColor value)
	{
		((ChartTheme)P_0).PaletteColor1 = value;
	}

	internal static void F0e8gKbsvn9oiwwG8YVW(object P_0, XColor value)
	{
		((ChartTheme)P_0).QuoteStopOrderColor = value;
	}

	internal static void GFqREJbsBhTliLWLx9ul(object P_0, XColor value)
	{
		((ChartTheme)P_0).ShortPositionColor = value;
	}

	internal static void HEfcGJbsa5uS2nBmhvjw(object P_0, XColor value)
	{
		((ChartTheme)P_0).StopLossColor = value;
	}

	internal static void uWHaA5bsi7sKiHNjNga2(object P_0, XColor value)
	{
		((ChartTheme)P_0).AreaLineColor = value;
	}

	internal static void T9uBw1bslOksZ3mTVsY2(object P_0, XColor value)
	{
		((ChartTheme)P_0).CandleUpBorderColor = value;
	}

	internal static void F3X2Wobs4O8PmmF2mYPY(object P_0, XColor value)
	{
		((ChartTheme)P_0).ChartFontColor = value;
	}

	internal static void cDZmIxbsDtvI8Zo0rfh0(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterDeltaPlusColor = value;
	}

	internal static void TgDbZ7bsb6NJxi5g8vL7(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterDownBarColor = value;
	}

	internal static void MJjw94bsNK5xANJYxMhC(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterStrongAskColor = value;
	}

	internal static void uKknHlbskRkATkxUQH37(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterUpBarColor = value;
	}

	internal static void ASDK0Zbs17BOmhObH4eI(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterVolumeColor = value;
	}

	internal static void l1ZVTNbs53j1AZcsI8eK(object P_0, XColor value)
	{
		((ChartTheme)P_0).HistogramVolumeColor = value;
	}

	internal static void yhwItFbsS87sG5V3S9uc(object P_0, XColor value)
	{
		((ChartTheme)P_0).QuoteBestBuyColor = value;
	}

	internal static void dGOsOmbsxLlqBFNGBBOX(object P_0, XColor value)
	{
		((ChartTheme)P_0).QuoteBestSellColor = value;
	}

	internal static void jlO8StbsLE8TJUWfquZx(object P_0, XColor value)
	{
		((ChartTheme)P_0).QuoteBuyColor = value;
	}

	internal static void SQxrYmbsekoq9EpPCu8p(object P_0, XColor value)
	{
		((ChartTheme)P_0).SellStopOrderColor = value;
	}

	internal static void CVpPt7bss2mCqw60X9Hs(object P_0, XColor value)
	{
		((ChartTheme)P_0).CursorMarkerBackColor = value;
	}

	internal static void gILH1ybsXrtZo4w3pP4h(object P_0, XColor value)
	{
		((ChartTheme)P_0).DomTextColor = value;
	}

	internal static void oINd8Dbsc9Uvwphbxct2(object P_0, XColor value)
	{
		((ChartTheme)P_0).IndicatorAlertBackColor = value;
	}

	internal static void xYHTstbsjE0HY1iZwAS1(object P_0, XColor value)
	{
		((ChartTheme)P_0).NegativePnLColor = value;
	}

	internal static void k9e04UbsE5LqiI39nqWt(object P_0, XColor value)
	{
		((ChartTheme)P_0).BarUpBarColor = value;
	}

	internal static void XZpx9qbsQiDU2munWwpg(object P_0, XColor value)
	{
		((ChartTheme)P_0).CandleDownWickColor = value;
	}

	internal static void GAcS6Vbsddx0P1HylaXk(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterOpenIntPlusColor = value;
	}

	internal static void Kq91JRbsg1od5nEARom8(object P_0, XColor value)
	{
		((ChartTheme)P_0).OpenLongPositionColor = value;
	}

	internal static void LK0gXcbsRWSAo6dtxmHR(object P_0, XColor value)
	{
		((ChartTheme)P_0).PaletteColor7 = value;
	}

	internal static void fvRytObs6fNRDyD6qvkp(object P_0, XColor value)
	{
		((ChartTheme)P_0).QuoteLimitOrderColor = value;
	}

	internal static void y4Kl6FbsMH4eqqmVE96V(object P_0, XColor value)
	{
		((ChartTheme)P_0).QuoteSellVolumeColor = value;
	}

	internal static void lBMj6QbsOI9LIbYCmiSE(object P_0, XColor value)
	{
		((ChartTheme)P_0).CandleUpWickColor = value;
	}

	internal static void FgPJ7pbsqpiA3mm1dYbi(object P_0, XColor value)
	{
		((ChartTheme)P_0).LongPositionColor = value;
	}

	internal static void SduekjbsIB9MvHpW910V(object P_0, XColor value)
	{
		((ChartTheme)P_0).ChartGridColor = value;
	}

	internal static void kUrmWAbsWOOnwy6hhtUj(object P_0, XColor value)
	{
		((ChartTheme)P_0).ChartObjectLineColor = value;
	}

	internal static void R6ZnlabstSGcgtcrK42q(object P_0, XColor value)
	{
		((ChartTheme)P_0).QuoteBuyVolumeColor = value;
	}

	internal static void Ec7RNObsUw6MOwApl1f4(object P_0, XColor value)
	{
		((ChartTheme)P_0).ClusterStrongBidColor = value;
	}

	internal static void D84J26bsTuZHb0HfOgcZ(object P_0, XColor value)
	{
		((ChartTheme)P_0).HistogramDeltaMinusColor = value;
	}

	internal static void ufKVo9bsytlIC1iPGPXp(object P_0, XColor value)
	{
		((ChartTheme)P_0).SelectionFillColor = value;
	}

	internal static object NdFCpcbsZLGOpIlXsK2M()
	{
		return Resources.ChartThemeDarkModern;
	}

	internal static void pIbWf3bsVhcMf9cyhbSI(object P_0, XColor value)
	{
		((ChartTheme)P_0).HistogramAskColor = value;
	}

	internal static void isScgPbsCq3d8b6mj8y8()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object xH9eVKbsrMZaZvIPP73n()
	{
		return DarkNeoTheme;
	}

	internal static object XPqkaObsKbC7acSSd0nX()
	{
		return LightTheme;
	}

	internal static object CtOZrfbsmrlooJBMiXe2()
	{
		return DarkTigerTheme;
	}

	internal static object DD9cddbshe9PtKy9PptN()
	{
		return DarkPurpleGrayTheme;
	}
}
