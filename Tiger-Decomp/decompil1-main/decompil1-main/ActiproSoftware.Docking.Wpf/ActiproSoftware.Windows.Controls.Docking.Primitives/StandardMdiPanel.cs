using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class StandardMdiPanel : Panel
{
	internal static StandardMdiPanel yni;

	protected override Size ArrangeOverride(Size finalSize)
	{
		double num = finalSize.Width;
		double num2 = finalSize.Height;
		foreach (UIElement child in base.Children)
		{
			if (child is StandardMdiWindowControl standardMdiWindowControl)
			{
				child.Arrange(new Rect(standardMdiWindowControl.Left, standardMdiWindowControl.Top, standardMdiWindowControl.DesiredSize.Width, standardMdiWindowControl.DesiredSize.Height));
				num = Math.Max(num, standardMdiWindowControl.Left + standardMdiWindowControl.DesiredSize.Width);
				num2 = Math.Max(num2, standardMdiWindowControl.Top + standardMdiWindowControl.DesiredSize.Height);
			}
		}
		return new Size(num, num2);
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		double num = 0.0;
		double num2 = 0.0;
		int num4 = default(int);
		foreach (UIElement child in base.Children)
		{
			if (child == null)
			{
				continue;
			}
			child.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
			if (!(child is StandardMdiWindowControl standardMdiWindowControl))
			{
				int num3 = 0;
				if (Onu() != null)
				{
					num3 = num4;
				}
				switch (num3)
				{
				}
			}
			else if (standardMdiWindowControl.WindowState != WindowState.Maximized)
			{
				num = Math.Max(num, standardMdiWindowControl.Left + standardMdiWindowControl.DesiredSize.Width);
				num2 = Math.Max(num2, standardMdiWindowControl.Top + standardMdiWindowControl.DesiredSize.Height);
			}
		}
		return new Size(num, num2);
	}

	public StandardMdiPanel()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool snZ()
	{
		return yni == null;
	}

	internal static StandardMdiPanel Onu()
	{
		return yni;
	}
}
