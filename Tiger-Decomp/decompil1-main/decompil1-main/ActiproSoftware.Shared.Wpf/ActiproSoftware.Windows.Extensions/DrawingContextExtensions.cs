using System;
using System.Windows;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Windows.Extensions;

public static class DrawingContextExtensions
{
	internal static DrawingContextExtensions i35;

	public static void DrawRoundedRectangle(this DrawingContext drawingContext, Brush brush, Pen pen, Rect rectangle, CornerRadius cornerRadius)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		if (cornerRadius.IsEffectivelyZero())
		{
			drawingContext.DrawRectangle(brush, pen, rectangle);
			int num = 0;
			if (b3Z() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
			return;
		}
		StreamGeometry streamGeometry = new StreamGeometry();
		using (StreamGeometryContext streamGeometryContext = streamGeometry.Open())
		{
			bool isFilled = brush != null;
			bool isStroked = pen != null;
			streamGeometryContext.BeginFigure(rectangle.TopLeft + new Vector(0.0, cornerRadius.TopLeft), isFilled, isClosed: true);
			streamGeometryContext.ArcTo(new Point(rectangle.TopLeft.X + cornerRadius.TopLeft, rectangle.TopLeft.Y), new Size(cornerRadius.TopLeft, cornerRadius.TopLeft), 90.0, isLargeArc: false, SweepDirection.Clockwise, isStroked, isSmoothJoin: true);
			streamGeometryContext.LineTo(rectangle.TopRight - new Vector(cornerRadius.TopRight, 0.0), isStroked, isSmoothJoin: true);
			streamGeometryContext.ArcTo(new Point(rectangle.TopRight.X, rectangle.TopRight.Y + cornerRadius.TopRight), new Size(cornerRadius.TopRight, cornerRadius.TopRight), 90.0, isLargeArc: false, SweepDirection.Clockwise, isStroked, isSmoothJoin: true);
			streamGeometryContext.LineTo(rectangle.BottomRight - new Vector(0.0, cornerRadius.BottomRight), isStroked, isSmoothJoin: true);
			streamGeometryContext.ArcTo(new Point(rectangle.BottomRight.X - cornerRadius.BottomRight, rectangle.BottomRight.Y), new Size(cornerRadius.BottomRight, cornerRadius.BottomRight), 90.0, isLargeArc: false, SweepDirection.Clockwise, isStroked, isSmoothJoin: true);
			streamGeometryContext.LineTo(rectangle.BottomLeft + new Vector(cornerRadius.BottomLeft, 0.0), isStroked, isSmoothJoin: true);
			streamGeometryContext.ArcTo(new Point(rectangle.BottomLeft.X, rectangle.BottomLeft.Y - cornerRadius.BottomLeft), new Size(cornerRadius.BottomLeft, cornerRadius.BottomLeft), 90.0, isLargeArc: false, SweepDirection.Clockwise, isStroked, isSmoothJoin: true);
			streamGeometryContext.Close();
			int num3 = 0;
			if (b3Z() != null)
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			case 0:
				break;
			}
		}
		drawingContext.DrawGeometry(brush, pen, streamGeometry);
	}

	internal static bool M3m()
	{
		return i35 == null;
	}

	internal static DrawingContextExtensions b3Z()
	{
		return i35;
	}
}
