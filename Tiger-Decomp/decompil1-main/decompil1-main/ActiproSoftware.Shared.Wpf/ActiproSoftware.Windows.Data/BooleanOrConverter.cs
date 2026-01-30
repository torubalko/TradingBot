using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

public class BooleanOrConverter : IMultiValueConverter
{
	private static BooleanOrConverter RNd;

	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				default:
					if (values.Length == 0)
					{
						goto IL_00f5;
					}
					goto IL_0105;
				case 2:
					foreach (object obj in values)
					{
						if (obj != DependencyProperty.UnsetValue)
						{
							if (!(obj is bool))
							{
								throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111580));
							}
							flag = flag || (bool)obj;
						}
					}
					return flag;
				case 1:
					{
						if (values == null)
						{
							goto IL_00f5;
						}
						num2 = 0;
						if (HNv())
						{
							num2 = 0;
						}
						break;
					}
					IL_00f5:
					throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111472));
				}
				goto IL_0012;
				IL_0105:
				flag = false;
				num2 = 2;
			}
			while (LNa() == null);
		}
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public BooleanOrConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool HNv()
	{
		return RNd == null;
	}

	internal static BooleanOrConverter LNa()
	{
		return RNd;
	}
}
