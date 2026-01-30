using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public class ObjectPropertyChangedRoutedEventArgs : PropertyChangedRoutedEventArgs<object>
{
	internal static ObjectPropertyChangedRoutedEventArgs eMY;

	public ObjectPropertyChangedRoutedEventArgs(object oldValue, object newValue)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(oldValue, newValue);
	}

	public ObjectPropertyChangedRoutedEventArgs(RoutedEvent routedEvent, object oldValue, object newValue)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(routedEvent, oldValue, newValue);
	}

	public ObjectPropertyChangedRoutedEventArgs(RoutedEvent routedEvent, object oldValue, object newValue, object source)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(routedEvent, oldValue, newValue, source);
	}

	internal static bool EMt()
	{
		return eMY == null;
	}

	internal static ObjectPropertyChangedRoutedEventArgs VMf()
	{
		return eMY;
	}
}
