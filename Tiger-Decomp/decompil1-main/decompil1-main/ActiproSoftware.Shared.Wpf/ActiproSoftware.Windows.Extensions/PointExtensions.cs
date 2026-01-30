using System;
using System.Windows;

namespace ActiproSoftware.Windows.Extensions;

public static class PointExtensions
{
	internal static PointExtensions v34;

	public static double GetDegreeAngle(this Point centerPosition, Point position)
	{
		return Math.Atan2(position.X - centerPosition.X, centerPosition.Y - position.Y).ConvertRadiansToDegrees();
	}

	public static Point GetRadiusPointAtRotation(this Point centerPosition, double angle, double radius)
	{
		return new Point(centerPosition.X + Math.Sin(angle.ConvertDegreesToRadians()) * radius, centerPosition.Y - Math.Cos(angle.ConvertDegreesToRadians()) * radius);
	}

	public static bool IsEffectivelyEqual(this Point left, Point right)
	{
		if (left == right)
		{
			return true;
		}
		return left.X.IsEffectivelyEqual(right.X) && left.Y.IsEffectivelyEqual(right.Y);
	}

	public static bool IsWithin(this Point left, Point right, double difference)
	{
		if (!(left == right))
		{
			return left.X.IsWithin(right.X, difference) && left.Y.IsWithin(right.Y, difference);
		}
		return true;
	}

	public static Point Midpoint(this Point point, Point otherPoint)
	{
		if (point == otherPoint)
		{
			return point;
		}
		return new Point(Math.Min(point.X, otherPoint.X) + Math.Abs(point.X - otherPoint.X) / 2.0, Math.Min(point.Y, otherPoint.Y) + Math.Abs(point.Y - otherPoint.Y) / 2.0);
	}

	internal static bool g3s()
	{
		return v34 == null;
	}

	internal static PointExtensions C3i()
	{
		return v34;
	}
}
