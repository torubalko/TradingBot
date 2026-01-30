namespace MailKit.Net.Imap;

internal class BadUrlResponseCode : ImapResponseCode
{
	public string BadUrl;

	internal BadUrlResponseCode(ImapResponseCodeType type)
		: base(type, isError: true)
	{
	}
}
