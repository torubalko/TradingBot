using System;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class AdvancedTabControlMenuEventArgs : EventArgs
{
	[CompilerGenerated]
	private ContextMenu TwB;

	[CompilerGenerated]
	private AdvancedTabItem OwK;

	private static AdvancedTabControlMenuEventArgs m9;

	public ContextMenu Menu
	{
		[CompilerGenerated]
		get
		{
			return TwB;
		}
		[CompilerGenerated]
		set
		{
			TwB = value;
		}
	}

	public AdvancedTabItem TabItem
	{
		[CompilerGenerated]
		get
		{
			return OwK;
		}
		[CompilerGenerated]
		internal set
		{
			OwK = value;
		}
	}

	public AdvancedTabControlMenuEventArgs()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool Ym()
	{
		return m9 == null;
	}

	internal static AdvancedTabControlMenuEventArgs lo()
	{
		return m9;
	}
}
