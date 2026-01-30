using System.Windows.Media;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Extensions;

public static class ColorExtensions
{
	private static ColorExtensions U38;

	public static Color Tint(this Color color, Color tintColor)
	{
		return UIColor.GetTintedColor(color, tintColor);
	}

	public static SolidColorBrush ToSolidColorBrush(this Color color)
	{
		return color.ToSolidColorBrush(freeze: true);
	}

	public static SolidColorBrush ToSolidColorBrush(this Color color, bool freeze)
	{
		SolidColorBrush solidColorBrush = new SolidColorBrush(color);
		if (freeze && solidColorBrush.CanFreeze)
		{
			solidColorBrush.Freeze();
		}
		return solidColorBrush;
	}

	internal static bool U3j()
	{
		return U38 == null;
	}

	internal static ColorExtensions I3e()
	{
		return U38;
	}
}
