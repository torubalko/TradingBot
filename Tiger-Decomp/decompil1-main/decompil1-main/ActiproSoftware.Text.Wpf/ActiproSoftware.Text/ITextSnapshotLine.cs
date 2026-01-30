using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text;

public interface ITextSnapshotLine : ITextRangeProvider
{
	int EndOffset { get; }

	int EndOffsetIncludingLineTerminator { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	int FirstNonWhitespaceCharacterOffset { get; }

	int IndentAmount { get; set; }

	int Index { get; }

	bool IsLastLine { get; }

	int Length { get; }

	ITextSnapshot Snapshot { get; }

	TextSnapshotRange SnapshotRange { get; }

	int StartOffset { get; }

	string Text { get; }

	TextRange TextRangeIncludingLineTerminator { get; }

	bool Contains(int offset);

	int GetIndentAmountBefore(int offset);

	bool IsLineEnd(int offset);

	bool IsLineStart(int offset);
}
