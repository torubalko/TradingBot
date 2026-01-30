using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public class WindowBoundsChangeEventArgs : RoutedEventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool ru7;

	internal static WindowBoundsChangeEventArgs OYr;

	public bool IsMove
	{
		[CompilerGenerated]
		get
		{
			return ru7;
		}
		[CompilerGenerated]
		set
		{
			ru7 = value;
		}
	}

	public WindowBoundsChangeEventArgs(bool isMove, RoutedEvent routedEvent, object source)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(routedEvent, source);
		IsMove = isMove;
	}

	internal static bool aYI()
	{
		return OYr == null;
	}

	internal static WindowBoundsChangeEventArgs RYD()
	{
		return OYr;
	}
}
