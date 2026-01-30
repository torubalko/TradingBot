using System;
using System.Collections;
using System.Collections.Generic;

namespace MimeKit;

public class HeaderListCollection : ICollection<HeaderList>, IEnumerable<HeaderList>, IEnumerable
{
	private readonly List<HeaderList> groups;

	public int Count => groups.Count;

	public bool IsReadOnly => false;

	public HeaderList this[int index]
	{
		get
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return groups[index];
		}
		set
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (groups[index] != value)
			{
				groups[index].Changed -= OnGroupChanged;
				value.Changed += OnGroupChanged;
				groups[index] = value;
			}
		}
	}

	internal event EventHandler Changed;

	public HeaderListCollection()
	{
		groups = new List<HeaderList>();
	}

	public void Add(HeaderList group)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		group.Changed += OnGroupChanged;
		groups.Add(group);
		OnChanged();
	}

	public void Clear()
	{
		for (int i = 0; i < groups.Count; i++)
		{
			groups[i].Changed -= OnGroupChanged;
		}
		groups.Clear();
		OnChanged();
	}

	public bool Contains(HeaderList group)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		return groups.Contains(group);
	}

	public void CopyTo(HeaderList[] array, int arrayIndex)
	{
		groups.CopyTo(array, arrayIndex);
	}

	public bool Remove(HeaderList group)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (!groups.Remove(group))
		{
			return false;
		}
		group.Changed -= OnGroupChanged;
		OnChanged();
		return true;
	}

	public IEnumerator<HeaderList> GetEnumerator()
	{
		return groups.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	private void OnChanged()
	{
		this.Changed?.Invoke(this, EventArgs.Empty);
	}

	private void OnGroupChanged(object sender, HeaderListChangedEventArgs e)
	{
		OnChanged();
	}
}
