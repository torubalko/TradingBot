namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;

public interface IAdornmentManager
{
	IAdornmentLayer AdornmentLayer { get; }

	bool IsActive { get; set; }

	ITextView View { get; }

	void Close();
}
