namespace MailKit.Net.Imap;

internal class PermanentFlagsResponseCode : ImapResponseCode
{
	public MessageFlags Flags;

	internal PermanentFlagsResponseCode(ImapResponseCodeType type)
		: base(type, isError: false)
	{
	}
}
