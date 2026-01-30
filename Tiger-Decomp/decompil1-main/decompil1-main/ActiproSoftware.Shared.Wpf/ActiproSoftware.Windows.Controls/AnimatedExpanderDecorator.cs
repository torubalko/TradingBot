using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using ActiproSoftware.Windows.Data;
using ActiproSoftware.Windows.Themes;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class AnimatedExpanderDecorator : Decorator
{
	private bool klq;

	private Storyboard BlW;

	public static readonly RoutedEvent CollapseAnimationCompletedEvent;

	public static readonly RoutedEvent ExpansionAnimationCompletedEvent;

	public static readonly DependencyProperty CollapseDurationProperty;

	public static readonly DependencyProperty CollapsedVisibilityProperty;

	public static readonly DependencyProperty ExpandDirectionProperty;

	public static readonly DependencyProperty ExpandDurationProperty;

	private static readonly DependencyProperty olU;

	public static readonly DependencyProperty IsExpandedProperty;

	private static AnimatedExpanderDecorator RqC;

	private double ExpandPercent
	{
		get
		{
			return (double)GetValue(olU);
		}
		set
		{
			SetValue(olU, value);
		}
	}

	public Duration CollapseDuration
	{
		get
		{
			return (Duration)GetValue(CollapseDurationProperty);
		}
		set
		{
			SetValue(CollapseDurationProperty, value);
		}
	}

	public Visibility CollapsedVisibility
	{
		get
		{
			return (Visibility)GetValue(CollapsedVisibilityProperty);
		}
		set
		{
			SetValue(CollapsedVisibilityProperty, value);
		}
	}

	public ExpandDirection ExpandDirection
	{
		get
		{
			return (ExpandDirection)GetValue(ExpandDirectionProperty);
		}
		set
		{
			SetValue(ExpandDirectionProperty, value);
		}
	}

	public Duration ExpandDuration
	{
		get
		{
			return (Duration)GetValue(ExpandDurationProperty);
		}
		set
		{
			SetValue(ExpandDurationProperty, value);
		}
	}

	public bool IsExpanded
	{
		get
		{
			return (bool)GetValue(IsExpandedProperty);
		}
		set
		{
			SetValue(IsExpandedProperty, value);
		}
	}

	[Description("Occurs when the expansion animation has completed.")]
	public event RoutedEventHandler CollapseAnimationCompleted
	{
		add
		{
			AddHandler(CollapseAnimationCompletedEvent, value);
		}
		remove
		{
			RemoveHandler(CollapseAnimationCompletedEvent, value);
		}
	}

	[Description("Occurs when the expansion animation has completed.")]
	public event RoutedEventHandler ExpansionAnimationCompleted
	{
		add
		{
			AddHandler(ExpansionAnimationCompletedEvent, value);
		}
		remove
		{
			RemoveHandler(ExpansionAnimationCompletedEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static AnimatedExpanderDecorator()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		CollapseAnimationCompletedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113624), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(AnimatedExpanderDecorator));
		ExpansionAnimationCompletedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113680), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(AnimatedExpanderDecorator));
		CollapseDurationProperty = ExpanderThemeProperties.CollapseDurationProperty.AddOwner(typeof(AnimatedExpanderDecorator));
		CollapsedVisibilityProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113738), typeof(Visibility), typeof(AnimatedExpanderDecorator), new FrameworkPropertyMetadata(Visibility.Hidden, TlY));
		ExpandDirectionProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113780), typeof(ExpandDirection), typeof(AnimatedExpanderDecorator), new FrameworkPropertyMetadata(ExpandDirection.Down, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange));
		ExpandDurationProperty = ExpanderThemeProperties.ExpandDurationProperty.AddOwner(typeof(AnimatedExpanderDecorator));
		olU = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113814), typeof(double), typeof(AnimatedExpanderDecorator), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsMeasure, olI), ValidationHelper.ValidateDoubleIsPercentage);
		IsExpandedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113844), typeof(bool), typeof(AnimatedExpanderDecorator), new FrameworkPropertyMetadata(false, Klx));
		UIElement.ClipToBoundsProperty.OverrideMetadata(typeof(AnimatedExpanderDecorator), new FrameworkPropertyMetadata(true));
		UIElement.OpacityProperty.OverrideMetadata(typeof(AnimatedExpanderDecorator), new FrameworkPropertyMetadata(0.0));
		UIElement.VisibilityProperty.OverrideMetadata(typeof(AnimatedExpanderDecorator), new FrameworkPropertyMetadata(Visibility.Hidden));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private static void TlY(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is AnimatedExpanderDecorator animatedExpanderDecorator)
		{
			animatedExpanderDecorator.RlZ();
		}
	}

	private static void olI(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AnimatedExpanderDecorator animatedExpanderDecorator = (AnimatedExpanderDecorator)P_0;
		animatedExpanderDecorator.RlZ();
		if (animatedExpanderDecorator.Opacity != animatedExpanderDecorator.ExpandPercent)
		{
			animatedExpanderDecorator.Opacity = animatedExpanderDecorator.ExpandPercent;
		}
	}

	private static void Klx(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AnimatedExpanderDecorator animatedExpanderDecorator = (AnimatedExpanderDecorator)P_0;
		bool flag = (bool)P_1.NewValue;
		Duration duration = ((!animatedExpanderDecorator.IsLoaded) ? new Duration(TimeSpan.FromMilliseconds(0.0)) : (flag ? animatedExpanderDecorator.ExpandDuration : animatedExpanderDecorator.CollapseDuration));
		animatedExpanderDecorator.klq = flag;
		if (duration.HasTimeSpan && duration.TimeSpan.TotalMilliseconds != 0.0)
		{
			if (animatedExpanderDecorator.BlW == null)
			{
				animatedExpanderDecorator.BlW = new Storyboard();
				animatedExpanderDecorator.BlW.Completed += animatedExpanderDecorator.Olr;
			}
			else if (animatedExpanderDecorator.BlW.GetCurrentState(animatedExpanderDecorator) == ClockState.Active)
			{
				animatedExpanderDecorator.BlW.Stop(animatedExpanderDecorator);
			}
			DoubleAnimation doubleAnimation = new DoubleAnimation(flag ? 1.0 : 0.0, duration, FillBehavior.HoldEnd);
			if (flag)
			{
				doubleAnimation.DecelerationRatio = 0.5;
			}
			else
			{
				doubleAnimation.AccelerationRatio = 0.5;
			}
			doubleAnimation.EasingFunction = new QuadraticEase
			{
				EasingMode = EasingMode.EaseOut
			};
			Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(olU));
			animatedExpanderDecorator.BlW.Children.Clear();
			animatedExpanderDecorator.BlW.Children.Add(doubleAnimation);
			animatedExpanderDecorator.BlW.Begin(animatedExpanderDecorator, isControllable: true);
		}
		else
		{
			animatedExpanderDecorator.BeginAnimation(olU, null);
			if (flag)
			{
				animatedExpanderDecorator.ExpandPercent = 1.0;
				animatedExpanderDecorator.OnExpansionAnimationCompleted();
			}
			else
			{
				animatedExpanderDecorator.ExpandPercent = 0.0;
				animatedExpanderDecorator.OnCollapseAnimationCompleted();
			}
		}
	}

	private void Olr(object P_0, EventArgs P_1)
	{
		if (klq)
		{
			OnExpansionAnimationCompleted();
		}
		else
		{
			OnCollapseAnimationCompleted();
		}
	}

	private void RlZ()
	{
		Visibility visibility = ((!(ExpandPercent > 0.0)) ? CollapsedVisibility : Visibility.Visible);
		if (base.Visibility != visibility)
		{
			base.Visibility = visibility;
		}
	}

	protected override Size ArrangeOverride(Size arrangeSize)
	{
		if (Child != null)
		{
			switch (ExpandDirection)
			{
			case ExpandDirection.Up:
			case ExpandDirection.Left:
				Child.Arrange(new Rect(0.0, 0.0, arrangeSize.Width, arrangeSize.Height));
				break;
			case ExpandDirection.Right:
				Child.Arrange(new Rect((ExpandPercent - 1.0) * arrangeSize.Width, 0.0, arrangeSize.Width, arrangeSize.Height));
				break;
			default:
				Child.Arrange(new Rect(0.0, (ExpandPercent - 1.0) * arrangeSize.Height, arrangeSize.Width, arrangeSize.Height));
				break;
			}
			return arrangeSize;
		}
		return new Size(0.0, 0.0);
	}

	public static Duration GetCollapseDuration(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (Duration)obj.GetValue(CollapseDurationProperty);
	}

	public static void SetCollapseDuration(DependencyObject obj, Duration value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(CollapseDurationProperty, value);
	}

	public static Duration GetExpandDuration(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (Duration)obj.GetValue(ExpandDurationProperty);
	}

	public static void SetExpandDuration(DependencyObject obj, Duration value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(ExpandDurationProperty, value);
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		int num = 1;
		Size result = default(Size);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					double num3 = 1.0;
					double num4 = 1.0;
					ExpandDirection expandDirection = ExpandDirection;
					ExpandDirection expandDirection2 = expandDirection;
					if ((uint)(expandDirection2 - 2) > 1u)
					{
						num4 = ExpandPercent;
					}
					else
					{
						num3 = ExpandPercent;
					}
					result.Width = (double.IsPositiveInfinity(availableSize.Width) ? Child.DesiredSize.Width : Math.Min(availableSize.Width, Child.DesiredSize.Width)) * num3;
					result.Height = (double.IsPositiveInfinity(availableSize.Height) ? Child.DesiredSize.Height : Math.Min(availableSize.Height, Child.DesiredSize.Height)) * num4;
					goto IL_0105;
				}
				default:
					if (Child != null)
					{
						Child.Measure(availableSize);
						num2 = 2;
						if (sq9() == null)
						{
							continue;
						}
						break;
					}
					goto IL_0105;
				case 1:
					{
						result = new Size(0.0, 0.0);
						num2 = 0;
						if (qqR())
						{
							continue;
						}
						break;
					}
					IL_0105:
					return result;
				}
				break;
			}
		}
	}

	protected virtual void OnCollapseAnimationCompleted()
	{
		RaiseEvent(new RoutedEventArgs(CollapseAnimationCompletedEvent, this));
	}

	protected virtual void OnExpansionAnimationCompleted()
	{
		RaiseEvent(new RoutedEventArgs(ExpansionAnimationCompletedEvent, this));
	}

	public AnimatedExpanderDecorator()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool qqR()
	{
		return RqC == null;
	}

	internal static AnimatedExpanderDecorator sq9()
	{
		return RqC;
	}
}
