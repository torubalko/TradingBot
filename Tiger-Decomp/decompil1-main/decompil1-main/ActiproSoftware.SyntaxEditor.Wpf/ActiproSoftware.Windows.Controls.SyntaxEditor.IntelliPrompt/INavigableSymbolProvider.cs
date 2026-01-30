using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface INavigableSymbolProvider
{
	INavigableSymbolSet GetSymbols(INavigableRequestContext context, TextSnapshotOffset snapshotOffset, INavigableSymbol parentSymbol);
}
