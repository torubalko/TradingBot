using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class DropShadowChrome : Decorator
{
	public static readonly DependencyProperty BorderThicknessProperty;

	public static readonly DependencyProperty ColorProperty;

	public static readonly DependencyProperty CornerRadiusProperty;

	public static readonly DependencyProperty XOffsetProperty;

	public static readonly DependencyProperty YOffsetProperty;

	public static readonly DependencyProperty ZOffsetProperty;

	private static DropShadowChrome uGM;

	public Thickness BorderThickness
	{
		get
		{
			return (Thickness)GetValue(BorderThicknessProperty);
		}
		set
		{
			SetValue(BorderThicknessProperty, value);
		}
	}

	public Color Color
	{
		get
		{
			return (Color)GetValue(ColorProperty);
		}
		set
		{
			SetValue(ColorProperty, value);
		}
	}

	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(CornerRadiusProperty);
		}
		set
		{
			SetValue(CornerRadiusProperty, value);
		}
	}

	public double XOffset
	{
		get
		{
			return (double)GetValue(XOffsetProperty);
		}
		set
		{
			SetValue(XOffsetProperty, value);
		}
	}

	public double YOffset
	{
		get
		{
			return (double)GetValue(YOffsetProperty);
		}
		set
		{
			SetValue(YOffsetProperty, value);
		}
	}

	public double ZOffset
	{
		get
		{
			return (double)GetValue(ZOffsetProperty);
		}
		set
		{
			SetValue(ZOffsetProperty, value);
		}
	}

	private GradientStopCollection DlK(double P_0)
	{
		Color color = Color;
		double num = (int)color.A;
		double num2 = 1.0 - P_0;
		GradientStopCollection gradientStopCollection = new GradientStopCollection();
		gradientStopCollection.Add(new GradientStop(color, P_0 + 0.0 * num2));
		color.A = (byte)(0.74336 * num);
		gradientStopCollection.Add(new GradientStop(color, P_0 + 0.2 * num2));
		color.A = (byte)(0.38053 * num);
		gradientStopCollection.Add(new GradientStop(color, P_0 + 0.4 * num2));
		color.A = (byte)(0.12389 * num);
		gradientStopCollection.Add(new GradientStop(color, P_0 + 0.7 * num2));
		color.A = 0;
		gradientStopCollection.Add(new GradientStop(color, P_0 + 1.0 * num2));
		gradientStopCollection.Freeze();
		int num3 = 0;
		if (!tGY())
		{
			int num4 = default(int);
			num3 = num4;
		}
		return num3 switch
		{
			_ => gradientStopCollection, 
		};
	}

	private void rlg(DrawingContext P_0, double P_1, double P_2, double P_3, double P_4, Sides P_5)
	{
		if (!(P_3 <= 0.0) && !(P_4 <= 0.0))
		{
			Rect rectangle = new Rect(P_1, P_2, P_3, P_4);
			Point startPoint;
			Point endPoint;
			switch (P_5)
			{
			case Sides.Left:
				startPoint = new Point(1.0, 0.0);
				endPoint = new Point(0.0, 0.0);
				break;
			case Sides.Top:
				startPoint = new Point(0.0, 1.0);
				endPoint = new Point(0.0, 0.0);
				break;
			case Sides.Right:
				startPoint = new Point(0.0, 0.0);
				endPoint = new Point(1.0, 0.0);
				break;
			default:
				startPoint = new Point(0.0, 0.0);
				endPoint = new Point(0.0, 1.0);
				break;
			}
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(DlK(0.0), startPoint, endPoint);
			linearGradientBrush.Freeze();
			P_0.DrawRectangle(linearGradientBrush, null, rectangle);
		}
	}

	private void Sl8(DrawingContext P_0, double P_1, double P_2, double P_3, double P_4, Corners P_5)
	{
		if (P_3 <= 0.0 || P_4 <= 0.0)
		{
			return;
		}
		Rect rectangle = new Rect(P_1, P_2, P_3, P_4);
		double num = 0.0;
		CornerRadius cornerRadius = default(CornerRadius);
		int num3 = default(int);
		int num2;
		RadialGradientBrush radialGradientBrush = default(RadialGradientBrush);
		Corners corners = default(Corners);
		switch (P_5)
		{
		case Corners.TopRight:
		{
			double topRight = CornerRadius.TopRight;
			cornerRadius = CornerRadius;
			num = topRight / (cornerRadius.TopRight + BorderThickness.Top);
			goto default;
		}
		case Corners.BottomRight:
		{
			double bottomRight = CornerRadius.BottomRight;
			cornerRadius = CornerRadius;
			num = bottomRight / (cornerRadius.BottomRight + BorderThickness.Bottom);
			num3 = 3;
			goto IL_0005;
		}
		case Corners.TopLeft:
			cornerRadius = CornerRadius;
			num2 = 4;
			goto IL_0009;
		case Corners.BottomLeft:
		{
			double bottomLeft = CornerRadius.BottomLeft;
			cornerRadius = CornerRadius;
			num = bottomLeft / (cornerRadius.BottomLeft + BorderThickness.Bottom);
			goto default;
		}
		default:
			{
				radialGradientBrush = new RadialGradientBrush(DlK(num));
				num2 = 1;
				if (bGt() != null)
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			IL_0009:
			while (true)
			{
				switch (num2)
				{
				case 4:
					goto IL_009c;
				case 1:
					corners = P_5;
					switch (corners)
					{
					case Corners.TopLeft:
						radialGradientBrush.Center = new Point(1.0, 1.0);
						break;
					case Corners.Top:
						break;
					default:
						goto IL_02c1;
					case Corners.TopRight:
						radialGradientBrush.Center = new Point(0.0, 1.0);
						break;
					case Corners.BottomRight:
						radialGradientBrush.Center = new Point(0.0, 0.0);
						break;
					}
					goto IL_0181;
				case 2:
					goto IL_02c1;
					IL_02c1:
					if (corners == Corners.BottomLeft)
					{
						radialGradientBrush.Center = new Point(1.0, 0.0);
					}
					goto IL_0181;
					IL_0181:
					radialGradientBrush.GradientOrigin = radialGradientBrush.Center;
					radialGradientBrush.RadiusX = 1.0;
					radialGradientBrush.RadiusY = 1.0;
					radialGradientBrush.Freeze();
					P_0.DrawRectangle(radialGradientBrush, null, rectangle);
					return;
				}
				break;
				IL_009c:
				double topLeft = cornerRadius.TopLeft;
				cornerRadius = CornerRadius;
				num = topLeft / (cornerRadius.TopLeft + BorderThickness.Top);
				num2 = 0;
				if (bGt() == null)
				{
					continue;
				}
				goto IL_0005;
			}
			goto default;
			IL_0005:
			num2 = num3;
			goto IL_0009;
		}
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		if ((double)(int)Color.A == 0.0)
		{
			return;
		}
		Rect rect = new Rect(new Point(XOffset, YOffset), base.RenderSize);
		rect.Inflate(ZOffset, ZOffset);
		if (!(rect.Width <= 0.0) && !(rect.Height <= 0.0))
		{
			Rect rect2 = new Rect(rect.Left + BorderThickness.Left, rect.Top + BorderThickness.Top, Math.Max(0.0, rect.Width - BorderThickness.Left - BorderThickness.Right), Math.Max(0.0, rect.Height - BorderThickness.Top - BorderThickness.Bottom));
			double[] guidelinesX = new double[4] { rect.Left, rect2.Left, rect2.Right, rect.Right };
			double[] guidelinesY = new double[4] { rect.Top, rect2.Top, rect2.Bottom, rect.Bottom };
			drawingContext.PushGuidelineSet(new GuidelineSet(guidelinesX, guidelinesY));
			if (rect2.Width > 0.0 && rect2.Height > 0.0)
			{
				SolidColorBrush solidColorBrush = new SolidColorBrush(Color);
				solidColorBrush.Freeze();
				PathFigure pathFigure = new PathFigure();
				pathFigure.StartPoint = new Point(rect2.Left + CornerRadius.TopLeft, rect2.Top);
				pathFigure.Segments.Add(new LineSegment(new Point(rect2.Right - CornerRadius.TopRight, rect2.Top), isStroked: true));
				pathFigure.Segments.Add(new LineSegment(new Point(rect2.Right - CornerRadius.TopRight, rect2.Top + CornerRadius.TopRight), isStroked: true));
				pathFigure.Segments.Add(new LineSegment(new Point(rect2.Right, rect2.Top + CornerRadius.TopRight), isStroked: true));
				pathFigure.Segments.Add(new LineSegment(new Point(rect2.Right, rect2.Bottom - CornerRadius.BottomRight), isStroked: true));
				pathFigure.Segments.Add(new LineSegment(new Point(rect2.Right - CornerRadius.BottomRight, rect2.Bottom - CornerRadius.BottomRight), isStroked: true));
				pathFigure.Segments.Add(new LineSegment(new Point(rect2.Right - CornerRadius.BottomRight, rect2.Bottom), isStroked: true));
				pathFigure.Segments.Add(new LineSegment(new Point(rect2.Left + CornerRadius.TopLeft, rect2.Bottom), isStroked: true));
				pathFigure.Segments.Add(new LineSegment(new Point(rect2.Left + CornerRadius.TopLeft, rect2.Bottom - CornerRadius.BottomLeft), isStroked: true));
				pathFigure.Segments.Add(new LineSegment(new Point(rect2.Left, rect2.Bottom - CornerRadius.BottomLeft), isStroked: true));
				pathFigure.Segments.Add(new LineSegment(new Point(rect2.Left, rect2.Top + CornerRadius.TopLeft), isStroked: true));
				pathFigure.Segments.Add(new LineSegment(new Point(rect2.Left + CornerRadius.TopLeft, rect2.Top + CornerRadius.TopLeft), isStroked: true));
				pathFigure.IsClosed = true;
				PathGeometry pathGeometry = new PathGeometry();
				pathGeometry.Figures.Add(pathFigure);
				pathGeometry.Freeze();
				drawingContext.DrawGeometry(solidColorBrush, null, pathGeometry);
			}
			rlg(drawingContext, rect.Left, rect2.Top + CornerRadius.TopLeft, BorderThickness.Left, rect2.Height - CornerRadius.TopLeft - CornerRadius.BottomLeft, Sides.Left);
			rlg(drawingContext, rect2.Left + CornerRadius.TopLeft, rect.Top, rect2.Width - CornerRadius.TopLeft - CornerRadius.TopRight, BorderThickness.Top, Sides.Top);
			rlg(drawingContext, rect2.Right, rect2.Top + CornerRadius.TopRight, BorderThickness.Right, rect2.Height - CornerRadius.TopRight - CornerRadius.BottomRight, Sides.Right);
			rlg(drawingContext, rect2.Left + CornerRadius.BottomLeft, rect2.Bottom, rect2.Width - CornerRadius.BottomLeft - CornerRadius.BottomRight, BorderThickness.Bottom, Sides.Bottom);
			Sl8(drawingContext, rect.Left, rect.Top, BorderThickness.Left + CornerRadius.TopLeft, BorderThickness.Top + CornerRadius.TopLeft, Corners.TopLeft);
			Sl8(drawingContext, rect2.Right - CornerRadius.TopRight, rect.Top, BorderThickness.Right + CornerRadius.TopRight, BorderThickness.Top + CornerRadius.TopRight, Corners.TopRight);
			Sl8(drawingContext, rect2.Right - CornerRadius.BottomRight, rect2.Bottom - CornerRadius.BottomRight, BorderThickness.Right + CornerRadius.BottomRight, BorderThickness.Bottom + CornerRadius.BottomRight, Corners.BottomRight);
			Sl8(drawingContext, rect.Left, rect2.Bottom - CornerRadius.BottomLeft, BorderThickness.Left + CornerRadius.BottomLeft, BorderThickness.Bottom + CornerRadius.BottomLeft, Corners.BottomLeft);
			drawingContext.Pop();
		}
	}

	public DropShadowChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static DropShadowChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		BorderThicknessProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114074), typeof(Thickness), typeof(DropShadowChrome), new FrameworkPropertyMetadata(new Thickness(5.0), FrameworkPropertyMetadataOptions.AffectsRender));
		ColorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114108), typeof(Color), typeof(DropShadowChrome), new FrameworkPropertyMetadata(Color.FromArgb(113, 0, 0, 0), FrameworkPropertyMetadataOptions.AffectsRender));
		CornerRadiusProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97530), typeof(CornerRadius), typeof(DropShadowChrome), new FrameworkPropertyMetadata(new CornerRadius(0.0), FrameworkPropertyMetadataOptions.AffectsRender));
		XOffsetProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114122), typeof(double), typeof(DropShadowChrome), new FrameworkPropertyMetadata(5.0, FrameworkPropertyMetadataOptions.AffectsRender));
		YOffsetProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114140), typeof(double), typeof(DropShadowChrome), new FrameworkPropertyMetadata(5.0, FrameworkPropertyMetadataOptions.AffectsRender));
		ZOffsetProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114158), typeof(double), typeof(DropShadowChrome), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender));
	}

	internal static bool tGY()
	{
		return uGM == null;
	}

	internal static DropShadowChrome bGt()
	{
		return uGM;
	}
}
