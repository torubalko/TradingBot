using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MimeKit.Utils;

public static class DateUtils
{
	internal static readonly DateTime UnixEpoch;

	private const string MonthCharacters = "JanuaryFebruaryMarchAprilMayJuneJulyAugustSeptemberOctoberNovemberDecember";

	private const string WeekdayCharacters = "SundayMondayTuesdayWednesdayThursdayFridaySaturday";

	private const string AlphaZoneCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	private const string NumericZoneCharacters = "+-0123456789";

	private const string NumericCharacters = "0123456789";

	private const string TimeCharacters = "0123456789:";

	private static readonly string[] Months;

	private static readonly string[] WeekDays;

	private static readonly Dictionary<string, int> timezones;

	private static readonly DateTokenFlags[] datetok;

	static DateUtils()
	{
		UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0);
		Months = new string[12]
		{
			"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct",
			"Nov", "Dec"
		};
		WeekDays = new string[7] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
		timezones = new Dictionary<string, int>(StringComparer.Ordinal)
		{
			{ "UT", 0 },
			{ "UTC", 0 },
			{ "GMT", 0 },
			{ "EDT", -400 },
			{ "EST", -500 },
			{ "CDT", -500 },
			{ "CST", -600 },
			{ "MDT", -600 },
			{ "MST", -700 },
			{ "PDT", -700 },
			{ "PST", -800 },
			{ "A", 100 },
			{ "B", 200 },
			{ "C", 300 },
			{ "D", 400 },
			{ "E", 500 },
			{ "F", 600 },
			{ "G", 700 },
			{ "H", 800 },
			{ "I", 900 },
			{ "K", 1000 },
			{ "L", 1100 },
			{ "M", 1200 },
			{ "N", -100 },
			{ "O", -200 },
			{ "P", -300 },
			{ "Q", -400 },
			{ "R", -500 },
			{ "S", -600 },
			{ "T", -700 },
			{ "U", -800 },
			{ "V", -900 },
			{ "W", -1000 },
			{ "X", -1100 },
			{ "Y", -1200 },
			{ "Z", 0 }
		};
		datetok = new DateTokenFlags[256];
		char[] array = new char[2];
		for (int i = 0; i < 256; i++)
		{
			if (i >= 65 && i <= 90)
			{
				array[1] = (char)(i + 32);
				array[0] = (char)i;
			}
			else if (i >= 97 && i <= 122)
			{
				array[0] = (char)(i - 32);
				array[1] = (char)i;
			}
			if ("+-0123456789".IndexOf((char)i) == -1)
			{
				datetok[i] |= DateTokenFlags.NonNumericZone;
			}
			if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf((char)i) == -1)
			{
				datetok[i] |= DateTokenFlags.NonAlphaZone;
			}
			if ("SundayMondayTuesdayWednesdayThursdayFridaySaturday".IndexOfAny(array) == -1)
			{
				datetok[i] |= DateTokenFlags.NonWeekday;
			}
			if ("0123456789".IndexOf((char)i) == -1)
			{
				datetok[i] |= DateTokenFlags.NonNumeric;
			}
			if ("JanuaryFebruaryMarchAprilMayJuneJulyAugustSeptemberOctoberNovemberDecember".IndexOfAny(array) == -1)
			{
				datetok[i] |= DateTokenFlags.NonMonth;
			}
			if ("0123456789:".IndexOf((char)i) == -1)
			{
				datetok[i] |= DateTokenFlags.NonTime;
			}
		}
		datetok[58] |= DateTokenFlags.HasColon;
		datetok[43] |= DateTokenFlags.HasSign;
		datetok[45] |= DateTokenFlags.HasSign;
	}

	private static bool TryGetWeekday(DateToken token, byte[] text, out DayOfWeek weekday)
	{
		weekday = DayOfWeek.Sunday;
		if (!token.IsWeekday || token.Length < 3)
		{
			return false;
		}
		string value = Encoding.ASCII.GetString(text, token.StartIndex, 3);
		for (int i = 0; i < WeekDays.Length; i++)
		{
			if (WeekDays[i].Equals(value, StringComparison.OrdinalIgnoreCase))
			{
				weekday = (DayOfWeek)i;
				return true;
			}
		}
		return false;
	}

	private static bool TryGetDayOfMonth(DateToken token, byte[] text, out int day)
	{
		int endIndex = token.StartIndex + token.Length;
		int index = token.StartIndex;
		day = 0;
		if (!token.IsNumeric)
		{
			return false;
		}
		if (!ParseUtils.TryParseInt32(text, ref index, endIndex, out day))
		{
			return false;
		}
		if (day <= 0 || day > 31)
		{
			return false;
		}
		return true;
	}

	private static bool TryGetMonth(DateToken token, byte[] text, out int month)
	{
		month = 0;
		if (!token.IsMonth || token.Length < 3)
		{
			return false;
		}
		string value = Encoding.ASCII.GetString(text, token.StartIndex, 3);
		for (int i = 0; i < Months.Length; i++)
		{
			if (Months[i].Equals(value, StringComparison.OrdinalIgnoreCase))
			{
				month = i + 1;
				return true;
			}
		}
		return false;
	}

	private static bool TryGetYear(DateToken token, byte[] text, out int year)
	{
		int endIndex = token.StartIndex + token.Length;
		int index = token.StartIndex;
		year = 0;
		if (!token.IsNumeric)
		{
			return false;
		}
		if (!ParseUtils.TryParseInt32(text, ref index, endIndex, out year))
		{
			return false;
		}
		if (year < 100)
		{
			year += ((year < 70) ? 2000 : 1900);
		}
		return year >= 1969;
	}

	private static bool TryGetTimeOfDay(DateToken token, byte[] text, out int hour, out int minute, out int second)
	{
		int num = token.StartIndex + token.Length;
		int index = token.StartIndex;
		hour = (minute = (second = 0));
		if (!token.IsTimeOfDay)
		{
			return false;
		}
		if (!ParseUtils.TryParseInt32(text, ref index, num, out hour) || hour > 23)
		{
			return false;
		}
		if (index >= num || text[index++] != 58)
		{
			return false;
		}
		if (!ParseUtils.TryParseInt32(text, ref index, num, out minute) || minute > 59)
		{
			return false;
		}
		if (index >= num || text[index++] != 58)
		{
			return true;
		}
		if (!ParseUtils.TryParseInt32(text, ref index, num, out second) || second > 59)
		{
			return false;
		}
		return index == num;
	}

	private static bool TryGetTimeZone(DateToken token, byte[] text, out int tzone)
	{
		tzone = 0;
		if (token.IsNumericZone)
		{
			int num = token.StartIndex + token.Length;
			int startIndex = token.StartIndex;
			int num2;
			if (text[startIndex] == 45)
			{
				num2 = -1;
			}
			else
			{
				if (text[startIndex] != 43)
				{
					return false;
				}
				num2 = 1;
			}
			startIndex++;
			if (!ParseUtils.TryParseInt32(text, ref startIndex, num, out tzone) || startIndex != num)
			{
				return false;
			}
			tzone *= num2;
		}
		else if (token.IsAlphaZone)
		{
			if (token.Length > 3)
			{
				return false;
			}
			string key = Encoding.ASCII.GetString(text, token.StartIndex, token.Length);
			if (!timezones.TryGetValue(key, out tzone))
			{
				return false;
			}
		}
		else if (token.IsNumeric)
		{
			int num3 = token.StartIndex + token.Length;
			int index = token.StartIndex;
			if (!ParseUtils.TryParseInt32(text, ref index, num3, out tzone) || index != num3)
			{
				return false;
			}
		}
		if (tzone < -1200 || tzone > 1400)
		{
			return false;
		}
		return true;
	}

	private static bool IsTokenDelimeter(byte c)
	{
		if (c != 45 && c != 47 && c != 44)
		{
			return c.IsWhitespace();
		}
		return true;
	}

	private static IEnumerable<DateToken> TokenizeDate(byte[] text, int startIndex, int length)
	{
		int endIndex = startIndex + length;
		for (int index = startIndex; index < endIndex; index++)
		{
			if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError: false))
			{
				break;
			}
			if (index >= endIndex)
			{
				break;
			}
			DateTokenFlags dateTokenFlags;
			if ((dateTokenFlags = datetok[text[index]]) != DateTokenFlags.None)
			{
				int num = index++;
				while (index < endIndex && !IsTokenDelimeter(text[index]))
				{
					dateTokenFlags |= datetok[text[index++]];
				}
				yield return new DateToken(dateTokenFlags, num, index - num);
			}
		}
	}

	private static bool TryParseStandardDateFormat(IList<DateToken> tokens, byte[] text, out DateTimeOffset date)
	{
		int num = 0;
		date = default(DateTimeOffset);
		if (tokens.Count < 5)
		{
			return false;
		}
		if (TryGetWeekday(tokens[num], text, out var _))
		{
			if (tokens.Count < 6)
			{
				return false;
			}
			num++;
		}
		if (!TryGetDayOfMonth(tokens[num++], text, out var day))
		{
			return false;
		}
		if (!TryGetMonth(tokens[num++], text, out var month))
		{
			return false;
		}
		if (!TryGetYear(tokens[num++], text, out var year))
		{
			return false;
		}
		if (!TryGetTimeOfDay(tokens[num++], text, out var hour, out var minute, out var second))
		{
			return false;
		}
		if (!TryGetTimeZone(tokens[num], text, out var tzone))
		{
			tzone = 0;
		}
		int minutes = tzone % 100;
		int hours = tzone / 100;
		TimeSpan offset = new TimeSpan(hours, minutes, 0);
		try
		{
			date = new DateTimeOffset(year, month, day, hour, minute, second, offset);
		}
		catch (ArgumentOutOfRangeException)
		{
			return false;
		}
		return true;
	}

	private static bool TryParseUnknownDateFormat(IList<DateToken> tokens, byte[] text, out DateTimeOffset date)
	{
		int? num = null;
		int? num2 = null;
		int? num3 = null;
		int? num4 = null;
		int hour = 0;
		int minute = 0;
		int second = 0;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		for (int i = 0; i < tokens.Count; i++)
		{
			int month;
			if (!flag2 && tokens[i].IsWeekday && TryGetWeekday(tokens[i], text, out var _))
			{
				flag2 = true;
			}
			else if ((!num2.HasValue || flag) && tokens[i].IsMonth && TryGetMonth(tokens[i], text, out month))
			{
				if (flag)
				{
					flag = false;
					num = num2;
				}
				num2 = month;
			}
			else if (!flag3 && tokens[i].IsTimeOfDay && TryGetTimeOfDay(tokens[i], text, out hour, out minute, out second))
			{
				flag3 = true;
			}
			else if (!num4.HasValue && tokens[i].IsTimeZone && TryGetTimeZone(tokens[i], text, out month))
			{
				num4 = month;
			}
			else
			{
				if (!tokens[i].IsNumeric)
				{
					continue;
				}
				if (tokens[i].Length == 4)
				{
					if (!num3.HasValue)
					{
						if (TryGetYear(tokens[i], text, out month))
						{
							num3 = month;
						}
					}
					else if (!num4.HasValue && TryGetTimeZone(tokens[i], text, out month))
					{
						num4 = month;
					}
				}
				else if (tokens[i].Length <= 2)
				{
					int endIndex = tokens[i].StartIndex + tokens[i].Length;
					int index = tokens[i].StartIndex;
					ParseUtils.TryParseInt32(text, ref index, endIndex, out month);
					if (!num2.HasValue && month > 0 && month <= 12)
					{
						flag = true;
						num2 = month;
					}
					else if (!num.HasValue && month > 0 && month <= 31)
					{
						num = month;
					}
					else if (!num3.HasValue && month >= 69)
					{
						num3 = 1900 + month;
					}
				}
			}
		}
		if (!num3.HasValue || !num2.HasValue || !num.HasValue)
		{
			date = default(DateTimeOffset);
			return false;
		}
		if (!flag3)
		{
			hour = (minute = (second = 0));
		}
		TimeSpan offset;
		if (num4.HasValue)
		{
			int minutes = num4.Value % 100;
			int hours = num4.Value / 100;
			offset = new TimeSpan(hours, minutes, 0);
		}
		else
		{
			offset = new TimeSpan(0L);
		}
		try
		{
			date = new DateTimeOffset(num3.Value, num2.Value, num.Value, hour, minute, second, offset);
		}
		catch (ArgumentOutOfRangeException)
		{
			date = default(DateTimeOffset);
			return false;
		}
		return true;
	}

	public static bool TryParse(byte[] buffer, int startIndex, int length, out DateTimeOffset date)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (startIndex < 0 || startIndex > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (length < 0 || length > buffer.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		List<DateToken> tokens = new List<DateToken>(TokenizeDate(buffer, startIndex, length));
		if (TryParseStandardDateFormat(tokens, buffer, out date))
		{
			return true;
		}
		if (TryParseUnknownDateFormat(tokens, buffer, out date))
		{
			return true;
		}
		date = default(DateTimeOffset);
		return false;
	}

	public static bool TryParse(byte[] buffer, int startIndex, out DateTimeOffset date)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (startIndex < 0 || startIndex > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		int length = buffer.Length - startIndex;
		List<DateToken> tokens = new List<DateToken>(TokenizeDate(buffer, startIndex, length));
		if (TryParseStandardDateFormat(tokens, buffer, out date))
		{
			return true;
		}
		if (TryParseUnknownDateFormat(tokens, buffer, out date))
		{
			return true;
		}
		date = default(DateTimeOffset);
		return false;
	}

	public static bool TryParse(byte[] buffer, out DateTimeOffset date)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		List<DateToken> tokens = new List<DateToken>(TokenizeDate(buffer, 0, buffer.Length));
		if (TryParseStandardDateFormat(tokens, buffer, out date))
		{
			return true;
		}
		if (TryParseUnknownDateFormat(tokens, buffer, out date))
		{
			return true;
		}
		date = default(DateTimeOffset);
		return false;
	}

	public static bool TryParse(string text, out DateTimeOffset date)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		List<DateToken> tokens = new List<DateToken>(TokenizeDate(bytes, 0, bytes.Length));
		if (TryParseStandardDateFormat(tokens, bytes, out date))
		{
			return true;
		}
		if (TryParseUnknownDateFormat(tokens, bytes, out date))
		{
			return true;
		}
		date = default(DateTimeOffset);
		return false;
	}

	internal static DateTime Parse(string text, string format)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int i;
		for (i = 0; i < text.Length && i < format.Length && format[i] != 'z'; i++)
		{
			if (text[i] < '0' || text[i] > '9')
			{
				throw new FormatException();
			}
			int num7 = text[i] - 48;
			switch (format[i])
			{
			case 'y':
				num4 = num4 * 10 + num7;
				break;
			case 'M':
				num5 = num5 * 10 + num7;
				break;
			case 'd':
				num6 = num6 * 10 + num7;
				break;
			case 'H':
				num = num * 10 + num7;
				break;
			case 'm':
				num2 = num2 * 10 + num7;
				break;
			case 's':
				num3 = num3 * 10 + num7;
				break;
			}
		}
		num2 += num3 / 60;
		num3 %= 60;
		num += num2 / 60;
		num2 %= 60;
		if (!timezones.TryGetValue(text.Substring(i), out var value))
		{
			value = 0;
		}
		TimeSpan value2 = new TimeSpan(value / 100, value % 100, 0);
		return new DateTime(num4, num5, num6, num, num2, num3, DateTimeKind.Utc).Add(value2);
	}

	public static string FormatDate(DateTimeOffset date)
	{
		return string.Format(CultureInfo.InvariantCulture, "{0}, {1:00} {2} {3:0000} {4:00}:{5:00}:{6:00} {7:+00;-00}{8:00}", WeekDays[(int)date.DayOfWeek], date.Day, Months[date.Month - 1], date.Year, date.Hour, date.Minute, date.Second, date.Offset.Hours, date.Offset.Minutes);
	}
}
