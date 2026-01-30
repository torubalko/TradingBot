using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using DQ3RIRilFbsKdQctor4q;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.List;

[ChartObject("Ellipse", "ChartObjectsEllipse", 2, Type = typeof(EllipseObject))]
[DataContract(Name = "EllipseObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public sealed class EllipseObject : PolygonObjectBase
{
	internal static EllipseObject tSZ7lRLz53vqRGHWfPGH;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.None;

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		Point point = ToPoint(base.ControlPoints[0]);
		Point point2 = ToPoint(base.ControlPoints[1]);
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
		{
			num = 1;
		}
		double num3 = default(double);
		double num2 = default(double);
		while (true)
		{
			switch (num)
			{
			case 3:
				visual.DrawEllipse(base.LinePen, new Point(point2.X, point.Y), num3, num2);
				return;
			case 1:
				num3 = Math.Abs(point2.X - point.X);
				num2 = Math.Abs(point2.Y - point.Y);
				if (num3 <= 0.0)
				{
					return;
				}
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a == 0)
				{
					num = 0;
				}
				break;
			case 2:
				if (!base.DrawBorder)
				{
					return;
				}
				goto case 3;
			default:
				if (num2 <= 0.0)
				{
					return;
				}
				if (base.DrawBack)
				{
					visual.FillEllipse(base.BackBrush, new Point(point2.X, point.Y), num3, num2);
					num = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 == 0)
					{
						num = 2;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	protected override bool InObject(int x, int y)
	{
		int num = 4;
		double x2 = default(double);
		Point[] array = default(Point[]);
		double y2 = default(double);
		double num4 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		Point point2 = default(Point);
		Point point3 = default(Point);
		double num7 = default(double);
		Point point = default(Point);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					x2 = array[1].X;
					y2 = array[0].Y;
					if (Math.Abs(num4) - ofhx9eLzLApO9Xktc9Xv(num5) > 0.0)
					{
						goto end_IL_0012;
					}
					num6 = YiSa58Lzefw1Y72xmqRD(num5 * num5 - num4 * num4);
					point2 = new Point(x2, y2 + num6);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					point3 = new Point(x2, y2 - num6);
					goto IL_00e6;
				case 5:
					point3 = new Point(x2 - num7, y2);
					goto IL_00e6;
				case 4:
					array = ToPoints(base.ControlPoints);
					num2 = 3;
					break;
				case 6:
					num5 = Math.Abs(array[1].Y - array[0].Y);
					num2 = 2;
					break;
				case 3:
					num4 = Math.Abs(array[1].X - array[0].X);
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 != 0)
					{
						num2 = 6;
					}
					break;
				default:
					{
						double num3 = oHnVUgLzsEDSqBoASitW(ofhx9eLzLApO9Xktc9Xv(num4), Math.Abs(num5));
						return Math.Abs(XyaVo8ilJa9AfK2KZEye.pFoil3yxg7x(point, point2) + XyaVo8ilJa9AfK2KZEye.pFoil3yxg7x(point, point3)) < num3 * 2.0;
					}
					IL_00e6:
					point = new Point(x, y);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num7 = Math.Sqrt(num4 * num4 - num5 * num5);
			point2 = new Point(x2 + num7, y2);
			num = 5;
		}
	}

	protected override int GetMinDist(int x, int y)
	{
		Point[] array = ToPoints(base.ControlPoints);
		double num = Math.Abs(array[1].X - array[0].X);
		double num2 = Math.Abs(array[1].Y - array[0].Y);
		double x2 = array[1].X;
		int num3 = 2;
		Point point2 = default(Point);
		double num6 = default(double);
		double y2 = default(double);
		Point point3 = default(Point);
		Point point = default(Point);
		double num4 = default(double);
		while (true)
		{
			switch (num3)
			{
			case 4:
				point2 = new Point(x2 - num6, y2);
				num3 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf == 0)
				{
					num3 = 1;
				}
				break;
			case 1:
				point3 = new Point(x, y);
				num3 = 6;
				break;
			case 2:
				y2 = array[0].Y;
				num3 = 5;
				break;
			case 3:
				num6 = Math.Sqrt(num * num - num2 * num2);
				point = new Point(x2 + num6, y2);
				num3 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
				{
					num3 = 4;
				}
				break;
			case 5:
				if (!(ofhx9eLzLApO9Xktc9Xv(num) - Math.Abs(num2) > 0.0))
				{
					num4 = Math.Sqrt(num2 * num2 - num * num);
					num3 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e != 0)
					{
						num3 = 0;
					}
				}
				else
				{
					num3 = 3;
				}
				break;
			case 6:
			{
				double num5 = Math.Min(XyaVo8ilJa9AfK2KZEye.pFoil3yxg7x(point3, point), XyaVo8ilJa9AfK2KZEye.pFoil3yxg7x(point3, point2));
				if (!(num5 > 0.0))
				{
					return -1;
				}
				return (int)num5;
			}
			default:
				point = new Point(x2, y2 + num4);
				point2 = new Point(x2, y2 - num4);
				goto case 1;
			}
		}
	}

	public EllipseObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	static EllipseObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		DKlblVLzXU5LBgJcLa2G();
	}

	internal static bool TWsKi4LzS5RiUmxNkZDm()
	{
		return tSZ7lRLz53vqRGHWfPGH == null;
	}

	internal static EllipseObject mDWV9SLzxfOGrjTOZmgl()
	{
		return tSZ7lRLz53vqRGHWfPGH;
	}

	internal static double ofhx9eLzLApO9Xktc9Xv(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static double YiSa58Lzefw1Y72xmqRD(double P_0)
	{
		return Math.Sqrt(P_0);
	}

	internal static double oHnVUgLzsEDSqBoASitW(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void DKlblVLzXU5LBgJcLa2G()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
