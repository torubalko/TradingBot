using System;
using System.Globalization;
using System.Windows.Data;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(object), typeof(object))]
public class CoalesceConverter : IMultiValueConverter, IValueConverter
{
	private static CoalesceConverter CNu;

	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values != null)
		{
			foreach (object obj in values)
			{
				if (obj != null)
				{
					return obj;
				}
			}
		}
		return parameter;
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value != null)
		{
			return value;
		}
		return parameter;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value;
	}

	public CoalesceConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool WNo()
	{
		return CNu == null;
	}

	internal static CoalesceConverter cN5()
	{
		return CNu;
	}
}
