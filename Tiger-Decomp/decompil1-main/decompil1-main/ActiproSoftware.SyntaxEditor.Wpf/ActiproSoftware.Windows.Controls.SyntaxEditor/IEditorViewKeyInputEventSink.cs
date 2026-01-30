using System.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorViewKeyInputEventSink
{
	void NotifyKeyDown(IEditorView view, KeyEventArgs e);

	void NotifyKeyUp(IEditorView view, KeyEventArgs e);
}
