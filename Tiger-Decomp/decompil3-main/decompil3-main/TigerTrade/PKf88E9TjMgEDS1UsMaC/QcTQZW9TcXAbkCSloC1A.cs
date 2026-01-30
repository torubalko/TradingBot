using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using C7UvAf9ri2R97XEwp7o2;
using ECOEgqlSad8NUJZ2Dr9n;
using MIA3eC2ZXsuRyAB0mjn;
using o1srKL9PWRC5v3sURMga;
using OVdvQi9TeSLDd8m0Ym88;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Settings;
using TigerTrade.Dx;
using TuAMtrl1Nd3XoZQQUXf0;
using uyZAkjGzbty6fP4YlLSY;
using Wf1kTvnGy6XhfTKJgfkM;

namespace PKf88E9TjMgEDS1UsMaC;

[Indicator("FundingRate", "Funding Rate", true)]
[DataContract(Name = "FundingRateIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class QcTQZW9TcXAbkCSloC1A : fi0dX39rarBK9dp2dGQR
{
	private readonly XBrush Tx19TrPXBKi;

	private int itR9TK2k6P4;

	private int GhT9TmxtGWp;

	private XColor XAX9Thvcc9a;

	private XColor OlS9TwAy8Vm;

	private int jNK9T7nIsic;

	private bool PRF9T8GFCPU;

	private gVBbdv9TLmyypWQI79XU kML9TAmscod;

	private XColor gRd9TPgk49B;

	private int HSR9TJN2QY1;

	private static QcTQZW9TcXAbkCSloC1A uk167LbIV4Q1SUvqt7Qp;

	[T4IXj62qBfXCaxs2RI5("ChartFundingRateIndicatorDisplay")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsOffsetX")]
	[DataMember(Name = "OffsetX")]
	public int OffsetX
	{
		get
		{
			return itR9TK2k6P4;
		}
		set
		{
			int num = Math.Max(0, XHQ11RbIK1FMwMy8NQPo(1000, num2));
			if (itR9TK2k6P4 != num)
			{
				itR9TK2k6P4 = num;
				OnPropertyChanged((string)yMlimHbImRLQHdpvA9DH(-45476899 ^ -45189051));
				int num3 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
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

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsOffsetY")]
	[T4IXj62qBfXCaxs2RI5("ChartFundingRateIndicatorDisplay")]
	[DataMember(Name = "OffsetY")]
	public int OffsetY
	{
		get
		{
			return GhT9TmxtGWp;
		}
		set
		{
			int num = Math.Max(0, Math.Min(1000, val));
			if (GhT9TmxtGWp != num)
			{
				GhT9TmxtGWp = num;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-3429745 ^ -3161819));
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
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

	[bBo0Zd2ycQQr3LNHQf4("ChartFundingRateIndicatorFundingColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "FundingRateColor")]
	public XColor FundingRateColor
	{
		get
		{
			return XAX9Thvcc9a;
		}
		set
		{
			if (XAX9Thvcc9a != xColor)
			{
				XAX9Thvcc9a = xColor;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)yMlimHbImRLQHdpvA9DH(0x68C7EAE6 ^ 0x68C3C01E));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartFundingRateIndicatorTimerColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "TimerColor")]
	public XColor TimerColor
	{
		get
		{
			return OlS9TwAy8Vm;
		}
		set
		{
			if (OlS9TwAy8Vm != xColor)
			{
				OlS9TwAy8Vm = xColor;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				v7XeYMbIhTPXPAN7VW88(this, yMlimHbImRLQHdpvA9DH(0x4662F6AF ^ 0x46669D13));
			}
		}
	}

	[DisplayName("Размер шрифта")]
	[DataMember(Name = "FontSize")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	public int FontSize
	{
		get
		{
			return jNK9T7nIsic;
		}
		set
		{
			int num = nTVomVbIw6xxBkvtvNyF(6, Math.Min(48, val));
			if (jNK9T7nIsic != num)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				jNK9T7nIsic = num;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x809A921));
			}
		}
	}

	[DefaultValue(true)]
	[T4IXj62qBfXCaxs2RI5("ChartFundingRateIndicatorDisplay")]
	[bBo0Zd2ycQQr3LNHQf4("ChartFundingRateIndicatorShowLine")]
	[DataMember(Name = "ShowFundingLine")]
	public bool ShowFundingLine
	{
		get
		{
			return PRF9T8GFCPU;
		}
		set
		{
			if (PRF9T8GFCPU != flag)
			{
				PRF9T8GFCPU = flag;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3305FC7B));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
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

	[DefaultValue(gVBbdv9TLmyypWQI79XU.aQ79TsmubFP)]
	[T4IXj62qBfXCaxs2RI5("ChartFundingRateIndicatorDisplay")]
	[DataMember(Name = "LabelPosition")]
	[bBo0Zd2ycQQr3LNHQf4("ChartFundingRateIndicatorLabelPosition")]
	public gVBbdv9TLmyypWQI79XU LabelPosition
	{
		get
		{
			return kML9TAmscod;
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
					kML9TAmscod = gVBbdv9TLmyypWQI79XU;
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2C8374E4 ^ 0x2C871F12));
					return;
				case 1:
					if (kML9TAmscod != gVBbdv9TLmyypWQI79XU)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartFundingRateIndicatorLineColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "FundingLineColor")]
	public XColor FundingLineColor
	{
		get
		{
			return gRd9TPgk49B;
		}
		set
		{
			if (gRd9TPgk49B != xColor)
			{
				gRd9TPgk49B = xColor;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2002318893 ^ -2002557497));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
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
	[bBo0Zd2ycQQr3LNHQf4("ChartFundingRateIndicatorLineWidth")]
	[DataMember(Name = "FundingLineWidth")]
	public int FundingLineWidth
	{
		get
		{
			return HSR9TJN2QY1;
		}
		set
		{
			int num = Math.Max(1, XHQ11RbIK1FMwMy8NQPo(10, num2));
			if (HSR9TJN2QY1 != num)
			{
				HSR9TJN2QY1 = num;
				int num3 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1311293279 ^ -1311560551));
			}
		}
	}

	[Browsable(false)]
	public override bool ShowIndicatorTitle => false;

	[Browsable(false)]
	public override bool ShowIndicatorLabels => false;

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.Default;

	public QcTQZW9TcXAbkCSloC1A()
	{
		YTAVuobI7XaN43he1T2t();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				HSR9TJN2QY1 = 2;
				Tx19TrPXBKi = new XBrush(new XColor(byte.MaxValue, 242, 166, 37));
				num = 3;
				break;
			case 1:
				XAX9Thvcc9a = new XColor(byte.MaxValue, 242, 166, 37);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
				{
					num = 4;
				}
				break;
			case 2:
				itR9TK2k6P4 = 0;
				GhT9TmxtGWp = 20;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
				{
					num = 1;
				}
				break;
			case 4:
				OlS9TwAy8Vm = new XColor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				jNK9T7nIsic = 14;
				PRF9T8GFCPU = true;
				kML9TAmscod = gVBbdv9TLmyypWQI79XU.TopLeft;
				gRd9TPgk49B = XColor.FromArgb(byte.MaxValue, 242, 166, 37);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public override void Render(DxVisualQueue P_0)
	{
		int num = 16;
		double x2 = default(double);
		int i2 = default(int);
		double num10 = default(double);
		double num11 = default(double);
		Rect rect2 = default(Rect);
		double num7 = default(double);
		Size size = default(Size);
		Size size2 = default(Size);
		Rect rect = default(Rect);
		XPen xPen = default(XPen);
		string text2 = default(string);
		double? num4 = default(double?);
		string text3 = default(string);
		double? num6 = default(double?);
		string text4 = default(string);
		string text = default(string);
		long num5 = default(long);
		double x = default(double);
		double num8 = default(double);
		double num9 = default(double);
		XFont xFont = default(XFont);
		double y = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				double? num3;
				object obj;
				object obj2;
				switch (num2)
				{
				case 20:
					x2 = ((IChartCanvas)Sqn8iabIJ93tG679hxZH(this)).GetX(i2);
					if (LabelPosition == gVBbdv9TLmyypWQI79XU.aQ79TsmubFP)
					{
						num10 = x2 - num11 - (double)OffsetX;
						num2 = 23;
						continue;
					}
					goto case 11;
				case 19:
					if (LabelPosition != gVBbdv9TLmyypWQI79XU.TopLeft)
					{
						if (LabelPosition != gVBbdv9TLmyypWQI79XU.aQ79TsmubFP)
						{
							num2 = 31;
							continue;
						}
						goto case 9;
					}
					rect2 = ((IChartCanvas)Sqn8iabIJ93tG679hxZH(this)).Rect;
					num2 = 29;
					continue;
				case 8:
					num7 = PKdMwybIAmE9XaY9s411(size.Height, size2.Height) + 10.0;
					rect = VT3xribIPtboXwcQEkk4(base.Canvas);
					num2 = 25;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
					{
						num2 = 2;
					}
					continue;
				case 31:
					if (LabelPosition == gVBbdv9TLmyypWQI79XU.wGb9TXTU55i)
					{
						num2 = 9;
						continue;
					}
					goto IL_027a;
				case 1:
					xPen = new XPen(new XBrush(FundingLineColor), FundingLineWidth);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
					{
						num2 = 4;
					}
					continue;
				case 22:
				{
					if (string.IsNullOrEmpty(text2))
					{
						num2 = 18;
						continue;
					}
					kjc7Gl9PIEfKaxcEBwuk kjc7Gl9PIEfKaxcEBwuk = base.DataProvider.lEVl9w6fCd9();
					if (kjc7Gl9PIEfKaxcEBwuk == null)
					{
						num4 = null;
						num2 = 24;
						continue;
					}
					num3 = kjc7Gl9PIEfKaxcEBwuk.EME9JvEvVPi();
					goto IL_0736;
				}
				case 3:
				{
					text3 = string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D56857), Math.Round(num6.Value, 4));
					text4 = text;
					ChartSettings chartSettings = base.Settings;
					if (chartSettings == null)
					{
						obj = null;
						break;
					}
					XFont chartFont = chartSettings.ChartFont;
					if (chartFont == null)
					{
						num2 = 5;
						continue;
					}
					obj = chartFont.Name;
					break;
				}
				case 26:
				{
					DateTime utcDateTime = DateTimeOffset.FromUnixTimeMilliseconds(num5).UtcDateTime;
					int i = Ugk3fEbI3ha3F2jqIZjx(base.Canvas, utcDateTime, 0);
					x = base.Canvas.GetX(i);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 7:
					num8 = rect2.Top + (double)OffsetY;
					goto IL_01d1;
				case 27:
					return;
				case 6:
					if (num5 > 0)
					{
						num2 = 26;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					return;
				case 12:
					num8 = rect2.Top + (double)OffsetY;
					goto IL_01d1;
				case 10:
					num10 = rect2.X + (double)OffsetX;
					rect2 = VT3xribIPtboXwcQEkk4(base.Canvas);
					num2 = 7;
					continue;
				case 18:
					return;
				case 11:
					num10 = x2 + (double)OffsetX;
					num2 = 30;
					continue;
				case 21:
					_ = 0;
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
					{
						num2 = 0;
					}
					continue;
				case 29:
					num10 = rect2.X + (double)OffsetX;
					rect2 = VT3xribIPtboXwcQEkk4(base.Canvas);
					num2 = 12;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
					{
						num2 = 6;
					}
					continue;
				case 28:
					return;
				case 25:
					num10 = 0.0;
					num8 = 0.0;
					num2 = 19;
					continue;
				case 9:
					if (num5 > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_027a;
				default:
				{
					DateTime utcDateTime2 = eXZIN5bIFqsCoI1xbsRG(num5).UtcDateTime;
					i2 = base.Canvas.DateToIndex(utcDateTime2, 0);
					num2 = 20;
					continue;
				}
				case 13:
					num9 += size.Width;
					P_0.DrawStrings(text4, xFont, new XBrush(TimerColor), new Rect(num9, y, size2.Width, size2.Height));
					if (ShowFundingLine)
					{
						num2 = 6;
						continue;
					}
					return;
				case 17:
					new Rect(num10, num8, num11, num7);
					num9 = num10 + 5.0;
					y = num8 + (num7 - size.Height) / 2.0;
					P_0.DrawStrings(text3, xFont, new XBrush(FundingRateColor), new Rect(num9, y, size.Width, size.Height));
					num2 = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 != 0)
					{
						num2 = 0;
					}
					continue;
				case 23:
				case 30:
					rect2 = VT3xribIPtboXwcQEkk4(base.Canvas);
					num8 = rect2.Top + (double)OffsetY;
					goto IL_01d1;
				case 2:
					return;
				case 4:
					goto end_IL_0012;
				case 16:
				{
					if (base.DataProvider == null)
					{
						num2 = 15;
						continue;
					}
					ijsjhhnGTadfwpOyDdrx symbol = base.DataProvider.Symbol;
					if (symbol == null)
					{
						num2 = 11;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
						{
							num2 = 14;
						}
						continue;
					}
					obj2 = symbol.Code;
					goto IL_070e;
				}
				case 15:
					return;
				case 14:
					obj2 = null;
					goto IL_070e;
				case 24:
					num3 = num4;
					goto IL_0736;
				case 5:
					{
						obj = null;
						break;
					}
					IL_0736:
					num6 = num3;
					if (num6.HasValue)
					{
						text = UETH72GzDcyNAirT5ahJ.E09GzekvJKi().T88Gz1CNSgl(text2);
						if (string.IsNullOrEmpty(text))
						{
							return;
						}
						num5 = UETH72GzDcyNAirT5ahJ.E09GzekvJKi().urBGz564GUO(text2);
						_ = string.Empty;
						num2 = 21;
					}
					else
					{
						num2 = 27;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
						{
							num2 = 25;
						}
					}
					continue;
					IL_070e:
					text2 = (string)obj2;
					num2 = 15;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
					{
						num2 = 22;
					}
					continue;
					IL_01d1:
					switch (LabelPosition)
					{
					case gVBbdv9TLmyypWQI79XU.TopLeft:
						num10 = rect.X + (double)OffsetX;
						num2 = 17;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 17;
					IL_027a:
					rect2 = ((IChartCanvas)Sqn8iabIJ93tG679hxZH(this)).Rect;
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
					{
						num2 = 10;
					}
					continue;
				}
				if (obj == null)
				{
					obj = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x73537989);
				}
				xFont = new XFont((string)obj, FontSize);
				size = xFont.GetSize(text3);
				size2 = QhZK1dbI8xyHfR2QjY2B(xFont, text4);
				num11 = size.Width + size2.Width + 10.0;
				num2 = 8;
				continue;
				end_IL_0012:
				break;
			}
			XPen pen = xPen;
			Point p = new Point(x, ((IChartCanvas)Sqn8iabIJ93tG679hxZH(this)).Rect.Top);
			double x3 = x;
			rect2 = base.Canvas.Rect;
			P_0.DrawLine(pen, p, new Point(x3, rect2.Bottom));
			num = 2;
		}
	}

	protected override void Execute()
	{
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		QcTQZW9TcXAbkCSloC1A qcTQZW9TcXAbkCSloC1A = (QcTQZW9TcXAbkCSloC1A)P_0;
		OffsetX = Qn6jeQbIpWoc1OGX3Wj8(qcTQZW9TcXAbkCSloC1A);
		OffsetY = X6igmRbIu17VoO9uFA2f(qcTQZW9TcXAbkCSloC1A);
		FundingRateColor = yWVv95bIzhqntEMukijR(qcTQZW9TcXAbkCSloC1A);
		int num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				FontSize = iNvSuPbW0OPOtnvIVMwE(qcTQZW9TcXAbkCSloC1A);
				ShowFundingLine = qcTQZW9TcXAbkCSloC1A.ShowFundingLine;
				LabelPosition = s8LVkZbW223mJUiPq3ju(qcTQZW9TcXAbkCSloC1A);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				TimerColor = qcTQZW9TcXAbkCSloC1A.TimerColor;
				num = 3;
				break;
			default:
				FundingLineColor = xOXtGsbWHXZ43gyvNs6U(qcTQZW9TcXAbkCSloC1A);
				FundingLineWidth = qcTQZW9TcXAbkCSloC1A.FundingLineWidth;
				tGHqqVbWfJqMq1Q5pI7P(this, P_0, P_1);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	static QcTQZW9TcXAbkCSloC1A()
	{
		cImX9tbW9XnIfrN5EcOj();
	}

	internal static int XHQ11RbIK1FMwMy8NQPo(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object yMlimHbImRLQHdpvA9DH(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool y7Lrd0bICZD4YFj809PC()
	{
		return uk167LbIV4Q1SUvqt7Qp == null;
	}

	internal static QcTQZW9TcXAbkCSloC1A lAMf5vbIrRmTLB6a7R1r()
	{
		return uk167LbIV4Q1SUvqt7Qp;
	}

	internal static void v7XeYMbIhTPXPAN7VW88(object P_0, object P_1)
	{
		((IndicatorBase)P_0).OnPropertyChanged((string)P_1);
	}

	internal static int nTVomVbIw6xxBkvtvNyF(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void YTAVuobI7XaN43he1T2t()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static Size QhZK1dbI8xyHfR2QjY2B(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static double PKdMwybIAmE9XaY9s411(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static Rect VT3xribIPtboXwcQEkk4(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static object Sqn8iabIJ93tG679hxZH(object P_0)
	{
		return ((IndicatorBase)P_0).Canvas;
	}

	internal static DateTimeOffset eXZIN5bIFqsCoI1xbsRG(long P_0)
	{
		return DateTimeOffset.FromUnixTimeMilliseconds(P_0);
	}

	internal static int Ugk3fEbI3ha3F2jqIZjx(object P_0, DateTime P_1, int P_2)
	{
		return ((IChartCanvas)P_0).DateToIndex(P_1, P_2);
	}

	internal static int Qn6jeQbIpWoc1OGX3Wj8(object P_0)
	{
		return ((QcTQZW9TcXAbkCSloC1A)P_0).OffsetX;
	}

	internal static int X6igmRbIu17VoO9uFA2f(object P_0)
	{
		return ((QcTQZW9TcXAbkCSloC1A)P_0).OffsetY;
	}

	internal static XColor yWVv95bIzhqntEMukijR(object P_0)
	{
		return ((QcTQZW9TcXAbkCSloC1A)P_0).FundingRateColor;
	}

	internal static int iNvSuPbW0OPOtnvIVMwE(object P_0)
	{
		return ((QcTQZW9TcXAbkCSloC1A)P_0).FontSize;
	}

	internal static gVBbdv9TLmyypWQI79XU s8LVkZbW223mJUiPq3ju(object P_0)
	{
		return ((QcTQZW9TcXAbkCSloC1A)P_0).LabelPosition;
	}

	internal static XColor xOXtGsbWHXZ43gyvNs6U(object P_0)
	{
		return ((QcTQZW9TcXAbkCSloC1A)P_0).FundingLineColor;
	}

	internal static void tGHqqVbWfJqMq1Q5pI7P(object P_0, object P_1, bool P_2)
	{
		((IndicatorBase)P_0).CopyTemplate((IndicatorBase)P_1, P_2);
	}

	internal static void cImX9tbW9XnIfrN5EcOj()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
