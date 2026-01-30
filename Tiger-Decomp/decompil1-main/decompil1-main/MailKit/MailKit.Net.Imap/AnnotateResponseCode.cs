namespace MailKit.Net.Imap;

internal class AnnotateResponseCode : ImapResponseCode
{
	public AnnotateResponseCodeSubType SubType;

	internal AnnotateResponseCode(ImapResponseCodeType type)
		: base(type, isError: true)
	{
	}
}
