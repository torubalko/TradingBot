using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICompletionProvider : IOrderable, IKeyedObject
{
	bool RequestSession(IEditorView view, bool canCommitWithoutPopup);
}
