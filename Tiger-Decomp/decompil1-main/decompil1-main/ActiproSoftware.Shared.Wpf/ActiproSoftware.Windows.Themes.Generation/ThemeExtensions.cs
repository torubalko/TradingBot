using System.Windows;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Themes.Generation;

internal static class ThemeExtensions
{
	private static ThemeExtensions Xfe;

	public static bool IsDarkTheme(this ThemeIntent intent)
	{
		switch (intent)
		{
		default:
			return false;
		case ThemeIntent.Dark:
		case ThemeIntent.Black:
		{
			int num = 0;
			if (!bf6())
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => true, 
			};
		}
		case ThemeIntent.HighContrast:
			return !UIColor.FromColor(SystemColors.WindowColor).IsLight;
		}
	}

	public static ShadeContrastName ToContrastName(this ShadeName shadeName, bool isDarkTheme)
	{
		int num = (int)shadeName;
		if (isDarkTheme)
		{
			num = 1000 - num;
		}
		return (ShadeContrastName)num;
	}

	internal static bool bf6()
	{
		return Xfe == null;
	}

	internal static ThemeExtensions tfw()
	{
		return Xfe;
	}
}
