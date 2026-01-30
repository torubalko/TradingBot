using System;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Lexing;

[Flags]
[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
public enum MergableLexerFlags
{
	None = 0,
	LooseMatch = 1,
	ScopeStart = 2,
	ScopeEnd = 4,
	DirectStateTransition = 8,
	ScopeStateTransitionStart = 0x10,
	ScopeStateTransitionEnd = 0x20,
	LanguageStart = 0x40,
	LanguageEnd = 0x80
}
