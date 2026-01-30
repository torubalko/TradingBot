using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public class PropertyChangingRoutedEventArgs<T> : RoutedEventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool wH;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private T N6;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private T JV;

	internal static object EMq;

	public bool Cancel
	{
		[CompilerGenerated]
		get
		{
			return wH;
		}
		[CompilerGenerated]
		set
		{
			wH = value;
		}
	}

	public T NewValue
	{
		[CompilerGenerated]
		get
		{
			return N6;
		}
		[CompilerGenerated]
		set
		{
			N6 = value;
		}
	}

	public T OldValue
	{
		[CompilerGenerated]
		get
		{
			return JV;
		}
		[CompilerGenerated]
		private set
		{
			JV = value;
		}
	}

	public PropertyChangingRoutedEventArgs(T oldValue, T newValue)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector((RoutedEvent)null, oldValue, newValue, (object)null);
	}

	public PropertyChangingRoutedEventArgs(RoutedEvent routedEvent, T oldValue, T newValue)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(routedEvent, oldValue, newValue, (object)null);
	}

	public PropertyChangingRoutedEventArgs(RoutedEvent routedEvent, T oldValue, T newValue, object source)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(routedEvent, source);
		OldValue = oldValue;
		NewValue = newValue;
	}

	internal static bool OMG()
	{
		return EMq == null;
	}

	internal static object VMn()
	{
		return EMq;
	}
}
