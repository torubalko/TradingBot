using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

public class CanvasDrawContext : DisposableObjectBase
{
	private Stack<Rect> bY2;

	private Stack<Rect> LYe;

	private double uY7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Rect bYF;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ICanvas WYo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Rect PYQ;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrawingContext WYO;

	internal static CanvasDrawContext Tnk;

	public Rect Bounds
	{
		[CompilerGenerated]
		get
		{
			return bYF;
		}
		[CompilerGenerated]
		private set
		{
			bYF = value;
		}
	}

	public ICanvas Canvas
	{
		[CompilerGenerated]
		get
		{
			return WYo;
		}
		[CompilerGenerated]
		private set
		{
			WYo = value;
		}
	}

	public Rect ClipBounds
	{
		[CompilerGenerated]
		get
		{
			return PYQ;
		}
		[CompilerGenerated]
		private set
		{
			PYQ = value;
		}
	}

	public DrawingContext PlatformRenderer
	{
		[CompilerGenerated]
		get
		{
			return WYO;
		}
		[CompilerGenerated]
		private set
		{
			WYO = value;
		}
	}

	public double Scale => uY7;

	public CanvasDrawContext(ICanvas canvas, DrawingContext platformRenderer, Rect bounds)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		uY7 = 1.0;
		base._002Ector();
		if (canvas == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116880));
		}
		bool flag = platformRenderer == null;
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116966));
		}
		Canvas = canvas;
		PlatformRenderer = platformRenderer;
		Bounds = bounds;
		ClipBounds = bounds;
	}

	private Pen qYh(Color P_0, LineKind P_1, float P_2)
	{
		if (P_1 == LineKind.None)
		{
			P_0 = Colors.Transparent;
		}
		SolidColorBrush solidColorBrush = Canvas.GetSolidColorBrush(P_0);
		return CreatePen(solidColorBrush, P_1, P_2);
	}

	internal static Pen CreatePen(Brush brush, LineKind lineKind, float strokeWidth)
	{
		Pen pen = new Pen(brush, strokeWidth);
		if (lineKind != LineKind.Solid)
		{
			pen.DashStyle = GetDashStyle(lineKind);
		}
		return pen;
	}

	internal static DashStyle GetDashStyle(LineKind lineKind)
	{
		return lineKind switch
		{
			LineKind.Dash => DashStyles.Dash, 
			LineKind.DashDot => DashStyles.DashDot, 
			LineKind.Dot => DashStyles.Dot, 
			_ => DashStyles.Solid, 
		};
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	public void DrawEllipse(Rect bounds, Color color, LineKind lineKind, float strokeWidth)
	{
		Pen pen = CreatePen(Canvas.GetSolidColorBrush(color), lineKind, strokeWidth);
		DrawEllipse(bounds, pen);
	}

	public void DrawEllipse(Rect bounds, Pen pen)
	{
		if (pen != null)
		{
			double num = bounds.Width / 2.0;
			double num2 = bounds.Height / 2.0;
			PlatformRenderer.DrawEllipse(null, pen, new Point(bounds.X + num, bounds.Y + num2), num, num2);
		}
	}

	public void DrawGeometry(Point location, Geometry geometry, Color color, LineKind lineKind, float strokeWidth)
	{
		Pen pen = CreatePen(Canvas.GetSolidColorBrush(color), lineKind, strokeWidth);
		DrawGeometry(location, geometry, pen);
	}

	public void DrawGeometry(Point location, Geometry geometry, Pen pen)
	{
		if (pen != null)
		{
			PlatformRenderer.PushTransform(new TranslateTransform(location.X, location.Y));
			PlatformRenderer.DrawGeometry(null, pen, geometry);
			PlatformRenderer.Pop();
		}
	}

	public void DrawImage(Point location, ImageSource imageSource)
	{
		if (imageSource != null)
		{
			PlatformRenderer.DrawImage(imageSource, new Rect(location.X, location.Y, imageSource.Width, imageSource.Height));
		}
	}

	public void DrawLine(Point startLocation, Point endLocation, Color color, LineKind lineKind, float strokeWidth)
	{
		Pen pen = qYh(color, lineKind, strokeWidth);
		DrawLine(startLocation, endLocation, pen);
	}

	public void DrawLine(Point startLocation, Point endLocation, Pen pen)
	{
		if (pen != null)
		{
			double num = pen.Thickness / 2.0;
			PlatformRenderer.DrawLine(pen, new Point(startLocation.X + num, startLocation.Y + num), new Point(endLocation.X + num, endLocation.Y + num));
		}
	}

	public void DrawRectangle(Rect bounds, Color color, LineKind lineKind, float strokeWidth)
	{
		Pen pen = CreatePen(Canvas.GetSolidColorBrush(color), lineKind, strokeWidth);
		DrawRectangle(bounds, pen);
	}

	public void DrawRectangle(Rect bounds, Pen pen)
	{
		if (pen != null)
		{
			double num = pen.Thickness / 2.0;
			bounds = new Rect(bounds.X + num, bounds.Y + num, Math.Max(1.0, bounds.Width - 2.0 * num), Math.Max(1.0, bounds.Height - 2.0 * num));
			PlatformRenderer.DrawRectangle(null, pen, bounds);
		}
	}

	public void DrawRoundedRectangle(Rect bounds, float radius, Color color, LineKind lineKind, float strokeWidth)
	{
		Pen pen = CreatePen(Canvas.GetSolidColorBrush(color), lineKind, strokeWidth);
		DrawRoundedRectangle(bounds, radius, pen);
	}

	public void DrawRoundedRectangle(Rect bounds, float radius, Pen pen)
	{
		if (pen != null)
		{
			double num = pen.Thickness / 2.0;
			bounds = new Rect(bounds.X + num, bounds.Y + num, Math.Max(1.0, bounds.Width - 2.0 * num), Math.Max(1.0, bounds.Height - 2.0 * num));
			PlatformRenderer.DrawRoundedRectangle(null, pen, bounds, radius, radius);
		}
	}

	public void DrawSquiggleLine(Rect bounds, Color color)
	{
		float[] array = new float[4] { 1.5f, 0f, 1.5f, 3f };
		bounds.Y = bounds.Bottom - 3.0;
		bounds.Height = 3.0;
		double width = bounds.Width;
		Pen squiggleLinePen = Canvas.GetSquiggleLinePen(color);
		PathFigure pathFigure = new PathFigure
		{
			StartPoint = new Point(0.0, array[0])
		};
		for (double num = 0.0; num < width; num += 1.5)
		{
			pathFigure.Segments.Add(new LineSegment
			{
				Point = new Point(num, array[(int)(num / 1.5 % (double)array.Length)])
			});
		}
		PathGeometry pathGeometry = new PathGeometry();
		pathGeometry.Figures.Add(pathFigure);
		Rect clipBounds = ClipBounds;
		clipBounds.Intersect(bounds);
		PushClip(clipBounds);
		DrawGeometry(new Point(bounds.X, bounds.Y), pathGeometry, squiggleLinePen);
		PopClip();
	}

	public void DrawText(Point location, ITextLayoutLine line)
	{
		if (line is TextLayoutLine textLayoutLine)
		{
			textLayoutLine.Draw(this, location);
		}
	}

	public void FillEllipse(Rect bounds, Color color)
	{
		SolidColorBrush solidColorBrush = Canvas.GetSolidColorBrush(color);
		FillEllipse(bounds, solidColorBrush);
	}

	public void FillEllipse(Rect bounds, Brush brush)
	{
		if (brush != null)
		{
			double num = bounds.Width / 2.0;
			double num2 = bounds.Height / 2.0;
			PlatformRenderer.DrawEllipse(brush, null, new Point(bounds.X + num, bounds.Y + num2), num, num2);
		}
	}

	public void FillGeometry(Point location, Geometry geometry, Color color)
	{
		SolidColorBrush solidColorBrush = Canvas.GetSolidColorBrush(color);
		FillGeometry(location, geometry, solidColorBrush);
	}

	public void FillGeometry(Point location, Geometry geometry, Brush brush)
	{
		if (brush != null)
		{
			PlatformRenderer.PushTransform(new TranslateTransform(location.X, location.Y));
			PlatformRenderer.DrawGeometry(brush, null, geometry);
			PlatformRenderer.Pop();
		}
	}

	public void FillRectangle(Rect bounds, Color color)
	{
		SolidColorBrush solidColorBrush = Canvas.GetSolidColorBrush(color);
		FillRectangle(bounds, solidColorBrush);
	}

	public void FillRectangle(Rect bounds, Brush brush)
	{
		if (brush != null)
		{
			PlatformRenderer.DrawRectangle(brush, null, bounds);
		}
	}

	public void FillRoundedRectangle(Rect bounds, float radius, Color color)
	{
		SolidColorBrush solidColorBrush = Canvas.GetSolidColorBrush(color);
		FillRoundedRectangle(bounds, radius, solidColorBrush);
	}

	public void FillRoundedRectangle(Rect bounds, float radius, Brush brush)
	{
		if (brush != null)
		{
			PlatformRenderer.DrawRoundedRectangle(brush, null, bounds, radius, radius);
		}
	}

	public void PopBounds()
	{
		if (bY2 != null && bY2.Count > 0)
		{
			Bounds = bY2.Pop();
		}
	}

	public void PopClip()
	{
		if (LYe != null && LYe.Count > 0)
		{
			ClipBounds = LYe.Pop();
			PlatformRenderer.Pop();
		}
	}

	public void PopScaleTransform()
	{
		uY7 = 1.0;
		PlatformRenderer.Pop();
	}

	public void PushBounds(Rect bounds)
	{
		if (bY2 == null)
		{
			bY2 = new Stack<Rect>(2);
		}
		bY2.Push(Bounds);
		Bounds = bounds;
	}

	public void PushClip(Rect clipBounds)
	{
		if (LYe == null)
		{
			LYe = new Stack<Rect>(2);
		}
		LYe.Push(ClipBounds);
		PlatformRenderer.PushClip(new RectangleGeometry(clipBounds));
		ClipBounds = clipBounds;
	}

	public void PushScaleTransform(double newScale)
	{
		uY7 = newScale;
		PlatformRenderer.PushTransform(new ScaleTransform(uY7, uY7));
	}

	internal static bool NnF()
	{
		return Tnk == null;
	}

	internal static CanvasDrawContext Ind()
	{
		return Tnk;
	}
}
