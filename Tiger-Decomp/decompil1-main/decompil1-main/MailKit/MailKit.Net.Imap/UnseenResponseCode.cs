namespace MailKit.Net.Imap;

internal class UnseenResponseCode : ImapResponseCode
{
	public int Index;

	internal UnseenResponseCode(ImapResponseCodeType type)
		: base(type, isError: false)
	{
	}
}
