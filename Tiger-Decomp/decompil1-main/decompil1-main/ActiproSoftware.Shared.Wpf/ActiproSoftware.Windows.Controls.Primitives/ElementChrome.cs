using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using ActiproSoftware.Windows.Data;
using ActiproSoftware.Windows.Extensions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
public class ElementChrome : ChromeBase
{
	private static readonly DependencyPropertyKey Nxq;

	public static readonly DependencyProperty BackgroundProperty;

	public static readonly DependencyProperty BackgroundCheckedProperty;

	public static readonly DependencyProperty BackgroundDefaultedProperty;

	public static readonly DependencyProperty BackgroundDisabledProperty;

	public static readonly DependencyProperty BackgroundFocusedProperty;

	public static readonly DependencyProperty BackgroundHoverProperty;

	public static readonly DependencyProperty BackgroundPressedProperty;

	public static readonly DependencyProperty BorderBrushProperty;

	public static readonly DependencyProperty BorderBrushCheckedProperty;

	public static readonly DependencyProperty BorderBrushDefaultedProperty;

	public static readonly DependencyProperty BorderBrushDisabledProperty;

	public static readonly DependencyProperty BorderBrushFocusedProperty;

	public static readonly DependencyProperty BorderBrushHoverProperty;

	public static readonly DependencyProperty BorderBrushPressedProperty;

	public static readonly DependencyProperty BorderStyleProperty;

	public static readonly DependencyProperty BorderThicknessProperty;

	public static readonly DependencyProperty CornerRadiusProperty;

	public static readonly DependencyProperty HighlightProperty;

	public static readonly DependencyProperty HighlightCheckedProperty;

	public static readonly DependencyProperty HighlightDefaultedProperty;

	public static readonly DependencyProperty HighlightDisabledProperty;

	public static readonly DependencyProperty HighlightFocusedProperty;

	public static readonly DependencyProperty HighlightHoverProperty;

	public static readonly DependencyProperty HighlightPressedProperty;

	public static readonly DependencyProperty InnerBorderBrushProperty;

	public static readonly DependencyProperty InnerBorderBrushCheckedProperty;

	public static readonly DependencyProperty InnerBorderBrushDefaultedProperty;

	public static readonly DependencyProperty InnerBorderBrushDisabledProperty;

	public static readonly DependencyProperty InnerBorderBrushFocusedProperty;

	public static readonly DependencyProperty InnerBorderBrushHoverProperty;

	public static readonly DependencyProperty InnerBorderBrushPressedProperty;

	public static readonly DependencyProperty InnerBorderThicknessProperty;

	public static readonly DependencyProperty LastStateProperty;

	public static readonly DependencyProperty PaddingProperty;

	public static readonly DependencyProperty StateProperty;

	private static readonly DependencyProperty DxW;

	private static readonly DependencyProperty gxU;

	private static readonly DependencyProperty ExH;

	private static readonly DependencyProperty Ex6;

	private static readonly DependencyProperty LxV;

	internal static ElementChrome obf;

	private double StateCheckedOpacity => (double)GetValue(DxW);

	private double StateDefaultedOpacity => (double)GetValue(gxU);

	private double StateFocusedOpacity => (double)GetValue(ExH);

	private double StateHoverOpacity => (double)GetValue(Ex6);

	private double StatePressedOpacity => (double)GetValue(LxV);

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

	public Brush BackgroundChecked
	{
		get
		{
			return (Brush)GetValue(BackgroundCheckedProperty);
		}
		set
		{
			SetValue(BackgroundCheckedProperty, value);
		}
	}

	public Brush BackgroundDefaulted
	{
		get
		{
			return (Brush)GetValue(BackgroundDefaultedProperty);
		}
		set
		{
			SetValue(BackgroundDefaultedProperty, value);
		}
	}

	public Brush BackgroundDisabled
	{
		get
		{
			return (Brush)GetValue(BackgroundDisabledProperty);
		}
		set
		{
			SetValue(BackgroundDisabledProperty, value);
		}
	}

	public Brush BackgroundFocused
	{
		get
		{
			return (Brush)GetValue(BackgroundFocusedProperty);
		}
		set
		{
			SetValue(BackgroundFocusedProperty, value);
		}
	}

	public Brush BackgroundHover
	{
		get
		{
			return (Brush)GetValue(BackgroundHoverProperty);
		}
		set
		{
			SetValue(BackgroundHoverProperty, value);
		}
	}

	public Brush BackgroundPressed
	{
		get
		{
			return (Brush)GetValue(BackgroundPressedProperty);
		}
		set
		{
			SetValue(BackgroundPressedProperty, value);
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

	public Brush BorderBrushChecked
	{
		get
		{
			return (Brush)GetValue(BorderBrushCheckedProperty);
		}
		set
		{
			SetValue(BorderBrushCheckedProperty, value);
		}
	}

	public Brush BorderBrushDefaulted
	{
		get
		{
			return (Brush)GetValue(BorderBrushDefaultedProperty);
		}
		set
		{
			SetValue(BorderBrushDefaultedProperty, value);
		}
	}

	public Brush BorderBrushDisabled
	{
		get
		{
			return (Brush)GetValue(BorderBrushDisabledProperty);
		}
		set
		{
			SetValue(BorderBrushDisabledProperty, value);
		}
	}

	public Brush BorderBrushFocused
	{
		get
		{
			return (Brush)GetValue(BorderBrushFocusedProperty);
		}
		set
		{
			SetValue(BorderBrushFocusedProperty, value);
		}
	}

	public Brush BorderBrushHover
	{
		get
		{
			return (Brush)GetValue(BorderBrushHoverProperty);
		}
		set
		{
			SetValue(BorderBrushHoverProperty, value);
		}
	}

	public Brush BorderBrushPressed
	{
		get
		{
			return (Brush)GetValue(BorderBrushPressedProperty);
		}
		set
		{
			SetValue(BorderBrushPressedProperty, value);
		}
	}

	public ElementChromeBorderStyle BorderStyle
	{
		get
		{
			return (ElementChromeBorderStyle)GetValue(BorderStyleProperty);
		}
		set
		{
			SetValue(BorderStyleProperty, value);
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

	public Brush Highlight
	{
		get
		{
			return (Brush)GetValue(HighlightProperty);
		}
		set
		{
			SetValue(HighlightProperty, value);
		}
	}

	public Brush HighlightChecked
	{
		get
		{
			return (Brush)GetValue(HighlightCheckedProperty);
		}
		set
		{
			SetValue(HighlightCheckedProperty, value);
		}
	}

	public Brush HighlightDefaulted
	{
		get
		{
			return (Brush)GetValue(HighlightDefaultedProperty);
		}
		set
		{
			SetValue(HighlightDefaultedProperty, value);
		}
	}

	public Brush HighlightDisabled
	{
		get
		{
			return (Brush)GetValue(HighlightDisabledProperty);
		}
		set
		{
			SetValue(HighlightDisabledProperty, value);
		}
	}

	public Brush HighlightFocused
	{
		get
		{
			return (Brush)GetValue(HighlightFocusedProperty);
		}
		set
		{
			SetValue(HighlightFocusedProperty, value);
		}
	}

	public Brush HighlightHover
	{
		get
		{
			return (Brush)GetValue(HighlightHoverProperty);
		}
		set
		{
			SetValue(HighlightHoverProperty, value);
		}
	}

	public Brush HighlightPressed
	{
		get
		{
			return (Brush)GetValue(HighlightPressedProperty);
		}
		set
		{
			SetValue(HighlightPressedProperty, value);
		}
	}

	public Brush InnerBorderBrush
	{
		get
		{
			return (Brush)GetValue(InnerBorderBrushProperty);
		}
		set
		{
			SetValue(InnerBorderBrushProperty, value);
		}
	}

	public Brush InnerBorderBrushChecked
	{
		get
		{
			return (Brush)GetValue(InnerBorderBrushCheckedProperty);
		}
		set
		{
			SetValue(InnerBorderBrushCheckedProperty, value);
		}
	}

	public Brush InnerBorderBrushDefaulted
	{
		get
		{
			return (Brush)GetValue(InnerBorderBrushDefaultedProperty);
		}
		set
		{
			SetValue(InnerBorderBrushDefaultedProperty, value);
		}
	}

	public Brush InnerBorderBrushDisabled
	{
		get
		{
			return (Brush)GetValue(InnerBorderBrushDisabledProperty);
		}
		set
		{
			SetValue(InnerBorderBrushDisabledProperty, value);
		}
	}

	public Brush InnerBorderBrushFocused
	{
		get
		{
			return (Brush)GetValue(InnerBorderBrushFocusedProperty);
		}
		set
		{
			SetValue(InnerBorderBrushFocusedProperty, value);
		}
	}

	public Brush InnerBorderBrushHover
	{
		get
		{
			return (Brush)GetValue(InnerBorderBrushHoverProperty);
		}
		set
		{
			SetValue(InnerBorderBrushHoverProperty, value);
		}
	}

	public Brush InnerBorderBrushPressed
	{
		get
		{
			return (Brush)GetValue(InnerBorderBrushPressedProperty);
		}
		set
		{
			SetValue(InnerBorderBrushPressedProperty, value);
		}
	}

	public Thickness InnerBorderThickness
	{
		get
		{
			return (Thickness)GetValue(InnerBorderThicknessProperty);
		}
		set
		{
			SetValue(InnerBorderThicknessProperty, value);
		}
	}

	public ElementChromeState LastState
	{
		get
		{
			return (ElementChromeState)GetValue(LastStateProperty);
		}
		private set
		{
			SetValue(Nxq, value);
		}
	}

	public Thickness Padding
	{
		get
		{
			return (Thickness)GetValue(PaddingProperty);
		}
		set
		{
			SetValue(PaddingProperty, value);
		}
	}

	public ElementChromeState State
	{
		get
		{
			return (ElementChromeState)GetValue(StateProperty);
		}
		set
		{
			SetValue(StateProperty, value);
		}
	}

	[SpecialName]
	private double ixl()
	{
		return BorderThickness.Left;
	}

	internal Geometry CreateRectangleGeometry(Rect bounds, Thickness thickness, Thickness offset, CornerRadius cornerRadius)
	{
		if (bounds.Width == 0.0 || bounds.Height == 0.0 || offset.Left + offset.Right >= bounds.Width || offset.Top + offset.Bottom >= bounds.Height)
		{
			return null;
		}
		bool flag = !thickness.Left.IsEffectivelyZero();
		bool flag2 = !thickness.Top.IsEffectivelyZero();
		bool flag3 = !thickness.Right.IsEffectivelyZero();
		bool flag4 = !thickness.Bottom.IsEffectivelyZero();
		if (thickness.IsEffectivelyUniform() && (cornerRadius.IsEffectivelyZero() || BorderStyle != ElementChromeBorderStyle.Default))
		{
			return new RectangleGeometry(new Rect(bounds.Left + offset.Left, bounds.Top + offset.Top, bounds.Width - (offset.Left + offset.Right), bounds.Height - (offset.Top + offset.Bottom)));
		}
		if (thickness.IsEffectivelyUniform() && cornerRadius.IsEffectivelyUniform())
		{
			return new RectangleGeometry(new Rect(bounds.Left + offset.Left, bounds.Top + offset.Top, bounds.Width - (offset.Left + offset.Right), bounds.Height - (offset.Top + offset.Bottom)))
			{
				RadiusX = cornerRadius.TopLeft,
				RadiusY = cornerRadius.TopLeft
			};
		}
		PathFigure pathFigure = new PathFigure();
		double num = bounds.Left + offset.Left;
		double num2 = bounds.Top + offset.Top;
		double num3 = bounds.Right - offset.Right;
		double num4 = bounds.Bottom - offset.Bottom;
		if (cornerRadius.TopLeft != 0.0)
		{
			pathFigure.StartPoint = new Point(num + cornerRadius.TopLeft - 0.5, num2);
			pathFigure.Segments.Add(new ArcSegment(new Point(num, num2 + cornerRadius.TopLeft - 0.5), new Size(cornerRadius.TopLeft, cornerRadius.TopLeft), 0.0, isLargeArc: false, SweepDirection.Counterclockwise, flag && flag2));
		}
		else
		{
			pathFigure.StartPoint = new Point(num, num2);
		}
		if (cornerRadius.BottomLeft != 0.0)
		{
			pathFigure.Segments.Add(new LineSegment(new Point(num, num4 - cornerRadius.BottomLeft + 0.5), flag));
			pathFigure.Segments.Add(new ArcSegment(new Point(num + cornerRadius.BottomLeft - 0.5, num4), new Size(cornerRadius.BottomLeft, cornerRadius.BottomLeft), 0.0, isLargeArc: false, SweepDirection.Counterclockwise, flag && flag4));
		}
		else
		{
			pathFigure.Segments.Add(new LineSegment(new Point(num, num4), flag));
		}
		if (cornerRadius.BottomRight != 0.0)
		{
			pathFigure.Segments.Add(new LineSegment(new Point(num3 - cornerRadius.BottomRight + 0.5, num4), flag4));
			pathFigure.Segments.Add(new ArcSegment(new Point(num3, num4 - cornerRadius.BottomRight + 0.5), new Size(cornerRadius.BottomRight, cornerRadius.BottomRight), 0.0, isLargeArc: false, SweepDirection.Counterclockwise, flag4 && flag3));
		}
		else
		{
			pathFigure.Segments.Add(new LineSegment(new Point(num3, num4), flag4));
		}
		if (cornerRadius.TopRight != 0.0)
		{
			pathFigure.Segments.Add(new LineSegment(new Point(num3, num2 + cornerRadius.TopRight - 0.5), flag3));
			pathFigure.Segments.Add(new ArcSegment(new Point(num3 - cornerRadius.TopRight + 0.5, num2), new Size(cornerRadius.TopRight, cornerRadius.TopRight), 0.0, isLargeArc: false, SweepDirection.Counterclockwise, flag3 && flag2));
		}
		else
		{
			pathFigure.Segments.Add(new LineSegment(new Point(num3, num2), flag3));
		}
		if (!flag2)
		{
			pathFigure.Segments.Add(new LineSegment(pathFigure.StartPoint, isStroked: false));
		}
		pathFigure.IsClosed = true;
		PathGeometry pathGeometry = new PathGeometry();
		pathGeometry.Figures.Add(pathFigure);
		return pathGeometry;
	}

	private Brush Wxu(ElementChromeState P_0)
	{
		return P_0 switch
		{
			ElementChromeState.Checked => BackgroundChecked, 
			ElementChromeState.Defaulted => BackgroundDefaulted, 
			ElementChromeState.Disabled => BackgroundDisabled, 
			ElementChromeState.Focused => BackgroundFocused, 
			ElementChromeState.Hover => BackgroundHover, 
			ElementChromeState.Pressed => BackgroundPressed, 
			_ => Background, 
		};
	}

	private Brush Ix2(ElementChromeState P_0)
	{
		Brush result;
		switch (P_0)
		{
		default:
			result = BorderBrush;
			break;
		case ElementChromeState.Checked:
		{
			result = BorderBrushChecked;
			int num = 0;
			if (obH() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				goto IL_00f3;
			}
			break;
		}
		case ElementChromeState.Hover:
			result = BorderBrushHover;
			break;
		case ElementChromeState.Pressed:
			result = BorderBrushPressed;
			break;
		case ElementChromeState.Defaulted:
			result = BorderBrushDefaulted;
			break;
		case ElementChromeState.Disabled:
			result = BorderBrushDisabled;
			break;
		case ElementChromeState.Focused:
			goto IL_00f3;
			IL_00f3:
			result = BorderBrushFocused;
			break;
		}
		return result;
	}

	internal Brush GetHighlightForState(ElementChromeState state)
	{
		Brush result;
		switch (state)
		{
		case ElementChromeState.Focused:
			result = HighlightFocused;
			break;
		case ElementChromeState.Disabled:
		{
			result = HighlightDisabled;
			int num = 0;
			if (obH() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				goto IL_010f;
			}
			break;
		}
		case ElementChromeState.Defaulted:
			result = HighlightDefaulted;
			break;
		case ElementChromeState.Pressed:
			result = HighlightPressed;
			break;
		default:
			result = Highlight;
			break;
		case ElementChromeState.Checked:
			result = HighlightChecked;
			break;
		case ElementChromeState.Hover:
			goto IL_010f;
			IL_010f:
			result = HighlightHover;
			break;
		}
		return result;
	}

	private Brush jxe(ElementChromeState P_0)
	{
		Brush result;
		switch (P_0)
		{
		case ElementChromeState.Hover:
			result = InnerBorderBrushHover;
			break;
		case ElementChromeState.Pressed:
			result = InnerBorderBrushPressed;
			break;
		case ElementChromeState.Defaulted:
			result = InnerBorderBrushDefaulted;
			break;
		case ElementChromeState.Disabled:
		{
			result = InnerBorderBrushDisabled;
			int num = 1;
			if (!nb7())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_0092;
			}
			break;
		}
		case ElementChromeState.Focused:
			goto IL_0092;
		case ElementChromeState.Checked:
			result = InnerBorderBrushChecked;
			break;
		default:
			{
				result = InnerBorderBrush;
				break;
			}
			IL_0092:
			result = InnerBorderBrushFocused;
			break;
		}
		return result;
	}

	private double hx7(ElementChromeState P_0)
	{
		double result;
		switch (P_0)
		{
		case ElementChromeState.Defaulted:
			result = StateDefaultedOpacity;
			break;
		case ElementChromeState.Hover:
			result = StateHoverOpacity;
			break;
		default:
			result = 1.0;
			break;
		case ElementChromeState.Pressed:
		{
			result = StatePressedOpacity;
			int num = 0;
			if (!nb7())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case ElementChromeState.Focused:
			result = StateFocusedOpacity;
			break;
		case ElementChromeState.Checked:
			result = StateCheckedOpacity;
			break;
		}
		return result;
	}

	[SpecialName]
	private double yxC()
	{
		return InnerBorderThickness.Left;
	}

	private static void exF(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is ElementChrome elementChrome))
		{
			return;
		}
		ElementChromeState elementChromeState = (elementChrome.LastState = (ElementChromeState)P_1.OldValue);
		if (elementChrome.IsAnimationEnabledResolved)
		{
			switch ((ElementChromeState)P_1.NewValue)
			{
			case ElementChromeState.Normal:
			{
				Duration duration4 = new Duration(TimeSpan.FromSeconds(0.2));
				elementChrome.BeginAnimation(DxW, new DoubleAnimation
				{
					Duration = duration4
				});
				elementChrome.BeginAnimation(gxU, new DoubleAnimation
				{
					Duration = duration4
				});
				elementChrome.BeginAnimation(ExH, new DoubleAnimation
				{
					Duration = duration4
				});
				elementChrome.BeginAnimation(Ex6, new DoubleAnimation
				{
					Duration = duration4
				});
				elementChrome.BeginAnimation(LxV, new DoubleAnimation
				{
					Duration = duration4
				});
				break;
			}
			case ElementChromeState.Checked:
			{
				Duration duration6 = new Duration(TimeSpan.FromSeconds(0.1));
				elementChrome.BeginAnimation(gxU, new DoubleAnimation
				{
					Duration = duration6
				});
				elementChrome.BeginAnimation(ExH, new DoubleAnimation
				{
					Duration = duration6
				});
				elementChrome.BeginAnimation(Ex6, new DoubleAnimation
				{
					Duration = duration6
				});
				elementChrome.BeginAnimation(LxV, new DoubleAnimation
				{
					Duration = duration6
				});
				elementChrome.BeginAnimation(DxW, new DoubleAnimation
				{
					To = 1.0,
					Duration = duration6
				});
				break;
			}
			case ElementChromeState.Disabled:
				elementChrome.BeginAnimation(DxW, null);
				elementChrome.BeginAnimation(gxU, null);
				elementChrome.BeginAnimation(ExH, null);
				elementChrome.BeginAnimation(Ex6, null);
				elementChrome.BeginAnimation(LxV, null);
				break;
			case ElementChromeState.Defaulted:
			{
				Duration duration5 = new Duration(TimeSpan.FromSeconds(0.1));
				elementChrome.BeginAnimation(DxW, new DoubleAnimation
				{
					Duration = duration5
				});
				elementChrome.BeginAnimation(Ex6, new DoubleAnimation
				{
					Duration = duration5
				});
				elementChrome.BeginAnimation(ExH, new DoubleAnimation
				{
					Duration = duration5
				});
				elementChrome.BeginAnimation(LxV, new DoubleAnimation
				{
					Duration = duration5
				});
				DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames
				{
					KeyFrames = 
					{
						(DoubleKeyFrame)new DiscreteDoubleKeyFrame(0.0, TimeSpan.FromSeconds(0.0)),
						(DoubleKeyFrame)new LinearDoubleKeyFrame(1.0, TimeSpan.FromSeconds(0.5)),
						(DoubleKeyFrame)new DiscreteDoubleKeyFrame(1.0, TimeSpan.FromSeconds(0.75)),
						(DoubleKeyFrame)new LinearDoubleKeyFrame(0.0, TimeSpan.FromSeconds(2.0))
					},
					RepeatBehavior = RepeatBehavior.Forever
				};
				Timeline.SetDesiredFrameRate(doubleAnimationUsingKeyFrames, 10);
				elementChrome.BeginAnimation(gxU, doubleAnimationUsingKeyFrames);
				break;
			}
			case ElementChromeState.Hover:
			{
				double? num = null;
				switch (elementChromeState)
				{
				case ElementChromeState.Defaulted:
					num = elementChrome.StateDefaultedOpacity;
					break;
				case ElementChromeState.Focused:
					num = elementChrome.StateFocusedOpacity;
					break;
				}
				Duration duration3 = new Duration(TimeSpan.FromSeconds(0.3));
				elementChrome.BeginAnimation(DxW, new DoubleAnimation
				{
					Duration = duration3
				});
				elementChrome.BeginAnimation(gxU, new DoubleAnimation
				{
					Duration = duration3
				});
				elementChrome.BeginAnimation(ExH, new DoubleAnimation
				{
					Duration = duration3
				});
				elementChrome.BeginAnimation(LxV, new DoubleAnimation
				{
					Duration = duration3
				});
				elementChrome.BeginAnimation(Ex6, new DoubleAnimation
				{
					From = num,
					To = 1.0,
					Duration = duration3
				});
				break;
			}
			case ElementChromeState.Pressed:
			{
				Duration duration2 = new Duration(TimeSpan.FromSeconds(0.1));
				elementChrome.BeginAnimation(DxW, new DoubleAnimation
				{
					Duration = duration2
				});
				elementChrome.BeginAnimation(gxU, new DoubleAnimation
				{
					Duration = duration2
				});
				elementChrome.BeginAnimation(ExH, new DoubleAnimation
				{
					Duration = duration2
				});
				elementChrome.BeginAnimation(Ex6, new DoubleAnimation
				{
					Duration = duration2
				});
				elementChrome.BeginAnimation(LxV, new DoubleAnimation
				{
					To = 1.0,
					Duration = duration2
				});
				break;
			}
			case ElementChromeState.Focused:
			{
				Duration duration = new Duration(TimeSpan.FromSeconds(0.1));
				elementChrome.BeginAnimation(DxW, new DoubleAnimation
				{
					Duration = duration
				});
				elementChrome.BeginAnimation(gxU, new DoubleAnimation
				{
					Duration = duration
				});
				elementChrome.BeginAnimation(Ex6, new DoubleAnimation
				{
					Duration = duration
				});
				elementChrome.BeginAnimation(LxV, new DoubleAnimation
				{
					Duration = duration
				});
				elementChrome.BeginAnimation(ExH, new DoubleAnimation
				{
					To = 1.0,
					Duration = duration
				});
				break;
			}
			default:
				elementChrome.InvalidateVisual();
				break;
			}
		}
		else
		{
			elementChrome.InvalidateVisual();
		}
		ElementChromeBorderStyle borderStyle = elementChrome.BorderStyle;
		ElementChromeBorderStyle elementChromeBorderStyle = borderStyle;
		if (elementChromeBorderStyle == ElementChromeBorderStyle.Raised || (uint)(elementChromeBorderStyle - 5) <= 1u)
		{
			elementChrome.InvalidateArrange();
		}
	}

	internal void RenderBackground(DrawingContext drawingContext, Geometry geometry)
	{
		ElementChromeState state = State;
		if (state == ElementChromeState.Disabled || !base.IsAnimationEnabledResolved)
		{
			Brush brush = Wxu(state) ?? Wxu(ElementChromeState.Normal);
			drawingContext.DrawGeometry(brush, null, geometry);
			return;
		}
		drawingContext.DrawGeometry(Background, null, geometry);
		state = LastState;
		if (state != ElementChromeState.Normal && state != ElementChromeState.Disabled)
		{
			Brush brush2 = Wxu(state);
			double num = hx7(state);
			if (brush2 != null && num != 0.0)
			{
				drawingContext.PushOpacity(num);
				try
				{
					drawingContext.DrawGeometry(brush2, null, geometry);
				}
				finally
				{
					drawingContext.Pop();
				}
			}
		}
		state = State;
		if (state == ElementChromeState.Normal)
		{
			return;
		}
		Brush brush3 = Wxu(state);
		double num2 = hx7(state);
		if (brush3 == null || num2 == 0.0)
		{
			return;
		}
		drawingContext.PushOpacity(num2);
		try
		{
			drawingContext.DrawGeometry(brush3, null, geometry);
		}
		finally
		{
			drawingContext.Pop();
		}
	}

	internal void RenderBorder(DrawingContext drawingContext, Geometry geometry)
	{
		Thickness borderThickness = BorderThickness;
		double num = Math.Max(borderThickness.Left, Math.Max(borderThickness.Top, Math.Max(borderThickness.Right, borderThickness.Bottom)));
		if (num == 0.0)
		{
			return;
		}
		ElementChromeState state = State;
		if (state == ElementChromeState.Disabled || !base.IsAnimationEnabledResolved)
		{
			Brush brush = Ix2(State) ?? Ix2(ElementChromeState.Normal);
			drawingContext.DrawGeometry(null, new Pen(brush, num), geometry);
			return;
		}
		drawingContext.DrawGeometry(null, new Pen(BorderBrush, num), geometry);
		state = LastState;
		if (state != ElementChromeState.Normal && state != ElementChromeState.Disabled)
		{
			Brush brush2 = Ix2(state);
			double num2 = hx7(state);
			if (brush2 != null && num2 != 0.0)
			{
				drawingContext.PushOpacity(num2);
				try
				{
					drawingContext.DrawGeometry(null, new Pen(brush2, num), geometry);
				}
				finally
				{
					drawingContext.Pop();
				}
			}
		}
		state = State;
		if (state == ElementChromeState.Normal)
		{
			return;
		}
		Brush brush3 = Ix2(state);
		double num3 = hx7(state);
		if (brush3 == null || num3 == 0.0)
		{
			return;
		}
		drawingContext.PushOpacity(num3);
		try
		{
			drawingContext.DrawGeometry(null, new Pen(brush3, num), geometry);
		}
		finally
		{
			drawingContext.Pop();
		}
	}

	private void mxo(DrawingContext P_0, Rect P_1)
	{
		ElementChromeState state = State;
		Thickness borderThickness = BorderThickness;
		if (state == ElementChromeState.Pressed)
		{
			P_0.DrawGeometry(null, new Pen(SystemColors.ControlDarkBrush, 1.0), new RectangleGeometry(P_1));
			return;
		}
		SolidColorBrush controlLightBrush = SystemColors.ControlLightBrush;
		SolidColorBrush controlDarkDarkBrush = SystemColors.ControlDarkDarkBrush;
		if (borderThickness.Right != 0.0)
		{
			P_0.DrawRectangle(controlDarkDarkBrush, null, new Rect(P_1.Right - 1.0, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Bottom != 0.0)
		{
			P_0.DrawRectangle(controlDarkDarkBrush, null, new Rect(P_1.Left, P_1.Bottom - 1.0, P_1.Width, 1.0));
		}
		if (borderThickness.Left != 0.0)
		{
			P_0.DrawRectangle(controlLightBrush, null, new Rect(P_1.Left, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Top != 0.0)
		{
			P_0.DrawRectangle(controlLightBrush, null, new Rect(P_1.Left, P_1.Top, P_1.Width, 1.0));
		}
		if (borderThickness.Left != 0.0)
		{
			P_1.X += 1.0;
			P_1.Width -= 1.0;
		}
		if (borderThickness.Top != 0.0)
		{
			P_1.Y += 1.0;
			P_1.Height -= 1.0;
		}
		if (borderThickness.Right != 0.0)
		{
			P_1.Width -= 1.0;
		}
		if (borderThickness.Bottom != 0.0)
		{
			P_1.Height -= 1.0;
		}
		controlLightBrush = SystemColors.ControlLightLightBrush;
		controlDarkDarkBrush = SystemColors.ControlDarkBrush;
		if (borderThickness.Right >= 2.0)
		{
			P_0.DrawRectangle(controlDarkDarkBrush, null, new Rect(P_1.Right - 1.0, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Bottom >= 2.0)
		{
			P_0.DrawRectangle(controlDarkDarkBrush, null, new Rect(P_1.Left, P_1.Bottom - 1.0, P_1.Width, 1.0));
		}
		if (borderThickness.Left >= 2.0)
		{
			P_0.DrawRectangle(controlLightBrush, null, new Rect(P_1.Left, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Top >= 2.0)
		{
			P_0.DrawRectangle(controlLightBrush, null, new Rect(P_1.Left, P_1.Top, P_1.Width, 1.0));
		}
	}

	private void KxQ(DrawingContext P_0, Rect P_1)
	{
		Thickness borderThickness = BorderThickness;
		SolidColorBrush controlLightLightBrush = SystemColors.ControlLightLightBrush;
		SolidColorBrush controlDarkBrush = SystemColors.ControlDarkBrush;
		if (borderThickness.Right != 0.0)
		{
			P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Right - 1.0, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Bottom != 0.0)
		{
			P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Left, P_1.Bottom - 1.0, P_1.Width, 1.0));
		}
		if (borderThickness.Left != 0.0)
		{
			P_0.DrawRectangle(controlDarkBrush, null, new Rect(P_1.Left, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Top != 0.0)
		{
			P_0.DrawRectangle(controlDarkBrush, null, new Rect(P_1.Left, P_1.Top, P_1.Width, 1.0));
		}
		if (borderThickness.Left != 0.0)
		{
			P_1.X += 1.0;
			P_1.Width -= 1.0;
		}
		if (borderThickness.Top != 0.0)
		{
			P_1.Y += 1.0;
			P_1.Height -= 1.0;
		}
		if (borderThickness.Right != 0.0)
		{
			P_1.Width -= 1.0;
		}
		if (borderThickness.Bottom != 0.0)
		{
			P_1.Height -= 1.0;
		}
		if (borderThickness.Right >= 2.0)
		{
			P_0.DrawRectangle(controlDarkBrush, null, new Rect(P_1.Right - 1.0, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Bottom >= 2.0)
		{
			P_0.DrawRectangle(controlDarkBrush, null, new Rect(P_1.Left, P_1.Bottom - 1.0, P_1.Width, 1.0));
		}
		if (borderThickness.Left >= 2.0)
		{
			P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Left, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Top >= 2.0)
		{
			P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Left, P_1.Top, P_1.Width, 1.0));
		}
	}

	private void VxO(DrawingContext P_0, Rect P_1)
	{
		ElementChromeState state = State;
		Thickness borderThickness = BorderThickness;
		if ((state == ElementChromeState.Checked || state == ElementChromeState.Defaulted || state == ElementChromeState.Focused || state == ElementChromeState.Pressed) && borderThickness.Left >= 3.0)
		{
			SolidColorBrush windowFrameBrush = SystemColors.WindowFrameBrush;
			P_0.DrawRectangle(windowFrameBrush, null, new Rect(P_1.Left, P_1.Top, 1.0, P_1.Height));
			P_0.DrawRectangle(windowFrameBrush, null, new Rect(P_1.Left, P_1.Top, P_1.Width, 1.0));
			P_0.DrawRectangle(windowFrameBrush, null, new Rect(P_1.Right - 1.0, P_1.Top, 1.0, P_1.Height));
			P_0.DrawRectangle(windowFrameBrush, null, new Rect(P_1.Left, P_1.Bottom - 1.0, P_1.Width, 1.0));
			P_1.Inflate(-1.0, -1.0);
		}
		if (state == ElementChromeState.Pressed)
		{
			P_0.DrawGeometry(null, new Pen(SystemColors.ControlDarkBrush, 1.0), new RectangleGeometry(P_1));
			return;
		}
		SolidColorBrush controlLightLightBrush = SystemColors.ControlLightLightBrush;
		SolidColorBrush controlDarkDarkBrush = SystemColors.ControlDarkDarkBrush;
		if (borderThickness.Left != 0.0)
		{
			P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Left, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Top != 0.0)
		{
			P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Left, P_1.Top, P_1.Width, 1.0));
		}
		if (borderThickness.Right != 0.0)
		{
			P_0.DrawRectangle(controlDarkDarkBrush, null, new Rect(P_1.Right - 1.0, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Bottom != 0.0)
		{
			P_0.DrawRectangle(controlDarkDarkBrush, null, new Rect(P_1.Left, P_1.Bottom - 1.0, P_1.Width, 1.0));
		}
		if (borderThickness.Left != 0.0)
		{
			P_1.X += 1.0;
			P_1.Width -= 1.0;
		}
		if (borderThickness.Top != 0.0)
		{
			P_1.Y += 1.0;
			P_1.Height -= 1.0;
		}
		if (borderThickness.Right != 0.0)
		{
			P_1.Width -= 1.0;
		}
		if (borderThickness.Bottom != 0.0)
		{
			P_1.Height -= 1.0;
		}
		controlLightLightBrush = SystemColors.ControlLightBrush;
		controlDarkDarkBrush = SystemColors.ControlDarkBrush;
		if (borderThickness.Left >= 2.0)
		{
			P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Left, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Top >= 2.0)
		{
			P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Left, P_1.Top, P_1.Width, 1.0));
		}
		if (borderThickness.Right >= 2.0)
		{
			P_0.DrawRectangle(controlDarkDarkBrush, null, new Rect(P_1.Right - 1.0, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Bottom >= 2.0)
		{
			P_0.DrawRectangle(controlDarkDarkBrush, null, new Rect(P_1.Left, P_1.Bottom - 1.0, P_1.Width, 1.0));
		}
	}

	private void Rx0(DrawingContext P_0, Rect P_1)
	{
		Thickness borderThickness = BorderThickness;
		SolidColorBrush controlLightLightBrush = SystemColors.ControlLightLightBrush;
		SolidColorBrush controlDarkBrush = SystemColors.ControlDarkBrush;
		if (borderThickness.Right != 0.0)
		{
			P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Right - 1.0, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Bottom != 0.0)
		{
			P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Left, P_1.Bottom - 1.0, P_1.Width, 1.0));
		}
		if (borderThickness.Left != 0.0)
		{
			P_0.DrawRectangle(controlDarkBrush, null, new Rect(P_1.Left, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Top != 0.0)
		{
			P_0.DrawRectangle(controlDarkBrush, null, new Rect(P_1.Left, P_1.Top, P_1.Width, 1.0));
		}
		if (borderThickness.Left != 0.0)
		{
			P_1.X += 1.0;
			P_1.Width -= 1.0;
		}
		if (borderThickness.Top != 0.0)
		{
			P_1.Y += 1.0;
			P_1.Height -= 1.0;
		}
		if (borderThickness.Right != 0.0)
		{
			P_1.Width -= 1.0;
		}
		if (borderThickness.Bottom != 0.0)
		{
			P_1.Height -= 1.0;
		}
		controlLightLightBrush = SystemColors.ControlLightBrush;
		controlDarkBrush = SystemColors.ControlDarkDarkBrush;
		if (borderThickness.Right >= 2.0)
		{
			P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Right - 1.0, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Bottom >= 2.0)
		{
			P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Left, P_1.Bottom - 1.0, P_1.Width, 1.0));
		}
		if (borderThickness.Left >= 2.0)
		{
			P_0.DrawRectangle(controlDarkBrush, null, new Rect(P_1.Left, P_1.Top, 1.0, P_1.Height));
		}
		if (borderThickness.Top >= 2.0)
		{
			P_0.DrawRectangle(controlDarkBrush, null, new Rect(P_1.Left, P_1.Top, P_1.Width, 1.0));
		}
	}

	private void txk(DrawingContext P_0, Rect P_1)
	{
		ElementChromeState state = State;
		Thickness borderThickness = BorderThickness;
		SolidColorBrush controlLightLightBrush = SystemColors.ControlLightLightBrush;
		SolidColorBrush controlDarkBrush = SystemColors.ControlDarkBrush;
		if (state == ElementChromeState.Pressed)
		{
			if (borderThickness.Left != 0.0)
			{
				P_0.DrawRectangle(controlDarkBrush, null, new Rect(P_1.Left, P_1.Top, 1.0, P_1.Height));
			}
			if (borderThickness.Top != 0.0)
			{
				P_0.DrawRectangle(controlDarkBrush, null, new Rect(P_1.Left, P_1.Top, P_1.Width, 1.0));
			}
			if (borderThickness.Right != 0.0)
			{
				P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Right - 1.0, P_1.Top, 1.0, P_1.Height));
			}
			if (borderThickness.Bottom != 0.0)
			{
				P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Left, P_1.Bottom - 1.0, P_1.Width, 1.0));
			}
		}
		else
		{
			if (borderThickness.Left != 0.0)
			{
				P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Left, P_1.Top, 1.0, P_1.Height));
			}
			if (borderThickness.Top != 0.0)
			{
				P_0.DrawRectangle(controlLightLightBrush, null, new Rect(P_1.Left, P_1.Top, P_1.Width, 1.0));
			}
			if (borderThickness.Right != 0.0)
			{
				P_0.DrawRectangle(controlDarkBrush, null, new Rect(P_1.Right - 1.0, P_1.Top, 1.0, P_1.Height));
			}
			if (borderThickness.Bottom != 0.0)
			{
				P_0.DrawRectangle(controlDarkBrush, null, new Rect(P_1.Left, P_1.Bottom - 1.0, P_1.Width, 1.0));
			}
		}
	}

	internal void RenderHighlight(DrawingContext drawingContext, Geometry geometry)
	{
		Brush brush = GetHighlightForState(State) ?? GetHighlightForState(ElementChromeState.Normal);
		if (brush != null)
		{
			drawingContext.DrawGeometry(brush, null, geometry);
		}
	}

	internal void RenderInnerBorder(DrawingContext drawingContext, Rect bounds)
	{
		Brush brush = jxe(State) ?? jxe(ElementChromeState.Normal);
		Thickness borderThickness = BorderThickness;
		Thickness innerBorderThickness = InnerBorderThickness;
		Geometry geometry;
		bool flag;
		int num;
		if (brush != null && !innerBorderThickness.IsEffectivelyZero())
		{
			Thickness offset = new Thickness
			{
				Left = borderThickness.Left + innerBorderThickness.Left / 2.0,
				Top = borderThickness.Top + innerBorderThickness.Top / 2.0,
				Right = borderThickness.Right + innerBorderThickness.Right / 2.0,
				Bottom = borderThickness.Bottom + innerBorderThickness.Bottom / 2.0
			};
			CornerRadius cornerRadius = new CornerRadius(Math.Max(CornerRadius.TopLeft - 1.0, 0.0), Math.Max(CornerRadius.TopRight - 1.0, 0.0), Math.Max(CornerRadius.BottomRight - 1.0, 0.0), Math.Max(CornerRadius.BottomLeft - 1.0, 0.0));
			geometry = CreateRectangleGeometry(bounds, innerBorderThickness, offset, cornerRadius);
			flag = geometry != null;
			num = 1;
			if (obH() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		return;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
			{
				if (!flag)
				{
					return;
				}
				double thickness = Math.Min(innerBorderThickness.Left, Math.Min(innerBorderThickness.Top, Math.Min(innerBorderThickness.Right, innerBorderThickness.Bottom)));
				drawingContext.DrawGeometry(null, new Pen(brush, thickness), geometry);
				num = 0;
				if (obH() == null)
				{
					break;
				}
				goto end_IL_0009;
			}
			case 0:
				return;
			}
			continue;
			end_IL_0009:
			break;
		}
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	protected override Size ArrangeOverride(Size arrangeSize)
	{
		UIElement child = Child;
		if (child != null)
		{
			Thickness padding = Padding;
			Thickness borderThickness = BorderThickness;
			ElementChromeBorderStyle borderStyle = BorderStyle;
			double num = borderThickness.Left + padding.Left;
			double num2 = borderThickness.Top + padding.Top;
			double num3 = borderThickness.Left + borderThickness.Right + padding.Left + padding.Right;
			double num4 = borderThickness.Top + borderThickness.Bottom + padding.Top + padding.Bottom;
			if (borderStyle == ElementChromeBorderStyle.Default)
			{
				Thickness innerBorderThickness = InnerBorderThickness;
				num += innerBorderThickness.Left;
				num2 += innerBorderThickness.Top;
				num3 += innerBorderThickness.Left + innerBorderThickness.Right;
				num4 += innerBorderThickness.Top + innerBorderThickness.Bottom;
			}
			Rect finalRect = new Rect(num, num2, Math.Max(0.0, arrangeSize.Width - num3), Math.Max(0.0, arrangeSize.Height - num4));
			ElementChromeBorderStyle elementChromeBorderStyle = borderStyle;
			ElementChromeBorderStyle elementChromeBorderStyle2 = elementChromeBorderStyle;
			if ((elementChromeBorderStyle2 == ElementChromeBorderStyle.Raised || (uint)(elementChromeBorderStyle2 - 5) <= 1u) && State == ElementChromeState.Pressed)
			{
				finalRect.X++;
				finalRect.Y++;
			}
			child.Arrange(finalRect);
		}
		return arrangeSize;
	}

	protected override Size MeasureOverride(Size constraint)
	{
		Thickness padding = Padding;
		Thickness borderThickness = BorderThickness;
		double num = borderThickness.Left + borderThickness.Right + padding.Left + padding.Right;
		double num2 = borderThickness.Top + borderThickness.Bottom + padding.Top + padding.Bottom;
		if (BorderStyle == ElementChromeBorderStyle.Default)
		{
			Thickness innerBorderThickness = InnerBorderThickness;
			num += innerBorderThickness.Left + innerBorderThickness.Right;
			num2 += innerBorderThickness.Top + innerBorderThickness.Bottom;
		}
		UIElement child = Child;
		if (child != null)
		{
			bool flag = constraint.Width < num;
			bool flag2 = constraint.Height < num2;
			Size availableSize = default(Size);
			if (!flag)
			{
				availableSize.Width = constraint.Width - num;
			}
			if (!flag2)
			{
				availableSize.Height = constraint.Height - num2;
			}
			child.Measure(availableSize);
			Size desiredSize = child.DesiredSize;
			if (!flag)
			{
				desiredSize.Width += num;
			}
			if (!flag2)
			{
				desiredSize.Height += num2;
			}
			return desiredSize;
		}
		return new Size(Math.Min(num, constraint.Width), Math.Min(num2, constraint.Height));
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		Rect rect = new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight);
		if (rect.Width == 0.0 || rect.Height == 0.0)
		{
			return;
		}
		Thickness borderThickness = BorderThickness;
		Thickness offset = new Thickness
		{
			Left = borderThickness.Left / 2.0,
			Top = borderThickness.Top / 2.0,
			Right = borderThickness.Right / 2.0,
			Bottom = borderThickness.Bottom / 2.0
		};
		Geometry geometry = CreateRectangleGeometry(rect, borderThickness, offset, CornerRadius);
		if (geometry != null)
		{
			RenderBackground(drawingContext, geometry);
			RenderHighlight(drawingContext, geometry);
			switch (BorderStyle)
			{
			case ElementChromeBorderStyle.None:
				break;
			case ElementChromeBorderStyle.Etched:
				KxQ(drawingContext, rect);
				break;
			case ElementChromeBorderStyle.Raised:
				VxO(drawingContext, rect);
				break;
			case ElementChromeBorderStyle.Sunken:
				Rx0(drawingContext, rect);
				break;
			case ElementChromeBorderStyle.AlternateRaised:
				mxo(drawingContext, rect);
				break;
			case ElementChromeBorderStyle.ThinRaised:
				txk(drawingContext, rect);
				break;
			default:
				RenderInnerBorder(drawingContext, rect);
				RenderBorder(drawingContext, geometry);
				break;
			}
		}
	}

	public ElementChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static ElementChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		Nxq = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117922), typeof(ElementChromeState), typeof(ElementChrome), new FrameworkPropertyMetadata(ElementChromeState.Normal));
		BackgroundProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117944), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BackgroundCheckedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117968), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BackgroundDefaultedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120432), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BackgroundDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118106), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BackgroundFocusedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120474), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BackgroundHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118146), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BackgroundPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118180), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118218), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushCheckedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118244), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushDefaultedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120512), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118388), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushFocusedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120556), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118430), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118466), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderStyleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118506), typeof(ElementChromeBorderStyle), typeof(ElementChrome), new FrameworkPropertyMetadata(ElementChromeBorderStyle.Default, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderThicknessProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114074), typeof(Thickness), typeof(ElementChrome), new FrameworkPropertyMetadata(default(Thickness), FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange | FrameworkPropertyMetadataOptions.AffectsRender));
		CornerRadiusProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97530), typeof(CornerRadius), typeof(ElementChrome), new FrameworkPropertyMetadata(default(CornerRadius), FrameworkPropertyMetadataOptions.AffectsRender));
		HighlightProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120596), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		HighlightCheckedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120618), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		HighlightDefaultedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120654), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		HighlightDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120694), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		HighlightFocusedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120732), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		HighlightHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120768), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		HighlightPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120800), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBorderBrushProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119650), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBorderBrushCheckedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120836), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBorderBrushDefaultedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120886), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBorderBrushDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119686), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBorderBrushFocusedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120940), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBorderBrushHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119738), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBorderBrushPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119784), typeof(Brush), typeof(ElementChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBorderThicknessProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97592), typeof(Thickness), typeof(ElementChrome), new FrameworkPropertyMetadata(default(Thickness), FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange | FrameworkPropertyMetadataOptions.AffectsRender));
		LastStateProperty = Nxq.DependencyProperty;
		PaddingProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120990), typeof(Thickness), typeof(ElementChrome), new FrameworkPropertyMetadata(default(Thickness), FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange));
		StateProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97386), typeof(ElementChromeState), typeof(ElementChrome), new FrameworkPropertyMetadata(ElementChromeState.Normal, FrameworkPropertyMetadataOptions.AffectsRender, exF));
		DxW = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121008), typeof(double), typeof(ElementChrome), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender), (object o) => ValidationHelper.ValidateDoubleIsBetweenInclusive(o, 0.0, 1.0));
		gxU = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121050), typeof(double), typeof(ElementChrome), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender), (object o) => ValidationHelper.ValidateDoubleIsBetweenInclusive(o, 0.0, 1.0));
		ExH = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121096), typeof(double), typeof(ElementChrome), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender), (object o) => ValidationHelper.ValidateDoubleIsBetweenInclusive(o, 0.0, 1.0));
		Ex6 = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119884), typeof(double), typeof(ElementChrome), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender), (object o) => ValidationHelper.ValidateDoubleIsBetweenInclusive(o, 0.0, 1.0));
		LxV = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119922), typeof(double), typeof(ElementChrome), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender), (object o) => ValidationHelper.ValidateDoubleIsBetweenInclusive(o, 0.0, 1.0));
	}

	internal static bool nb7()
	{
		return obf == null;
	}

	internal static ElementChrome obH()
	{
		return obf;
	}
}
