namespace MailKit.Net.Imap;

internal class MetadataResponseCode : ImapResponseCode
{
	public MetadataResponseCodeSubType SubType;

	public uint Value;

	internal MetadataResponseCode(ImapResponseCodeType type)
		: base(type, isError: true)
	{
	}
}
