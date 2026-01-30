using System.Windows;

namespace ActiproSoftware.Windows.Extensions;

public static class SizeExtensions
{
	internal static SizeExtensions Y3p;

	public static bool IsEffectivelyEqual(this Size left, Size right)
	{
		if (left == right)
		{
			return true;
		}
		return left.Width.IsEffectivelyEqual(right.Width) && left.Height.IsEffectivelyEqual(right.Height);
	}

	public static bool IsWithin(this Size left, Size right, double difference)
	{
		if (left == right)
		{
			return true;
		}
		return left.Width.IsWithin(right.Width, difference) && left.Height.IsWithin(right.Height, difference);
	}

	internal static bool T3h()
	{
		return Y3p == null;
	}

	internal static SizeExtensions k3P()
	{
		return Y3p;
	}
}
