using System;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Windows.Controls;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Windows.Extensions;

public static class OrientedElementExtensions
{
	internal static OrientedElementExtensions w3A;

	public static Size CreateSize(this IOrientedElement element, double extent, double ascent)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		return (element.Orientation == Orientation.Horizontal) ? new Size(extent, ascent) : new Size(ascent, extent);
	}

	public static double GetLocationAscent(this IOrientedElement element, Point location)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		return (element.Orientation == Orientation.Horizontal) ? location.Y : location.X;
	}

	public static double GetLocationAscent(this IOrientedElement element, Rect bounds)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		return (element.Orientation == Orientation.Horizontal) ? bounds.Y : bounds.X;
	}

	public static double GetLocationExtent(this IOrientedElement element, Point location)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		return (element.Orientation == Orientation.Horizontal) ? location.X : location.Y;
	}

	public static double GetLocationExtent(this IOrientedElement element, Rect bounds)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		return (element.Orientation == Orientation.Horizontal) ? bounds.X : bounds.Y;
	}

	public static double GetSizeAscent(this IOrientedElement element, Rect bounds)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		return (element.Orientation == Orientation.Horizontal) ? bounds.Height : bounds.Width;
	}

	public static double GetSizeAscent(this IOrientedElement element, Size size)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		return (element.Orientation == Orientation.Horizontal) ? size.Height : size.Width;
	}

	public static double GetSizeExtent(this IOrientedElement element, Rect bounds)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		return (element.Orientation == Orientation.Horizontal) ? bounds.Width : bounds.Height;
	}

	public static double GetSizeExtent(this IOrientedElement element, Size size)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		return (element.Orientation == Orientation.Horizontal) ? size.Width : size.Height;
	}

	internal static bool B3V()
	{
		return w3A == null;
	}

	internal static OrientedElementExtensions s3T()
	{
		return w3A;
	}
}
