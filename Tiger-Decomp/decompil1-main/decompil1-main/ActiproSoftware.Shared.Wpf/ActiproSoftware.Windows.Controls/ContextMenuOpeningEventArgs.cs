using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class ContextMenuOpeningEventArgs : RoutedEventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ContextMenu Old;

	internal static ContextMenuOpeningEventArgs bqr;

	public ContextMenu Menu
	{
		[CompilerGenerated]
		get
		{
			return Old;
		}
		[CompilerGenerated]
		set
		{
			Old = value;
		}
	}

	public ContextMenuOpeningEventArgs(RoutedEvent routedEvent, object source, ContextMenu menu)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(routedEvent, source);
		Menu = menu;
	}

	internal static bool oqI()
	{
		return bqr == null;
	}

	internal static ContextMenuOpeningEventArgs LqD()
	{
		return bqr;
	}
}
