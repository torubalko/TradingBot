namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorDocumentTextChangeEventSink
{
	void NotifyDocumentTextChanged(SyntaxEditor editor, EditorSnapshotChangedEventArgs e);

	void NotifyDocumentTextChanging(SyntaxEditor editor, EditorSnapshotChangingEventArgs e);
}
