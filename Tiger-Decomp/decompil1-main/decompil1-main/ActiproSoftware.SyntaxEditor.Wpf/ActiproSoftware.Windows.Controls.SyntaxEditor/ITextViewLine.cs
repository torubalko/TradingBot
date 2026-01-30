using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Undo;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface ITextViewLine : ITextRangeProvider
{
	double Baseline { get; }

	double BottomMargin { get; }

	Rect Bounds { get; }

	TextViewLineChange Change { get; }

	int CharacterCount { get; }

	int EndOffset { get; }

	int EndOffsetIncludingLineTerminator { get; }

	TextPosition EndPosition { get; }

	TextPosition EndPositionIncludingLineTerminator { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	int FirstNonWhitespaceCharacterIndex { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	int FirstNonWhitespaceOffset { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "HardLine")]
	bool HasHardLineBreak { get; }

	int IndentAmount { get; }

	bool IsFirstLine { get; }

	bool IsLastLine { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	bool IsPureWhitespace { get; }

	bool IsVirtualLine { get; }

	bool IsWrapped { get; }

	TextPosition MaxPosition { get; }

	ITextViewLine NextLine { get; }

	TextPositionRange PositionRange { get; }

	ITextViewLine PreviousLine { get; }

	SavePointChangeType SavePointChangeType { get; }

	Size Size { get; }

	TextSnapshotRange SnapshotRange { get; }

	TextSnapshotRange SnapshotRangeIncludingLineTerminator { get; }

	int StartOffset { get; }

	TextPosition StartPosition { get; }

	int TabStopLevel { get; set; }

	string Text { get; set; }

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	Rect TextBounds { get; }

	TextRange TextRangeIncludingLineTerminator { get; }

	Size TextSize { get; }

	double TopMargin { get; }

	double TranslationY { get; }

	ITextView View { get; }

	TextViewLineVisibility Visibility { get; }

	IEnumerable<TextSnapshotRange> VisibleSnapshotRanges { get; }

	TextPosition VisibleStartPosition { get; }

	int WordWrapIndex { get; }

	int CharacterIndexToOffset(int characterIndex);

	TextPosition CharacterIndexToPosition(int characterIndex);

	TextBounds GetCharacterBounds(int offset);

	TextBounds GetCharacterBounds(TextPosition position);

	int GetCharacterColumn(int offset);

	int GetCharacterColumn(TextPosition position);

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	IEnumerable<TagSnapshotRange<TTag>> GetIntraLineSpacerTags<TTag>() where TTag : IIntraLineSpacerTag;

	TextBounds GetIntraTextSpacerBounds(object tagKey);

	TagSnapshotRange<IIntraTextSpacerTag> GetIntraTextSpacerTag(int characterIndex);

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	IEnumerable<TagSnapshotRange<TTag>> GetIntraTextSpacerTags<TTag>() where TTag : IIntraTextSpacerTag;

	IEnumerable<TextBounds> GetTextBounds(TextRange textRange);

	IEnumerable<TextBounds> GetTextBounds(TextPositionRange positionRange);

	bool IsVirtualCharacter(int characterIndex, bool lineTerminatorsAreVirtual);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "x")]
	int LocationToCharacterIndex(double x, LocationToPositionAlgorithm algorithm);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "x")]
	int LocationToOffset(double x, LocationToPositionAlgorithm algorithm);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "x")]
	TextPosition LocationToPosition(double x, LocationToPositionAlgorithm algorithm);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "x")]
	TextPosition LocationToPosition(double x, LocationToPositionAlgorithm algorithm, bool forceVirtualSpace);

	int OffsetToCharacterIndex(int offset);

	int PositionToCharacterIndex(TextPosition position);
}
