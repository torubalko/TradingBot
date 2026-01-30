using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows;

public enum DateTimeFormatPattern
{
	ShortDateTime,
	FullDateTime,
	LongDate,
	LongTime,
	MonthDay,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rfc")]
	Rfc1123,
	ShortDate,
	ShortTime,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sortable")]
	SortableDateTime,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sortable")]
	UniversalSortableDateTime,
	YearMonth,
	YearMonthNoDelimiter
}
