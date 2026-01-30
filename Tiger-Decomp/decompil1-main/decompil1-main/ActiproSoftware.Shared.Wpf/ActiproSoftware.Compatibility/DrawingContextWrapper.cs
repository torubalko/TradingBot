using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Compatibility;

public class DrawingContextWrapper
{
	private DrawingContext RqZ;

	internal static DrawingContextWrapper PgX;

	public DrawingContextWrapper(DrawingContext drawingContext)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		RqZ = null;
		base._002Ector();
		if (drawingContext != null)
		{
			RqZ = drawingContext;
			return;
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
	}

	public void DrawEllipse(Brush brush, Pen pen, Point center, double radiusX, double radiusY)
	{
		RqZ.DrawEllipse(brush, pen, center, radiusX, radiusY);
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "key")]
	public void DrawEllipse(object key, Brush brush, Pen pen, Point center, double radiusX, double radiusY)
	{
		RqZ.DrawEllipse(brush, pen, center, radiusX, radiusY);
	}

	public void DrawGeometry(Brush brush, Pen pen, Geometry geometry)
	{
		RqZ.DrawGeometry(brush, pen, geometry);
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "key")]
	public void DrawGeometry(object key, Brush brush, Pen pen, Geometry geometry)
	{
		RqZ.DrawGeometry(brush, pen, geometry);
	}

	public void DrawImage(ImageSource imageSource, Rect rectangle)
	{
		RqZ.DrawImage(imageSource, rectangle);
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "key")]
	public void DrawImage(object key, ImageSource imageSource, Rect rectangle)
	{
		RqZ.DrawImage(imageSource, rectangle);
	}

	public void DrawLine(Pen pen, Point point0, Point point1)
	{
		RqZ.DrawLine(pen, point0, point1);
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "key")]
	public void DrawLine(object key, Pen pen, Point point0, Point point1)
	{
		RqZ.DrawLine(pen, point0, point1);
	}

	public void DrawRectangle(Brush brush, Pen pen, Rect rectangle)
	{
		RqZ.DrawRectangle(brush, pen, rectangle);
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "key")]
	public void DrawRectangle(object key, Brush brush, Pen pen, Rect rectangle)
	{
		RqZ.DrawRectangle(brush, pen, rectangle);
	}

	public void DrawRoundedRectangle(Brush brush, Pen pen, Rect rectangle, double radiusX, double radiusY)
	{
		RqZ.DrawRoundedRectangle(brush, pen, rectangle, radiusX, radiusY);
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "key")]
	public void DrawRoundedRectangle(object key, Brush brush, Pen pen, Rect rectangle, double radiusX, double radiusY)
	{
		RqZ.DrawRoundedRectangle(brush, pen, rectangle, radiusX, radiusY);
	}

	public void DrawText(FormattedText formattedText, Point origin)
	{
		RqZ.DrawText(formattedText, origin);
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "key")]
	public void DrawText(object key, FormattedText formattedText, Point origin)
	{
		RqZ.DrawText(formattedText, origin);
	}

	public void Pop()
	{
		RqZ.Pop();
	}

	public void PushClip(Geometry clipGeometry)
	{
		RqZ.PushClip(clipGeometry);
	}

	public void PushOpacity(double opacity)
	{
		RqZ.PushOpacity(opacity);
	}

	public void PushOpacityMask(Brush opacityMask)
	{
		RqZ.PushOpacityMask(opacityMask);
	}

	public void PushTransform(Transform transform)
	{
		RqZ.PushTransform(transform);
	}

	internal static bool sgU()
	{
		return PgX == null;
	}

	internal static DrawingContextWrapper mgL()
	{
		return PgX;
	}
}
