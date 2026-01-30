using System.Collections;
using System.Windows;

namespace ActiproSoftware.Windows;

public static class LogicalTreeHelperExtended
{
	internal static LogicalTreeHelperExtended As;

	public static DependencyObject GetRoot(DependencyObject source)
	{
		while (LogicalTreeHelper.GetParent(source) != null)
		{
			source = LogicalTreeHelper.GetParent(source);
		}
		return source;
	}

	public static IEnumerator Merge(params object[] items)
	{
		if (items == null || items.Length == 0)
		{
			return null;
		}
		ArrayList arrayList = new ArrayList();
		foreach (object obj in items)
		{
			if (obj == null)
			{
				continue;
			}
			if (obj is ICollection c)
			{
				arrayList.AddRange(c);
			}
			else if (obj is IEnumerator enumerator)
			{
				enumerator.Reset();
				while (enumerator.MoveNext())
				{
					arrayList.Add(enumerator.Current);
				}
			}
			else
			{
				arrayList.Add(obj);
			}
		}
		if (arrayList.Count > 0)
		{
			return arrayList.GetEnumerator();
		}
		return null;
	}

	internal static bool gi()
	{
		return As == null;
	}

	internal static LogicalTreeHelperExtended gp()
	{
		return As;
	}
}
