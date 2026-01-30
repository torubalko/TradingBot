using System;

namespace MailKit;

public class MessageEventArgs : EventArgs
{
	public int Index { get; private set; }

	public UniqueId? UniqueId { get; internal set; }

	public MessageEventArgs(int index)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		Index = index;
	}

	public MessageEventArgs(int index, UniqueId uid)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		Index = index;
		UniqueId = uid;
	}
}
