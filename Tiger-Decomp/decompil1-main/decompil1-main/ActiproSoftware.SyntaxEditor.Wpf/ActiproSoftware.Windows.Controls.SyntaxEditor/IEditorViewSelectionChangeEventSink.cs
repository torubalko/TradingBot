namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorViewSelectionChangeEventSink
{
	void NotifySelectionChanged(IEditorView view, EditorViewSelectionEventArgs e);
}
