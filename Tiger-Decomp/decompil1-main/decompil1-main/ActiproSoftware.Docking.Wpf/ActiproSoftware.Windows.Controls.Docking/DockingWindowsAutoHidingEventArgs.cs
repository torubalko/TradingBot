using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class DockingWindowsAutoHidingEventArgs : DockingWindowsEventArgs
{
	[CompilerGenerated]
	private Side iCF;

	internal static DockingWindowsAutoHidingEventArgs g1a;

	public Side Side
	{
		[CompilerGenerated]
		get
		{
			return iCF;
		}
		[CompilerGenerated]
		set
		{
			iCF = value;
		}
	}

	public DockingWindowsAutoHidingEventArgs(IEnumerable<DockingWindow> windows)
	{
		IVH.CecNqz();
		base._002Ector(windows);
	}

	internal static bool I1X()
	{
		return g1a == null;
	}

	internal static DockingWindowsAutoHidingEventArgs M1s()
	{
		return g1a;
	}
}
