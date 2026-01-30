using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public static class ContextMenuThemeProperties
{
	public static readonly DependencyProperty CanAdjustOffsetsForShadowProperty;

	private static readonly DependencyProperty Au4;

	private static readonly DependencyProperty muu;

	internal static ContextMenuThemeProperties HY6;

	[AttachedPropertyBrowsableForType(typeof(ContextMenu))]
	private static double Au3(DependencyObject P_0)
	{
		if (P_0 != null)
		{
			return (double)P_0.GetValue(Au4);
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
	}

	private static void sut(DependencyObject P_0, double P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		P_0.SetValue(Au4, P_1);
	}

	[AttachedPropertyBrowsableForType(typeof(ContextMenu))]
	private static double luJ(DependencyObject P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (double)P_0.GetValue(muu);
	}

	private static void Iu9(DependencyObject P_0, double P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		P_0.SetValue(muu, P_1);
	}

	private static void Huh(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is ContextMenu contextMenu)
		{
			if (true.Equals(P_1.NewValue))
			{
				contextMenu.Closed += dum;
				contextMenu.Opened += luw;
			}
			else
			{
				contextMenu.Closed -= dum;
				contextMenu.Opened -= luw;
			}
		}
	}

	private static void dum(object P_0, RoutedEventArgs P_1)
	{
		if (P_0 is ContextMenu { HasDropShadow: not false } contextMenu)
		{
			contextMenu.HorizontalOffset = Au3(contextMenu);
			contextMenu.VerticalOffset = luJ(contextMenu);
			contextMenu.ClearValue(Au4);
			contextMenu.ClearValue(muu);
		}
	}

	private static void luw(object P_0, RoutedEventArgs P_1)
	{
		if (!(P_0 is ContextMenu { HasDropShadow: not false } contextMenu) || contextMenu.ReadLocalValue(Au4) != DependencyProperty.UnsetValue)
		{
			return;
		}
		sut(contextMenu, contextMenu.HorizontalOffset);
		Iu9(contextMenu, contextMenu.VerticalOffset);
		ShadowChrome descendant = VisualTreeHelperExtended.GetDescendant<ShadowChrome>(contextMenu, 0);
		if (descendant == null)
		{
			return;
		}
		Thickness margin = descendant.Margin;
		Size size = new Size(1.0, 1.0);
		UIElement placementTarget = contextMenu.PlacementTarget;
		if (placementTarget != null)
		{
			Visual visual = PresentationSource.FromVisual(placementTarget)?.RootVisual;
			if (visual != null)
			{
				size = placementTarget.TransformToAncestor(visual).TransformBounds(new Rect(0.0, 0.0, 1.0, 1.0)).Size;
				if (size.Width > 0.1)
				{
					margin.Left /= size.Width;
				}
				if (size.Height > 0.1)
				{
					margin.Top /= size.Height;
				}
			}
		}
		contextMenu.HorizontalOffset -= (double)((!SystemParameters.IsMenuDropRightAligned) ? 1 : (-1)) * margin.Left;
		contextMenu.VerticalOffset -= margin.Top;
	}

	[AttachedPropertyBrowsableForType(typeof(ContextMenu))]
	public static bool GetCanAdjustOffsetsForShadow(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(CanAdjustOffsetsForShadowProperty);
	}

	public static void SetCanAdjustOffsetsForShadow(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(CanAdjustOffsetsForShadowProperty, value);
	}

	static ContextMenuThemeProperties()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		CanAdjustOffsetsForShadowProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96736), typeof(bool), typeof(ContextMenuThemeProperties), new FrameworkPropertyMetadata(false, Huh));
		Au4 = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96790), typeof(double), typeof(ContextMenuThemeProperties), new FrameworkPropertyMetadata(0.0));
		muu = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96832), typeof(double), typeof(ContextMenuThemeProperties), new FrameworkPropertyMetadata(0.0));
	}

	internal static bool lYw()
	{
		return HY6 == null;
	}

	internal static ContextMenuThemeProperties sYk()
	{
		return HY6;
	}
}
