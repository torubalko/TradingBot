using System.Collections;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

public class SimpleSynchronizedCollection<T> : SimpleObservableCollection<T> where T : class
{
	internal static object oWT;

	protected override void ClearItems()
	{
		lock (((ICollection)this).SyncRoot)
		{
			base.ClearItems();
		}
	}

	protected override void InsertItem(int index, T item)
	{
		lock (((ICollection)this).SyncRoot)
		{
			base.InsertItem(index, item);
		}
	}

	protected override void RemoveItem(int index)
	{
		lock (((ICollection)this).SyncRoot)
		{
			base.RemoveItem(index);
		}
	}

	protected override void SetItem(int index, T item)
	{
		lock (((ICollection)this).SyncRoot)
		{
			base.SetItem(index, item);
		}
	}

	public SimpleSynchronizedCollection()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool dWk()
	{
		return oWT == null;
	}

	internal static object cWX()
	{
		return oWT;
	}
}
