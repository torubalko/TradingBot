using System.Runtime.CompilerServices;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids;

public class TreeListViewColumnMenuEventArgs : TreeListViewColumnEventArgs
{
	[CompilerGenerated]
	private ContextMenu iJB;

	internal static TreeListViewColumnMenuEventArgs tWZ;

	public ContextMenu Menu
	{
		[CompilerGenerated]
		get
		{
			return iJB;
		}
		[CompilerGenerated]
		set
		{
			iJB = value;
		}
	}

	public TreeListViewColumnMenuEventArgs(TreeListViewColumn column)
	{
		fc.taYSkz();
		base._002Ector(column);
	}

	internal static bool eWx()
	{
		return tWZ == null;
	}

	internal static TreeListViewColumnMenuEventArgs DWS()
	{
		return tWZ;
	}
}
