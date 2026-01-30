namespace ActiproSoftware.Windows.Controls.Rendering;

public interface ITextProvider
{
	int Length { get; }

	string GetSubstring(int characterIndex, int characterCount);

	int Translate(int characterIndex, TextProviderTranslateModes modes);
}
