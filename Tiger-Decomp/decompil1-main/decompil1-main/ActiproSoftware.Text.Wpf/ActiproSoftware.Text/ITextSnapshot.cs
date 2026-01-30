using System.Diagnostics.CodeAnalysis;
using System.Threading;
using ActiproSoftware.Text.Exporters;
using ActiproSoftware.Text.Searching;

namespace ActiproSoftware.Text;

public interface ITextSnapshot : ITextRangeProvider
{
	ITextDocument Document { get; }

	string FooterText { get; }

	bool HasContent { get; }

	string HeaderText { get; }

	int Length { get; }

	ITextSnapshotLineCollection Lines { get; }

	TextSnapshotRange SnapshotRange { get; }

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	string Text { get; }

	char this[int index] { get; }

	ITextVersion Version { get; }

	ITextChange CreateTextChange(ITextChangeType type);

	ITextChange CreateTextChange(ITextChangeType type, ITextChangeOptions options);

	string Export(ITextExporter exporter);

	void ExportToFile(ITextExporter exporter, string path);

	ISearchResultSet FindAll(ISearchOptions options);

	ISearchResultSet FindAll(ISearchOptions options, TextRange searchTextRange);

	ISearchResultSet FindNext(ISearchOptions options, int startOffset, bool canWrap);

	ISearchResultSet FindNext(ISearchOptions options, int startOffset, bool canWrap, TextRange searchTextRange);

	ISearchResultSet FindNext(ISearchOptions options, int startOffset, bool canWrap, TextRange searchTextRange, CancellationToken cancellationToken);

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	ITextBufferReader GetMergedBufferReader();

	ITextSnapshotReader GetReader(int offset);

	ITextSnapshotReader GetReader(TextPosition position);

	string GetSubstring(int offset, int length);

	string GetSubstring(TextRange textRange);

	string GetSubstring(int offset, int length, LineTerminator lineTerminator);

	string GetSubstring(TextRange textRange, LineTerminator lineTerminator);

	string GetText(LineTerminator lineTerminator);

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	ITextStatistics GetTextStatistics();

	string GetWordText(int offset);

	TextRange GetWordTextRange(int offset);

	TextPosition OffsetToPosition(int offset);

	TextRange PositionRangeToTextRange(TextPositionRange positionRange);

	int PositionToOffset(TextPosition position);

	TextPositionRange TextRangeToPositionRange(TextRange textRange);
}
