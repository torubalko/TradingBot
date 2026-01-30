using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class EditorViewChangedEventArgs : PropertyChangedRoutedEventArgs<IEditorView>
{
	internal static EditorViewChangedEventArgs jo;

	public EditorViewChangedEventArgs(IEditorView oldValue, IEditorView newValue)
	{
		grA.DaB7cz();
		base._002Ector(oldValue, newValue);
	}

	internal static bool iQ()
	{
		return jo == null;
	}

	internal static EditorViewChangedEventArgs Yy()
	{
		return jo;
	}
}
