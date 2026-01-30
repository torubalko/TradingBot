using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using DQ3RIRilFbsKdQctor4q;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "ArrowObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("Arrow", "ChartObjectsArrow", 2, Type = typeof(ArrowObject))]
public sealed class ArrowObject : LineObjectBase
{
	internal static ArrowObject CVRcg1LuRGQZ5RtCacNd;

	public override ChartDataType ChartDataType => ChartDataType.Bar;

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		int num = 1;
		Matrix matrix = default(Matrix);
		Point point = default(Point);
		Point point2 = default(Point);
		Point[] array = default(Point[]);
		while (true)
		{
			int num2 = num;
			Vector vector;
			while (true)
			{
				switch (num2)
				{
				case 4:
					matrix.Rotate(30.0);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee != 0)
					{
						num2 = 2;
					}
					break;
				default:
					point = ToPoint(base.ControlPoints[1]);
					visual.DrawLine(base.LinePen, point2, point);
					if (nWSey7LuO1y3Nn0mj5e5(point2, point))
					{
						return;
					}
					goto end_IL_0012;
				case 2:
					array[0] = k8yI1PLuqEXkq1Oks4Rq(point, vector * matrix);
					num2 = 6;
					break;
				case 5:
					return;
				case 3:
					array = new Point[3]
					{
						default(Point),
						point,
						default(Point)
					};
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					point2 = ToPoint(base.ControlPoints[0]);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					matrix.Rotate(-60.0);
					array[2] = k8yI1PLuqEXkq1Oks4Rq(point, UcnqvSLuI3LnfrNeYCnD(vector, matrix));
					visual.DrawLines(base.LinePen, array);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
					{
						num2 = 5;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			matrix = default(Matrix);
			vector = point2 - point;
			vector.Normalize();
			vector *= (double)(12 + base.LineWidth * 2);
			num = 3;
		}
	}

	protected override bool InObject(int x, int y)
	{
		Point[] array = ToPoints(base.ControlPoints);
		int num = 0;
		int num2 = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd == 0)
		{
			num2 = 1;
		}
		while (true)
		{
			switch (num2)
			{
			default:
				return true;
			case 1:
				break;
			}
			while (true)
			{
				if (num >= array.Length - 1)
				{
					return false;
				}
				if (XGAfvwLuWZgODtewTeR1(x, y, array[num], array[num + 1], base.LineWidth + 2))
				{
					break;
				}
				num++;
			}
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 != 0)
			{
				num2 = 0;
			}
		}
	}

	public ArrowObject()
	{
		aqLBRnLutNAMy8DVooqJ();
		base._002Ector();
	}

	static ArrowObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool nWSey7LuO1y3Nn0mj5e5(Point P_0, Point P_1)
	{
		return P_0 == P_1;
	}

	internal static Point k8yI1PLuqEXkq1Oks4Rq(Point P_0, Vector P_1)
	{
		return P_0 + P_1;
	}

	internal static Vector UcnqvSLuI3LnfrNeYCnD(Vector P_0, Matrix P_1)
	{
		return P_0 * P_1;
	}

	internal static bool F2k4aqLu6PhTCN2LtiGt()
	{
		return CVRcg1LuRGQZ5RtCacNd == null;
	}

	internal static ArrowObject gCFegrLuMOxv5xYrkHCm()
	{
		return CVRcg1LuRGQZ5RtCacNd;
	}

	internal static bool XGAfvwLuWZgODtewTeR1(int P_0, int P_1, Point P_2, Point P_3, int P_4)
	{
		return XyaVo8ilJa9AfK2KZEye.yd5ilujJMuv(P_0, P_1, P_2, P_3, P_4);
	}

	internal static void aqLBRnLutNAMy8DVooqJ()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}
}
