using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids;

public class TreeListBoxItemMenuEventArgs : TreeListBoxItemEventArgs
{
	[CompilerGenerated]
	private bool JUz;

	[CompilerGenerated]
	private ContextMenu K6I;

	[CompilerGenerated]
	private Point? T6P;

	private static TreeListBoxItemMenuEventArgs RWE;

	public bool IsBackground
	{
		[CompilerGenerated]
		get
		{
			return JUz;
		}
		[CompilerGenerated]
		private set
		{
			JUz = value;
		}
	}

	public ContextMenu Menu
	{
		[CompilerGenerated]
		get
		{
			return K6I;
		}
		[CompilerGenerated]
		set
		{
			K6I = value;
		}
	}

	public Point? PointerLocation
	{
		[CompilerGenerated]
		get
		{
			return T6P;
		}
		[CompilerGenerated]
		set
		{
			T6P = value;
		}
	}

	public TreeListBoxItemMenuEventArgs(object item, TreeListBoxItem container, Point? pointerLocation, bool isBackground)
	{
		fc.taYSkz();
		base._002Ector(item, container);
		PointerLocation = pointerLocation;
		IsBackground = isBackground;
	}

	internal static bool eWg()
	{
		return RWE == null;
	}

	internal static TreeListBoxItemMenuEventArgs FWP()
	{
		return RWE;
	}
}
