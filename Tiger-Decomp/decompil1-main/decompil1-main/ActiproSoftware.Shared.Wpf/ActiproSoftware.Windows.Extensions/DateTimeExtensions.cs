using System;
using System.Globalization;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Windows.Extensions;

public static class DateTimeExtensions
{
	private static DateTimeExtensions e3F;

	private static string jkF(DateTimeFormatInfo P_0, DateTimeFormatPattern P_1)
	{
		return P_1 switch
		{
			DateTimeFormatPattern.UniversalSortableDateTime => P_0.UniversalSortableDateTimePattern, 
			DateTimeFormatPattern.FullDateTime => P_0.FullDateTimePattern, 
			DateTimeFormatPattern.ShortDate => P_0.ShortDatePattern, 
			DateTimeFormatPattern.Rfc1123 => P_0.RFC1123Pattern, 
			DateTimeFormatPattern.YearMonth => P_0.YearMonthPattern, 
			DateTimeFormatPattern.YearMonthNoDelimiter => P_0.YearMonthPattern.Replace(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110902), string.Empty), 
			DateTimeFormatPattern.SortableDateTime => P_0.SortableDateTimePattern, 
			DateTimeFormatPattern.LongTime => P_0.LongTimePattern, 
			DateTimeFormatPattern.MonthDay => P_0.MonthDayPattern, 
			DateTimeFormatPattern.ShortTime => P_0.ShortTimePattern, 
			DateTimeFormatPattern.LongDate => P_0.LongDatePattern, 
			_ => null, 
		};
	}

	public static bool IsToday(this DateTime dateTime)
	{
		return (dateTime.Date - DateTime.Now.Date).Days == 0;
	}

	public static bool IsWeekend(this DateTime dateTime)
	{
		return dateTime.DayOfWeek.IsWeekend();
	}

	public static string ToString(this DateTime dateTime, DateTimeFormatPattern pattern)
	{
		return dateTime.ToString(pattern, DateTimeFormatInfo.CurrentInfo);
	}

	public static string ToString(this DateTime dateTime, DateTimeFormatPattern pattern, IFormatProvider provider)
	{
		DateTimeFormatInfo instance = DateTimeFormatInfo.GetInstance(provider);
		if (instance == null)
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110908), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111028));
		}
		string text = jkF(instance, pattern);
		return dateTime.ToString(text, provider);
	}

	internal static bool w3d()
	{
		return e3F == null;
	}

	internal static DateTimeExtensions M3v()
	{
		return e3F;
	}
}
