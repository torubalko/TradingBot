using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using ActiproSoftware.Windows.Controls;

namespace ActiproSoftware.Internal;

internal static class CG
{
	public static Rect XvJ(double P_0, double P_1, IEnumerable<X8> P_2, X8 P_3, Rect P_4)
	{
		if (P_2 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9164));
		}
		if (P_3 == null)
		{
			throw new ArgumentNullException(vVK.ssH(23326));
		}
		P_0 = Math.Max(0.0, P_0);
		P_1 = Math.Max(0.0, P_1);
		double num = P_1;
		double num2 = P_1;
		Rect result = P_4;
		foreach (X8 item in P_2)
		{
			if (item == null || item == P_3)
			{
				continue;
			}
			Rect bounds = item.Bounds;
			if (P_4.Top < bounds.Bottom + P_1 - 1.0 && P_4.Bottom > bounds.Top - P_1)
			{
				if (Math.Abs(P_4.Left - bounds.Left) < num)
				{
					num = Math.Abs(P_4.Left - bounds.Left);
					result.X = bounds.Left;
				}
				if (Math.Abs(P_4.Left - (bounds.Right + P_0)) < num)
				{
					num = Math.Abs(P_4.Left - (bounds.Right + P_0));
					result.X = bounds.Right + P_0;
				}
				if (Math.Abs(P_4.Right - (bounds.Left - P_0)) < num)
				{
					num = Math.Abs(P_4.Right - (bounds.Left - P_0));
					result.X = bounds.Left - result.Width - P_0;
				}
				if (Math.Abs(P_4.Right - bounds.Right) < num)
				{
					num = Math.Abs(P_4.Right - bounds.Right);
					result.X = bounds.Right - result.Width;
				}
			}
			if (P_4.Left < bounds.Right + P_1 - 1.0 && P_4.Right > bounds.Left - P_1)
			{
				if (Math.Abs(P_4.Top - bounds.Top) < num2)
				{
					num2 = Math.Abs(P_4.Top - bounds.Top);
					result.Y = bounds.Top;
				}
				if (Math.Abs(P_4.Top - (bounds.Bottom + P_0)) < num2)
				{
					num2 = Math.Abs(P_4.Top - (bounds.Bottom + P_0));
					result.Y = bounds.Bottom + P_0;
				}
				if (Math.Abs(P_4.Bottom - (bounds.Top - P_0)) < num2)
				{
					num2 = Math.Abs(P_4.Bottom - (bounds.Top - P_0));
					result.Y = bounds.Top - result.Height - P_0;
				}
				if (Math.Abs(P_4.Bottom - bounds.Bottom) < num2)
				{
					num2 = Math.Abs(P_4.Bottom - bounds.Bottom);
					result.Y = bounds.Bottom - result.Height;
				}
			}
		}
		return result;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public static double Yvn(double P_0, double P_1, IEnumerable<X8> P_2, X8 P_3, Rect P_4, double P_5, Side P_6)
	{
		if (P_2 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9164));
		}
		if (P_3 == null)
		{
			throw new ArgumentNullException(vVK.ssH(23326));
		}
		P_0 = Math.Max(0.0, P_0);
		P_1 = Math.Max(0.0, P_1);
		double result = P_5;
		double num = P_1;
		foreach (X8 item in P_2)
		{
			if (item == null || item == P_3)
			{
				continue;
			}
			Rect bounds = item.Bounds;
			switch (P_6)
			{
			case Side.Left:
				if (P_4.Top < bounds.Bottom + P_1 - 1.0 && P_4.Bottom > bounds.Top - P_1)
				{
					if (Math.Abs(P_5 - bounds.Left) < num)
					{
						num = Math.Abs(P_5 - bounds.Left);
						result = bounds.Left;
					}
					if (Math.Abs(P_5 - (bounds.Right + P_0)) < num)
					{
						num = Math.Abs(P_5 - (bounds.Right + P_0));
						result = bounds.Right + P_0;
					}
				}
				break;
			case Side.Top:
				if (P_4.Left < bounds.Right + P_1 - 1.0 && P_4.Right > bounds.Left - P_1)
				{
					if (Math.Abs(P_5 - bounds.Top) < num)
					{
						num = Math.Abs(P_5 - bounds.Top);
						result = bounds.Top;
					}
					if (Math.Abs(P_5 - (bounds.Bottom + P_0)) < num)
					{
						num = Math.Abs(P_5 - (bounds.Bottom + P_0));
						result = bounds.Bottom + P_0;
					}
				}
				break;
			case Side.Right:
				if (P_4.Top < bounds.Bottom + P_1 - 1.0 && P_4.Bottom > bounds.Top - P_1)
				{
					if (Math.Abs(P_5 - (bounds.Left - P_0)) < num)
					{
						num = Math.Abs(P_5 - (bounds.Left - P_0));
						result = bounds.Left - P_0;
					}
					if (Math.Abs(P_5 - bounds.Right) < num)
					{
						num = Math.Abs(P_5 - bounds.Right);
						result = bounds.Right;
					}
				}
				break;
			case Side.Bottom:
				if (P_4.Left < bounds.Right + P_1 - 1.0 && P_4.Right > bounds.Left - P_1)
				{
					if (Math.Abs(P_5 - (bounds.Top - P_0)) < num)
					{
						num = Math.Abs(P_5 - (bounds.Top - P_0));
						result = bounds.Top - P_0;
					}
					if (Math.Abs(P_5 - bounds.Bottom) < num)
					{
						num = Math.Abs(P_5 - bounds.Bottom);
						result = bounds.Bottom;
					}
				}
				break;
			}
		}
		return result;
	}
}
