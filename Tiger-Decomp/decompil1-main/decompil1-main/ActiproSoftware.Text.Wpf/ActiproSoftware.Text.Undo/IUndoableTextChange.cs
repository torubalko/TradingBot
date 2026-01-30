using System.Collections.Generic;

namespace ActiproSoftware.Text.Undo;

public interface IUndoableTextChange
{
	object CustomData { get; }

	string Description { get; }

	bool IsMerged { get; }

	IList<ITextChangeOperation> Operations { get; }

	ITextPositionRangeCollection PostSelectionPositionRanges { get; set; }

	ITextPositionRangeCollection PreSelectionPositionRanges { get; set; }

	bool RetainSelection { get; }

	ITextChangeType Type { get; }
}
