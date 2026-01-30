namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICodeSnippetTemplateSessionEventSink
{
	void NotifyDeclarationActivated(ICodeSnippetTemplateSession session);

	void NotifyDeclarationDeactivated(ICodeSnippetTemplateSession session);

	void NotifyDeclarationTextChanged(ICodeSnippetTemplateSession session);

	void NotifySessionClosed(ICodeSnippetTemplateSession session);

	void NotifySessionOpened(ICodeSnippetTemplateSession session);
}
