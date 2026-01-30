using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids;

public class TreeListViewColumnEventArgs : CancelRoutedEventArgs
{
	[CompilerGenerated]
	private TreeListViewColumn Yqb;

	internal static TreeListViewColumnEventArgs iWt;

	public TreeListViewColumn Column
	{
		[CompilerGenerated]
		get
		{
			return Yqb;
		}
		[CompilerGenerated]
		private set
		{
			Yqb = value;
		}
	}

	public TreeListViewColumnEventArgs(TreeListViewColumn column)
	{
		fc.taYSkz();
		base._002Ector();
		Column = column;
	}

	internal static bool KW4()
	{
		return iWt == null;
	}

	internal static TreeListViewColumnEventArgs SWl()
	{
		return iWt;
	}
}
