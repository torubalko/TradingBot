using System.Windows.Media;

namespace ActiproSoftware.Windows.Extensions;

public static class PenExtensions
{
	internal static PenExtensions e3X;

	public static Pen Tint(this Pen pen, Color tintColor)
	{
		return pen.Tint(tintColor, freeze: true);
	}

	public static Pen Tint(this Pen pen, Color tintColor, bool freeze)
	{
		if (pen == null)
		{
			return null;
		}
		Pen pen2 = pen;
		if (!pen2.IsFrozen && tintColor != Colors.Transparent)
		{
			pen2 = pen.CloneCurrentValue();
			pen2.Brush = pen2.Brush.Tint(tintColor);
		}
		else if (!pen.IsFrozen)
		{
			pen2 = pen.CloneCurrentValue();
		}
		if (freeze && pen2.CanFreeze)
		{
			pen2.Freeze();
		}
		return pen2;
	}

	internal static bool n3U()
	{
		return e3X == null;
	}

	internal static PenExtensions l3L()
	{
		return e3X;
	}
}
