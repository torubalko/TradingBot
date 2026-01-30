using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IIndentProvider
{
	IndentMode Mode { get; }

	int GetIndentAmount(TextSnapshotOffset snapshotOffset, int defaultAmount);
}
