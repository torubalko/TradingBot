using System.Diagnostics.CodeAnalysis;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.DataGrid;

public static class DataGridCommands
{
	private static RoutedCommand Y8;

	private static DataGridCommands Yd;

	public static RoutedCommand ToggleFrozenColumn => Y8;

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static DataGridCommands()
	{
		ns.vQ9Sfz();
		Y8 = new RoutedCommand(Ng.cn(658), typeof(System.Windows.Controls.DataGrid));
		CommandManager.RegisterClassCommandBinding(typeof(System.Windows.Controls.DataGrid), new CommandBinding(Y8, Od));
	}

	private static void Od(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (!(P_1.Parameter is DataGridColumnHeader dataGridColumnHeader))
		{
			return;
		}
		System.Windows.Controls.DataGrid dataGrid = VisualTreeHelperExtended.GetAncestor(dataGridColumnHeader, typeof(System.Windows.Controls.DataGrid)) as System.Windows.Controls.DataGrid;
		DataGridColumn column = dataGridColumnHeader.Column;
		if (dataGrid == null || column == null)
		{
			return;
		}
		if (column.IsFrozen)
		{
			int num = 0;
			if (!Gm())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			int frozenColumnCount = (column.DisplayIndex = dataGrid.FrozenColumnCount - 1);
			dataGrid.FrozenColumnCount = frozenColumnCount;
		}
		else
		{
			column.DisplayIndex = dataGrid.FrozenColumnCount++;
		}
	}

	internal static bool Gm()
	{
		return Yd == null;
	}

	internal static DataGridCommands O5()
	{
		return Yd;
	}
}
