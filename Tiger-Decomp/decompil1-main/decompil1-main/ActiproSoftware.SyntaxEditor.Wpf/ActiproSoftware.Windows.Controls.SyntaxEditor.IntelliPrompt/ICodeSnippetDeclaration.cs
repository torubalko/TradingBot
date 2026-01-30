namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICodeSnippetDeclaration
{
	string DefaultText { get; }

	string FunctionInvocation { get; }

	string Id { get; }

	bool IsEditable { get; }

	string ToolTip { get; }
}
