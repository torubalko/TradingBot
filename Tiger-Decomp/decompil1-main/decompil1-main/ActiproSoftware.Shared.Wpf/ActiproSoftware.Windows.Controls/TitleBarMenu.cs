using System;
using System.Windows;
using System.Windows.Controls;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class TitleBarMenu : Menu
{
	internal static readonly DependencyPropertyKey IsInTitleBarPropertyKey;

	public static readonly DependencyProperty IsInTitleBarProperty;

	private static TitleBarMenu kn3;

	public TitleBarMenu()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		base.DefaultStyleKey = typeof(TitleBarMenu);
	}

	[AttachedPropertyBrowsableForType(typeof(MenuItem))]
	public static bool GetIsInTitleBar(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(IsInTitleBarProperty);
	}

	private static void SetIsInTitleBar(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(IsInTitleBarPropertyKey, value);
	}

	protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
	{
		base.PrepareContainerForItemOverride(element, item);
		SetIsInTitleBar(element, value: true);
	}

	static TitleBarMenu()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		IsInTitleBarPropertyKey = DependencyProperty.RegisterAttachedReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116788), typeof(bool), typeof(TitleBarMenu), new FrameworkPropertyMetadata(false));
		IsInTitleBarProperty = IsInTitleBarPropertyKey.DependencyProperty;
	}

	internal static bool NnN()
	{
		return kn3 == null;
	}

	internal static TitleBarMenu ynO()
	{
		return kn3;
	}
}
