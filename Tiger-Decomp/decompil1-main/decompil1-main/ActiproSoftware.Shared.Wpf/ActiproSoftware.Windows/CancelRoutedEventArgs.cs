using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public class CancelRoutedEventArgs : RoutedEventArgs
{
	private bool Tj;

	internal static CancelRoutedEventArgs sJ;

	public bool Cancel
	{
		get
		{
			return Tj;
		}
		set
		{
			Tj = value;
		}
	}

	public CancelRoutedEventArgs()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(cancel: false, null, null);
	}

	public CancelRoutedEventArgs(RoutedEvent routedEvent)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(cancel: false, routedEvent, null);
	}

	public CancelRoutedEventArgs(RoutedEvent routedEvent, object source)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(cancel: false, routedEvent, source);
	}

	public CancelRoutedEventArgs(bool cancel)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(cancel, null, null);
	}

	public CancelRoutedEventArgs(bool cancel, RoutedEvent routedEvent)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(cancel, routedEvent, null);
	}

	public CancelRoutedEventArgs(bool cancel, RoutedEvent routedEvent, object source)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(routedEvent, source);
		Tj = cancel;
	}

	internal static bool K3()
	{
		return sJ == null;
	}

	internal static CancelRoutedEventArgs LN()
	{
		return sJ;
	}
}
