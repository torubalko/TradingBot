using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class NavigableSymbolSelectorPanel : Panel
{
	public static readonly DependencyProperty SplitSizeProperty;

	internal static NavigableSymbolSelectorPanel JBr;

	public double SplitSize
	{
		get
		{
			return (double)GetValue(SplitSizeProperty);
		}
		set
		{
			SetValue(SplitSizeProperty, value);
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		UIElement uIElement = ((base.Children.Count > 0) ? base.Children[0] : null);
		UIElement uIElement2 = ((base.Children.Count == 2) ? base.Children[1] : null);
		if (uIElement != null && uIElement.Visibility != Visibility.Visible)
		{
			uIElement = null;
		}
		if (uIElement2 != null && uIElement2.Visibility != Visibility.Visible)
		{
			uIElement2 = null;
		}
		if (uIElement != null && uIElement2 != null)
		{
			double num = Math.Round(Math.Max(0.0, finalSize.Width - SplitSize) / 2.0);
			uIElement.Arrange(new Rect(0.0, 0.0, num, finalSize.Height));
			double num2 = num + SplitSize;
			num = Math.Floor(Math.Max(0.0, finalSize.Width - num2));
			uIElement2.Arrange(new Rect(num2, 0.0, num, finalSize.Height));
		}
		else
		{
			(uIElement ?? uIElement2)?.Arrange(new Rect(0.0, 0.0, finalSize.Width, finalSize.Height));
		}
		return finalSize;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		double num = 0.0;
		double num2 = 0.0;
		double width = availableSize.Width;
		if (!double.IsInfinity(width) && base.Children.Count >= 1 && base.Children.Count <= 2)
		{
			UIElement uIElement = base.Children[0];
			UIElement uIElement2 = ((base.Children.Count == 2) ? base.Children[1] : null);
			if (uIElement != null && uIElement.Visibility != Visibility.Visible)
			{
				uIElement = null;
			}
			if (uIElement2 != null && uIElement2.Visibility != Visibility.Visible)
			{
				uIElement2 = null;
			}
			if (uIElement != null && uIElement2 != null)
			{
				double num3 = Math.Floor(Math.Max(0.0, width - SplitSize) / 2.0);
				uIElement.Measure(new Size(num3, availableSize.Height));
				double num4 = num3 + SplitSize;
				num3 = Math.Round(Math.Max(0.0, width - num4));
				uIElement2.Measure(new Size(num3, availableSize.Height));
				num = Math.Ceiling(uIElement.DesiredSize.Width + SplitSize + uIElement2.DesiredSize.Width);
				num2 = Math.Ceiling(Math.Max(uIElement.DesiredSize.Height, uIElement2.DesiredSize.Height));
			}
			else
			{
				UIElement uIElement3 = uIElement ?? uIElement2;
				if (uIElement3 != null)
				{
					uIElement3.Measure(availableSize);
					num = Math.Ceiling(uIElement3.DesiredSize.Width);
					num2 = Math.Ceiling(uIElement3.DesiredSize.Height);
				}
			}
		}
		else
		{
			num += SplitSize;
			foreach (UIElement child in base.Children)
			{
				if (child != null)
				{
					child.Measure(availableSize);
					num += Math.Ceiling(child.DesiredSize.Width);
					num2 = Math.Max(num2, Math.Ceiling(child.DesiredSize.Height));
				}
			}
		}
		if (!double.IsInfinity(availableSize.Width))
		{
			num = availableSize.Width;
		}
		return new Size(num, num2);
	}

	public NavigableSymbolSelectorPanel()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	static NavigableSymbolSelectorPanel()
	{
		grA.DaB7cz();
		SplitSizeProperty = DependencyProperty.Register(Q7Z.tqM(9306), typeof(double), typeof(NavigableSymbolSelectorPanel), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsArrange));
	}

	internal static bool pBX()
	{
		return JBr == null;
	}

	internal static NavigableSymbolSelectorPanel CBE()
	{
		return JBr;
	}
}
