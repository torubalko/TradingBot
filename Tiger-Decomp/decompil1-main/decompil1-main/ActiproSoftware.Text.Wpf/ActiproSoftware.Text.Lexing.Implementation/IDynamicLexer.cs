using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Lexing.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
public interface IDynamicLexer : IMergableLexer, ILexer, IKeyedObject
{
	new DynamicLexicalState DefaultLexicalState { get; set; }

	new string Key { get; set; }

	IDynamicLexicalMacroCollection LexicalMacros { get; }

	IDynamicLexicalStateCollection LexicalStates { get; }
}
