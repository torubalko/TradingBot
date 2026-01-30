using System.Windows;
using ActiproSoftware.Windows.Controls;

namespace ActiproSoftware.Windows.Extensions;

public static class CornerRadiusExtensions
{
	internal static CornerRadiusExtensions z36;

	public static bool IsEffectivelyEqual(this CornerRadius left, CornerRadius right)
	{
		if (left == right)
		{
			return true;
		}
		return left.BottomLeft.IsEffectivelyEqual(right.BottomLeft) && left.BottomRight.IsEffectivelyEqual(right.BottomRight) && left.TopLeft.IsEffectivelyEqual(right.TopLeft) && left.TopRight.IsEffectivelyEqual(right.TopRight);
	}

	public static bool IsEffectivelyUniform(this CornerRadius value)
	{
		return value.BottomLeft.IsEffectivelyEqual(value.BottomRight) && value.BottomLeft.IsEffectivelyEqual(value.TopLeft) && value.BottomLeft.IsEffectivelyEqual(value.TopRight);
	}

	public static bool IsEffectivelyZero(this CornerRadius value)
	{
		return value.BottomLeft.IsEffectivelyEqual(0.0) && value.BottomRight.IsEffectivelyEqual(0.0) && value.TopLeft.IsEffectivelyEqual(0.0) && value.TopRight.IsEffectivelyEqual(0.0);
	}

	public static CornerRadius Round(this CornerRadius value, RoundMode mode)
	{
		if (mode != RoundMode.None)
		{
			return new CornerRadius
			{
				BottomLeft = value.BottomLeft.Round(mode),
				BottomRight = value.BottomRight.Round(mode),
				TopLeft = value.TopLeft.Round(mode),
				TopRight = value.TopRight.Round(mode)
			};
		}
		return value;
	}

	public static CornerRadius SetCorners(this CornerRadius value, Corners corners, CornerRadius radius)
	{
		if (corners == Corners.All)
		{
			return radius;
		}
		return new CornerRadius
		{
			BottomLeft = (((corners & Corners.BottomLeft) != Corners.None) ? radius.BottomLeft : value.BottomLeft),
			BottomRight = (((corners & Corners.BottomRight) != Corners.None) ? radius.BottomRight : value.BottomRight),
			TopLeft = (((corners & Corners.TopLeft) != Corners.None) ? radius.TopLeft : value.TopLeft),
			TopRight = (((corners & Corners.TopRight) != Corners.None) ? radius.TopRight : value.TopRight)
		};
	}

	public static CornerRadius SetCorners(this CornerRadius value, Corners corners, double radius)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				flag = corners == Corners.All;
				num2 = 0;
				if (x3w())
				{
					num2 = 0;
				}
				continue;
			}
			if (!flag)
			{
				return new CornerRadius
				{
					BottomLeft = (((corners & Corners.BottomLeft) != Corners.None) ? radius : value.BottomLeft),
					BottomRight = (((corners & Corners.BottomRight) != Corners.None) ? radius : value.BottomRight),
					TopLeft = (((corners & Corners.TopLeft) != Corners.None) ? radius : value.TopLeft),
					TopRight = (((corners & Corners.TopRight) != Corners.None) ? radius : value.TopRight)
				};
			}
			return new CornerRadius(radius);
		}
	}

	internal static bool x3w()
	{
		return z36 == null;
	}

	internal static CornerRadiusExtensions K3k()
	{
		return z36;
	}
}
