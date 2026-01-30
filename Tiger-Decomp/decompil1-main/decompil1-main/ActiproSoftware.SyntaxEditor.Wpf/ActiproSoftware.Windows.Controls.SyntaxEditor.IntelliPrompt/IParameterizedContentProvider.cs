namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface IParameterizedContentProvider : IContentProvider
{
	int? ParameterIndex { get; set; }
}
