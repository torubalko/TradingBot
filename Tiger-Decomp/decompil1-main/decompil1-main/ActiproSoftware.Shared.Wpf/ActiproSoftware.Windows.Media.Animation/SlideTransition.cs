using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public class SlideTransition : StoryboardTransitionBase
{
	public static readonly DependencyProperty BeginTimeProperty;

	public static readonly DependencyProperty DirectionProperty;

	public static readonly DependencyProperty DurationProperty;

	public static readonly DependencyProperty IsFromContentPushedProperty;

	public static readonly DependencyProperty ModeProperty;

	internal static SlideTransition UHn;

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

	public bool IsFromContentPushed
	{
		get
		{
			return (bool)GetValue(IsFromContentPushedProperty);
		}
		set
		{
			SetValue(IsFromContentPushedProperty, value);
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

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static SlideTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		BeginTimeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107862), typeof(TimeSpan), typeof(SlideTransition), new FrameworkPropertyMetadata(TimeSpan.Zero));
		DirectionProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107884), typeof(TransitionDirection), typeof(SlideTransition), new FrameworkPropertyMetadata(TransitionDirection.Default));
		DurationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107906), typeof(Duration), typeof(SlideTransition), new FrameworkPropertyMetadata(Duration.Automatic));
		IsFromContentPushedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108940), typeof(bool), typeof(SlideTransition), new FrameworkPropertyMetadata(false));
		ModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107926), typeof(TransitionMode), typeof(SlideTransition), new FrameworkPropertyMetadata(TransitionMode.In, mQg));
		Transition.ClipToBoundsProperty.OverrideMetadata(typeof(SlideTransition), new FrameworkPropertyMetadata(true));
	}

	private static Point dQs(Point P_0)
	{
		P_0.X = -1.0 * P_0.X;
		P_0.Y = -1.0 * P_0.Y;
		return P_0;
	}

	private Storyboard kQL(TransitionPresenter P_0, FrameworkElement P_1)
	{
		if (!IsFromContentPushed)
		{
			return null;
		}
		TransitionDirection resolvedDirection = Transition.GetResolvedDirection(Direction, P_0?.DefaultDirection ?? TransitionDirection.Default);
		Duration duration = ((Duration == Duration.Automatic && P_0 != null) ? P_0.DefaultDuration : Duration);
		if (!duration.HasTimeSpan)
		{
			duration = new Duration(TimeSpan.FromMilliseconds(500.0));
		}
		Storyboard storyboard = new Storyboard();
		storyboard.BeginTime = BeginTime;
		storyboard.FillBehavior = FillBehavior.Stop;
		Point point = dQs((Mode == TransitionMode.In) ? default(Point) : rQK(resolvedDirection));
		Point point2 = dQs((Mode == TransitionMode.In) ? rQK(resolvedDirection) : default(Point));
		DoubleAnimation doubleAnimation = new DoubleAnimation
		{
			From = point.X * P_1.ActualWidth,
			To = point2.X * P_1.ActualWidth,
			Duration = duration,
			EasingFunction = new QuadraticEase
			{
				EasingMode = EasingMode.EaseOut
			}
		};
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100670)));
		storyboard.Children.Add(doubleAnimation);
		DoubleAnimation doubleAnimation2 = new DoubleAnimation
		{
			From = point.Y * P_1.ActualHeight,
			To = point2.Y * P_1.ActualHeight,
			Duration = duration,
			EasingFunction = new QuadraticEase
			{
				EasingMode = EasingMode.EaseOut
			}
		};
		Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108982)));
		storyboard.Children.Add(doubleAnimation2);
		return storyboard;
	}

	private Style vQd(TransitionPresenter P_0, FrameworkElement P_1)
	{
		if (!IsFromContentPushed)
		{
			return null;
		}
		TransitionDirection resolvedDirection = Transition.GetResolvedDirection(Direction, P_0?.DefaultDirection ?? TransitionDirection.Default);
		Style style = new Style(typeof(FrameworkElement));
		Point point = dQs((Mode == TransitionMode.In) ? default(Point) : rQK(resolvedDirection));
		TranslateTransform value = new TranslateTransform
		{
			X = point.X * P_1.ActualWidth,
			Y = point.Y * P_1.ActualHeight
		};
		style.Setters.Add(new Setter(UIElement.RenderTransformProperty, value));
		return style;
	}

	private Storyboard wQN(TransitionPresenter P_0, FrameworkElement P_1)
	{
		TransitionDirection resolvedDirection = Transition.GetResolvedDirection(Direction, P_0?.DefaultDirection ?? TransitionDirection.Default);
		Duration duration = ((Duration == Duration.Automatic && P_0 != null) ? P_0.DefaultDuration : Duration);
		if (!duration.HasTimeSpan)
		{
			duration = new Duration(TimeSpan.FromMilliseconds(500.0));
		}
		Storyboard storyboard = new Storyboard();
		storyboard.BeginTime = BeginTime;
		storyboard.FillBehavior = FillBehavior.Stop;
		Point point = ((Mode == TransitionMode.In) ? rQK(resolvedDirection) : default(Point));
		Point point2 = ((Mode == TransitionMode.In) ? default(Point) : rQK(resolvedDirection));
		P_1.UpdateLayout();
		DoubleAnimation doubleAnimation = new DoubleAnimation
		{
			From = point.X * P_1.ActualWidth,
			To = point2.X * P_1.ActualWidth,
			Duration = duration,
			EasingFunction = new QuadraticEase
			{
				EasingMode = EasingMode.EaseOut
			}
		};
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100670)));
		storyboard.Children.Add(doubleAnimation);
		DoubleAnimation doubleAnimation2 = new DoubleAnimation
		{
			From = point.Y * P_1.ActualHeight,
			To = point2.Y * P_1.ActualHeight,
			Duration = duration,
			EasingFunction = new QuadraticEase
			{
				EasingMode = EasingMode.EaseOut
			}
		};
		Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108982)));
		storyboard.Children.Add(doubleAnimation2);
		return storyboard;
	}

	private Style sQM(TransitionPresenter P_0, FrameworkElement P_1)
	{
		TransitionDirection resolvedDirection = Transition.GetResolvedDirection(Direction, P_0?.DefaultDirection ?? TransitionDirection.Default);
		Style style = new Style(typeof(FrameworkElement));
		Point point = ((Mode == TransitionMode.In) ? rQK(resolvedDirection) : default(Point));
		TranslateTransform value = new TranslateTransform
		{
			X = point.X * P_1.ActualWidth,
			Y = point.Y * P_1.ActualHeight
		};
		style.Setters.Add(new Setter(UIElement.RenderTransformProperty, value));
		return style;
	}

	private static Point rQK(TransitionDirection P_0)
	{
		return P_0 switch
		{
			TransitionDirection.Backward => new Point(-1.0, 0.0), 
			TransitionDirection.BackwardDown => new Point(-1.0, 1.0), 
			TransitionDirection.BackwardUp => new Point(-1.0, -1.0), 
			TransitionDirection.Down => new Point(0.0, 1.0), 
			TransitionDirection.Forward => new Point(1.0, 0.0), 
			TransitionDirection.ForwardDown => new Point(1.0, 1.0), 
			TransitionDirection.ForwardUp => new Point(1.0, -1.0), 
			_ => new Point(0.0, -1.0), 
		};
	}

	private static void mQg(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SlideTransition slideTransition = (SlideTransition)P_0;
		slideTransition.IsToContentTopMost = slideTransition.Mode == TransitionMode.In;
	}

	protected override Storyboard GetFromContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.Out) ? wQN(presenter, content) : kQL(presenter, content);
	}

	protected override Style GetFromContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.Out) ? sQM(presenter, content) : vQd(presenter, content);
	}

	public override Transition GetOppositeTransition()
	{
		SlideTransition slideTransition = (SlideTransition)Clone();
		slideTransition.Mode = Transition.GetOppositeMode(Mode);
		return slideTransition;
	}

	protected override Storyboard GetToContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.In) ? wQN(presenter, content) : kQL(presenter, content);
	}

	protected override Style GetToContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.In) ? sQM(presenter, content) : vQd(presenter, content);
	}

	public SlideTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool KH0()
	{
		return UHn == null;
	}

	internal static SlideTransition bHb()
	{
		return UHn;
	}
}
