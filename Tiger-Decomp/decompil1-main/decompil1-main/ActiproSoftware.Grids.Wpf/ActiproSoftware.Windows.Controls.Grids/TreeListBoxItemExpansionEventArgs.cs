using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids;

public class TreeListBoxItemExpansionEventArgs : TreeListBoxItemEventArgs
{
	[CompilerGenerated]
	private TreeExpansionKind OUA;

	[CompilerGenerated]
	private object wU4;

	internal static TreeListBoxItemExpansionEventArgs jWA;

	public TreeExpansionKind Kind
	{
		[CompilerGenerated]
		get
		{
			return OUA;
		}
		[CompilerGenerated]
		private set
		{
			OUA = value;
		}
	}

	public object SourceItem
	{
		[CompilerGenerated]
		get
		{
			return wU4;
		}
		[CompilerGenerated]
		private set
		{
			wU4 = value;
		}
	}

	public TreeListBoxItemExpansionEventArgs(object item, TreeListBoxItem container, TreeExpansionKind kind, object sourceItem)
	{
		fc.taYSkz();
		base._002Ector(item, container);
		Kind = kind;
		SourceItem = sourceItem;
	}

	internal static bool YWJ()
	{
		return jWA == null;
	}

	internal static TreeListBoxItemExpansionEventArgs bWK()
	{
		return jWA;
	}
}
