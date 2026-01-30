using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Primitives;

[ToolboxItem(false)]
public class PropertyGridItemContentPanel : Panel
{
	private FrameworkElement LEQ;

	private static PropertyGridItemContentPanel KFD;

	[SpecialName]
	private TreeListViewItem REY()
	{
		return base.TemplatedParent as TreeListViewItem;
	}

	private double RET()
	{
		return 2.0 + (REY()?.IndentAmount ?? 0.0);
	}

	private void JEo()
	{
		LEQ = null;
		foreach (object child in base.Children)
		{
			if (child is FrameworkElement frameworkElement && frameworkElement.Name == xv.hTz(9674))
			{
				LEQ = frameworkElement;
			}
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		double num = RET();
		int num3 = default(int);
		foreach (object child in base.Children)
		{
			if (child == LEQ)
			{
				LEQ.Arrange(new Rect(num - LEQ.DesiredSize.Width, 0.0, LEQ.DesiredSize.Width, finalSize.Height));
			}
			else if (child is FrameworkElement frameworkElement)
			{
				int num2 = 0;
				if (!hFb())
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				frameworkElement.Arrange(new Rect(num, 0.0, Math.Max(0.0, finalSize.Width - num), finalSize.Height));
			}
		}
		return finalSize;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		JEo();
		double num = RET();
		Size size = new Size(num, 0.0);
		int num3 = default(int);
		foreach (object child in base.Children)
		{
			if (child == LEQ)
			{
				int num2 = 0;
				if (aFz() != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				LEQ.Measure(new Size(double.PositiveInfinity, availableSize.Height));
				size.Height = Math.Max(size.Height, LEQ.DesiredSize.Height);
			}
			else if (child is FrameworkElement frameworkElement)
			{
				frameworkElement.Measure(new Size(Math.Max(0.0, availableSize.Width - num), availableSize.Height));
				size = new Size(Math.Max(size.Width, num + frameworkElement.DesiredSize.Width), Math.Max(size.Height, frameworkElement.DesiredSize.Height));
			}
		}
		return new Size(size.Width, Math.Ceiling(size.Height));
	}

	public PropertyGridItemContentPanel()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool hFb()
	{
		return KFD == null;
	}

	internal static PropertyGridItemContentPanel aFz()
	{
		return KFD;
	}
}
