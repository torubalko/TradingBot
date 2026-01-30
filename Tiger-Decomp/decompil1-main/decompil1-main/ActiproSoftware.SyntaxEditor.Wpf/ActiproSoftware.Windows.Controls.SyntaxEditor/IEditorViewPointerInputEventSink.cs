using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorViewPointerInputEventSink
{
	void NotifyPointerEntered(IEditorView view, InputPointerEventArgs e);

	void NotifyPointerExited(IEditorView view, InputPointerEventArgs e);

	void NotifyPointerHovered(IEditorView view, InputPointerEventArgs e);

	void NotifyPointerMoved(IEditorView view, InputPointerEventArgs e);

	void NotifyPointerPressed(IEditorView view, InputPointerButtonEventArgs e);

	void NotifyPointerReleased(IEditorView view, InputPointerButtonEventArgs e);

	void NotifyPointerWheel(IEditorView view, InputPointerWheelEventArgs e);
}
