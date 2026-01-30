using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Margins.Implementation;

public class DefaultEditorViewMarginFactory : IEditorViewMarginFactory
{
	private static DefaultEditorViewMarginFactory rn0;

	public virtual IEditorViewMarginCollection CreateMargins(IEditorView view)
	{
		IEditorViewMarginCollection editorViewMarginCollection = new EditorViewMarginCollection();
		editorViewMarginCollection.Add(new EditorSelectionMargin(view));
		editorViewMarginCollection.Add(new EditorLineNumberMargin(view));
		editorViewMarginCollection.Add(new EditorIndicatorMargin(view));
		editorViewMarginCollection.Add(new EditorOutliningMargin(view));
		editorViewMarginCollection.Add(new EditorRulerMargin(view));
		editorViewMarginCollection.Add(new EditorWordWrapGlyphMargin(view));
		int num = 0;
		if (!ln7())
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => editorViewMarginCollection, 
		};
	}

	public DefaultEditorViewMarginFactory()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool ln7()
	{
		return rn0 == null;
	}

	internal static DefaultEditorViewMarginFactory Dnn()
	{
		return rn0;
	}
}
