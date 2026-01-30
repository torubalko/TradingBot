using System.Runtime.CompilerServices;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class DockingMenuEventArgs : DockingWindowEventArgs
{
	[CompilerGenerated]
	private ContextMenu GIE;

	[CompilerGenerated]
	private DockingMenuKind uIr;

	private static DockingMenuEventArgs P1n;

	public ContextMenu Menu
	{
		[CompilerGenerated]
		get
		{
			return GIE;
		}
		[CompilerGenerated]
		set
		{
			GIE = value;
		}
	}

	public DockingMenuKind Kind
	{
		[CompilerGenerated]
		get
		{
			return uIr;
		}
		[CompilerGenerated]
		private set
		{
			uIr = value;
		}
	}

	public DockingMenuEventArgs(DockingMenuKind kind)
	{
		IVH.CecNqz();
		base._002Ector();
		Kind = kind;
	}

	internal static bool g1A()
	{
		return P1n == null;
	}

	internal static DockingMenuEventArgs P1Y()
	{
		return P1n;
	}
}
