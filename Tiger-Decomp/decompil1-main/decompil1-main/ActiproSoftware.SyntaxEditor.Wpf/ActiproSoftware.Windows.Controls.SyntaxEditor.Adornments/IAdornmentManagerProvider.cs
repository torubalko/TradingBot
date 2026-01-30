namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;

public interface IAdornmentManagerProvider
{
	IAdornmentManager GetAdornmentManager(ITextView view);
}
