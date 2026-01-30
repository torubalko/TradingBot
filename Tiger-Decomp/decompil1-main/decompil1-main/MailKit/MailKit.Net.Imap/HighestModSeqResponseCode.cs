namespace MailKit.Net.Imap;

internal class HighestModSeqResponseCode : ImapResponseCode
{
	public ulong HighestModSeq;

	internal HighestModSeqResponseCode(ImapResponseCodeType type)
		: base(type, isError: false)
	{
	}
}
