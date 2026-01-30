using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

public class KeyedObservableCollection<T> : SimpleObservableCollection<T>, IKeyedObservableCollection<T>, IObservableCollection<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : class, IKeyedObject
{
	internal static object AWn;

	public virtual T this[string key]
	{
		get
		{
			int num = IndexOf(key);
			if (num != -1)
			{
				return base[num];
			}
			return null;
		}
	}

	public bool Contains(string key)
	{
		return IndexOf(key) != -1;
	}

	public virtual int IndexOf(string key)
	{
		for (int i = 0; i < base.Count; i++)
		{
			if (base[i].Key == key)
			{
				return i;
			}
		}
		return -1;
	}

	public virtual bool Remove(string key)
	{
		int num = IndexOf(key);
		if (num != -1)
		{
			RemoveAt(num);
		}
		return num != -1;
	}

	public KeyedObservableCollection()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	[SpecialName]
	bool ICollection<T>.get_IsReadOnly()
	{
		return IsReadOnly;
	}

	internal static bool cWA()
	{
		return AWn == null;
	}

	internal static object GWV()
	{
		return AWn;
	}
}
