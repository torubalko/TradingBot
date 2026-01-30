using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICodeSnippetProvider : IOrderable, IKeyedObject
{
	bool IsCaseSensitive { get; }

	ICodeSnippetFolder RootFolder { get; }

	bool RequestSelectionSession(IEditorView view, CodeSnippetTypes snippetType);

	bool RequestTemplateSession(IEditorView view, ICodeSnippet codeSnippet);
}
