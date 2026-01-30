using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Headered")]
public static class HeaderedControlThemeProperties
{
	public static readonly DependencyProperty HeaderBackgroundProperty;

	public static readonly DependencyProperty HeaderBorderBrushProperty;

	public static readonly DependencyProperty HeaderBorderThicknessProperty;

	public static readonly DependencyProperty HeaderContextMenuProperty;

	public static readonly DependencyProperty HeaderCornerRadiusProperty;

	public static readonly DependencyProperty HeaderFontSizeProperty;

	public static readonly DependencyProperty HeaderForegroundProperty;

	public static readonly DependencyProperty HeaderGlyphTemplateProperty;

	public static readonly DependencyProperty HeaderPaddingProperty;

	public static readonly DependencyProperty HeaderStyleProperty;

	internal static HeaderedControlThemeProperties IYa;

	public static Brush GetHeaderBackground(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (Brush)obj.GetValue(HeaderBackgroundProperty);
	}

	public static void SetHeaderBackground(DependencyObject obj, Brush value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HeaderBackgroundProperty, value);
	}

	public static Brush GetHeaderBorderBrush(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (Brush)obj.GetValue(HeaderBorderBrushProperty);
	}

	public static void SetHeaderBorderBrush(DependencyObject obj, Brush value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HeaderBorderBrushProperty, value);
	}

	public static Thickness GetHeaderBorderThickness(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (Thickness)obj.GetValue(HeaderBorderThicknessProperty);
	}

	public static void SetHeaderBorderThickness(DependencyObject obj, Thickness value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HeaderBorderThicknessProperty, value);
	}

	public static ContextMenu GetHeaderContextMenu(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (ContextMenu)obj.GetValue(HeaderContextMenuProperty);
	}

	public static void SetHeaderContextMenu(DependencyObject obj, ContextMenu value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HeaderContextMenuProperty, value);
	}

	public static CornerRadius GetHeaderCornerRadius(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (CornerRadius)obj.GetValue(HeaderCornerRadiusProperty);
	}

	public static void SetHeaderCornerRadius(DependencyObject obj, CornerRadius value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HeaderCornerRadiusProperty, value);
	}

	public static double GetHeaderFontSize(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (double)obj.GetValue(HeaderFontSizeProperty);
	}

	public static void SetHeaderFontSize(DependencyObject obj, double value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HeaderFontSizeProperty, value);
	}

	public static Brush GetHeaderForeground(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (Brush)obj.GetValue(HeaderForegroundProperty);
	}

	public static void SetHeaderForeground(DependencyObject obj, Brush value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HeaderForegroundProperty, value);
	}

	public static DataTemplate GetHeaderGlyphTemplate(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (DataTemplate)obj.GetValue(HeaderGlyphTemplateProperty);
	}

	public static void SetHeaderGlyphTemplate(DependencyObject obj, DataTemplate value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HeaderGlyphTemplateProperty, value);
	}

	public static Thickness GetHeaderPadding(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (Thickness)obj.GetValue(HeaderPaddingProperty);
	}

	public static void SetHeaderPadding(DependencyObject obj, Thickness value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HeaderPaddingProperty, value);
	}

	public static Style GetHeaderStyle(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (Style)obj.GetValue(HeaderStyleProperty);
	}

	public static void SetHeaderStyle(DependencyObject obj, Style value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HeaderStyleProperty, value);
	}

	static HeaderedControlThemeProperties()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		HeaderBackgroundProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96994), typeof(Brush), typeof(HeaderedControlThemeProperties), new FrameworkPropertyMetadata(null));
		HeaderBorderBrushProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97030), typeof(Brush), typeof(HeaderedControlThemeProperties), new FrameworkPropertyMetadata(null));
		HeaderBorderThicknessProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97068), typeof(Thickness), typeof(HeaderedControlThemeProperties), new FrameworkPropertyMetadata(new Thickness(0.0)));
		HeaderContextMenuProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97114), typeof(ContextMenu), typeof(HeaderedControlThemeProperties), new FrameworkPropertyMetadata(null));
		HeaderCornerRadiusProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97152), typeof(CornerRadius), typeof(HeaderedControlThemeProperties), new FrameworkPropertyMetadata(new CornerRadius(0.0)));
		HeaderFontSizeProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97192), typeof(double), typeof(HeaderedControlThemeProperties), new FrameworkPropertyMetadata(15.0));
		HeaderForegroundProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97224), typeof(Brush), typeof(HeaderedControlThemeProperties), new FrameworkPropertyMetadata(null));
		HeaderGlyphTemplateProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97260), typeof(DataTemplate), typeof(HeaderedControlThemeProperties), new FrameworkPropertyMetadata(null));
		HeaderPaddingProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97302), typeof(Thickness), typeof(HeaderedControlThemeProperties), new FrameworkPropertyMetadata(new Thickness(0.0)));
		HeaderStyleProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97332), typeof(Style), typeof(HeaderedControlThemeProperties), new FrameworkPropertyMetadata(null));
	}

	internal static bool QYy()
	{
		return IYa == null;
	}

	internal static HeaderedControlThemeProperties bYQ()
	{
		return IYa;
	}
}
