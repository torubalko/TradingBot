using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using ActiproSoftware.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public class FadeTransition : StoryboardTransitionBase
{
	public static readonly DependencyProperty BeginTimeProperty;

	public static readonly DependencyProperty BlurRadiusProperty;

	public static readonly DependencyProperty DurationProperty;

	public static readonly DependencyProperty ModeProperty;

	internal static FadeTransition nHf;

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

	public double BlurRadius
	{
		get
		{
			return (double)GetValue(BlurRadiusProperty);
		}
		set
		{
			SetValue(BlurRadiusProperty, value);
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

	private static void NQ6(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		FadeTransition fadeTransition = (FadeTransition)P_0;
		fadeTransition.IsToContentTopMost = fadeTransition.Mode == TransitionMode.In;
	}

	protected override Storyboard GetFromContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		if (Mode == TransitionMode.Out || BlurRadius > 0.0)
		{
			Duration duration = ((Duration == Duration.Automatic && presenter != null) ? presenter.DefaultDuration : Duration);
			Storyboard storyboard = new Storyboard();
			storyboard.BeginTime = BeginTime;
			storyboard.FillBehavior = FillBehavior.Stop;
			if (Mode == TransitionMode.Out)
			{
				DoubleAnimation doubleAnimation = new DoubleAnimation
				{
					From = 1.0,
					To = 0.0,
					Duration = duration
				};
				Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(UIElement.OpacityProperty));
				storyboard.Children.Add(doubleAnimation);
			}
			if (BlurRadius > 0.0)
			{
				DoubleAnimation doubleAnimation2 = new DoubleAnimation
				{
					From = ((Mode == TransitionMode.In) ? BlurRadius : 0.0),
					To = ((Mode == TransitionMode.In) ? 0.0 : BlurRadius),
					Duration = duration
				};
				Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108360)));
				storyboard.Children.Add(doubleAnimation2);
			}
			return storyboard;
		}
		return null;
	}

	[SuppressMessage("Microsoft.Portability", "CA1903:UseOnlyApiFromTargetedFramework", MessageId = "System.Windows.Media.Effects.BlurEffect")]
	[SuppressMessage("Microsoft.Portability", "CA1903:UseOnlyApiFromTargetedFramework", MessageId = "System.Windows.UIElement.#EffectProperty")]
	protected override Style GetFromContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		if (!(BlurRadius > 0.0))
		{
			return null;
		}
		Style style = new Style(typeof(FrameworkElement));
		BlurEffect blurEffect = new BlurEffect();
		blurEffect.Radius = 0.0;
		style.Setters.Add(new Setter(UIElement.EffectProperty, blurEffect));
		return style;
	}

	public override Transition GetOppositeTransition()
	{
		FadeTransition fadeTransition = (FadeTransition)Clone();
		fadeTransition.Mode = Transition.GetOppositeMode(Mode);
		return fadeTransition;
	}

	protected override Storyboard GetToContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		if (Mode != TransitionMode.In)
		{
			return null;
		}
		Duration duration = ((Duration == Duration.Automatic && presenter != null) ? presenter.DefaultDuration : Duration);
		Storyboard storyboard = new Storyboard();
		storyboard.BeginTime = BeginTime;
		storyboard.FillBehavior = FillBehavior.Stop;
		DoubleAnimation doubleAnimation = new DoubleAnimation
		{
			From = 0.0,
			To = 1.0,
			Duration = duration
		};
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(UIElement.OpacityProperty));
		storyboard.Children.Add(doubleAnimation);
		return storyboard;
	}

	public FadeTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static FadeTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		BeginTimeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107862), typeof(TimeSpan), typeof(FadeTransition), new FrameworkPropertyMetadata(TimeSpan.Zero));
		BlurRadiusProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108440), typeof(double), typeof(FadeTransition), new FrameworkPropertyMetadata(0.0), ValidationHelper.ValidateDoubleIsPositive);
		DurationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107906), typeof(Duration), typeof(FadeTransition), new FrameworkPropertyMetadata(Duration.Automatic));
		ModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107926), typeof(TransitionMode), typeof(FadeTransition), new FrameworkPropertyMetadata(TransitionMode.In, NQ6));
	}

	internal static bool LH7()
	{
		return nHf == null;
	}

	internal static FadeTransition THH()
	{
		return nHf;
	}
}
