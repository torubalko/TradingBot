using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.DataGrid;

public static class FocusBehavior
{
	private static readonly DependencyPropertyKey rU;

	public static readonly DependencyProperty IsFocusedHeaderProperty;

	public static readonly DependencyProperty TrackingModesProperty;

	private static FocusBehavior Y4;

	private static void It(object P_0, RoutedEventArgs P_1)
	{
		uF(P_0 as System.Windows.Controls.DataGrid);
	}

	private static void kE(object P_0, RoutedEventArgs P_1)
	{
		uF(P_0 as System.Windows.Controls.DataGrid);
	}

	private static void sO(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		System.Windows.Controls.DataGrid dataGrid = default(System.Windows.Controls.DataGrid);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
					if (dataGrid != null)
					{
						if ((FocusTrackingModes)P_1.NewValue == FocusTrackingModes.None)
						{
							dataGrid.RemoveHandler(UIElement.GotFocusEvent, new RoutedEventHandler(It));
							dataGrid.RemoveHandler(UIElement.LostFocusEvent, new RoutedEventHandler(kE));
						}
						else
						{
							dataGrid.AddHandler(UIElement.GotFocusEvent, new RoutedEventHandler(It), handledEventsToo: true);
							dataGrid.AddHandler(UIElement.LostFocusEvent, new RoutedEventHandler(kE), handledEventsToo: true);
						}
						uF(dataGrid);
					}
					return;
				}
				dataGrid = P_0 as System.Windows.Controls.DataGrid;
				num2 = 0;
			}
			while (re());
		}
	}

	private static void uF(System.Windows.Controls.DataGrid P_0)
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
		FocusTrackingModes trackingModes = GetTrackingModes(P_0);
		if ((trackingModes & FocusTrackingModes.Headers) != FocusTrackingModes.None)
		{
			DataGridCell dataGridCell = Keyboard.FocusedElement as DataGridCell;
			if (dataGridCell == null)
			{
				dataGridCell = VisualTreeHelperExtended.GetAncestor(Keyboard.FocusedElement as FrameworkElement, typeof(DataGridCell)) as DataGridCell;
			}
			{
				foreach (DataGridColumnHeader item in allDescendants)
				{
					bool flag = dataGridCell != null && dataGridCell.Column == item.Column;
					if (flag != GetIsFocusedHeader(item))
					{
						if (flag)
						{
							item.SetValue(rU, true);
						}
						else
						{
							item.ClearValue(rU);
						}
					}
				}
				return;
			}
		}
		foreach (DataGridColumnHeader item2 in allDescendants)
		{
			if (GetIsFocusedHeader(item2))
			{
				item2.ClearValue(rU);
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static bool GetIsFocusedHeader(DataGridColumnHeader obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(Ng.cn(718));
		}
		return (bool)obj.GetValue(IsFocusedHeaderProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static FocusTrackingModes GetTrackingModes(System.Windows.Controls.DataGrid obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(Ng.cn(718));
		}
		return (FocusTrackingModes)obj.GetValue(TrackingModesProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetTrackingModes(System.Windows.Controls.DataGrid obj, FocusTrackingModes value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(Ng.cn(718));
		}
		obj.SetValue(TrackingModesProperty, value);
	}

	static FocusBehavior()
	{
		ns.vQ9Sfz();
		rU = DependencyProperty.RegisterAttachedReadOnly(Ng.cn(728), typeof(bool), typeof(FocusBehavior), new FrameworkPropertyMetadata(false));
		IsFocusedHeaderProperty = rU.DependencyProperty;
		TrackingModesProperty = DependencyProperty.RegisterAttached(Ng.cn(762), typeof(FocusTrackingModes), typeof(FocusBehavior), new FrameworkPropertyMetadata(FocusTrackingModes.None, sO));
	}

	internal static bool re()
	{
		return Y4 == null;
	}

	internal static FocusBehavior oG()
	{
		return Y4;
	}
}
