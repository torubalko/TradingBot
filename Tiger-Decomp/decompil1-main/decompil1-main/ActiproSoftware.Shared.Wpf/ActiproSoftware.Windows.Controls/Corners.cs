using System;

namespace ActiproSoftware.Windows.Controls;

[Flags]
public enum Corners
{
	None = 0,
	TopLeft = 1,
	TopRight = 2,
	BottomRight = 4,
	BottomLeft = 8,
	Left = 9,
	Top = 3,
	Right = 6,
	Bottom = 0xC,
	All = 0xF
}
