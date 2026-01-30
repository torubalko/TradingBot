using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using DQ3RIRilFbsKdQctor4q;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;

namespace k3ptRDii4wIARv6pRdUB;

[ChartObject("TrendAngle", "ChartObjectsTrendAngle", 3, Type = typeof(JZyO9ciilO8DvMv0japj))]
[DataContract(Name = "TrendAngleObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public sealed class JZyO9ciilO8DvMv0japj : LineGroupObjectBase
{
	private List<ObjectPoint> mYviisINRRZ;

	private List<Point> TG1iiXFKZnF;

	[CompilerGenerated]
	private XBrush x0PiicoW5kI;

	private XColor Iryiij19rSq;

	private int DAgiiEGrXN1;

	private int KsyiiQO3Uje;

	internal static JZyO9ciilO8DvMv0japj BNHsXce9lJtklyVH46RU;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[Browsable(false)]
	private XBrush hOPiik5wBx2
	{
		[CompilerGenerated]
		get
		{
			return x0PiicoW5kI;
		}
		[CompilerGenerated]
		set
		{
			x0PiicoW5kI = xBrush;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartCommonColor")]
	[DataMember(Name = "TextColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsText")]
	public XColor TextColor
	{
		get
		{
			return Iryiij19rSq;
		}
		set
		{
			if (!jcsu1ie9b1F2nqjhc9ZD(xColor, Iryiij19rSq))
			{
				Iryiij19rSq = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				hOPiik5wBx2 = new XBrush(Iryiij19rSq);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7DB10E6E ^ 0x7DB17130));
			}
		}
	}

	[DataMember(Name = "FontSize")]
	[DefaultValue(18)]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsSize")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsText")]
	public int FontSize
	{
		get
		{
			return DAgiiEGrXN1;
		}
		set
		{
			num = Math.Max(10, Math.Min(100, num));
			if (num != DAgiiEGrXN1)
			{
				DAgiiEGrXN1 = num;
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1192989954 ^ -1193011398));
			}
		}
	}

	[DataMember(Name = "Angle")]
	private int Angle
	{
		get
		{
			return KsyiiQO3Uje;
		}
		set
		{
			if (num != KsyiiQO3Uje)
			{
				KsyiiQO3Uje = num;
			}
		}
	}

	public JZyO9ciilO8DvMv0japj()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		TextColor = Colors.White;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		FontSize = 18;
	}

	protected override void CalcPoint()
	{
		int num = 2;
		int num2 = num;
		Point[] array = default(Point[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				array = ToPoints(base.ControlPoints);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				StartPoints[1] = new Point(array[0].X, array[0].Y);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				EndPoints[1] = new Point(array[2].X, array[2].Y);
				return;
			case 1:
				StartPoints = new Point[base.ControlPoints.Length];
				EndPoints = new Point[base.ControlPoints.Length];
				StartPoints[0] = new Point(array[0].X, array[0].Y);
				EndPoints[0] = new Point(array[1].X, array[1].Y);
				num2 = 3;
				break;
			}
		}
	}

	private bool Q01iiDrbGLN()
	{
		if (mYviisINRRZ != null)
		{
			int num = 0;
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (base.ControlPoints[num].Y != mYviisINRRZ[num].Y)
					{
						goto IL_00f4;
					}
					num++;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					if (num >= base.ControlPoints.Length)
					{
						return true;
					}
					if (base.ControlPoints[num].X == mYviisINRRZ[num].X)
					{
						num2 = 2;
						continue;
					}
					goto IL_00f4;
				case 3:
					break;
					IL_00f4:
					return false;
				}
				break;
			}
		}
		mYviisINRRZ = base.ControlPoints.ToList();
		return true;
	}

	protected override void Draw(DxVisualQueue P_0, ref List<ObjectLabelInfo> P_1)
	{
		CalcPoint();
		int num = 0;
		Point[] array = default(Point[]);
		Vector vector = default(Vector);
		Vector vector2 = default(Vector);
		int num5 = default(int);
		XFont xFont = default(XFont);
		Size size = default(Size);
		string text = default(string);
		double x = default(double);
		double y = default(double);
		int num4 = default(int);
		Point point2 = default(Point);
		Point point = default(Point);
		while (true)
		{
			IL_0257:
			int num2;
			if (num >= StartPoints.Length - 1)
			{
				array = ToPoints(base.ControlPoints);
				num2 = 10;
				goto IL_0005;
			}
			goto IL_0098;
			IL_03ac:
			vector = eY7E5je9kAHS2WNo4cxD(array[2], array[0]);
			vector2.Normalize();
			vector.Normalize();
			if (double.IsNaN(vector2.LengthSquared))
			{
				break;
			}
			num2 = 2;
			goto IL_0005;
			IL_0098:
			FrKshEe9Ni0VVMyEM8pb(P_0, base.LinePen, StartPoints[num], EndPoints[num]);
			num++;
			int num3 = 8;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
			{
				num3 = 6;
			}
			goto IL_0009;
			IL_0005:
			num3 = num2;
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num3)
				{
				case 1:
					num5 = (int)zDpYUfe91jI446HapEgC(XyaVo8ilJa9AfK2KZEye.Angle(array[0], array[1], array[2]));
					if (Angle != num5)
					{
						num3 = 11;
						continue;
					}
					goto case 14;
				case 9:
					break;
				case 11:
					if (Q01iiDrbGLN())
					{
						goto case 14;
					}
					Angle = num5;
					num3 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b != 0)
					{
						num3 = 13;
					}
					continue;
				case 3:
					goto IL_0114;
				case 7:
					return;
				case 14:
					if (Angle == 0)
					{
						return;
					}
					xFont = new XFont(((XFont)uoWlsle95lLBqVnHY3rP(base.Canvas)).Name, FontSize);
					num3 = 12;
					continue;
				case 2:
					if (double.IsNaN(vector.LengthSquared))
					{
						return;
					}
					num3 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
					{
						num3 = 1;
					}
					continue;
				case 4:
					size = xFont.GetSize(text);
					x = array[2].X + 10.0;
					y = array[2].Y + 10.0;
					num3 = 6;
					continue;
				case 6:
					if (array[2].X < array[0].X)
					{
						x = array[2].X - (size.Width + 10.0);
					}
					P_0.DrawString(text, xFont, hOPiik5wBx2, x, y);
					num4 = 20;
					point2 = array[0] + vector2 * num4;
					num3 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
					{
						num3 = 0;
					}
					continue;
				case 8:
					goto IL_0257;
				case 10:
					vector2 = eY7E5je9kAHS2WNo4cxD(array[1], array[0]);
					num3 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
					{
						num3 = 2;
					}
					continue;
				case 13:
					mYviisINRRZ = base.ControlPoints.ToList();
					num3 = 14;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
					{
						num3 = 6;
					}
					continue;
				case 12:
					text = string.Format((string)GGpGgne9SA5PMA82E1y4(0x315AB1E3 ^ 0x315A3287), v0mU8Pe9xTATnBZF7t64(Angle));
					num3 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f != 0)
					{
						num3 = 4;
					}
					continue;
				case 15:
					P_0.DrawArc(base.LinePen, point2, point, num4, 0.0);
					return;
				case 5:
					goto IL_03ac;
				default:
					point = array[0] + vector * num4;
					num3 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
					{
						num3 = 1;
					}
					continue;
				}
				break;
				IL_0114:
				if (Angle <= 0)
				{
					ATLRmte9LqwqaSGfXNJo(P_0, base.LinePen, point, point2, num4, 0.0);
					return;
				}
				num3 = 15;
			}
			goto IL_0098;
		}
	}

	public override void ApplyTheme(IChartTheme theme)
	{
		base.ApplyTheme(theme);
		TextColor = JQo1oOe9ewX4AI9VPx3y(theme);
	}

	public override void CopyTemplate(ObjectBase P_0, bool P_1)
	{
		int num = 2;
		int num2 = num;
		JZyO9ciilO8DvMv0japj jZyO9ciilO8DvMv0japj = default(JZyO9ciilO8DvMv0japj);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				jZyO9ciilO8DvMv0japj = P_0 as JZyO9ciilO8DvMv0japj;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (jZyO9ciilO8DvMv0japj != null)
				{
					TextColor = jZyO9ciilO8DvMv0japj.TextColor;
					FontSize = C3H2RBe9sNmtwJ8R7MTm(jZyO9ciilO8DvMv0japj);
				}
				base.CopyTemplate(P_0, P_1);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static JZyO9ciilO8DvMv0japj()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool SB08f2e94H8jD2fVZuwV()
	{
		return BNHsXce9lJtklyVH46RU == null;
	}

	internal static JZyO9ciilO8DvMv0japj hPMHJde9DwLvZ2kB6MlB()
	{
		return BNHsXce9lJtklyVH46RU;
	}

	internal static bool jcsu1ie9b1F2nqjhc9ZD(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static void FrKshEe9Ni0VVMyEM8pb(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static Vector eY7E5je9kAHS2WNo4cxD(Point P_0, Point P_1)
	{
		return P_0 - P_1;
	}

	internal static double zDpYUfe91jI446HapEgC(double P_0)
	{
		return Math.Floor(P_0);
	}

	internal static object uoWlsle95lLBqVnHY3rP(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static object GGpGgne9SA5PMA82E1y4(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static int v0mU8Pe9xTATnBZF7t64(int P_0)
	{
		return Math.Abs(P_0);
	}

	internal static void ATLRmte9LqwqaSGfXNJo(object P_0, object P_1, Point P_2, Point P_3, double P_4, double P_5)
	{
		((DxVisualQueue)P_0).DrawArc((XPen)P_1, P_2, P_3, P_4, P_5);
	}

	internal static XColor JQo1oOe9ewX4AI9VPx3y(object P_0)
	{
		return ((IChartTheme)P_0).ChartFontColor;
	}

	internal static int C3H2RBe9sNmtwJ8R7MTm(object P_0)
	{
		return ((JZyO9ciilO8DvMv0japj)P_0).FontSize;
	}
}
