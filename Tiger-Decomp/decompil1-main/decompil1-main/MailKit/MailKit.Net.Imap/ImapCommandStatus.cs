namespace MailKit.Net.Imap;

internal enum ImapCommandStatus
{
	Created,
	Queued,
	Active,
	Complete,
	Error
}
