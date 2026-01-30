using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public struct DateRange : IComparable<DateRange>, IEnumerable<DateTime>, IEnumerable, IEquatable<DateRange>
{
	private DateTime gv;

	private DateTime DX;

	private static object sO;

	public int Count => (int)(EndDate - StartDate).TotalDays + 1;

	public DateTime EndDate => gv;

	public DateTime StartDate => DX;

	private DateRange(DateTime startDate, DateTime endDate)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		DX = ((startDate < endDate) ? startDate.Date : endDate.Date);
		gv = ((startDate < endDate) ? endDate.Date : startDate.Date);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public int CompareTo(DateRange other)
	{
		if (StartDate == other.StartDate && EndDate == other.EndDate)
		{
			return 0;
		}
		if (StartDate < other.StartDate)
		{
			return -1;
		}
		return 1;
	}

	public bool Contains(DateTime date)
	{
		date = date.Date;
		return date >= DX && date <= gv;
	}

	public bool Contains(DateRange dateRange)
	{
		return dateRange.StartDate >= DX && dateRange.StartDate <= gv;
	}

	public override bool Equals(object obj)
	{
		if (obj is DateRange)
		{
			return Equals((DateRange)obj);
		}
		return false;
	}

	public bool Equals(DateRange other)
	{
		return CompareTo(other) == 0;
	}

	public static DateRange FromDate(DateTime date)
	{
		return new DateRange(date, date);
	}

	public static DateRange FromDecade(DateTime date)
	{
		DateTime dateTime = new DateTime(date.Year / 10 * 10, 1, 1);
		DateTime endDate = DateTime.MaxValue;
		if (dateTime < endDate.AddYears(-10))
		{
			endDate = dateTime.AddYears(10).AddDays(-1.0);
		}
		return new DateRange(dateTime, endDate);
	}

	public static DateRange FromMonth(DateTime date)
	{
		DateTime dateTime = new DateTime(date.Year, date.Month, 1);
		DateTime endDate = DateTime.MaxValue;
		if (dateTime < endDate.AddMonths(-1))
		{
			endDate = dateTime.AddMonths(1).AddDays(-1.0);
		}
		return new DateRange(dateTime, endDate);
	}

	public static DateRange FromRange(DateTime startDate, DateTime endDate)
	{
		return new DateRange(startDate, endDate);
	}

	public static DateRange FromYear(DateTime date)
	{
		DateTime dateTime = new DateTime(date.Year, 1, 1);
		DateTime endDate = DateTime.MaxValue;
		if (dateTime < endDate.AddYears(-1))
		{
			endDate = dateTime.AddYears(1).AddDays(-1.0);
		}
		return new DateRange(dateTime, endDate);
	}

	public IEnumerator<DateTime> GetEnumerator()
	{
		DateTime current = DX;
		DateTime stop = gv;
		do
		{
			yield return current;
			if (current == stop)
			{
				break;
			}
			current = current.AddDays(1.0);
		}
		while (current <= stop);
	}

	public override int GetHashCode()
	{
		return DX.GetHashCode() ^ gv.GetHashCode();
	}

	public bool OverlapsWith(DateRange otherRange)
	{
		return otherRange.EndDate > DX && otherRange.StartDate < gv;
	}

	public override string ToString()
	{
		if (!(DX == gv))
		{
			return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(14), new object[2] { DX, gv });
		}
		return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(0), new object[1] { DX });
	}

	public static bool operator ==(DateRange left, DateRange right)
	{
		return left.CompareTo(right) == 0;
	}

	public static bool operator !=(DateRange left, DateRange right)
	{
		return !(left == right);
	}

	public static bool operator <(DateRange left, DateRange right)
	{
		return left.CompareTo(right) == -1;
	}

	public static bool operator >(DateRange left, DateRange right)
	{
		return left.CompareTo(right) == 1;
	}

	internal static bool Aq()
	{
		return sO == null;
	}

	internal static object nG()
	{
		return sO;
	}
}
