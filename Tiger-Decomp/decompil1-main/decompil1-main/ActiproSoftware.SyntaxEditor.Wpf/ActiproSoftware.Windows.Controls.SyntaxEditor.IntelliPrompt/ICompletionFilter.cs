using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICompletionFilter : IKeyedObject
{
	string GroupName { get; set; }

	bool IsActive { get; set; }

	CompletionFilterResult Filter(ICompletionSession session, ICompletionItem item);
}
