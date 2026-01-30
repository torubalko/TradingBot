namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ISignatureItem
{
	IContentProvider ContentProvider { get; }

	object Tag { get; set; }
}
