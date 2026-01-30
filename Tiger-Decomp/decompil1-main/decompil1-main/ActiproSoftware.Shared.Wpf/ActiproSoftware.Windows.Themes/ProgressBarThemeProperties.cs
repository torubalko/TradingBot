using System;
using System.Windows;
using ActiproSoftware.Windows.Controls;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public static class ProgressBarThemeProperties
{
	public static readonly DependencyProperty IsContinuousProperty;

	public static readonly DependencyProperty IsGlassEnabledProperty;

	public static readonly DependencyProperty StateProperty;

	public static readonly DependencyProperty UseHighlightForIndeterminateIndicatorProperty;

	internal static ProgressBarThemeProperties hYC;

	public static bool GetIsContinuous(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(IsContinuousProperty);
	}

	public static void SetIsContinuous(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(IsContinuousProperty, value);
	}

	public static bool GetIsGlassEnabled(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(IsGlassEnabledProperty);
	}

	public static void SetIsGlassEnabled(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(IsGlassEnabledProperty, value);
	}

	public static OperationState GetState(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (OperationState)obj.GetValue(StateProperty);
	}

	public static void SetState(DependencyObject obj, OperationState value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(StateProperty, value);
	}

	public static bool GetUseHighlightForIndeterminateIndicator(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(UseHighlightForIndeterminateIndicatorProperty);
	}

	public static void SetUseHighlightForIndeterminateIndicator(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(UseHighlightForIndeterminateIndicatorProperty, value);
	}

	static ProgressBarThemeProperties()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		IsContinuousProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97358), typeof(bool), typeof(ProgressBarThemeProperties), new FrameworkPropertyMetadata(true));
		IsGlassEnabledProperty = ThemeProperties.IsGlassEnabledProperty.AddOwner(typeof(ProgressBarThemeProperties));
		StateProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97386), typeof(OperationState), typeof(ProgressBarThemeProperties), new FrameworkPropertyMetadata(OperationState.Normal));
		UseHighlightForIndeterminateIndicatorProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97400), typeof(bool), typeof(ProgressBarThemeProperties), new FrameworkPropertyMetadata(true));
	}

	internal static bool WYR()
	{
		return hYC == null;
	}

	internal static ProgressBarThemeProperties iY9()
	{
		return hYC;
	}
}
