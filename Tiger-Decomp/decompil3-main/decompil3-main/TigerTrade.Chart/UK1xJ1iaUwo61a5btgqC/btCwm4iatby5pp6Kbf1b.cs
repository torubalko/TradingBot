using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Objects.Enums;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace UK1xJ1iaUwo61a5btgqC;

[DataContract(Name = "ServerAlertLineObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("ServerAlertLine", "ChartObjectsServerAlertLine", 1, Type = typeof(btCwm4iatby5pp6Kbf1b))]
public class btCwm4iatby5pp6Kbf1b : LineObjectBase
{
	[CompilerGenerated]
	private string SC5iiYCjHef;

	[CompilerGenerated]
	private double cfViioEFZQ1;

	[CompilerGenerated]
	private double LQUiivOcrxp;

	private double pbfiiBkVy9v;

	private bool ELViiaa0rk9;

	protected Rect g9QiiiapAOP;

	internal static btCwm4iatby5pp6Kbf1b uE32vsefwZSpMRESjUKg;

	[Browsable(false)]
	protected XBrush IsiiaZRNk5X => base.Theme.ServerAlertLineBrush;

	[Browsable(false)]
	public XPen afYiaCICW7G => base.Theme.ServerAlertLinePen;

	[Browsable(false)]
	public XPen KVjiaKdXs9T => base.Theme.ServerAlertCpBorderPen;

	[Browsable(false)]
	public XBrush NWyiahKq12P => base.Theme.ServerAlertCpBackBrush;

	[Browsable(false)]
	public new XColor LineColor => LCJjm7efA26Ping0stdC(base.Theme);

	[Browsable(false)]
	public new int LineWidth => base.Theme.ServerAlertLineWidth;

	[Browsable(false)]
	public new XDashStyle LineStyle => LmMSCLefPGHld2LdAmCx(base.Theme);

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[Browsable(false)]
	public string TEUiaJ0b229
	{
		[CompilerGenerated]
		get
		{
			return SC5iiYCjHef;
		}
		[CompilerGenerated]
		set
		{
			SC5iiYCjHef = sC5iiYCjHef;
		}
	}

	[Browsable(false)]
	public double KqRiapIEu5v
	{
		[CompilerGenerated]
		get
		{
			return cfViioEFZQ1;
		}
		[CompilerGenerated]
		private set
		{
			cfViioEFZQ1 = num;
		}
	}

	[Browsable(false)]
	public double grwii0uuNqO
	{
		[CompilerGenerated]
		get
		{
			return LQUiivOcrxp;
		}
		[CompilerGenerated]
		private set
		{
			LQUiivOcrxp = lQUiivOcrxp;
		}
	}

	[Browsable(false)]
	public double Price
	{
		get
		{
			return base.ControlPoints[0].Y;
		}
		set
		{
			if (num != base.ControlPoints[0].Y)
			{
				base.ControlPoints[0].Y = num;
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x9F0F634 ^ 0x9F08AE8));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5EA8FF2A ^ 0x5EA883C0));
			}
		}
	}

	[Browsable(false)]
	public double OriginalPrice
	{
		get
		{
			return pbfiiBkVy9v;
		}
		set
		{
			if (num != pbfiiBkVy9v)
			{
				pbfiiBkVy9v = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-710503328 ^ -710535360));
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
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

	[Browsable(false)]
	public bool IsSynchronized
	{
		get
		{
			return ELViiaa0rk9;
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
					if (flag != ELViiaa0rk9)
					{
						ELViiaa0rk9 = flag;
						OnPropertyChanged((string)B436rkefJphniKkbolje(0xAD5B8B3 ^ 0xAD53B8D));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public btCwm4iatby5pp6Kbf1b()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	protected override void Draw(DxVisualQueue P_0, ref List<ObjectLabelInfo> P_1)
	{
		if (base.Canvas == null)
		{
			return;
		}
		Point point = ToPoint(base.ControlPoints[0]);
		Point point2 = new Point(base.Canvas.Rect.Left, point.Y);
		Point point3 = new Point(base.Canvas.Rect.Right, point.Y);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
		{
			num = 0;
		}
		double y = default(double);
		double y2 = default(double);
		double step = default(double);
		long num2 = default(long);
		string text = default(string);
		XFont xFont = default(XFont);
		Size size = default(Size);
		Point point4 = default(Point);
		XBrush xBrush = default(XBrush);
		while (true)
		{
			switch (num)
			{
			case 11:
				g9QiiiapAOP = new Rect(new Point(point2.X, y), new Point(point3.X, y2));
				num = 8;
				break;
			case 10:
			{
				if (!vefeFMefFeP8rpXV6euM(base.Settings) || !sZTFL5ef3uYhun25GnF4(base.Canvas) || O89QVtefpSLpsXnLyf30(base.Canvas) != ChartStockType.Clusters)
				{
					goto IL_0249;
				}
				double y3 = base.ControlPoints[0].Y;
				step = base.DataProvider.Step;
				num2 = (long)Math.Round(y3 / step);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf == 0)
				{
					num = 1;
				}
				break;
			}
			case 4:
				return;
			case 5:
				if (!IsSynchronized || base.Theme.ServerAlertBellAlignment == ObjectTextAlignment.Hide)
				{
					return;
				}
				text = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6F7F734B ^ 0x6F7FF015);
				xFont = new XFont(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-90307782 ^ -90276156), base.Canvas.ChartFont.Size);
				size = RSRsS1efz1dkvS7DNr4N(xFont, text);
				point4 = EkviaTPDHSu(point2.X, point3.X, point2.Y, LhUB6Ee90oakZk37J8Ro(base.Theme), size, afYiaCICW7G.Width);
				num = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
				{
					num = 9;
				}
				break;
			case 1:
				y = GetY(((double)num2 + 0.5) * step);
				y2 = GetY(((double)num2 - 0.5) * step);
				if (y2 - y > (double)(LineWidth + 2))
				{
					xBrush = new XBrush(LineColor, (LineColor.Alpha > 127) ? 127 : LineColor.Alpha);
					num = 11;
					break;
				}
				goto IL_0249;
			case 2:
				if (TEUiaJ0b229 == null)
				{
					return;
				}
				num = 5;
				break;
			case 6:
				return;
			case 3:
				return;
			case 9:
			{
				Rect rect = new Rect(point4.X, point4.Y, size.Width, size.Height);
				Lq3uIQe92rQ04nlDtvsQ(P_0, text, xFont, IsiiaZRNk5X, rect, XTextAlignment.Left);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b != 0)
				{
					num = 4;
				}
				break;
			}
			case 8:
			{
				FDAn2Wefuc3gPE6xsZeo(P_0, xBrush, g9QiiiapAOP);
				P_1.Add(new ObjectLabelInfo((double)num2 * step, y, y2, LineColor));
				int num3 = 6;
				num = num3;
				break;
			}
			case 7:
				P_1.Add(new ObjectLabelInfo(base.ControlPoints[0].Y, LineColor));
				num = 2;
				break;
			default:
				{
					g9QiiiapAOP = new Rect(point2, point3);
					num = 10;
					break;
				}
				IL_0249:
				P_0.DrawLine(afYiaCICW7G, point2, point3);
				num = 7;
				break;
			}
		}
	}

	public static Point EkviaTPDHSu(double P_0, double P_1, double P_2, ObjectTextAlignment P_3, Size P_4, int P_5)
	{
		double num = 0.0;
		double y = 0.0;
		int num2 = 6;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			case 2:
			case 7:
				return new Point(num, y);
			case 1:
			case 3:
			case 4:
				switch (P_3)
				{
				case ObjectTextAlignment.CenterTop:
				case ObjectTextAlignment.CenterMiddle:
				case ObjectTextAlignment.CenterBottom:
					goto IL_0103;
				case ObjectTextAlignment.RightTop:
				case ObjectTextAlignment.RightMiddle:
				case ObjectTextAlignment.RightBottom:
					goto IL_011f;
				case ObjectTextAlignment.LeftTop:
				case ObjectTextAlignment.LeftMiddle:
				case ObjectTextAlignment.LeftBottom:
					goto IL_0211;
				}
				num3 = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
				{
					num3 = 7;
				}
				break;
			case 5:
				goto IL_012f;
			case 6:
				switch (P_3)
				{
				case ObjectTextAlignment.LeftMiddle:
				case ObjectTextAlignment.CenterMiddle:
				case ObjectTextAlignment.RightMiddle:
					break;
				case ObjectTextAlignment.LeftBottom:
				case ObjectTextAlignment.CenterBottom:
				case ObjectTextAlignment.RightBottom:
					goto IL_012f;
				default:
					goto IL_01aa;
				case ObjectTextAlignment.LeftTop:
				case ObjectTextAlignment.CenterTop:
				case ObjectTextAlignment.RightTop:
					goto IL_0219;
				}
				y = P_2 - 0.5 * P_4.Height + 0.5 * (double)P_5;
				num3 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
				{
					num3 = 0;
				}
				break;
			default:
				goto IL_0211;
				IL_0219:
				y = P_2 - P_4.Height - 5.0 - 0.5 * (double)P_5;
				goto case 1;
				IL_01aa:
				num3 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 != 0)
				{
					num3 = 0;
				}
				break;
				IL_0211:
				num = P_0;
				goto case 2;
				IL_011f:
				num = P_1 - P_4.Width;
				if (num < P_0)
				{
					num = P_0;
				}
				goto case 2;
				IL_012f:
				y = P_2 + 5.0 + 0.5 * (double)P_5;
				num3 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
				{
					num3 = 4;
				}
				break;
				IL_0103:
				num = 0.5 * (P_0 + P_1 - P_4.Width);
				if (num < P_0)
				{
					num = P_0;
					num3 = 2;
					break;
				}
				goto case 2;
			}
		}
	}

	public override void BeginDrag()
	{
		KqRiapIEu5v = OriginalPrice;
		grwii0uuNqO = Price;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.BeginDrag();
	}

	public override void DrawControlPoints(DxVisualQueue P_0)
	{
		int num = 3;
		int num2 = num;
		Rect rect = default(Rect);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				P_0.FillRectangle(NWyiahKq12P, rect);
				f4d5Yqe9fyXbNufIcGAU(P_0, KVjiaKdXs9T, rect);
				return;
			case 3:
				if (T1ABNje9HBTyQITPpXSe(g9QiiiapAOP, Rect.Empty))
				{
					num2 = 2;
					break;
				}
				num3 = LineWidth / 2 + 4;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
			{
				Point point = new Point((g9QiiiapAOP.Left + g9QiiiapAOP.Right) / 2.0, (g9QiiiapAOP.Top + g9QiiiapAOP.Bottom) / 2.0);
				rect = new Rect(point, point);
				rect.Inflate(new Size(num3, num3));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	protected override bool InObject(int P_0, int P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return QNnCd1e99sWMgbchLlpl(g9QiiiapAOP, new Size(0.0, 2.0)).Contains(P_0, P_1);
			case 1:
				if (T1ABNje9HBTyQITPpXSe(g9QiiiapAOP, Rect.Empty))
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override bool IsObjectOnChart()
	{
		return true;
	}

	static btCwm4iatby5pp6Kbf1b()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool cbRAILef7KnOP7apdF60()
	{
		return uE32vsefwZSpMRESjUKg == null;
	}

	internal static btCwm4iatby5pp6Kbf1b m7VxdQef8qNSyq5TfNmZ()
	{
		return uE32vsefwZSpMRESjUKg;
	}

	internal static XColor LCJjm7efA26Ping0stdC(object P_0)
	{
		return ((IChartTheme)P_0).ServerAlertLineColor;
	}

	internal static XDashStyle LmMSCLefPGHld2LdAmCx(object P_0)
	{
		return ((IChartTheme)P_0).ServerAlertLineStyle;
	}

	internal static object B436rkefJphniKkbolje(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool vefeFMefFeP8rpXV6euM(object P_0)
	{
		return ((IChartSettings)P_0).TransformHorLines;
	}

	internal static bool sZTFL5ef3uYhun25GnF4(object P_0)
	{
		return ((IChartCanvas)P_0).IsStock;
	}

	internal static ChartStockType O89QVtefpSLpsXnLyf30(object P_0)
	{
		return ((IChartCanvas)P_0).StockType;
	}

	internal static void FDAn2Wefuc3gPE6xsZeo(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static Size RSRsS1efz1dkvS7DNr4N(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static ObjectTextAlignment LhUB6Ee90oakZk37J8Ro(object P_0)
	{
		return ((IChartTheme)P_0).ServerAlertBellAlignment;
	}

	internal static void Lq3uIQe92rQ04nlDtvsQ(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static bool T1ABNje9HBTyQITPpXSe(Rect P_0, Rect P_1)
	{
		return P_0 == P_1;
	}

	internal static void f4d5Yqe9fyXbNufIcGAU(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).DrawRectangle((XPen)P_1, P_2);
	}

	internal static Rect QNnCd1e99sWMgbchLlpl(Rect P_0, Size P_1)
	{
		return Rect.Inflate(P_0, P_1);
	}
}
