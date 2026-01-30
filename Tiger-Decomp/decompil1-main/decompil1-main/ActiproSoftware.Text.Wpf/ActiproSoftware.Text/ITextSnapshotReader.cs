using System;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text.Lexing;

namespace ActiproSoftware.Text;

public interface ITextSnapshotReader
{
	ITextBufferReader BufferReader { get; }

	char Character { get; }

	bool IsAtSnapshotEnd { get; }

	bool IsAtSnapshotLineEnd { get; }

	bool IsAtSnapshotLineStart { get; }

	bool IsAtSnapshotStart { get; }

	bool IsAtTokenStart { get; }

	bool IsCharacterLineTerminator { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	bool IsCharacterWhitespace { get; }

	ISyntaxLanguage Language { get; }

	int Length { get; }

	int Offset { get; set; }

	ITextSnapshotReaderOptions Options { get; }

	TextPosition Position { get; }

	ITextSnapshot Snapshot { get; }

	ITextSnapshotLine SnapshotLine { get; }

	IToken Token { get; }

	string TokenText { get; }

	void GoToCurrentSnapshotLineEnd();

	void GoToCurrentSnapshotLineStart();

	void GoToCurrentTokenStart();

	bool GoToCurrentWordEnd();

	bool GoToCurrentWordStart();

	bool GoToNextMatchingTokenById(int startTokenId, int endTokenId);

	void GoToNextSnapshotLineStart();

	bool GoToNextToken();

	bool GoToNextToken(int count);

	bool GoToNextToken(Predicate<IToken> predicate);

	bool GoToNextTokenWithId(int id);

	bool GoToNextTokenWithId(params int[] ids);

	bool GoToNextTokenWithKey(string key);

	bool GoToNextTokenWithKey(params string[] keys);

	bool GoToNextWordStart();

	bool GoToPreviousMatchingTokenById(int endTokenId, int startTokenId);

	void GoToPreviousSnapshotLineEnd();

	bool GoToPreviousToken();

	bool GoToPreviousToken(int count);

	bool GoToPreviousToken(Predicate<IToken> predicate);

	bool GoToPreviousTokenWithId(int id);

	bool GoToPreviousTokenWithId(params int[] ids);

	bool GoToPreviousTokenWithKey(string key);

	bool GoToPreviousTokenWithKey(params string[] keys);

	bool GoToPreviousWordStart();

	void GoToSnapshotEnd();

	void GoToSnapshotStart();

	char PeekCharacter();

	char PeekCharacterReverse();

	string PeekText(int maxCharCount);

	string PeekTextReverse(int maxCharCount);

	IToken PeekToken();

	IToken PeekTokenReverse();

	char ReadCharacter();

	char ReadCharacterReverse();

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	bool ReadCharacterReverseThrough(char ch);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	bool ReadCharacterReverseThrough(char ch, int minOffset);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	bool ReadCharacterThrough(char ch);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	bool ReadCharacterThrough(char ch, int maxOffset);

	string ReadText(int maxCharCount);

	string ReadTextReverse(int maxCharCount);

	IToken ReadToken();

	IToken ReadTokenReverse();

	void SeekCharacter(int delta);
}
