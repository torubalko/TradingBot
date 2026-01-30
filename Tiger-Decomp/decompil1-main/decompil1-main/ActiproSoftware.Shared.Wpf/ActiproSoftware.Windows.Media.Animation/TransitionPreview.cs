using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public class TransitionPreview : Control
{
	private TransitionPresenter presenter;

	private DispatcherTimer XOo;

	public static readonly DependencyProperty DefaultDirectionProperty;

	public static readonly DependencyProperty DefaultDurationProperty;

	public static readonly DependencyProperty DefaultModeProperty;

	public static readonly DependencyProperty TransitionProperty;

	public static readonly DependencyProperty TransitionSelectorProperty;

	private static TransitionPreview yHm;

	public TransitionDirection DefaultDirection
	{
		get
		{
			return (TransitionDirection)GetValue(DefaultDirectionProperty);
		}
		set
		{
			SetValue(DefaultDirectionProperty, value);
		}
	}

	public Duration DefaultDuration
	{
		get
		{
			return (Duration)GetValue(DefaultDurationProperty);
		}
		set
		{
			SetValue(DefaultDurationProperty, value);
		}
	}

	public TransitionMode DefaultMode
	{
		get
		{
			return (TransitionMode)GetValue(DefaultModeProperty);
		}
		set
		{
			SetValue(DefaultModeProperty, value);
		}
	}

	public Transition Transition
	{
		get
		{
			return (Transition)GetValue(TransitionProperty);
		}
		set
		{
			SetValue(TransitionProperty, value);
		}
	}

	public TransitionSelector TransitionSelector
	{
		get
		{
			return (TransitionSelector)GetValue(TransitionSelectorProperty);
		}
		set
		{
			SetValue(TransitionSelectorProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static TransitionPreview()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		DefaultDirectionProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109926), typeof(TransitionDirection), typeof(TransitionPreview), new FrameworkPropertyMetadata(TransitionDirection.Forward));
		DefaultDurationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109962), typeof(Duration), typeof(TransitionPreview), new FrameworkPropertyMetadata(new Duration(TimeSpan.FromMilliseconds(1500.0))));
		DefaultModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109996), typeof(TransitionMode), typeof(TransitionPreview), new FrameworkPropertyMetadata(TransitionMode.In));
		TransitionProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110248), typeof(Transition), typeof(TransitionPreview), new FrameworkPropertyMetadata(null));
		TransitionSelectorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110272), typeof(TransitionSelector), typeof(TransitionPreview), new FrameworkPropertyMetadata(null));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(TransitionPreview), new FrameworkPropertyMetadata(typeof(TransitionPreview)));
		UIElement.FocusableProperty.OverrideMetadata(typeof(TransitionPreview), new FrameworkPropertyMetadata(false));
		UIElement.IsEnabledProperty.OverrideMetadata(typeof(TransitionPreview), new FrameworkPropertyMetadata(bOF));
	}

	public TransitionPreview()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		XOo = new DispatcherTimer(DispatcherPriority.Background);
		XOo.Interval = TimeSpan.FromMilliseconds(1500.0);
		XOo.Tick += rO7;
		if (!DesignerProperties.GetIsInDesignMode(this))
		{
			XOo.Start();
		}
	}

	private void SOe(object P_0, RoutedPropertyChangedEventArgs<object> P_1)
	{
		if (base.IsEnabled)
		{
			XOo.Start();
		}
	}

	private void rO7(object P_0, EventArgs P_1)
	{
		XOo.Stop();
		if (presenter != null)
		{
			int num = 0;
			if (eHr() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (presenter.Content is Label { Content: not null } label)
			{
				Label label2 = new Label();
				label2.Content = (label.Content.Equals(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110352)) ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110358) : WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110352));
				presenter.Content = label2;
				return;
			}
		}
		XOo.Start();
	}

	private static void bOF(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TransitionPreview transitionPreview = (TransitionPreview)P_0;
		if (!transitionPreview.IsEnabled)
		{
			if (transitionPreview.XOo.IsEnabled)
			{
				transitionPreview.XOo.Stop();
			}
		}
		else if (!transitionPreview.XOo.IsEnabled && !DesignerProperties.GetIsInDesignMode(transitionPreview))
		{
			transitionPreview.XOo.Start();
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		if (presenter != null)
		{
			presenter.TransitionCompleted -= SOe;
		}
		presenter = GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110364)) as TransitionPresenter;
		if (presenter != null)
		{
			presenter.TransitionCompleted += SOe;
		}
	}

	internal static bool hHZ()
	{
		return yHm == null;
	}

	internal static TransitionPreview eHr()
	{
		return yHm;
	}
}
