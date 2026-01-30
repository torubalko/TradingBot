using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

public class EnumDescriptionConverter : IValueConverter
{
	private static EnumDescriptionConverter iNs;

	private static string KkV(Type P_0, string P_1)
	{
		if (null != P_0 && P_1 != null)
		{
			FieldInfo field = P_0.GetField(P_1);
			if (null != field && field.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false) is DescriptionAttribute[] array && array.Length != 0)
			{
				return array[0].Description;
			}
			return P_1;
		}
		return string.Empty;
	}

	private static object kk5(Type P_0, string P_1)
	{
		FieldInfo[] fields = P_0.GetFields();
		FieldInfo[] array = fields;
		bool flag2 = default(bool);
		int num2 = default(int);
		foreach (FieldInfo fieldInfo in array)
		{
			DescriptionAttribute[] array2 = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false) as DescriptionAttribute[];
			bool flag = array2 != null && array2.Length != 0;
			int num = 1;
			if (!VNi())
			{
				goto IL_0005;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				default:
					if (!flag2)
					{
						goto IL_00e8;
					}
					return fieldInfo.GetValue(fieldInfo.Name);
				case 1:
					if (flag && array2[0].Description == P_1)
					{
						return fieldInfo.GetValue(fieldInfo.Name);
					}
					flag2 = fieldInfo.Name == P_1;
					num = 0;
					if (VNi())
					{
						break;
					}
					goto end_IL_0009;
				}
				continue;
				end_IL_0009:
				break;
			}
			goto IL_0005;
			IL_0005:
			num = num2;
			goto IL_0009;
			IL_00e8:;
		}
		return P_1;
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is Enum && typeof(string) == targetType)
		{
			return KkV(value.GetType(), value.ToString());
		}
		return value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (targetType == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111918));
		}
		if (value is string text && targetType.IsSubclassOf(typeof(Enum)))
		{
			return kk5(targetType, text);
		}
		return value;
	}

	public EnumDescriptionConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool VNi()
	{
		return iNs == null;
	}

	internal static EnumDescriptionConverter GNp()
	{
		return iNs;
	}
}
