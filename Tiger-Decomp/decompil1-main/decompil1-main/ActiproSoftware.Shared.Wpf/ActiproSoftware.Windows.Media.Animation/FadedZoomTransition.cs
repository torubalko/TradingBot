using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using ActiproSoftware.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public class FadedZoomTransition : StoryboardTransitionBase
{
	public static readonly DependencyProperty BeginTimeProperty;

	public static readonly DependencyProperty DurationProperty;

	public static readonly DependencyProperty ModeProperty;

	public static readonly DependencyProperty ZoomInPercentageProperty;

	public static readonly DependencyProperty ZoomOutPercentageProperty;

	private static FadedZoomTransition OHM;

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

	public double ZoomInPercentage
	{
		get
		{
			return (double)GetValue(ZoomInPercentageProperty);
		}
		set
		{
			SetValue(ZoomInPercentageProperty, value);
		}
	}

	public double ZoomOutPercentage
	{
		get
		{
			return (double)GetValue(ZoomOutPercentageProperty);
		}
		set
		{
			SetValue(ZoomOutPercentageProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "obj")]
	private static object GQH(DependencyObject P_0, object P_1)
	{
		if (!(P_1 is double))
		{
			return 0.2;
		}
		return Math.Max(0.0, Math.Min(0.5, (double)P_1));
	}

	protected override Storyboard GetFromContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		Duration duration = ((Duration == Duration.Automatic && presenter != null) ? presenter.DefaultDuration : Duration);
		Storyboard storyboard = new Storyboard();
		storyboard.BeginTime = BeginTime;
		storyboard.FillBehavior = FillBehavior.Stop;
		Duration duration2 = ((Mode == TransitionMode.In) ? duration : new Duration(TimeSpan.FromMilliseconds(duration.TimeSpan.TotalMilliseconds / 2.0)));
		DoubleAnimation doubleAnimation = new DoubleAnimation
		{
			From = 1.0,
			To = 0.0,
			Duration = duration2
		};
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(UIElement.OpacityProperty));
		storyboard.Children.Add(doubleAnimation);
		double num = 0.0;
		double num2 = ((Mode == TransitionMode.In) ? ZoomOutPercentage : (0.0 - ZoomInPercentage));
		DoubleAnimation doubleAnimation2 = new DoubleAnimation
		{
			From = 1.0 - num,
			To = 1.0 + num2,
			Duration = duration
		};
		Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108074)));
		storyboard.Children.Add(doubleAnimation2);
		doubleAnimation2 = new DoubleAnimation
		{
			From = 1.0 - num,
			To = 1.0 + num2,
			Duration = duration
		};
		Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108180)));
		storyboard.Children.Add(doubleAnimation2);
		return storyboard;
	}

	protected override Style GetFromContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		Style style = new Style(typeof(FrameworkElement));
		style.Setters.Add(new Setter(UIElement.RenderTransformOriginProperty, new Point(0.5, 0.5)));
		style.Setters.Add(new Setter(UIElement.RenderTransformProperty, new ScaleTransform()));
		return style;
	}

	public override Transition GetOppositeTransition()
	{
		FadedZoomTransition fadedZoomTransition = (FadedZoomTransition)Clone();
		fadedZoomTransition.Mode = Transition.GetOppositeMode(Mode);
		return fadedZoomTransition;
	}

	protected override Storyboard GetToContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		Duration duration = ((Duration == Duration.Automatic && presenter != null) ? presenter.DefaultDuration : Duration);
		Storyboard storyboard = new Storyboard();
		storyboard.BeginTime = BeginTime;
		storyboard.FillBehavior = FillBehavior.Stop;
		Duration duration2 = ((Mode == TransitionMode.In) ? new Duration(TimeSpan.FromMilliseconds(duration.TimeSpan.TotalMilliseconds / 2.0)) : duration);
		DoubleAnimation doubleAnimation = new DoubleAnimation
		{
			From = 0.0,
			To = 1.0,
			Duration = duration2
		};
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(UIElement.OpacityProperty));
		storyboard.Children.Add(doubleAnimation);
		double num = ((Mode == TransitionMode.In) ? ZoomInPercentage : (0.0 - ZoomOutPercentage));
		double num2 = 0.0;
		DoubleAnimation doubleAnimation2 = new DoubleAnimation
		{
			From = 1.0 - num,
			To = 1.0 + num2,
			Duration = duration
		};
		Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108074)));
		storyboard.Children.Add(doubleAnimation2);
		doubleAnimation2 = new DoubleAnimation
		{
			From = 1.0 - num,
			To = 1.0 + num2,
			Duration = duration
		};
		Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108180)));
		storyboard.Children.Add(doubleAnimation2);
		return storyboard;
	}

	protected override Style GetToContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		Style style = new Style(typeof(FrameworkElement));
		style.Setters.Add(new Setter(UIElement.RenderTransformOriginProperty, new Point(0.5, 0.5)));
		style.Setters.Add(new Setter(UIElement.RenderTransformProperty, new ScaleTransform()));
		return style;
	}

	public FadedZoomTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static FadedZoomTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		BeginTimeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107862), typeof(TimeSpan), typeof(FadedZoomTransition), new FrameworkPropertyMetadata(TimeSpan.Zero));
		DurationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107906), typeof(Duration), typeof(FadedZoomTransition), new FrameworkPropertyMetadata(Duration.Automatic));
		ModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107926), typeof(TransitionMode), typeof(FadedZoomTransition), new FrameworkPropertyMetadata(TransitionMode.In));
		ZoomInPercentageProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108286), typeof(double), typeof(FadedZoomTransition), new FrameworkPropertyMetadata(0.2, null, GQH), ValidationHelper.ValidateDoubleIsPercentage);
		ZoomOutPercentageProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108322), typeof(double), typeof(FadedZoomTransition), new FrameworkPropertyMetadata(0.2, null, GQH), ValidationHelper.ValidateDoubleIsPercentage);
	}

	internal static bool YHY()
	{
		return OHM == null;
	}

	internal static FadedZoomTransition gHt()
	{
		return OHM;
	}
}
