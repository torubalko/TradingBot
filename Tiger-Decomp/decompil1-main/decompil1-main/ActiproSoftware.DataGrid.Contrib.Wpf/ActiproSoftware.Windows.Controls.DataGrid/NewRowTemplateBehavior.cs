using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.DataGrid;

public static class NewRowTemplateBehavior
{
	private static readonly DependencyPropertyKey sS;

	public static readonly DependencyProperty DefaultTemplateProperty;

	public static readonly DependencyProperty TemplateProperty;

	internal static NewRowTemplateBehavior rq;

	[SuppressMessage("Microsoft.Portability", "CA1903:UseOnlyApiFromTargetedFramework", MessageId = "System.Windows.Data.CollectionView.#get_NewItemPlaceholder()")]
	private static void DA(object P_0, DataGridRowEventArgs P_1)
	{
		if (P_0 is System.Windows.Controls.DataGrid dataGrid && CollectionView.NewItemPlaceholder == P_1.Row.Item)
		{
			e3(dataGrid, P_1.Row.Template);
			P_1.Row.Template = GetTemplate(dataGrid);
			P_1.Row.MouseLeftButtonDown += pQ;
		}
	}

	[SuppressMessage("Microsoft.Portability", "CA1903:UseOnlyApiFromTargetedFramework", MessageId = "System.ComponentModel.IEditableCollectionView")]
	private static void SX(object P_0, DataGridRowEditEndingEventArgs P_1)
	{
		if (P_0 is System.Windows.Controls.DataGrid dataGrid && CollectionViewSource.GetDefaultView(dataGrid.ItemsSource) is IEditableCollectionView { IsAddingNew: not false })
		{
			dataGrid.Dispatcher.Invoke(DispatcherPriority.ApplicationIdle, new DispatcherOperationCallback(nV), dataGrid);
		}
	}

	[SuppressMessage("Microsoft.Portability", "CA1903:UseOnlyApiFromTargetedFramework", MessageId = "System.Windows.Data.CollectionView.#get_NewItemPlaceholder()")]
	private static void pQ(object P_0, MouseButtonEventArgs P_1)
	{
		if (!(P_0 is DataGridRow dataGridRow) || !(VisualTreeHelperExtended.GetAncestor(dataGridRow, typeof(System.Windows.Controls.DataGrid)) is System.Windows.Controls.DataGrid dataGrid) || CollectionView.NewItemPlaceholder != dataGridRow.Item)
		{
			return;
		}
		ControlTemplate template = GetTemplate(dataGrid);
		if (dataGridRow.Template == template)
		{
			dataGridRow.Template = GetDefaultTemplate(dataGrid);
			dataGridRow.UpdateLayout();
			dataGrid.CurrentItem = dataGridRow.Item;
			DataGridColumn dataGridColumn = dataGrid.Columns.FirstOrDefault((DataGridColumn col) => !col.IsReadOnly);
			if (dataGridColumn != null && VisualTreeHelperExtended.GetAncestor(dataGridColumn.GetCellContent(dataGridRow), typeof(DataGridCell)) is DataGridCell dataGridCell)
			{
				dataGridCell.Focus();
			}
			dataGrid.BeginEdit();
		}
	}

	[SuppressMessage("Microsoft.Portability", "CA1903:UseOnlyApiFromTargetedFramework", MessageId = "System.Windows.Data.CollectionView.#get_NewItemPlaceholder()")]
	private static void ns(object P_0, DataGridRowEventArgs P_1)
	{
		if (P_0 is System.Windows.Controls.DataGrid dataGrid && CollectionView.NewItemPlaceholder == P_1.Row.Item)
		{
			ControlTemplate defaultTemplate = GetDefaultTemplate(dataGrid);
			if (defaultTemplate != null)
			{
				P_1.Row.Template = defaultTemplate;
				P_1.Row.MouseLeftButtonDown -= pQ;
				e3(dataGrid, null);
			}
		}
	}

	private static void Km(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is System.Windows.Controls.DataGrid dataGrid))
		{
			return;
		}
		if (P_1.NewValue != null)
		{
			dataGrid.LoadingRow += DA;
			dataGrid.RowEditEnding += SX;
			dataGrid.UnloadingRow += ns;
		}
		else
		{
			dataGrid.LoadingRow -= DA;
			dataGrid.RowEditEnding -= SX;
			dataGrid.UnloadingRow -= ns;
			int num = 0;
			if (bT() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (dataGrid.IsLoaded)
		{
			nV(dataGrid);
		}
	}

	[SuppressMessage("Microsoft.Portability", "CA1903:UseOnlyApiFromTargetedFramework", MessageId = "System.Windows.Data.CollectionView.#get_NewItemPlaceholder()")]
	private static object nV(object P_0)
	{
		if (!(P_0 is System.Windows.Controls.DataGrid dataGrid))
		{
			return null;
		}
		DataGridRow row = dataGrid.GetRow(CollectionView.NewItemPlaceholder);
		if (row == null)
		{
			return null;
		}
		ControlTemplate controlTemplate = GetTemplate(dataGrid);
		if (controlTemplate == null)
		{
			controlTemplate = GetDefaultTemplate(dataGrid);
		}
		if (row.Template != controlTemplate)
		{
			row.Template = controlTemplate;
			row.UpdateLayout();
		}
		return null;
	}

	private static void e3(System.Windows.Controls.DataGrid P_0, ControlTemplate P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Ng.cn(718));
		}
		P_0.SetValue(sS, P_1);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static ControlTemplate GetDefaultTemplate(System.Windows.Controls.DataGrid obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(Ng.cn(718));
		}
		return (ControlTemplate)obj.GetValue(DefaultTemplateProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static ControlTemplate GetTemplate(System.Windows.Controls.DataGrid obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(Ng.cn(718));
		}
		return (ControlTemplate)obj.GetValue(TemplateProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetTemplate(System.Windows.Controls.DataGrid obj, ControlTemplate value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(Ng.cn(718));
		}
		obj.SetValue(TemplateProperty, value);
	}

	static NewRowTemplateBehavior()
	{
		ActiproSoftware.Internal.ns.vQ9Sfz();
		sS = DependencyProperty.RegisterAttachedReadOnly(Ng.cn(792), typeof(ControlTemplate), typeof(NewRowTemplateBehavior), new FrameworkPropertyMetadata(null));
		DefaultTemplateProperty = sS.DependencyProperty;
		TemplateProperty = DependencyProperty.RegisterAttached(Ng.cn(826), typeof(ControlTemplate), typeof(NewRowTemplateBehavior), new FrameworkPropertyMetadata(null, Km));
	}

	internal static bool Nw()
	{
		return rq == null;
	}

	internal static NewRowTemplateBehavior bT()
	{
		return rq;
	}
}
