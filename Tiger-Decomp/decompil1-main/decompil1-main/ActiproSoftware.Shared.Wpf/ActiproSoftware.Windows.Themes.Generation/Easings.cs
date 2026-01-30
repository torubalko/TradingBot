using System;

namespace ActiproSoftware.Windows.Themes.Generation;

internal static class Easings
{
	internal static Easings Wty;

	public static double SineIn(double p)
	{
		return Math.Sin((p - 1.0) * Math.PI / 2.0) + 1.0;
	}

	public static double SineInOut(double p)
	{
		return 0.5 * (1.0 - Math.Cos(p * Math.PI));
	}

	public static double SineOut(double p)
	{
		return Math.Sin(p * Math.PI / 2.0);
	}

	internal static bool gtQ()
	{
		return Wty == null;
	}

	internal static Easings jtC()
	{
		return Wty;
	}
}
