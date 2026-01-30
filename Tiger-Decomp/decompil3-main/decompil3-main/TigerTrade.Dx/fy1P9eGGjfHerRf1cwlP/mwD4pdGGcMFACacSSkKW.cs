using System;
using System.Windows;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;

namespace fy1P9eGGjfHerRf1cwlP;

internal static class mwD4pdGGcMFACacSSkKW
{
	internal static mwD4pdGGcMFACacSSkKW OvyNixkXVUkAdiGaEypl;

	public static void RX6GGEKprXg(Point[] P_0, out Point[] P_1, out Point[] P_2)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-1251569705 ^ -1251569705));
		}
		int num = P_0.Length - 1;
		int num2 = 4;
		double[] array3 = default(double[]);
		double[] array = default(double[]);
		int num3 = default(int);
		int num4 = default(int);
		double[] array2 = default(double[]);
		int num5 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				array3 = (double[])i8QUeQkXKD5CrBTl3Wbb(array);
				num2 = 12;
				break;
			case 5:
				num3++;
				num2 = 5;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_0dddf5ef66c34125ab2fb5b0d18a207d == 0)
				{
					num2 = 9;
				}
				break;
			case 9:
				if (num3 >= num - 1)
				{
					array[0] = P_0[0].X + 2.0 * P_0[1].X;
					array[num - 1] = (8.0 * P_0[num - 1].X + P_0[num].X) / 2.0;
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9ea6ac1b9978445f984c9b1d9e0008bf == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					array[num3] = 4.0 * P_0[num3].X + 2.0 * P_0[num3 + 1].X;
					num2 = 5;
				}
				break;
			case 15:
				P_2[num4] = new Point(2.0 * P_0[num4 + 1].X - array2[num4 + 1], 2.0 * P_0[num4 + 1].Y - array3[num4 + 1]);
				goto case 7;
			case 13:
				P_1[num4] = new Point(array2[num4], array3[num4]);
				num2 = 8;
				break;
			case 14:
				P_1[0].X = (2.0 * P_0[0].X + P_0[1].X) / 3.0;
				P_1[0].Y = (2.0 * P_0[0].Y + P_0[1].Y) / 3.0;
				P_2 = new Point[1];
				P_2[0].X = 2.0 * P_1[0].X - P_0[0].X;
				P_2[0].Y = 2.0 * P_1[0].Y - P_0[0].Y;
				return;
			case 3:
				num5 = 1;
				num2 = 3;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9dc87266080545b1b4e0ed15ee567184 != 0)
				{
					num2 = 11;
				}
				break;
			default:
				array2 = (double[])i8QUeQkXKD5CrBTl3Wbb(array);
				num2 = 3;
				break;
			case 8:
				if (num4 >= num - 1)
				{
					P_2[num4] = new Point((P_0[num].X + array2[num - 1]) / 2.0, (P_0[num].Y + array3[num - 1]) / 2.0);
					num2 = 2;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e3c56040434a4a628f0f01cc04d0408d == 0)
					{
						num2 = 7;
					}
				}
				else
				{
					num2 = 15;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_184a9da0ab194171b7012b62e9cac4a3 == 0)
					{
						num2 = 14;
					}
				}
				break;
			case 2:
			{
				array[num5] = 4.0 * P_0[num5].Y + 2.0 * P_0[num5 + 1].Y;
				num5++;
				int num6 = 10;
				num2 = num6;
				break;
			}
			case 4:
				if (num < 1)
				{
					throw new ArgumentException(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x6AB40973 ^ 0x6AB4097D), vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x7DB10E6E ^ 0x7DB10E6E));
				}
				if (num == 1)
				{
					P_1 = new Point[1];
					num2 = 14;
					break;
				}
				array = new double[num];
				num3 = 1;
				goto case 9;
			case 10:
			case 11:
				if (num5 >= num - 1)
				{
					array[0] = P_0[0].Y + 2.0 * P_0[1].Y;
					array[num - 1] = (8.0 * P_0[num - 1].Y + P_0[num].Y) / 2.0;
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_f1601605e25a48e58f87674317e812a9 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 7:
				num4++;
				goto IL_03ea;
			case 6:
				P_2 = new Point[num];
				num4 = 0;
				goto IL_03ea;
			case 12:
				{
					P_1 = new Point[num];
					num2 = 6;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_ddce9f0563524ee592adad7a07e5ceaf != 0)
					{
						num2 = 4;
					}
					break;
				}
				IL_03ea:
				if (num4 >= num)
				{
					return;
				}
				goto case 13;
			}
		}
	}

	private static double[] mYBGGQry1l1(double[] P_0)
	{
		int num = P_0.Length;
		double[] array = new double[num];
		int num2 = 4;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_7e2cedcef3cc4cf38b7bccbb81c290d2 == 0)
		{
			num2 = 2;
		}
		int num3 = default(int);
		double[] array2 = default(double[]);
		double num4 = default(double);
		int num5 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 7:
				array[num - num3 - 1] -= array2[num - num3] * array[num - num3];
				num2 = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_dfe9f5da877a401b848251d2d558dcec != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				array2 = new double[num];
				num4 = 2.0;
				array[0] = P_0[0] / num4;
				num5 = 1;
				num2 = 3;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_80f73fd0542d40589be6ac0a306f5ee4 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				if (num5 < num)
				{
					array2[num5] = 1.0 / num4;
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_92fde72072f340cbb1258afbb2ecb037 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
				}
				break;
			case 1:
				num3++;
				goto case 5;
			case 6:
				num5++;
				goto case 3;
			default:
				num4 = ((num5 < num - 1) ? 4.0 : 3.5) - array2[num5];
				array[num5] = (P_0[num5] - array[num5 - 1]) / num4;
				num2 = 6;
				break;
			case 5:
				if (num3 >= num)
				{
					return array;
				}
				goto case 7;
			case 2:
				num3 = 1;
				num2 = 4;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_bd607e2f58ca463285fecec2cbb1549f != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	static mwD4pdGGcMFACacSSkKW()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object i8QUeQkXKD5CrBTl3Wbb(object P_0)
	{
		return mYBGGQry1l1((double[])P_0);
	}

	internal static bool mgZV3LkXCf9QrdYXTty0()
	{
		return OvyNixkXVUkAdiGaEypl == null;
	}

	internal static mwD4pdGGcMFACacSSkKW fAovjokXr8Q1J97sAWoM()
	{
		return OvyNixkXVUkAdiGaEypl;
	}
}
