using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Lexing;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
public interface ILexer : IKeyedObject
{
	ITokenIdProvider TokenIdProvider { get; }

	TextRange Parse(TextSnapshotRange snapshotRange, ILexerTarget parseTarget);
}
