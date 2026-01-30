using System;
using System.Collections;
using System.Collections.Generic;

namespace MimeKit.Cryptography;

public class CmsRecipientCollection : ICollection<CmsRecipient>, IEnumerable<CmsRecipient>, IEnumerable
{
	private readonly IList<CmsRecipient> recipients;

	public int Count => recipients.Count;

	public bool IsReadOnly => false;

	public CmsRecipientCollection()
	{
		recipients = new List<CmsRecipient>();
	}

	public void Add(CmsRecipient recipient)
	{
		if (recipient == null)
		{
			throw new ArgumentNullException("recipient");
		}
		recipients.Add(recipient);
	}

	public void Clear()
	{
		recipients.Clear();
	}

	public bool Contains(CmsRecipient recipient)
	{
		if (recipient == null)
		{
			throw new ArgumentNullException("recipient");
		}
		return recipients.Contains(recipient);
	}

	public void CopyTo(CmsRecipient[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0 || arrayIndex + Count > array.Length)
		{
			throw new ArgumentOutOfRangeException("arrayIndex");
		}
		recipients.CopyTo(array, arrayIndex);
	}

	public bool Remove(CmsRecipient recipient)
	{
		if (recipient == null)
		{
			throw new ArgumentNullException("recipient");
		}
		return recipients.Remove(recipient);
	}

	public IEnumerator<CmsRecipient> GetEnumerator()
	{
		return recipients.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return recipients.GetEnumerator();
	}
}
