using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class AdvancedTabItemEventArgs : CancelRoutedEventArgs
{
	[CompilerGenerated]
	private AdvancedTabItem m2O;

	internal static AdvancedTabItemEventArgs U2;

	public AdvancedTabItem TabItem
	{
		[CompilerGenerated]
		get
		{
			return m2O;
		}
		[CompilerGenerated]
		set
		{
			m2O = value;
		}
	}

	public AdvancedTabItemEventArgs()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool S6()
	{
		return U2 == null;
	}

	internal static AdvancedTabItemEventArgs eW()
	{
		return U2;
	}
}
