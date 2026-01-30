using System;
using System.Globalization;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Windows.Extensions;

public static class DayOfWeekExtensions
{
	private static DayOfWeekExtensions Y3a;

	public static bool IsWeekend(this DayOfWeek dayOfWeek)
	{
		if (dayOfWeek != DayOfWeek.Sunday && dayOfWeek != DayOfWeek.Saturday)
		{
			return false;
		}
		return true;
	}

	public static string ToString(this DayOfWeek dayOfWeek, DayOfWeekFormatPattern pattern)
	{
		return dayOfWeek.ToString(pattern, DateTimeFormatInfo.CurrentInfo);
	}

	public static string ToString(this DayOfWeek dayOfWeek, DayOfWeekFormatPattern pattern, IFormatProvider provider)
	{
		DateTimeFormatInfo instance = DateTimeFormatInfo.GetInstance(provider);
		if (instance == null)
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110908), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111028));
		}
		return pattern switch
		{
			DayOfWeekFormatPattern.Abbreviated => instance.GetAbbreviatedDayName(dayOfWeek), 
			DayOfWeekFormatPattern.AbbreviatedUppercase => instance.GetAbbreviatedDayName(dayOfWeek).ToUpperInvariant(), 
			DayOfWeekFormatPattern.Shortest => instance.GetShortestDayName(dayOfWeek), 
			DayOfWeekFormatPattern.ShortestUppercase => instance.GetShortestDayName(dayOfWeek).ToUpperInvariant(), 
			DayOfWeekFormatPattern.SingleLetter => instance.GetShortestDayName(dayOfWeek)[0].ToString(), 
			_ => instance.GetDayName(dayOfWeek), 
		};
	}

	internal static bool I3y()
	{
		return Y3a == null;
	}

	internal static DayOfWeekExtensions p3Q()
	{
		return Y3a;
	}
}
