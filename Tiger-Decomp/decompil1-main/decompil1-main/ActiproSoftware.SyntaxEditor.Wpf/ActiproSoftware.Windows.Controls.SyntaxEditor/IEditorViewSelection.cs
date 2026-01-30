using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorViewSelection
{
	int CaretCharacterColumn { get; }

	int CaretDisplayCharacterColumn { get; }

	int CaretOffset { get; set; }

	TextPosition CaretPosition { get; set; }

	int EndOffset { get; set; }

	TextPosition EndPosition { get; set; }

	TextSnapshotOffset EndSnapshotOffset { get; }

	int FirstOffset { get; }

	TextPosition FirstPosition { get; }

	bool IsNormalized { get; }

	bool IsReadOnly { get; }

	bool IsZeroLength { get; }

	int LastOffset { get; }

	TextPosition LastPosition { get; }

	int Length { get; }

	SelectionModes Mode { get; }

	TextPositionRange PositionRange { get; set; }

	ITextPositionRangeCollection Ranges { get; }

	TextSnapshotRange SnapshotRange { get; }

	int StartOffset { get; set; }

	TextPosition StartPosition { get; set; }

	TextSnapshotOffset StartSnapshotOffset { get; }

	TextRange TextRange { get; set; }

	void AddRange(TextPositionRange positionRange);

	IEditorViewSelectionState CaptureState();

	IEditorViewSelectionState CaptureState(TextRangeTrackingModes trackingModes);

	bool CodeBlockContract();

	bool CodeBlockExpand();

	void Collapse();

	void CollapseLeft();

	void CollapseRight();

	bool Contains(int offset);

	bool Contains(TextPosition position);

	IDisposable CreateBatch(EditorViewSelectionBatchOptions options);

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	IList<double> GetPreferredCaretHorizontalLocations();

	IList<TextRange> GetTextRanges();

	IList<TextRange> GetTextRanges(int minimumLines);

	void MoveDown();

	void MoveLeft();

	void MovePageDown();

	void MovePageUp();

	void MoveRight();

	void MoveToDocumentEnd();

	void MoveToDocumentStart();

	void MoveToLineEnd();

	void MoveToLineStart();

	void MoveToLineStartAfterIndentation();

	void MoveToMatchingBracket();

	void MoveToNextLineStartAfterIndentation();

	void MoveToNextWord();

	void MoveToPreviousLineStartAfterIndentation();

	void MoveToPreviousWord();

	void MoveToVisibleBottom();

	void MoveToVisibleTop();

	void MoveUp();

	void SelectAll();

	void SelectBlockDown();

	void SelectBlockLeft();

	void SelectBlockRight();

	void SelectBlockToNextWord();

	void SelectBlockToPreviousWord();

	void SelectBlockUp();

	void SelectDown();

	void SelectLeft();

	void SelectPageDown();

	void SelectPageUp();

	void SelectRange(int offset, int length);

	void SelectRange(int offset, int length, SelectionModes mode);

	void SelectRange(TextRange textRange);

	void SelectRange(TextRange textRange, SelectionModes mode);

	void SelectRange(TextPosition startPosition, TextPosition endPosition);

	void SelectRange(TextPositionRange positionRange);

	void SelectRange(TextPosition startPosition, TextPosition endPosition, SelectionModes mode);

	void SelectRange(TextPositionRange positionRange, SelectionModes mode);

	void SelectRanges(IEnumerable<TextPositionRange> positionRanges);

	void SelectRanges(IEnumerable<TextPositionRange> positionRanges, int? primaryIndex);

	void SelectRight();

	void SelectToDocumentEnd();

	void SelectToDocumentStart();

	void SelectToLineEnd();

	void SelectToLineStart();

	void SelectToLineStartAfterIndentation();

	void SelectToMatchingBracket();

	void SelectToNextWord();

	void SelectToPreviousWord();

	void SelectToVisibleBottom();

	void SelectToVisibleTop();

	void SelectUp();

	void SelectWord();

	bool ToggleRange(TextPositionRange positionRange);
}
