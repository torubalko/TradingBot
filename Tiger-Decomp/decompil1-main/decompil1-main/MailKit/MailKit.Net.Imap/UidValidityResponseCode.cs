namespace MailKit.Net.Imap;

internal class UidValidityResponseCode : ImapResponseCode
{
	public uint UidValidity;

	internal UidValidityResponseCode(ImapResponseCodeType type)
		: base(type, isError: false)
	{
	}
}
