using System;
using System.Windows;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public static class ExpanderThemeProperties
{
	public static readonly DependencyProperty CanMeasureCollapsedContentProperty;

	public static readonly DependencyProperty CollapseDurationProperty;

	public static readonly DependencyProperty ExpandDurationProperty;

	internal static ExpanderThemeProperties TYF;

	public static bool GetCanMeasureCollapsedContent(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(CanMeasureCollapsedContentProperty);
	}

	public static void SetCanMeasureCollapsedContent(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(CanMeasureCollapsedContentProperty, value);
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

	static ExpanderThemeProperties()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		CanMeasureCollapsedContentProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96870), typeof(bool), typeof(ExpanderThemeProperties), new FrameworkPropertyMetadata(true));
		CollapseDurationProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96926), typeof(Duration), typeof(ExpanderThemeProperties), new FrameworkPropertyMetadata(new Duration(TimeSpan.FromMilliseconds(150.0))));
		ExpandDurationProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96962), typeof(Duration), typeof(ExpanderThemeProperties), new FrameworkPropertyMetadata(new Duration(TimeSpan.FromMilliseconds(150.0))));
	}

	internal static bool UYd()
	{
		return TYF == null;
	}

	internal static ExpanderThemeProperties dYv()
	{
		return TYF;
	}
}
