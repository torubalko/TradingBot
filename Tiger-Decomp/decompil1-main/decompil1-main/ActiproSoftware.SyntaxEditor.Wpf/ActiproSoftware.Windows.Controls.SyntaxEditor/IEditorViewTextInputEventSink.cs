using System.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorViewTextInputEventSink
{
	void NotifyTextInput(IEditorView view, TextCompositionEventArgs e);
}
