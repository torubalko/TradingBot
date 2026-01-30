using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using DQ3RIRilFbsKdQctor4q;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.Abstract;

[DataContract(Name = "LineGroupObjectBase", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public abstract class LineGroupObjectBase : LineObjectBase
{
	protected Point[] StartPoints;

	protected Point[] EndPoints;

	private static LineGroupObjectBase dj1nEmeYB81tmNJc3X1Y;

	protected virtual void CalcPoint()
	{
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		zGQHaFeYlFOy71liS5SD(this);
		if (StartPoints == null)
		{
			return;
		}
		int num = default(int);
		if (EndPoints != null)
		{
			num = 0;
			goto IL_00ae;
		}
		int num2 = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 != 0)
		{
			num2 = 1;
		}
		goto IL_0009;
		IL_00ae:
		if (num < StartPoints.Length)
		{
			visual.DrawLine(base.LinePen, StartPoints[num], EndPoints[num]);
			num2 = 2;
		}
		else
		{
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
			{
				num2 = 0;
			}
		}
		goto IL_0009;
		IL_0009:
		switch (num2)
		{
		default:
			return;
		case 1:
			return;
		case 2:
			break;
		case 0:
			return;
		}
		num++;
		goto IL_00ae;
	}

	protected override bool InObject(int x, int y)
	{
		int num = 4;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (EndPoints == null)
				{
					goto IL_004c;
				}
				num3 = 0;
				goto case 1;
			default:
				return false;
			case 1:
				if (num3 >= StartPoints.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (sjZUHHeY4HkC5HCXWp2W(StartPoints[num3], default(Point)))
				{
					goto IL_00b1;
				}
				goto case 2;
			case 4:
				if (StartPoints != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto IL_004c;
			case 2:
				{
					if (!XyaVo8ilJa9AfK2KZEye.yd5ilujJMuv(x, y, StartPoints[num3], EndPoints[num3], NEX6XReYDjlgCtTI1VbR(this) + 2))
					{
						goto IL_00b1;
					}
					return true;
				}
				IL_004c:
				return false;
				IL_00b1:
				num3++;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected LineGroupObjectBase()
	{
		ooCM0beYbBtti2L3QtKR();
		base._002Ector();
	}

	static LineGroupObjectBase()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void zGQHaFeYlFOy71liS5SD(object P_0)
	{
		((LineGroupObjectBase)P_0).CalcPoint();
	}

	internal static bool kxdcJYeYaUJ6wVpENaYU()
	{
		return dj1nEmeYB81tmNJc3X1Y == null;
	}

	internal static LineGroupObjectBase lk6FiOeYiJpjhMAVxpJs()
	{
		return dj1nEmeYB81tmNJc3X1Y;
	}

	internal static bool sjZUHHeY4HkC5HCXWp2W(Point P_0, Point P_1)
	{
		return P_0 == P_1;
	}

	internal static int NEX6XReYDjlgCtTI1VbR(object P_0)
	{
		return ((ObjectBase)P_0).PenWidth;
	}

	internal static void ooCM0beYbBtti2L3QtKR()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}
}
