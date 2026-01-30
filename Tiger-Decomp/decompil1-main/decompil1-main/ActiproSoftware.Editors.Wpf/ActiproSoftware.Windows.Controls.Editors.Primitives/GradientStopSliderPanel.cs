using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ToolboxItem(false)]
public class GradientStopSliderPanel : Panel
{
	private static GradientStopSliderPanel cjQ;

	protected override Size ArrangeOverride(Size finalSize)
	{
		double num = Math.Max(0.0, finalSize.Width - 1.0);
		int num3 = default(int);
		foreach (UIElement child in base.Children)
		{
			GradientStopThumb gradientStopThumb = child as GradientStopThumb;
			bool flag = gradientStopThumb != null;
			int num2 = 0;
			if (ujR() != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
			if (flag && gradientStopThumb.DataContext is GradientStop gradientStop)
			{
				double num4 = Math.Max(0.0, Math.Min(1.0, gradientStop.Offset));
				double x = num4 * num - gradientStopThumb.DesiredSize.Width / 2.0;
				gradientStopThumb.Arrange(new Rect(x, 0.0, gradientStopThumb.DesiredSize.Width, finalSize.Height));
			}
		}
		return finalSize;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		double num = 0.0;
		double num2 = 0.0;
		foreach (UIElement child in base.Children)
		{
			if (child != null)
			{
				child.Measure(availableSize);
				num = Math.Max(num, child.DesiredSize.Width);
				num2 = Math.Max(num2, child.DesiredSize.Height);
			}
		}
		return new Size(num, num2);
	}

	public GradientStopSliderPanel()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool sjZ()
	{
		return cjQ == null;
	}

	internal static GradientStopSliderPanel ujR()
	{
		return cjQ;
	}
}
