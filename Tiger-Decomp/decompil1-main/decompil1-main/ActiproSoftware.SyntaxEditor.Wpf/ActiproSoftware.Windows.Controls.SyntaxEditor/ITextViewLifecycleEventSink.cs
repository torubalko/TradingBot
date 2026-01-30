namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface ITextViewLifecycleEventSink
{
	void NotifyViewAttached(ITextView view);

	void NotifyViewDetached(ITextView view);
}
