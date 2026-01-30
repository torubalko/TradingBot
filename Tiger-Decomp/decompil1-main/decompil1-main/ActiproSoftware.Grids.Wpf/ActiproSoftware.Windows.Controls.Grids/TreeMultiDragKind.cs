using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.Grids;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi")]
public enum TreeMultiDragKind
{
	None,
	Any,
	SameType,
	SameDepth,
	Siblings
}
