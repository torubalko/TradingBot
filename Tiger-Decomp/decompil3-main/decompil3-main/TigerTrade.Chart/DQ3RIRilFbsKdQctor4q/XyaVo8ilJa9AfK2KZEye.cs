using System;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Objects.Common;

namespace DQ3RIRilFbsKdQctor4q;

internal static class XyaVo8ilJa9AfK2KZEye
{
	private static XyaVo8ilJa9AfK2KZEye Q8i7NVeGcOQaerV2Iqt9;

	public static double pFoil3yxg7x(Point P_0, Point P_1)
	{
		double num = P_0.X - P_1.X;
		double num2 = P_0.Y - P_1.Y;
		return Math.Sqrt(num * num + num2 * num2);
	}

	public static double a3kilpJDIm1(int P_0, int P_1, Point P_2, Point P_3)
	{
		double num = P_2.X - P_3.X;
		double num2 = P_2.Y - P_3.Y;
		return (((double)P_0 - P_2.X) * (P_3.Y - P_2.Y) - (P_3.X - P_2.X) * ((double)P_1 - P_2.Y)) / gCZrHWeGQDRKmToxj6f1(num * num + num2 * num2);
	}

	public static bool yd5ilujJMuv(int P_0, int P_1, Point P_2, Point P_3, int P_4)
	{
		int num = 2;
		int num2 = num;
		double num6 = default(double);
		double num5 = default(double);
		double num3 = default(double);
		double num4 = default(double);
		while (true)
		{
			switch (num2)
			{
			default:
				num6 = Math.Min(P_2.Y, P_3.Y);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				if (Math.Abs(a3kilpJDIm1(P_0, P_1, P_2, P_3)) <= (double)P_4 && (double)P_0 <= num5 + (double)P_4 && (double)P_0 >= num3 - (double)P_4 && (double)P_1 <= num4 + (double)P_4)
				{
					return (double)P_1 >= num6 - (double)P_4;
				}
				return false;
			case 2:
				num5 = Math.Max(P_2.X, P_3.X);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				num3 = AAWJlheGdiBFUN8BfeEZ(P_2.X, P_3.X);
				num4 = YDntCCeGgYQqV52RuJU1(P_2.Y, P_3.Y);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool cjPilzesqJS(int P_0, int P_1, Point[] P_2, int P_3, bool P_4)
	{
		if (P_2 == null)
		{
			return false;
		}
		int num = 0;
		int num2 = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a != 0)
		{
			num2 = 0;
		}
		while (true)
		{
			switch (num2)
			{
			case 2:
				return false;
			case 1:
				return true;
			default:
				while (num < P_2.Length - ((!P_4) ? 1 : 0))
				{
					if (!yd5ilujJMuv(P_0, P_1, P_2[num], P_2[(num + 1) % P_2.Length], P_3))
					{
						num++;
						continue;
					}
					goto case 1;
				}
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public static bool uDai40BIcET(int P_0, int P_1, double P_2, double P_3, double P_4, double P_5, int P_6)
	{
		int num = 1;
		int num2 = num;
		Point point3 = default(Point);
		double num3 = default(double);
		Point point = default(Point);
		Point point2 = default(Point);
		double num4 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 4:
				point3 = new Point(P_2 - num3, P_3);
				goto IL_0057;
			case 1:
				if (FspxHBeGRV3tbx5oaONL(P_4) - Math.Abs(P_5) > 0.0)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
			{
				double num5 = Math.Sqrt(P_5 * P_5 - P_4 * P_4);
				point = new Point(P_2, P_3 + num5);
				point3 = new Point(P_2, P_3 - num5);
				goto IL_0057;
			}
			case 2:
				return FspxHBeGRV3tbx5oaONL(pFoil3yxg7x(point2, point) + Ws0QR2eG6Kd511p1RLVb(point2, point3) - num4 * 2.0) <= (double)P_6;
			default:
				{
					num3 = gCZrHWeGQDRKmToxj6f1(P_4 * P_4 - P_5 * P_5);
					point = new Point(P_2 + num3, P_3);
					num2 = 4;
					break;
				}
				IL_0057:
				point2 = new Point(P_0, P_1);
				num4 = Math.Max(Math.Abs(P_4), Math.Abs(P_5));
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public static void LkYi424Ks5t(IChartCanvas P_0, Point P_1, Point P_2, out Point P_3)
	{
		int num = 7;
		int num2 = num;
		double num6 = default(double);
		double num3 = default(double);
		Rect rect = default(Rect);
		double num4 = default(double);
		double num5 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 10:
				return;
			case 2:
			case 4:
				P_3 = new Point(num6, num3);
				return;
			case 13:
				num3 = P_2.Y;
				rect = P_0.Rect;
				if (!(num4 < 0.0))
				{
					if (num4 > 0.0)
					{
						num6 = rect.Right;
						num2 = 11;
						break;
					}
				}
				else
				{
					num6 = 0.0;
				}
				goto case 11;
			case 8:
				num3 = rect.Top;
				goto IL_00ef;
			case 3:
				num3 = rect.Top;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
				{
					num2 = 4;
				}
				break;
			case 9:
				if (!qF7careGMThm5iAOVUtR(P_2, default(Point)))
				{
					num4 = P_2.X - P_1.X;
					num5 = P_2.Y - P_1.Y;
					num6 = P_2.X;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
					{
						num2 = 13;
					}
					break;
				}
				goto IL_00d0;
			default:
				if (!(num3 < rect.Top))
				{
					num2 = 12;
					break;
				}
				goto IL_021c;
			case 6:
				if (!qF7careGMThm5iAOVUtR(P_1, default(Point)))
				{
					num2 = 9;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto IL_00d0;
			case 12:
				if (!(num3 > rect.Bottom))
				{
					goto case 2;
				}
				goto IL_021c;
			case 11:
				if (num4 != 0.0)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
					{
						num2 = 1;
					}
					break;
				}
				if (num5 > 0.0)
				{
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			case 1:
				num3 = (num6 - P_2.X) / num4 * num5 + P_2.Y;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				if (P_0 != null)
				{
					num2 = 6;
					break;
				}
				goto IL_00d0;
			case 5:
				{
					num3 = rect.Bottom;
					num2 = 2;
					break;
				}
				IL_00d0:
				P_3 = P_2;
				num2 = 10;
				break;
				IL_021c:
				if (num3 > rect.Bottom)
				{
					num3 = rect.Bottom;
				}
				else if (num3 < rect.Top)
				{
					num2 = 8;
					break;
				}
				goto IL_00ef;
				IL_00ef:
				if (num5 != 0.0)
				{
					num6 = (num3 - P_2.Y) / num5 * num4 + P_2.X;
				}
				goto case 2;
			}
		}
	}

	public static double Angle(Point p1, Point p2, Point p3)
	{
		return Vector.AngleBetween(p2 - p1, p3 - p1);
	}

	public static double Angle(ObjectPoint p1, ObjectPoint p2, ObjectPoint p3)
	{
		Point point = new Point(p1.X, p1.Y);
		Point point2 = new Point(p2.X, p2.Y);
		return Vector.AngleBetween(vector2: new Point(p3.X, p3.Y) - point, vector1: point2 - point);
	}

	static XyaVo8ilJa9AfK2KZEye()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		hGmreoeGOyqahrWj5coO();
	}

	internal static bool YwAEOseGjvNiOqljXBWN()
	{
		return Q8i7NVeGcOQaerV2Iqt9 == null;
	}

	internal static XyaVo8ilJa9AfK2KZEye s158DaeGEujFTtZm6mpW()
	{
		return Q8i7NVeGcOQaerV2Iqt9;
	}

	internal static double gCZrHWeGQDRKmToxj6f1(double P_0)
	{
		return Math.Sqrt(P_0);
	}

	internal static double AAWJlheGdiBFUN8BfeEZ(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static double YDntCCeGgYQqV52RuJU1(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static double FspxHBeGRV3tbx5oaONL(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static double Ws0QR2eG6Kd511p1RLVb(Point P_0, Point P_1)
	{
		return pFoil3yxg7x(P_0, P_1);
	}

	internal static bool qF7careGMThm5iAOVUtR(Point P_0, Point P_1)
	{
		return P_0 == P_1;
	}

	internal static void hGmreoeGOyqahrWj5coO()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
