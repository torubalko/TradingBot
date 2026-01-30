using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Data;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Internal;

internal class gy : ListCollectionView, ICompletionItemCollectionView, ICollectionView, IEnumerable, INotifyCollectionChanged
{
	private static gy kaw;

	public ICompletionItem this[int P_0] => GetItemAt(P_0) as ICompletionItem;

	public gy(IList P_0)
	{
		grA.DaB7cz();
		base._002Ector(P_0);
	}

	public bool Contains(ICompletionItem P_0)
	{
		return Contains((object)P_0);
	}

	public int IndexOf(ICompletionItem P_0)
	{
		return IndexOf((object)P_0);
	}

	internal static bool Tau()
	{
		return kaw == null;
	}

	internal static gy Pa8()
	{
		return kaw;
	}
}
