namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IActiveEditorViewChangeEventSink
{
	void NotifyActiveEditorViewChanged(SyntaxEditor editor, EditorViewChangedEventArgs e);
}
