using System;
using System.Collections;
using System.Collections.Generic;

namespace MailKit;

public class UniqueIdMap : IReadOnlyDictionary<UniqueId, UniqueId>, IReadOnlyCollection<KeyValuePair<UniqueId, UniqueId>>, IEnumerable<KeyValuePair<UniqueId, UniqueId>>, IEnumerable
{
	public static readonly UniqueIdMap Empty = new UniqueIdMap();

	public IList<UniqueId> Source { get; private set; }

	public IList<UniqueId> Destination { get; private set; }

	public int Count => Source.Count;

	public IEnumerable<UniqueId> Keys => Source;

	public IEnumerable<UniqueId> Values => Destination;

	public UniqueId this[UniqueId index]
	{
		get
		{
			if (!TryGetValue(index, out var value))
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return value;
		}
	}

	public UniqueIdMap(IList<UniqueId> source, IList<UniqueId> destination)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		Destination = destination;
		Source = source;
	}

	private UniqueIdMap()
	{
		Destination = (Source = new UniqueId[0]);
	}

	public bool ContainsKey(UniqueId key)
	{
		return Source.Contains(key);
	}

	public bool TryGetValue(UniqueId key, out UniqueId value)
	{
		int num = Source.IndexOf(key);
		if (num == -1 || num >= Destination.Count)
		{
			value = UniqueId.Invalid;
			return false;
		}
		value = Destination[num];
		return true;
	}

	public IEnumerator<KeyValuePair<UniqueId, UniqueId>> GetEnumerator()
	{
		IEnumerator<UniqueId> dst = Destination.GetEnumerator();
		IEnumerator<UniqueId> src = Source.GetEnumerator();
		while (src.MoveNext() && dst.MoveNext())
		{
			yield return new KeyValuePair<UniqueId, UniqueId>(src.Current, dst.Current);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
