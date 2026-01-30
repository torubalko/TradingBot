using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace MailKit;

public class UniqueIdRange : IList<UniqueId>, ICollection<UniqueId>, IEnumerable<UniqueId>, IEnumerable
{
	public static readonly UniqueIdRange All = new UniqueIdRange(UniqueId.MinValue, UniqueId.MaxValue);

	private static readonly UniqueIdRange Invalid = new UniqueIdRange();

	private readonly uint validity;

	internal uint start;

	internal uint end;

	public uint Validity => validity;

	public UniqueId Min
	{
		get
		{
			if (start >= end)
			{
				return new UniqueId(validity, end);
			}
			return new UniqueId(validity, start);
		}
	}

	public UniqueId Max
	{
		get
		{
			if (start <= end)
			{
				return new UniqueId(validity, end);
			}
			return new UniqueId(validity, start);
		}
	}

	public UniqueId Start => new UniqueId(validity, start);

	public UniqueId End => new UniqueId(validity, end);

	public int Count => (int)(((start <= end) ? (end - start) : (start - end)) + 1);

	public bool IsReadOnly => true;

	public UniqueId this[int index]
	{
		get
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			uint id = ((start <= end) ? (start + (uint)index) : (start - (uint)index));
			return new UniqueId(validity, id);
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	private UniqueIdRange()
	{
	}

	public UniqueIdRange(uint validity, uint start, uint end)
	{
		if (start == 0)
		{
			throw new ArgumentOutOfRangeException("start");
		}
		if (end == 0)
		{
			throw new ArgumentOutOfRangeException("end");
		}
		this.validity = validity;
		this.start = start;
		this.end = end;
	}

	public UniqueIdRange(UniqueId start, UniqueId end)
	{
		if (!start.IsValid)
		{
			throw new ArgumentOutOfRangeException("start");
		}
		if (!end.IsValid)
		{
			throw new ArgumentOutOfRangeException("end");
		}
		validity = start.Validity;
		this.start = start.Id;
		this.end = end.Id;
	}

	public void Add(UniqueId uid)
	{
		throw new NotSupportedException();
	}

	public void Clear()
	{
		throw new NotSupportedException();
	}

	public bool Contains(UniqueId uid)
	{
		if (start <= end)
		{
			if (uid.Id >= start)
			{
				return uid.Id <= end;
			}
			return false;
		}
		if (uid.Id <= start)
		{
			return uid.Id >= end;
		}
		return false;
	}

	public void CopyTo(UniqueId[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0 || arrayIndex > array.Length - Count)
		{
			throw new ArgumentOutOfRangeException("arrayIndex");
		}
		int num = arrayIndex;
		if (start <= end)
		{
			uint num2 = start;
			while (num2 <= end)
			{
				array[num] = new UniqueId(validity, num2);
				num2++;
				num++;
			}
		}
		else
		{
			uint num3 = start;
			while (num3 >= end)
			{
				array[num] = new UniqueId(validity, num3);
				num3--;
				num++;
			}
		}
	}

	public bool Remove(UniqueId uid)
	{
		throw new NotSupportedException();
	}

	public int IndexOf(UniqueId uid)
	{
		if (start <= end)
		{
			if (uid.Id < start || uid.Id > end)
			{
				return -1;
			}
			return (int)(uid.Id - start);
		}
		if (uid.Id > start || uid.Id < end)
		{
			return -1;
		}
		return (int)(start - uid.Id);
	}

	public void Insert(int index, UniqueId uid)
	{
		throw new NotSupportedException();
	}

	public void RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	public IEnumerator<UniqueId> GetEnumerator()
	{
		if (start <= end)
		{
			for (uint uid = start; uid <= end; uid++)
			{
				yield return new UniqueId(validity, uid);
			}
			yield break;
		}
		for (uint uid = start; uid >= end; uid--)
		{
			yield return new UniqueId(validity, uid);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public override string ToString()
	{
		if (end == uint.MaxValue)
		{
			return string.Format(CultureInfo.InvariantCulture, "{0}:*", start);
		}
		return string.Format(CultureInfo.InvariantCulture, "{0}:{1}", start, end);
	}

	public static bool TryParse(string token, uint validity, out UniqueIdRange range)
	{
		if (token == null)
		{
			throw new ArgumentNullException("token");
		}
		int index = 0;
		if (!UniqueId.TryParse(token, ref index, out var uid) || index + 2 > token.Length || token[index++] != ':')
		{
			range = Invalid;
			return false;
		}
		uint uid2;
		if (token[index] != '*')
		{
			if (!UniqueId.TryParse(token, ref index, out uid2) || index < token.Length)
			{
				range = Invalid;
				return false;
			}
		}
		else
		{
			if (index + 1 != token.Length)
			{
				range = Invalid;
				return false;
			}
			uid2 = uint.MaxValue;
		}
		range = new UniqueIdRange(validity, uid, uid2);
		return true;
	}

	public static bool TryParse(string token, out UniqueIdRange range)
	{
		return TryParse(token, 0u, out range);
	}
}
