using System.Windows;

namespace ActiproSoftware.Windows.Data;

public static class ValidationHelper
{
	private static ValidationHelper FOD;

	private static bool jk1(object P_0, double P_1, double P_2, bool P_3)
	{
		if (P_0 == null)
		{
			return false;
		}
		double result;
		if (P_0 is double)
		{
			result = (double)P_0;
		}
		else if (!double.TryParse(P_0.ToString(), out result))
		{
			return false;
		}
		if (double.IsNaN(result))
		{
			return P_3;
		}
		return result >= P_1 && result <= P_2;
	}

	public static bool ValidateDoubleIsBetweenInclusive(object value, double min, double max)
	{
		return jk1(value, min, max, _0020: false);
	}

	public static bool ValidateDoubleIsGreaterThan(object value, double min)
	{
		if (value == null)
		{
			return false;
		}
		double result;
		if (value is double)
		{
			result = (double)value;
		}
		else if (!double.TryParse(value.ToString(), out result))
		{
			return false;
		}
		if (double.IsNaN(result))
		{
			return false;
		}
		return result > min && result <= double.MaxValue;
	}

	public static bool ValidateDoubleIsGreaterThanOrEqual(object value, double min)
	{
		return jk1(value, min, double.MaxValue, _0020: false);
	}

	public static bool ValidateDoubleIsNumber(object value)
	{
		bool result;
		int num;
		if (value == null)
		{
			result = false;
			num = 1;
			if (IOl() != null)
			{
				goto IL_0005;
			}
		}
		else
		{
			double result2;
			if (value is double)
			{
				result2 = (double)value;
			}
			else if (!double.TryParse(value.ToString(), out result2))
			{
				result = false;
				goto IL_011f;
			}
			if (double.IsNaN(result2) || double.IsPositiveInfinity(result2) || double.IsNegativeInfinity(result2))
			{
				result = false;
				goto IL_011f;
			}
			result = true;
			num = 0;
			if (!hO2())
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_011f:
		return result;
		IL_0009:
		switch (num)
		{
		}
		goto IL_011f;
	}

	public static bool ValidateDoubleIsNumberOrNaN(object value)
	{
		if (value == null)
		{
			return false;
		}
		double result;
		if (value is double)
		{
			result = (double)value;
		}
		else if (!double.TryParse(value.ToString(), out result))
		{
			return false;
		}
		if (double.IsPositiveInfinity(result) || double.IsNegativeInfinity(result))
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDoubleIsPercentage(object value)
	{
		return jk1(value, 0.0, 1.0, _0020: false);
	}

	public static bool ValidateDoubleIsPositive(object value)
	{
		return jk1(value, 0.0, double.MaxValue, _0020: false);
	}

	public static bool ValidateDoubleIsPositiveOrNaN(object value)
	{
		return jk1(value, 0.0, double.MaxValue, _0020: true);
	}

	public static bool ValidateDurationIsPositiveTimeSpan(object value)
	{
		if (!(value is Duration duration))
		{
			return false;
		}
		return duration.HasTimeSpan && duration.TimeSpan.TotalMilliseconds >= 0.0;
	}

	public static bool ValidateInt32IsBetweenInclusive(object value, int min, int max)
	{
		if (value == null)
		{
			return false;
		}
		int result;
		if (!(value is int))
		{
			bool flag = !int.TryParse(value.ToString(), out result);
			int num = 0;
			if (IOl() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (flag)
			{
				return false;
			}
		}
		else
		{
			result = (int)value;
		}
		return result >= min && result <= max;
	}

	public static bool ValidateInt32IsGreaterThanOrEqual(object value, int min)
	{
		return ValidateInt32IsBetweenInclusive(value, min, int.MaxValue);
	}

	public static bool ValidateInt32IsPositive(object value)
	{
		return ValidateInt32IsBetweenInclusive(value, 0, int.MaxValue);
	}

	public static bool ValidateInt64IsBetweenInclusive(object value, long min, long max)
	{
		if (value != null)
		{
			long result;
			if (!(value is long))
			{
				bool flag = !long.TryParse(value.ToString(), out result);
				int num = 0;
				if (IOl() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (flag)
				{
					return false;
				}
			}
			else
			{
				result = (long)value;
			}
			return result >= min && result <= max;
		}
		return false;
	}

	public static bool ValidateInt64IsGreaterThanOrEqual(object value, long min)
	{
		return ValidateInt64IsBetweenInclusive(value, min, long.MaxValue);
	}

	public static bool ValidateInt64IsPositive(object value)
	{
		return ValidateInt64IsBetweenInclusive(value, 0L, long.MaxValue);
	}

	internal static bool hO2()
	{
		return FOD == null;
	}

	internal static ValidationHelper IOl()
	{
		return FOD;
	}
}
