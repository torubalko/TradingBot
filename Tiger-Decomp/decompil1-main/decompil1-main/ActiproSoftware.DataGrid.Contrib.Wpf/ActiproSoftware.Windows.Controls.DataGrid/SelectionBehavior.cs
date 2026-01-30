using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.DataGrid;

public static class SelectionBehavior
{
	private static readonly DependencyPropertyKey O5;

	public static readonly DependencyProperty IsSelectedHeaderProperty;

	public static readonly DependencyProperty TrackingModesProperty;

	internal static SelectionBehavior CK;

	private static void uf(object P_0, SelectedCellsChangedEventArgs P_1)
	{
		u0(P_0 as System.Windows.Controls.DataGrid);
	}

	private static void je(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is System.Windows.Controls.DataGrid dataGrid)
		{
			if ((SelectionTrackingModes)P_1.NewValue == SelectionTrackingModes.None)
			{
				dataGrid.SelectedCellsChanged -= uf;
			}
			else
			{
				dataGrid.SelectedCellsChanged += uf;
			}
			u0(dataGrid);
		}
	}

	private static void u0(System.Windows.Controls.DataGrid P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		IList<DependencyObject> allDescendants = VisualTreeHelperExtended.GetAllDescendants(P_0, typeof(DataGridColumnHeader));
		if (allDescendants == null || allDescendants.Count == 0)
		{
			return;
		}
		SelectionTrackingModes trackingModes = GetTrackingModes(P_0);
		if ((trackingModes & SelectionTrackingModes.Headers) != SelectionTrackingModes.None)
		{
			foreach (DataGridColumnHeader item in allDescendants)
			{
				bool flag = false;
				foreach (DataGridCellInfo selectedCell in P_0.SelectedCells)
				{
					if (selectedCell.Column == item.Column)
					{
						flag = true;
						break;
					}
				}
				if (flag != GetIsSelectedHeader(item))
				{
					if (flag)
					{
						item.SetValue(O5, true);
					}
					else
					{
						item.ClearValue(O5);
					}
				}
			}
			return;
		}
		foreach (DataGridColumnHeader item2 in allDescendants)
		{
			if (GetIsSelectedHeader(item2))
			{
				item2.ClearValue(O5);
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static bool GetIsSelectedHeader(DataGridColumnHeader obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(Ng.cn(718));
		}
		return (bool)obj.GetValue(IsSelectedHeaderProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static SelectionTrackingModes GetTrackingModes(System.Windows.Controls.DataGrid obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(Ng.cn(718));
		}
		return (SelectionTrackingModes)obj.GetValue(TrackingModesProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetTrackingModes(System.Windows.Controls.DataGrid obj, SelectionTrackingModes value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(Ng.cn(718));
		}
		obj.SetValue(TrackingModesProperty, value);
	}

	static SelectionBehavior()
	{
		ns.vQ9Sfz();
		O5 = DependencyProperty.RegisterAttachedReadOnly(Ng.cn(846), typeof(bool), typeof(SelectionBehavior), new FrameworkPropertyMetadata(false));
		IsSelectedHeaderProperty = O5.DependencyProperty;
		TrackingModesProperty = DependencyProperty.RegisterAttached(Ng.cn(762), typeof(SelectionTrackingModes), typeof(SelectionBehavior), new FrameworkPropertyMetadata(SelectionTrackingModes.None, je));
	}

	internal static bool Au()
	{
		return CK == null;
	}

	internal static SelectionBehavior h0()
	{
		return CK;
	}
}
