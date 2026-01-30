using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public class ItemRoutedEventArgs<T> : RoutedEventArgs
{
	private T AZ;

	public T Item
	{
		get
		{
			return AZ;
		}
		set
		{
			AZ = value;
		}
	}

	public ItemRoutedEventArgs(T item)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(item, (RoutedEvent)null, (object)null);
	}

	public ItemRoutedEventArgs(T item, RoutedEvent routedEvent)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(item, routedEvent, (object)null);
	}

	public ItemRoutedEventArgs(T item, RoutedEvent routedEvent, object source)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(routedEvent, source);
		AZ = item;
	}
}
