using ActiproSoftware.Internal;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class EditorDocumentLanguageChangedEventArgs : PropertyChangedRoutedEventArgs<ISyntaxLanguage>
{
	internal static EditorDocumentLanguageChangedEventArgs Fi;

	public EditorDocumentLanguageChangedEventArgs(ISyntaxLanguage oldValue, ISyntaxLanguage newValue)
	{
		grA.DaB7cz();
		base._002Ector(oldValue, newValue);
	}

	internal static bool b2()
	{
		return Fi == null;
	}

	internal static EditorDocumentLanguageChangedEventArgs dV()
	{
		return Fi;
	}
}
