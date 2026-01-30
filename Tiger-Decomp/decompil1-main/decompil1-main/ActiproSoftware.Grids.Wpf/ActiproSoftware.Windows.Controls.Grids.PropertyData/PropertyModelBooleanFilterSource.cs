using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public enum PropertyModelBooleanFilterSource
{
	CanResetValue,
	HasStandardValues,
	IsLimitedToStandardValues,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Mergeable")]
	IsMergeable,
	IsModified,
	IsReadOnly
}
