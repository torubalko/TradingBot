using System;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Extensions;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Windows.Data;

public static class MathHelper
{
	private static MathHelper hO3;

	public static double Max(params double[] values)
	{
		if (values == null || values.Length == 0)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112392));
		}
		double num = values[0];
		for (int i = 1; i < values.Length; i++)
		{
			num = Math.Max(num, values[i]);
		}
		return num;
	}

	public static int Max(params int[] values)
	{
		if (values == null || values.Length == 0)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112392));
		}
		int num = values[0];
		for (int i = 1; i < values.Length; i++)
		{
			num = Math.Max(num, values[i]);
		}
		return num;
	}

	public static double Min(params double[] values)
	{
		if (values == null || values.Length == 0)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112392));
		}
		double num = values[0];
		for (int i = 1; i < values.Length; i++)
		{
			num = Math.Min(num, values[i]);
		}
		return num;
	}

	public static int Min(params int[] values)
	{
		if (values == null || values.Length == 0)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112392));
		}
		int num = values[0];
		int num2 = 1;
		int num4 = default(int);
		while (num2 < values.Length)
		{
			num = Math.Min(num, values[num2]);
			num2++;
			int num3 = 0;
			if (ROO() != null)
			{
				num3 = num4;
			}
			switch (num3)
			{
			}
		}
		return num;
	}

	public static decimal Range(decimal value, decimal minValue, decimal maxValue)
	{
		return value.Range(minValue, maxValue);
	}

	public static double Range(double value, double minValue, double maxValue)
	{
		return value.Range(minValue, maxValue);
	}

	public static int Range(int value, int minValue, int maxValue)
	{
		return value.Range(minValue, maxValue);
	}

	public static double Round(RoundMode mode, double value)
	{
		return value.Round(mode);
	}

	internal static bool VON()
	{
		return hO3 == null;
	}

	internal static MathHelper ROO()
	{
		return hO3;
	}
}
