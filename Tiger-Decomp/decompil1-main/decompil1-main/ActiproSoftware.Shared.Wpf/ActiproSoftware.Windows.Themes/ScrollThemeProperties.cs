using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public static class ScrollThemeProperties
{
	public static readonly DependencyProperty HasButtonsProperty;

	internal static ScrollThemeProperties UYc;

	[AttachedPropertyBrowsableForType(typeof(ScrollViewer))]
	[AttachedPropertyBrowsableForType(typeof(ScrollBar))]
	public static bool GetHasButtons(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(HasButtonsProperty);
	}

	public static void SetHasButtons(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HasButtonsProperty, value);
	}

	static ScrollThemeProperties()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		HasButtonsProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97478), typeof(bool), typeof(ScrollThemeProperties), new FrameworkPropertyMetadata(true));
	}

	internal static bool dYu()
	{
		return UYc == null;
	}

	internal static ScrollThemeProperties KYo()
	{
		return UYc;
	}
}
