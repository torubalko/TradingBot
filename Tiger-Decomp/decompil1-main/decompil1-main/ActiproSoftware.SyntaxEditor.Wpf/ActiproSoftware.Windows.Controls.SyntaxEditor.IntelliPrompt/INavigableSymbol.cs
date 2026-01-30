using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface INavigableSymbol
{
	IContentProvider ContentProvider { get; }

	int HierarchyLevel { get; }

	TextSnapshotOffset? NavigationSnapshotOffset { get; }

	TextSnapshotRange SnapshotRange { get; }
}
