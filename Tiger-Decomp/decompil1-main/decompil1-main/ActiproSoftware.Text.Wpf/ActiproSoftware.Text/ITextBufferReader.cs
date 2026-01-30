using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace ActiproSoftware.Text;

public interface ITextBufferReader
{
	bool HasStackEntries { get; }

	bool IsAtEnd { get; }

	bool IsAtStart { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "OnLine")]
	bool IsWhitespaceOnlyAfterOnLine { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "OnLine")]
	bool IsWhitespaceOnlyBeforeOnLine { get; }

	int Length { get; }

	int Offset { get; set; }

	int OffsetDelta { get; }

	TextPosition Position { get; }

	TextPosition PositionDelta { get; }

	TextReader AsTextReader();

	string GetSubstring(int offset, int length);

	char Peek();

	char Peek(int count);

	char PeekReverse();

	bool Pop();

	bool PopAll();

	void Push();

	char Read();

	char ReadReverse();

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	bool ReadReverseThrough(char ch);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	bool ReadReverseThrough(char ch, int minOffset);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	bool ReadThrough(char ch);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	bool ReadThrough(char ch, int maxOffset);
}
