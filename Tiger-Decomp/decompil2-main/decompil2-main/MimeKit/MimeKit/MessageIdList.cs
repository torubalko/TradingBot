using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MimeKit;

public class MessageIdList : IList<string>, ICollection<string>, IEnumerable<string>, IEnumerable
{
	private readonly List<string> references;

	public string this[int index]
	{
		get
		{
			return references[index];
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!(references[index] == value))
			{
				references[index] = ValidateMessageId(value);
				OnChanged();
			}
		}
	}

	public int Count => references.Count;

	public bool IsReadOnly => false;

	internal event EventHandler Changed;

	public MessageIdList()
	{
		references = new List<string>();
	}

	public MessageIdList Clone()
	{
		MessageIdList messageIdList = new MessageIdList();
		for (int i = 0; i < references.Count; i++)
		{
			messageIdList.references.Add(references[i]);
		}
		return messageIdList;
	}

	public int IndexOf(string messageId)
	{
		if (messageId == null)
		{
			throw new ArgumentNullException("messageId");
		}
		return references.IndexOf(messageId);
	}

	private static string ValidateMessageId(string messageId)
	{
		if (messageId.Length < 2 || messageId[0] != '<' || messageId[messageId.Length - 1] != '>')
		{
			return messageId;
		}
		return messageId.Substring(1, messageId.Length - 2);
	}

	public void Insert(int index, string messageId)
	{
		if (messageId == null)
		{
			throw new ArgumentNullException("messageId");
		}
		references.Insert(index, ValidateMessageId(messageId));
		OnChanged();
	}

	public void RemoveAt(int index)
	{
		references.RemoveAt(index);
		OnChanged();
	}

	public void Add(string messageId)
	{
		if (messageId == null)
		{
			throw new ArgumentNullException("messageId");
		}
		references.Add(ValidateMessageId(messageId));
		OnChanged();
	}

	public void AddRange(IEnumerable<string> items)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		foreach (string item in items)
		{
			references.Add(ValidateMessageId(item));
		}
		OnChanged();
	}

	public void Clear()
	{
		references.Clear();
		OnChanged();
	}

	public bool Contains(string messageId)
	{
		if (messageId == null)
		{
			throw new ArgumentNullException("messageId");
		}
		return references.Contains(messageId);
	}

	public void CopyTo(string[] array, int arrayIndex)
	{
		references.CopyTo(array, arrayIndex);
	}

	public bool Remove(string messageId)
	{
		if (messageId == null)
		{
			throw new ArgumentNullException("messageId");
		}
		if (references.Remove(messageId))
		{
			OnChanged();
			return true;
		}
		return false;
	}

	public IEnumerator<string> GetEnumerator()
	{
		return references.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return references.GetEnumerator();
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < references.Count; i++)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('<');
			stringBuilder.Append(references[i]);
			stringBuilder.Append('>');
		}
		return stringBuilder.ToString();
	}

	private void OnChanged()
	{
		if (this.Changed != null)
		{
			this.Changed(this, EventArgs.Empty);
		}
	}
}
