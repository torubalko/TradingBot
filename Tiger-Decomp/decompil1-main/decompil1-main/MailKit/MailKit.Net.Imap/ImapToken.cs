using System.Globalization;
using MimeKit.Utils;

namespace MailKit.Net.Imap;

internal class ImapToken
{
	public readonly ImapTokenType Type;

	public readonly object Value;

	public ImapToken(ImapTokenType type, object value = null)
	{
		Value = value;
		Type = type;
	}

	public override string ToString()
	{
		return Type switch
		{
			ImapTokenType.NoData => "<no data>", 
			ImapTokenType.Nil => "NIL", 
			ImapTokenType.Atom => (string)Value, 
			ImapTokenType.Flag => (string)Value, 
			ImapTokenType.QString => MimeUtils.Quote((string)Value), 
			ImapTokenType.Literal => string.Format(CultureInfo.InvariantCulture, "{{{0}}}", (int)Value), 
			ImapTokenType.Eoln => "'\\n'", 
			ImapTokenType.OpenParen => "'('", 
			ImapTokenType.CloseParen => "')'", 
			ImapTokenType.Asterisk => "'*'", 
			ImapTokenType.OpenBracket => "'['", 
			ImapTokenType.CloseBracket => "']'", 
			_ => string.Format(CultureInfo.InvariantCulture, "[{0}: '{1}']", Type, Value), 
		};
	}
}
