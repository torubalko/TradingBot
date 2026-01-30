using System.Collections.Generic;

namespace ActiproSoftware.Text;

public interface ITextChange
{
	bool CanMergeIntoPreviousChange { get; }

	bool CheckReadOnly { get; }

	object CustomData { get; set; }

	bool IsMerged { get; }

	bool IsRedo { get; }

	bool IsUndo { get; }

	int LastTextReplacementOperationIndex { get; }

	IList<ITextChangeOperation> Operations { get; }

	ITextPositionRangeCollection PostSelectionPositionRanges { get; set; }

	ITextPositionRangeCollection PreSelectionPositionRanges { get; set; }

	bool RetainSelection { get; }

	ITextSnapshot Snapshot { get; }

	object Source { get; }

	ITextChangeType Type { get; }

	void AppendText(string text);

	bool Apply();

	bool Apply(IList<TextRange> pendingSelectionTextRanges, int primaryIndex, TextRangeTrackingModes? translationTrackingModes);

	bool Apply(ITextPositionRangeCollection pendingSelectionPositionRanges, TextRangeTrackingModes translationTrackingModes);

	void DeleteText(TextRange textRange);

	void DeleteText(int offset, int deleteLength);

	void InsertText(int offset, string text);

	void ReplaceText(TextRange textRange, string insertText);

	void ReplaceText(int offset, int deleteLength, string insertText);

	void SetText(string text);

	void SetText(string text, bool isProgrammatic);
}
