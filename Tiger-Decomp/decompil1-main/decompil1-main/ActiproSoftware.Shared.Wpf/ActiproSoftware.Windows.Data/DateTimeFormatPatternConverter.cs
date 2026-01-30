using System;
using System.Globalization;
using System.Windows.Data;
using ActiproSoftware.Windows.Extensions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(DateTime), typeof(string))]
public class DateTimeFormatPatternConverter : IValueConverter
{
	internal static DateTimeFormatPatternConverter fNl;

	public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is DateTime dateTime))
		{
			return string.Empty;
		}
		if (parameter is string text)
		{
			return dateTime.ToString(text, CultureInfo.CurrentCulture);
		}
		return dateTime.ToString((parameter is DateTimeFormatPattern) ? ((DateTimeFormatPattern)parameter) : DateTimeFormatPattern.ShortDateTime, CultureInfo.CurrentCulture);
	}

	public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (culture == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111764));
		}
		string text = value as string;
		if (!string.IsNullOrEmpty(text))
		{
			int num = 0;
			if (VNx() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => DateTime.Parse(text, culture.DateTimeFormat), 
			};
		}
		return null;
	}

	public DateTimeFormatPatternConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool KNE()
	{
		return fNl == null;
	}

	internal static DateTimeFormatPatternConverter VNx()
	{
		return fNl;
	}
}
