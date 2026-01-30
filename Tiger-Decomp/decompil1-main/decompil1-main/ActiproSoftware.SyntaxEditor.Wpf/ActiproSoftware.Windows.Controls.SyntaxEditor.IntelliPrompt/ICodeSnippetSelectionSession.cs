using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICodeSnippetSelectionSession : IIntelliPromptSession, IServiceLocator
{
	string Label { get; }

	ICodeSnippetFolder RootFolder { get; }

	void Open(IEditorView view);
}
