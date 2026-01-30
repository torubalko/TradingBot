using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Extensions;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class TabItemBorder : Decorator
{
	private Storyboard LxB;

	private static readonly Color sxK;

	public static readonly DependencyProperty CornerRadiusProperty;

	public static readonly DependencyProperty FlashColorProperty;

	public static readonly DependencyProperty FlashModeProperty;

	public static readonly DependencyProperty TabStripPlacementProperty;

	public static readonly DependencyProperty TintColorProperty;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Untinted")]
	public static readonly DependencyProperty UntintedBackgroundProperty;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Untinted")]
	public static readonly DependencyProperty UntintedBorderBrushProperty;

	public static readonly DependencyProperty BackgroundProperty;

	public static readonly DependencyProperty BorderBrushProperty;

	public static readonly DependencyProperty BorderThicknessProperty;

	public static readonly DependencyProperty FarSlantExtentProperty;

	public static readonly DependencyProperty IsSelectedProperty;

	public static readonly DependencyProperty NearSlantExtentProperty;

	private static TabItemBorder AAY;

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

	public Color FlashColor
	{
		get
		{
			return (Color)GetValue(FlashColorProperty);
		}
		set
		{
			SetValue(FlashColorProperty, value);
		}
	}

	public TabFlashMode FlashMode
	{
		get
		{
			return (TabFlashMode)GetValue(FlashModeProperty);
		}
		set
		{
			SetValue(FlashModeProperty, value);
		}
	}

	public Dock TabStripPlacement
	{
		get
		{
			return (Dock)GetValue(TabStripPlacementProperty);
		}
		set
		{
			SetValue(TabStripPlacementProperty, value);
		}
	}

	public Color TintColor
	{
		get
		{
			return (Color)GetValue(TintColorProperty);
		}
		set
		{
			SetValue(TintColorProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Untinted")]
	public Brush UntintedBackground
	{
		get
		{
			return (Brush)GetValue(UntintedBackgroundProperty);
		}
		set
		{
			SetValue(UntintedBackgroundProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Untinted")]
	public Brush UntintedBorderBrush
	{
		get
		{
			return (Brush)GetValue(UntintedBorderBrushProperty);
		}
		set
		{
			SetValue(UntintedBorderBrushProperty, value);
		}
	}

	public Brush Background
	{
		get
		{
			return (Brush)GetValue(BackgroundProperty);
		}
		set
		{
			SetValue(BackgroundProperty, value);
		}
	}

	public Brush BorderBrush
	{
		get
		{
			return (Brush)GetValue(BorderBrushProperty);
		}
		set
		{
			SetValue(BorderBrushProperty, value);
		}
	}

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

	public double FarSlantExtent
	{
		get
		{
			return (double)GetValue(FarSlantExtentProperty);
		}
		set
		{
			SetValue(FarSlantExtentProperty, value);
		}
	}

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(IsSelectedProperty);
		}
		set
		{
			SetValue(IsSelectedProperty, value);
		}
	}

	public double NearSlantExtent
	{
		get
		{
			return (double)GetValue(NearSlantExtentProperty);
		}
		set
		{
			SetValue(NearSlantExtentProperty, value);
		}
	}

	private static bool zx2(Brush P_0)
	{
		if (P_0 == null)
		{
			return true;
		}
		if (P_0 is SolidColorBrush solidColorBrush)
		{
			return solidColorBrush.Color == Colors.Transparent;
		}
		return false;
	}

	private static void zxe(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TabItemBorder tabItemBorder = (TabItemBorder)P_0;
		if (P_1.NewValue != P_1.OldValue)
		{
			tabItemBorder.xx1();
		}
	}

	private static void ExG(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TabItemBorder tabItemBorder = (TabItemBorder)P_0;
		if (P_1.NewValue != P_1.OldValue)
		{
			tabItemBorder.xx1();
		}
	}

	private static void uxI(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TabItemBorder tabItemBorder = (TabItemBorder)P_0;
		if (P_1.NewValue != P_1.OldValue)
		{
			tabItemBorder.yxC();
		}
	}

	private static void sxk(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TabItemBorder tabItemBorder = (TabItemBorder)P_0;
		if (P_1.NewValue != P_1.OldValue)
		{
			tabItemBorder.yxC();
		}
	}

	private void yxC()
	{
		Color tintColor = TintColor;
		Brush untintedBackground = UntintedBackground;
		Brush untintedBorderBrush = UntintedBorderBrush;
		if (tintColor.A <= 0)
		{
			Background = untintedBackground;
			BorderBrush = untintedBorderBrush;
			return;
		}
		bool flag = FlashMode != TabFlashMode.None;
		bool flag2 = zx2(untintedBackground);
		bool flag3 = zx2(untintedBorderBrush);
		if (!flag2)
		{
			goto IL_00ac;
		}
		if (!flag3)
		{
			Background = untintedBackground;
		}
		else
		{
			Color color = tintColor;
			color.A = 0;
			Background = hW.Hla(flag ? color : sxK, tintColor, flag).ToSolidColorBrush();
		}
		goto IL_0144;
		IL_0144:
		if (!flag3)
		{
			BorderBrush = hW.ylm(untintedBorderBrush, tintColor, flag);
			int num = 1;
			if (!HAC())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				return;
			}
			goto IL_00ac;
		}
		if (flag2)
		{
			Color color2 = tintColor;
			color2.A = 0;
			BorderBrush = hW.Hla(flag ? color2 : sxK, tintColor, flag).ToSolidColorBrush();
		}
		else
		{
			BorderBrush = untintedBorderBrush;
		}
		return;
		IL_00ac:
		Background = hW.ylm(untintedBackground, tintColor, flag);
		goto IL_0144;
	}

	private void xx1()
	{
		int num;
		if (LxB != null)
		{
			LxB.Stop(this);
			ApplyAnimationClock(TintColorProperty, null);
			LxB = null;
			num = 1;
			if (cAK() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_002d;
		IL_002d:
		Color flashColor = FlashColor;
		Color value = flashColor;
		value.A = 0;
		TabFlashMode flashMode = FlashMode;
		if (flashMode != TabFlashMode.Blink)
		{
			if (flashMode != TabFlashMode.Smooth)
			{
				return;
			}
			LxB = new Storyboard
			{
				AutoReverse = true,
				Children = { (Timeline)new ColorAnimation
				{
					From = value,
					To = flashColor,
					Duration = new Duration(TimeSpan.FromSeconds(0.75)),
					FillBehavior = FillBehavior.Stop
				} },
				RepeatBehavior = RepeatBehavior.Forever
			};
			Storyboard.SetTarget(LxB, this);
			num = 0;
			if (!HAC())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		LxB = new Storyboard
		{
			Children = { (Timeline)new ColorAnimationUsingKeyFrames
			{
				Duration = new Duration(TimeSpan.FromSeconds(1.0)),
				FillBehavior = FillBehavior.Stop,
				KeyFrames = 
				{
					(ColorKeyFrame)new DiscreteColorKeyFrame
					{
						KeyTime = KeyTime.FromTimeSpan(TimeSpan.Zero),
						Value = value
					},
					(ColorKeyFrame)new DiscreteColorKeyFrame
					{
						KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.5)),
						Value = flashColor
					}
				}
			} },
			RepeatBehavior = RepeatBehavior.Forever
		};
		Storyboard.SetTarget(LxB, this);
		Storyboard.SetTargetProperty(LxB, new PropertyPath(vVK.ssH(6620)));
		LxB.Begin(this, isControllable: true);
		return;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			Storyboard.SetTargetProperty(LxB, new PropertyPath(vVK.ssH(6620)));
			LxB.Begin(this, isControllable: true);
			return;
		}
		goto IL_002d;
	}

	private static PathGeometry XxN(bool P_0, double P_1, double P_2, Dock P_3, bool P_4, CornerRadius P_5, double P_6, double P_7, double P_8)
	{
		double num = (P_0 ? P_8 : (P_4 ? 0.0 : (2.0 * P_8))) / 2.0;
		if (P_3 == Dock.Left || P_3 == Dock.Right)
		{
			double num2 = P_1;
			P_1 = P_2;
			P_2 = num2;
		}
		PathFigure pathFigure = new PathFigure
		{
			StartPoint = new Point(num, P_2 - num),
			IsFilled = true
		};
		if (P_6 > 0.0)
		{
			pathFigure.Segments.Add(new BezierSegment(new Point(num + 2.0 * P_5.BottomLeft, P_2 - num), new Point(num + P_6, num), new Point(num + P_5.BottomLeft + P_6 + P_5.TopLeft, num), isStroked: true));
		}
		else
		{
			if (P_5.BottomLeft > 0.0)
			{
				pathFigure.Segments.Add(new ArcSegment(new Point(num + P_5.BottomLeft, P_2 - num - P_5.BottomLeft), new Size(P_5.BottomLeft, P_5.BottomLeft), 0.0, isLargeArc: false, SweepDirection.Counterclockwise, isStroked: true));
			}
			else if (P_0)
			{
				pathFigure.StartPoint = new Point(num, P_2 - (P_4 ? 0.0 : P_8));
			}
			pathFigure.Segments.Add(new LineSegment(new Point(num + P_5.BottomLeft + P_6, num + P_5.TopLeft), isStroked: true));
			if (P_5.TopLeft > 0.0)
			{
				pathFigure.Segments.Add(new ArcSegment(new Point(num + P_5.BottomLeft + P_6 + P_5.TopLeft, num), new Size(P_5.TopLeft, P_5.TopLeft), 0.0, isLargeArc: false, SweepDirection.Clockwise, isStroked: true));
			}
		}
		pathFigure.Segments.Add(new LineSegment(new Point(P_1 - num - P_5.BottomRight - P_7 - P_5.TopRight, num), isStroked: true));
		if (P_7 > 0.0)
		{
			pathFigure.Segments.Add(new BezierSegment(new Point(P_1 - num - P_7, num), new Point(P_1 - num - 2.0 * P_5.BottomRight, P_2 - num), new Point(P_1 - num, P_2 - num), isStroked: true));
		}
		else
		{
			if (P_5.TopRight > 0.0)
			{
				pathFigure.Segments.Add(new ArcSegment(new Point(P_1 - num - P_5.BottomRight - P_7, num + P_5.TopRight), new Size(P_5.TopRight, P_5.TopRight), 0.0, isLargeArc: false, SweepDirection.Clockwise, isStroked: true));
			}
			if (P_5.BottomRight > 0.0)
			{
				pathFigure.Segments.Add(new LineSegment(new Point(P_1 - num - P_5.BottomRight, P_2 - num - P_5.BottomRight), isStroked: true));
				pathFigure.Segments.Add(new ArcSegment(new Point(P_1 - num, P_2 - num), new Size(P_5.BottomRight, P_5.BottomRight), 0.0, isLargeArc: false, SweepDirection.Counterclockwise, isStroked: true));
			}
			else
			{
				pathFigure.Segments.Add(new LineSegment(new Point(P_1 - num - P_5.BottomRight, P_2 - ((!P_0) ? num : (P_4 ? 0.0 : P_8))), isStroked: true));
			}
		}
		switch (P_3)
		{
		case Dock.Bottom:
			YxQ(pathFigure, P_2);
			break;
		case Dock.Left:
			vxW(pathFigure);
			break;
		case Dock.Right:
			YxQ(pathFigure, P_2);
			vxW(pathFigure);
			break;
		}
		PathGeometry pathGeometry = new PathGeometry();
		pathGeometry.Figures.Add(pathFigure);
		pathGeometry.Freeze();
		return pathGeometry;
	}

	private static void YxQ(PathFigure P_0, double P_1)
	{
		P_0.StartPoint = new Point(P_0.StartPoint.X, P_1 - P_0.StartPoint.Y);
		using PathSegmentCollection.Enumerator enumerator = P_0.Segments.GetEnumerator();
		while (enumerator.MoveNext())
		{
			PathSegment current = enumerator.Current;
			if (current is LineSegment lineSegment)
			{
				lineSegment.Point = new Point(lineSegment.Point.X, P_1 - lineSegment.Point.Y);
			}
			else if (!(current is ArcSegment arcSegment))
			{
				if (current is BezierSegment bezierSegment)
				{
					bezierSegment.Point1 = new Point(bezierSegment.Point1.X, P_1 - bezierSegment.Point1.Y);
					bezierSegment.Point2 = new Point(bezierSegment.Point2.X, P_1 - bezierSegment.Point2.Y);
					bezierSegment.Point3 = new Point(bezierSegment.Point3.X, P_1 - bezierSegment.Point3.Y);
				}
			}
			else
			{
				arcSegment.Point = new Point(arcSegment.Point.X, P_1 - arcSegment.Point.Y);
				arcSegment.SweepDirection = ((arcSegment.SweepDirection != SweepDirection.Clockwise) ? SweepDirection.Clockwise : SweepDirection.Counterclockwise);
			}
		}
		int num = 0;
		if (cAK() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private static void Wxm(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TabItemBorder obj = (TabItemBorder)P_0;
		obj.InvalidateMeasure();
		obj.InvalidateVisual();
	}

	private static Thickness Xxa(DrawingContext P_0, Size P_1, bool P_2, Dock P_3, CornerRadius P_4, double P_5, double P_6, Brush P_7, Brush P_8, Thickness P_9)
	{
		if (P_9.Left == P_9.Top && P_9.Top == P_9.Right && P_9.Right == P_9.Bottom)
		{
			P_9.Bottom = 0.0;
		}
		P_5 = Math.Max(0.0, P_5);
		P_6 = Math.Max(0.0, P_6);
		int num = 2;
		if (cAK() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		PathGeometry geometry = default(PathGeometry);
		Pen pen = default(Pen);
		do
		{
			IL_0009_2:
			switch (num)
			{
			case 2:
			{
				double val = Math.Min(Math.Max(0.0, P_1.Width - P_5 - P_6), P_1.Height) / 2.0;
				P_4 = new CornerRadius(Math.Min(val, P_4.TopLeft), Math.Min(val, P_4.TopRight), Math.Min(val, P_4.BottomRight), Math.Min(val, P_4.BottomLeft));
				if (P_0 != null)
				{
					double top = P_9.Top;
					if (P_7 != null)
					{
						PathGeometry geometry2 = XxN(_0020: false, P_1.Width, P_1.Height, P_3, P_2, P_4, P_5, P_6, top);
						P_0.DrawGeometry(P_7, null, geometry2);
					}
					if (P_8 != null)
					{
						if (top > 0.0)
						{
							geometry = XxN(_0020: true, P_1.Width, P_1.Height, P_3, P_2, P_4, P_5, P_6, top);
							pen = new Pen(P_8, top);
							num = 1;
							if (cAK() != null)
							{
								num = 1;
							}
							goto IL_0009_2;
						}
						if (P_9.Bottom > 0.0)
						{
							if ((uint)(P_3 - 2) <= 1u)
							{
								break;
							}
							P_0.DrawRectangle(P_8, null, new Rect(0.0, P_1.Height - P_9.Bottom, P_1.Width, P_9.Bottom));
						}
					}
				}
				goto IL_0290;
			}
			case 1:
				pen.Freeze();
				P_0.DrawGeometry(null, pen, geometry);
				goto IL_0290;
			default:
				{
					P_0.DrawRectangle(P_8, null, new Rect(0.0, 0.0, P_1.Width, P_9.Bottom));
					goto IL_0290;
				}
				IL_0290:
				return P_3 switch
				{
					Dock.Bottom => new Thickness(P_9.Left + P_4.BottomLeft + P_5, P_9.Bottom, P_9.Right + P_6 + P_4.BottomRight, P_9.Top), 
					Dock.Left => new Thickness(P_9.Bottom, P_9.Left + P_4.BottomLeft + P_5, P_9.Top, P_9.Right + P_6 + P_4.BottomRight), 
					Dock.Right => new Thickness(P_9.Top, P_9.Left + P_4.BottomLeft + P_5, P_9.Bottom, P_9.Right + P_6 + P_4.BottomRight), 
					_ => new Thickness(P_9.Left + P_4.BottomLeft + P_5, P_9.Top, P_9.Right + P_6 + P_4.BottomRight, P_9.Bottom), 
				};
			}
			num = 0;
		}
		while (HAC());
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private static void vxW(PathFigure P_0)
	{
		P_0.StartPoint = new Point(P_0.StartPoint.Y, P_0.StartPoint.X);
		foreach (PathSegment segment in P_0.Segments)
		{
			if (segment is LineSegment lineSegment)
			{
				lineSegment.Point = new Point(lineSegment.Point.Y, lineSegment.Point.X);
			}
			else if (segment is ArcSegment arcSegment)
			{
				arcSegment.Point = new Point(arcSegment.Point.Y, arcSegment.Point.X);
				arcSegment.SweepDirection = ((arcSegment.SweepDirection != SweepDirection.Clockwise) ? SweepDirection.Clockwise : SweepDirection.Counterclockwise);
			}
			else if (segment is BezierSegment bezierSegment)
			{
				bezierSegment.Point1 = new Point(bezierSegment.Point1.Y, bezierSegment.Point1.X);
				bezierSegment.Point2 = new Point(bezierSegment.Point2.Y, bezierSegment.Point2.X);
				bezierSegment.Point3 = new Point(bezierSegment.Point3.Y, bezierSegment.Point3.X);
			}
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		Thickness thickness = Xxa(null, finalSize, IsSelected, TabStripPlacement, CornerRadius, NearSlantExtent, FarSlantExtent, null, null, BorderThickness);
		if (Child != null)
		{
			Size size = new Size(Math.Max(0.0, finalSize.Width - thickness.Left - thickness.Right), Math.Max(0.0, finalSize.Height - thickness.Top - thickness.Bottom));
			Child.Arrange(new Rect(thickness.Left, thickness.Top, size.Width, size.Height));
		}
		return finalSize;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		Thickness thickness = Xxa(null, availableSize, IsSelected, TabStripPlacement, CornerRadius, NearSlantExtent, FarSlantExtent, null, null, BorderThickness);
		availableSize.Width = Math.Max(0.0, availableSize.Width - thickness.Left - thickness.Right);
		availableSize.Height = Math.Max(0.0, availableSize.Height - thickness.Top - thickness.Bottom);
		Size result = base.MeasureOverride(availableSize);
		result.Width += thickness.Left + thickness.Right;
		result.Height += thickness.Top + thickness.Bottom;
		return result;
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		Xxa(drawingContext, base.RenderSize, IsSelected, TabStripPlacement, CornerRadius, NearSlantExtent, FarSlantExtent, Background, BorderBrush, BorderThickness);
	}

	public TabItemBorder()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	static TabItemBorder()
	{
		IVH.CecNqz();
		sxK = Color.FromArgb(64, 128, 128, 128);
		CornerRadiusProperty = DependencyProperty.Register(vVK.ssH(5600), typeof(CornerRadius), typeof(TabItemBorder), new PropertyMetadata(default(CornerRadius), Wxm));
		FlashColorProperty = DependencyProperty.Register(vVK.ssH(5658), typeof(Color), typeof(TabItemBorder), new PropertyMetadata(Color.FromArgb(128, byte.MaxValue, 160, 0), zxe));
		FlashModeProperty = DependencyProperty.Register(vVK.ssH(5682), typeof(TabFlashMode), typeof(TabItemBorder), new PropertyMetadata(TabFlashMode.None, ExG));
		TabStripPlacementProperty = DependencyProperty.Register(vVK.ssH(3510), typeof(Dock), typeof(TabItemBorder), new PropertyMetadata(Dock.Top, Wxm));
		TintColorProperty = DependencyProperty.Register(vVK.ssH(6620), typeof(Color), typeof(TabItemBorder), new PropertyMetadata(Colors.Transparent, uxI));
		UntintedBackgroundProperty = DependencyProperty.Register(vVK.ssH(21944), typeof(Brush), typeof(TabItemBorder), new PropertyMetadata(null, sxk));
		UntintedBorderBrushProperty = DependencyProperty.Register(vVK.ssH(21984), typeof(Brush), typeof(TabItemBorder), new PropertyMetadata(null, sxk));
		BackgroundProperty = DependencyProperty.Register(vVK.ssH(22026), typeof(Brush), typeof(TabItemBorder), new PropertyMetadata(null, Wxm));
		BorderBrushProperty = DependencyProperty.Register(vVK.ssH(22050), typeof(Brush), typeof(TabItemBorder), new PropertyMetadata(null, Wxm));
		BorderThicknessProperty = DependencyProperty.Register(vVK.ssH(3548), typeof(Thickness), typeof(TabItemBorder), new PropertyMetadata(default(Thickness), Wxm));
		FarSlantExtentProperty = DependencyProperty.Register(vVK.ssH(6698), typeof(double), typeof(TabItemBorder), new PropertyMetadata(0.0, Wxm));
		IsSelectedProperty = DependencyProperty.Register(vVK.ssH(8344), typeof(bool), typeof(TabItemBorder), new PropertyMetadata(false, Wxm));
		NearSlantExtentProperty = DependencyProperty.Register(vVK.ssH(6730), typeof(double), typeof(TabItemBorder), new PropertyMetadata(0.0, Wxm));
	}

	internal static bool HAC()
	{
		return AAY == null;
	}

	internal static TabItemBorder cAK()
	{
		return AAY;
	}
}
