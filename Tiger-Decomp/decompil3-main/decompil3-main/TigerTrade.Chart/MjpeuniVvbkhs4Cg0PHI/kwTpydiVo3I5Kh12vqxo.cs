using System;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;

namespace MjpeuniVvbkhs4Cg0PHI;

internal static class kwTpydiVo3I5Kh12vqxo
{
	private static kwTpydiVo3I5Kh12vqxo Dy7cCveqqiq7TMB8kvFf;

	public static bool QrGiVB71CFw(Point P_0, Point P_1, Rect P_2)
	{
		bool num = kisiVa2rnVA(P_0, P_2);
		bool flag = kisiVa2rnVA(P_1, P_2);
		if (num || flag)
		{
			return true;
		}
		bool flag2 = jMWiVi9wVrD(P_0, P_2);
		bool flag3 = jMWiVi9wVrD(P_1, P_2);
		Rect rect = default(Rect);
		int num2;
		Point[] array = default(Point[]);
		if ((flag2 && !flag3) || (!flag2 && flag3))
		{
			rect = new Rect(P_2.Left + 1.0, P_2.Top + 1.0, P_2.Width - 2.0, P_2.Height - 2.0);
			num2 = 2;
		}
		else if (flag2 && flag3)
		{
			if (aTviVlPIcMu(P_0, P_1, new Point(P_2.Left, P_2.Top), new Point(P_2.Right, P_2.Top)) || DuVmEjeqtWhD0kq2GR8C(P_0, P_1, new Point(P_2.Right, P_2.Top), new Point(P_2.Right, P_2.Bottom)))
			{
				goto IL_039b;
			}
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f != 0)
			{
				num2 = 3;
			}
		}
		else
		{
			array = new Point[4]
			{
				new Point(P_2.Left, P_2.Top),
				new Point(P_2.Right, P_2.Top),
				new Point(P_2.Right, P_2.Bottom),
				new Point(P_2.Left, P_2.Bottom)
			};
			num2 = 5;
		}
		int num3 = default(int);
		Point point = default(Point);
		Point point2 = default(Point);
		Point[] array2 = default(Point[]);
		int num4 = default(int);
		Point point4 = default(Point);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (num3 < 4)
				{
					point = array[num3];
					point2 = array[(num3 + 1) % 4];
					num2 = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				return false;
			case 3:
				if (aTviVlPIcMu(P_0, P_1, new Point(P_2.Right, P_2.Bottom), new Point(P_2.Left, P_2.Bottom)))
				{
					int num5 = 10;
					num2 = num5;
					continue;
				}
				return aTviVlPIcMu(P_0, P_1, new Point(P_2.Left, P_2.Bottom), new Point(P_2.Left, P_2.Top));
			case 12:
				return true;
			default:
				return false;
			case 2:
				array2 = new Point[4]
				{
					new Point(rect.Left, rect.Top),
					new Point(rect.Right, rect.Top),
					new Point(rect.Right, rect.Bottom),
					new Point(rect.Left, rect.Bottom)
				};
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
			{
				Point point3 = array2[(num4 + 1) % 4];
				if (aTviVlPIcMu(P_0, P_1, point4, point3))
				{
					num2 = 9;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
					{
						num2 = 9;
					}
				}
				else
				{
					num4++;
					num2 = 4;
				}
				continue;
			}
			case 9:
				return true;
			case 1:
				num4 = 0;
				num2 = 8;
				continue;
			case 10:
				break;
			case 4:
			case 8:
				if (num4 < 4)
				{
					point4 = array2[num4];
					num2 = 6;
					continue;
				}
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd != 0)
				{
					num2 = 0;
				}
				continue;
			case 11:
				if (!aTviVlPIcMu(P_0, P_1, point, point2))
				{
					num3++;
					num2 = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
					{
						num2 = 7;
					}
				}
				else
				{
					num2 = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf == 0)
					{
						num2 = 12;
					}
				}
				continue;
			case 5:
				num3 = 0;
				goto case 7;
			}
			break;
		}
		goto IL_039b;
		IL_039b:
		return true;
	}

	private static bool kisiVa2rnVA(Point P_0, Rect P_1)
	{
		if (P_0.X > P_1.Left && P_0.X < P_1.Right && P_0.Y > P_1.Top)
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => P_0.Y < P_1.Bottom, 
			};
		}
		return false;
	}

	private static bool jMWiVi9wVrD(Point P_0, Rect P_1)
	{
		bool num = !YTNUJceqUhVesX0HOjMG(P_0, P_1);
		bool flag = P_0.X >= P_1.Left && P_0.X <= P_1.Right && P_0.Y >= P_1.Top && P_0.Y <= P_1.Bottom;
		return num && flag;
	}

	public static bool aTviVlPIcMu(Point P_0, Point P_1, Point P_2, Point P_3)
	{
		int num = p8PiV4IlN6W(P_0, P_1, P_2);
		int num2 = cv4AjoeqTpC0fPT87uZn(P_0, P_1, P_3);
		int num3 = p8PiV4IlN6W(P_2, P_3, P_0);
		int num4 = cv4AjoeqTpC0fPT87uZn(P_2, P_3, P_1);
		if (num != num2 && num3 != num4)
		{
			return true;
		}
		int num5;
		if (num == 0)
		{
			num5 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 != 0)
			{
				num5 = 0;
			}
			goto IL_0009;
		}
		goto IL_0116;
		IL_004b:
		if (num4 == 0)
		{
			num5 = 4;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 != 0)
			{
				num5 = 1;
			}
			goto IL_0009;
		}
		goto IL_0095;
		IL_0009:
		while (true)
		{
			switch (num5)
			{
			default:
				return true;
			case 3:
				break;
			case 2:
				return true;
			case 4:
				goto IL_00a9;
			case 5:
				return true;
			case 1:
				goto IL_0122;
			}
			if (HTMiVDRPu2G(P_2, P_0, P_3))
			{
				num5 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 != 0)
				{
					num5 = 0;
				}
				continue;
			}
			goto IL_004b;
			IL_0122:
			if (!HTMiVDRPu2G(P_0, P_2, P_1))
			{
				break;
			}
			num5 = 5;
			continue;
			IL_00a9:
			if (HTMiVDRPu2G(P_2, P_1, P_3))
			{
				num5 = 2;
				continue;
			}
			goto IL_0095;
		}
		goto IL_0116;
		IL_0116:
		if (num2 == 0 && HTMiVDRPu2G(P_0, P_3, P_1))
		{
			return true;
		}
		if (num3 == 0)
		{
			num5 = 3;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
			{
				num5 = 2;
			}
			goto IL_0009;
		}
		goto IL_004b;
		IL_0095:
		return false;
	}

	private static int p8PiV4IlN6W(Point P_0, Point P_1, Point P_2)
	{
		double num = (P_1.Y - P_0.Y) * (P_2.X - P_1.X) - (P_1.X - P_0.X) * (P_2.Y - P_1.Y);
		if (cW7kfOeqyb0ntKurilD7(num) < 1E-10)
		{
			return 0;
		}
		if (num > 0.0)
		{
			return 1;
		}
		int num2 = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
		{
			num2 = 0;
		}
		return num2 switch
		{
			_ => 2, 
		};
	}

	private static bool HTMiVDRPu2G(Point P_0, Point P_1, Point P_2)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (P_1.X <= Math.Max(P_0.X, P_2.X))
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0044;
			default:
				{
					if (P_1.X >= kNxMeaeqZpXGXa2Hbvce(P_0.X, P_2.X) && P_1.Y <= s0Y2m7eqVXVEPe6JyFwM(P_0.Y, P_2.Y))
					{
						return P_1.Y >= Math.Min(P_0.Y, P_2.Y);
					}
					goto IL_0044;
				}
				IL_0044:
				return false;
			}
		}
	}

	static kwTpydiVo3I5Kh12vqxo()
	{
		pk0aG0eqCXY8Gbgts2iR();
		pbhfjleqrDsG9qSm6I47();
	}

	internal static bool DuVmEjeqtWhD0kq2GR8C(Point P_0, Point P_1, Point P_2, Point P_3)
	{
		return aTviVlPIcMu(P_0, P_1, P_2, P_3);
	}

	internal static bool HiwM1UeqIljbty3U9Pqj()
	{
		return Dy7cCveqqiq7TMB8kvFf == null;
	}

	internal static kwTpydiVo3I5Kh12vqxo eJCgrNeqWcbQ3yx3xRVH()
	{
		return Dy7cCveqqiq7TMB8kvFf;
	}

	internal static bool YTNUJceqUhVesX0HOjMG(Point P_0, Rect P_1)
	{
		return kisiVa2rnVA(P_0, P_1);
	}

	internal static int cv4AjoeqTpC0fPT87uZn(Point P_0, Point P_1, Point P_2)
	{
		return p8PiV4IlN6W(P_0, P_1, P_2);
	}

	internal static double cW7kfOeqyb0ntKurilD7(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static double kNxMeaeqZpXGXa2Hbvce(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static double s0Y2m7eqVXVEPe6JyFwM(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void pk0aG0eqCXY8Gbgts2iR()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void pbhfjleqrDsG9qSm6I47()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
