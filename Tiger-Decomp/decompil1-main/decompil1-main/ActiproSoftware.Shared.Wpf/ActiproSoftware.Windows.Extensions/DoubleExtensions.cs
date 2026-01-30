using System;
using ActiproSoftware.Windows.Controls;

namespace ActiproSoftware.Windows.Extensions;

public static class DoubleExtensions
{
	private static DoubleExtensions a3c;

	public static double ConvertDegreesToRadians(this double angle)
	{
		return angle * (Math.PI / 180.0);
	}

	public static double ConvertRadiansToDegrees(this double angle)
	{
		return angle * (180.0 / Math.PI);
	}

	public static double GetNormalizedDegreeAngle(this double angle)
	{
		if (double.IsNaN(angle) || double.IsInfinity(angle))
		{
			angle = 0.0;
		}
		angle %= 360.0;
		if (angle < 0.0)
		{
			angle += 360.0;
		}
		return angle;
	}

	public static bool IsEffectivelyEqual(this double left, double right)
	{
		if (left == right)
		{
			return true;
		}
		double num = (Math.Abs(left) + Math.Abs(right) + 10.0) * 2.220446049250313E-16;
		double num2 = left - right;
		return 0.0 - num < num2 && num > num2;
	}

	public static bool IsEffectivelyGreaterThan(this double left, double right)
	{
		return left > right && !left.IsEffectivelyEqual(right);
	}

	public static bool IsEffectivelyGreaterThanOrEqual(this double left, double right)
	{
		return left > right || left.IsEffectivelyEqual(right);
	}

	public static bool IsEffectivelyLessThan(this double left, double right)
	{
		return left < right && !left.IsEffectivelyEqual(right);
	}

	public static bool IsEffectivelyLessThanOrEqual(this double left, double right)
	{
		return left < right || left.IsEffectivelyEqual(right);
	}

	public static bool IsEffectivelyZero(this double value)
	{
		return value.IsEffectivelyEqual(0.0);
	}

	public static bool IsWithin(this double left, double right, double difference)
	{
		if (left != right)
		{
			return Math.Abs(left - right) < Math.Abs(difference);
		}
		return true;
	}

	public static double Range(this double value, double minValue, double maxValue)
	{
		return Math.Min(maxValue, Math.Max(minValue, value));
	}

	public static double Round(this double value, RoundMode mode)
	{
		switch (mode)
		{
		case RoundMode.Ceiling:
		case RoundMode.CeilingToEven:
		case RoundMode.CeilingToOdd:
			value = Math.Ceiling(value);
			if (mode == RoundMode.CeilingToEven && value % 2.0 == 1.0)
			{
				value += 1.0;
			}
			if (mode == RoundMode.CeilingToOdd && value % 2.0 == 0.0)
			{
				value += 1.0;
			}
			break;
		case RoundMode.Floor:
		case RoundMode.FloorToEven:
		case RoundMode.FloorToOdd:
			value = Math.Floor(value);
			if (mode == RoundMode.FloorToEven && value % 2.0 == 1.0)
			{
				value -= 1.0;
			}
			if (mode == RoundMode.FloorToOdd && value % 2.0 == 0.0)
			{
				value -= 1.0;
			}
			break;
		case RoundMode.Round:
			value = Math.Round(value);
			break;
		case RoundMode.RoundToEven:
		{
			double num2 = Math.Round(value);
			value = ((Math.Abs(num2) % 2.0 != 0.0) ? ((value != num2) ? (num2 + (double)((num2 < value) ? 1 : (-1))) : (value + (double)((value >= 0.0) ? 1 : (-1)))) : num2);
			break;
		}
		case RoundMode.RoundToOdd:
		{
			double num = Math.Round(value);
			value = ((Math.Abs(num) % 2.0 != 1.0) ? ((value != num) ? (num + (double)((num < value) ? 1 : (-1))) : (value + (double)((value >= 0.0) ? 1 : (-1)))) : num);
			break;
		}
		}
		return value;
	}

	internal static bool K3u()
	{
		return a3c == null;
	}

	internal static DoubleExtensions S3o()
	{
		return a3c;
	}
}
