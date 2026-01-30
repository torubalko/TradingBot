using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class DockingWindowDefaultLocationEventArgs : DockingWindowEventArgs
{
	[CompilerGenerated]
	private Point? kC6;

	[CompilerGenerated]
	private bool BC9;

	[CompilerGenerated]
	private Side? YCY;

	[CompilerGenerated]
	private DockingWindowState iCp;

	[CompilerGenerated]
	private IDockTarget qCs;

	internal static DockingWindowDefaultLocationEventArgs H15;

	public Point? FloatingLocation
	{
		[CompilerGenerated]
		get
		{
			return kC6;
		}
		[CompilerGenerated]
		set
		{
			kC6 = value;
		}
	}

	public bool ShouldFloat
	{
		[CompilerGenerated]
		get
		{
			return BC9;
		}
		[CompilerGenerated]
		set
		{
			BC9 = value;
		}
	}

	public Side? Side
	{
		[CompilerGenerated]
		get
		{
			return YCY;
		}
		[CompilerGenerated]
		set
		{
			YCY = value;
		}
	}

	public DockingWindowState State
	{
		[CompilerGenerated]
		get
		{
			return iCp;
		}
		[CompilerGenerated]
		private set
		{
			iCp = value;
		}
	}

	public IDockTarget Target
	{
		[CompilerGenerated]
		get
		{
			return qCs;
		}
		[CompilerGenerated]
		set
		{
			qCs = value;
		}
	}

	public DockingWindowDefaultLocationEventArgs(DockingWindow window, DockingWindowState state)
	{
		IVH.CecNqz();
		base._002Ector();
		if (window == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		base.Window = window;
		State = state;
	}

	internal static bool R1j()
	{
		return H15 == null;
	}

	internal static DockingWindowDefaultLocationEventArgs R1t()
	{
		return H15;
	}
}
