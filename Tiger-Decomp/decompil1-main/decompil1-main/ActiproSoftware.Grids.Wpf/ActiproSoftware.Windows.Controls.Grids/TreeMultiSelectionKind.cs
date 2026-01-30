using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.Grids;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi")]
public enum TreeMultiSelectionKind
{
	Any,
	SameType,
	SameDepth,
	Siblings
}
