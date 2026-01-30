using System;
using System.Collections;
using System.Collections.Generic;

namespace MailKit;

public class AccessRights : ICollection<AccessRight>, IEnumerable<AccessRight>, IEnumerable
{
	private readonly List<AccessRight> list = new List<AccessRight>();

	public int Count => list.Count;

	public bool IsReadOnly => false;

	public AccessRight this[int index]
	{
		get
		{
			if (index < 0 || index >= list.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return list[index];
		}
	}

	public AccessRights(IEnumerable<AccessRight> rights)
	{
		AddRange(rights);
	}

	public AccessRights(string rights)
	{
		AddRange(rights);
	}

	public AccessRights()
	{
	}

	void ICollection<AccessRight>.Add(AccessRight right)
	{
		Add(right);
	}

	public bool Add(AccessRight right)
	{
		if (list.Contains(right))
		{
			return false;
		}
		list.Add(right);
		return true;
	}

	public bool Add(char right)
	{
		return Add(new AccessRight(right));
	}

	public void AddRange(string rights)
	{
		if (rights == null)
		{
			throw new ArgumentNullException("rights");
		}
		for (int i = 0; i < rights.Length; i++)
		{
			Add(new AccessRight(rights[i]));
		}
	}

	public void AddRange(IEnumerable<AccessRight> rights)
	{
		if (rights == null)
		{
			throw new ArgumentNullException("rights");
		}
		foreach (AccessRight right in rights)
		{
			Add(right);
		}
	}

	public void Clear()
	{
		list.Clear();
	}

	public bool Contains(AccessRight right)
	{
		return list.Contains(right);
	}

	public void CopyTo(AccessRight[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0 || arrayIndex + Count > array.Length)
		{
			throw new ArgumentOutOfRangeException("arrayIndex");
		}
		list.CopyTo(array, arrayIndex);
	}

	public bool Remove(AccessRight right)
	{
		return list.Remove(right);
	}

	public IEnumerator<AccessRight> GetEnumerator()
	{
		return list.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return list.GetEnumerator();
	}

	public override string ToString()
	{
		char[] array = new char[list.Count];
		for (int i = 0; i < list.Count; i++)
		{
			array[i] = list[i].Right;
		}
		return new string(array);
	}
}
