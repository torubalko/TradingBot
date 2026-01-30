using System;
using System.Globalization;
using System.Windows.Data;
using ActiproSoftware.Windows.Extensions;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(DayOfWeek), typeof(string))]
public class DayOfWeekFormatPatternConverter : IValueConverter
{
	private static DayOfWeekFormatPatternConverter BNS;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is int num))
		{
			return string.Empty;
		}
		return ((DayOfWeek)num).ToString((parameter is DayOfWeekFormatPattern) ? ((DayOfWeekFormatPattern)parameter) : DayOfWeekFormatPattern.Full, CultureInfo.CurrentCulture);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		string value2 = value as string;
		if (!string.IsNullOrEmpty(value2))
		{
			return Enum.Parse(typeof(DayOfWeek), value2);
		}
		return null;
	}

	public DayOfWeekFormatPatternConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool sNB()
	{
		return BNS == null;
	}

	internal static DayOfWeekFormatPatternConverter nNA()
	{
		return BNS;
	}
}
