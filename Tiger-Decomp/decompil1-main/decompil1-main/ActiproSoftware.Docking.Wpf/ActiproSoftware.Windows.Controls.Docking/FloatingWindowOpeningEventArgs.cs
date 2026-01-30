using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class FloatingWindowOpeningEventArgs : RoutedEventArgs
{
	[CompilerGenerated]
	private DockHost xmL;

	[CompilerGenerated]
	private Size um3;

	internal static FloatingWindowOpeningEventArgs P1R;

	public DockHost DockHost
	{
		[CompilerGenerated]
		get
		{
			return xmL;
		}
		[CompilerGenerated]
		internal set
		{
			xmL = value;
		}
	}

	public FrameworkElement DockHostChild => (DockHost.pGK() as FrameworkElement) ?? DockHost.Child;

	public Size Size
	{
		[CompilerGenerated]
		get
		{
			return um3;
		}
		[CompilerGenerated]
		set
		{
			um3 = value;
		}
	}

	public FloatingWindowOpeningEventArgs(DockHost dockHost)
	{
		IVH.CecNqz();
		base._002Ector();
		if (dockHost == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		DockHost = dockHost;
	}

	internal static bool Q1D()
	{
		return P1R == null;
	}

	internal static FloatingWindowOpeningEventArgs H1E()
	{
		return P1R;
	}
}
