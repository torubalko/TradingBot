using System;
using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public class DateTimePropertyChangedRoutedEventArgs : PropertyChangedRoutedEventArgs<DateTime>
{
	internal static DateTimePropertyChangedRoutedEventArgs Gj;

	public DateTimePropertyChangedRoutedEventArgs(DateTime oldValue, DateTime newValue)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(oldValue, newValue);
	}

	public DateTimePropertyChangedRoutedEventArgs(RoutedEvent routedEvent, DateTime oldValue, DateTime newValue)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(routedEvent, oldValue, newValue);
	}

	internal static bool Ye()
	{
		return Gj == null;
	}

	internal static DateTimePropertyChangedRoutedEventArgs I6()
	{
		return Gj;
	}
}
