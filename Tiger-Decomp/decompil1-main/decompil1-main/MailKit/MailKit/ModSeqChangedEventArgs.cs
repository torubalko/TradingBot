namespace MailKit;

public class ModSeqChangedEventArgs : MessageEventArgs
{
	public ulong ModSeq { get; internal set; }

	internal ModSeqChangedEventArgs(int index)
		: base(index)
	{
	}

	public ModSeqChangedEventArgs(int index, ulong modseq)
		: base(index)
	{
		ModSeq = modseq;
	}

	public ModSeqChangedEventArgs(int index, UniqueId uid, ulong modseq)
		: base(index, uid)
	{
		ModSeq = modseq;
	}
}
