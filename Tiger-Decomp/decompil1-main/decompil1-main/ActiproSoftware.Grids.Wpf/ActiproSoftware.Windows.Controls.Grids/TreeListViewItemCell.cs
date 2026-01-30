using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Grids;

[TemplatePart(Name = "PART_ResizeGripper", Type = typeof(FrameworkElement))]
[ToolboxItem(false)]
public class TreeListViewItemCell : ContentControl
{
	private FrameworkElement fJj;

	private InputAdapter DJx;

	private Point NJa;

	private double fJi;

	private double KJb;

	public static readonly DependencyProperty ColumnProperty;

	public static readonly DependencyProperty IndentAmountProperty;

	public static readonly DependencyProperty IsResizeGripperEnabledProperty;

	private static TreeListViewItemCell HWa;

	public TreeListViewColumn Column
	{
		get
		{
			return (TreeListViewColumn)GetValue(ColumnProperty);
		}
		private set
		{
			SetValue(ColumnProperty, value);
		}
	}

	public double IndentAmount
	{
		get
		{
			return (double)GetValue(IndentAmountProperty);
		}
		set
		{
			SetValue(IndentAmountProperty, value);
		}
	}

	public bool IsResizeGripperEnabled
	{
		get
		{
			return (bool)GetValue(IsResizeGripperEnabledProperty);
		}
		internal set
		{
			SetValue(IsResizeGripperEnabledProperty, value);
		}
	}

	public TreeListViewItemCell()
	{
		fc.taYSkz();
		KJb = double.NaN;
		base._002Ector();
		base.DefaultStyleKey = typeof(TreeListViewItemCell);
	}

	public TreeListViewItemCell(TreeListViewColumn column)
	{
		fc.taYSkz();
		this._002Ector();
		if (column == null)
		{
			throw new ArgumentNullException(xv.hTz(7676));
		}
		Column = column;
		IsResizeGripperEnabled = column.IsResizeGripperEnabled;
	}

	[SpecialName]
	private FrameworkElement HJv()
	{
		return fJj;
	}

	[SpecialName]
	private void DJ8(FrameworkElement value)
	{
		if (fJj == value)
		{
			return;
		}
		if (DJx != null)
		{
			DJx.AttachedEventKinds = InputAdapterEventKinds.None;
			DJx.PointerCaptureLost -= zJO;
			DJx.PointerMoved -= yJw;
			DJx.PointerPressed -= GJX;
			DJx.PointerReleased -= uJ2;
			DJx = null;
		}
		fJj = value;
		if (fJj != null)
		{
			DJx = new InputAdapter(fJj);
			DJx.PointerCaptureLost += zJO;
			int num = 0;
			if (!VWe())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			DJx.PointerMoved += yJw;
			DJx.PointerPressed += GJX;
			DJx.PointerReleased += uJ2;
			DJx.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased;
		}
	}

	private void zJO(object P_0, InputPointerEventArgs P_1)
	{
		KJb = double.NaN;
		fJi = 0.0;
	}

	private void yJw(object P_0, InputPointerEventArgs P_1)
	{
		TreeListViewColumn column = Column;
		if (P_1 == null || column == null || double.IsNaN(KJb))
		{
			return;
		}
		TreeListView treeListView = column.VqY();
		if (treeListView == null)
		{
			return;
		}
		int num = 1;
		if (!VWe())
		{
			num = 1;
		}
		TreeListViewColumn treeListViewColumn = default(TreeListViewColumn);
		double num2 = default(double);
		int num6 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				P_1.Handled = true;
				Point position = P_1.GetPosition(treeListView);
				double val = Math.Max(0.0, KJb + (position.X - NJa.X));
				if (column.Width.GridUnitType != GridUnitType.Star)
				{
					val = Math.Max(column.NqT(), Math.Min(column.iqg(), val));
					column.Width = new GridLength(val);
					return;
				}
				treeListViewColumn = treeListView.Q6t(column);
				if (treeListViewColumn == null)
				{
					return;
				}
				double num3 = column.ActualWidth + treeListViewColumn.ActualWidth;
				if (!(num3 > 0.0))
				{
					return;
				}
				val = Math.Max(column.NqT(), Math.Min(column.iqg(), val));
				double num4 = Math.Max(0.0, num3 - val);
				if (num4 < treeListViewColumn.NqT() || num4 > treeListViewColumn.iqg())
				{
					return;
				}
				double num5 = Math.Max(0.0, Math.Min(1.0, val / num3));
				num2 = 1.0 - num5;
				column.Width = new GridLength(num5 * fJi, GridUnitType.Star);
				num = 0;
				if (wWv() != null)
				{
					num = num6;
				}
				break;
			}
			default:
				treeListViewColumn.Width = new GridLength(num2 * fJi, GridUnitType.Star);
				return;
			}
		}
	}

	private void GJX(object P_0, InputPointerButtonEventArgs P_1)
	{
		TreeListViewColumn column = Column;
		if (P_1 == null || !P_1.IsPrimaryButton || fJj == null)
		{
			return;
		}
		int num = 0;
		if (wWv() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (column == null)
		{
			return;
		}
		KJb = ((column.Width.GridUnitType == GridUnitType.Pixel) ? column.Width.Value : column.ActualWidth);
		fJi = 0.0;
		TreeListView treeListView = column.VqY();
		if (treeListView != null)
		{
			fJi = column.Width.Value;
			TreeListViewColumn treeListViewColumn = treeListView.Q6t(column);
			if (treeListViewColumn != null)
			{
				fJi += treeListViewColumn.Width.Value;
			}
			NJa = P_1.GetPosition(treeListView);
			P_1.Handled = true;
			DJx.CapturePointer(P_1);
		}
	}

	private void uJ2(object P_0, InputPointerButtonEventArgs P_1)
	{
		KJb = double.NaN;
		fJi = 0.0;
		DJx.ReleasePointerCaptures();
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		DJ8(GetTemplateChild(xv.hTz(7578)) as FrameworkElement);
	}

	static TreeListViewItemCell()
	{
		fc.taYSkz();
		ColumnProperty = DependencyProperty.Register(xv.hTz(7692), typeof(TreeListViewColumn), typeof(TreeListViewItemCell), new PropertyMetadata(null));
		IndentAmountProperty = DependencyProperty.Register(xv.hTz(5596), typeof(double), typeof(TreeListViewItemCell), new PropertyMetadata(0.0));
		IsResizeGripperEnabledProperty = DependencyProperty.Register(xv.hTz(7116), typeof(bool), typeof(TreeListViewItemCell), new PropertyMetadata(false));
	}

	internal static bool VWe()
	{
		return HWa == null;
	}

	internal static TreeListViewItemCell wWv()
	{
		return HWa;
	}
}
