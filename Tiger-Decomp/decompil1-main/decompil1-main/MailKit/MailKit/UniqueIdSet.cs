using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using MailKit.Search;

namespace MailKit;

public class UniqueIdSet : IList<UniqueId>, ICollection<UniqueId>, IEnumerable<UniqueId>, IEnumerable
{
	private struct Range
	{
		public uint Start;

		public uint End;

		public int Count => (int)(((Start <= End) ? (End - Start) : (Start - End)) + 1);

		public uint this[int index]
		{
			get
			{
				if (Start > End)
				{
					return Start - (uint)index;
				}
				return Start + (uint)index;
			}
		}

		public Range(uint start, uint end)
		{
			Start = start;
			End = end;
		}

		public bool Contains(uint uid)
		{
			if (Start <= End)
			{
				if (uid >= Start)
				{
					return uid <= End;
				}
				return false;
			}
			if (uid <= Start)
			{
				return uid >= End;
			}
			return false;
		}

		public int IndexOf(uint uid)
		{
			if (Start <= End)
			{
				if (uid < Start || uid > End)
				{
					return -1;
				}
				return (int)(uid - Start);
			}
			if (uid > Start || uid < End)
			{
				return -1;
			}
			return (int)(Start - uid);
		}

		public IEnumerator<uint> GetEnumerator()
		{
			if (Start <= End)
			{
				for (uint uid = Start; uid <= End; uid++)
				{
					yield return uid;
				}
				yield break;
			}
			for (uint uid = Start; uid >= End; uid--)
			{
				yield return uid;
			}
		}

		public override string ToString()
		{
			if (Start == End)
			{
				return Start.ToString(CultureInfo.InvariantCulture);
			}
			if (Start <= End && End == uint.MaxValue)
			{
				return string.Format(CultureInfo.InvariantCulture, "{0}:*", Start);
			}
			return string.Format(CultureInfo.InvariantCulture, "{0}:{1}", Start, End);
		}
	}

	private readonly List<Range> ranges = new List<Range>();

	private long count;

	public SortOrder SortOrder { get; private set; }

	public uint Validity { get; private set; }

	public int Count => (int)Math.Min(count, 2147483647L);

	public bool IsReadOnly => false;

	public UniqueId this[int index]
	{
		get
		{
			if (index < 0 || index >= count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int num = 0;
			for (int i = 0; i < ranges.Count; i++)
			{
				if (index >= num + ranges[i].Count)
				{
					num += ranges[i].Count;
					continue;
				}
				uint id = ranges[i][index - num];
				return new UniqueId(Validity, id);
			}
			throw new ArgumentOutOfRangeException("index");
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public UniqueIdSet(uint validity, SortOrder order = SortOrder.None)
	{
		if ((uint)order > 2u)
		{
			throw new ArgumentOutOfRangeException("order");
		}
		Validity = validity;
		SortOrder = order;
	}

	public UniqueIdSet(SortOrder order = SortOrder.None)
		: this(0u, order)
	{
	}

	public UniqueIdSet(IEnumerable<UniqueId> uids, SortOrder order = SortOrder.None)
		: this(order)
	{
		foreach (UniqueId uid in uids)
		{
			Add(uid);
		}
	}

	private int BinarySearch(uint uid)
	{
		int num = 0;
		int num2 = ranges.Count;
		if (num2 == 0)
		{
			return -1;
		}
		do
		{
			int num3 = num + (num2 - num) / 2;
			if (SortOrder == SortOrder.Ascending)
			{
				if (uid >= ranges[num3].Start)
				{
					if (uid <= ranges[num3].End)
					{
						return num3;
					}
					num = num3 + 1;
				}
				else
				{
					num2 = num3;
				}
			}
			else if (uid >= ranges[num3].End)
			{
				if (uid <= ranges[num3].Start)
				{
					return num3;
				}
				num2 = num3;
			}
			else
			{
				num = num3 + 1;
			}
		}
		while (num < num2);
		return -1;
	}

	private int IndexOfRange(uint uid)
	{
		if (SortOrder != SortOrder.None)
		{
			return BinarySearch(uid);
		}
		for (int i = 0; i < ranges.Count; i++)
		{
			if (ranges[i].Contains(uid))
			{
				return i;
			}
		}
		return -1;
	}

	private void BinaryInsertAscending(uint uid)
	{
		int num = 0;
		int num2 = ranges.Count;
		int num3;
		do
		{
			num3 = num + (num2 - num) / 2;
			if (uid >= ranges[num3].Start)
			{
				if (uid <= ranges[num3].End)
				{
					return;
				}
				if (uid == ranges[num3].End + 1)
				{
					if (num3 + 1 < ranges.Count && uid + 1 >= ranges[num3 + 1].Start)
					{
						ranges[num3] = new Range(ranges[num3].Start, ranges[num3 + 1].End);
						ranges.RemoveAt(num3 + 1);
						count++;
					}
					else
					{
						ranges[num3] = new Range(ranges[num3].Start, uid);
						count++;
					}
					return;
				}
				num = num3 + 1;
				num3 = num;
				continue;
			}
			if (uid == ranges[num3].Start - 1)
			{
				if (num3 > 0 && uid - 1 <= ranges[num3 - 1].End)
				{
					ranges[num3 - 1] = new Range(ranges[num3 - 1].Start, ranges[num3].End);
					ranges.RemoveAt(num3);
					count++;
				}
				else
				{
					ranges[num3] = new Range(uid, ranges[num3].End);
					count++;
				}
				return;
			}
			num2 = num3;
		}
		while (num < num2);
		Range item = new Range(uid, uid);
		if (num3 < ranges.Count)
		{
			ranges.Insert(num3, item);
		}
		else
		{
			ranges.Add(item);
		}
		count++;
	}

	private void BinaryInsertDescending(uint uid)
	{
		int num = 0;
		int num2 = ranges.Count;
		int num3;
		do
		{
			num3 = num + (num2 - num) / 2;
			if (uid <= ranges[num3].Start)
			{
				if (uid >= ranges[num3].End)
				{
					return;
				}
				if (uid == ranges[num3].End - 1)
				{
					if (num3 + 1 < ranges.Count && uid - 1 <= ranges[num3 + 1].Start)
					{
						ranges[num3] = new Range(ranges[num3].Start, ranges[num3 + 1].End);
						ranges.RemoveAt(num3 + 1);
						count++;
					}
					else
					{
						ranges[num3] = new Range(ranges[num3].Start, uid);
						count++;
					}
					return;
				}
				num = num3 + 1;
				num3 = num;
				continue;
			}
			if (uid == ranges[num3].Start + 1)
			{
				if (num3 > 0 && uid + 1 >= ranges[num3 - 1].End)
				{
					ranges[num3 - 1] = new Range(ranges[num3 - 1].Start, ranges[num3].End);
					ranges.RemoveAt(num3);
					count++;
				}
				else
				{
					ranges[num3] = new Range(uid, ranges[num3].End);
					count++;
				}
				return;
			}
			num2 = num3;
		}
		while (num < num2);
		Range item = new Range(uid, uid);
		if (num3 < ranges.Count)
		{
			ranges.Insert(num3, item);
		}
		else
		{
			ranges.Add(item);
		}
		count++;
	}

	private void Append(uint uid)
	{
		if (IndexOfRange(uid) != -1)
		{
			return;
		}
		count++;
		if (ranges.Count > 0)
		{
			int index = ranges.Count - 1;
			Range range = ranges[index];
			if (range.Start == range.End)
			{
				if (uid == range.End + 1 || uid == range.End - 1)
				{
					ranges[index] = new Range(range.Start, uid);
					return;
				}
			}
			else if (range.Start < range.End)
			{
				if (uid == range.End + 1)
				{
					ranges[index] = new Range(range.Start, uid);
					return;
				}
			}
			else if (range.Start > range.End && uid == range.End - 1)
			{
				ranges[index] = new Range(range.Start, uid);
				return;
			}
		}
		ranges.Add(new Range(uid, uid));
	}

	public void Add(UniqueId uid)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("Invalid unique identifier.", "uid");
		}
		if (ranges.Count == 0)
		{
			ranges.Add(new Range(uid.Id, uid.Id));
			count++;
			return;
		}
		switch (SortOrder)
		{
		case SortOrder.Descending:
			BinaryInsertDescending(uid.Id);
			break;
		case SortOrder.Ascending:
			BinaryInsertAscending(uid.Id);
			break;
		default:
			Append(uid.Id);
			break;
		}
	}

	public void AddRange(IEnumerable<UniqueId> uids)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		foreach (UniqueId uid in uids)
		{
			Add(uid);
		}
	}

	public void Clear()
	{
		ranges.Clear();
		count = 0L;
	}

	public bool Contains(UniqueId uid)
	{
		return IndexOfRange(uid.Id) != -1;
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
		for (int i = 0; i < ranges.Count; i++)
		{
			foreach (uint item in ranges[i])
			{
				array[num++] = new UniqueId(Validity, item);
			}
		}
	}

	private void Remove(int index, uint uid)
	{
		Range range = ranges[index];
		if (uid == range.Start)
		{
			if (range.Start != range.End)
			{
				if (range.Start <= range.End)
				{
					ranges[index] = new Range(uid + 1, range.End);
				}
				else
				{
					ranges[index] = new Range(uid - 1, range.End);
				}
			}
			else
			{
				ranges.RemoveAt(index);
			}
		}
		else if (uid == range.End)
		{
			if (range.Start <= range.End)
			{
				ranges[index] = new Range(range.Start, uid - 1);
			}
			else
			{
				ranges[index] = new Range(range.Start, uid + 1);
			}
		}
		else if (range.Start < range.End)
		{
			ranges.Insert(index, new Range(range.Start, uid - 1));
			ranges[index + 1] = new Range(uid + 1, range.End);
		}
		else
		{
			ranges.Insert(index, new Range(range.Start, uid + 1));
			ranges[index + 1] = new Range(uid - 1, range.End);
		}
		count--;
	}

	public bool Remove(UniqueId uid)
	{
		int num = IndexOfRange(uid.Id);
		if (num == -1)
		{
			return false;
		}
		Remove(num, uid.Id);
		return true;
	}

	public int IndexOf(UniqueId uid)
	{
		int num = 0;
		for (int i = 0; i < ranges.Count; i++)
		{
			if (ranges[i].Contains(uid.Id))
			{
				return num + ranges[i].IndexOf(uid.Id);
			}
			num += ranges[i].Count;
		}
		return -1;
	}

	public void Insert(int index, UniqueId uid)
	{
		throw new NotSupportedException();
	}

	public void RemoveAt(int index)
	{
		if (index < 0 || index >= count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		int num = 0;
		for (int i = 0; i < ranges.Count; i++)
		{
			if (index >= num + ranges[i].Count)
			{
				num += ranges[i].Count;
				continue;
			}
			uint uid = ranges[i][index - num];
			Remove(i, uid);
			break;
		}
	}

	public IEnumerator<UniqueId> GetEnumerator()
	{
		for (int i = 0; i < ranges.Count; i++)
		{
			foreach (uint item in ranges[i])
			{
				yield return new UniqueId(Validity, item);
			}
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public override string ToString()
	{
		using (IEnumerator<string> enumerator = EnumerateSerializedSubsets(int.MaxValue).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return enumerator.Current;
			}
		}
		return string.Empty;
	}

	public static string ToString(IList<UniqueId> uids)
	{
		using (IEnumerator<string> enumerator = EnumerateSerializedSubsets(uids, int.MaxValue).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return enumerator.Current;
			}
		}
		return string.Empty;
	}

	private IEnumerable<string> EnumerateSerializedSubsets(int maxLength)
	{
		if (maxLength < 0)
		{
			throw new ArgumentOutOfRangeException("maxLength");
		}
		StringBuilder builder = new StringBuilder();
		for (int i = 0; i < ranges.Count; i++)
		{
			string range = ranges[i].ToString();
			if (builder.Length > 0)
			{
				if (builder.Length + 1 + range.Length > maxLength)
				{
					yield return builder.ToString();
					builder.Clear();
				}
				else
				{
					builder.Append(',');
				}
			}
			builder.Append(range);
		}
		yield return builder.ToString();
	}

	internal static IEnumerable<string> EnumerateSerializedSubsets(IList<UniqueId> uids, int maxLength)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		if (maxLength < 0)
		{
			throw new ArgumentOutOfRangeException("maxLength");
		}
		if (uids.Count == 0)
		{
			yield return string.Empty;
			yield break;
		}
		if (uids is UniqueIdRange uniqueIdRange)
		{
			yield return uniqueIdRange.ToString();
			yield break;
		}
		if (uids is UniqueIdSet uniqueIdSet)
		{
			foreach (string item in uniqueIdSet.EnumerateSerializedSubsets(maxLength))
			{
				yield return item;
			}
			yield break;
		}
		StringBuilder builder = new StringBuilder();
		int num = 0;
		while (num < uids.Count)
		{
			if (!uids[num].IsValid)
			{
				throw new ArgumentException("One or more of the uids is invalid.", "uids");
			}
			uint id = uids[num].Id;
			uint num2 = uids[num].Id;
			int i = num + 1;
			if (i < uids.Count)
			{
				if (uids[i].Id == num2 + 1)
				{
					for (num2 = uids[i++].Id; i < uids.Count && uids[i].Id == num2 + 1; i++)
					{
						num2++;
					}
				}
				else if (uids[i].Id == num2 - 1)
				{
					for (num2 = uids[i++].Id; i < uids.Count && uids[i].Id == num2 - 1; i++)
					{
						num2--;
					}
				}
			}
			string next = ((id == num2) ? id.ToString() : string.Format(CultureInfo.InvariantCulture, "{0}:{1}", id, num2));
			if (builder.Length > 0)
			{
				if (builder.Length + 1 + next.Length > maxLength)
				{
					yield return builder.ToString();
					builder.Clear();
				}
				else
				{
					builder.Append(',');
				}
			}
			builder.Append(next);
			num = i;
		}
		yield return builder.ToString();
	}

	public static bool TryParse(string token, uint validity, out UniqueIdSet uids)
	{
		if (token == null)
		{
			throw new ArgumentNullException("token");
		}
		uids = new UniqueIdSet(validity);
		SortOrder sortOrder = SortOrder.None;
		bool flag = true;
		uint num = 0u;
		int index = 0;
		while (true)
		{
			if (!UniqueId.TryParse(token, ref index, out var uid))
			{
				return false;
			}
			if (index < token.Length && token[index] == ':')
			{
				index++;
				if (!UniqueId.TryParse(token, ref index, out var uid2))
				{
					return false;
				}
				Range item = new Range(uid, uid2);
				uids.count += item.Count;
				uids.ranges.Add(item);
				if (flag)
				{
					switch (sortOrder)
					{
					default:
						flag = true;
						sortOrder = ((uid <= uid2) ? SortOrder.Ascending : SortOrder.Descending);
						break;
					case SortOrder.Descending:
						flag = uid >= uid2 && uid <= num;
						break;
					case SortOrder.Ascending:
						flag = uid <= uid2 && uid >= num;
						break;
					}
				}
				num = uid2;
			}
			else
			{
				uids.ranges.Add(new Range(uid, uid));
				uids.count++;
				if (flag && uids.ranges.Count > 1)
				{
					switch (sortOrder)
					{
					default:
						flag = true;
						sortOrder = ((uid >= num) ? SortOrder.Ascending : SortOrder.Descending);
						break;
					case SortOrder.Descending:
						flag = uid <= num;
						break;
					case SortOrder.Ascending:
						flag = uid >= num;
						break;
					}
				}
				num = uid;
			}
			if (index >= token.Length)
			{
				break;
			}
			if (token[index++] != ',')
			{
				return false;
			}
		}
		uids.SortOrder = (flag ? sortOrder : SortOrder.None);
		return true;
	}

	public static bool TryParse(string token, out UniqueIdSet uids)
	{
		return TryParse(token, 0u, out uids);
	}
}
