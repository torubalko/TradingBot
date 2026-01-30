using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public interface IEditorViewIntelliPrompt
{
	void RequestAutoComplete();

	void RequestCompletionSession();

	void RequestInsertSnippetSession();

	void RequestParameterInfoSession();

	void RequestQuickInfoSession();

	void RequestSurroundWithSession();
}
