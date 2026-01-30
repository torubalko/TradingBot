using System.Windows.Media;

namespace ActiproSoftware.Windows.Extensions;

public static class BrushExtensions
{
	private static BrushExtensions F3b;

	public static Brush Tint(this Brush brush, Color tintColor)
	{
		return brush.Tint(tintColor, freeze: true);
	}

	public static Brush Tint(this Brush brush, Color tintColor, bool freeze)
	{
		if (brush == null)
		{
			return null;
		}
		Brush brush2 = brush;
		if (tintColor != Colors.Transparent)
		{
			brush2 = brush.CloneCurrentValue();
			if (!brush2.IsFrozen)
			{
				if (brush2 is SolidColorBrush solidColorBrush)
				{
					solidColorBrush.Color = solidColorBrush.Color.Tint(tintColor);
				}
				else if (brush2 is GradientBrush gradientBrush)
				{
					foreach (GradientStop gradientStop in gradientBrush.GradientStops)
					{
						gradientStop.Color = gradientStop.Color.Tint(tintColor);
					}
				}
			}
		}
		else if (!brush.IsFrozen)
		{
			brush2 = brush.CloneCurrentValue();
		}
		if (freeze && brush2.CanFreeze)
		{
			brush2.Freeze();
		}
		return brush2;
	}

	internal static bool o31()
	{
		return F3b == null;
	}

	internal static BrushExtensions n3g()
	{
		return F3b;
	}
}
