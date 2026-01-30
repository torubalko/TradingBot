using System;
using System.Globalization;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(object), typeof(bool))]
public class IsTypeConverter : IValueConverter
{
	private static readonly IsTypeConverter hkL;

	internal static IsTypeConverter YO7;

	public static IsTypeConverter Instance => hkL;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		Type type = parameter as Type;
		if (type == null)
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112286));
		}
		if (value == null)
		{
			return false;
		}
		bool flag = type.IsAssignableFrom(value.GetType());
		return flag;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public IsTypeConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static IsTypeConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		hkL = new IsTypeConverter();
	}

	internal static bool yOH()
	{
		return YO7 == null;
	}

	internal static IsTypeConverter XOJ()
	{
		return YO7;
	}
}
