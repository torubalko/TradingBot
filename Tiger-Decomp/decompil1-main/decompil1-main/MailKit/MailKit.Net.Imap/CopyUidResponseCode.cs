namespace MailKit.Net.Imap;

internal class CopyUidResponseCode : UidValidityResponseCode
{
	public UniqueIdSet SrcUidSet;

	public UniqueIdSet DestUidSet;

	internal CopyUidResponseCode(ImapResponseCodeType type)
		: base(type)
	{
	}
}
