using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

public interface IOutliningNodeDefinition : IKeyedObject
{
	bool HasEndDelimiter { get; }

	bool IsCollapsible { get; }

	bool IsDefaultCollapsed { get; }

	bool IsImplementation { get; }

	object GetCollapsedContent(IOutliningNode node);
}
