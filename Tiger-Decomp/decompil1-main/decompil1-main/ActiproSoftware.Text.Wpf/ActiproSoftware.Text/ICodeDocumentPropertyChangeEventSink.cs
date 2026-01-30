using ActiproSoftware.Text.Parsing;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text;

public interface ICodeDocumentPropertyChangeEventSink
{
	void NotifyFileNameChanged(ICodeDocument document, StringPropertyChangedEventArgs e);

	void NotifyParseDataChanged(ICodeDocument document, ParseDataPropertyChangedEventArgs e);
}
