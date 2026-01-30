using System.Collections.Generic;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

internal class CachingList<T>
{
	private T uYl;

	private Dictionary<T, int> wYA;

	private List<T> GYC;

	private static readonly bool mYY;

	internal static object BnQ;

	public T this[int index] => (GYC != null) ? GYC[index] : uYl;

	public void Clear()
	{
		uYl = default(T);
		wYA = null;
		GYC = null;
	}

	public int GetIndex(T item)
	{
		if (item.Equals(uYl))
		{
			return 0;
		}
		if (mYY)
		{
			if (uYl == null)
			{
				uYl = item;
				return 0;
			}
		}
		else if (default(T).Equals(uYl))
		{
			uYl = item;
			return 0;
		}
		int value;
		if (wYA == null)
		{
			wYA = new Dictionary<T, int>();
		}
		else if (wYA.TryGetValue(item, out value))
		{
			return value;
		}
		if (GYC == null)
		{
			GYC = new List<T>(2);
			GYC.Add(uYl);
			GYC.Add(item);
			wYA[uYl] = 0;
			wYA[item] = 1;
			return 1;
		}
		value = GYC.Count;
		wYA[item] = value;
		GYC.Add(item);
		return value;
	}

	public CachingList()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static CachingList()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		mYY = default(T) == null;
	}

	internal static bool PnC()
	{
		return BnQ == null;
	}

	internal static object CnR()
	{
		return BnQ;
	}
}
