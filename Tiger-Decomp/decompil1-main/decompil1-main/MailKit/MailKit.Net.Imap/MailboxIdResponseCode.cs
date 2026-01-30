namespace MailKit.Net.Imap;

internal class MailboxIdResponseCode : ImapResponseCode
{
	public string MailboxId;

	internal MailboxIdResponseCode(ImapResponseCodeType type)
		: base(type, isError: false)
	{
	}
}
