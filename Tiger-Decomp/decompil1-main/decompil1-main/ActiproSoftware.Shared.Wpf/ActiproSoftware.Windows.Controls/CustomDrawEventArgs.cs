using System.Windows;
using System.Windows.Media;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class CustomDrawEventArgs<T> : RoutedEventArgs
{
	private DrawingContext HlN;

	private T wlM;

	private static object dqW;

	public DrawingContext DrawingContext => HlN;

	public T Element => wlM;

	public CustomDrawEventArgs(RoutedEvent routedEvent, T element, DrawingContext drawingContext)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(routedEvent);
		wlM = element;
		HlN = drawingContext;
	}

	internal static bool Iqz()
	{
		return dqW == null;
	}

	internal static object dGK()
	{
		return dqW;
	}
}
