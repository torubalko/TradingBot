namespace MailKit.Net.Imap;

internal enum ImapTokenType
{
	NoData = -7,
	Error = -6,
	Nil = -5,
	Atom = -4,
	Flag = -3,
	QString = -2,
	Literal = -1,
	Eoln = 10,
	OpenParen = 40,
	CloseParen = 41,
	Asterisk = 42,
	OpenBracket = 91,
	CloseBracket = 93
}
