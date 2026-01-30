using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class DockingWindowEventArgs : CancelRoutedEventArgs
{
	[CompilerGenerated]
	private DockingWindow JCq;

	internal static DockingWindowEventArgs x1p;

	public DockingWindow Window
	{
		[CompilerGenerated]
		get
		{
			return JCq;
		}
		[CompilerGenerated]
		set
		{
			JCq = value;
		}
	}

	public DockingWindowEventArgs()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool R14()
	{
		return x1p == null;
	}

	internal static DockingWindowEventArgs m12()
	{
		return x1p;
	}
}
