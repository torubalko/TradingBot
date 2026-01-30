using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorViewSelectionState
{
	ITextPositionRangeCollection Ranges { get; }

	void Restore();

	void Restore(bool collapseColumns);
}
