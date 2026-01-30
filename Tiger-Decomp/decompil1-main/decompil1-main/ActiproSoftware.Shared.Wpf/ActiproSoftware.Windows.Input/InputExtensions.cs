using System.Windows;
using System.Windows.Input;

namespace ActiproSoftware.Windows.Input;

internal static class InputExtensions
{
	internal static InputExtensions EJg;

	public static int GetClickCount(this InputEventArgs e)
	{
		if (!(e is MouseButtonEventArgs { ClickCount: var clickCount }))
		{
			return 1;
		}
		return clickCount;
	}

	public static Point GetPosition(this InputEventArgs e, UIElement relativeTo)
	{
		if (e is MouseEventArgs e2)
		{
			return e2.GetPosition(relativeTo);
		}
		if (e is TouchEventArgs e3)
		{
			Rect bounds = e3.GetTouchPoint(relativeTo).Bounds;
			return new Point(bounds.Left + bounds.Width / 2.0, bounds.Top + bounds.Height / 2.0);
		}
		return default(Point);
	}

	internal static bool MJ8()
	{
		return EJg == null;
	}

	internal static InputExtensions sJj()
	{
		return EJg;
	}
}
