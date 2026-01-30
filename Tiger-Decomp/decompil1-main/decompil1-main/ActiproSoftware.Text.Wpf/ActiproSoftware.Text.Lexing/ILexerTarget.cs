using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Lexing;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
public interface ILexerTarget
{
	bool HasInitialContext { get; }

	void OnPostParse(int endOffset);

	[SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#")]
	ILexerContext OnPreParse(ref int startOffset);

	bool OnTokenParsed(IToken newToken, ILexicalScopeStateNode scopeStateNode);
}
