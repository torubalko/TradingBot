using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public class PropertyChangedRoutedEventArgs<T> : RoutedEventArgs
{
	private T Pq;

	private T sW;

	public T NewValue => Pq;

	public T OldValue => sW;

	public PropertyChangedRoutedEventArgs(T oldValue, T newValue)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector((RoutedEvent)null, oldValue, newValue);
	}

	public PropertyChangedRoutedEventArgs(RoutedEvent routedEvent, T oldValue, T newValue)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(routedEvent, oldValue, newValue, (object)null);
	}

	public PropertyChangedRoutedEventArgs(RoutedEvent routedEvent, T oldValue, T newValue, object source)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(routedEvent, source);
		sW = oldValue;
		Pq = newValue;
	}
}
