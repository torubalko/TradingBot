using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Lexing;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
public interface IMergableLexer : ILexer, IKeyedObject
{
	ILexicalState DefaultLexicalState { get; }

	ILexicalStateIdProvider LexicalStateIdProvider { get; }

	event EventHandler Changed;

	IDisposable CreateChangeBatch();

	IMergableToken CreateDocumentEndToken(int startOffset, TextPosition startPosition, ILexicalState lexicalState);

	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "lexer")]
	IMergableToken CreateToken(int startOffset, int length, TextPosition startPosition, TextPosition endPosition, MergableLexerFlags lexerFlags, ILexicalState lexicalState, IMergableTokenLexerData lexerData);

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	IEnumerable<ILexicalStateTransition> GetAllLexicalStateTransitions();

	MergableLexerResult GetDefaultToken(ITextBufferReader reader, ILexicalState lexicalState);

	MergableLexerResult GetNextToken(ITextBufferReader reader, ILexicalState lexicalState);
}
