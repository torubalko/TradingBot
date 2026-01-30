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

[DataContract(Name = "TriangleObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("Triangle", "ChartObjectsTriangle", 3, Type = typeof(TriangleObject))]
public sealed class TriangleObject : PolygonObjectBase
{
	internal static TriangleObject ty0Ptre9XwWVx27qPlUa;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.None;

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		int num = 1;
		int num2 = num;
		Point[] array = default(Point[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				array = ToPoints(base.ControlPoints);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (array.Length == 0)
			{
				return;
			}
			if (base.DrawBack)
			{
				jmNW4ye9EP0a2r6wYLhA(visual, base.BackBrush, array);
			}
			if (!base.DrawBorder)
			{
				return;
			}
			visual.DrawPolygon(base.LinePen, array);
			num2 = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 != 0)
			{
				num2 = 2;
			}
		}
	}

	protected override bool InObject(int x, int y)
	{
		Point[] array = ToPoints(base.ControlPoints);
		double num = (array[0].X - (double)x) * (array[1].Y - array[0].Y) - (array[1].X - array[0].X) * (array[0].Y - (double)y);
		int num2 = 3;
		double num3 = default(double);
		double num4 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = (array[2].X - (double)x) * (array[0].Y - array[2].Y) - (array[0].X - array[2].X) * (array[2].Y - (double)y);
				num2 = 2;
				break;
			case 2:
				if (!(num >= 0.0) || !(num4 >= 0.0) || !(num3 >= 0.0))
				{
					if (!(num <= 0.0) || !(num4 <= 0.0))
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f != 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			case 3:
				num4 = (array[1].X - (double)x) * (array[2].Y - array[1].Y) - (array[2].X - array[1].X) * (array[1].Y - (double)y);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return num3 <= 0.0;
			}
		}
	}

	protected override int GetMinDist(int x, int y)
	{
		int num = 1;
		int num2 = num;
		Point[] array = default(Point[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				array = ToPoints(base.ControlPoints);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			double num3 = A3Ftmye9QBdvm1Dp0BZF(x, y, array[0], array[1]);
			double val = A3Ftmye9QBdvm1Dp0BZF(x, y, array[1], array[2]);
			double val2 = XyaVo8ilJa9AfK2KZEye.a3kilpJDIm1(x, y, array[2], array[0]);
			double num4 = BKOHaxe9dxvEVKPxQ8X9(num3, Math.Min(val, val2));
			if (!(num4 > 0.0))
			{
				return -1;
			}
			return (int)num4;
		}
	}

	public TriangleObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	static TriangleObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void jmNW4ye9EP0a2r6wYLhA(object P_0, object P_1, object P_2)
	{
		((DxVisualQueue)P_0).FillPolygon((XBrush)P_1, (Point[])P_2);
	}

	internal static bool PSQ8AFe9cD9wObDnuMB9()
	{
		return ty0Ptre9XwWVx27qPlUa == null;
	}

	internal static TriangleObject y9KUd6e9jObWuq7oOTqj()
	{
		return ty0Ptre9XwWVx27qPlUa;
	}

	internal static double A3Ftmye9QBdvm1Dp0BZF(int P_0, int P_1, Point P_2, Point P_3)
	{
		return XyaVo8ilJa9AfK2KZEye.a3kilpJDIm1(P_0, P_1, P_2, P_3);
	}

	internal static double BKOHaxe9dxvEVKPxQ8X9(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}
}
