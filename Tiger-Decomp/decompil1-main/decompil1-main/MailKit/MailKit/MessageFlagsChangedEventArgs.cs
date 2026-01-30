using System;
using System.Collections.Generic;

namespace MailKit;

public class MessageFlagsChangedEventArgs : MessageEventArgs
{
	public MessageFlags Flags { get; internal set; }

	public HashSet<string> Keywords { get; private set; }

	[Obsolete("Use Keywords instead.")]
	public HashSet<string> UserFlags => Keywords;

	public ulong? ModSeq { get; internal set; }

	internal MessageFlagsChangedEventArgs(int index)
		: base(index)
	{
		Keywords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
	}

	public MessageFlagsChangedEventArgs(int index, MessageFlags flags)
		: base(index)
	{
		Keywords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		Flags = flags;
	}

	public MessageFlagsChangedEventArgs(int index, MessageFlags flags, HashSet<string> keywords)
		: base(index)
	{
		if (keywords == null)
		{
			throw new ArgumentNullException("keywords");
		}
		Keywords = keywords;
		Flags = flags;
	}

	public MessageFlagsChangedEventArgs(int index, MessageFlags flags, ulong modseq)
		: base(index)
	{
		Keywords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		ModSeq = modseq;
		Flags = flags;
	}

	public MessageFlagsChangedEventArgs(int index, MessageFlags flags, HashSet<string> keywords, ulong modseq)
		: base(index)
	{
		if (keywords == null)
		{
			throw new ArgumentNullException("keywords");
		}
		Keywords = keywords;
		ModSeq = modseq;
		Flags = flags;
	}

	public MessageFlagsChangedEventArgs(int index, UniqueId uid, MessageFlags flags)
		: base(index, uid)
	{
		Keywords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		Flags = flags;
	}

	public MessageFlagsChangedEventArgs(int index, UniqueId uid, MessageFlags flags, HashSet<string> keywords)
		: base(index, uid)
	{
		if (keywords == null)
		{
			throw new ArgumentNullException("keywords");
		}
		Keywords = keywords;
		Flags = flags;
	}

	public MessageFlagsChangedEventArgs(int index, UniqueId uid, MessageFlags flags, ulong modseq)
		: base(index, uid)
	{
		Keywords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		ModSeq = modseq;
		Flags = flags;
	}

	public MessageFlagsChangedEventArgs(int index, UniqueId uid, MessageFlags flags, HashSet<string> keywords, ulong modseq)
		: base(index, uid)
	{
		if (keywords == null)
		{
			throw new ArgumentNullException("keywords");
		}
		Keywords = keywords;
		ModSeq = modseq;
		Flags = flags;
	}
}
