using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls;

[SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
public enum ResizeOperation
{
	None = 61440,
	West,
	East,
	North,
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "NorthWest")]
	NorthWest,
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "NorthEast")]
	NorthEast,
	South,
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "SouthWest")]
	SouthWest,
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "SouthEast")]
	SouthEast
}
