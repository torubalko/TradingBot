using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class ReadOnlyDockingWindowBaseCollection<T> : ReadOnlyObservableCollection<T> where T : DockingWindow
{
	internal static object Ne;

	public T this[string name]
	{
		get
		{
			int num = IndexOf(name);
			if (num != -1)
			{
				return base[num];
			}
			return null;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1043:UseIntegralOrStringArgumentForIndexers")]
	public T this[Guid uniqueId]
	{
		get
		{
			int num = IndexOf(uniqueId);
			if (num != -1)
			{
				return base[num];
			}
			return null;
		}
	}

	public ReadOnlyDockingWindowBaseCollection(ObservableCollection<T> list)
	{
		IVH.CecNqz();
		base._002Ector(list);
	}

	public bool Contains(string name)
	{
		return IndexOf(name) != -1;
	}

	public bool Contains(Guid uniqueId)
	{
		return IndexOf(uniqueId) != -1;
	}

	public int IndexOf(string name)
	{
		for (int i = 0; i < base.Count; i++)
		{
			if (base[i].Name == name)
			{
				return i;
			}
		}
		return -1;
	}

	public int IndexOf(Guid uniqueId)
	{
		int num = 0;
		while (true)
		{
			if (num < base.Count)
			{
				if (base[num].UniqueId == uniqueId)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public T[] ToArray()
	{
		T[] array = new T[base.Count];
		CopyTo(array, 0);
		return array;
	}

	internal static bool MJ()
	{
		return Ne == null;
	}

	internal static object mU()
	{
		return Ne;
	}
}
