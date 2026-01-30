using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.ColorSelection.Primitives;

[ToolboxItem(false)]
public class GradientBrushThumbPanel : Panel
{
	public static readonly DependencyProperty OffsetProperty;

	public static readonly DependencyProperty OrientationProperty;

	private static GradientBrushThumbPanel l1q;

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

	protected override Size ArrangeOverride(Size finalSize)
	{
		bool flag = Orientation == Orientation.Horizontal;
		foreach (UIElement child in base.Children)
		{
			if (child != null)
			{
				Size desiredSize = child.DesiredSize;
				double offset = GetOffset(child);
				Rect finalRect = ((!flag) ? new Rect(finalSize.Width - desiredSize.Width, finalSize.Height * offset - desiredSize.Height / 2.0, desiredSize.Width, desiredSize.Height) : new Rect(finalSize.Width * offset - desiredSize.Width / 2.0, finalSize.Height - desiredSize.Height, desiredSize.Width, desiredSize.Height));
				child.Arrange(finalRect);
			}
		}
		return finalSize;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		Size availableSize2 = new Size(double.PositiveInfinity, double.PositiveInfinity);
		foreach (UIElement child in base.Children)
		{
			child?.Measure(availableSize2);
		}
		double width = 0.0;
		if (!double.IsInfinity(availableSize.Width))
		{
			width = availableSize.Width;
		}
		double height = 0.0;
		bool flag = !double.IsInfinity(availableSize.Height);
		int num = 0;
		if (C1n() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (flag)
			{
				height = availableSize.Height;
			}
			return new Size(width, height);
		}
	}

	[AttachedPropertyBrowsableForChildren]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static double GetOffset(UIElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		return (double)element.GetValue(OffsetProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetOffset(UIElement element, double value)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		element.SetValue(OffsetProperty, value);
	}

	public GradientBrushThumbPanel()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static GradientBrushThumbPanel()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		OffsetProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122360), typeof(double), typeof(GradientBrushThumbPanel), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsArrange));
		OrientationProperty = GradientBrushSlider.OrientationProperty.AddOwner(typeof(GradientBrushThumbPanel), new FrameworkPropertyMetadata(Orientation.Horizontal, FrameworkPropertyMetadataOptions.AffectsArrange));
	}

	internal static bool J1G()
	{
		return l1q == null;
	}

	internal static GradientBrushThumbPanel C1n()
	{
		return l1q;
	}
}
