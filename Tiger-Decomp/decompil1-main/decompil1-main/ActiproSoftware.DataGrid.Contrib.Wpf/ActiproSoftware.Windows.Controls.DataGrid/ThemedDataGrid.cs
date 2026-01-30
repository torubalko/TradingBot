using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Themes;

namespace ActiproSoftware.Windows.Controls.DataGrid;

public class ThemedDataGrid : System.Windows.Controls.DataGrid
{
	private Style mM;

	private Style m7;

	private Style tW;

	private static ThemedDataGrid bJ;

	static ThemedDataGrid()
	{
		ns.vQ9Sfz();
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(ThemedDataGrid), new FrameworkPropertyMetadata(typeof(ThemedDataGrid)));
	}

	protected virtual void ApplyThemedStyle(DataGridCheckBoxColumn column)
	{
		if (column == null)
		{
			throw new ArgumentNullException(Ng.cn(882));
		}
		if (column.ElementStyle != DataGridCheckBoxColumn.DefaultElementStyle && column.EditingElementStyle != DataGridCheckBoxColumn.DefaultEditingElementStyle)
		{
			return;
		}
		if (column.ElementStyle == DataGridCheckBoxColumn.DefaultElementStyle)
		{
			if (m7 == null)
			{
				if (!(TryFindResource(SharedResourceKeys.CheckBoxStyleKey) is Style basedOn))
				{
					return;
				}
				m7 = new Style(typeof(CheckBox))
				{
					BasedOn = basedOn,
					Setters = 
					{
						(SetterBase)new Setter(UIElement.IsHitTestVisibleProperty, false),
						(SetterBase)new Setter(UIElement.FocusableProperty, false),
						(SetterBase)new Setter(FrameworkElement.HorizontalAlignmentProperty, HorizontalAlignment.Center),
						(SetterBase)new Setter(FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Top)
					}
				};
				m7.Seal();
			}
			column.ElementStyle = m7;
		}
		if (column.EditingElementStyle != DataGridCheckBoxColumn.DefaultEditingElementStyle)
		{
			return;
		}
		if (mM == null)
		{
			int num = 0;
			if (rR() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!(TryFindResource(SharedResourceKeys.CheckBoxStyleKey) is Style basedOn2))
			{
				return;
			}
			mM = new Style(typeof(CheckBox))
			{
				BasedOn = basedOn2,
				Setters = 
				{
					(SetterBase)new Setter(FrameworkElement.HorizontalAlignmentProperty, HorizontalAlignment.Center),
					(SetterBase)new Setter(FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Top)
				}
			};
			mM.Seal();
		}
		column.EditingElementStyle = mM;
	}

	protected virtual void ApplyThemedStyle(DataGridComboBoxColumn column)
	{
		if (column == null)
		{
			throw new ArgumentNullException(Ng.cn(882));
		}
		if (column.ElementStyle != DataGridComboBoxColumn.DefaultElementStyle && column.EditingElementStyle != DataGridComboBoxColumn.DefaultEditingElementStyle)
		{
			return;
		}
		if (tW == null)
		{
			if (!(TryFindResource(SharedResourceKeys.ComboBoxStyleKey) is Style basedOn))
			{
				return;
			}
			tW = new Style(typeof(ComboBox))
			{
				BasedOn = basedOn,
				Setters = { (SetterBase)new Setter(Selector.IsSynchronizedWithCurrentItemProperty, false) }
			};
			tW.Seal();
		}
		if (column.ElementStyle == DataGridComboBoxColumn.DefaultElementStyle)
		{
			column.ElementStyle = tW;
		}
		if (column.EditingElementStyle == DataGridComboBoxColumn.DefaultEditingElementStyle)
		{
			column.EditingElementStyle = tW;
		}
	}

	protected override void OnAutoGeneratingColumn(DataGridAutoGeneratingColumnEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Ng.cn(898));
		}
		if (e.Column is DataGridComboBoxColumn column)
		{
			ApplyThemedStyle(column);
		}
		else if (e.Column is DataGridCheckBoxColumn column2)
		{
			ApplyThemedStyle(column2);
		}
		base.OnAutoGeneratingColumn(e);
	}

	public ThemedDataGrid()
	{
		ns.vQ9Sfz();
		base._002Ector();
	}

	internal static bool xM()
	{
		return bJ == null;
	}

	internal static ThemedDataGrid rR()
	{
		return bJ;
	}
}
