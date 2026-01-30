using System;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public class DockingWindowCollectionBase<T> : DeferrableObservableCollection<T> where T : DockingWindow
{
	internal static object hs;

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
		for (int i = 0; i < base.Count; i++)
		{
			if (base[i].UniqueId == uniqueId)
			{
				return i;
			}
		}
		return -1;
	}

	public DockingWindowCollectionBase()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool qQ()
	{
		return hs == null;
	}

	internal static object dv()
	{
		return hs;
	}
}
