using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface IQuickInfoProvider : IEditorViewPointerInputEventSink, IOrderable, IKeyedObject
{
	object GetContext(IHitTestResult hitTestResult);

	object GetContext(IEditorView view, int offset);

	bool RequestSession(IEditorView view, object context, bool canTrackPointer);
}
