using System;
using System.Globalization;
using System.Windows.Data;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

public class TypeNameConverter : IValueConverter
{
	internal static TypeNameConverter aO9;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value?.GetType().Name;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public TypeNameConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool bOc()
	{
		return aO9 == null;
	}

	internal static TypeNameConverter EOu()
	{
		return aO9;
	}
}
