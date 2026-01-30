using System.Collections.Generic;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface INavigableSymbolSet
{
	bool IsPartial { get; }

	IEnumerable<INavigableSymbol> Symbols { get; }
}
