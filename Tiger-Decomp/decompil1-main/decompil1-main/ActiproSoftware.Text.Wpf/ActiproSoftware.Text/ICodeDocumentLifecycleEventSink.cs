namespace ActiproSoftware.Text;

public interface ICodeDocumentLifecycleEventSink
{
	void NotifyDocumentAttached(ICodeDocument document);

	void NotifyDocumentDetached(ICodeDocument document);
}
