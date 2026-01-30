using System;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class DockingWindowsDragOverEventArgs : DockingWindowsEventArgs
{
	[CompilerGenerated]
	private DockGuideKinds GCU;

	[CompilerGenerated]
	private DockHost HCc;

	[CompilerGenerated]
	private DockGuideKinds FC4;

	[CompilerGenerated]
	private IDockTarget aCj;

	private static DockingWindowsDragOverEventArgs L1Q;

	public DockGuideKinds AllowedDockGuideKinds
	{
		[CompilerGenerated]
		get
		{
			return GCU;
		}
		[CompilerGenerated]
		set
		{
			GCU = value;
		}
	}

	public DockHost DraggedDockHost
	{
		[CompilerGenerated]
		get
		{
			return HCc;
		}
		[CompilerGenerated]
		private set
		{
			HCc = value;
		}
	}

	public DockGuideKinds SupportedDockGuideKinds
	{
		[CompilerGenerated]
		get
		{
			return FC4;
		}
		[CompilerGenerated]
		private set
		{
			FC4 = value;
		}
	}

	public IDockTarget Target
	{
		[CompilerGenerated]
		get
		{
			return aCj;
		}
		[CompilerGenerated]
		private set
		{
			aCj = value;
		}
	}

	public DockingWindowsDragOverEventArgs(DockHost draggedDockHost, IDockTarget target, DockGuideKinds supportedDockGuideKinds)
	{
		IVH.CecNqz();
		base._002Ector(draggedDockHost);
		if (draggedDockHost == null)
		{
			throw new ArgumentNullException(vVK.ssH(9114));
		}
		if (target == null)
		{
			throw new ArgumentNullException(vVK.ssH(9148));
		}
		DraggedDockHost = draggedDockHost;
		Target = target;
		SupportedDockGuideKinds = supportedDockGuideKinds;
		AllowedDockGuideKinds = supportedDockGuideKinds;
	}

	internal static bool h1v()
	{
		return L1Q == null;
	}

	internal static DockingWindowsDragOverEventArgs s1N()
	{
		return L1Q;
	}
}
