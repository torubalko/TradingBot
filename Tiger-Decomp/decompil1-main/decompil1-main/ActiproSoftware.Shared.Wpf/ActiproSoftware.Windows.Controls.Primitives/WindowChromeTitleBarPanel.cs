using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Windows.Themes;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
public class WindowChromeTitleBarPanel : Panel
{
	private double PZB;

	public static readonly DependencyProperty HeaderAlignmentProperty;

	public static readonly DependencyProperty HeaderMarginProperty;

	public static readonly DependencyProperty HeaderMinWidthProperty;

	public static readonly DependencyProperty LeftContentMaxWidthOverflowPercentageProperty;

	public static readonly DependencyProperty RightContentMaxWidthOverflowPercentageProperty;

	public static readonly DependencyProperty SlotAlignmentProperty;

	private static WindowChromeTitleBarPanel TbI;

	public HorizontalAlignment HeaderAlignment
	{
		get
		{
			return (HorizontalAlignment)GetValue(HeaderAlignmentProperty);
		}
		set
		{
			SetValue(HeaderAlignmentProperty, value);
		}
	}

	public Thickness HeaderMargin
	{
		get
		{
			return (Thickness)GetValue(HeaderMarginProperty);
		}
		set
		{
			SetValue(HeaderMarginProperty, value);
		}
	}

	public double HeaderMinWidth
	{
		get
		{
			return (double)GetValue(HeaderMinWidthProperty);
		}
		set
		{
			SetValue(HeaderMinWidthProperty, value);
		}
	}

	public double LeftContentMaxWidthOverflowPercentage
	{
		get
		{
			return (double)GetValue(LeftContentMaxWidthOverflowPercentageProperty);
		}
		set
		{
			SetValue(LeftContentMaxWidthOverflowPercentageProperty, value);
		}
	}

	public double RightContentMaxWidthOverflowPercentage
	{
		get
		{
			return (double)GetValue(RightContentMaxWidthOverflowPercentageProperty);
		}
		set
		{
			SetValue(RightContentMaxWidthOverflowPercentageProperty, value);
		}
	}

	private Thickness cZv(FrameworkElement P_0, ContentControl P_1, ContentControl P_2)
	{
		if (P_2 != null)
		{
			Thickness headerMargin = HeaderMargin;
			if ((P_1 == null || P_1.DesiredSize.Width == 0.0) && P_0 != null && P_0.IsVisible)
			{
				headerMargin.Left = 0.0;
			}
			return headerMargin;
		}
		return new Thickness(0.0);
	}

	private Tuple<ContentControl, ContentControl, ContentControl> sZX()
	{
		ContentControl item = null;
		ContentControl item2 = null;
		ContentControl item3 = null;
		foreach (UIElement child in base.Children)
		{
			if (child.GetType() == typeof(ContentControl))
			{
				switch (GetSlotAlignment(child))
				{
				case HorizontalAlignment.Left:
					item = (ContentControl)child;
					break;
				case HorizontalAlignment.Right:
					item3 = (ContentControl)child;
					break;
				default:
					item2 = (ContentControl)child;
					break;
				}
			}
		}
		return Tuple.Create(item, item2, item3);
	}

	private Tuple<double, double> LZT(double P_0, ContentControl P_1, ContentControl P_2, ContentControl P_3, ref Thickness P_4)
	{
		double value = 0.0;
		double value2 = 0.0;
		double num = Math.Max(0.01, LeftContentMaxWidthOverflowPercentage);
		double num2 = Math.Max(0.01, RightContentMaxWidthOverflowPercentage);
		if (num + num2 > 1.0)
		{
			num /= num + num2;
			num2 /= num + num2;
		}
		if (P_2 != null)
		{
			if (P_1 != null)
			{
				if (P_3 != null)
				{
					value = P_0 * num;
					value2 = P_0 * num2;
				}
				else
				{
					value = P_0 * num;
				}
			}
			else if (P_3 != null)
			{
				value2 = P_0 * num2;
			}
		}
		else if (P_1 != null)
		{
			if (P_3 != null)
			{
				value = P_0 * num;
				value2 = P_0 * num2;
			}
			else
			{
				value = P_0;
			}
		}
		else if (P_3 != null)
		{
			value2 = P_0;
		}
		value = Math.Round(value, MidpointRounding.AwayFromZero);
		value2 = Math.Round(value2, MidpointRounding.AwayFromZero);
		if (P_2 != null)
		{
			double num3 = Math.Max(0.0, Math.Round(P_0 - value - P_4.Left - P_4.Right - value2, MidpointRounding.AwayFromZero));
			double headerMinWidth = HeaderMinWidth;
			if (num3 < headerMinWidth)
			{
				if (P_0 < headerMinWidth)
				{
					value = 0.0;
					value2 = 0.0;
					double num4 = Math.Max(0.25, (headerMinWidth >= 1.0) ? (P_0 / headerMinWidth) : 1.0);
					P_4.Left = Math.Floor(P_4.Left * num4);
					P_4.Right = Math.Floor(P_4.Right * num4);
				}
				else if (value + value2 > 0.0)
				{
					double num5 = (headerMinWidth - num3) / (value + value2);
					value = Math.Max(0.0, Math.Round(value - num5 * value, MidpointRounding.AwayFromZero));
					value2 = Math.Max(0.0, Math.Round(value2 - num5 * value2, MidpointRounding.AwayFromZero));
				}
			}
		}
		return Tuple.Create(value, value2);
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		Tuple<ContentControl, ContentControl, ContentControl> tuple = sZX();
		ContentControl item = tuple.Item1;
		ContentControl item2 = tuple.Item2;
		ContentControl item3 = tuple.Item3;
		double num = 0.0;
		FrameworkElement frameworkElement = null;
		foreach (UIElement child in base.Children)
		{
			if (child != null && GetSlotAlignment(child) == HorizontalAlignment.Left && child != item)
			{
				child.Arrange(new Rect(num, 0.0, child.DesiredSize.Width, finalSize.Height));
				num += child.DesiredSize.Width;
				if (WindowChrome.GetElementKind(child) == WindowChromeElementKind.SystemMenu)
				{
					frameworkElement = child as FrameworkElement;
				}
			}
		}
		double num2 = finalSize.Width;
		for (int num3 = base.Children.Count - 1; num3 >= 0; num3--)
		{
			UIElement uIElement2 = base.Children[num3];
			if (uIElement2 != null && GetSlotAlignment(uIElement2) == HorizontalAlignment.Right && uIElement2 != item3)
			{
				num2 -= uIElement2.DesiredSize.Width;
				uIElement2.Arrange(new Rect(num2, 0.0, uIElement2.DesiredSize.Width, finalSize.Height));
			}
		}
		Thickness thickness = cZv(frameworkElement, item, item2);
		if (finalSize.Width >= PZB)
		{
			if (item != null)
			{
				item.Arrange(new Rect(num, 0.0, item.DesiredSize.Width, finalSize.Height));
				num += item.DesiredSize.Width;
			}
			if (item3 != null)
			{
				num2 -= item3.DesiredSize.Width;
				item3.Arrange(new Rect(num2, 0.0, item3.DesiredSize.Width, finalSize.Height));
			}
		}
		else
		{
			double num4 = Math.Max(0.0, Math.Round(num2 - num, MidpointRounding.AwayFromZero));
			Tuple<double, double> tuple2 = LZT(num4, item, item2, item3, ref thickness);
			if (item != null)
			{
				double num5 = Math.Min(tuple2.Item1, item.DesiredSize.Width);
				item.Arrange(new Rect(num, 0.0, num5, finalSize.Height));
				num += num5;
			}
			if (item3 != null)
			{
				double num6 = Math.Min(tuple2.Item2, item3.DesiredSize.Width);
				num2 -= num6;
				item3.Arrange(new Rect(num2, 0.0, num6, finalSize.Height));
			}
		}
		if (base.TemplatedParent is Window window)
		{
			WindowChrome.SetTitleBarHeight(window, finalSize.Height);
			WindowChrome.SetTitleBarLeftContentWidth(window, num);
			WindowChrome.SetTitleBarRightContentWidth(window, finalSize.Width - num2);
		}
		if (item2 != null)
		{
			num += thickness.Left;
			num2 -= thickness.Right;
			HorizontalAlignment headerAlignment = HeaderAlignment;
			if (headerAlignment == HorizontalAlignment.Center)
			{
				double num7 = finalSize.Width / 2.0;
				double num8 = Math.Round(num7 - item2.DesiredSize.Width / 2.0);
				double num9 = num8 + item2.DesiredSize.Width;
				if (num8 >= num && num9 <= num2)
				{
					num = num8;
					num2 = num9;
				}
			}
			double num10 = Math.Max(0.0, num2 - num);
			double num11 = num10;
			if (headerAlignment != HorizontalAlignment.Stretch)
			{
				num11 = Math.Min(num10, item2.DesiredSize.Width);
				if (num11 < num10)
				{
					switch (headerAlignment)
					{
					case HorizontalAlignment.Center:
						num = Math.Round(num + (num10 - num11) / 2.0, MidpointRounding.AwayFromZero);
						break;
					case HorizontalAlignment.Right:
						num = Math.Round(num2 - num11, MidpointRounding.AwayFromZero);
						break;
					}
				}
			}
			item2.Arrange(new Rect(num, 0.0, num11, finalSize.Height));
		}
		return finalSize;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		double width = availableSize.Width;
		double height = availableSize.Height;
		double num = 0.0;
		double num2 = 0.0;
		Tuple<ContentControl, ContentControl, ContentControl> tuple = sZX();
		ContentControl item = tuple.Item1;
		ContentControl item2 = tuple.Item2;
		ContentControl item3 = tuple.Item3;
		double num3 = 0.0;
		FrameworkElement frameworkElement = null;
		foreach (UIElement child in base.Children)
		{
			if (child == null || GetSlotAlignment(child) != HorizontalAlignment.Left)
			{
				continue;
			}
			child.Measure(new Size(double.PositiveInfinity, height));
			num2 = Math.Max(num2, child.DesiredSize.Height);
			if (child != item)
			{
				num3 += child.DesiredSize.Width;
				num += child.DesiredSize.Width;
				if (WindowChrome.GetElementKind(child) == WindowChromeElementKind.SystemMenu)
				{
					frameworkElement = child as FrameworkElement;
				}
			}
		}
		double num4 = 0.0;
		foreach (UIElement child2 in base.Children)
		{
			if (child2 != null && GetSlotAlignment(child2) == HorizontalAlignment.Right)
			{
				child2.Measure(new Size(double.PositiveInfinity, height));
				num2 = Math.Max(num2, child2.DesiredSize.Height);
				if (child2 != item3)
				{
					num4 += child2.DesiredSize.Width;
					num += child2.DesiredSize.Width;
				}
			}
		}
		if (item2 != null)
		{
			item2.Measure(new Size(double.PositiveInfinity, height));
			num2 = Math.Max(num2, item2.DesiredSize.Height);
		}
		Thickness thickness = cZv(frameworkElement, item, item2);
		PZB = num3 + (item?.DesiredSize.Width ?? 0.0) + ((item2 != null) ? (thickness.Left + item2.DesiredSize.Width + thickness.Right) : 0.0) + (item3?.DesiredSize.Width ?? 0.0) + num4;
		if (!double.IsPositiveInfinity(width) && PZB > width)
		{
			width = Math.Max(0.0, width - num3 - num4);
			Tuple<double, double> tuple2 = LZT(width, item, item2, item3, ref thickness);
			if (item != null)
			{
				double width2 = item.DesiredSize.Width;
				item.Measure(new Size(tuple2.Item1, height));
				num2 = Math.Max(num2, item.DesiredSize.Height);
				if (width2 > 0.0 && item.DesiredSize.Width == 0.0)
				{
					thickness = cZv(frameworkElement, item, item2);
					tuple2 = LZT(width, item, item2, item3, ref thickness);
				}
			}
			if (item3 != null)
			{
				item3.Measure(new Size(tuple2.Item2, height));
				num2 = Math.Max(num2, item3.DesiredSize.Height);
			}
			double num5 = Math.Min(tuple2.Item1, item?.DesiredSize.Width ?? 0.0);
			double num6 = Math.Min(tuple2.Item2, item3?.DesiredSize.Width ?? 0.0);
			num += num5 + num6;
			if (item2 != null)
			{
				double width3 = Math.Max(0.0, width - num5 - thickness.Left - thickness.Right - num6);
				item2.Measure(new Size(width3, height));
				num += thickness.Left + item2.DesiredSize.Width + thickness.Right;
				num2 = Math.Max(num2, item2.DesiredSize.Height);
			}
		}
		else
		{
			num = PZB;
		}
		PZB = Math.Ceiling(PZB);
		num = Math.Ceiling(Math.Min(availableSize.Width, num));
		num2 = Math.Ceiling(Math.Min(availableSize.Height, num2));
		if (num2 % 2.0 == 1.0)
		{
			num2 += 1.0;
		}
		return new Size(num, num2);
	}

	[AttachedPropertyBrowsableForChildren]
	public static HorizontalAlignment GetSlotAlignment(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (HorizontalAlignment)obj.GetValue(SlotAlignmentProperty);
	}

	public static void SetSlotAlignment(DependencyObject obj, HorizontalAlignment value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(SlotAlignmentProperty, value);
	}

	public WindowChromeTitleBarPanel()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static WindowChromeTitleBarPanel()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		HeaderAlignmentProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121662), typeof(HorizontalAlignment), typeof(WindowChromeTitleBarPanel), new FrameworkPropertyMetadata(HorizontalAlignment.Left, FrameworkPropertyMetadataOptions.AffectsMeasure));
		HeaderMarginProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121696), typeof(Thickness), typeof(WindowChromeTitleBarPanel), new FrameworkPropertyMetadata(new Thickness(8.0, 0.0, 8.0, 0.0), FrameworkPropertyMetadataOptions.AffectsMeasure));
		HeaderMinWidthProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121724), typeof(double), typeof(WindowChromeTitleBarPanel), new FrameworkPropertyMetadata(50.0, FrameworkPropertyMetadataOptions.AffectsMeasure));
		LeftContentMaxWidthOverflowPercentageProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121756), typeof(double), typeof(WindowChromeTitleBarPanel), new FrameworkPropertyMetadata(0.3, FrameworkPropertyMetadataOptions.AffectsMeasure));
		RightContentMaxWidthOverflowPercentageProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121834), typeof(double), typeof(WindowChromeTitleBarPanel), new FrameworkPropertyMetadata(0.3, FrameworkPropertyMetadataOptions.AffectsMeasure));
		SlotAlignmentProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121914), typeof(HorizontalAlignment), typeof(WindowChromeTitleBarPanel), new FrameworkPropertyMetadata(HorizontalAlignment.Right));
	}

	internal static bool pbD()
	{
		return TbI == null;
	}

	internal static WindowChromeTitleBarPanel lb2()
	{
		return TbI;
	}
}
