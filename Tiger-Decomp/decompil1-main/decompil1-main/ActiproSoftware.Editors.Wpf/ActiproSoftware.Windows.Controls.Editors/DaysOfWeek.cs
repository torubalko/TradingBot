using System;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.Editors;

[Flags]
[SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames")]
public enum DaysOfWeek
{
	None = 0,
	Sunday = 1,
	Monday = 2,
	Tuesday = 4,
	Wednesday = 8,
	Thursday = 0x10,
	Friday = 0x20,
	Saturday = 0x40,
	Weekdays = 0x3E,
	Weekend = 0x41,
	All = 0x7F
}
