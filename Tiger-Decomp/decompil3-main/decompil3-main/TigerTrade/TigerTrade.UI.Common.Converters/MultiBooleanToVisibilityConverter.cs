using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

internal sealed class MultiBooleanToVisibilityConverter : IMultiValueConverter
{
	internal static MultiBooleanToVisibilityConverter Dt72CDDXoeZpZOUiSlIh;

	public object Convert(object[] P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int num = 1;
		bool flag2 = default(bool);
		int num3 = default(int);
		object[] array = default(object[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				switch (num2)
				{
				case 3:
					if (!flag2)
					{
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					num4 = 0;
					break;
				case 1:
					flag2 = true;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					num4 = 2;
					break;
				case 2:
				case 5:
					if (num3 < array.Length)
					{
						if (array[num3] is bool flag)
						{
							flag2 = flag2 && flag;
						}
						num3++;
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto end_IL_0012;
				default:
					array = P_0;
					num3 = 0;
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				return (Visibility)num4;
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public object[] ConvertBack(object P_0, Type[] P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public MultiBooleanToVisibilityConverter()
	{
		kahRYIDXa03c62x9oltL();
		base._002Ector();
	}

	static MultiBooleanToVisibilityConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool yB4I7SDXvMDOkC6xtYkB()
	{
		return Dt72CDDXoeZpZOUiSlIh == null;
	}

	internal static MultiBooleanToVisibilityConverter AXMNgiDXB7tYgpSMIKUt()
	{
		return Dt72CDDXoeZpZOUiSlIh;
	}

	internal static void kahRYIDXa03c62x9oltL()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
