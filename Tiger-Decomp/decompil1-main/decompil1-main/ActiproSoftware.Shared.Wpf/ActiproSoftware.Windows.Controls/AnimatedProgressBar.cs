using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;
using ActiproSoftware.Windows.Controls.Automation.Peers;
using ActiproSoftware.Windows.Themes;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

[TemplatePart(Name = "PART_Track", Type = typeof(FrameworkElement))]
[TemplatePart(Name = "PART_Indicator", Type = typeof(FrameworkElement))]
public class AnimatedProgressBar : RangeBase
{
	private FrameworkElement indicator;

	private Storyboard AlE;

	private FrameworkElement Els;

	public static readonly RoutedEvent StateChangedEvent;

	private static readonly DependencyPropertyKey blL;

	public static readonly DependencyProperty DecreaseDurationProperty;

	public static readonly DependencyProperty IncreaseDurationProperty;

	public static readonly DependencyProperty IsAnimationEnabledProperty;

	public static readonly DependencyProperty IsCompletedProperty;

	public static readonly DependencyProperty IsContinuousProperty;

	public static readonly DependencyProperty IsIndeterminateProperty;

	public static readonly DependencyProperty OrientationProperty;

	public static readonly DependencyProperty StateProperty;

	private static AnimatedProgressBar Kqc;

	public Duration DecreaseDuration
	{
		get
		{
			return (Duration)GetValue(DecreaseDurationProperty);
		}
		set
		{
			SetValue(DecreaseDurationProperty, value);
		}
	}

	public Duration IncreaseDuration
	{
		get
		{
			return (Duration)GetValue(IncreaseDurationProperty);
		}
		set
		{
			SetValue(IncreaseDurationProperty, value);
		}
	}

	public bool IsAnimationEnabled
	{
		get
		{
			return (bool)GetValue(IsAnimationEnabledProperty);
		}
		set
		{
			SetValue(IsAnimationEnabledProperty, value);
		}
	}

	public bool IsCompleted
	{
		get
		{
			return (bool)GetValue(IsCompletedProperty);
		}
		private set
		{
			SetValue(blL, value);
		}
	}

	public bool IsContinuous
	{
		get
		{
			return (bool)GetValue(IsContinuousProperty);
		}
		set
		{
			SetValue(IsContinuousProperty, value);
		}
	}

	public bool IsIndeterminate
	{
		get
		{
			return (bool)GetValue(IsIndeterminateProperty);
		}
		set
		{
			SetValue(IsIndeterminateProperty, value);
		}
	}

	public Orientation Orientation
	{
		get
		{
			return (Orientation)GetValue(OrientationProperty);
		}
		set
		{
			SetValue(OrientationProperty, value);
		}
	}

	public OperationState State
	{
		get
		{
			return (OperationState)GetValue(StateProperty);
		}
		set
		{
			SetValue(StateProperty, value);
		}
	}

	[Description("Occurs when the State property is changed.")]
	public event EventHandler<OperationStatePropertyChangedRoutedEventArgs> StateChanged
	{
		add
		{
			AddHandler(StateChangedEvent, value);
		}
		remove
		{
			RemoveHandler(StateChangedEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static AnimatedProgressBar()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		StateChangedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113868), RoutingStrategy.Bubble, typeof(EventHandler<OperationStatePropertyChangedRoutedEventArgs>), typeof(AnimatedProgressBar));
		blL = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113896), typeof(bool), typeof(AnimatedProgressBar), new FrameworkPropertyMetadata(false));
		DecreaseDurationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113922), typeof(Duration), typeof(AnimatedProgressBar), new FrameworkPropertyMetadata(new Duration(TimeSpan.FromMilliseconds(500.0))));
		IncreaseDurationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113958), typeof(Duration), typeof(AnimatedProgressBar), new FrameworkPropertyMetadata(new Duration(TimeSpan.FromMilliseconds(500.0))));
		IsAnimationEnabledProperty = ThemeProperties.IsAnimationEnabledProperty.AddOwner(typeof(AnimatedProgressBar));
		IsCompletedProperty = blL.DependencyProperty;
		IsContinuousProperty = ProgressBarThemeProperties.IsContinuousProperty.AddOwner(typeof(AnimatedProgressBar));
		IsIndeterminateProperty = ProgressBar.IsIndeterminateProperty.AddOwner(typeof(AnimatedProgressBar), new FrameworkPropertyMetadata(GlH));
		OrientationProperty = ProgressBar.OrientationProperty.AddOwner(typeof(AnimatedProgressBar));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		StateProperty = ProgressBarThemeProperties.StateProperty.AddOwner(typeof(AnimatedProgressBar), new FrameworkPropertyMetadata(vl6));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(AnimatedProgressBar), new FrameworkPropertyMetadata(typeof(AnimatedProgressBar)));
		UIElement.FocusableProperty.OverrideMetadata(typeof(AnimatedProgressBar), new FrameworkPropertyMetadata(false));
		RangeBase.MaximumProperty.OverrideMetadata(typeof(AnimatedProgressBar), new FrameworkPropertyMetadata(100.0));
	}

	private static void GlH(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is AnimatedProgressBar animatedProgressBar)
		{
			if (UIElementAutomationPeer.FromElement(animatedProgressBar) is AnimatedProgressBarAutomationPeer animatedProgressBarAutomationPeer)
			{
				animatedProgressBarAutomationPeer.InvalidatePeer();
			}
			animatedProgressBar.Jl5();
			animatedProgressBar.UpdateProgressBarIndicatorLength(allowAnimation: false);
		}
	}

	private static void vl6(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is AnimatedProgressBar animatedProgressBar))
		{
			return;
		}
		OperationState oldValue = (OperationState)P_1.OldValue;
		OperationState newValue = (OperationState)P_1.NewValue;
		if (UIElementAutomationPeer.FromElement(animatedProgressBar) is AnimatedProgressBarAutomationPeer animatedProgressBarAutomationPeer)
		{
			animatedProgressBarAutomationPeer.RaiseValuePropertyChangedEvent(oldValue, newValue);
			int num = 0;
			if (sqo() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		animatedProgressBar.OnStateChanged(oldValue, newValue);
	}

	private void jlV(object P_0, SizeChangedEventArgs P_1)
	{
		UpdateProgressBarIndicatorLength(allowAnimation: false);
	}

	private void Jl5()
	{
		bool flag = !IsIndeterminate && base.Value >= base.Maximum;
		if (flag != IsCompleted)
		{
			IsCompleted = flag;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		if (Els != null)
		{
			Els.SizeChanged -= jlV;
		}
		Els = GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113994)) as FrameworkElement;
		indicator = GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114018)) as FrameworkElement;
		AlE = null;
		if (Els != null)
		{
			Els.SizeChanged += jlV;
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new AnimatedProgressBarAutomationPeer(this);
	}

	protected virtual void OnStateChanged(OperationState oldValue, OperationState newValue)
	{
		OperationStatePropertyChangedRoutedEventArgs e = new OperationStatePropertyChangedRoutedEventArgs(StateChangedEvent, oldValue, newValue);
		e.Source = this;
		RaiseEvent(e);
	}

	protected override void OnValueChanged(double oldValue, double newValue)
	{
		base.OnValueChanged(oldValue, newValue);
		Jl5();
		UpdateProgressBarIndicatorLength(allowAnimation: true);
	}

	protected virtual void UpdateProgressBarIndicatorLength(bool allowAnimation)
	{
		if (Els == null || indicator == null)
		{
			return;
		}
		if (AlE == null)
		{
			AlE = new Storyboard();
		}
		else
		{
			AlE.Children.Clear();
		}
		double minimum = base.Minimum;
		double maximum = base.Maximum;
		double num = ((IsIndeterminate || maximum == minimum) ? 1.0 : ((base.Value - minimum) / (maximum - minimum)));
		double num2 = 0.0;
		double num3 = 0.0;
		bool flag = false;
		DependencyProperty dependencyProperty = null;
		if (Orientation == Orientation.Horizontal)
		{
			num2 = indicator.ActualWidth;
			num3 = num * Els.ActualWidth;
			flag = double.IsInfinity(indicator.Width) || double.IsNaN(indicator.Width);
			dependencyProperty = FrameworkElement.WidthProperty;
		}
		else
		{
			num2 = indicator.ActualHeight;
			num3 = num * Els.ActualHeight;
			flag = double.IsInfinity(indicator.Height) || double.IsNaN(indicator.Height);
			dependencyProperty = FrameworkElement.HeightProperty;
		}
		if (base.IsInitialized && (num3 != num2 || !flag))
		{
			Duration duration = ((!allowAnimation || !IsAnimationEnabled || IsIndeterminate) ? new Duration(TimeSpan.FromMilliseconds(0.0)) : ((num3 < num2) ? DecreaseDuration : IncreaseDuration));
			if (0.0 != duration.TimeSpan.TotalMilliseconds)
			{
				DoubleAnimation doubleAnimation = ((!flag) ? new DoubleAnimation(num3, duration, FillBehavior.HoldEnd) : new DoubleAnimation(num2, num3, duration, FillBehavior.HoldEnd));
				Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(dependencyProperty));
				AlE.Children.Add(doubleAnimation);
			}
		}
		if (AlE.Children.Count != 0)
		{
			AlE.Begin(indicator, HandoffBehavior.SnapshotAndReplace);
			return;
		}
		indicator.BeginAnimation(dependencyProperty, null);
		indicator.SetValue(dependencyProperty, num3);
	}

	public AnimatedProgressBar()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool Nqu()
	{
		return Kqc == null;
	}

	internal static AnimatedProgressBar sqo()
	{
		return Kqc;
	}
}
