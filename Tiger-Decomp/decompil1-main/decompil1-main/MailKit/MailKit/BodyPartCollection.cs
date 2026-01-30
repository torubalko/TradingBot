using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MimeKit.Utils;

namespace MailKit;

public class BodyPartCollection : ICollection<BodyPart>, IEnumerable<BodyPart>, IEnumerable
{
	private readonly List<BodyPart> collection = new List<BodyPart>();

	public int Count => collection.Count;

	public bool IsReadOnly => false;

	public BodyPart this[int index]
	{
		get
		{
			if (index < 0 || index >= collection.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return collection[index];
		}
	}

	public void Add(BodyPart part)
	{
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		collection.Add(part);
	}

	public void Clear()
	{
		collection.Clear();
	}

	public bool Contains(BodyPart part)
	{
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		return collection.Contains(part);
	}

	public void CopyTo(BodyPart[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0 || arrayIndex + Count > array.Length)
		{
			throw new ArgumentOutOfRangeException("arrayIndex");
		}
		collection.CopyTo(array, arrayIndex);
	}

	public bool Remove(BodyPart part)
	{
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		return collection.Remove(part);
	}

	public int IndexOf(Uri uri)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		bool flag = uri.IsAbsoluteUri && uri.Scheme.ToLowerInvariant() == "cid";
		for (int i = 0; i < Count; i++)
		{
			if (!(this[i] is BodyPartBasic bodyPartBasic))
			{
				continue;
			}
			if (uri.IsAbsoluteUri)
			{
				if (flag)
				{
					if (!string.IsNullOrEmpty(bodyPartBasic.ContentId))
					{
						string text = MimeUtils.EnumerateReferences(bodyPartBasic.ContentId).FirstOrDefault() ?? bodyPartBasic.ContentId;
						if (text == uri.AbsolutePath)
						{
							return i;
						}
					}
				}
				else if (bodyPartBasic.ContentLocation != null && bodyPartBasic.ContentLocation.IsAbsoluteUri && bodyPartBasic.ContentLocation == uri)
				{
					return i;
				}
			}
			else if (bodyPartBasic.ContentLocation == uri)
			{
				return i;
			}
		}
		return -1;
	}

	public IEnumerator<BodyPart> GetEnumerator()
	{
		return collection.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
