using System;

namespace ActiproSoftware.Windows.Extensions;

public static class Int32Extensions
{
	private static Int32Extensions K32;

	public static bool IsWithin(this int left, int right, int difference)
	{
		if (left == right)
		{
			return true;
		}
		return Math.Abs(left - right) < Math.Abs(difference);
	}

	public static int Range(this int value, int minValue, int maxValue)
	{
		return Math.Min(maxValue, Math.Max(minValue, value));
	}

	internal static bool z3l()
	{
		return K32 == null;
	}

	internal static Int32Extensions X3E()
	{
		return K32;
	}
}
