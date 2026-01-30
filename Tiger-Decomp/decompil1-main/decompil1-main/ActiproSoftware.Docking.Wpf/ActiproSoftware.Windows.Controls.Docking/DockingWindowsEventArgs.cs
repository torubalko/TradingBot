using System;
using System.Collections.Generic;
using System.Linq;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class DockingWindowsEventArgs : CancelRoutedEventArgs
{
	private DockHost tCZ;

	private IEnumerable<DockingWindow> CCb;

	internal static DockingWindowsEventArgs P1S;

	public IEnumerable<DockingWindow> Windows
	{
		get
		{
			if (CCb == null && tCZ != null)
			{
				CCb = from r in pL.Mxl<DockingWindow>(tCZ, null)
					select r.dx3();
			}
			return CCb;
		}
	}

	public DockingWindowsEventArgs(IEnumerable<DockingWindow> windows)
	{
		IVH.CecNqz();
		base._002Ector();
		if (windows == null)
		{
			throw new ArgumentNullException(vVK.ssH(9164));
		}
		CCb = windows;
	}

	public DockingWindowsEventArgs(DockHost dockHost)
	{
		IVH.CecNqz();
		base._002Ector();
		if (dockHost == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		tCZ = dockHost;
	}

	internal static bool m1P()
	{
		return P1S == null;
	}

	internal static DockingWindowsEventArgs R1e()
	{
		return P1S;
	}
}
