using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using ActiproSoftware.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public class BarnDoorWipeTransition : StoryboardTransitionBase
{
	public static readonly DependencyProperty BeginTimeProperty;

	public static readonly DependencyProperty DirectionProperty;

	public static readonly DependencyProperty DurationProperty;

	public static readonly DependencyProperty ModeProperty;

	public static readonly DependencyProperty SpreadProperty;

	internal static BarnDoorWipeTransition W7X;

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
	private static object lQA(DependencyObject P_0, object P_1)
	{
		return Math.Max(0.0, Math.Min(1.0, (double)P_1));
	}

	private Storyboard PQC(TransitionPresenter P_0)
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
		double num2 = ((Mode == TransitionMode.In) ? 1 : (-1));
		DoubleAnimation doubleAnimation = new DoubleAnimation();
		doubleAnimation.BeginTime = TimeSpan.FromMilliseconds((Mode == TransitionMode.In) ? 0.0 : num);
		doubleAnimation.By = num2 * -0.5;
		doubleAnimation.Duration = TimeSpan.FromMilliseconds(duration.TimeSpan.TotalMilliseconds - num);
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107342)));
		storyboard.Children.Add(doubleAnimation);
		doubleAnimation = new DoubleAnimation();
		doubleAnimation.BeginTime = TimeSpan.FromMilliseconds((Mode == TransitionMode.In) ? num : 0.0);
		doubleAnimation.By = num2 * -0.5;
		doubleAnimation.Duration = TimeSpan.FromMilliseconds(duration.TimeSpan.TotalMilliseconds - num);
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107472)));
		storyboard.Children.Add(doubleAnimation);
		doubleAnimation = new DoubleAnimation();
		doubleAnimation.BeginTime = TimeSpan.FromMilliseconds((Mode == TransitionMode.In) ? num : 0.0);
		doubleAnimation.By = num2 * 0.5;
		doubleAnimation.Duration = TimeSpan.FromMilliseconds(duration.TimeSpan.TotalMilliseconds - num);
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107602)));
		storyboard.Children.Add(doubleAnimation);
		doubleAnimation = new DoubleAnimation();
		doubleAnimation.BeginTime = TimeSpan.FromMilliseconds((Mode == TransitionMode.In) ? 0.0 : num);
		doubleAnimation.By = num2 * 0.5;
		doubleAnimation.Duration = TimeSpan.FromMilliseconds(duration.TimeSpan.TotalMilliseconds - num);
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107732)));
		storyboard.Children.Add(doubleAnimation);
		return storyboard;
	}

	private Style wQY(TransitionPresenter P_0)
	{
		TransitionDirection resolvedDirection = Transition.GetResolvedDirection(Direction, P_0?.DefaultDirection ?? TransitionDirection.Default);
		Style style = new Style(typeof(FrameworkElement));
		LinearGradientBrush linearGradientBrush = new LinearGradientBrush();
		linearGradientBrush.StartPoint = ((Mode == TransitionMode.In) ? BarWipeTransition.GetDirectionEndPoint(resolvedDirection) : BarWipeTransition.GetDirectionStartPoint(resolvedDirection));
		linearGradientBrush.EndPoint = ((Mode == TransitionMode.In) ? BarWipeTransition.GetDirectionStartPoint(resolvedDirection) : BarWipeTransition.GetDirectionEndPoint(resolvedDirection));
		linearGradientBrush.GradientStops.Add(new GradientStop
		{
			Color = Colors.Transparent,
			Offset = ((Mode == TransitionMode.In) ? 0.5 : 0.0)
		});
		linearGradientBrush.GradientStops.Add(new GradientStop
		{
			Color = Colors.Black,
			Offset = ((Mode == TransitionMode.In) ? 0.5 : 0.0)
		});
		linearGradientBrush.GradientStops.Add(new GradientStop
		{
			Color = Colors.Black,
			Offset = ((Mode == TransitionMode.In) ? 0.5 : 1.0)
		});
		linearGradientBrush.GradientStops.Add(new GradientStop
		{
			Color = Colors.Transparent,
			Offset = ((Mode == TransitionMode.In) ? 0.5 : 1.0)
		});
		style.Setters.Add(new Setter(UIElement.OpacityMaskProperty, linearGradientBrush));
		return style;
	}

	private static void uQI(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		BarnDoorWipeTransition barnDoorWipeTransition = (BarnDoorWipeTransition)P_0;
		barnDoorWipeTransition.IsToContentTopMost = barnDoorWipeTransition.Mode == TransitionMode.In;
	}

	protected override Storyboard GetFromContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.Out) ? PQC(presenter) : null;
	}

	protected override Style GetFromContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.Out) ? wQY(presenter) : null;
	}

	public override Transition GetOppositeTransition()
	{
		BarnDoorWipeTransition barnDoorWipeTransition = (BarnDoorWipeTransition)Clone();
		barnDoorWipeTransition.Mode = Transition.GetOppositeMode(Mode);
		return barnDoorWipeTransition;
	}

	protected override Storyboard GetToContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.In) ? PQC(presenter) : null;
	}

	protected override Style GetToContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.In) ? wQY(presenter) : null;
	}

	public BarnDoorWipeTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static BarnDoorWipeTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		BeginTimeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107862), typeof(TimeSpan), typeof(BarnDoorWipeTransition), new FrameworkPropertyMetadata(TimeSpan.Zero));
		DirectionProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107884), typeof(TransitionDirection), typeof(BarnDoorWipeTransition), new FrameworkPropertyMetadata(TransitionDirection.Default));
		DurationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107906), typeof(Duration), typeof(BarnDoorWipeTransition), new FrameworkPropertyMetadata(Duration.Automatic));
		ModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107926), typeof(TransitionMode), typeof(BarnDoorWipeTransition), new FrameworkPropertyMetadata(TransitionMode.In, uQI));
		SpreadProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107938), typeof(double), typeof(BarnDoorWipeTransition), new FrameworkPropertyMetadata(0.25, null, lQA), ValidationHelper.ValidateDoubleIsPercentage);
	}

	internal static bool g7U()
	{
		return W7X == null;
	}

	internal static BarnDoorWipeTransition y7L()
	{
		return W7X;
	}
}
