using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using vpwhoy2uK6omT7YERhoY;

namespace TigerTrade.UI.Common.Converters;

public class ObjectToVisibilityConverter : IValueConverter
{
	private static ObjectToVisibilityConverter wOFm7vDxATgKOa1mZw7Z;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (P_0 is jWwovh2urRpGSqRUD0RN jWwovh2urRpGSqRUD0RN)
		{
			int num2;
			while (true)
			{
				if (!(NH2txBDxF7bvvyG3e31t(jWwovh2urRpGSqRUD0RN) is CategoryModel))
				{
					int num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
					{
						num = 0;
					}
					switch (num)
					{
					case 1:
						continue;
					}
					num2 = 2;
				}
				else
				{
					num2 = 0;
				}
				break;
			}
			return (Visibility)num2;
		}
		return Visibility.Visible;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		return null;
	}

	public ObjectToVisibilityConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static ObjectToVisibilityConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object NH2txBDxF7bvvyG3e31t(object P_0)
	{
		return ((DataModelBase)P_0).Parent;
	}

	internal static bool AfhjKEDxPVrwOuRiafHP()
	{
		return wOFm7vDxATgKOa1mZw7Z == null;
	}

	internal static ObjectToVisibilityConverter KOgtowDxJxfWvQYfKtry()
	{
		return wOFm7vDxATgKOa1mZw7Z;
	}
}
