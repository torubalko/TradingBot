namespace MailKit.Net.Imap;

internal class NewNameResponseCode : ImapResponseCode
{
	public string OldName;

	public string NewName;

	internal NewNameResponseCode(ImapResponseCodeType type)
		: base(type, isError: false)
	{
	}
}
