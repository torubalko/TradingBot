namespace MailKit.Net.Imap;

internal class UndefinedFilterResponseCode : ImapResponseCode
{
	public string Name;

	internal UndefinedFilterResponseCode(ImapResponseCodeType type)
		: base(type, isError: true)
	{
	}
}
