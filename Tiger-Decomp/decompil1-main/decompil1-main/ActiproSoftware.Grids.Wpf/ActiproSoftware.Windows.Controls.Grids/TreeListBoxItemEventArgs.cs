using System;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids;

public class TreeListBoxItemEventArgs : CancelRoutedEventArgs
{
	[CompilerGenerated]
	private TreeListBoxItem nUc;

	[CompilerGenerated]
	private object nUV;

	internal static TreeListBoxItemEventArgs zWk;

	public TreeListBoxItem Container
	{
		[CompilerGenerated]
		get
		{
			return nUc;
		}
		[CompilerGenerated]
		private set
		{
			nUc = value;
		}
	}

	public object Item
	{
		[CompilerGenerated]
		get
		{
			return nUV;
		}
		[CompilerGenerated]
		private set
		{
			nUV = value;
		}
	}

	public TreeListBoxItemEventArgs(object item, TreeListBoxItem container)
	{
		fc.taYSkz();
		base._002Ector();
		if (item == null)
		{
			throw new ArgumentNullException(xv.hTz(3356));
		}
		Item = item;
		Container = container;
	}

	internal static bool uWm()
	{
		return zWk == null;
	}

	internal static TreeListBoxItemEventArgs tWi()
	{
		return zWk;
	}
}
