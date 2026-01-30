using System;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.DataGrid;

public static class DataGridExtensions
{
	internal static DataGridExtensions Yi;

	public static DataGridRow GetRow(this System.Windows.Controls.DataGrid dataGrid, int index)
	{
		if (dataGrid == null)
		{
			throw new ArgumentNullException(Ng.cn(698));
		}
		if (dataGrid.ItemContainerGenerator.Status != GeneratorStatus.ContainersGenerated)
		{
			return null;
		}
		DataGridRow dataGridRow = dataGrid.ItemContainerGenerator.ContainerFromIndex(index) as DataGridRow;
		if (dataGridRow == null && dataGrid.EnableRowVirtualization && dataGrid.IsLoaded && dataGrid.IsVisible)
		{
			dataGrid.ScrollIntoView(dataGrid.Items[index]);
			dataGrid.UpdateLayout();
			int num = 0;
			if (qb() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			dataGridRow = dataGrid.ItemContainerGenerator.ContainerFromIndex(index) as DataGridRow;
		}
		return dataGridRow;
	}

	public static DataGridRow GetRow(this System.Windows.Controls.DataGrid dataGrid, object item)
	{
		if (dataGrid == null)
		{
			throw new ArgumentNullException(Ng.cn(698));
		}
		int num = dataGrid.Items.IndexOf(item);
		if (num == -1)
		{
			return null;
		}
		return dataGrid.GetRow(num);
	}

	internal static bool Xr()
	{
		return Yi == null;
	}

	internal static DataGridExtensions qb()
	{
		return Yi;
	}
}
