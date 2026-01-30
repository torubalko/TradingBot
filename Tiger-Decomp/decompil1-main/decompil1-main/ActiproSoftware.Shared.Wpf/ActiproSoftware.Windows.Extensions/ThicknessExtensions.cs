using System.Windows;
using ActiproSoftware.Windows.Controls;

namespace ActiproSoftware.Windows.Extensions;

public static class ThicknessExtensions
{
	private static ThicknessExtensions p3W;

	public static bool IsEffectivelyEqual(this Thickness left, Thickness right)
	{
		if (left == right)
		{
			return true;
		}
		return left.Bottom.IsEffectivelyEqual(right.Bottom) && left.Left.IsEffectivelyEqual(right.Left) && left.Right.IsEffectivelyEqual(right.Right) && left.Top.IsEffectivelyEqual(right.Top);
	}

	public static bool IsEffectivelyUniform(this Thickness value)
	{
		return value.Bottom.IsEffectivelyEqual(value.Left) && value.Bottom.IsEffectivelyEqual(value.Right) && value.Bottom.IsEffectivelyEqual(value.Top);
	}

	public static bool IsEffectivelyZero(this Thickness value)
	{
		return value.Bottom.IsEffectivelyEqual(0.0) && value.Left.IsEffectivelyEqual(0.0) && value.Right.IsEffectivelyEqual(0.0) && value.Top.IsEffectivelyEqual(0.0);
	}

	public static Thickness Round(this Thickness value, RoundMode mode)
	{
		if (mode == RoundMode.None)
		{
			return value;
		}
		return new Thickness
		{
			Bottom = value.Bottom.Round(mode),
			Left = value.Left.Round(mode),
			Right = value.Right.Round(mode),
			Top = value.Top.Round(mode)
		};
	}

	public static Thickness SetSides(this Thickness value, Sides sides, Thickness thickness)
	{
		if (sides == Sides.All)
		{
			return thickness;
		}
		return new Thickness
		{
			Bottom = (((sides & Sides.Bottom) != Sides.None) ? thickness.Bottom : value.Bottom),
			Left = (((sides & Sides.Left) != Sides.None) ? thickness.Left : value.Left),
			Right = (((sides & Sides.Right) != Sides.None) ? thickness.Right : value.Right),
			Top = (((sides & Sides.Top) != Sides.None) ? thickness.Top : value.Top)
		};
	}

	public static Thickness SetSides(this Thickness value, Sides sides, double thickness)
	{
		if (sides == Sides.All)
		{
			return new Thickness(thickness);
		}
		return new Thickness
		{
			Bottom = (((sides & Sides.Bottom) != Sides.None) ? thickness : value.Bottom),
			Left = (((sides & Sides.Left) != Sides.None) ? thickness : value.Left),
			Right = (((sides & Sides.Right) != Sides.None) ? thickness : value.Right),
			Top = (((sides & Sides.Top) != Sides.None) ? thickness : value.Top)
		};
	}

	internal static bool W3z()
	{
		return p3W == null;
	}

	internal static ThicknessExtensions wNK()
	{
		return p3W;
	}
}
