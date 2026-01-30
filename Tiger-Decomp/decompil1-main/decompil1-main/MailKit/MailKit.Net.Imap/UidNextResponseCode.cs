namespace MailKit.Net.Imap;

internal class UidNextResponseCode : ImapResponseCode
{
	public UniqueId Uid;

	internal UidNextResponseCode(ImapResponseCodeType type)
		: base(type, isError: false)
	{
	}
}
