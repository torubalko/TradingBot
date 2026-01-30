using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Lexing;

public interface ILexicalState : IKeyedObject
{
	ILexicalStateCollection ChildLexicalStates { get; }

	int DefaultTokenId { get; set; }

	int Id { get; }

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	ILexer Lexer { get; }

	ILexicalScopeCollection LexicalScopes { get; }

	object Tag { get; set; }

	ILexicalStateTransition Transition { get; set; }
}
