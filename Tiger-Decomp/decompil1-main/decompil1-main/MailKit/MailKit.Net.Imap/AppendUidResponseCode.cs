namespace MailKit.Net.Imap;

internal class AppendUidResponseCode : UidValidityResponseCode
{
	public UniqueIdSet UidSet;

	internal AppendUidResponseCode(ImapResponseCodeType type)
		: base(type)
	{
	}
}
