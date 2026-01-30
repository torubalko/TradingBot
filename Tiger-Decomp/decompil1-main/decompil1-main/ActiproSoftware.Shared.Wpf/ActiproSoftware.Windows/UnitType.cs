using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows;

[SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
public enum UnitType
{
	Pixel = 1,
	Percentage,
	Inch,
	Centimeter,
	Point
}
