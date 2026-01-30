using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

public interface IOutliner
{
	AutomaticOutliningUpdateTrigger UpdateTrigger { get; }

	IOutliningSource GetOutliningSource(ITextSnapshot snapshot);
}
