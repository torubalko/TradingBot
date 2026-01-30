using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

[ContentProperty("Content")]
public class TransitionPresenter : ContentPresenter
{
	private ContentPresenter bO9;

	private ContentPresenter kOh;

	private static DataTemplate eOm;

	public static readonly RoutedEvent TransitionCompletedEvent;

	private static readonly DependencyPropertyKey OOw;

	public static readonly DependencyProperty DefaultDirectionProperty;

	public static readonly DependencyProperty DefaultDurationProperty;

	public static readonly DependencyProperty DefaultModeProperty;

	public static readonly DependencyProperty IsFirstContentTransitionEnabledProperty;

	public static readonly DependencyProperty IsPostTransitionFocusEnabledProperty;

	public static readonly DependencyProperty IsTransitioningProperty;

	public static readonly DependencyProperty IsTransitioningEnabledProperty;

	public static readonly DependencyProperty IsTransitioningSuspendedProperty;

	public static readonly DependencyProperty TransitionProperty;

	public static readonly DependencyProperty TransitionSelectorProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private UIElementCollection PO4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Transition tOu;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool XO2;

	private static TransitionPresenter fHu;

	internal UIElementCollection Children
	{
		[CompilerGenerated]
		get
		{
			return PO4;
		}
		[CompilerGenerated]
		private set
		{
			PO4 = value;
		}
	}

	internal Transition CurrentTransition
	{
		[CompilerGenerated]
		get
		{
			return tOu;
		}
		[CompilerGenerated]
		set
		{
			tOu = value;
		}
	}

	internal virtual bool IsTransitioningOnNewContentEnabled => true;

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

	public bool IsFirstContentTransitionEnabled
	{
		get
		{
			return (bool)GetValue(IsFirstContentTransitionEnabledProperty);
		}
		set
		{
			SetValue(IsFirstContentTransitionEnabledProperty, value);
		}
	}

	public bool IsPostTransitionFocusEnabled
	{
		get
		{
			return (bool)GetValue(IsPostTransitionFocusEnabledProperty);
		}
		set
		{
			SetValue(IsPostTransitionFocusEnabledProperty, value);
		}
	}

	public bool IsTransitioning
	{
		get
		{
			return (bool)GetValue(IsTransitioningProperty);
		}
		internal set
		{
			SetValue(OOw, value);
		}
	}

	public bool IsTransitioningEnabled
	{
		get
		{
			return (bool)GetValue(IsTransitioningEnabledProperty);
		}
		set
		{
			SetValue(IsTransitioningEnabledProperty, value);
		}
	}

	public bool IsTransitioningSuspended
	{
		get
		{
			return (bool)GetValue(IsTransitioningSuspendedProperty);
		}
		set
		{
			SetValue(IsTransitioningSuspendedProperty, value);
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

	protected override int VisualChildrenCount
	{
		get
		{
			if (Children != null)
			{
				return Children.Count;
			}
			return 0;
		}
	}

	[Description("Occurs after a transition has completed.")]
	public event RoutedPropertyChangedEventHandler<object> TransitionCompleted
	{
		add
		{
			AddHandler(TransitionCompletedEvent, value);
		}
		remove
		{
			RemoveHandler(TransitionCompletedEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static TransitionPresenter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		TransitionCompletedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109850), RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<object>), typeof(TransitionPresenter));
		OOw = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109892), typeof(bool), typeof(TransitionPresenter), new FrameworkPropertyMetadata(false));
		DefaultDirectionProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109926), typeof(TransitionDirection), typeof(TransitionPresenter), new FrameworkPropertyMetadata(TransitionDirection.Forward));
		int num = 0;
		if (true)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				ContentPresenter.ContentTemplateSelectorProperty.OverrideMetadata(typeof(TransitionPresenter), new FrameworkPropertyMetadata(null, pOy));
				eOm = new DataTemplate();
				eOm.Seal();
				return;
			}
			DefaultDurationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109962), typeof(Duration), typeof(TransitionPresenter), new FrameworkPropertyMetadata(new Duration(TimeSpan.FromMilliseconds(200.0))));
			DefaultModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109996), typeof(TransitionMode), typeof(TransitionPresenter), new FrameworkPropertyMetadata(TransitionMode.In));
			IsFirstContentTransitionEnabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110022), typeof(bool), typeof(TransitionPresenter), new FrameworkPropertyMetadata(true));
			IsPostTransitionFocusEnabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110088), typeof(bool), typeof(TransitionPresenter), new FrameworkPropertyMetadata(false));
			IsTransitioningProperty = OOw.DependencyProperty;
			IsTransitioningEnabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110148), typeof(bool), typeof(TransitionPresenter), new FrameworkPropertyMetadata(true));
			IsTransitioningSuspendedProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110196), typeof(bool), typeof(TransitionPresenter), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits, NOf));
			TransitionProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110248), typeof(Transition), typeof(TransitionPresenter), new FrameworkPropertyMetadata(null, POB));
			TransitionSelectorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110272), typeof(TransitionSelector), typeof(TransitionPresenter), new FrameworkPropertyMetadata(null));
			UIElement.ClipToBoundsProperty.OverrideMetadata(typeof(TransitionPresenter), new FrameworkPropertyMetadata(null, WOT));
			ContentPresenter.ContentProperty.OverrideMetadata(typeof(TransitionPresenter), new FrameworkPropertyMetadata(null, LOp));
			ContentPresenter.ContentTemplateProperty.OverrideMetadata(typeof(TransitionPresenter), new FrameworkPropertyMetadata(null, sOb));
			num = 1;
			if (false)
			{
				int num2;
				num = num2;
			}
		}
	}

	public TransitionPresenter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		bO9 = new ContentPresenter();
		kOh = new ContentPresenter();
		Children = new UIElementCollection(this, null);
	}

	private static object WOT(DependencyObject P_0, object P_1)
	{
		TransitionPresenter transitionPresenter = (TransitionPresenter)P_0;
		if (!(bool)P_1 && transitionPresenter.IsTransitioning && transitionPresenter.CurrentTransition != null && transitionPresenter.CurrentTransition.ClipToBounds)
		{
			return true;
		}
		return P_1;
	}

	private static object POB(DependencyObject P_0, object P_1)
	{
		TransitionPresenter transitionPresenter = (TransitionPresenter)P_0;
		if (!transitionPresenter.IsTransitioning)
		{
			return P_1;
		}
		return transitionPresenter.CurrentTransition;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool wO3()
	{
		return XO2;
	}

	[SpecialName]
	[CompilerGenerated]
	private void VOt(bool value)
	{
		XO2 = value;
	}

	private static void LOp(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TransitionPresenter transitionPresenter = (TransitionPresenter)P_0;
		if (transitionPresenter.IsTransitioningOnNewContentEnabled)
		{
			transitionPresenter.UOi();
		}
	}

	private static void sOb(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TransitionPresenter transitionPresenter = (TransitionPresenter)P_0;
		if (transitionPresenter.IsTransitioningOnNewContentEnabled)
		{
			transitionPresenter.UOi();
		}
	}

	private static void pOy(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TransitionPresenter transitionPresenter = (TransitionPresenter)P_0;
		if (transitionPresenter.IsTransitioningOnNewContentEnabled)
		{
			transitionPresenter.UOi();
		}
	}

	internal virtual void OnIsTransitioningSuspendedChanged(bool oldValue, bool newValue)
	{
		if (wO3() && !IsTransitioningSuspended)
		{
			VOt(value: false);
			UOi();
		}
	}

	private static void NOf(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is TransitionPresenter transitionPresenter)
		{
			transitionPresenter.OnIsTransitioningSuspendedChanged((bool)P_1.OldValue, (bool)P_1.NewValue);
		}
	}

	internal virtual void OnTransitionCompleted()
	{
		object content = bO9.Content;
		object content2 = kOh.Content;
		Children.Remove(bO9);
		if (!Children.Contains(kOh))
		{
			Children.Add(kOh);
		}
		bO9.Visibility = Visibility.Visible;
		kOh.Visibility = Visibility.Visible;
		bO9.Content = null;
		bO9.ContentTemplate = null;
		bO9.ContentTemplateSelector = null;
		bO9.ApplyTemplate();
		IsTransitioning = false;
		CurrentTransition = null;
		CoerceValue(UIElement.ClipToBoundsProperty);
		CoerceValue(TransitionProperty);
		CoerceValue(ContentPresenter.ContentProperty);
		CoerceValue(ContentPresenter.ContentTemplateProperty);
		CoerceValue(ContentPresenter.ContentTemplateSelectorProperty);
		if (!base.IsInitialized && content2 is FrameworkElement frameworkElement)
		{
			frameworkElement.InvalidateProperty(FrameworkElement.DataContextProperty);
		}
		if (IsPostTransitionFocusEnabled && base.Content != null)
		{
			UIElement uIElement = base.Content as UIElement;
			if (uIElement == null || !uIElement.Focusable)
			{
				uIElement = VisualTreeHelperExtended.GetFirstFocusableDescendant(kOh);
			}
			uIElement?.Focus();
		}
		OnTransitionCompleted(content, content2);
	}

	private void UOi()
	{
		if (IsTransitioningSuspended)
		{
			VOt(value: true);
			return;
		}
		Transition transition = Transition;
		if (transition == null)
		{
			TransitionSelector transitionSelector = TransitionSelector;
			if (transitionSelector != null)
			{
				transition = transitionSelector.SelectTransition(this, kOh.Content, base.Content);
			}
		}
		if (!IsFirstContentTransitionEnabled && kOh.Content == null)
		{
			transition = null;
		}
		if (!IsTransitioningEnabled || !base.IsVisible)
		{
			transition = null;
		}
		ContentPresenter contentPresenter = bO9;
		bO9 = kOh;
		kOh = contentPresenter;
		kOh.Content = base.Content;
		kOh.ContentTemplate = base.ContentTemplate;
		kOh.ContentTemplateSelector = base.ContentTemplateSelector;
		if (base.Content is UIElement)
		{
			((UIElement)base.Content).Visibility = Visibility.Visible;
			((UIElement)base.Content).UpdateLayout();
		}
		if (transition != null)
		{
			IsTransitioning = true;
			CurrentTransition = transition;
			CoerceValue(UIElement.ClipToBoundsProperty);
			CoerceValue(TransitionProperty);
			if (Children.Contains(kOh))
			{
				Children.Remove(kOh);
			}
			if (transition.IsToContentTopMost)
			{
				Children.Add(kOh);
			}
			else
			{
				Children.Insert(0, kOh);
			}
			transition.BeginTransition(this, bO9, kOh);
		}
		else
		{
			OnTransitionCompleted();
		}
	}

	protected override Size ArrangeOverride(Size arrangeSize)
	{
		foreach (UIElement child in Children)
		{
			child?.Arrange(new Rect(arrangeSize));
		}
		return arrangeSize;
	}

	protected override DataTemplate ChooseTemplate()
	{
		DataTemplate dataTemplate = base.ChooseTemplate();
		if (dataTemplate != null && string.Compare(dataTemplate.GetType().Name, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110312), StringComparison.Ordinal) == 0)
		{
			int num = 0;
			if (cH5() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => dataTemplate, 
			};
		}
		return eOm;
	}

	protected override Visual GetVisualChild(int index)
	{
		if (index < 0 || index >= Children.Count)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(196));
		}
		return Children[index];
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		Size result = default(Size);
		foreach (UIElement child in Children)
		{
			if (child != null)
			{
				child.Measure(availableSize);
				result.Width = Math.Max(result.Width, child.DesiredSize.Width);
				result.Height = Math.Max(result.Height, child.DesiredSize.Height);
			}
		}
		return result;
	}

	protected virtual void OnTransitionCompleted(object fromContent, object toContent)
	{
		RoutedPropertyChangedEventArgs<object> e = new RoutedPropertyChangedEventArgs<object>(fromContent, toContent, TransitionCompletedEvent);
		e.Source = this;
		RaiseEvent(e);
	}

	internal static bool sHo()
	{
		return fHu == null;
	}

	internal static TransitionPresenter cH5()
	{
		return fHu;
	}
}
