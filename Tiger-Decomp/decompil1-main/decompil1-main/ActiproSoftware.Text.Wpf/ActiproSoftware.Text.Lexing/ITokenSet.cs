using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ActiproSoftware.Text.Lexing;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public interface ITokenSet : IEnumerable<IToken>, IEnumerable, ITextRangeProvider
{
	int Count { get; }

	IToken FirstToken { get; }

	bool FirstTokenExtendsBack { get; }

	IToken LastToken { get; }

	bool LastTokenExtendsForward { get; }

	object ParseContext { get; }

	[IndexerName("Tokens")]
	IToken this[int index] { get; }

	int IndexOf(int offset, int hintIndex);
}
