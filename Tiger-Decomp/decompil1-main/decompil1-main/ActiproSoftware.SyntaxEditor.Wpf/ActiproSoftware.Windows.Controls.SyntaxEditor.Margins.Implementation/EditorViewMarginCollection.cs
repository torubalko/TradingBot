using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Margins.Implementation;

public class EditorViewMarginCollection : KeyedObservableCollection<IEditorViewMargin>, IEditorViewMarginCollection, IKeyedObservableCollection<IEditorViewMargin>, IObservableCollection<IEditorViewMargin>, IList<IEditorViewMargin>, ICollection<IEditorViewMargin>, IEnumerable<IEditorViewMargin>, IEnumerable
{
	internal static EditorViewMarginCollection OnL;

	public EditorViewMarginCollection()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool Cng()
	{
		return OnL == null;
	}

	internal static EditorViewMarginCollection qnA()
	{
		return OnL;
	}
}
