using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data.Filtering;

[ContentProperty("Children")]
public class DataFilterGroup : DataFilterBase
{
	private DataFilterCollection tlX;

	public static readonly DependencyProperty OperationProperty;

	private static DataFilterGroup eOP;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DataFilterCollection Children => tlX;

	public DataFilterGroupOperation Operation
	{
		get
		{
			return (DataFilterGroupOperation)GetValue(OperationProperty);
		}
		set
		{
			SetValue(OperationProperty, value);
		}
	}

	public DataFilterGroup()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		tlX = new DataFilterCollection();
		tlX.CollectionChanged += Elv;
	}

	private void Nlj(object P_0, EventArgs P_1)
	{
		RaiseFilterChangedEvent();
	}

	private void Elv(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		IList oldItems = P_1.OldItems;
		if (oldItems != null)
		{
			foreach (IDataFilter item in oldItems)
			{
				if (item != null)
				{
					item.FilterChanged -= Nlj;
				}
			}
		}
		IList newItems = P_1.NewItems;
		if (newItems != null)
		{
			int num = 0;
			if (aOz() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			foreach (IDataFilter item2 in newItems)
			{
				if (item2 != null)
				{
					item2.FilterChanged += Nlj;
				}
			}
		}
		RaiseFilterChangedEvent();
	}

	public override DataFilterResult Filter(object item, object context)
	{
		DataFilterGroupOperation operation = Operation;
		DataFilterGroupOperation dataFilterGroupOperation = operation;
		if (dataFilterGroupOperation == DataFilterGroupOperation.Or)
		{
			DataFilterResult dataFilterResult = DataFilterResult.Excluded;
			bool flag = false;
			foreach (IDataFilter item2 in tlX)
			{
				if (item2 != null && item2.IsEnabled)
				{
					switch (item2.Filter(item, context))
					{
					case DataFilterResult.Included:
					case DataFilterResult.IncludedWithDescendants:
						return base.IncludedFilterResult;
					case DataFilterResult.IncludedByDescendants:
						dataFilterResult = DataFilterResult.IncludedByDescendants;
						break;
					}
					flag = true;
				}
			}
			return flag ? dataFilterResult : FallbackFilterResult;
		}
		DataFilterResult dataFilterResult2 = base.IncludedFilterResult;
		bool flag2 = false;
		foreach (IDataFilter item3 in tlX)
		{
			if (item3 != null && item3.IsEnabled)
			{
				switch (item3.Filter(item, context))
				{
				case DataFilterResult.IncludedByDescendants:
					dataFilterResult2 = DataFilterResult.IncludedByDescendants;
					break;
				case DataFilterResult.Excluded:
					return DataFilterResult.Excluded;
				}
				flag2 = true;
			}
		}
		return flag2 ? dataFilterResult2 : FallbackFilterResult;
	}

	static DataFilterGroup()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		OperationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112766), typeof(DataFilterGroupOperation), typeof(DataFilterGroup), new PropertyMetadata(DataFilterGroupOperation.And, DataFilterBase.OnFilterRelatedPropertyValueChanged));
	}

	internal static bool EOW()
	{
		return eOP == null;
	}

	internal static DataFilterGroup aOz()
	{
		return eOP;
	}
}
