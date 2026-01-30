using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

public class BooleanAndConverter : IMultiValueConverter
{
	private static BooleanAndConverter qNj;

	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values == null || values.Length == 0)
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111472));
		}
		bool flag = true;
		foreach (object obj in values)
		{
			if (obj != DependencyProperty.UnsetValue)
			{
				if (!(obj is bool))
				{
					throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111580));
				}
				flag = flag && (bool)obj;
			}
		}
		return flag;
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public BooleanAndConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool ENe()
	{
		return qNj == null;
	}

	internal static BooleanAndConverter UN6()
	{
		return qNj;
	}
}
