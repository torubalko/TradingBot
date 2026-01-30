using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface IParameterInfoProvider : IOrderable, IKeyedObject
{
	bool RequestSession(IEditorView view);
}
