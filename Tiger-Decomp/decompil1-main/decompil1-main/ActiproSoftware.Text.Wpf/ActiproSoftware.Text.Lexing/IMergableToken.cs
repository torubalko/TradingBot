using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Lexing;

public interface IMergableToken : IToken
{
	string AutoCaseCorrectText { get; }

	IClassificationType ClassificationType { get; }

	ILexicalState DeclaringLexicalState { get; }

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	IMergableLexer Lexer { get; }

	ILexicalScope LexicalScope { get; }

	ILexicalState LexicalState { get; }

	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flag")]
	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "flag")]
	bool HasFlag(MergableLexerFlags flag);

	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flag")]
	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "flag")]
	void SetFlag(MergableLexerFlags flag, bool setBit);
}
