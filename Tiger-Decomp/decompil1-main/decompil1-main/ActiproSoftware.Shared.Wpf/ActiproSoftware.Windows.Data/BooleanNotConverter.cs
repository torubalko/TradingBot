using System;
using System.Globalization;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(bool), typeof(bool))]
public class BooleanNotConverter : IValueConverter
{
	private static BooleanNotConverter GNw;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is bool))
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111580));
		}
		return !(bool)value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return Convert(value, targetType, parameter, culture);
	}

	public BooleanNotConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool NNk()
	{
		return GNw == null;
	}

	internal static BooleanNotConverter yNF()
	{
		return GNw;
	}
}
