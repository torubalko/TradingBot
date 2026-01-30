using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Exporters;
using ActiproSoftware.Text.Searching;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorView : ITextView
{
	bool ContainsFocus { get; }

	ITextSnapshotLine CurrentSnapshotLine { get; }

	ITextViewLine CurrentViewLine { get; }

	bool HasFocus { get; }

	ISearchOptions HighlightedResultSearchOptions { get; set; }

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
	IEditorViewIntelliPrompt IntelliPrompt { get; }

	bool IsActive { get; }

	bool IsIncrementalSearchActive { get; set; }

	IEditorViewMarginCollection Margins { get; }

	IEditorViewOverlayPaneCollection OverlayPanes { get; }

	EditorViewPlacement Placement { get; }

	ITextPositionFinder PositionFinder { get; }

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Scroller")]
	IEditorViewScroller Scroller { get; }

	IEditorViewSearcher Searcher { get; }

	string SelectedText { get; set; }

	IEditorViewSelection Selection { get; }

	IEditorViewTextChangeActions TextChangeActions { get; }

	event RoutedEventHandler HasFocusChanged;

	event RoutedEventHandler HighlightedResultSearchOptionsChanged;

	event EventHandler<EditorViewSelectionEventArgs> SelectionChanged;

	void Activate();

	void CopyToClipboard();

	void CopyAndAppendToClipboard();

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "CutLine")]
	void CutLineToClipboard();

	void CutToClipboard();

	void CutAndAppendToClipboard();

	bool DeleteSelectedText(ITextChangeType type);

	bool DeleteSelectedText(ITextChangeType type, IEditorViewTextChangeOptions options);

	bool ExecuteEditAction(IEditAction action);

	string ExportSelectedText(ITextExporter exporter);

	int FindCurrentWordEnd();

	int FindCurrentWordStart();

	int FindNextWordStart();

	int FindPreviousWordStart();

	bool Focus();

	TextBounds GetCharacterBounds(int offset);

	TextBounds GetCharacterBounds(int offset, bool hasFarAffinity);

	TextBounds GetCharacterBounds(TextPosition position);

	int GetCharacterColumn(int offset);

	int GetCharacterColumn(int offset, bool hasFarAffinity);

	int GetCharacterColumn(TextPosition position);

	IList<Range> GetCharacterIndexRanges(TextPositionRange positionRange);

	IList<Range> GetCharacterIndexRanges(TextPositionRange positionRange, int minimumLines);

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	string GetCurrentWordText();

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	TextRange GetCurrentWordTextRange();

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	ITextSnapshotReader GetReader();

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	ITextStatistics GetTextStatisticsForSelectedText();

	ITextViewLine GetViewLine(double verticalLocation, LocationToPositionAlgorithm algorithm);

	string GetVirtualCharacterFillString(TextPosition position, bool returnCharacterFill);

	void InsertFile(string path);

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "preText")]
	bool InsertSurroundingText(string preText, string postText);

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "preText")]
	bool InsertSurroundingText(ITextChangeType type, string preText, string postText);

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "preText")]
	bool InsertSurroundingText(ITextChangeType type, string preText, string postText, bool reselect);

	bool IsVirtualCharacter(TextPosition position, bool lineTerminatorsAreVirtual);

	bool IsVirtualLine(int positionLineIndex);

	bool IsVirtualLine(TextPosition position);

	TextPosition LocationToPosition(Point location, LocationToPositionAlgorithm algorithm);

	void PasteFromClipboard();

	void PasteFromClipboard(IDataObject clipboardData);

	bool ReplaceSelectedText(ITextChangeType type, string text);

	bool ReplaceSelectedText(ITextChangeType type, string text, IEditorViewTextChangeOptions options);

	void StartPointerSelection(InputPointerButtonEventArgs e);
}
