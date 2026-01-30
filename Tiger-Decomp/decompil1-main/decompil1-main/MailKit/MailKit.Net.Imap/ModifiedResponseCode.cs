namespace MailKit.Net.Imap;

internal class ModifiedResponseCode : ImapResponseCode
{
	public UniqueIdSet UidSet;

	internal ModifiedResponseCode(ImapResponseCodeType type)
		: base(type, isError: false)
	{
	}
}
