using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class RadioButtonList : ListBox
{
	public static readonly DependencyProperty AutoDisableNonSelectedItemContentProperty;

	public static readonly DependencyProperty BulletMarginProperty;

	public static readonly DependencyProperty BulletVerticalAlignmentProperty;

	public static readonly DependencyProperty OrientationProperty;

	private static RadioButtonList NGl;

	public bool AutoDisableNonSelectedItemContent
	{
		get
		{
			return (bool)GetValue(AutoDisableNonSelectedItemContentProperty);
		}
		set
		{
			SetValue(AutoDisableNonSelectedItemContentProperty, value);
		}
	}

	public Thickness BulletMargin
	{
		get
		{
			return (Thickness)GetValue(BulletMarginProperty);
		}
		set
		{
			SetValue(BulletMarginProperty, value);
		}
	}

	public VerticalAlignment BulletVerticalAlignment
	{
		get
		{
			return (VerticalAlignment)GetValue(BulletVerticalAlignmentProperty);
		}
		set
		{
			SetValue(BulletVerticalAlignmentProperty, value);
		}
	}

	public Orientation Orientation
	{
		get
		{
			return (Orientation)GetValue(OrientationProperty);
		}
		set
		{
			SetValue(OrientationProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static RadioButtonList()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		AutoDisableNonSelectedItemContentProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115882), typeof(bool), typeof(RadioButtonList), new FrameworkPropertyMetadata(false));
		BulletMarginProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115952), typeof(Thickness), typeof(RadioButtonList), new FrameworkPropertyMetadata(new Thickness(0.0, 0.0, 5.0, 0.0)));
		BulletVerticalAlignmentProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115980), typeof(VerticalAlignment), typeof(RadioButtonList), new FrameworkPropertyMetadata(VerticalAlignment.Center));
		OrientationProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116030), typeof(Orientation), typeof(RadioButtonList), new FrameworkPropertyMetadata(Orientation.Vertical));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(RadioButtonList), new FrameworkPropertyMetadata(typeof(RadioButtonList)));
		EventManager.RegisterClassHandler(typeof(ListBoxItem), AccessKeyManager.AccessKeyPressedEvent, new AccessKeyPressedEventHandler(oCB));
	}

	private static void oCB(object P_0, AccessKeyPressedEventArgs P_1)
	{
		ListBoxItem listBoxItem = P_0 as ListBoxItem;
		if (P_1.Handled || P_1.Scope != null || P_1.Target != null)
		{
			return;
		}
		int num = 0;
		if (BGx() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (P_1.Key != null && listBoxItem != null && ItemsControl.ItemsControlFromItemContainer(listBoxItem) is RadioButtonList)
		{
			P_1.Target = listBoxItem;
			listBoxItem.IsSelected = true;
			P_1.Handled = true;
		}
	}

	[AttachedPropertyBrowsableForChildren]
	public static Thickness GetBulletMargin(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (Thickness)obj.GetValue(BulletMarginProperty);
	}

	public static void SetBulletMargin(DependencyObject obj, Thickness value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(BulletMarginProperty, value);
	}

	[AttachedPropertyBrowsableForChildren]
	public static VerticalAlignment GetBulletVerticalAlignment(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (VerticalAlignment)obj.GetValue(BulletVerticalAlignmentProperty);
	}

	public static void SetBulletVerticalAlignment(DependencyObject obj, VerticalAlignment value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(BulletVerticalAlignmentProperty, value);
	}

	public RadioButtonList()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool bGE()
	{
		return NGl == null;
	}

	internal static RadioButtonList BGx()
	{
		return NGl;
	}
}
