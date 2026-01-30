using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls;

[SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
[SuppressMessage("Microsoft.Design", "CA1027:MarkEnumsWithFlags")]
public enum Corner
{
	TopLeft = 1,
	TopRight = 2,
	BottomRight = 4,
	BottomLeft = 8
}
