using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Lexing;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
public interface IMergableTokenLexerData
{
	IClassificationType ClassificationType { get; }

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	IMergableLexer Lexer { get; }

	ILexicalScope LexicalScope { get; }

	ILexicalState LexicalState { get; }

	int TokenId { get; }

	string TokenKey { get; }
}
