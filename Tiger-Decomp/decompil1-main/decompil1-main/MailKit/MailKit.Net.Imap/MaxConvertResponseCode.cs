namespace MailKit.Net.Imap;

internal class MaxConvertResponseCode : ImapResponseCode
{
	public uint MaxConvert;

	internal MaxConvertResponseCode(ImapResponseCodeType type)
		: base(type, isError: true)
	{
	}
}
