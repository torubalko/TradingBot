using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(Duration), typeof(double))]
public class DurationToMillisecondConverter : IValueConverter
{
	internal static DurationToMillisecondConverter FNU;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is Duration duration))
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111782));
		}
		if (duration.HasTimeSpan)
		{
			return duration.TimeSpan.TotalMilliseconds;
		}
		throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111834));
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "System.Double.TryParse(System.String,System.Double@)")]
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		double result = 0.0;
		if (value is double)
		{
			result = (double)value;
		}
		else if (value != null && !double.TryParse(value.ToString(), out result))
		{
			result = 0.0;
		}
		return new Duration(TimeSpan.FromMilliseconds(result));
	}

	public DurationToMillisecondConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool zNL()
	{
		return FNU == null;
	}

	internal static DurationToMillisecondConverter tN4()
	{
		return FNU;
	}
}
