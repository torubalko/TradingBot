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

[ChartObject("Circle", "ChartObjectsCircle", 2, Type = typeof(CircleObject))]
[DataContract(Name = "CircleObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public sealed class CircleObject : PolygonObjectBase
{
	internal static CircleObject TV3aaZLu7EV4CCvnF3qK;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.None;

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		Point point = ToPoint(base.ControlPoints[0]);
		Point point2 = ToPoint(base.ControlPoints[1]);
		double num = XyaVo8ilJa9AfK2KZEye.pFoil3yxg7x(point, point2);
		int num2 = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
		{
			num2 = 0;
		}
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (base.DrawBack)
				{
					visual.FillEllipse(base.BackBrush, point, num, num);
					int num3 = 2;
					num2 = num3;
					continue;
				}
				break;
			case 0:
				return;
			case 2:
				break;
			}
			if (!base.DrawBorder)
			{
				break;
			}
			XSvPf0LuPdcw4i36xWaD(visual, base.LinePen, point, num, num);
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
			{
				num2 = 0;
			}
		}
	}

	protected override bool InObject(int x, int y)
	{
		Point[] array = ToPoints(base.ControlPoints);
		return XyaVo8ilJa9AfK2KZEye.pFoil3yxg7x(array[0], array[1]) > XyaVo8ilJa9AfK2KZEye.pFoil3yxg7x(array[0], new Point(x, y));
	}

	protected override int GetMinDist(int x, int y)
	{
		Point[] array = ToPoints(base.ControlPoints);
		double num = XyaVo8ilJa9AfK2KZEye.pFoil3yxg7x(array[0], array[1]) - XyaVo8ilJa9AfK2KZEye.pFoil3yxg7x(array[0], new Point(x, y));
		if (!(num > 0.0))
		{
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
			{
				num2 = 0;
			}
			return num2 switch
			{
				_ => -1, 
			};
		}
		return (int)num;
	}

	public CircleObject()
	{
		muLXacLuJh9RX3XtDYWu();
		base._002Ector();
	}

	static CircleObject()
	{
		bmUpTMLuFfnxelHgqhRv();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void XSvPf0LuPdcw4i36xWaD(object P_0, object P_1, Point P_2, double P_3, double P_4)
	{
		((DxVisualQueue)P_0).DrawEllipse((XPen)P_1, P_2, P_3, P_4);
	}

	internal static bool b9SH4GLu8tuJUCQJ1HBn()
	{
		return TV3aaZLu7EV4CCvnF3qK == null;
	}

	internal static CircleObject aIl8nXLuAWTVHNfVV0dV()
	{
		return TV3aaZLu7EV4CCvnF3qK;
	}

	internal static void muLXacLuJh9RX3XtDYWu()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static void bmUpTMLuFfnxelHgqhRv()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
