using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Windows.Themes;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class AnimatedExpander : Expander
{
	public static readonly DependencyProperty CanMeasureCollapsedContentProperty;

	public static readonly DependencyProperty CollapseDurationProperty;

	public static readonly DependencyProperty ExpandDurationProperty;

	public static readonly DependencyProperty HeaderContextMenuProperty;

	public static readonly DependencyProperty HeaderCornerRadiusProperty;

	public static readonly DependencyProperty HeaderPaddingProperty;

	public static readonly DependencyProperty IsAutoCollapseOnBlurEnabledProperty;

	public static readonly DependencyProperty IsAutoExpandOnFocusEnabledProperty;

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "AutoFocus")]
	public static readonly DependencyProperty IsAutoFocusOnExpandEnabledProperty;

	private static AnimatedExpander Hqa;

	public bool CanMeasureCollapsedContent
	{
		get
		{
			return (bool)GetValue(CanMeasureCollapsedContentProperty);
		}
		set
		{
			SetValue(CanMeasureCollapsedContentProperty, value);
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

	public ContextMenu HeaderContextMenu
	{
		get
		{
			return (ContextMenu)GetValue(HeaderContextMenuProperty);
		}
		set
		{
			SetValue(HeaderContextMenuProperty, value);
		}
	}

	public CornerRadius HeaderCornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(HeaderCornerRadiusProperty);
		}
		set
		{
			SetValue(HeaderCornerRadiusProperty, value);
		}
	}

	public Thickness HeaderPadding
	{
		get
		{
			return (Thickness)GetValue(HeaderPaddingProperty);
		}
		set
		{
			SetValue(HeaderPaddingProperty, value);
		}
	}

	public bool IsAutoCollapseOnBlurEnabled
	{
		get
		{
			return (bool)GetValue(IsAutoCollapseOnBlurEnabledProperty);
		}
		set
		{
			SetValue(IsAutoCollapseOnBlurEnabledProperty, value);
		}
	}

	public bool IsAutoExpandOnFocusEnabled
	{
		get
		{
			return (bool)GetValue(IsAutoExpandOnFocusEnabledProperty);
		}
		set
		{
			SetValue(IsAutoExpandOnFocusEnabledProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "AutoFocus")]
	public bool IsAutoFocusOnExpandEnabled
	{
		get
		{
			return (bool)GetValue(IsAutoFocusOnExpandEnabledProperty);
		}
		set
		{
			SetValue(IsAutoFocusOnExpandEnabledProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static AnimatedExpander()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		CanMeasureCollapsedContentProperty = ExpanderThemeProperties.CanMeasureCollapsedContentProperty.AddOwner(typeof(AnimatedExpander));
		CollapseDurationProperty = ExpanderThemeProperties.CollapseDurationProperty.AddOwner(typeof(AnimatedExpander));
		ExpandDurationProperty = ExpanderThemeProperties.ExpandDurationProperty.AddOwner(typeof(AnimatedExpander));
		HeaderContextMenuProperty = HeaderedControlThemeProperties.HeaderContextMenuProperty.AddOwner(typeof(AnimatedExpander));
		HeaderCornerRadiusProperty = HeaderedControlThemeProperties.HeaderCornerRadiusProperty.AddOwner(typeof(AnimatedExpander));
		HeaderPaddingProperty = HeaderedControlThemeProperties.HeaderPaddingProperty.AddOwner(typeof(AnimatedExpander));
		IsAutoCollapseOnBlurEnabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113454), typeof(bool), typeof(AnimatedExpander), new FrameworkPropertyMetadata(false));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		IsAutoExpandOnFocusEnabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113512), typeof(bool), typeof(AnimatedExpander), new FrameworkPropertyMetadata(false));
		IsAutoFocusOnExpandEnabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113568), typeof(bool), typeof(AnimatedExpander), new FrameworkPropertyMetadata(false));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(AnimatedExpander), new FrameworkPropertyMetadata(typeof(AnimatedExpander)));
		ToolTipService.IsEnabledProperty.OverrideMetadata(typeof(AnimatedExpander), new FrameworkPropertyMetadata(false));
		EventManager.RegisterClassHandler(typeof(AnimatedExpander), AnimatedExpanderDecorator.ExpansionAnimationCompletedEvent, new RoutedEventHandler(ElC));
	}

	private static void ElC(object P_0, RoutedEventArgs P_1)
	{
		AnimatedExpander animatedExpander = (AnimatedExpander)P_0;
		if (animatedExpander.IsLoaded && animatedExpander.IsAutoFocusOnExpandEnabled && animatedExpander.Content is UIElement uIElement)
		{
			uIElement.MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
		}
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsKeyboardFocusWithinChanged(e);
		bool isKeyboardFocusWithin = base.IsKeyboardFocusWithin;
		int num = 0;
		if (!jqy())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (isKeyboardFocusWithin)
		{
			if (IsAutoExpandOnFocusEnabled && !base.IsExpanded && Mouse.LeftButton == MouseButtonState.Released)
			{
				base.IsExpanded = true;
			}
		}
		else if (IsAutoCollapseOnBlurEnabled && base.IsExpanded)
		{
			base.IsExpanded = false;
		}
	}

	public AnimatedExpander()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool jqy()
	{
		return Hqa == null;
	}

	internal static AnimatedExpander sqQ()
	{
		return Hqa;
	}
}
