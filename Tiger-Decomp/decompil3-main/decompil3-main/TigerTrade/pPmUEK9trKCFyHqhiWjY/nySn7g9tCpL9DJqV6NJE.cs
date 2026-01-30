using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Windows;
using aRm0YY9tVc5T4nsWvU5y;
using C7UvAf9ri2R97XEwp7o2;
using ECOEgqlSad8NUJZ2Dr9n;
using hTabtpHZ5rp1Am1FvYmp;
using jZcH719tygSsN8nhQEap;
using LIZPJWHZEY2VKUjdIYiN;
using LPq3llG3QX4HMCBL7b1Q;
using MIA3eC2ZXsuRyAB0mjn;
using NsWD4W9miMxRbFU3fsu9;
using p9TTcsHCw7Nx8eLJhObh;
using r5KQolHZv1kdRuFVTnUq;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.Sources;
using TigerTrade.Chart.Settings;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using UMI2GBGJ3kloSb47d3eV;

namespace pPmUEK9trKCFyHqhiWjY;

[Indicator("VolatilityTable", "VolatilityTable", true, Type = typeof(nySn7g9tCpL9DJqV6NJE))]
[DataContract(Name = "VolatilityTableIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class nySn7g9tCpL9DJqV6NJE : fi0dX39rarBK9dp2dGQR
{
	[Serializable]
	[CompilerGenerated]
	private sealed class PjacLrnpZcYqC3S8aijb
	{
		public static readonly PjacLrnpZcYqC3S8aijb GlhnpCiO16b;

		public static Func<OjH2QVHZoARxtkRLMBCI, double> QgCnpr5e8hg;

		private static PjacLrnpZcYqC3S8aijb x6Yt1dNtiJfnM38G6ejy;

		static PjacLrnpZcYqC3S8aijb()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			x6xjCsNtDh8FY9mxlm3t();
			GlhnpCiO16b = new PjacLrnpZcYqC3S8aijb();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public PjacLrnpZcYqC3S8aijb()
		{
			x6xjCsNtDh8FY9mxlm3t();
			base._002Ector();
		}

		internal double fpCnpVfNQkG(OjH2QVHZoARxtkRLMBCI b)
		{
			return b.Close;
		}

		internal static void x6xjCsNtDh8FY9mxlm3t()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool U97y1wNtlcxNBwVgUkxF()
		{
			return x6Yt1dNtiJfnM38G6ejy == null;
		}

		internal static PjacLrnpZcYqC3S8aijb MMC5kgNt4Yqp17dDNjP9()
		{
			return x6Yt1dNtiJfnM38G6ejy;
		}
	}

	private static readonly Point Gef9UTKDuqN;

	private static readonly Point UAF9UyMxeHb;

	private ypqMIv9maFM0tRwF0xMh jCB9UC7ZYVU;

	private decimal fN49UrGeaGh;

	private decimal Hsg9UK5yanL;

	private double QC49UmXIpF9;

	private bool qH79UhtpURN;

	private double rJN9UwDgHkQ;

	private bool sbZ9U7W5NgW;

	private object boG9U8FxkV4;

	private bool R0x9UAtKAXX;

	private int EwH9UPkJbBX;

	private int hM59UJ0AlWD;

	private int XWF9UFHPZ3G;

	private IndicatorMaType SaW9U3M6jaL;

	private IndicatorSourceBase VsW9Upn286V;

	private Symbol EBw9UuUGJJE;

	private int haA9UzjCmKo;

	private long? zTy9T0bwAPn;

	private long? YsX9T2SBL9Z;

	private decimal? CUy9THgsv7q;

	private decimal? b7j9TfUgEWe;

	private bool CRB9T9wHFGg;

	private XBrush Sis9TnGcY4W;

	private XColor ukI9TGLQoZu;

	private XBrush R5K9TYXLR4M;

	private XColor XKD9To6Jqf3;

	private XBrush Qi89TvBlWwx;

	private XColor Yad9TBsTmgy;

	private XBrush ust9TaSY5vI;

	private XColor jL59TiEU72h;

	private XBrush dxr9TlyMydm;

	private XColor Btq9T4hXIbC;

	private bool ieA9TD28TE1;

	private bool STi9TbJKYw4;

	private bool SRd9TNwFCb3;

	private bool WNg9TkuC3fr;

	private IA4TWm9tT0N2p8p89AZn p6H9T11boSu;

	private double gEH9T5tdHqr;

	private NRk0Y59tZN0iHuhOcdCq gE29TSbrdGc;

	private double bWX9Tx7fw46;

	internal static nySn7g9tCpL9DJqV6NJE tkaF12bI2kEcAWIibqSE;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsAverageVolume")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsAvgVolumePeriod")]
	[DefaultValue(30)]
	[DataMember(Name = "AvgVolumePeriod")]
	public int AvgVolumePeriod
	{
		get
		{
			return EwH9UPkJbBX;
		}
		set
		{
			num = Math.Max(0, Math.Min(1000, num));
			if (num == EwH9UPkJbBX)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
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
				EwH9UPkJbBX = num;
				JrispYbI9fcSutQhmGDr(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x50C1C840 ^ 0x50C5AF9C));
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsNATR")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsNatrPeriod")]
	[DataMember(Name = "NatrPeriod")]
	[DefaultValue(14)]
	public int NatrPeriod
	{
		get
		{
			return hM59UJ0AlWD;
		}
		set
		{
			num = Math.Max(0, ArybsFbIn1F1NgUKgDeF(1000, num));
			if (num == hM59UJ0AlWD)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
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
				hM59UJ0AlWD = num;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C38D18));
			}
		}
	}

	[DataMember(Name = "NatrShift")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsNATR")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsNatrShift")]
	public int NatrShift
	{
		get
		{
			return XWF9UFHPZ3G;
		}
		set
		{
			num = Math.Max(0, Math.Min(1000, num));
			if (num != XWF9UFHPZ3G)
			{
				XWF9UFHPZ3G = num;
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2C8374E4 ^ 0x2C871CF2));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsNatrMaType")]
	[DefaultValue(IndicatorMaType.EMA)]
	[DataMember(Name = "NatrMaType")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsNATR")]
	public IndicatorMaType NatrMaType
	{
		get
		{
			return SaW9U3M6jaL;
		}
		set
		{
			if (indicatorMaType != SaW9U3M6jaL)
			{
				SaW9U3M6jaL = indicatorMaType;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x4293ABC7));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
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

	[DataMember(Name = "NatrSource")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsNatrSource")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsNATR")]
	public IndicatorSourceBase NatrSource
	{
		get
		{
			return VsW9Upn286V ?? (VsW9Upn286V = new StockSource());
		}
		set
		{
			if (indicatorSourceBase != VsW9Upn286V)
			{
				VsW9Upn286V = indicatorSourceBase;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29447010));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsCorrelationPeriod")]
	[DataMember(Name = "CorrelationPeriod")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsCorrelation")]
	[DefaultValue(20)]
	public int CorrelationPeriod
	{
		get
		{
			return haA9UzjCmKo;
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
					if (num3 != haA9UzjCmKo)
					{
						haA9UzjCmKo = num3;
						OnPropertyChanged((string)iwbtNBbIGGRpoQMEvTgQ(0x684F243E ^ 0x684B4C62));
					}
					return;
				case 1:
					num3 = Math.Max(0, ArybsFbIn1F1NgUKgDeF(1000, num3));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsDailyVolumeThr")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsAlerts")]
	[DataMember(Name = "DailyVolumeThr")]
	public long? DailyVolumeThr
	{
		get
		{
			return zTy9T0bwAPn;
		}
		set
		{
			if (num.HasValue)
			{
				num = Math.Max(0L, num.Value);
			}
			if (num != zTy9T0bwAPn)
			{
				zTy9T0bwAPn = num;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7DB10E6E ^ 0x7DB566EC));
			}
		}
	}

	[DataMember(Name = "AverageVolumeThr")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsAlerts")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsAverageVolumeThr")]
	public long? AverageVolumeThr
	{
		get
		{
			return YsX9T2SBL9Z;
		}
		set
		{
			if (num.HasValue)
			{
				num = Math.Max(0L, num.Value);
			}
			if (num != YsX9T2SBL9Z)
			{
				YsX9T2SBL9Z = num;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2002318893 ^ -2002558607));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsNatrThr")]
	[DataMember(Name = "NatrThr")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsAlerts")]
	public decimal? NatrThr
	{
		get
		{
			return CUy9THgsv7q;
		}
		set
		{
			if (num.HasValue)
			{
				num = Math.Max(0m, Math.Min(1000m, num.Value));
			}
			if (!(num == CUy9THgsv7q))
			{
				CUy9THgsv7q = num;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E29932B));
			}
		}
	}

	[DataMember(Name = "CorrelationThr")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsCorrelationThr")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsAlerts")]
	public decimal? CorrelationThr
	{
		get
		{
			return b7j9TfUgEWe;
		}
		set
		{
			if (num.HasValue)
			{
				num = Math.Max(-1m, Math.Min(1m, num.Value));
			}
			if (!(num == b7j9TfUgEWe))
			{
				b7j9TfUgEWe = num;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1324946069));
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "MinimizeValues")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsMinimizeValues")]
	public bool MinimizeValues
	{
		get
		{
			return CRB9T9wHFGg;
		}
		set
		{
			if (flag != CRB9T9wHFGg)
			{
				CRB9T9wHFGg = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)iwbtNBbIGGRpoQMEvTgQ(-165474503 ^ -165208671));
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "BackColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsVolTblBackColor")]
	public XColor BackColor
	{
		get
		{
			return ukI9TGLQoZu;
		}
		set
		{
			if (!Yn5TjGbIYVNsBBZ5YtkU(xColor, ukI9TGLQoZu))
			{
				ukI9TGLQoZu = xColor;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				Sis9TnGcY4W = new XBrush(ukI9TGLQoZu);
				JrispYbI9fcSutQhmGDr(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1878925204));
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsVolTblBackColor2")]
	[DataMember(Name = "BackColor2")]
	public XColor BackColor2
	{
		get
		{
			return XKD9To6Jqf3;
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
					OnPropertyChanged((string)iwbtNBbIGGRpoQMEvTgQ(0x2D313048 ^ 0x2D3558B0));
					return;
				case 2:
					if (!(xColor == XKD9To6Jqf3))
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
						{
							num2 = 1;
						}
						break;
					}
					return;
				case 1:
					XKD9To6Jqf3 = xColor;
					R5K9TYXLR4M = new XBrush(XKD9To6Jqf3);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "TextColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsVolTblTextColor")]
	public XColor TextColor
	{
		get
		{
			return Yad9TBsTmgy;
		}
		set
		{
			if (!Yn5TjGbIYVNsBBZ5YtkU(xColor, Yad9TBsTmgy))
			{
				Yad9TBsTmgy = xColor;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return;
				}
				Qi89TvBlWwx = new XBrush(Yad9TBsTmgy);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2056710528 ^ -2056682176));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsAlertBackColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "AlertBackColor")]
	public XColor AlertBackColor
	{
		get
		{
			return jL59TiEU72h;
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
					if (!(xColor == jL59TiEU72h))
					{
						jL59TiEU72h = xColor;
						ust9TaSY5vI = new XBrush(jL59TiEU72h);
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1AB79299 ^ 0x1AB3FB89));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "AlertTextColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsAlertTextColor")]
	public XColor AlertTextColor
	{
		get
		{
			return Btq9T4hXIbC;
		}
		set
		{
			if (!(xColor == Btq9T4hXIbC))
			{
				Btq9T4hXIbC = xColor;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return;
				}
				dxr9TlyMydm = new XBrush(Btq9T4hXIbC);
				OnPropertyChanged((string)iwbtNBbIGGRpoQMEvTgQ(0x34407BB ^ 0x3406E8B));
			}
		}
	}

	[DataMember(Name = "ShowDailyVolume")]
	[DefaultValue(true)]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsShowDailyVolume")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	public bool ShowDailyVolume
	{
		get
		{
			return ieA9TD28TE1;
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
					if (flag != ieA9TD28TE1)
					{
						ieA9TD28TE1 = flag;
						OnPropertyChanged((string)iwbtNBbIGGRpoQMEvTgQ(-2123795572 ^ -2123556132));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "ShowAverageVolume")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsShowAverageVolume")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DefaultValue(true)]
	public bool ShowAverageVolume
	{
		get
		{
			return STi9TbJKYw4;
		}
		set
		{
			if (flag != STi9TbJKYw4)
			{
				STi9TbJKYw4 = flag;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x60620FC1 ^ 0x606666B3));
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

	[DefaultValue(true)]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsShowNATR")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "ShowNATR")]
	public bool ShowNATR
	{
		get
		{
			return SRd9TNwFCb3;
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
					if (flag == SRd9TNwFCb3)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
						{
							num2 = 0;
						}
						break;
					}
					SRd9TNwFCb3 = flag;
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x12620268 ^ 0x12666BF0));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsShowCorrelation")]
	[DefaultValue(true)]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "ShowCorrelation")]
	public bool ShowCorrelation
	{
		get
		{
			return WNg9TkuC3fr;
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
					if (flag == WNg9TkuC3fr)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
						{
							num2 = 0;
						}
						break;
					}
					WNg9TkuC3fr = flag;
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1087080834 ^ -1087365166));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DefaultValue(IA4TWm9tT0N2p8p89AZn.Right)]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsHorizontalAlignment")]
	[DataMember(Name = "TableHorizontalAlignment")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	public IA4TWm9tT0N2p8p89AZn TableHorizontalAlignment
	{
		get
		{
			return p6H9T11boSu;
		}
		set
		{
			if (iA4TWm9tT0N2p8p89AZn != p6H9T11boSu)
			{
				p6H9T11boSu = iA4TWm9tT0N2p8p89AZn;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2074141628 ^ -2074380918));
			}
		}
	}

	[DefaultValue(10)]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsHorizontalIndent")]
	[DataMember(Name = "HorizontalIndent")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	public double HorizontalIndent
	{
		get
		{
			return gEH9T5tdHqr;
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
					if (num3 == gEH9T5tdHqr)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c != 0)
						{
							num2 = 0;
						}
						break;
					}
					gEH9T5tdHqr = num3;
					JrispYbI9fcSutQhmGDr(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-490987856 ^ -491227982));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "TableVerticalAlignment")]
	[DefaultValue(NRk0Y59tZN0iHuhOcdCq.Bottom)]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsVerticalAlignment")]
	public NRk0Y59tZN0iHuhOcdCq TableVerticalAlignment
	{
		get
		{
			return gE29TSbrdGc;
		}
		set
		{
			if (nRk0Y59tZN0iHuhOcdCq != gE29TSbrdGc)
			{
				gE29TSbrdGc = nRk0Y59tZN0iHuhOcdCq;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1606927328 ^ -1606658554));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 != 0)
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

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "VerticalIndent")]
	[DefaultValue(10)]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsVerticalIndent")]
	public double VerticalIndent
	{
		get
		{
			return bWX9Tx7fw46;
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
					if (num3 != bWX9Tx7fw46)
					{
						bWX9Tx7fw46 = num3;
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-690510723 ^ -690762197));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[SpecialName]
	private double cgR9t8MFv3k()
	{
		return rJN9UwDgHkQ;
	}

	[SpecialName]
	private void EEj9tA2NJGI(double P_0)
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
				if (rJN9UwDgHkQ == P_0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
					{
						num2 = 0;
					}
					break;
				}
				rJN9UwDgHkQ = P_0;
				qH79UhtpURN = true;
				return;
			case 0:
				return;
			}
		}
	}

	public nySn7g9tCpL9DJqV6NJE()
	{
		gBnHXSbIojYJVAh9IMWo();
		boG9U8FxkV4 = new object();
		base._002Ector();
		int num = 4;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				AvgVolumePeriod = 30;
				NatrPeriod = 14;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
				{
					num = 1;
				}
				break;
			case 3:
				ShowDailyVolume = true;
				ShowAverageVolume = true;
				ShowNATR = true;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
				{
					num = 0;
				}
				break;
			case 1:
			{
				CorrelationPeriod = 20;
				int num2 = 6;
				num = num2;
				break;
			}
			case 6:
				TableVerticalAlignment = NRk0Y59tZN0iHuhOcdCq.Bottom;
				num = 5;
				break;
			case 2:
				HorizontalIndent = 10.0;
				VerticalIndent = 10.0;
				MinimizeValues = true;
				NatrMaType = IndicatorMaType.EMA;
				bhINVubIvCVXmHKFHk5U(this, IndicatorCalculation.OnBarClose);
				num = 3;
				break;
			case 5:
				TableHorizontalAlignment = IA4TWm9tT0N2p8p89AZn.Right;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
				{
					num = 2;
				}
				break;
			default:
				ShowCorrelation = true;
				return;
			}
		}
	}

	private void d7V9tK6gF47(EventOwner<SecurityEvent> P_0)
	{
		if (ShowDailyVolume && base.DataProvider?.Symbol?.Code == P_0.Value.Symbol.ID)
		{
			fN49UrGeaGh = P_0.Value.Value.GetValueOrDefault();
		}
	}

	private void o7r9tm7L0rO(q7ohYNHZ1Db3CcCWYhdv P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (base.DataProvider != null && CxOOj4bIaX9oIayXeOPP(rIYvdDbIBgaX0X1uljlU(base.DataProvider), P_0.waFHZS0rmmF))
				{
					Execute();
				}
				return;
			case 3:
				if (EBw9UuUGJJE != P_0.Symbol)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				if (ShowCorrelation && EBw9UuUGJJE != null)
				{
					num2 = 3;
					break;
				}
				return;
			case 1:
				if (P_0 == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool CheckNeedRedraw()
	{
		if (!qH79UhtpURN)
		{
			return false;
		}
		qH79UhtpURN = true;
		return true;
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		BackColor = P_0.IndicatorBackColor1;
		BackColor2 = P_0.IndicatorBackColor2;
		TextColor = P_0.ChartFontColor;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
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
			AlertTextColor = P_0.ChartFontColor;
			AlertBackColor = uZDSmmbIie6DIwAdHXSD(P_0);
			base.ApplyColors(P_0);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
			{
				num = 1;
			}
		}
	}

	private static Symbol KbD9thbWgU1(ypqMIv9maFM0tRwF0xMh P_0)
	{
		if (((P_0 != null) ? J9cKXobIlIMrG7rxlnl1(P_0) : null) == null)
		{
			return null;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => SymbolManager.Get(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1AB79299 ^ 0x1AB3F8EF)), 
		};
	}

	protected override void wxjl9ZbwOKd(ypqMIv9maFM0tRwF0xMh P_0)
	{
		Symbol eBw9UuUGJJE = EBw9UuUGJJE;
		int num;
		if (hWT6svbI44QsFouaG23E(base.DataProvider?.DataCycle))
		{
			EBw9UuUGJJE = KbD9thbWgU1(base.DataProvider);
			if (base.DataProvider != null)
			{
				vvRshJbIDKHcCd3njZNU(EBw9UuUGJJE, rIYvdDbIBgaX0X1uljlU(base.DataProvider));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
				{
					num = 5;
				}
				goto IL_0009;
			}
		}
		goto IL_027d;
		IL_02bf:
		object obj = null;
		goto IL_038a;
		IL_0331:
		object obj2 = boG9U8FxkV4;
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac != 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num)
			{
			default:
				lockTaken = false;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
				{
					num = 1;
				}
				continue;
			case 1:
				try
				{
					Monitor.Enter(obj2, ref lockTaken);
					int num2;
					if (sbZ9U7W5NgW)
					{
						if (base.DataProvider == null)
						{
							DataManager.OnSecurityEvent -= d7V9tK6gF47;
							sbZ9U7W5NgW = false;
							goto IL_00d9;
						}
						num2 = 2;
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
						{
							num2 = 0;
						}
					}
					goto IL_006d;
					IL_006d:
					while (true)
					{
						switch (num2)
						{
						case 8:
							break;
						case 2:
						case 5:
							goto IL_00d9;
						case 4:
							DataManager.OnSecurityEvent += d7V9tK6gF47;
							num2 = 8;
							continue;
						case 1:
							if (base.DataProvider == null)
							{
								return;
							}
							goto case 3;
						case 7:
							R0x9UAtKAXX = false;
							return;
						case 6:
							return;
						case 3:
							LStMKXHZj9m30GIr08xj.D03HZyEkss1(o7r9tm7L0rO);
							R0x9UAtKAXX = true;
							num2 = 6;
							continue;
						default:
							if (base.DataProvider == null)
							{
								goto IL_00d9;
							}
							goto case 4;
						}
						break;
					}
					sbZ9U7W5NgW = true;
					int num3 = 5;
					goto IL_0069;
					IL_00d9:
					if (!R0x9UAtKAXX)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
						{
							num2 = 1;
						}
						goto IL_006d;
					}
					if (base.DataProvider != null)
					{
						return;
					}
					LStMKXHZj9m30GIr08xj.kD0HZZUTQ8f(o7r9tm7L0rO);
					num3 = 7;
					goto IL_0069;
					IL_0069:
					num2 = num3;
					goto IL_006d;
				}
				finally
				{
					if (!lockTaken)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					else
					{
						Monitor.Exit(obj2);
					}
				}
			case 5:
				break;
			case 2:
				goto IL_02bf;
			case 4:
				goto IL_0317;
			case 3:
				return;
			}
			break;
		}
		goto IL_027d;
		IL_027d:
		if (P_0 == null)
		{
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		obj = P_0.DataCycle;
		goto IL_038a;
		IL_0317:
		if (P_0 != null)
		{
			LStMKXHZj9m30GIr08xj.k3CHZdW1sOk(eBw9UuUGJJE, rK4VxZbIbU0FcffrAiW8(P_0.DataCycle), D5A3QdbINOfAHeB6TOHp(rIYvdDbIBgaX0X1uljlU(P_0)));
		}
		goto IL_0331;
		IL_038a:
		if (zYZeUVHCh1Om9Qf74p6d.iZ3HCAQmUav((DataCycle)obj))
		{
			goto IL_0317;
		}
		goto IL_0331;
	}

	protected override void vV3l9VrwgiA(DataCycleBase? P_0, int P_1)
	{
		if (base.DataProvider != null)
		{
			EBw9UuUGJJE = KbD9thbWgU1(base.DataProvider);
			if (zYZeUVHCh1Om9Qf74p6d.iZ3HCAQmUav(base.DataProvider?.DataCycle) && base.DataProvider != null)
			{
				LStMKXHZj9m30GIr08xj.IxjHZQVGieV(EBw9UuUGJJE, base.DataProvider.DataCycle);
			}
			if (P_0.HasValue && zYZeUVHCh1Om9Qf74p6d.QF7HCPSA4m3(P_0.Value))
			{
				LStMKXHZj9m30GIr08xj.k3CHZdW1sOk(EBw9UuUGJJE, P_0.Value, P_1);
			}
		}
	}

	protected override void Execute()
	{
		int num = 18;
		double[] array = default(double[]);
		int num7 = default(int);
		decimal num4 = default(decimal);
		double[] array2 = default(double[]);
		int num5 = default(int);
		int num3 = default(int);
		IChartCluster cluster = default(IChartCluster);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				IChartCluster chartCluster;
				IChartCluster cluster2;
				List<OjH2QVHZoARxtkRLMBCI> list;
				switch (num2)
				{
				case 12:
					if (array.Length != 0)
					{
						IChartCluster cluster3 = ((IChartDataProvider)base.DataProvider).GetCluster(base.DataProvider.Count - 1);
						QC49UmXIpF9 = ((array.Length - 1 >= NatrShift) ? (array[array.Length - 1 - NatrShift] / (double)cluster3.Close / (double)base.DataProvider.UJElnHayjot) : double.NaN);
						num2 = 2;
						break;
					}
					goto case 2;
				case 11:
					return;
				case 14:
					num7 = Math.Min(base.DataProvider.Count, AvgVolumePeriod);
					num4 = default(decimal);
					num2 = 10;
					break;
				case 1:
					EEj9tA2NJGI(o25qEBbIc4JMrxBTx5ln(base.Helper, CorrelationPeriod, array2, num5, num3));
					num2 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
					{
						num2 = 11;
					}
					break;
				case 17:
					return;
				case 2:
					if (!ShowCorrelation)
					{
						return;
					}
					if (EBw9UuUGJJE != null)
					{
						if (base.DataProvider != null)
						{
							ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = base.DataProvider;
							if (ypqMIv9maFM0tRwF0xMh == null)
							{
								num2 = 8;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
								{
									num2 = 7;
								}
								break;
							}
							obj = ypqMIv9maFM0tRwF0xMh.DataCycle;
							goto IL_04fc;
						}
						goto IL_0076;
					}
					num2 = 9;
					break;
				case 16:
					cluster = ((IChartDataProvider)base.DataProvider).GetCluster(num6);
					num2 = 3;
					break;
				case 10:
					num6 = base.DataProvider.Count - num7;
					num2 = 7;
					break;
				case 18:
					if (base.DataProvider == null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
						{
							num2 = 17;
						}
						break;
					}
					goto case 13;
				default:
					if (num6 < base.DataProvider.Count)
					{
						goto case 16;
					}
					Hsg9UK5yanL = ((num7 > 0) ? (num4 / oru9mJbI1KLN6yaTovr1(num7)) : (-1m));
					goto IL_03e4;
				case 3:
					if (cluster != null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto IL_028e;
				case 15:
					if (array != null)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 9:
					return;
				case 5:
					num4 = v9whkpbISyf2914ONm6G(num4, PqQeCVbI5SxB4AWrHZ7h(cluster.Volume * cluster.Close, oru9mJbI1KLN6yaTovr1(zwWJnTbIkpLkJJ7euHGU(base.DataProvider))));
					goto IL_028e;
				case 4:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
					{
						num2 = 1;
					}
					break;
				case 13:
					if (base.DataProvider.Count <= 0)
					{
						return;
					}
					if (ShowAverageVolume)
					{
						num2 = 9;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
						{
							num2 = 14;
						}
						break;
					}
					goto IL_03e4;
				case 6:
					return;
				case 8:
					{
						obj = null;
						goto IL_04fc;
					}
					IL_04fc:
					if (!zYZeUVHCh1Om9Qf74p6d.iZ3HCAQmUav((DataCycle)obj) || base.DataProvider.Count - CorrelationPeriod < 1)
					{
						goto IL_0076;
					}
					chartCluster = (IChartCluster)dicUPWbIetN6TKonQmuX((IChartDataProvider)base.DataProvider, vmqOKpbILGYCk628fx0U(base.DataProvider) - 1);
					cluster2 = ((IChartDataProvider)base.DataProvider).GetCluster(vmqOKpbILGYCk628fx0U(base.DataProvider) - CorrelationPeriod - 1);
					LStMKXHZj9m30GIr08xj.BSmHZgoTnIV(EBw9UuUGJJE, base.DataProvider.DataCycle, DAt3VxbIs4PdUwBlvs4Y(cluster2), DAt3VxbIs4PdUwBlvs4Y(chartCluster));
					list = LStMKXHZj9m30GIr08xj.MP6HZT4QbxW(EBw9UuUGJJE, base.DataProvider.DataCycle);
					if (list == null || list.Count <= 0)
					{
						return;
					}
					array2 = list.Select((OjH2QVHZoARxtkRLMBCI b) => b.Close).ToArray();
					if (!ORgL04bIXluQoVCd0djA(list[list.Count - 1].Time, chartCluster.Time))
					{
						num5 = (num3 = 0);
						goto case 1;
					}
					num5 = 1;
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
					{
						num2 = 4;
					}
					break;
					IL_028e:
					num6++;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
					{
						num2 = 0;
					}
					break;
					IL_03e4:
					if (ShowNATR)
					{
						array = (double[])zb4nh2bIxFjC52mVl0Yr(base.Helper, NatrPeriod, NatrMaType);
						num2 = 15;
						break;
					}
					goto case 2;
					IL_0076:
					EEj9tA2NJGI(double.NaN);
					num2 = 6;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 12;
		}
	}

	private static void KQk9twPM1Gh(Size P_0, ref double P_1, ref double P_2)
	{
		if (P_0.Width > P_1)
		{
			P_1 = P_0.Width;
		}
		if (P_0.Height > P_2)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			P_2 = P_0.Height;
		}
	}

	private XBrush nkG9t72idCF(bool P_0, bool P_1)
	{
		if (!P_1)
		{
			if (!P_0)
			{
				return R5K9TYXLR4M;
			}
			return Sis9TnGcY4W;
		}
		return ust9TaSY5vI;
	}

	public override void Render(DxVisualQueue P_0)
	{
		string text = null;
		string text2 = null;
		int num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
		{
			num = 10;
		}
		double num11 = default(double);
		double num7 = default(double);
		int num10 = default(int);
		double num6 = default(double);
		decimal? num5 = default(decimal?);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag4 = default(bool);
		string text6 = default(string);
		bool flag5 = default(bool);
		Rect rect4 = default(Rect);
		double x = default(double);
		Rect rect3 = default(Rect);
		string text7;
		string text3 = default(string);
		XFont chartFont;
		XBrush brush;
		Rect rect5 = default(Rect);
		double num12 = default(double);
		Rect rect2 = default(Rect);
		Rect rect = default(Rect);
		double num13 = default(double);
		while (true)
		{
			object obj;
			string text5;
			int num4;
			double num9;
			string text4;
			int num14;
			double num3;
			double num2;
			switch (num)
			{
			case 25:
				text = (string)iwbtNBbIGGRpoQMEvTgQ(0x2BD86B18 ^ 0x2BDC01BA) + base.DataProvider.Symbol.FormatSize(fN49UrGeaGh, 2, MinimizeValues);
				num = 36;
				continue;
			case 1:
				num11 += num7 + 1.0;
				num = 18;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda != 0)
				{
					num = 12;
				}
				continue;
			case 28:
				num10++;
				num = 25;
				continue;
			case 36:
			{
				KQk9twPM1Gh(base.Settings.ChartFont.GetSize(text), ref num6, ref num7);
				decimal num8 = fN49UrGeaGh;
				num5 = DailyVolumeThr;
				flag3 = (num8 >= num5.GetValueOrDefault()) & num5.HasValue;
				goto IL_0245;
			}
			case 27:
				flag2 = false;
				num = 22;
				continue;
			case 23:
				flag = false;
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
				{
					num = 27;
				}
				continue;
			case 20:
				if (!double.IsNaN(cgR9t8MFv3k()))
				{
					obj = string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28BBDCA ^ 0x28FD714), cgR9t8MFv3k());
					goto IL_08f5;
				}
				num = 37;
				continue;
			case 39:
				num10++;
				if (!VbEkcsbIEVqwCJDyHvyj(QC49UmXIpF9))
				{
					num = 7;
					continue;
				}
				text5 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1962651919 ^ -1962925019);
				goto IL_08d0;
			case 17:
				if (ShowNATR)
				{
					goto case 16;
				}
				goto IL_04de;
			case 11:
			{
				if (!num5.HasValue)
				{
					num = 21;
					continue;
				}
				double num15 = QC49UmXIpF9 * 100.0;
				num5 = NatrThr;
				num4 = ((num15 >= (double)num5.Value) ? 1 : 0);
				goto IL_08d8;
			}
			case 3:
				flag4 = !flag4;
				num = 6;
				continue;
			case 10:
				text6 = null;
				num = 15;
				continue;
			case 5:
				num6 += UAF9UyMxeHb.X;
				num7 += UAF9UyMxeHb.Y;
				if (TableHorizontalAlignment != IA4TWm9tT0N2p8p89AZn.Left)
				{
					num = 30;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
					{
						num = 10;
					}
					continue;
				}
				num9 = HorizontalIndent;
				goto IL_0924;
			case 22:
				flag5 = false;
				num6 = 0.0;
				num7 = 0.0;
				num = 38;
				continue;
			case 6:
				num11 += num7 + 1.0;
				rect4 = new Rect(x, num11, num6, num7);
				num = 14;
				continue;
			default:
				if (ShowNATR)
				{
					goto case 39;
				}
				goto IL_057d;
			case 29:
				num11 += num7 + 1.0;
				rect3 = new Rect(x, num11, num6, num7);
				num = 26;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
				{
					num = 24;
				}
				continue;
			case 32:
				if (!(Hsg9UK5yanL >= 0m))
				{
					num = 24;
					continue;
				}
				text4 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710738216) + base.DataProvider.Symbol.FormatSize(Hsg9UK5yanL, 2, MinimizeValues);
				goto IL_084d;
			case 26:
				yJgf6FbIgmXGeV4Wdi3r(P_0, nkG9t72idCF(_0020: true, flag3), rect3, Gef9UTKDuqN);
				P_0.DrawString(text, base.Settings.ChartFont, flag3 ? dxr9TlyMydm : Qi89TvBlWwx, rect3, XTextAlignment.Center);
				goto IL_01fb;
			case 14:
				yJgf6FbIgmXGeV4Wdi3r(P_0, nkG9t72idCF(flag4, flag5), rect4, Gef9UTKDuqN);
				text7 = text3;
				chartFont = base.Settings.ChartFont;
				brush = (flag5 ? dxr9TlyMydm : Qi89TvBlWwx);
				break;
			case 16:
				flag4 = !flag4;
				num11 += num7 + 1.0;
				rect5 = new Rect(x, num11, num6, num7);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
				{
					num = 8;
				}
				continue;
			case 31:
			{
				double num17 = cgR9t8MFv3k();
				num5 = CorrelationThr;
				num14 = ((num17 >= (double)num5.Value) ? 1 : 0);
				goto IL_0902;
			}
			case 9:
				if (ShowDailyVolume)
				{
					flag4 = true;
					num = 29;
					continue;
				}
				goto IL_01fb;
			case 8:
				P_0.FillRoundedRectangle(nkG9t72idCF(flag4, flag2), rect5, Gef9UTKDuqN);
				Rr1LBcbI6UNaDdXYFq7e(P_0, text6, fQjdnybIR5ak9mtoBmbW(base.Settings), flag2 ? dxr9TlyMydm : Qi89TvBlWwx, rect5, XTextAlignment.Center);
				goto IL_04de;
			case 34:
				num12 = ((TableVerticalAlignment == NRk0Y59tZN0iHuhOcdCq.Top) ? VerticalIndent : (0.0 - VerticalIndent));
				if (TableHorizontalAlignment == IA4TWm9tT0N2p8p89AZn.Left)
				{
					rect2 = base.Canvas.Rect;
					num = 33;
					continue;
				}
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
				{
					num = 2;
				}
				continue;
			case 4:
				KQk9twPM1Gh(base.Settings.ChartFont.GetSize(text3), ref num6, ref num7);
				num5 = CorrelationThr;
				if (num5.HasValue)
				{
					num = 31;
					continue;
				}
				num14 = 0;
				goto IL_0902;
			case 38:
				num10 = 0;
				if (ShowDailyVolume)
				{
					num = 28;
					continue;
				}
				goto IL_0245;
			case 2:
				rect2 = base.Canvas.Rect;
				num3 = rect2.Right - num6;
				goto IL_0944;
			case 18:
				rect = new Rect(x, num11, num6, num7);
				yJgf6FbIgmXGeV4Wdi3r(P_0, nkG9t72idCF(flag4, flag), rect, Gef9UTKDuqN);
				num = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
				{
					num = 8;
				}
				continue;
			case 19:
				if (TableVerticalAlignment == NRk0Y59tZN0iHuhOcdCq.Top)
				{
					rect2 = BVJQ6cbIdTKwaEX1nHWD(base.Canvas);
					num = 12;
					continue;
				}
				rect2 = BVJQ6cbIdTKwaEX1nHWD(xBaJbMbIQRv4LdjgNbWg(this));
				num2 = rect2.Bottom - num7 * (double)num10;
				goto IL_096a;
			case 30:
				num9 = 0.0 - HorizontalIndent;
				goto IL_0924;
			case 7:
				text5 = string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1487846E ^ 0x1483EEAC), QC49UmXIpF9);
				goto IL_08d0;
			case 15:
				text3 = null;
				flag3 = false;
				num = 23;
				continue;
			case 24:
				text4 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2074141628 ^ -2074380568);
				goto IL_084d;
			case 35:
			{
				decimal hsg9UK5yanL = Hsg9UK5yanL;
				num5 = AverageVolumeThr;
				flag = (hsg9UK5yanL >= num5.GetValueOrDefault()) & num5.HasValue;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
				{
					num = 0;
				}
				continue;
			}
			case 21:
				num4 = 0;
				goto IL_08d8;
			case 37:
				obj = iwbtNBbIGGRpoQMEvTgQ(-90307782 ^ -90543668);
				goto IL_08f5;
			case 33:
				num3 = rect2.Left;
				goto IL_0944;
			case 12:
				num2 = rect2.Top;
				goto IL_096a;
			case 13:
				{
					P_0.DrawString(text2, base.Settings.ChartFont, flag ? dxr9TlyMydm : Qi89TvBlWwx, rect, XTextAlignment.Center);
					num = 17;
					continue;
				}
				IL_08f5:
				text3 = (string)obj;
				num = 4;
				continue;
				IL_01fb:
				if (ShowAverageVolume)
				{
					flag4 = !flag4;
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
					{
						num = 1;
					}
					continue;
				}
				goto case 17;
				IL_08d0:
				text6 = text5;
				KQk9twPM1Gh(ckucsjbIjcBcTsP1BS9w(base.Settings.ChartFont, text6), ref num6, ref num7);
				num5 = NatrThr;
				num = 11;
				continue;
				IL_096a:
				num11 = num2 + num12 - num7 - 1.0;
				flag4 = false;
				num = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
				{
					num = 9;
				}
				continue;
				IL_084d:
				text2 = text4;
				KQk9twPM1Gh(ckucsjbIjcBcTsP1BS9w(base.Settings.ChartFont, text2), ref num6, ref num7);
				num = 35;
				continue;
				IL_0924:
				num13 = num9;
				num = 34;
				continue;
				IL_0944:
				x = num3 + num13;
				num = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
				{
					num = 19;
				}
				continue;
				IL_0245:
				if (ShowAverageVolume)
				{
					num10++;
					num = 32;
					continue;
				}
				goto default;
				IL_08d8:
				flag2 = (byte)num4 != 0;
				goto IL_057d;
				IL_04de:
				if (ShowCorrelation)
				{
					int num16 = 3;
					num = num16;
					continue;
				}
				return;
				IL_057d:
				if (ShowCorrelation)
				{
					num10++;
					num = 20;
					continue;
				}
				goto case 5;
				IL_0902:
				flag5 = (byte)num14 != 0;
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
				{
					num = 3;
				}
				continue;
			}
			break;
		}
		P_0.DrawString(text7, chartFont, brush, rect4, XTextAlignment.Center);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 2;
		nySn7g9tCpL9DJqV6NJE nySn7g9tCpL9DJqV6NJE2 = default(nySn7g9tCpL9DJqV6NJE);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					AlertTextColor = nySn7g9tCpL9DJqV6NJE2.AlertTextColor;
					ShowDailyVolume = nySn7g9tCpL9DJqV6NJE2.ShowDailyVolume;
					num2 = 11;
					continue;
				case 11:
					ShowAverageVolume = nySn7g9tCpL9DJqV6NJE2.ShowAverageVolume;
					num2 = 5;
					continue;
				case 7:
					AlertBackColor = nySn7g9tCpL9DJqV6NJE2.AlertBackColor;
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					nySn7g9tCpL9DJqV6NJE2 = (nySn7g9tCpL9DJqV6NJE)P_0;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					MinimizeValues = nySn7g9tCpL9DJqV6NJE2.MinimizeValues;
					BackColor = nySn7g9tCpL9DJqV6NJE2.BackColor;
					BackColor2 = nySn7g9tCpL9DJqV6NJE2.BackColor2;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					ShowCorrelation = r6wGssbIOJRuHmMyrTZG(nySn7g9tCpL9DJqV6NJE2);
					ShowNATR = nySn7g9tCpL9DJqV6NJE2.ShowNATR;
					num2 = 6;
					continue;
				case 9:
					DailyVolumeThr = nySn7g9tCpL9DJqV6NJE2.DailyVolumeThr;
					AverageVolumeThr = nySn7g9tCpL9DJqV6NJE2.AverageVolumeThr;
					num2 = 3;
					continue;
				case 1:
					AvgVolumePeriod = nySn7g9tCpL9DJqV6NJE2.AvgVolumePeriod;
					NatrShift = eZRkbUbIMpghwxLJmjdp(nySn7g9tCpL9DJqV6NJE2);
					CorrelationPeriod = nySn7g9tCpL9DJqV6NJE2.CorrelationPeriod;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
					{
						num2 = 9;
					}
					continue;
				case 10:
					NatrSource = nySn7g9tCpL9DJqV6NJE2.NatrSource.CloneSource();
					if (boG9U8FxkV4 == null)
					{
						boG9U8FxkV4 = new object();
					}
					base.CopyTemplate(P_0, P_1);
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					NatrThr = nySn7g9tCpL9DJqV6NJE2.NatrThr;
					CorrelationThr = nySn7g9tCpL9DJqV6NJE2.CorrelationThr;
					num = 12;
					break;
				case 8:
					return;
				case 6:
					TableHorizontalAlignment = Ns3nhVbIqncHxne5COWv(nySn7g9tCpL9DJqV6NJE2);
					TableVerticalAlignment = WvPDgPbII7T7ms7BQK1Z(nySn7g9tCpL9DJqV6NJE2);
					HorizontalIndent = nySn7g9tCpL9DJqV6NJE2.HorizontalIndent;
					VerticalIndent = ynF5PBbIWoGlH6QrQduN(nySn7g9tCpL9DJqV6NJE2);
					NatrPeriod = xftnDQbItWV59hHdeA9t(nySn7g9tCpL9DJqV6NJE2);
					NatrMaType = nySn7g9tCpL9DJqV6NJE2.NatrMaType;
					num = 10;
					break;
				default:
					TextColor = nySn7g9tCpL9DJqV6NJE2.TextColor;
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	public override List<IndicatorValueInfo> GetValues(int cursorPos)
	{
		List<IndicatorValueInfo> list = new List<IndicatorValueInfo>();
		StringBuilder stringBuilder = new StringBuilder();
		if (ShowDailyVolume)
		{
			stringBuilder.Append(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842329985) + base.DataProvider.Symbol.FormatSize(fN49UrGeaGh, 2, MinimizeValues) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BE8CF0));
		}
		if (ShowAverageVolume)
		{
			stringBuilder.Append((Hsg9UK5yanL >= 0m) ? (stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x706541F3 ^ 0x70612AEF) + base.DataProvider.Symbol.FormatSize(Hsg9UK5yanL, 2, MinimizeValues) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xB15786A ^ 0xB1559D0)) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-527080372 ^ -527364288));
		}
		if (ShowNATR)
		{
			stringBuilder.Append(double.IsNaN(QC49UmXIpF9) ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-671204305 ^ -671459567) : string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--871424829 ^ 0x33F48815), QC49UmXIpF9));
		}
		if (ShowCorrelation)
		{
			stringBuilder.Append(double.IsNaN(cgR9t8MFv3k()) ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x9F0F634 ^ 0x9F49D5C) : string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746ABF49), cgR9t8MFv3k()));
		}
		list.Add(new IndicatorValueInfo(stringBuilder.ToString(), base.Theme.ChartFontBrush));
		return list;
	}

	public override string ToString()
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3305FCD9);
	}

	public override void Dispose()
	{
		if (base.DataProvider != null)
		{
			base.DataProvider = null;
		}
		base.Dispose();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
		{
			num = 1;
		}
		object obj = default(object);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num)
			{
			case 1:
				obj = boG9U8FxkV4;
				lockTaken = false;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
				{
					num = 0;
				}
				continue;
			}
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 2:
						DataManager.OnSecurityEvent -= d7V9tK6gF47;
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						sbZ9U7W5NgW = false;
						break;
					default:
						if (sbZ9U7W5NgW)
						{
							num2 = 2;
							continue;
						}
						break;
					}
					break;
				}
				if (R0x9UAtKAXX)
				{
					LStMKXHZj9m30GIr08xj.kD0HZZUTQ8f(o7r9tm7L0rO);
					R0x9UAtKAXX = false;
				}
				return;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	static nySn7g9tCpL9DJqV6NJE()
	{
		Rn73X5bIUGLmuNgCBfar();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Gef9UTKDuqN = new Point(5.0, 5.0);
		UAF9UyMxeHb = new Point(15.0, 15.0);
	}

	internal static bool cL96nJbIHfdjSpxdmNb4()
	{
		return tkaF12bI2kEcAWIibqSE == null;
	}

	internal static nySn7g9tCpL9DJqV6NJE VSkKErbIfGsU1Jv33khA()
	{
		return tkaF12bI2kEcAWIibqSE;
	}

	internal static void JrispYbI9fcSutQhmGDr(object P_0, object P_1)
	{
		((IndicatorBase)P_0).OnPropertyChanged((string)P_1);
	}

	internal static int ArybsFbIn1F1NgUKgDeF(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object iwbtNBbIGGRpoQMEvTgQ(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool Yn5TjGbIYVNsBBZ5YtkU(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static void gBnHXSbIojYJVAh9IMWo()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void bhINVubIvCVXmHKFHk5U(object P_0, IndicatorCalculation P_1)
	{
		((IndicatorBase)P_0).Calculation = P_1;
	}

	internal static object rIYvdDbIBgaX0X1uljlU(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).DataCycle;
	}

	internal static bool CxOOj4bIaX9oIayXeOPP(object P_0, object P_1)
	{
		return ((DataCycle)P_0).Equals((DataCycle)P_1);
	}

	internal static XColor uZDSmmbIie6DIwAdHXSD(object P_0)
	{
		return ((IChartTheme)P_0).IndicatorAlertBackColor;
	}

	internal static object J9cKXobIlIMrG7rxlnl1(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).Symbol;
	}

	internal static bool hWT6svbI44QsFouaG23E(object P_0)
	{
		return zYZeUVHCh1Om9Qf74p6d.iZ3HCAQmUav((DataCycle)P_0);
	}

	internal static void vvRshJbIDKHcCd3njZNU(object P_0, object P_1)
	{
		LStMKXHZj9m30GIr08xj.IxjHZQVGieV((Symbol)P_0, (DataCycle)P_1);
	}

	internal static DataCycleBase rK4VxZbIbU0FcffrAiW8(object P_0)
	{
		return ((DataCycle)P_0).CycleBase;
	}

	internal static int D5A3QdbINOfAHeB6TOHp(object P_0)
	{
		return ((DataCycle)P_0).Repeat;
	}

	internal static int zwWJnTbIkpLkJJ7euHGU(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).UJElnHayjot;
	}

	internal static decimal oru9mJbI1KLN6yaTovr1(int P_0)
	{
		return P_0;
	}

	internal static decimal PqQeCVbI5SxB4AWrHZ7h(decimal P_0, decimal P_1)
	{
		return P_0 * P_1;
	}

	internal static decimal v9whkpbISyf2914ONm6G(decimal P_0, decimal P_1)
	{
		return P_0 + P_1;
	}

	internal static object zb4nh2bIxFjC52mVl0Yr(object P_0, int P_1, IndicatorMaType P_2)
	{
		return ((IndicatorsHelper)P_0).ATR(P_1, P_2);
	}

	internal static int vmqOKpbILGYCk628fx0U(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).Count;
	}

	internal static object dicUPWbIetN6TKonQmuX(object P_0, int P_1)
	{
		return ((IChartDataProvider)P_0).GetCluster(P_1);
	}

	internal static DateTime DAt3VxbIs4PdUwBlvs4Y(object P_0)
	{
		return ((IChartCluster)P_0).Time;
	}

	internal static bool ORgL04bIXluQoVCd0djA(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static double o25qEBbIc4JMrxBTx5ln(object P_0, int P_1, object P_2, int P_3, int P_4)
	{
		return ((IndicatorsHelper)P_0).CloseCorrelation(P_1, (double[])P_2, P_3, P_4);
	}

	internal static Size ckucsjbIjcBcTsP1BS9w(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static bool VbEkcsbIEVqwCJDyHvyj(double P_0)
	{
		return double.IsNaN(P_0);
	}

	internal static object xBaJbMbIQRv4LdjgNbWg(object P_0)
	{
		return ((IndicatorBase)P_0).Canvas;
	}

	internal static Rect BVJQ6cbIdTKwaEX1nHWD(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static void yJgf6FbIgmXGeV4Wdi3r(object P_0, object P_1, Rect P_2, Point P_3)
	{
		((DxVisualQueue)P_0).FillRoundedRectangle((XBrush)P_1, P_2, P_3);
	}

	internal static object fQjdnybIR5ak9mtoBmbW(object P_0)
	{
		return ((ChartSettings)P_0).ChartFont;
	}

	internal static void Rr1LBcbI6UNaDdXYFq7e(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static int eZRkbUbIMpghwxLJmjdp(object P_0)
	{
		return ((nySn7g9tCpL9DJqV6NJE)P_0).NatrShift;
	}

	internal static bool r6wGssbIOJRuHmMyrTZG(object P_0)
	{
		return ((nySn7g9tCpL9DJqV6NJE)P_0).ShowCorrelation;
	}

	internal static IA4TWm9tT0N2p8p89AZn Ns3nhVbIqncHxne5COWv(object P_0)
	{
		return ((nySn7g9tCpL9DJqV6NJE)P_0).TableHorizontalAlignment;
	}

	internal static NRk0Y59tZN0iHuhOcdCq WvPDgPbII7T7ms7BQK1Z(object P_0)
	{
		return ((nySn7g9tCpL9DJqV6NJE)P_0).TableVerticalAlignment;
	}

	internal static double ynF5PBbIWoGlH6QrQduN(object P_0)
	{
		return ((nySn7g9tCpL9DJqV6NJE)P_0).VerticalIndent;
	}

	internal static int xftnDQbItWV59hHdeA9t(object P_0)
	{
		return ((nySn7g9tCpL9DJqV6NJE)P_0).NatrPeriod;
	}

	internal static void Rn73X5bIUGLmuNgCBfar()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
