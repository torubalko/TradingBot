using System;
using System.Windows;
using System.Windows.Input;
using ActiproSoftware.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public static class ThemeProperties
{
	public static readonly DependencyProperty BorderMarginProperty;

	public static readonly DependencyProperty CornerRadiusProperty;

	public static readonly DependencyProperty DisabledOpacityProperty;

	public static readonly DependencyProperty InnerBorderThicknessProperty;

	public static readonly DependencyProperty IsActiveProperty;

	public static readonly DependencyProperty IsAnimationEnabledProperty;

	public static readonly DependencyProperty IsGlassEnabledProperty;

	public static readonly DependencyProperty IsMouseWheelEnabledProperty;

	public static readonly DependencyProperty IsTransparencyModeEnabledProperty;

	public static readonly DependencyProperty UseAlternateStyleProperty;

	public static readonly DependencyProperty UseBackgroundStatesProperty;

	public static readonly DependencyProperty UseBorderStatesProperty;

	public static readonly DependencyProperty ZoomLevelProperty;

	internal static ThemeProperties YY5;

	private static void Ru2(object P_0, MouseWheelEventArgs P_1)
	{
		if (P_1 != null)
		{
			P_1.Handled = true;
		}
	}

	private static void Tue(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is UIElement uIElement)
		{
			if (true.Equals(P_1.NewValue))
			{
				uIElement.PreviewMouseWheel -= Ru2;
			}
			else
			{
				uIElement.PreviewMouseWheel += Ru2;
			}
		}
	}

	public static Thickness GetBorderMargin(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (Thickness)obj.GetValue(BorderMarginProperty);
	}

	public static void SetBorderMargin(DependencyObject obj, Thickness value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(BorderMarginProperty, value);
	}

	public static CornerRadius GetCornerRadius(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (CornerRadius)obj.GetValue(CornerRadiusProperty);
	}

	public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(CornerRadiusProperty, value);
	}

	public static double GetDisabledOpacity(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (double)obj.GetValue(DisabledOpacityProperty);
	}

	public static void SetDisabledOpacity(DependencyObject obj, double value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(DisabledOpacityProperty, value);
	}

	public static Thickness GetInnerBorderThickness(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (Thickness)obj.GetValue(InnerBorderThicknessProperty);
	}

	public static void SetInnerBorderThickness(DependencyObject obj, Thickness value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(InnerBorderThicknessProperty, value);
	}

	public static bool GetIsActive(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(IsActiveProperty);
	}

	public static void SetIsActive(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(IsActiveProperty, value);
	}

	public static bool GetIsAnimationEnabled(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(IsAnimationEnabledProperty);
	}

	public static void SetIsAnimationEnabled(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(IsAnimationEnabledProperty, value);
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

	public static bool GetIsMouseWheelEnabled(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(IsMouseWheelEnabledProperty);
	}

	public static void SetIsMouseWheelEnabled(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(IsMouseWheelEnabledProperty, value);
	}

	public static bool GetIsTransparencyModeEnabled(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(IsTransparencyModeEnabledProperty);
	}

	public static void SetIsTransparencyModeEnabled(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(IsTransparencyModeEnabledProperty, value);
	}

	public static bool GetUseAlternateStyle(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(UseAlternateStyleProperty);
	}

	public static void SetUseAlternateStyle(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(UseAlternateStyleProperty, value);
	}

	public static bool GetUseBackgroundStates(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(UseBackgroundStatesProperty);
	}

	public static void SetUseBackgroundStates(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(UseBackgroundStatesProperty, value);
	}

	public static bool GetUseBorderStates(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(UseBorderStatesProperty);
	}

	public static void SetUseBorderStates(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(UseBorderStatesProperty, value);
	}

	public static double GetZoomLevel(DependencyObject obj)
	{
		if (obj != null)
		{
			return (double)obj.GetValue(ZoomLevelProperty);
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
	}

	public static void SetZoomLevel(DependencyObject obj, double value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(ZoomLevelProperty, value);
	}

	static ThemeProperties()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		BorderMarginProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97502), typeof(Thickness), typeof(ThemeProperties), new FrameworkPropertyMetadata(new Thickness(0.0)));
		CornerRadiusProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97530), typeof(CornerRadius), typeof(ThemeProperties), new FrameworkPropertyMetadata(new CornerRadius(0.0)));
		DisabledOpacityProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97558), typeof(double), typeof(ThemeProperties), new FrameworkPropertyMetadata(0.6), (object o) => ValidationHelper.ValidateDoubleIsBetweenInclusive(o, 0.0, 1.0));
		InnerBorderThicknessProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97592), typeof(Thickness), typeof(ThemeProperties), new FrameworkPropertyMetadata(new Thickness(0.0)));
		IsActiveProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97636), typeof(bool), typeof(ThemeProperties), new FrameworkPropertyMetadata(false));
		IsAnimationEnabledProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97656), typeof(bool), typeof(ThemeProperties), new FrameworkPropertyMetadata(true));
		IsGlassEnabledProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97696), typeof(bool), typeof(ThemeProperties), new FrameworkPropertyMetadata(true));
		IsMouseWheelEnabledProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97728), typeof(bool), typeof(ThemeProperties), new FrameworkPropertyMetadata(true, Tue));
		IsTransparencyModeEnabledProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97770), typeof(bool), typeof(ThemeProperties), new FrameworkPropertyMetadata(true));
		UseAlternateStyleProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97824), typeof(bool), typeof(ThemeProperties), new FrameworkPropertyMetadata(false));
		UseBackgroundStatesProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97862), typeof(bool), typeof(ThemeProperties), new FrameworkPropertyMetadata(true));
		UseBorderStatesProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97904), typeof(bool), typeof(ThemeProperties), new FrameworkPropertyMetadata(true));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		ZoomLevelProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97938), typeof(double), typeof(ThemeProperties), new FrameworkPropertyMetadata(1.0));
	}

	internal static bool zYm()
	{
		return YY5 == null;
	}

	internal static ThemeProperties RYZ()
	{
		return YY5;
	}
}
