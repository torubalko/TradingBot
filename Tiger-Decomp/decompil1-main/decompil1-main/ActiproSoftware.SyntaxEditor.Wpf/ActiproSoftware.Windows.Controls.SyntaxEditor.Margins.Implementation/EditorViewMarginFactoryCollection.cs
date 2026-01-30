using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Margins.Implementation;

public class EditorViewMarginFactoryCollection : ObservableCollection<IEditorViewMarginFactory>, IEditorViewMarginFactoryCollection, IList<IEditorViewMarginFactory>, ICollection<IEditorViewMarginFactory>, IEnumerable<IEditorViewMarginFactory>, IEnumerable, IList, ICollection
{
	internal static EditorViewMarginFactoryCollection Pnl;

	public EditorViewMarginFactoryCollection()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool WnW()
	{
		return Pnl == null;
	}

	internal static EditorViewMarginFactoryCollection inS()
	{
		return Pnl;
	}
}
