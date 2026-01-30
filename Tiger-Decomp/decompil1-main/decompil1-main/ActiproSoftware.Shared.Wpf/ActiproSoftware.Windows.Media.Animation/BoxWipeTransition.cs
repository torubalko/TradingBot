using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public class BoxWipeTransition : StoryboardTransitionBase
{
	public static readonly DependencyProperty BeginTimeProperty;

	public static readonly DependencyProperty DirectionProperty;

	public static readonly DependencyProperty DurationProperty;

	public static readonly DependencyProperty ModeProperty;

	private static BoxWipeTransition P7p;

	public TimeSpan BeginTime
	{
		get
		{
			return (TimeSpan)GetValue(BeginTimeProperty);
		}
		set
		{
			SetValue(BeginTimeProperty, value);
		}
	}

	public TransitionDirection Direction
	{
		get
		{
			return (TransitionDirection)GetValue(DirectionProperty);
		}
		set
		{
			SetValue(DirectionProperty, value);
		}
	}

	public Duration Duration
	{
		get
		{
			return (Duration)GetValue(DurationProperty);
		}
		set
		{
			SetValue(DurationProperty, value);
		}
	}

	public TransitionMode Mode
	{
		get
		{
			return (TransitionMode)GetValue(ModeProperty);
		}
		set
		{
			SetValue(ModeProperty, value);
		}
	}

	private Storyboard zQa(TransitionPresenter P_0)
	{
		Duration duration = ((Duration == Duration.Automatic && P_0 != null) ? P_0.DefaultDuration : Duration);
		if (!duration.HasTimeSpan)
		{
			duration = new Duration(TimeSpan.FromMilliseconds(500.0));
		}
		Storyboard storyboard = new Storyboard();
		storyboard.BeginTime = BeginTime;
		storyboard.FillBehavior = FillBehavior.Stop;
		DoubleAnimation doubleAnimation = new DoubleAnimation((Mode != TransitionMode.In) ? 1 : 0, (Mode == TransitionMode.In) ? 1 : 0, duration);
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107954)));
		storyboard.Children.Add(doubleAnimation);
		doubleAnimation = new DoubleAnimation(doubleAnimation.From.Value, doubleAnimation.To.Value, duration);
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108014)));
		storyboard.Children.Add(doubleAnimation);
		return storyboard;
	}

	private Style uQq(TransitionPresenter P_0, FrameworkElement P_1)
	{
		int num = 1;
		int num2 = num;
		TransitionDirection resolvedDirection = default(TransitionDirection);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				Point directionStartPoint = BarWipeTransition.GetDirectionStartPoint(resolvedDirection);
				Style style = new Style(typeof(FrameworkElement));
				DrawingBrush drawingBrush = new DrawingBrush();
				drawingBrush.Drawing = new GeometryDrawing(Brushes.Black, null, new RectangleGeometry(new Rect(0.0, 0.0, 1.0, 1.0)));
				drawingBrush.Transform = new ScaleTransform((Mode != TransitionMode.In) ? 1 : 0, (Mode != TransitionMode.In) ? 1 : 0, directionStartPoint.X * P_1.ActualWidth, directionStartPoint.Y * P_1.ActualHeight);
				style.Setters.Add(new Setter(UIElement.OpacityMaskProperty, drawingBrush));
				return style;
			}
			case 1:
				resolvedDirection = Transition.GetResolvedDirection(Direction, P_0?.DefaultDirection ?? TransitionDirection.Default);
				num2 = 0;
				if (b7h())
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static void jQW(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		BoxWipeTransition boxWipeTransition = (BoxWipeTransition)P_0;
		boxWipeTransition.IsToContentTopMost = boxWipeTransition.Mode == TransitionMode.In;
	}

	protected override Storyboard GetFromContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.Out) ? zQa(presenter) : null;
	}

	protected override Style GetFromContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.Out) ? uQq(presenter, content) : null;
	}

	public override Transition GetOppositeTransition()
	{
		BoxWipeTransition boxWipeTransition = (BoxWipeTransition)Clone();
		boxWipeTransition.Mode = Transition.GetOppositeMode(Mode);
		return boxWipeTransition;
	}

	protected override Storyboard GetToContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.In) ? zQa(presenter) : null;
	}

	protected override Style GetToContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.In) ? uQq(presenter, content) : null;
	}

	public BoxWipeTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static BoxWipeTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		BeginTimeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107862), typeof(TimeSpan), typeof(BoxWipeTransition), new FrameworkPropertyMetadata(TimeSpan.Zero));
		DirectionProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107884), typeof(TransitionDirection), typeof(BoxWipeTransition), new FrameworkPropertyMetadata(TransitionDirection.Default));
		DurationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107906), typeof(Duration), typeof(BoxWipeTransition), new FrameworkPropertyMetadata(Duration.Automatic));
		ModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107926), typeof(TransitionMode), typeof(BoxWipeTransition), new FrameworkPropertyMetadata(TransitionMode.In, jQW));
	}

	internal static bool b7h()
	{
		return P7p == null;
	}

	internal static BoxWipeTransition G7P()
	{
		return P7p;
	}
}
