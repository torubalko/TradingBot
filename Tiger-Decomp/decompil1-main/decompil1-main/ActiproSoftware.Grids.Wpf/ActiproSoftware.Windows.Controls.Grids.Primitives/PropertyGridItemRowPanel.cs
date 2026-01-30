using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Primitives;

[ToolboxItem(false)]
public class PropertyGridItemRowPanel : TreeListViewItemRowPanel
{
	private FrameworkElement chrome;

	internal static PropertyGridItemRowPanel RsQ;

	internal Control SEy()
	{
		int num = ((vCb() is PropertyGrid propertyGrid) ? propertyGrid.NameColumnIndex : (-1));
		if (num != -1)
		{
			IList<Ne> list = mCL();
			if (num < list.Count)
			{
				return list[num].Hmb();
			}
		}
		return null;
	}

	private Tuple<TreeListViewColumn, Ne> qEd()
	{
		PropertyGrid propertyGrid = vCb() as PropertyGrid;
		int num = propertyGrid?.NameColumnIndex ?? (-1);
		if (num != -1)
		{
			IList<Ne> list = mCL();
			if (num < list.Count)
			{
				return Tuple.Create(propertyGrid.Columns[num], list[num]);
			}
		}
		return null;
	}

	internal Control CEB()
	{
		int num = ((vCb() is PropertyGrid propertyGrid) ? propertyGrid.ValueColumnIndex : (-1));
		if (num != -1)
		{
			IList<Ne> list = mCL();
			if (num < list.Count)
			{
				return list[num].Hmb();
			}
		}
		return null;
	}

	private void iER()
	{
		chrome = null;
		foreach (object child in base.Children)
		{
			if (child is FrameworkElement frameworkElement && frameworkElement.Name == xv.hTz(7470))
			{
				chrome = frameworkElement;
			}
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		Size result = base.ArrangeOverride(finalSize);
		Tuple<TreeListViewColumn, Ne> tuple = qEd();
		if (tuple != null)
		{
			int num = 0;
			if (WsC() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			TreeListViewColumn item = tuple.Item1;
			Ne item2 = tuple.Item2;
			if (chrome != null)
			{
				chrome.Arrange(new Rect(item2.Qm0() + item2.IndentAmount + item.CellBorderThickness.Left, item.CellBorderThickness.Top, Math.Max(0.0, item2.gmH() - item.CellBorderThickness.Left - item2.IndentAmount - item.CellBorderThickness.Right), Math.Max(0.0, result.Height - item.CellBorderThickness.Top - item.CellBorderThickness.Bottom)));
			}
		}
		else if (chrome != null)
		{
			chrome.Arrange(default(Rect));
		}
		return result;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		iER();
		Size result = base.MeasureOverride(availableSize);
		Tuple<TreeListViewColumn, Ne> tuple = qEd();
		if (tuple != null)
		{
			TreeListViewColumn item = tuple.Item1;
			Ne item2 = tuple.Item2;
			if (chrome != null)
			{
				chrome.Measure(new Size(Math.Max(0.0, item2.Hmc() - item.CellBorderThickness.Left - item2.IndentAmount - item.CellBorderThickness.Right), Math.Max(0.0, availableSize.Height - item.CellBorderThickness.Top - item.CellBorderThickness.Bottom)));
				return result;
			}
		}
		else if (chrome != null)
		{
			chrome.Measure(default(Size));
		}
		return result;
	}

	public PropertyGridItemRowPanel()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool SsW()
	{
		return RsQ == null;
	}

	internal static PropertyGridItemRowPanel WsC()
	{
		return RsQ;
	}
}
