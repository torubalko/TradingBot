using System;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

[Flags]
public enum EditorViewSelectionBatchOptions
{
	None = 0,
	NoScrollToCaret = 1,
	NoPreferredCaretHorizontalLocationsUpdate = 2,
	NoClearCodeBlockSelectionHistory = 4,
	ForceSelectionChangedEvent = 8,
	NoResetSearchStartOffset = 0x10
}
