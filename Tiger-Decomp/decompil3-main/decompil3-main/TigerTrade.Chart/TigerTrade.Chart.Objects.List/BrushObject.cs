using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using DQ3RIRilFbsKdQctor4q;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "BrushObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("Brush", "ChartObjectsBrush", 2, Type = typeof(BrushObject))]
public sealed class BrushObject : LineObjectBase
{
	private List<ObjectPoint> _points;

	private static BrushObject D43sCWLuU24UdMjKH3FX;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[Browsable(false)]
	[DataMember(Name = "Points")]
	public List<ObjectPoint> Points
	{
		get
		{
			return _points ?? (_points = new List<ObjectPoint>());
		}
		set
		{
			_points = value;
		}
	}

	public void AddPoint(ObjectPoint op)
	{
		ObjectPoint objectPoint = base.ControlPoints[0];
		ObjectPoint objectPoint2 = new ObjectPoint
		{
			X = op.X - objectPoint.X,
			Y = op.Y - objectPoint.Y
		};
		int num = 2;
		ObjectPoint item = default(ObjectPoint);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				item = objectPoint2;
				num = 3;
				break;
			case 3:
				if (musdamLuZUs6X6dYQkB9(Points) > 0)
				{
					ObjectPoint objectPoint3 = Points[musdamLuZUs6X6dYQkB9(Points) - 1];
					if (item.X == objectPoint3.X && item.Y == objectPoint3.Y)
					{
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a == 0)
						{
							num = 1;
						}
						break;
					}
				}
				Points.Add(item);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		if (musdamLuZUs6X6dYQkB9(Points) < 2)
		{
			return;
		}
		ObjectPoint objectPoint = base.ControlPoints[0];
		List<ObjectPoint> list = new List<ObjectPoint>();
		int num = 5;
		List<ObjectPoint>.Enumerator enumerator = default(List<ObjectPoint>.Enumerator);
		int num2 = default(int);
		List<Point> list2 = default(List<Point>);
		Point item = default(Point);
		Point[] array = default(Point[]);
		while (true)
		{
			switch (num)
			{
			case 5:
				enumerator = Points.GetEnumerator();
				num = 7;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
				{
					num = 7;
				}
				continue;
			case 7:
				try
				{
					while (enumerator.MoveNext())
					{
						ObjectPoint current = enumerator.Current;
						list.Add(new ObjectPoint
						{
							X = current.X + objectPoint.X,
							Y = current.Y + objectPoint.Y
						});
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 3;
			case 1:
				num2 = 1;
				goto IL_00cb;
			case 6:
				num2++;
				goto IL_00cb;
			default:
			{
				Point point = list2[list2.Count - 1];
				item = array[num2];
				if (Math.Abs(point.X - item.X) > 5.0)
				{
					break;
				}
				if (Math.Abs(point.Y - item.Y) > 5.0)
				{
					num = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a != 0)
					{
						num = 3;
					}
					continue;
				}
				goto case 6;
			}
			case 2:
				return;
			case 3:
				array = ToPoints((ObjectPoint[])LboJK1LuVjfpJQwDZj4D(list));
				list2 = new List<Point> { array[0] };
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
				{
					num = 1;
				}
				continue;
			case 4:
				break;
				IL_00cb:
				if (num2 >= array.Length)
				{
					if (list2.Count < 2)
					{
						return;
					}
					MWhnpoLurAy6pVn1RZGZ(visual, base.LinePen, WxxGCiLuCrcIgF0RC9Gs(list2));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
					{
						num = 2;
					}
					continue;
				}
				goto default;
			}
			list2.Add(item);
			num = 6;
		}
	}

	protected override int GetMinDist(int x, int y)
	{
		return base.GetMinDist(x, y);
	}

	protected override bool InObject(int x, int y)
	{
		if (Points.Count < 2)
		{
			return false;
		}
		Point[] array = ToPoints((ObjectPoint[])LboJK1LuVjfpJQwDZj4D(Points));
		int num = 0;
		while (true)
		{
			int num2;
			if (num >= array.Length - 1)
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 != 0)
				{
					num2 = 0;
				}
			}
			else if (!XyaVo8ilJa9AfK2KZEye.yd5ilujJMuv(x, y, array[num], array[num + 1], base.LineWidth + 2))
			{
				num++;
				num2 = 2;
			}
			else
			{
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 != 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 1:
				return true;
			case 2:
				break;
			default:
				return false;
			}
		}
	}

	public override void ApplyTheme(IChartTheme theme)
	{
		base.ApplyTheme(theme);
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		_ = objectBase is BrushObject;
		base.CopyTemplate(objectBase, style);
	}

	public BrushObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	static BrushObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int musdamLuZUs6X6dYQkB9(object P_0)
	{
		return ((List<ObjectPoint>)P_0).Count;
	}

	internal static bool pCHjUtLuT2RRDomgfATO()
	{
		return D43sCWLuU24UdMjKH3FX == null;
	}

	internal static BrushObject o63yPLLuylCBIts4uJab()
	{
		return D43sCWLuU24UdMjKH3FX;
	}

	internal static object LboJK1LuVjfpJQwDZj4D(object P_0)
	{
		return ((List<ObjectPoint>)P_0).ToArray();
	}

	internal static object WxxGCiLuCrcIgF0RC9Gs(object P_0)
	{
		return ((List<Point>)P_0).ToArray();
	}

	internal static void MWhnpoLurAy6pVn1RZGZ(object P_0, object P_1, object P_2)
	{
		((DxVisualQueue)P_0).DrawLines((XPen)P_1, (Point[])P_2);
	}
}
