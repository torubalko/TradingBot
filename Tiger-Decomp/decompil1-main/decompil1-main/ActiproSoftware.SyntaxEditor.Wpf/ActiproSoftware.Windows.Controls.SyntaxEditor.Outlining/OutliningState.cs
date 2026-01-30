using System;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

[Flags]
[SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames")]
public enum OutliningState
{
	None = 0,
	IsTopLevel = 1,
	HasCollapsedNode = 2,
	HasExpandedNodeStart = 4,
	HasExpandedNodeEnd = 8,
	IsOpen = 0x10
}
