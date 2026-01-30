using System;
using ActiproSoftware.Windows.Controls;

namespace ActiproSoftware.Windows.Extensions;

public static class DecimalExtensions
{
	private static DecimalExtensions K3C;

	public static bool IsWithin(this decimal left, decimal right, decimal difference)
	{
		if (left == right)
		{
			return true;
		}
		return Math.Abs(left - right) < Math.Abs(difference);
	}

	public static decimal Range(this decimal value, decimal minValue, decimal maxValue)
	{
		return Math.Min(maxValue, Math.Max(minValue, value));
	}

	public static decimal Round(this decimal value, RoundMode mode)
	{
		switch (mode)
		{
		case RoundMode.Ceiling:
		case RoundMode.CeilingToEven:
		case RoundMode.CeilingToOdd:
			value = Math.Ceiling(value);
			if (mode == RoundMode.CeilingToEven && value % 2m == 1m)
			{
				++value;
			}
			if (mode == RoundMode.CeilingToOdd && value % 2m == 0m)
			{
				++value;
			}
			break;
		case RoundMode.Floor:
		case RoundMode.FloorToEven:
		case RoundMode.FloorToOdd:
			value = Math.Floor(value);
			if (mode == RoundMode.FloorToEven && value % 2m == 1m)
			{
				--value;
			}
			if (mode == RoundMode.FloorToOdd && value % 2m == 0m)
			{
				--value;
			}
			break;
		case RoundMode.Round:
			value = Math.Round(value);
			break;
		case RoundMode.RoundToEven:
		{
			decimal num2 = Math.Round(value);
			if (Math.Abs(num2) % 2m == 0m)
			{
				value = num2;
			}
			else if (value == num2)
			{
				value += (decimal)((value >= 0m) ? 1 : (-1));
			}
			else
			{
				value = num2 + (decimal)((num2 < value) ? 1 : (-1));
			}
			break;
		}
		case RoundMode.RoundToOdd:
		{
			decimal num = Math.Round(value);
			if (Math.Abs(num) % 2m == 1m)
			{
				value = num;
			}
			else if (value == num)
			{
				value += (decimal)((value >= 0m) ? 1 : (-1));
			}
			else
			{
				value = num + (decimal)((num < value) ? 1 : (-1));
			}
			break;
		}
		}
		return value;
	}

	internal static bool E3R()
	{
		return K3C == null;
	}

	internal static DecimalExtensions U39()
	{
		return K3C;
	}
}
