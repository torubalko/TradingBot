using ActiproSoftware.Internal;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class EditorDocumentChangedEventArgs : PropertyChangedRoutedEventArgs<IEditorDocument>
{
	private static EditorDocumentChangedEventArgs M3;

	public EditorDocumentChangedEventArgs(IEditorDocument oldValue, IEditorDocument newValue)
	{
		grA.DaB7cz();
		base._002Ector(oldValue, newValue);
	}

	internal static bool Wv()
	{
		return M3 == null;
	}

	internal static EditorDocumentChangedEventArgs yf()
	{
		return M3;
	}
}
