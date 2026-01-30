using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
public class AutoCollapseStackPanel : Panel
{
	private static AutoCollapseStackPanel i0r;

	protected override Size ArrangeOverride(Size finalSize)
	{
		double num = 0.0;
		bool flag = true;
		int num3 = default(int);
		foreach (UIElement child in base.Children)
		{
			flag &= num + child.DesiredSize.Width <= finalSize.Width;
			int num2 = 0;
			if (!s0I())
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
			child.IsHitTestVisible = flag;
			if (flag)
			{
				child.Arrange(new Rect(num, 0.0, child.DesiredSize.Width, finalSize.Height));
				num += child.DesiredSize.Width;
			}
			else
			{
				child.Arrange(new Rect(num, 0.0, 0.0, finalSize.Height));
			}
		}
		return new Size(num, finalSize.Height);
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		double num = 0.0;
		double num2 = 0.0;
		bool flag = true;
		foreach (UIElement child in base.Children)
		{
			child.Measure(new Size(double.PositiveInfinity, availableSize.Height));
			flag &= num + child.DesiredSize.Width <= availableSize.Width;
			if (flag)
			{
				num += child.DesiredSize.Width;
				num2 = Math.Max(num2, child.DesiredSize.Height);
			}
		}
		num = Math.Ceiling(Math.Min(availableSize.Width, num));
		num2 = Math.Ceiling(Math.Min(availableSize.Height, num2));
		return new Size(num, num2);
	}

	public AutoCollapseStackPanel()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool s0I()
	{
		return i0r == null;
	}

	internal static AutoCollapseStackPanel M0D()
	{
		return i0r;
	}
}
