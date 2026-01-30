using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MailKit;

public class MessageLabelsChangedEventArgs : MessageEventArgs
{
	public IList<string> Labels { get; internal set; }

	public ulong? ModSeq { get; internal set; }

	internal MessageLabelsChangedEventArgs(int index)
		: base(index)
	{
	}

	public MessageLabelsChangedEventArgs(int index, IList<string> labels)
		: base(index)
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		Labels = new ReadOnlyCollection<string>(labels);
	}

	public MessageLabelsChangedEventArgs(int index, IList<string> labels, ulong modseq)
		: base(index)
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		Labels = new ReadOnlyCollection<string>(labels);
		ModSeq = modseq;
	}

	public MessageLabelsChangedEventArgs(int index, UniqueId uid, IList<string> labels)
		: base(index, uid)
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		Labels = new ReadOnlyCollection<string>(labels);
	}

	public MessageLabelsChangedEventArgs(int index, UniqueId uid, IList<string> labels, ulong modseq)
		: base(index, uid)
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		Labels = new ReadOnlyCollection<string>(labels);
		ModSeq = modseq;
	}
}
