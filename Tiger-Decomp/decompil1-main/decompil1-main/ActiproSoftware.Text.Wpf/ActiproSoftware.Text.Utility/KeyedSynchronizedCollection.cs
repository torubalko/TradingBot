using System.Collections;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

public class KeyedSynchronizedCollection<T> : KeyedObservableCollection<T> where T : class, IKeyedObject
{
	internal static object gWb;

	public override T this[string key]
	{
		get
		{
			lock (((ICollection)this).SyncRoot)
			{
				return base[key];
			}
		}
	}

	protected override void ClearItems()
	{
		lock (((ICollection)this).SyncRoot)
		{
			base.ClearItems();
		}
	}

	public override int IndexOf(string key)
	{
		lock (((ICollection)this).SyncRoot)
		{
			return base.IndexOf(key);
		}
	}

	protected override void InsertItem(int index, T item)
	{
		lock (((ICollection)this).SyncRoot)
		{
			base.InsertItem(index, item);
		}
	}

	public override bool Remove(string key)
	{
		lock (((ICollection)this).SyncRoot)
		{
			return base.Remove(key);
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

	public KeyedSynchronizedCollection()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool OW1()
	{
		return gWb == null;
	}

	internal static object yW5()
	{
		return gWb;
	}
}
