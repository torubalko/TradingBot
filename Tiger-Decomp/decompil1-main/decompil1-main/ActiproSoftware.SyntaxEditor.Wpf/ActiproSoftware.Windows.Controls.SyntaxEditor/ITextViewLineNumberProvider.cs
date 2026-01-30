namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface ITextViewLineNumberProvider
{
	string GetLargestLineNumberText(ITextView view);

	string GetLineNumberText(ITextViewLine viewLine);
}
