using System;

namespace ActiproSoftware.Windows.Controls.Editors;

[Flags]
public enum TimeSpanEditableParts
{
	None = 0,
	Days = 1,
	Hours = 2,
	Minutes = 4,
	Seconds = 8,
	Milliseconds = 0x10,
	All = 0x1F
}
