using System.Collections.Generic;
using System.Windows.Media;
using ActiproSoftware.Windows.Media;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public class LogicalChildrenCollection<T> : DeferrableObservableCollection<T>
{
	private ILogicalParent bn;

	private IVisualParent ca;

	private static object WU;

	public ILogicalParent Parent => bn;

	public LogicalChildrenCollection(ILogicalParent parent)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(parent, areVisualChildren: false);
	}

	public LogicalChildrenCollection(ILogicalParent parent, bool areVisualChildren)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		bn = parent;
		if (areVisualChildren)
		{
			ca = parent as IVisualParent;
		}
	}

	protected override void ClearItems()
	{
		if (bn != null)
		{
			using IEnumerator<T> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				T current = enumerator.Current;
				if (ca != null && current is Visual child)
				{
					ca.RemoveVisualChild(child);
				}
				bn.RemoveLogicalChild(current);
			}
		}
		base.ClearItems();
	}

	protected override void InsertItem(int index, T item)
	{
		base.InsertItem(index, item);
		if (bn != null)
		{
			bn.AddLogicalChild(item);
			if (ca != null && item is Visual child)
			{
				ca.AddVisualChild(child);
			}
		}
	}

	protected override void RemoveItem(int index)
	{
		if (bn != null)
		{
			T val = base[index];
			if (ca != null && val is Visual child)
			{
				ca.RemoveVisualChild(child);
			}
			bn.RemoveLogicalChild(val);
		}
		base.RemoveItem(index);
	}

	protected override void SetItem(int index, T item)
	{
		if (bn != null && (object)base[index] != (object)item)
		{
			T val = base[index];
			if (ca != null && val is Visual child)
			{
				ca.RemoveVisualChild(child);
			}
			bn.RemoveLogicalChild(val);
			base.SetItem(index, item);
			bn.AddLogicalChild(item);
			if (ca != null && item is Visual child2)
			{
				ca.AddVisualChild(child2);
			}
		}
		else
		{
			base.SetItem(index, item);
		}
	}

	internal static bool vL()
	{
		return WU == null;
	}

	internal static object g4()
	{
		return WU;
	}
}
