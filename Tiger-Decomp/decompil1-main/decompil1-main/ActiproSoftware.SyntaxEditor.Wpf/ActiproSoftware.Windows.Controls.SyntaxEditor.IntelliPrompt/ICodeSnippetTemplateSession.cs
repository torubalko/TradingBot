using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICodeSnippetTemplateSession : IIntelliPromptSession, IServiceLocator
{
	ICodeSnippetDeclaration ActiveDeclaration { get; }

	ICodeSnippet CodeSnippet { get; }

	bool IsAutoIndentEnabled { get; }

	void Open(IEditorView view);
}
