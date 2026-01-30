using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using ActiproSoftware.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public class BarWipeTransition : StoryboardTransitionBase
{
	public static readonly DependencyProperty BeginTimeProperty;

	public static readonly DependencyProperty DirectionProperty;

	public static readonly DependencyProperty DurationProperty;

	public static readonly DependencyProperty ModeProperty;

	public static readonly DependencyProperty SpreadProperty;

	internal static BarWipeTransition F74;

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

	public double Spread
	{
		get
		{
			return (double)GetValue(SpreadProperty);
		}
		set
		{
			SetValue(SpreadProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "obj")]
	private static object rQx(DependencyObject P_0, object P_1)
	{
		return Math.Max(0.0, Math.Min(1.0, (double)P_1));
	}

	private Storyboard BQr(TransitionPresenter P_0)
	{
		Duration duration = ((Duration == Duration.Automatic && P_0 != null) ? P_0.DefaultDuration : Duration);
		if (!duration.HasTimeSpan)
		{
			duration = new Duration(TimeSpan.FromMilliseconds(500.0));
		}
		double spread = Spread;
		double num = duration.TimeSpan.TotalMilliseconds * spread / 2.0;
		Storyboard storyboard = new Storyboard();
		storyboard.BeginTime = BeginTime;
		storyboard.FillBehavior = FillBehavior.Stop;
		DoubleAnimation doubleAnimation = new DoubleAnimation();
		doubleAnimation.BeginTime = TimeSpan.FromMilliseconds(num);
		doubleAnimation.By = 1.0;
		doubleAnimation.Duration = TimeSpan.FromMilliseconds(duration.TimeSpan.TotalMilliseconds - num);
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107342)));
		storyboard.Children.Add(doubleAnimation);
		doubleAnimation = new DoubleAnimation();
		doubleAnimation.By = 1.0;
		doubleAnimation.Duration = TimeSpan.FromMilliseconds(duration.TimeSpan.TotalMilliseconds - num);
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107472)));
		storyboard.Children.Add(doubleAnimation);
		return storyboard;
	}

	private Style lQZ(TransitionPresenter P_0)
	{
		TransitionDirection resolvedDirection = Transition.GetResolvedDirection(Direction, P_0?.DefaultDirection ?? TransitionDirection.Default);
		Style style = new Style(typeof(FrameworkElement));
		LinearGradientBrush linearGradientBrush = new LinearGradientBrush();
		linearGradientBrush.StartPoint = ((Mode == TransitionMode.In) ? GetDirectionStartPoint(resolvedDirection) : GetDirectionEndPoint(resolvedDirection));
		linearGradientBrush.EndPoint = ((Mode == TransitionMode.In) ? GetDirectionEndPoint(resolvedDirection) : GetDirectionStartPoint(resolvedDirection));
		linearGradientBrush.GradientStops.Add(new GradientStop
		{
			Color = ((Mode == TransitionMode.In) ? Colors.Black : Colors.Transparent),
			Offset = 0.0
		});
		int num = 0;
		if (!J7s())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			linearGradientBrush.GradientStops.Add(new GradientStop
			{
				Color = ((Mode == TransitionMode.In) ? Colors.Transparent : Colors.Black),
				Offset = 0.0
			});
			style.Setters.Add(new Setter(UIElement.OpacityMaskProperty, linearGradientBrush));
			return style;
		}
	}

	internal static Point GetDirectionEndPoint(TransitionDirection direction)
	{
		int num = 1;
		TransitionDirection transitionDirection = default(TransitionDirection);
		Point result = default(Point);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					transitionDirection = direction;
					num2 = 0;
					if (J7s())
					{
						continue;
					}
					break;
				default:
					switch (transitionDirection)
					{
					case TransitionDirection.ForwardUp:
						break;
					case TransitionDirection.ForwardDown:
						goto IL_005f;
					case TransitionDirection.Down:
						goto IL_007d;
					case TransitionDirection.Backward:
						goto IL_00d3;
					default:
						goto IL_0149;
					case TransitionDirection.BackwardUp:
						goto IL_0167;
					case TransitionDirection.BackwardDown:
						goto IL_018f;
					case TransitionDirection.Forward:
						goto IL_01ad;
					}
					result = new Point(1.0, 0.0);
					goto case 2;
				case 2:
					{
						return result;
					}
					IL_01ad:
					result = new Point(1.0, 0.5);
					goto case 2;
					IL_018f:
					result = new Point(0.0, 1.0);
					goto case 2;
					IL_0167:
					result = new Point(0.0, 0.0);
					goto case 2;
					IL_0149:
					result = new Point(0.5, 0.0);
					goto case 2;
					IL_00d3:
					result = new Point(0.0, 0.5);
					goto case 2;
					IL_007d:
					result = new Point(0.5, 1.0);
					num2 = 2;
					if (N7i() == null)
					{
						continue;
					}
					break;
					IL_005f:
					result = new Point(1.0, 1.0);
					goto case 2;
				}
				break;
			}
		}
	}

	internal static Point GetDirectionStartPoint(TransitionDirection direction)
	{
		Point result;
		int num;
		switch (direction)
		{
		case TransitionDirection.BackwardUp:
			result = new Point(1.0, 1.0);
			num = 1;
			if (J7s())
			{
				num = 1;
			}
			goto IL_0009;
		case TransitionDirection.Backward:
			result = new Point(1.0, 0.5);
			break;
		case TransitionDirection.BackwardDown:
			result = new Point(1.0, 0.0);
			break;
		case TransitionDirection.ForwardUp:
			result = new Point(0.0, 1.0);
			break;
		default:
			result = new Point(0.5, 1.0);
			break;
		case TransitionDirection.ForwardDown:
			result = new Point(0.0, 0.0);
			num = 0;
			if (!J7s())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0009;
		case TransitionDirection.Down:
			result = new Point(0.5, 0.0);
			break;
		case TransitionDirection.Forward:
			{
				result = new Point(0.0, 0.5);
				break;
			}
			IL_0009:
			switch (num)
			{
			}
			break;
		}
		return result;
	}

	private static void JQn(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		BarWipeTransition barWipeTransition = (BarWipeTransition)P_0;
		barWipeTransition.IsToContentTopMost = barWipeTransition.Mode == TransitionMode.In;
	}

	protected override Storyboard GetFromContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.Out) ? BQr(presenter) : null;
	}

	protected override Style GetFromContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.Out) ? lQZ(presenter) : null;
	}

	public override Transition GetOppositeTransition()
	{
		BarWipeTransition barWipeTransition = (BarWipeTransition)Clone();
		barWipeTransition.Mode = Transition.GetOppositeMode(Mode);
		return barWipeTransition;
	}

	protected override Storyboard GetToContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.In) ? BQr(presenter) : null;
	}

	protected override Style GetToContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.In) ? lQZ(presenter) : null;
	}

	public BarWipeTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static BarWipeTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		BeginTimeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107862), typeof(TimeSpan), typeof(BarWipeTransition), new FrameworkPropertyMetadata(TimeSpan.Zero));
		DirectionProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107884), typeof(TransitionDirection), typeof(BarWipeTransition), new FrameworkPropertyMetadata(TransitionDirection.Default));
		DurationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107906), typeof(Duration), typeof(BarWipeTransition), new FrameworkPropertyMetadata(Duration.Automatic));
		ModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107926), typeof(TransitionMode), typeof(BarWipeTransition), new FrameworkPropertyMetadata(TransitionMode.In, JQn));
		SpreadProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107938), typeof(double), typeof(BarWipeTransition), new FrameworkPropertyMetadata(0.25, null, rQx), ValidationHelper.ValidateDoubleIsPercentage);
	}

	internal static bool J7s()
	{
		return F74 == null;
	}

	internal static BarWipeTransition N7i()
	{
		return F74;
	}
}
