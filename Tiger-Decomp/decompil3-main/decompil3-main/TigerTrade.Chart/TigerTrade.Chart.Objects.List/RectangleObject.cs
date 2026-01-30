using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "RectangleObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("Rectangle", "ChartObjectsRectangle", 2, Type = typeof(RectangleObject))]
public class RectangleObject : PolygonObjectBase
{
	public class OMLr46iChQEV6FRmSOMR
	{
		public Point FltiCwIq5gX;

		public Point b2iiC7Sspas;

		public Point up0iC86P1TV;

		public Point s6IiCA3yCP3;

		public Rect Rectangle;

		private static OMLr46iChQEV6FRmSOMR d6HDsLetE4KCHoH8PFfI;

		public OMLr46iChQEV6FRmSOMR()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			base._002Ector();
		}

		static OMLr46iChQEV6FRmSOMR()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool tLM2bDetQjMAuDhLyrv7()
		{
			return d6HDsLetE4KCHoH8PFfI == null;
		}

		internal static OMLr46iChQEV6FRmSOMR RBlNbeetdMNuSK6J0p9w()
		{
			return d6HDsLetE4KCHoH8PFfI;
		}
	}

	private bool _isObjectInArea;

	internal static RectangleObject zHIrXlefysxY11TTe2t2;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[Browsable(false)]
	public OMLr46iChQEV6FRmSOMR RectInfo { get; private set; }

	public override ObjectPoint[] ExtraPoints
	{
		get
		{
			ObjectPoint objectPoint = base.ControlPoints[0];
			ObjectPoint objectPoint2 = base.ControlPoints[1];
			ObjectPoint objectPoint3 = new ObjectPoint(objectPoint2.X, objectPoint.Y);
			ObjectPoint objectPoint4 = new ObjectPoint(objectPoint.X, objectPoint2.Y);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => new ObjectPoint[2] { objectPoint3, objectPoint4 }, 
			};
		}
	}

	protected override void Prepare()
	{
		int num = 7;
		int num2 = num;
		Point s6IiCA3yCP = default(Point);
		double num4 = default(double);
		Point point2 = default(Point);
		Point up0iC86P1TV = default(Point);
		Point point = default(Point);
		double num5 = default(double);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 1:
				s6IiCA3yCP.Y += num4;
				goto case 2;
			case 6:
				point2 = ToPoint(base.ControlPoints[1]);
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				up0iC86P1TV = ToPoint(ExtraPoints[0]);
				s6IiCA3yCP = ToPoint(ExtraPoints[1]);
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
				{
					num2 = 4;
				}
				break;
			case 7:
				point = ToPoint(base.ControlPoints[0]);
				num2 = 6;
				break;
			case 5:
				num5 = base.Canvas.ColumnWidth / 2.0;
				num2 = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				num4 = base.Canvas.StepHeight / 2.0;
				if (base.Canvas.StockType != ChartStockType.Clusters)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
					{
						num2 = 0;
					}
					break;
				}
				num3 = 1;
				goto IL_0277;
			default:
				num3 = (cnQrIeefrPjhxFI0aUR0(base.ID, aiKEamefCNwDE59N5l1x(0x37B74BDF ^ 0x37B7C8DD)) ? 1 : 0);
				goto IL_0277;
			case 2:
				{
					RectInfo = new OMLr46iChQEV6FRmSOMR
					{
						FltiCwIq5gX = point,
						b2iiC7Sspas = point2,
						up0iC86P1TV = up0iC86P1TV,
						s6IiCA3yCP3 = s6IiCA3yCP,
						Rectangle = new Rect(point, point2)
					};
					_isObjectInArea = base.Canvas.Rect.IntersectsWith(RectInfo.Rectangle);
					return;
				}
				IL_0277:
				if (point.X > point2.X)
				{
					point.X += num5;
					point2.X -= num5;
				}
				else
				{
					point.X -= num5;
					point2.X += num5;
				}
				if (num3 != 0)
				{
					if (point.Y > point2.Y)
					{
						point.Y += num4;
						point2.Y -= num4;
					}
					else
					{
						point.Y -= num4;
						point2.Y += num4;
					}
				}
				if (up0iC86P1TV.X > s6IiCA3yCP.X)
				{
					up0iC86P1TV.X += num5;
					s6IiCA3yCP.X -= num5;
				}
				else
				{
					up0iC86P1TV.X -= num5;
					s6IiCA3yCP.X += num5;
				}
				if (num3 != 0)
				{
					if (up0iC86P1TV.Y > s6IiCA3yCP.Y)
					{
						up0iC86P1TV.Y += num4;
						s6IiCA3yCP.Y -= num4;
						num2 = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 != 0)
						{
							num2 = 2;
						}
					}
					else
					{
						up0iC86P1TV.Y -= num4;
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
						{
							num2 = 1;
						}
					}
					break;
				}
				goto case 2;
			}
		}
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		if (base.DrawBack)
		{
			visual.FillRectangle(base.BackBrush, RectInfo.Rectangle);
		}
		if (base.DrawBorder)
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			visual.DrawRectangle(base.LinePen, RectInfo.Rectangle);
		}
	}

	public override void DrawControlPoints(DxVisualQueue visual)
	{
		if (RectInfo == null)
		{
			return;
		}
		DrawControlPoint(visual, RectInfo.FltiCwIq5gX);
		DrawControlPoint(visual, RectInfo.b2iiC7Sspas);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				DrawControlPoint(visual, RectInfo.s6IiCA3yCP3);
				return;
			}
			DrawControlPoint(visual, RectInfo.up0iC86P1TV);
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
			{
				num = 0;
			}
		}
	}

	public override int GetControlPoint(int x, int y)
	{
		int num = 1;
		int num2 = num;
		Point[] array = default(Point[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				if (RectInfo == null)
				{
					goto IL_0074;
				}
				array = new Point[2] { RectInfo.FltiCwIq5gX, RectInfo.b2iiC7Sspas };
				num3 = 0;
				goto case 4;
			case 3:
				return -1;
			case 1:
				if (base.Canvas != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0074;
			case 2:
			{
				double num4 = array[num3].X - (double)x;
				double num5 = array[num3].Y - (double)y;
				if (num4 * num4 + num5 * num5 < 9.0 + (double)PenWidth / 2.0)
				{
					return num3;
				}
				num3++;
				num2 = 4;
				break;
			}
			case 4:
				{
					if (num3 >= array.Length)
					{
						num2 = 3;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
				IL_0074:
				return -1;
			}
		}
	}

	public override int GetExtraPoint(int x, int y)
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return num3;
			default:
				return -1;
			case 1:
				if (base.Canvas == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				break;
			}
			if (RectInfo != null)
			{
				Point[] array = new Point[2] { RectInfo.up0iC86P1TV, RectInfo.s6IiCA3yCP3 };
				num3 = 0;
				while (true)
				{
					if (num3 >= array.Length)
					{
						return -1;
					}
					double num4 = array[num3].X - (double)x;
					double num5 = array[num3].Y - (double)y;
					if (num4 * num4 + num5 * num5 < 9.0 + (double)PenWidth / 2.0)
					{
						break;
					}
					num3++;
				}
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
				{
					num2 = 3;
				}
			}
			else
			{
				num2 = 4;
			}
		}
	}

	protected override bool IsObjectInArea()
	{
		return _isObjectInArea;
	}

	protected override bool InObject(int x, int y)
	{
		if (RectInfo == null)
		{
			return false;
		}
		if (VRVNkEefmFPNGcKUKsy4(RectInfo.Rectangle, AJUFFNefK9MSHdvPlLfr()))
		{
			return RectInfo.Rectangle.Contains(x, y);
		}
		return false;
	}

	protected override int GetMinDist(int x, int y)
	{
		int num = 1;
		int num2 = num;
		Rect rectangle = default(Rect);
		while (true)
		{
			switch (num2)
			{
			case 1:
				rectangle = RectInfo.Rectangle;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
				{
					num2 = 0;
				}
				continue;
			}
			double val = Math.Min(rectangle.X + rectangle.Width - (double)x, (double)x - rectangle.X);
			double val2 = DlOiBjefhrpSc38COv3t(rectangle.Y + rectangle.Height - (double)y, (double)y - rectangle.Y);
			double num3 = Math.Min(val, val2);
			if (!(num3 > 0.0))
			{
				return -1;
			}
			return (int)num3;
		}
	}

	public override void ExtraPointChanged(int index, ObjectPoint op)
	{
		int num;
		if (index == 0)
		{
			base.ControlPoints[1].X = op.X;
			base.ControlPoints[0].Y = op.Y;
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_00da;
		IL_0009:
		switch (num)
		{
		case 2:
			base.ControlPoints[1].Y = op.Y;
			return;
		case 1:
			return;
		}
		goto IL_00da;
		IL_00da:
		if (index != 1)
		{
			return;
		}
		base.ControlPoints[0].X = op.X;
		num = 2;
		goto IL_0009;
	}

	public RectangleObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	static RectangleObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool k75OqyefZ4GKNTRIJUOG()
	{
		return zHIrXlefysxY11TTe2t2 == null;
	}

	internal static RectangleObject ofow0tefVtZNTZF27DUt()
	{
		return zHIrXlefysxY11TTe2t2;
	}

	internal static object aiKEamefCNwDE59N5l1x(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool cnQrIeefrPjhxFI0aUR0(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Rect AJUFFNefK9MSHdvPlLfr()
	{
		return Rect.Empty;
	}

	internal static bool VRVNkEefmFPNGcKUKsy4(Rect P_0, Rect P_1)
	{
		return P_0 != P_1;
	}

	internal static double DlOiBjefhrpSc38COv3t(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}
}
