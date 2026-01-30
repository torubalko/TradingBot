using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Lexing;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
public interface ILexerContext
{
	ILexicalScopeStateNode ScopeState { get; }
}
