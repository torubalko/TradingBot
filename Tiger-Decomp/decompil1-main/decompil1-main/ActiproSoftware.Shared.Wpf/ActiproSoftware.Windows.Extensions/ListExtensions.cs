using System;
using System.Collections.Generic;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Windows.Extensions;

public static class ListExtensions
{
	public static void AddRange<T>(this IList<T> list, IEnumerable<T> collection)
	{
		if (list == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111128));
		}
		if (collection == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132));
		}
		if (list is List<T> list2)
		{
			list2.AddRange(collection);
			return;
		}
		foreach (T item in collection)
		{
			list.Add(item);
		}
	}

	public static void InsertRange<T>(this IList<T> list, int index, IEnumerable<T> collection)
	{
		if (list == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111128));
		}
		if (collection == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132));
		}
		if (list is List<T> list2)
		{
			list2.InsertRange(index, collection);
			return;
		}
		int num = 0;
		foreach (T item in collection)
		{
			list.Insert(index + num++, item);
		}
	}

	public static int RemoveAll<T>(this IList<T> list, Predicate<T> match)
	{
		if (list == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111128));
		}
		if (match == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111140));
		}
		if (list is List<T> list2)
		{
			return list2.RemoveAll(match);
		}
		int num = 0;
		for (int num2 = list.Count - 1; num2 >= 0; num2--)
		{
			if (match(list[num2]))
			{
				list.RemoveAt(num2);
				num++;
			}
		}
		return num;
	}
}
