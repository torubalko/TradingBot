using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

internal class IntToVisibleConverter : IValueConverter
{
	private static IntToVisibleConverter eAAcj0Dxyhbm9c7FNwyX;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		object result = default(object);
		try
		{
			int num;
			if ((int?)P_0 != 0)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
				{
					num = 1;
				}
				goto IL_001a;
			}
			int num2 = 2;
			goto IL_0072;
			IL_001a:
			switch (num)
			{
			default:
				goto end_IL_0009;
			case 1:
				num2 = 0;
				break;
			case 0:
				goto end_IL_0009;
			}
			goto IL_0072;
			IL_0072:
			result = (Visibility)num2;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
			{
				num = 0;
			}
			goto IL_001a;
			end_IL_0009:;
		}
		catch (Exception)
		{
			result = Visibility.Visible;
		}
		return result;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public IntToVisibleConverter()
	{
		aZE7NMDxC4iNXZLS5cxc();
		base._002Ector();
	}

	static IntToVisibleConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool tZcxuVDxZj2QqiYwNX5D()
	{
		return eAAcj0Dxyhbm9c7FNwyX == null;
	}

	internal static IntToVisibleConverter zbAAAlDxVvFYup5eLQtl()
	{
		return eAAcj0Dxyhbm9c7FNwyX;
	}

	internal static void aZE7NMDxC4iNXZLS5cxc()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
