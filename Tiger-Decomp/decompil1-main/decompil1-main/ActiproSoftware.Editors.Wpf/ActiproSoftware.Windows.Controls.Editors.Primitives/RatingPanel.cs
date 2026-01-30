using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ToolboxItem(false)]
public class RatingPanel : StackPanel
{
	private Rating bIe;

	private static RatingPanel Lhk;

	private void NIJ()
	{
		if (bIe == null)
		{
			bIe = VisualTreeHelperExtended.GetAncestor<Rating>(this);
			if (bIe != null)
			{
				bIe.Llj(this);
			}
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		bool flag = base.Orientation == Orientation.Horizontal;
		double num = (flag ? 0.0 : finalSize.Height);
		foreach (UIElement child in base.Children)
		{
			if (flag)
			{
				child.Arrange(new Rect(num, 0.0, child.DesiredSize.Width, finalSize.Height));
				num += child.DesiredSize.Width;
			}
			else
			{
				num -= child.DesiredSize.Height;
				child.Arrange(new Rect(0.0, num, finalSize.Width, child.DesiredSize.Height));
			}
		}
		return finalSize;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		double num = 0.0;
		double num2 = 0.0;
		bool flag = base.Orientation == Orientation.Horizontal;
		int num4 = default(int);
		foreach (UIElement child in base.Children)
		{
			if (child == null)
			{
				continue;
			}
			child.Measure(availableSize);
			bool flag2 = flag;
			int num3 = 0;
			if (IhN() != null)
			{
				num3 = num4;
			}
			switch (num3)
			{
			}
			if (flag2)
			{
				num += child.DesiredSize.Width;
				num2 = Math.Max(num2, child.DesiredSize.Height);
			}
			else
			{
				num = Math.Max(num, child.DesiredSize.Width);
				num2 += child.DesiredSize.Height;
			}
		}
		return new Size(num, num2);
	}

	protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost)
	{
		base.OnIsItemsHostChanged(oldIsItemsHost, newIsItemsHost);
		NIJ();
	}

	public RatingPanel()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool ahf()
	{
		return Lhk == null;
	}

	internal static RatingPanel IhN()
	{
		return Lhk;
	}
}
