using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

[ContentProperty("Content")]
public class ToggleTransitionPresenter : TransitionPresenter
{
	private ContentPresenter MOj;

	private ContentPresenter contentPresenter;

	private bool POv;

	public static readonly DependencyProperty AlternateContentProperty;

	public static readonly DependencyProperty AlternateContentTemplateProperty;

	public static readonly DependencyProperty AlternateContentTemplateSelectorProperty;

	public static readonly DependencyProperty IsAlternateContentVisibleProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool UOX;

	private static ToggleTransitionPresenter xHw;

	internal override bool IsTransitioningOnNewContentEnabled => false;

	public object AlternateContent
	{
		get
		{
			return GetValue(AlternateContentProperty);
		}
		set
		{
			SetValue(AlternateContentProperty, value);
		}
	}

	public DataTemplate AlternateContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(AlternateContentTemplateProperty);
		}
		set
		{
			SetValue(AlternateContentTemplateProperty, value);
		}
	}

	public DataTemplateSelector AlternateContentTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(AlternateContentTemplateSelectorProperty);
		}
		set
		{
			SetValue(AlternateContentTemplateSelectorProperty, value);
		}
	}

	public bool IsAlternateContentVisible
	{
		get
		{
			return (bool)GetValue(IsAlternateContentVisibleProperty);
		}
		set
		{
			SetValue(IsAlternateContentVisibleProperty, value);
		}
	}

	public ToggleTransitionPresenter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		contentPresenter = new ContentPresenter();
		contentPresenter.SetBinding(ContentPresenter.ContentProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109242))
		{
			Source = this
		});
		contentPresenter.SetBinding(ContentPresenter.ContentTemplateProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109260))
		{
			Source = this
		});
		contentPresenter.SetBinding(ContentPresenter.ContentTemplateSelectorProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109294))
		{
			Source = this
		});
		contentPresenter.IsEnabledChanged += lQ8;
		contentPresenter.IsVisibleChanged += sQD;
		MOj = new ContentPresenter();
		MOj.SetBinding(ContentPresenter.ContentProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109344))
		{
			Source = this
		});
		MOj.SetBinding(ContentPresenter.ContentTemplateProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109380))
		{
			Source = this
		});
		MOj.SetBinding(ContentPresenter.ContentTemplateSelectorProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109432))
		{
			Source = this
		});
		MOj.Visibility = Visibility.Collapsed;
		base.Children.Add(contentPresenter);
		base.Children.Add(MOj);
	}

	[SpecialName]
	[CompilerGenerated]
	private bool pQ1()
	{
		return UOX;
	}

	[SpecialName]
	[CompilerGenerated]
	private void jQz(bool value)
	{
		UOX = value;
	}

	private void lQ8(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		POv = true;
	}

	private void sQD(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (POv && (bool)P_1.NewValue && VisualTreeHelperExtended.GetFirstChild(contentPresenter) is UIElement uIElement)
		{
			uIElement.InvalidateMeasure();
			uIElement.InvalidateProperty(UIElement.IsEnabledProperty);
			POv = false;
		}
	}

	private static void gQP(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ToggleTransitionPresenter toggleTransitionPresenter = (ToggleTransitionPresenter)P_0;
		if ((bool)P_1.NewValue != (bool)P_1.OldValue)
		{
			toggleTransitionPresenter.JQG();
		}
	}

	internal override void OnIsTransitioningSuspendedChanged(bool oldValue, bool newValue)
	{
		if (pQ1() && !base.IsTransitioningSuspended)
		{
			jQz(value: false);
			JQG();
		}
	}

	internal override void OnTransitionCompleted()
	{
		ContentPresenter mOj;
		ContentPresenter mOj2;
		if (IsAlternateContentVisible)
		{
			mOj = contentPresenter;
			mOj2 = MOj;
		}
		else
		{
			mOj = MOj;
			mOj2 = contentPresenter;
		}
		mOj.Visibility = Visibility.Collapsed;
		base.IsTransitioning = false;
		base.CurrentTransition = null;
		CoerceValue(UIElement.ClipToBoundsProperty);
		CoerceValue(TransitionPresenter.TransitionProperty);
		if (VisualTreeHelperExtended.GetFirstChild(mOj2) is UIElement uIElement)
		{
			uIElement.InvalidateProperty(UIElement.IsEnabledProperty);
		}
		if (base.IsPostTransitionFocusEnabled)
		{
			if (mOj2.Content is UIElement { Focusable: not false } uIElement2)
			{
				uIElement2.Focus();
			}
			else
			{
				VisualTreeHelperExtended.GetFirstFocusableDescendant(mOj2)?.Focus();
			}
		}
		OnTransitionCompleted(mOj, mOj2);
	}

	private void JQG()
	{
		if (base.IsTransitioningSuspended)
		{
			jQz(value: true);
			return;
		}
		ContentPresenter mOj;
		ContentPresenter mOj2;
		if (IsAlternateContentVisible)
		{
			mOj = contentPresenter;
			mOj2 = MOj;
		}
		else
		{
			mOj = MOj;
			mOj2 = contentPresenter;
		}
		Transition transition = base.Transition;
		if (transition == null)
		{
			TransitionSelector transitionSelector = base.TransitionSelector;
			if (transitionSelector != null)
			{
				transition = transitionSelector.SelectTransition(this, mOj2.Content, base.Content);
			}
		}
		if (!base.IsTransitioningEnabled || !base.IsVisible)
		{
			transition = null;
		}
		mOj2.Visibility = Visibility.Visible;
		if (transition != null)
		{
			base.IsTransitioning = true;
			base.CurrentTransition = transition;
			CoerceValue(UIElement.ClipToBoundsProperty);
			CoerceValue(TransitionPresenter.TransitionProperty);
			base.Children.Remove(mOj2);
			if (transition.IsToContentTopMost)
			{
				base.Children.Add(mOj2);
			}
			else
			{
				base.Children.Insert(0, mOj2);
			}
			transition.BeginTransition(this, mOj, mOj2);
		}
		else
		{
			OnTransitionCompleted();
		}
	}

	static ToggleTransitionPresenter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		AlternateContentProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109344), typeof(object), typeof(ToggleTransitionPresenter), new FrameworkPropertyMetadata(null));
		AlternateContentTemplateProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109380), typeof(DataTemplate), typeof(ToggleTransitionPresenter), new FrameworkPropertyMetadata(null));
		AlternateContentTemplateSelectorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109432), typeof(DataTemplateSelector), typeof(ToggleTransitionPresenter), new FrameworkPropertyMetadata(null));
		IsAlternateContentVisibleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109500), typeof(bool), typeof(ToggleTransitionPresenter), new FrameworkPropertyMetadata(false, gQP));
	}

	internal static bool cHk()
	{
		return xHw == null;
	}

	internal static ToggleTransitionPresenter lHF()
	{
		return xHw;
	}
}
