using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text.RegularExpressions;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal static class ldZ
{
	public static readonly DateTime YD2;

	public static readonly DateTime ADa;

	private static Regex WDf;

	internal static ldZ pSZ;

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static IPart ab3(string P_0, string P_1, IPart P_2)
	{
		ME mE2;
		switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(P_0))
		{
		case 3264879351u:
		{
			if (!(P_0 == QdM.AR8(26690)))
			{
				break;
			}
			Ph ph = new Ph();
			ph.Format = P_1;
			return ph;
		}
		case 3699810009u:
		{
			if (!(P_0 == QdM.AR8(26722)))
			{
				break;
			}
			N0 n = new N0();
			n.Format = P_1;
			return n;
		}
		case 1245607610u:
		{
			if (!(P_0 == QdM.AR8(26752)))
			{
				break;
			}
			EY eY = new EY();
			eY.Format = P_1;
			return eY;
		}
		case 1818331204u:
		{
			if (!(P_0 == QdM.AR8(26784)))
			{
				break;
			}
			fv fv2 = new fv();
			fv2.Format = P_1;
			return fv2;
		}
		case 515840738u:
		{
			if (!(P_0 == QdM.AR8(26802)))
			{
				break;
			}
			h8 h9 = new h8();
			h9.Format = P_1;
			return h9;
		}
		case 572892822u:
		{
			if (!(P_0 == QdM.AR8(26822)))
			{
				break;
			}
			XN xN = new XN();
			xN.Format = P_1;
			return xN;
		}
		case 1083275584u:
		{
			if (!(P_0 == QdM.AR8(26858)))
			{
				break;
			}
			Ko ko = new Ko();
			ko.Format = P_1;
			return ko;
		}
		case 3298333396u:
		{
			if (!(P_0 == QdM.AR8(26882)))
			{
				break;
			}
			mS mS2 = new mS();
			mS2.Format = P_1;
			return mS2;
		}
		case 322239660u:
		{
			if (!(P_0 == QdM.AR8(26904)))
			{
				break;
			}
			UF uF = new UF();
			uF.Format = P_1;
			return uF;
		}
		case 2079996643u:
		{
			if (!(P_0 == QdM.AR8(26928)))
			{
				break;
			}
			KK kK = new KK();
			kK.Format = P_1;
			return kK;
		}
		case 1013085497u:
		{
			if (!(P_0 == QdM.AR8(26956)))
			{
				break;
			}
			tD tD2 = new tD();
			tD2.Format = P_1;
			return tD2;
		}
		case 535917593u:
			if (!(P_0 == QdM.AR8(26976)))
			{
				break;
			}
			goto IL_039b;
		case 1748879461u:
			{
				if (!(P_0 == QdM.AR8(27018)))
				{
					break;
				}
				goto IL_039b;
			}
			IL_039b:
			if (P_0 == QdM.AR8(26976))
			{
				P_1 = NbS(P_1);
			}
			if (P_2 is ME mE && !mE.fkx())
			{
				mE.Text += P_1;
				break;
			}
			mE2 = new ME();
			mE2.Text = P_1 ?? string.Empty;
			return mE2;
		}
		return null;
	}

	private static string Hby(char P_0, DateTimeFormatInfo P_1)
	{
		switch (P_0)
		{
		case 'd':
			return P_1.ShortDatePattern;
		case 'D':
			return P_1.LongDatePattern;
		case 'f':
			return P_1.LongDatePattern + QdM.AR8(23766) + P_1.ShortTimePattern;
		case 'F':
			return P_1.FullDateTimePattern;
		case 'g':
			return P_1.ShortDatePattern + QdM.AR8(23766) + P_1.ShortTimePattern;
		case 'G':
			return P_1.ShortDatePattern + QdM.AR8(23766) + P_1.LongTimePattern;
		case 'M':
		case 'm':
			return P_1.MonthDayPattern;
		case 'O':
		case 'o':
			P_1 = DateTimeFormatInfo.InvariantInfo;
			return QdM.AR8(27048);
		case 'R':
		case 'r':
			P_1 = DateTimeFormatInfo.InvariantInfo;
			return P_1.RFC1123Pattern;
		case 's':
			P_1 = DateTimeFormatInfo.InvariantInfo;
			return P_1.SortableDateTimePattern;
		case 't':
			return P_1.ShortTimePattern;
		case 'T':
			return P_1.LongTimePattern;
		case 'u':
			P_1 = DateTimeFormatInfo.InvariantInfo;
			return P_1.UniversalSortableDateTimePattern;
		case 'U':
			P_1 = DateTimeFormatInfo.InvariantInfo;
			return P_1.FullDateTimePattern;
		case 'Y':
		case 'y':
			return P_1.YearMonthPattern;
		default:
			throw new FormatException(QdM.AR8(27128));
		}
	}

	private static int Ibm(DateTime P_0)
	{
		return DateTime.DaysInMonth(P_0.Year, P_0.Month);
	}

	private static string NbS(string P_0)
	{
		return Regex.Replace(P_0, QdM.AR8(27212), QdM.AR8(27236));
	}

	public static DateTime yb1(DateTime P_0)
	{
		Calendar calendar = CultureInfo.CurrentCulture.Calendar;
		DateTime dateTime = calendar?.MinSupportedDateTime ?? DateTime.MinValue;
		DateTime dateTime2 = calendar?.MaxSupportedDateTime ?? DateTime.MaxValue;
		return BDP(P_0, dateTime, dateTime2);
	}

	public static bool zb8(DaysOfWeek P_0, DayOfWeek P_1)
	{
		bool result;
		int num;
		switch (P_1)
		{
		case DayOfWeek.Wednesday:
			result = (P_0 & DaysOfWeek.Wednesday) == DaysOfWeek.Wednesday;
			break;
		case DayOfWeek.Thursday:
			result = (P_0 & DaysOfWeek.Thursday) == DaysOfWeek.Thursday;
			break;
		default:
			result = false;
			break;
		case DayOfWeek.Friday:
			result = (P_0 & DaysOfWeek.Friday) == DaysOfWeek.Friday;
			break;
		case DayOfWeek.Monday:
			result = (P_0 & DaysOfWeek.Monday) == DaysOfWeek.Monday;
			num = 0;
			if (tSR())
			{
				num = 0;
			}
			goto IL_0009;
		case DayOfWeek.Saturday:
			result = (P_0 & DaysOfWeek.Saturday) == DaysOfWeek.Saturday;
			break;
		case DayOfWeek.Tuesday:
			result = (P_0 & DaysOfWeek.Tuesday) == DaysOfWeek.Tuesday;
			num = 1;
			if (!tSR())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0009;
		case DayOfWeek.Sunday:
			{
				result = (P_0 & DaysOfWeek.Sunday) == DaysOfWeek.Sunday;
				break;
			}
			IL_0009:
			switch (num)
			{
			}
			break;
		}
		return result;
	}

	public static IList<IPart> vbr(string P_0, CultureInfo P_1)
	{
		P_0 = bbk(P_0, P_1);
		IPart part = null;
		List<IPart> list = new List<IPart>();
		MatchCollection matchCollection = WDf.Matches(P_0);
		foreach (Match item in matchCollection)
		{
			int num = 0;
			foreach (Group group in item.Groups)
			{
				if (group.Success && num != 0)
				{
					string text = WDf.GroupNameFromNumber(num);
					IPart part2 = ab3(text, group.Value, part);
					if (part2 != null)
					{
						list.Add(part2);
						part = part2;
					}
				}
				num++;
			}
		}
		return new ReadOnlyCollection<IPart>(list);
	}

	public static CalendarWeekRule Abv(CalendarWeekRule? P_0)
	{
		return P_0 ?? ((CultureInfo.CurrentCulture.DateTimeFormat != null) ? CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule : CalendarWeekRule.FirstDay);
	}

	public static string Pbp(DateTime P_0)
	{
		int year = P_0.Year / 100 * 100;
		DateTime dateTime = P_0;
		try
		{
			dateTime = new DateTime(year, 1, 1);
		}
		catch (ArgumentException)
		{
			dateTime = DateTime.MinValue;
		}
		DateTime dateTime2 = dateTime;
		try
		{
			dateTime2 = dateTime2.AddYears(99);
		}
		catch (ArgumentException)
		{
			dateTime2 = DateTime.MaxValue;
		}
		dateTime = yb1(dateTime);
		int num = 0;
		if (!tSR())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			dateTime2 = yb1(dateTime2);
			return string.Format(CultureInfo.CurrentCulture, QdM.AR8(27250), new object[2]
			{
				dateTime.ToString(QdM.AR8(20244), CultureInfo.CurrentCulture),
				dateTime2.ToString(QdM.AR8(20244), CultureInfo.CurrentCulture)
			});
		}
	}

	public static IEnumerable<DateTime> RbW(DateTime P_0, DayOfWeek P_1)
	{
		Calendar calendar = CultureInfo.CurrentCulture.Calendar;
		int year = calendar.GetYear(P_0);
		int month = calendar.GetMonth(P_0);
		List<DateTime> list = new List<DateTime>();
		int daysInMonth = calendar.GetDaysInMonth(year, month);
		for (int i = 1; i <= daysInMonth; i++)
		{
			DateTime dateTime = calendar.ToDateTime(year, month, i, 0, 0, 0, 0);
			if (calendar.GetDayOfWeek(dateTime) == P_1)
			{
				list.Add(dateTime);
			}
		}
		return list;
	}

	public static int wbi(DateTime P_0, DayOfWeek P_1)
	{
		return (P_0.DayOfWeek - P_1 + 7) % 7;
	}

	public static string qbZ(DateTime P_0, bool P_1)
	{
		int year = P_0.Year / 10 * 10;
		DateTime dateTime = P_0;
		int num = 0;
		if (!tSR())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			try
			{
				dateTime = new DateTime(year, 1, 1);
			}
			catch (ArgumentException)
			{
				dateTime = DateTime.MinValue;
			}
			DateTime dateTime2 = dateTime;
			try
			{
				dateTime2 = dateTime2.AddYears(9);
			}
			catch (ArgumentException)
			{
				dateTime2 = DateTime.MaxValue;
			}
			dateTime = yb1(dateTime);
			dateTime2 = yb1(dateTime2);
			return string.Format(CultureInfo.CurrentCulture, QdM.AR8(27268), new object[3]
			{
				dateTime.ToString(QdM.AR8(20244), CultureInfo.CurrentCulture),
				P_1 ? Environment.NewLine : string.Empty,
				dateTime2.ToString(QdM.AR8(20244), CultureInfo.CurrentCulture)
			});
		}
		}
	}

	public static DateTime obt(DateTime P_0)
	{
		Calendar calendar = CultureInfo.CurrentCulture.Calendar;
		int year = calendar.GetYear(P_0);
		int month = calendar.GetMonth(P_0);
		P_0 = calendar.ToDateTime(year, month, 1, 0, 0, 0, 0);
		return yb1(P_0);
	}

	public static DayOfWeek Pbn(DayOfWeek? P_0)
	{
		return P_0 ?? ((CultureInfo.CurrentCulture.DateTimeFormat != null) ? CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek : DayOfWeek.Sunday);
	}

	public static DateTime QbJ(MonthCalendarViewMode P_0, DateTime P_1)
	{
		int num = 2;
		MonthCalendarViewMode monthCalendarViewMode = default(MonthCalendarViewMode);
		while (true)
		{
			int num2 = num;
			do
			{
				DateTime dateTime;
				switch (num2)
				{
				case 1:
					switch (monthCalendarViewMode)
					{
					case MonthCalendarViewMode.Decade:
						break;
					case MonthCalendarViewMode.Year:
						goto IL_00c6;
					default:
						goto IL_00fe;
					case MonthCalendarViewMode.Century:
						goto IL_014d;
					case MonthCalendarViewMode.Month:
						goto IL_01c3;
					}
					dateTime = new DateTime(P_1.Year / 10 * 10, 1, 1).AddYears(10).AddDays(-1.0);
					break;
				case 2:
					goto IL_00e5;
				default:
					goto IL_01c3;
					IL_01c3:
					dateTime = new DateTime(P_1.Year, P_1.Month, 1).AddMonths(1).AddDays(-1.0);
					break;
					IL_014d:
					dateTime = new DateTime(P_1.Year / 100 * 100, 1, 1).AddYears(100).AddDays(-1.0);
					break;
					IL_00fe:
					dateTime = P_1;
					break;
					IL_00c6:
					dateTime = new DateTime(P_1.Year, 1, 1).AddYears(1).AddDays(-1.0);
					break;
				}
				return yb1(dateTime);
				IL_00e5:
				monthCalendarViewMode = P_0;
				num2 = 1;
			}
			while (cSi() == null);
		}
	}

	public static DateTime mbe(MonthCalendarViewMode P_0, DateTime P_1)
	{
		return yb1(P_0 switch
		{
			MonthCalendarViewMode.Century => new DateTime(P_1.Year / 100 * 100, 1, 1), 
			MonthCalendarViewMode.Month => new DateTime(P_1.Year, P_1.Month, 1), 
			MonthCalendarViewMode.Decade => new DateTime(P_1.Year / 10 * 10, 1, 1), 
			MonthCalendarViewMode.Year => new DateTime(P_1.Year, 1, 1), 
			_ => P_1, 
		});
	}

	public static string bbk(string P_0, CultureInfo P_1)
	{
		if (P_1 == null)
		{
			P_1 = CultureInfo.CurrentCulture;
		}
		if (P_0 != null)
		{
			P_0 = P_0.Trim();
		}
		if (string.IsNullOrEmpty(P_0))
		{
			P_0 = QdM.AR8(18772);
		}
		if (P_0.Length == 1)
		{
			P_0 = Hby(P_0[0], P_1.DateTimeFormat);
		}
		return P_0;
	}

	public static IEnumerable<DateTime> dbE(DateTime P_0, int P_1, CalendarWeekRule P_2, DayOfWeek P_3)
	{
		List<DateTime> list = new List<DateTime>();
		Calendar calendar = CultureInfo.CurrentCulture.Calendar;
		int daysInMonth = calendar.GetDaysInMonth(P_0.Year, P_0.Month);
		for (int i = 1; i <= daysInMonth; i++)
		{
			DateTime dateTime = new DateTime(P_0.Year, P_0.Month, i);
			if (calendar.GetWeekOfYear(dateTime, P_2, P_3) == P_1)
			{
				list.Add(dateTime);
			}
		}
		return list;
	}

	public static int lb7(DateTime P_0, CalendarWeekRule P_1, DayOfWeek P_2)
	{
		Calendar calendar = CultureInfo.CurrentCulture.Calendar;
		return calendar.GetWeekOfYear(P_0, P_1, P_2);
	}

	public static DateTime Qb4(DateTime P_0, int P_1, DateTime? P_2, DateTime? P_3, SpinWrapping P_4)
	{
		DateTime dateTime = P_2 ?? DateTime.MinValue;
		DateTime dateTime2 = P_3 ?? DateTime.MaxValue;
		try
		{
			int num = 1;
			int num2 = Ibm(P_0);
			P_0 = ((P_1 >= 0) ? ((P_0.Day == num2 && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(P_0.Year, P_0.Month, num, P_0.Hour, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind) : ((P_0.Day + P_1 < num2 || P_4 == SpinWrapping.Wrap) ? P_0.AddDays(P_1) : new DateTime(P_0.Year, P_0.Month, num2, P_0.Hour, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind))) : ((P_0.Day == num && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(P_0.Year, P_0.Month, num2, P_0.Hour, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind) : ((P_0.Day + P_1 > num || P_4 == SpinWrapping.Wrap) ? P_0.AddDays(P_1) : new DateTime(P_0.Year, P_0.Month, num, P_0.Hour, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind))));
			P_0 = BDP(P_0, dateTime, dateTime2);
		}
		catch (ArgumentOutOfRangeException)
		{
			P_0 = ((P_1 > 0) ? dateTime2 : dateTime);
		}
		P_0 = yb1(P_0);
		return P_0;
	}

	public static DateTime ObB(DateTime P_0, int P_1, DateTime? P_2, DateTime? P_3, SpinWrapping P_4)
	{
		DateTime dateTime = P_2 ?? DateTime.MinValue;
		DateTime dateTime2 = P_3 ?? DateTime.MaxValue;
		try
		{
			int num = 0;
			int num2 = 23;
			P_0 = ((P_1 >= 0) ? ((P_0.Hour == num2 && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(P_0.Year, P_0.Month, P_0.Day, num, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind) : ((P_0.Hour + P_1 < num2 || P_4 == SpinWrapping.Wrap) ? P_0.AddHours(P_1) : new DateTime(P_0.Year, P_0.Month, P_0.Day, num2, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind))) : ((P_0.Hour == num && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(P_0.Year, P_0.Month, P_0.Day, num2, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind) : ((P_0.Hour + P_1 > num || P_4 == SpinWrapping.Wrap) ? P_0.AddHours(P_1) : new DateTime(P_0.Year, P_0.Month, P_0.Day, num, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind))));
			P_0 = BDP(P_0, dateTime, dateTime2);
		}
		catch (ArgumentOutOfRangeException)
		{
			P_0 = ((P_1 > 0) ? dateTime2 : dateTime);
		}
		P_0 = yb1(P_0);
		return P_0;
	}

	public static DateTime Ubh(DateTime P_0, int P_1, DateTime? P_2, DateTime? P_3, SpinWrapping P_4)
	{
		DateTime dateTime = P_2 ?? DateTime.MinValue;
		DateTime dateTime2 = P_3 ?? DateTime.MaxValue;
		try
		{
			int num = 0;
			int num2 = 999;
			P_0 = ((P_1 >= 0) ? ((P_0.Millisecond == num2 && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(P_0.Year, P_0.Month, P_0.Day, P_0.Hour, P_0.Minute, P_0.Second, num, P_0.Kind) : ((P_0.Millisecond + P_1 < num2 || P_4 == SpinWrapping.Wrap) ? P_0.AddMilliseconds(P_1) : new DateTime(P_0.Year, P_0.Month, P_0.Day, P_0.Hour, P_0.Minute, P_0.Second, num2, P_0.Kind))) : ((P_0.Millisecond == num && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(P_0.Year, P_0.Month, P_0.Day, P_0.Hour, P_0.Minute, P_0.Second, num2, P_0.Kind) : ((P_0.Millisecond + P_1 > num || P_4 == SpinWrapping.Wrap) ? P_0.AddMilliseconds(P_1) : new DateTime(P_0.Year, P_0.Month, P_0.Day, P_0.Hour, P_0.Minute, P_0.Second, num, P_0.Kind))));
			P_0 = BDP(P_0, dateTime, dateTime2);
		}
		catch (ArgumentOutOfRangeException)
		{
			P_0 = ((P_1 > 0) ? dateTime2 : dateTime);
		}
		P_0 = yb1(P_0);
		return P_0;
	}

	public static DateTime abw(DateTime P_0, int P_1, DateTime? P_2, DateTime? P_3, SpinWrapping P_4)
	{
		DateTime dateTime = P_2 ?? DateTime.MinValue;
		DateTime dateTime2 = P_3 ?? DateTime.MaxValue;
		try
		{
			int num = 0;
			int num2 = 59;
			P_0 = ((P_1 >= 0) ? ((P_0.Minute == num2 && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(P_0.Year, P_0.Month, P_0.Day, P_0.Hour, num, P_0.Second, P_0.Millisecond, P_0.Kind) : ((P_0.Minute + P_1 < num2 || P_4 == SpinWrapping.Wrap) ? P_0.AddMinutes(P_1) : new DateTime(P_0.Year, P_0.Month, P_0.Day, P_0.Hour, num2, P_0.Second, P_0.Millisecond, P_0.Kind))) : ((P_0.Minute == num && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(P_0.Year, P_0.Month, P_0.Day, P_0.Hour, num2, P_0.Second, P_0.Millisecond, P_0.Kind) : ((P_0.Minute + P_1 > num || P_4 == SpinWrapping.Wrap) ? P_0.AddMinutes(P_1) : new DateTime(P_0.Year, P_0.Month, P_0.Day, P_0.Hour, num, P_0.Second, P_0.Millisecond, P_0.Kind))));
			P_0 = BDP(P_0, dateTime, dateTime2);
		}
		catch (ArgumentOutOfRangeException)
		{
			P_0 = ((P_1 > 0) ? dateTime2 : dateTime);
		}
		P_0 = yb1(P_0);
		return P_0;
	}

	public static DateTime hbN(DateTime P_0, int P_1, DateTime? P_2, DateTime? P_3, SpinWrapping P_4)
	{
		DateTime dateTime = P_2 ?? DateTime.MinValue;
		DateTime dateTime2 = P_3 ?? DateTime.MaxValue;
		try
		{
			int num = 1;
			int num2 = 12;
			P_0 = ((P_1 >= 0) ? ((P_0.Month == num2 && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(P_0.Year, num, P_0.Day, P_0.Hour, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind) : ((P_0.Month + P_1 < num2 || P_4 == SpinWrapping.Wrap) ? P_0.AddMonths(P_1) : new DateTime(P_0.Year, num2, P_0.Day, P_0.Hour, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind))) : ((P_0.Month == num && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(P_0.Year, num2, P_0.Day, P_0.Hour, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind) : ((P_0.Month + P_1 > num || P_4 == SpinWrapping.Wrap) ? P_0.AddMonths(P_1) : new DateTime(P_0.Year, num, P_0.Day, P_0.Hour, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind))));
			P_0 = BDP(P_0, dateTime, dateTime2);
		}
		catch (ArgumentOutOfRangeException)
		{
			P_0 = ((P_1 > 0) ? dateTime2 : dateTime);
		}
		P_0 = yb1(P_0);
		return P_0;
	}

	public static DateTime jbU(DateTime P_0, int P_1, DateTime? P_2, DateTime? P_3, SpinWrapping P_4)
	{
		DateTime dateTime = P_2 ?? DateTime.MinValue;
		DateTime dateTime2 = P_3 ?? DateTime.MaxValue;
		try
		{
			int num = 0;
			int num2 = 59;
			P_0 = ((P_1 >= 0) ? ((P_0.Second == num2 && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(P_0.Year, P_0.Month, P_0.Day, P_0.Hour, P_0.Minute, num, P_0.Millisecond, P_0.Kind) : ((P_0.Second + P_1 < num2 || P_4 == SpinWrapping.Wrap) ? P_0.AddSeconds(P_1) : new DateTime(P_0.Year, P_0.Month, P_0.Day, P_0.Hour, P_0.Minute, num2, P_0.Millisecond, P_0.Kind))) : ((P_0.Second == num && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(P_0.Year, P_0.Month, P_0.Day, P_0.Hour, P_0.Minute, num2, P_0.Millisecond, P_0.Kind) : ((P_0.Second + P_1 > num || P_4 == SpinWrapping.Wrap) ? P_0.AddSeconds(P_1) : new DateTime(P_0.Year, P_0.Month, P_0.Day, P_0.Hour, P_0.Minute, num, P_0.Millisecond, P_0.Kind))));
			P_0 = BDP(P_0, dateTime, dateTime2);
		}
		catch (ArgumentOutOfRangeException)
		{
			P_0 = ((P_1 > 0) ? dateTime2 : dateTime);
		}
		P_0 = yb1(P_0);
		return P_0;
	}

	public static DateTime ebz(DateTime P_0, int P_1, DateTime? P_2, DateTime? P_3, SpinWrapping P_4)
	{
		DateTime dateTime = P_2 ?? DateTime.MinValue;
		DateTime dateTime2 = P_3 ?? DateTime.MaxValue;
		try
		{
			int num = 1;
			int num2 = 9999;
			P_0 = ((P_1 >= 0) ? ((P_0.Year == num2 && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(num, P_0.Month, P_0.Day, P_0.Hour, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind) : ((P_0.Year + P_1 < num2 || P_4 == SpinWrapping.Wrap) ? P_0.AddYears(P_1) : new DateTime(num2, P_0.Month, P_0.Day, P_0.Hour, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind))) : ((P_0.Year == num && P_4 == SpinWrapping.SimpleWrap) ? new DateTime(num2, P_0.Month, P_0.Day, P_0.Hour, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind) : ((P_0.Year + P_1 > num || P_4 == SpinWrapping.Wrap) ? P_0.AddYears(P_1) : new DateTime(num, P_0.Month, P_0.Day, P_0.Hour, P_0.Minute, P_0.Second, P_0.Millisecond, P_0.Kind))));
			P_0 = BDP(P_0, dateTime, dateTime2);
		}
		catch (ArgumentOutOfRangeException)
		{
			P_0 = ((P_1 > 0) ? dateTime2 : dateTime);
		}
		P_0 = yb1(P_0);
		return P_0;
	}

	public static bool xDQ(DateTime P_0, DateTime P_1)
	{
		Calendar calendar = CultureInfo.CurrentCulture.Calendar;
		if (!TDM(P_0))
		{
			return false;
		}
		if (!TDM(P_1))
		{
			P_1 = BDP(P_1, calendar.MinSupportedDateTime, calendar.MaxSupportedDateTime);
		}
		int num = calendar.GetYear(P_1) / 10 * 10;
		int num2 = num + 9;
		return calendar.GetYear(P_0) >= num && calendar.GetYear(P_0) <= num2;
	}

	public static bool CDV(DateTime P_0, DateTime P_1)
	{
		Calendar calendar = CultureInfo.CurrentCulture.Calendar;
		if (!TDM(P_0))
		{
			return false;
		}
		if (!TDM(P_1))
		{
			P_1 = BDP(P_1, calendar.MinSupportedDateTime, calendar.MaxSupportedDateTime);
		}
		return calendar.GetYear(P_0) == calendar.GetYear(P_1) && calendar.GetMonth(P_0) == calendar.GetMonth(P_1);
	}

	public static bool QDC(DateTime P_0, DateTime P_1, DateTime P_2)
	{
		DateTime date = P_0.Date;
		return date >= P_1.Date && date <= P_2.Date;
	}

	public static bool yD6(MonthCalendarViewMode P_0, DateTime P_1, DateTime P_2, DateTime P_3)
	{
		P_2 = mbe(P_0, P_2);
		P_3 = QbJ(P_0, P_3);
		return P_1 >= P_2 && P_1 <= P_3;
	}

	public static bool TDM(DateTime P_0)
	{
		Calendar calendar = CultureInfo.CurrentCulture.Calendar;
		return P_0 >= calendar.MinSupportedDateTime && P_0 <= calendar.MaxSupportedDateTime;
	}

	public static DateTime oDs(DateTime P_0, DateTime P_1)
	{
		return (P_0 > P_1) ? P_0 : P_1;
	}

	public static DateTime ODj(DateTime P_0, DateTime P_1)
	{
		return (P_0 < P_1) ? P_0 : P_1;
	}

	public static DateTime BDP(DateTime P_0, DateTime P_1, DateTime P_2)
	{
		return oDs(P_1, ODj(P_0, P_2));
	}

	static ldZ()
	{
		awj.QuEwGz();
		YD2 = new DateTime(9899, 12, 31);
		ADa = new DateTime(1753, 1, 1);
		WDf = new Regex(QdM.AR8(27292), RegexOptions.ExplicitCapture | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace | RegexOptions.CultureInvariant);
	}

	internal static bool tSR()
	{
		return pSZ == null;
	}

	internal static ldZ cSi()
	{
		return pSZ;
	}
}
