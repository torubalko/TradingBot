namespace MailKit.Net.Imap;

internal class AnnotationsResponseCode : ImapResponseCode
{
	public AnnotationAccess Access;

	public AnnotationScope Scopes;

	public uint MaxSize;

	internal AnnotationsResponseCode(ImapResponseCodeType type)
		: base(type, isError: false)
	{
	}
}
