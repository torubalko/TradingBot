namespace MailKit.Net.Imap;

internal class NoUpdateResponseCode : ImapResponseCode
{
	public string Tag;

	internal NoUpdateResponseCode(ImapResponseCodeType type)
		: base(type, isError: true)
	{
	}
}
